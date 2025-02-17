using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public partial class XiakeUIPanel
{
	private Image PreImage_Image;
	private Text NameText_Text;
	private Text InfoText_Text;
	private Text SkillText_Text;
	private Text ItemsText_Text;
	private Button ButtonSelectWeapon_Button;
	private Button ButtonSelectArmor_Button;
	private Button ButtonSelectBook_Button;
	private Button LeaveButton_Button;
	private RectTransform RoleParent_RectTransform;
	private Button BackButton_Button;

	public void InitTrans()
	{
		PreImage_Image = transform.Find("MainContent/HeadAvataPre/Mask/PreImage").GetComponent<Image>();
		NameText_Text = transform.Find("MainContent/NameText").GetComponent<Text>();
		InfoText_Text = transform.Find("MainContent/InfoText").GetComponent<Text>();
		SkillText_Text = transform.Find("MainContent/SkillText").GetComponent<Text>();
		ItemsText_Text = transform.Find("MainContent/ItemsText").GetComponent<Text>();
		ButtonSelectWeapon_Button = transform.Find("MainContent/ButtonSelectWeapon").GetComponent<Button>();
		ButtonSelectArmor_Button = transform.Find("MainContent/ButtonSelectArmor").GetComponent<Button>();
		ButtonSelectBook_Button = transform.Find("MainContent/ButtonSelectBook").GetComponent<Button>();
		LeaveButton_Button = transform.Find("MainContent/LeaveButton").GetComponent<Button>();
		RoleParent_RectTransform = transform.Find("RoleScroll/Viewport/RoleParent").GetComponent<RectTransform>();
		BackButton_Button = transform.Find("BackButton").GetComponent<Button>();

	}
}

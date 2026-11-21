using System;
using Aki.Config;

// Token: 0x02001C6A RID: 7274
public class RoleHandBookPreviewView : RolePreviewDescribeTabView
{
	// Token: 0x060120D2 RID: 73938 RVA: 0x0054F1EC File Offset: 0x0054D3EC
	protected override void SetCharacterVoiceInfo()
	{
		RoleInfo roleConfig = RoleModel.Instance.GetCurSelectMainRoleInstance().GetRoleConfig();
		this.CharacterVoiceTitleText.SetUIActive(true);
		this.CharacterVoiceNameText.SetUIActive(true);
		LguiUtil.Instance.SetLocalText(this.CharacterVoiceTitleText, "CharacterVoice", Array.Empty<object>());
		this.CharacterVoiceNameText.ShowTextNew(roleConfig.CharacterVoice);
	}

	// Token: 0x060120D3 RID: 73939 RVA: 0x0054F250 File Offset: 0x0054D450
	protected override void SetAttributeInfo()
	{
		int elementId = RoleModel.Instance.GetCurSelectMainRoleInstance().GetRoleConfig().ElementId;
		ElementInfo value = ElementInfoConfig.Instance.GetElementInfo(elementId).Value;
		this.AttributeIconTexture.SetUIActive(true);
		this.AttributeText.SetUIActive(true);
		base.SetTextureByPath(value.Icon, this.AttributeIconTexture, null, null);
		this.AttributeText.ShowTextNew(value.Name);
	}
}

using System;
using Aki.Config;

// Token: 0x0200277F RID: 10111
public class RoleHandBookPreviewView : RolePreviewDescribeTabView
{
	// Token: 0x06014BEF RID: 84975 RVA: 0x00540360 File Offset: 0x0053E560
	protected override void SetCharacterVoiceInfo()
	{
		RoleInfo roleConfig = RoleModel.Instance.GetCurSelectMainRoleInstance().GetRoleConfig();
		this.CharacterVoiceTitleText.SetUIActive(true);
		this.CharacterVoiceNameText.SetUIActive(true);
		LguiUtil.Instance.SetLocalText(this.CharacterVoiceTitleText, "CharacterVoice", Array.Empty<object>());
		this.CharacterVoiceNameText.ShowTextNew(roleConfig.CharacterVoice);
	}

	// Token: 0x06014BF0 RID: 84976 RVA: 0x005403C4 File Offset: 0x0053E5C4
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

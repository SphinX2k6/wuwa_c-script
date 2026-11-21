using System;
using Aki.Config;
using CSharpScript.Game.Module.PhoneMessage;

// Token: 0x020019FA RID: 6650
public class PhoneMsgThemeItemData
{
	// Token: 0x0601060A RID: 67082 RVA: 0x004C89A8 File Offset: 0x004C6BA8
	public ChatTheme GetConfig()
	{
		return PhoneMsgConfig.Instance.GetChatThemeConfig(this.ThemeId).Value;
	}

	// Token: 0x0601060B RID: 67083 RVA: 0x004C89CD File Offset: 0x004C6BCD
	public bool IsHasRedDot()
	{
		return PhoneMsgModel.Instance.IsChatShowHasRedDotById(this.ThemeId);
	}

	// Token: 0x0400913F RID: 37183
	public int ThemeId;

	// Token: 0x04009140 RID: 37184
	public bool IsSelected;

	// Token: 0x04009141 RID: 37185
	public bool IsUsing;

	// Token: 0x04009142 RID: 37186
	public bool IsUnlocked;
}

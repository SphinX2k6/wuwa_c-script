using System;
using Aki.Config;
using CSharpScript.Game.Module.PhoneMessage;

// Token: 0x02002513 RID: 9491
public class PhoneMsgThemeItemData
{
	// Token: 0x0601314B RID: 78155 RVA: 0x004BAC44 File Offset: 0x004B8E44
	public ChatTheme GetConfig()
	{
		return PhoneMsgConfig.Instance.GetChatThemeConfig(this.ThemeId).Value;
	}

	// Token: 0x0601314C RID: 78156 RVA: 0x004BAC69 File Offset: 0x004B8E69
	public bool IsHasRedDot()
	{
		return PhoneMsgModel.Instance.IsChatShowHasRedDotById(this.ThemeId);
	}

	// Token: 0x04008FEB RID: 36843
	public int ThemeId;

	// Token: 0x04008FEC RID: 36844
	public bool IsSelected;

	// Token: 0x04008FED RID: 36845
	public bool IsUsing;

	// Token: 0x04008FEE RID: 36846
	public bool IsUnlocked;
}

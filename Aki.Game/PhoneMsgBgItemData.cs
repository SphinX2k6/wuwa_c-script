using System;
using Aki.Config;
using CSharpScript.Game.Module.PhoneMessage;

// Token: 0x020019F9 RID: 6649
public class PhoneMsgBgItemData
{
	// Token: 0x06010607 RID: 67079 RVA: 0x004C8968 File Offset: 0x004C6B68
	public ChatBg GetConfig()
	{
		return PhoneMsgConfig.Instance.GetChatBgConfig(this.BgId).Value;
	}

	// Token: 0x06010608 RID: 67080 RVA: 0x004C898D File Offset: 0x004C6B8D
	public bool IsHasRedDot()
	{
		return PhoneMsgModel.Instance.IsChatShowHasRedDotById(this.BgId);
	}

	// Token: 0x0400913B RID: 37179
	public int BgId;

	// Token: 0x0400913C RID: 37180
	public bool IsSelected;

	// Token: 0x0400913D RID: 37181
	public bool IsUsing;

	// Token: 0x0400913E RID: 37182
	public bool IsUnlocked;
}

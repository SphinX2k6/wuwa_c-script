using System;
using Aki.Config;
using CSharpScript.Game.Module.PhoneMessage;

// Token: 0x020019FB RID: 6651
public class PhoneMsgCharmItemData
{
	// Token: 0x0601060D RID: 67085 RVA: 0x004C89E8 File Offset: 0x004C6BE8
	public ChatCharm GetConfig()
	{
		return PhoneMsgConfig.Instance.GetChatCharmConfig(this.CharmId).Value;
	}

	// Token: 0x0601060E RID: 67086 RVA: 0x004C8A0D File Offset: 0x004C6C0D
	public bool IsHasRedDot()
	{
		return PhoneMsgModel.Instance.IsChatShowHasRedDotById(this.CharmId);
	}

	// Token: 0x04009143 RID: 37187
	public int CharmId;

	// Token: 0x04009144 RID: 37188
	public bool IsSelected;

	// Token: 0x04009145 RID: 37189
	public bool IsUsing;

	// Token: 0x04009146 RID: 37190
	public bool IsUnlocked;
}

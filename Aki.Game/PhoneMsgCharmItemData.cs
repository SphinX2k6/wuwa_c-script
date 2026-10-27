using System;
using Aki.Config;
using CSharpScript.Game.Module.PhoneMessage;

// Token: 0x02002514 RID: 9492
public class PhoneMsgCharmItemData
{
	// Token: 0x0601314E RID: 78158 RVA: 0x004BAC84 File Offset: 0x004B8E84
	public ChatCharm GetConfig()
	{
		return PhoneMsgConfig.Instance.GetChatCharmConfig(this.CharmId).Value;
	}

	// Token: 0x0601314F RID: 78159 RVA: 0x004BACA9 File Offset: 0x004B8EA9
	public bool IsHasRedDot()
	{
		return PhoneMsgModel.Instance.IsChatShowHasRedDotById(this.CharmId);
	}

	// Token: 0x04008FEF RID: 36847
	public int CharmId;

	// Token: 0x04008FF0 RID: 36848
	public bool IsSelected;

	// Token: 0x04008FF1 RID: 36849
	public bool IsUsing;

	// Token: 0x04008FF2 RID: 36850
	public bool IsUnlocked;
}

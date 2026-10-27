using System;
using Aki.Config;
using CSharpScript.Game.Module.PhoneMessage;

// Token: 0x02002511 RID: 9489
public class PhoneMsgDialogItemData
{
	// Token: 0x06013144 RID: 78148 RVA: 0x004BABBC File Offset: 0x004B8DBC
	public ChatDialog GetConfig()
	{
		return PhoneMsgConfig.Instance.GetChatDialogConfig(this.DialogId).Value;
	}

	// Token: 0x06013145 RID: 78149 RVA: 0x004BABE1 File Offset: 0x004B8DE1
	public bool IsHasRedDot()
	{
		return PhoneMsgModel.Instance.IsChatShowHasRedDotById(this.DialogId);
	}

	// Token: 0x04008FE3 RID: 36835
	public int DialogId;

	// Token: 0x04008FE4 RID: 36836
	public bool IsSelected;

	// Token: 0x04008FE5 RID: 36837
	public bool IsUsing;

	// Token: 0x04008FE6 RID: 36838
	public bool IsUnlocked;
}

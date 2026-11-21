using System;
using Aki.Config;
using CSharpScript.Game.Module.PhoneMessage;

// Token: 0x020019F8 RID: 6648
public class PhoneMsgDialogItemData
{
	// Token: 0x06010603 RID: 67075 RVA: 0x004C8920 File Offset: 0x004C6B20
	public ChatDialog GetConfig()
	{
		return PhoneMsgConfig.Instance.GetChatDialogConfig(this.DialogId).Value;
	}

	// Token: 0x06010604 RID: 67076 RVA: 0x004C8945 File Offset: 0x004C6B45
	public bool IsHasRedDot()
	{
		return PhoneMsgModel.Instance.IsChatShowHasRedDotById(this.DialogId);
	}

	// Token: 0x04009137 RID: 37175
	public int DialogId;

	// Token: 0x04009138 RID: 37176
	public bool IsSelected;

	// Token: 0x04009139 RID: 37177
	public bool IsUsing;

	// Token: 0x0400913A RID: 37178
	public bool IsUnlocked;
}

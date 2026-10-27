using System;
using System.Runtime.CompilerServices;

// Token: 0x02002525 RID: 9509
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class SettingViewLeftDialogItemData : MultiTemplateGridDataBase<PhoneMsgDialogItemData, PhoneMsgDialogItem>
{
	// Token: 0x06013200 RID: 78336 RVA: 0x004BF75B File Offset: 0x004BD95B
	public override int GetTemplateIndex()
	{
		return 1;
	}

	// Token: 0x06013201 RID: 78337 RVA: 0x004BF75E File Offset: 0x004BD95E
	public override PhoneMsgDialogItem CreateProxy()
	{
		return new PhoneMsgDialogItem
		{
			OnToggleCallBack = this.OnToggleCallBack
		};
	}

	// Token: 0x06013202 RID: 78338 RVA: 0x004BF771 File Offset: 0x004BD971
	public SettingViewLeftDialogItemData(PhoneMsgDialogItemData dialogData)
	{
		base.Data = dialogData;
	}

	// Token: 0x06013203 RID: 78339 RVA: 0x004BF780 File Offset: 0x004BD980
	public int GetDialogId()
	{
		return base.Data.DialogId;
	}

	// Token: 0x04009067 RID: 36967
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, PhoneMsgDialogItemData> OnToggleCallBack;
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x02001A0C RID: 6668
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class SettingViewLeftDialogItemData : MultiTemplateGridDataBase<PhoneMsgDialogItemData, PhoneMsgDialogItem>
{
	// Token: 0x060106C0 RID: 67264 RVA: 0x004CD467 File Offset: 0x004CB667
	public override int GetTemplateIndex()
	{
		return 1;
	}

	// Token: 0x060106C1 RID: 67265 RVA: 0x004CD46A File Offset: 0x004CB66A
	public override PhoneMsgDialogItem CreateProxy()
	{
		return new PhoneMsgDialogItem
		{
			OnToggleCallBack = this.OnToggleCallBack
		};
	}

	// Token: 0x060106C2 RID: 67266 RVA: 0x004CD47D File Offset: 0x004CB67D
	public SettingViewLeftDialogItemData(PhoneMsgDialogItemData dialogData)
	{
		base.Data = dialogData;
	}

	// Token: 0x060106C3 RID: 67267 RVA: 0x004CD48C File Offset: 0x004CB68C
	public int GetDialogId()
	{
		return base.Data.DialogId;
	}

	// Token: 0x040091BC RID: 37308
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, PhoneMsgDialogItemData> OnToggleCallBack;
}

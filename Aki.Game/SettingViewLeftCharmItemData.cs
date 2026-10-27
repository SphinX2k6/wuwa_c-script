using System;
using System.Runtime.CompilerServices;

// Token: 0x02002528 RID: 9512
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class SettingViewLeftCharmItemData : MultiTemplateGridDataBase<PhoneMsgCharmItemData, PhoneMsgCharmItem>
{
	// Token: 0x0601320C RID: 78348 RVA: 0x004BF7F1 File Offset: 0x004BD9F1
	public override int GetTemplateIndex()
	{
		return 3;
	}

	// Token: 0x0601320D RID: 78349 RVA: 0x004BF7F4 File Offset: 0x004BD9F4
	public override PhoneMsgCharmItem CreateProxy()
	{
		return new PhoneMsgCharmItem
		{
			OnToggleCallBack = this.OnToggleCallBack
		};
	}

	// Token: 0x0601320E RID: 78350 RVA: 0x004BF807 File Offset: 0x004BDA07
	public SettingViewLeftCharmItemData(PhoneMsgCharmItemData charmData)
	{
		base.Data = charmData;
	}

	// Token: 0x0601320F RID: 78351 RVA: 0x004BF816 File Offset: 0x004BDA16
	public int GetCharmId()
	{
		return base.Data.CharmId;
	}

	// Token: 0x0400906C RID: 36972
	public int Index;

	// Token: 0x0400906D RID: 36973
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, PhoneMsgCharmItemData> OnToggleCallBack;
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x02002530 RID: 9520
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class TipsChatGridData : MultiTemplateGridDataBase<PhoneMsgChatData, TipsChatItem>
{
	// Token: 0x06013245 RID: 78405 RVA: 0x004C0676 File Offset: 0x004BE876
	public TipsChatGridData(PhoneMsgChatData data)
	{
		base.Data = data;
	}

	// Token: 0x06013246 RID: 78406 RVA: 0x004C0685 File Offset: 0x004BE885
	public override int GetTemplateIndex()
	{
		return 2;
	}

	// Token: 0x06013247 RID: 78407 RVA: 0x004C0688 File Offset: 0x004BE888
	public override TipsChatItem CreateProxy()
	{
		return new TipsChatItem();
	}
}

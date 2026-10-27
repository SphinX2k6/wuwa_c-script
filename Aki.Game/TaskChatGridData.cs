using System;
using System.Runtime.CompilerServices;

// Token: 0x02002534 RID: 9524
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class TaskChatGridData : MultiTemplateGridDataBase<PhoneMsgChatData, TaskChatItem>
{
	// Token: 0x06013252 RID: 78418 RVA: 0x004C097F File Offset: 0x004BEB7F
	public TaskChatGridData(PhoneMsgChatData data)
	{
		base.Data = data;
	}

	// Token: 0x06013253 RID: 78419 RVA: 0x004C098E File Offset: 0x004BEB8E
	public override int GetTemplateIndex()
	{
		return 3;
	}

	// Token: 0x06013254 RID: 78420 RVA: 0x004C0991 File Offset: 0x004BEB91
	public override TaskChatItem CreateProxy()
	{
		return new TaskChatItem();
	}
}

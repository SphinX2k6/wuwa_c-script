using System;
using System.Runtime.CompilerServices;

// Token: 0x02001A1B RID: 6683
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class TaskChatGridData : MultiTemplateGridDataBase<PhoneMsgChatData, TaskChatItem>
{
	// Token: 0x06010716 RID: 67350 RVA: 0x004CE92B File Offset: 0x004CCB2B
	public TaskChatGridData(PhoneMsgChatData data)
	{
		base.Data = data;
	}

	// Token: 0x06010717 RID: 67351 RVA: 0x004CE93A File Offset: 0x004CCB3A
	public override int GetTemplateIndex()
	{
		return 3;
	}

	// Token: 0x06010718 RID: 67352 RVA: 0x004CE93D File Offset: 0x004CCB3D
	public override TaskChatItem CreateProxy()
	{
		return new TaskChatItem();
	}
}

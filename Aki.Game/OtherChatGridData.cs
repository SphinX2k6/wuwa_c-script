using System;
using System.Runtime.CompilerServices;

// Token: 0x0200253D RID: 9533
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class OtherChatGridData : MultiTemplateGridDataBase<PhoneMsgChatData, PhoneMsgOtherChatItem>
{
	// Token: 0x0601327A RID: 78458 RVA: 0x004C13AA File Offset: 0x004BF5AA
	public OtherChatGridData(PhoneMsgChatData data)
	{
		base.Data = data;
	}

	// Token: 0x0601327B RID: 78459 RVA: 0x004C13B9 File Offset: 0x004BF5B9
	public override int GetTemplateIndex()
	{
		return 0;
	}

	// Token: 0x0601327C RID: 78460 RVA: 0x004C13BC File Offset: 0x004BF5BC
	public override PhoneMsgOtherChatItem CreateProxy()
	{
		return new PhoneMsgOtherChatItem
		{
			OnItemClickDelegate = this.OnItemClickDelegate
		};
	}

	// Token: 0x040090B1 RID: 37041
	[Nullable(2)]
	public Action<int> OnItemClickDelegate;
}

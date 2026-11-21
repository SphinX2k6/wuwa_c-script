using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200118F RID: 4495
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CollectionTypeItemData : MultiTemplateGridDataBase<MotorFightItemType, CollectionTypeItem>
{
	// Token: 0x0600B34B RID: 45899 RVA: 0x0034FDC1 File Offset: 0x0034DFC1
	public override int GetTemplateIndex()
	{
		return 0;
	}

	// Token: 0x0600B34C RID: 45900 RVA: 0x0034FDC4 File Offset: 0x0034DFC4
	public override CollectionTypeItem CreateProxy()
	{
		return new CollectionTypeItem();
	}
}

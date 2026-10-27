using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001CCD RID: 7373
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CollectionTypeItemData : MultiTemplateGridDataBase<MotorFightItemType, CollectionTypeItem>
{
	// Token: 0x0600DF2E RID: 57134 RVA: 0x00344399 File Offset: 0x00342599
	public override int GetTemplateIndex()
	{
		return 0;
	}

	// Token: 0x0600DF2F RID: 57135 RVA: 0x0034439C File Offset: 0x0034259C
	public override CollectionTypeItem CreateProxy()
	{
		return new CollectionTypeItem();
	}
}

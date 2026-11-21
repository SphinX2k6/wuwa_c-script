using System;
using System.Runtime.CompilerServices;

// Token: 0x0200118B RID: 4491
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class CollectionGridItemData : MultiTemplateGridDataBase<MotorcycleArrowCollectionItemData, CollectionGridItem>
{
	// Token: 0x0600B335 RID: 45877 RVA: 0x0034F8FA File Offset: 0x0034DAFA
	public override int GetTemplateIndex()
	{
		return 1;
	}

	// Token: 0x0600B336 RID: 45878 RVA: 0x0034F900 File Offset: 0x0034DB00
	public override CollectionGridItem CreateProxy()
	{
		CollectionGridItem proxy = new CollectionGridItem();
		proxy.OnClickCb = delegate(MotorcycleArrowCollectionItemData data)
		{
			this.OnClickCb(data, proxy);
		};
		return proxy;
	}

	// Token: 0x04006770 RID: 26480
	public Action<MotorcycleArrowCollectionItemData, CollectionGridItem> OnClickCb;
}

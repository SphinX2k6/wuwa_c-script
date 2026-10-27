using System;
using System.Runtime.CompilerServices;

// Token: 0x02001CC9 RID: 7369
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class CollectionGridItemData : MultiTemplateGridDataBase<MotorcycleArrowCollectionItemData, CollectionGridItem>
{
	// Token: 0x0600DF18 RID: 57112 RVA: 0x00343ED2 File Offset: 0x003420D2
	public override int GetTemplateIndex()
	{
		return 1;
	}

	// Token: 0x0600DF19 RID: 57113 RVA: 0x00343ED8 File Offset: 0x003420D8
	public override CollectionGridItem CreateProxy()
	{
		CollectionGridItem proxy = new CollectionGridItem();
		proxy.OnClickCb = delegate(MotorcycleArrowCollectionItemData data)
		{
			this.OnClickCb(data, proxy);
		};
		return proxy;
	}

	// Token: 0x04006691 RID: 26257
	public Action<MotorcycleArrowCollectionItemData, CollectionGridItem> OnClickCb;
}

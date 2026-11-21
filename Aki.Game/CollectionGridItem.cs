using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200118A RID: 4490
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CollectionGridItem : SyncGridProxyAbstract<MotorcycleArrowCollectionItemData>
{
	// Token: 0x0600B330 RID: 45872 RVA: 0x0034F86E File Offset: 0x0034DA6E
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x0600B331 RID: 45873 RVA: 0x0034F891 File Offset: 0x0034DA91
	protected override void OnStart()
	{
		base.OnStart();
		this.GridItem = new CollectionGridItemPanel();
		this.GridItem.CreateThenShowByActor(base.GetItem(0).GetOwner());
		this.GridItem.OnClickCallBack = this.OnClickCb;
	}

	// Token: 0x0600B332 RID: 45874 RVA: 0x0034F8CC File Offset: 0x0034DACC
	public override void Refresh(MotorcycleArrowCollectionItemData data)
	{
		CollectionGridItemPanel gridItem = this.GridItem;
		if (gridItem == null)
		{
			return;
		}
		gridItem.Refresh(data);
	}

	// Token: 0x0600B333 RID: 45875 RVA: 0x0034F8DF File Offset: 0x0034DADF
	public void SetToggleState(bool state)
	{
		CollectionGridItemPanel gridItem = this.GridItem;
		if (gridItem == null)
		{
			return;
		}
		gridItem.SetToggleState(state);
	}

	// Token: 0x0400676E RID: 26478
	[Nullable(2)]
	private CollectionGridItemPanel GridItem;

	// Token: 0x0400676F RID: 26479
	public Action<MotorcycleArrowCollectionItemData> OnClickCb;

	// Token: 0x02007450 RID: 29776
	[NullableContext(0)]
	private static class ECollectionGridItemComponents
	{
		// Token: 0x04025DC2 RID: 155074
		public const int ItemBaseGrid = 0;
	}
}

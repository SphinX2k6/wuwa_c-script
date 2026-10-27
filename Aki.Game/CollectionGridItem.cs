using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001CC8 RID: 7368
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CollectionGridItem : SyncGridProxyAbstract<MotorcycleArrowCollectionItemData>
{
	// Token: 0x0600DF13 RID: 57107 RVA: 0x00343E46 File Offset: 0x00342046
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x0600DF14 RID: 57108 RVA: 0x00343E69 File Offset: 0x00342069
	protected override void OnStart()
	{
		base.OnStart();
		this.GridItem = new CollectionGridItemPanel();
		this.GridItem.CreateThenShowByActor(base.GetItem(0).GetOwner());
		this.GridItem.OnClickCallBack = this.OnClickCb;
	}

	// Token: 0x0600DF15 RID: 57109 RVA: 0x00343EA4 File Offset: 0x003420A4
	public override void Refresh(MotorcycleArrowCollectionItemData data)
	{
		CollectionGridItemPanel gridItem = this.GridItem;
		if (gridItem == null)
		{
			return;
		}
		gridItem.Refresh(data);
	}

	// Token: 0x0600DF16 RID: 57110 RVA: 0x00343EB7 File Offset: 0x003420B7
	public void SetToggleState(bool state)
	{
		CollectionGridItemPanel gridItem = this.GridItem;
		if (gridItem == null)
		{
			return;
		}
		gridItem.SetToggleState(state);
	}

	// Token: 0x0400668F RID: 26255
	[Nullable(2)]
	private CollectionGridItemPanel GridItem;

	// Token: 0x04006690 RID: 26256
	public Action<MotorcycleArrowCollectionItemData> OnClickCb;

	// Token: 0x020082C7 RID: 33479
	[NullableContext(0)]
	private static class ECollectionGridItemComponents
	{
		// Token: 0x0402AA9A RID: 174746
		public const int ItemBaseGrid = 0;
	}
}

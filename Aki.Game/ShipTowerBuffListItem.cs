using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200299D RID: 10653
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerBuffListItem : GridProxyAbstract<ShipTowerBuffQuality>
{
	// Token: 0x0601615B RID: 90459 RVA: 0x00595760 File Offset: 0x00593960
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x0601615C RID: 90460 RVA: 0x005957BC File Offset: 0x005939BC
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerBuffListItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerBuffListItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601615D RID: 90461 RVA: 0x00595800 File Offset: 0x00593A00
	public override UniTask RefreshAsync(ShipTowerBuffQuality data, bool isSelected, int gridIndex)
	{
		ShipTowerBuffListItem.<RefreshAsync>d__8 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.data = data;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<ShipTowerBuffListItem.<RefreshAsync>d__8>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601615E RID: 90462 RVA: 0x0059584C File Offset: 0x00593A4C
	public override void Refresh(ShipTowerBuffQuality data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		GenericLayout<ShipTowerBuffItem, ShipTowerBuffData> itemLayout = this.ItemLayout;
		if (itemLayout != null)
		{
			ShipTowerBuffQuality itemData = this.ItemData;
			itemLayout.RefreshByData(((itemData != null) ? itemData.BuffList : null) ?? new List<ShipTowerBuffData>(), null, true);
		}
		base.GetText(0).ShowTextNew(this.ItemData.Title);
	}

	// Token: 0x0601615F RID: 90463 RVA: 0x005958A5 File Offset: 0x00593AA5
	private ShipTowerBuffItem CreateBuffItem()
	{
		return new ShipTowerBuffItem
		{
			OnItemClickCallback = this.OnItemClickCallback,
			GetStageIdCallback = this.GetStageIdCallback,
			AllComponentLoadedCallback = this.BuffComponentLoadedCallback
		};
	}

	// Token: 0x06016160 RID: 90464 RVA: 0x005958D0 File Offset: 0x00593AD0
	public void UpdateBuffInfo()
	{
		GenericLayout<ShipTowerBuffItem, ShipTowerBuffData> itemLayout = this.ItemLayout;
		List<ShipTowerBuffItem> list = (itemLayout != null) ? itemLayout.GetLayoutItemList() : null;
		if (list == null)
		{
			return;
		}
		for (int i = 0; i < list.Count; i++)
		{
			list[i].UpdateBuffInfo();
		}
	}

	// Token: 0x06016161 RID: 90465 RVA: 0x00595914 File Offset: 0x00593B14
	public void UpdateBuffSelected()
	{
		GenericLayout<ShipTowerBuffItem, ShipTowerBuffData> itemLayout = this.ItemLayout;
		List<ShipTowerBuffItem> list = (itemLayout != null) ? itemLayout.GetLayoutItemList() : null;
		if (list == null)
		{
			return;
		}
		for (int i = 0; i < list.Count; i++)
		{
			list[i].UpdateBuffSelected();
		}
	}

	// Token: 0x06016162 RID: 90466 RVA: 0x00595958 File Offset: 0x00593B58
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (this.ItemData == null || this.ItemData.BuffList.Count == 0)
		{
			return null;
		}
		if (configParams.Length != 3)
		{
			return null;
		}
		int num;
		if (!int.TryParse(configParams[2], out num) || num < 0 || num >= this.ItemData.BuffList.Count)
		{
			return null;
		}
		GenericLayout<ShipTowerBuffItem, ShipTowerBuffData> itemLayout = this.ItemLayout;
		UUIItem uuiitem = (itemLayout != null) ? itemLayout.GetItemByIndex(num) : null;
		if (uuiitem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			uuiitem,
			uuiitem
		};
	}

	// Token: 0x0400A49E RID: 42142
	[Nullable(2)]
	private ShipTowerBuffQuality ItemData;

	// Token: 0x0400A49F RID: 42143
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ShipTowerBuffItem, ShipTowerBuffData> ItemLayout;

	// Token: 0x0400A4A0 RID: 42144
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ShipTowerBuffData> OnItemClickCallback;

	// Token: 0x0400A4A1 RID: 42145
	[Nullable(2)]
	public Func<int?> GetStageIdCallback;

	// Token: 0x0400A4A2 RID: 42146
	[Nullable(2)]
	public Action BuffComponentLoadedCallback;

	// Token: 0x02008FA1 RID: 36769
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402E854 RID: 190548
		public const int TxtTitle = 0;

		// Token: 0x0402E855 RID: 190549
		public const int GridLayoutItemList = 1;

		// Token: 0x0402E856 RID: 190550
		public const int ItemItem = 2;
	}
}

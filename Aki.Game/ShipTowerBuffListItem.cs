using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F18 RID: 7960
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerBuffListItem : GridProxyAbstract<ShipTowerBuffQuality>
{
	// Token: 0x06013B61 RID: 80737 RVA: 0x005C0720 File Offset: 0x005BE920
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06013B62 RID: 80738 RVA: 0x005C077C File Offset: 0x005BE97C
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerBuffListItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerBuffListItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013B63 RID: 80739 RVA: 0x005C07C0 File Offset: 0x005BE9C0
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

	// Token: 0x06013B64 RID: 80740 RVA: 0x005C080C File Offset: 0x005BEA0C
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

	// Token: 0x06013B65 RID: 80741 RVA: 0x005C0865 File Offset: 0x005BEA65
	private ShipTowerBuffItem CreateBuffItem()
	{
		return new ShipTowerBuffItem
		{
			OnItemClickCallback = this.OnItemClickCallback,
			GetStageIdCallback = this.GetStageIdCallback,
			AllComponentLoadedCallback = this.BuffComponentLoadedCallback
		};
	}

	// Token: 0x06013B66 RID: 80742 RVA: 0x005C0890 File Offset: 0x005BEA90
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

	// Token: 0x06013B67 RID: 80743 RVA: 0x005C08D4 File Offset: 0x005BEAD4
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

	// Token: 0x06013B68 RID: 80744 RVA: 0x005C0918 File Offset: 0x005BEB18
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

	// Token: 0x0400A888 RID: 43144
	[Nullable(2)]
	private ShipTowerBuffQuality ItemData;

	// Token: 0x0400A889 RID: 43145
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ShipTowerBuffItem, ShipTowerBuffData> ItemLayout;

	// Token: 0x0400A88A RID: 43146
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ShipTowerBuffData> OnItemClickCallback;

	// Token: 0x0400A88B RID: 43147
	[Nullable(2)]
	public Func<int?> GetStageIdCallback;

	// Token: 0x0400A88C RID: 43148
	[Nullable(2)]
	public Action BuffComponentLoadedCallback;

	// Token: 0x020081EA RID: 33258
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04029F53 RID: 171859
		public const int TxtTitle = 0;

		// Token: 0x04029F54 RID: 171860
		public const int GridLayoutItemList = 1;

		// Token: 0x04029F55 RID: 171861
		public const int ItemItem = 2;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D0C RID: 7436
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerTokenZoneItem : GridProxyAbstract<RoleTowerTokenZoneItemData>
{
	// Token: 0x06012686 RID: 75398 RVA: 0x00570B80 File Offset: 0x0056ED80
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06012687 RID: 75399 RVA: 0x00570BDC File Offset: 0x0056EDDC
	protected override UniTask OnBeforeStartAsync()
	{
		RoleTowerTokenZoneItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleTowerTokenZoneItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012688 RID: 75400 RVA: 0x00570C20 File Offset: 0x0056EE20
	public override UniTask RefreshAsync(RoleTowerTokenZoneItemData data, bool isSelected, int gridIndex)
	{
		RoleTowerTokenZoneItem.<RefreshAsync>d__8 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.data = data;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<RoleTowerTokenZoneItem.<RefreshAsync>d__8>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012689 RID: 75401 RVA: 0x00570C6C File Offset: 0x0056EE6C
	public override void Refresh(RoleTowerTokenZoneItemData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		GenericLayout<RoleTowerTokenItem, RoleTowerTokenItemData> itemLayout = this.ItemLayout;
		if (itemLayout != null)
		{
			RoleTowerTokenZoneItemData itemData = this.ItemData;
			itemLayout.RefreshByData(((itemData != null) ? itemData.TokenList : null) ?? new List<RoleTowerTokenItemData>(), null, true);
		}
		base.GetText(0).ShowTextNew(this.ItemData.Title);
		this.TryPlayListAnim();
	}

	// Token: 0x0601268A RID: 75402 RVA: 0x00570CCB File Offset: 0x0056EECB
	private void TryPlayListAnim()
	{
		if (this.AlreadyPlayedListAnim)
		{
			return;
		}
		this.AlreadyPlayedListAnim = true;
		UUIInturnAnimController itemListAnim = this.ItemListAnim;
		if (itemListAnim == null)
		{
			return;
		}
		itemListAnim.Play("", -1, false);
	}

	// Token: 0x0601268B RID: 75403 RVA: 0x00570CF4 File Offset: 0x0056EEF4
	private RoleTowerTokenItem CreateTokenItem()
	{
		return new RoleTowerTokenItem
		{
			OnItemClickCallback = this.OnItemClickCallback
		};
	}

	// Token: 0x0601268C RID: 75404 RVA: 0x00570D07 File Offset: 0x0056EF07
	[NullableContext(2)]
	public UUIItem GetTokenUiItemByIndex(int index)
	{
		GenericLayout<RoleTowerTokenItem, RoleTowerTokenItemData> itemLayout = this.ItemLayout;
		if (itemLayout == null)
		{
			return null;
		}
		return itemLayout.GetItemByIndex(index);
	}

	// Token: 0x0601268D RID: 75405 RVA: 0x00570D1C File Offset: 0x0056EF1C
	public void UpdateTokenInfo()
	{
		GenericLayout<RoleTowerTokenItem, RoleTowerTokenItemData> itemLayout = this.ItemLayout;
		List<RoleTowerTokenItem> list = (itemLayout != null) ? itemLayout.GetLayoutItemList() : null;
		if (list == null)
		{
			return;
		}
		for (int i = 0; i < list.Count; i++)
		{
			list[i].UpdateTokenInfo();
		}
	}

	// Token: 0x0601268E RID: 75406 RVA: 0x00570D60 File Offset: 0x0056EF60
	public void UpdateTokenSelected()
	{
		GenericLayout<RoleTowerTokenItem, RoleTowerTokenItemData> itemLayout = this.ItemLayout;
		List<RoleTowerTokenItem> list = (itemLayout != null) ? itemLayout.GetLayoutItemList() : null;
		if (list == null)
		{
			return;
		}
		for (int i = 0; i < list.Count; i++)
		{
			list[i].UpdateTokenSelected();
		}
	}

	// Token: 0x0400A05E RID: 41054
	[Nullable(2)]
	private RoleTowerTokenZoneItemData ItemData;

	// Token: 0x0400A05F RID: 41055
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleTowerTokenItem, RoleTowerTokenItemData> ItemLayout;

	// Token: 0x0400A060 RID: 41056
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<RoleTowerTokenItemData> OnItemClickCallback;

	// Token: 0x0400A061 RID: 41057
	[Nullable(2)]
	private UUIInturnAnimController ItemListAnim;

	// Token: 0x0400A062 RID: 41058
	private bool AlreadyPlayedListAnim;

	// Token: 0x0200803D RID: 32829
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x040297E6 RID: 169958
		public const int TxtTitle = 0;

		// Token: 0x040297E7 RID: 169959
		public const int GridLayoutItemList = 1;

		// Token: 0x040297E8 RID: 169960
		public const int ItemItem = 2;
	}
}

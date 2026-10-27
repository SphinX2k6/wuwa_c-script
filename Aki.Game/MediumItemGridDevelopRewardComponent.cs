using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001910 RID: 6416
public class MediumItemGridDevelopRewardComponent : MediumItemGridComponent
{
	// Token: 0x0600BBFD RID: 48125 RVA: 0x002A9CA8 File Offset: 0x002A7EA8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BBFE RID: 48126 RVA: 0x002A9D11 File Offset: 0x002A7F11
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemVisionMap";
	}

	// Token: 0x0600BBFF RID: 48127 RVA: 0x002A9D18 File Offset: 0x002A7F18
	protected override void OnActivate()
	{
		this.Layout = new GenericLayoutNew<DevelopRewardItem>(base.GetLayoutBase(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<DevelopRewardItem>(this.InitItem), base.GetItem(1));
	}

	// Token: 0x0600BC00 RID: 48128 RVA: 0x002A9D3F File Offset: 0x002A7F3F
	protected override void OnDeactivate()
	{
		GenericLayoutNew<DevelopRewardItem> layout = this.Layout;
		if (layout != null)
		{
			layout.ClearChildren();
		}
		this.Layout = null;
	}

	// Token: 0x0600BC01 RID: 48129 RVA: 0x002A9D5C File Offset: 0x002A7F5C
	[NullableContext(1)]
	private ILayoutItem<DevelopRewardItem> InitItem(object data, UUIItem uiItem, int index)
	{
		DevelopRewardItem developRewardItem = new DevelopRewardItem();
		developRewardItem.CreateByActorAsync(uiItem.GetOwner(), null, false).ContinueWith(delegate()
		{
			developRewardItem.SetIsUnlock(index < this.UnlockLevel);
			developRewardItem.SetUiActive(true);
		}).Forget();
		return new LayoutItem<DevelopRewardItem>
		{
			Key = index,
			Value = developRewardItem
		};
	}

	// Token: 0x0600BC02 RID: 48130 RVA: 0x002A9DD4 File Offset: 0x002A7FD4
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		DevelopRewardInfo developRewardInfo = data as DevelopRewardInfo;
		if (developRewardInfo == null)
		{
			this.SetActive(false);
			return;
		}
		bool? isUnlock = developRewardInfo.IsUnlock;
		if (!isUnlock.GetValueOrDefault())
		{
			this.SetActive(false);
			return;
		}
		this.DevelopRewardLevel = developRewardInfo.DevelopRewardLevel;
		this.UnlockLevel = developRewardInfo.UnlockLevel;
		GenericLayoutNew<DevelopRewardItem> layout = this.Layout;
		if (layout != null)
		{
			layout.RebuildLayoutByDataNew<object>(null, new int?(this.DevelopRewardLevel));
		}
		this.SetActive(true);
	}

	// Token: 0x0400552C RID: 21804
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<DevelopRewardItem> Layout;

	// Token: 0x0400552D RID: 21805
	private int DevelopRewardLevel;

	// Token: 0x0400552E RID: 21806
	private int UnlockLevel;

	// Token: 0x02007E83 RID: 32387
	private class EChildType
	{
		// Token: 0x0402964C RID: 169548
		public const int LevelLayout = 0;

		// Token: 0x0402964D RID: 169549
		public const int LevelLayoutItem = 1;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02000DC9 RID: 3529
public class MediumItemGridDevelopRewardComponent : MediumItemGridComponent
{
	// Token: 0x06008FE7 RID: 36839 RVA: 0x002B4404 File Offset: 0x002B2604
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

	// Token: 0x06008FE8 RID: 36840 RVA: 0x002B446D File Offset: 0x002B266D
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemVisionMap";
	}

	// Token: 0x06008FE9 RID: 36841 RVA: 0x002B4474 File Offset: 0x002B2674
	protected override void OnActivate()
	{
		this.Layout = new GenericLayoutNew<DevelopRewardItem>(base.GetLayoutBase(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<DevelopRewardItem>(this.InitItem), base.GetItem(1));
	}

	// Token: 0x06008FEA RID: 36842 RVA: 0x002B449B File Offset: 0x002B269B
	protected override void OnDeactivate()
	{
		GenericLayoutNew<DevelopRewardItem> layout = this.Layout;
		if (layout != null)
		{
			layout.ClearChildren();
		}
		this.Layout = null;
	}

	// Token: 0x06008FEB RID: 36843 RVA: 0x002B44B8 File Offset: 0x002B26B8
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

	// Token: 0x06008FEC RID: 36844 RVA: 0x002B4530 File Offset: 0x002B2730
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

	// Token: 0x040055D7 RID: 21975
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<DevelopRewardItem> Layout;

	// Token: 0x040055D8 RID: 21976
	private int DevelopRewardLevel;

	// Token: 0x040055D9 RID: 21977
	private int UnlockLevel;

	// Token: 0x0200700A RID: 28682
	private class EChildType
	{
		// Token: 0x04024978 RID: 149880
		public const int LevelLayout = 0;

		// Token: 0x04024979 RID: 149881
		public const int LevelLayoutItem = 1;
	}
}

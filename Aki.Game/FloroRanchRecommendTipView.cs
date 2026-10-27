using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B73 RID: 7027
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchRecommendTipView : UiViewBase
{
	// Token: 0x0600D103 RID: 53507 RVA: 0x002FCDB9 File Offset: 0x002FAFB9
	public FloroRanchRecommendTipView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600D104 RID: 53508 RVA: 0x002FCDE0 File Offset: 0x002FAFE0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickCloseButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D105 RID: 53509 RVA: 0x002FCEC8 File Offset: 0x002FB0C8
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchRecommendTipView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchRecommendTipView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D106 RID: 53510 RVA: 0x002FCF0C File Offset: 0x002FB10C
	private UniTask CreateRecommendItem(FloroRanchUnlockDataBase data)
	{
		FloroRanchRecommendTipView.<CreateRecommendItem>d__9 <CreateRecommendItem>d__;
		<CreateRecommendItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateRecommendItem>d__.<>4__this = this;
		<CreateRecommendItem>d__.data = data;
		<CreateRecommendItem>d__.<>1__state = -1;
		<CreateRecommendItem>d__.<>t__builder.Start<FloroRanchRecommendTipView.<CreateRecommendItem>d__9>(ref <CreateRecommendItem>d__);
		return <CreateRecommendItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600D107 RID: 53511 RVA: 0x002FCF58 File Offset: 0x002FB158
	private UniTask RefreshRecommendViewAsync()
	{
		FloroRanchRecommendTipView.<RefreshRecommendViewAsync>d__10 <RefreshRecommendViewAsync>d__;
		<RefreshRecommendViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRecommendViewAsync>d__.<>4__this = this;
		<RefreshRecommendViewAsync>d__.<>1__state = -1;
		<RefreshRecommendViewAsync>d__.<>t__builder.Start<FloroRanchRecommendTipView.<RefreshRecommendViewAsync>d__10>(ref <RefreshRecommendViewAsync>d__);
		return <RefreshRecommendViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D108 RID: 53512 RVA: 0x002FCF9C File Offset: 0x002FB19C
	private void SetRecommendSlotItemsAlphaVisible()
	{
		foreach (FloroRanchHandBookSmallSlotItem floroRanchHandBookSmallSlotItem in this.RecommendItemList)
		{
			floroRanchHandBookSmallSlotItem.GetRootItem().SetAlpha(1f);
		}
	}

	// Token: 0x0600D109 RID: 53513 RVA: 0x002FCFF8 File Offset: 0x002FB1F8
	private void OnClickRecommendItem(FloroRanchHandBookSmallSlotItem item)
	{
		int num = this.RecommendItemList.IndexOf(item);
		if (num < 0)
		{
			return;
		}
		this.ShowRecommendTip(num);
	}

	// Token: 0x0600D10A RID: 53514 RVA: 0x002FD020 File Offset: 0x002FB220
	private void HideRecommendTip()
	{
		if (this.CurSelectIndex < 0)
		{
			return;
		}
		FloroRanchHandBookSmallSlotItem floroRanchHandBookSmallSlotItem = this.RecommendItemList[this.CurSelectIndex];
		if (floroRanchHandBookSmallSlotItem != null)
		{
			floroRanchHandBookSmallSlotItem.OnDeselected(true);
		}
	}

	// Token: 0x0600D10B RID: 53515 RVA: 0x002FD054 File Offset: 0x002FB254
	private void ShowRecommendTip(int index)
	{
		if (index < 0 || index >= this.RefreshDataList.Count)
		{
			return;
		}
		this.HideRecommendTip();
		this.CurSelectIndex = index;
		FloroRanchHandBookSmallSlotItem floroRanchHandBookSmallSlotItem = this.RecommendItemList[index];
		if (floroRanchHandBookSmallSlotItem != null)
		{
			floroRanchHandBookSmallSlotItem.OnSelected(true);
		}
		FloroRanchUnlockDataBase data = this.RefreshDataList[index];
		FloroRanchCommonTipParam floroRanchCommonTipParam = this.BuildTipParam(data);
		if (floroRanchCommonTipParam == null)
		{
			return;
		}
		this.RecommendTipItem.RefreshInfoTipByParam(floroRanchCommonTipParam);
	}

	// Token: 0x0600D10C RID: 53516 RVA: 0x002FD0C0 File Offset: 0x002FB2C0
	[return: Nullable(2)]
	private FloroRanchCommonTipParam BuildTipParam(FloroRanchUnlockDataBase data)
	{
		FloroRanchUnlockCardData floroRanchUnlockCardData = data as FloroRanchUnlockCardData;
		if (floroRanchUnlockCardData != null)
		{
			return new FloroRanchCommonTipParam
			{
				TipType = EFloroRanchCommonTipType.Card,
				CardData = floroRanchUnlockCardData.GetCardData()
			};
		}
		FloroRanchUnlockToyData floroRanchUnlockToyData = data as FloroRanchUnlockToyData;
		if (floroRanchUnlockToyData != null)
		{
			return new FloroRanchCommonTipParam
			{
				TipType = EFloroRanchCommonTipType.Toy,
				ToyData = floroRanchUnlockToyData.GetToyData()
			};
		}
		return null;
	}

	// Token: 0x0600D10D RID: 53517 RVA: 0x002FD114 File Offset: 0x002FB314
	private void OnClickCloseButton()
	{
		base.CloseMe(null);
		this.CurSelectIndex = -1;
	}

	// Token: 0x04005FEC RID: 24556
	private readonly List<FloroRanchHandBookSmallSlotItem> RecommendItemList = new List<FloroRanchHandBookSmallSlotItem>();

	// Token: 0x04005FED RID: 24557
	private readonly List<FloroRanchUnlockDataBase> RefreshDataList = new List<FloroRanchUnlockDataBase>();

	// Token: 0x04005FEE RID: 24558
	private int CurSelectIndex = -1;

	// Token: 0x04005FEF RID: 24559
	private FloroRanchCommonTipItem RecommendTipItem;

	// Token: 0x04005FF0 RID: 24560
	private EFloroRanchActivityDataType ActivityDataType;

	// Token: 0x020080EA RID: 33002
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402A101 RID: 172289
		public const int CloseButton = 0;

		// Token: 0x0402A102 RID: 172290
		public const int RecommendTipItem = 1;

		// Token: 0x0402A103 RID: 172291
		public const int RecommendLayout = 2;

		// Token: 0x0402A104 RID: 172292
		public const int RecommendItemTemplate = 3;
	}
}

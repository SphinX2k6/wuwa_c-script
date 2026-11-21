using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001032 RID: 4146
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchRecommendTipView : UiViewBase
{
	// Token: 0x0600A514 RID: 42260 RVA: 0x00307E91 File Offset: 0x00306091
	public FloroRanchRecommendTipView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A515 RID: 42261 RVA: 0x00307EB8 File Offset: 0x003060B8
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

	// Token: 0x0600A516 RID: 42262 RVA: 0x00307FA0 File Offset: 0x003061A0
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchRecommendTipView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchRecommendTipView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A517 RID: 42263 RVA: 0x00307FE4 File Offset: 0x003061E4
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

	// Token: 0x0600A518 RID: 42264 RVA: 0x00308030 File Offset: 0x00306230
	private UniTask RefreshRecommendViewAsync()
	{
		FloroRanchRecommendTipView.<RefreshRecommendViewAsync>d__10 <RefreshRecommendViewAsync>d__;
		<RefreshRecommendViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRecommendViewAsync>d__.<>4__this = this;
		<RefreshRecommendViewAsync>d__.<>1__state = -1;
		<RefreshRecommendViewAsync>d__.<>t__builder.Start<FloroRanchRecommendTipView.<RefreshRecommendViewAsync>d__10>(ref <RefreshRecommendViewAsync>d__);
		return <RefreshRecommendViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A519 RID: 42265 RVA: 0x00308074 File Offset: 0x00306274
	private void SetRecommendSlotItemsAlphaVisible()
	{
		foreach (FloroRanchHandBookSmallSlotItem floroRanchHandBookSmallSlotItem in this.RecommendItemList)
		{
			floroRanchHandBookSmallSlotItem.GetRootItem().SetAlpha(1f);
		}
	}

	// Token: 0x0600A51A RID: 42266 RVA: 0x003080D0 File Offset: 0x003062D0
	private void OnClickRecommendItem(FloroRanchHandBookSmallSlotItem item)
	{
		int num = this.RecommendItemList.IndexOf(item);
		if (num < 0)
		{
			return;
		}
		this.ShowRecommendTip(num);
	}

	// Token: 0x0600A51B RID: 42267 RVA: 0x003080F8 File Offset: 0x003062F8
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

	// Token: 0x0600A51C RID: 42268 RVA: 0x0030812C File Offset: 0x0030632C
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

	// Token: 0x0600A51D RID: 42269 RVA: 0x00308198 File Offset: 0x00306398
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

	// Token: 0x0600A51E RID: 42270 RVA: 0x003081EC File Offset: 0x003063EC
	private void OnClickCloseButton()
	{
		base.CloseMe(null);
		this.CurSelectIndex = -1;
	}

	// Token: 0x040060BB RID: 24763
	private readonly List<FloroRanchHandBookSmallSlotItem> RecommendItemList = new List<FloroRanchHandBookSmallSlotItem>();

	// Token: 0x040060BC RID: 24764
	private readonly List<FloroRanchUnlockDataBase> RefreshDataList = new List<FloroRanchUnlockDataBase>();

	// Token: 0x040060BD RID: 24765
	private int CurSelectIndex = -1;

	// Token: 0x040060BE RID: 24766
	private FloroRanchCommonTipItem RecommendTipItem;

	// Token: 0x040060BF RID: 24767
	private EFloroRanchActivityDataType ActivityDataType;

	// Token: 0x02007278 RID: 29304
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04025435 RID: 152629
		public const int CloseButton = 0;

		// Token: 0x04025436 RID: 152630
		public const int RecommendTipItem = 1;

		// Token: 0x04025437 RID: 152631
		public const int RecommendLayout = 2;

		// Token: 0x04025438 RID: 152632
		public const int RecommendItemTemplate = 3;
	}
}

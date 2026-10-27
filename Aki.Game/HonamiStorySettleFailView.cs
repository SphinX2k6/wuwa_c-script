using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F14 RID: 7956
public class HonamiStorySettleFailView : UiViewBase
{
	// Token: 0x0600F527 RID: 62759 RVA: 0x003B27EF File Offset: 0x003B09EF
	[NullableContext(1)]
	public HonamiStorySettleFailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F528 RID: 62760 RVA: 0x003B27F8 File Offset: 0x003B09F8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnConfirmClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600F529 RID: 62761 RVA: 0x003B2943 File Offset: 0x003B0B43
	protected override void OnStart()
	{
		this.ScrollView = new GenericScrollViewNew<HonamiStorySettleItem, IHonamiStorySettleItemParams>(base.GetScrollViewWithScrollbar(0), new Func<HonamiStorySettleItem>(this.InitItem), null, false, null);
	}

	// Token: 0x0600F52A RID: 62762 RVA: 0x003B2968 File Offset: 0x003B0B68
	protected override void OnBeforeShow()
	{
		IHonamiStorySettleFailViewParams honamiStorySettleFailViewParams = this.OpenParam as IHonamiStorySettleFailViewParams;
		if (honamiStorySettleFailViewParams == null)
		{
			return;
		}
		base.GetItem(6).SetUIActive(false);
		GenericScrollViewNew<HonamiStorySettleItem, IHonamiStorySettleItemParams> scrollView = this.ScrollView;
		if (scrollView != null)
		{
			scrollView.RefreshByData(honamiStorySettleFailViewParams.DisplayItems, delegate
			{
				if (this.ScrollView != null && this.ScrollView.IsExpand)
				{
					base.GetItem(6).SetUIActive(true);
				}
			}, true);
		}
		base.GetText(1).SetText(honamiStorySettleFailViewParams.TotalReward.ToString(), true);
		base.GetItem(2).SetUIActive(honamiStorySettleFailViewParams.IsNewRecord);
		int failAddProportion = honamiStorySettleFailViewParams.FailAddProportion;
		bool flag = failAddProportion > 0;
		base.GetItem(4).SetUIActive(flag);
		if (flag)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "HonamiStory_EvacuationInterface_4", new <>z__ReadOnlySingleElementList<object>(failAddProportion));
		}
		this.SetDialogAndSound();
	}

	// Token: 0x0600F52B RID: 62763 RVA: 0x003B2A26 File Offset: 0x003B0C26
	[NullableContext(1)]
	private HonamiStorySettleItem InitItem()
	{
		return new HonamiStorySettleItem();
	}

	// Token: 0x0600F52C RID: 62764 RVA: 0x003B2A2D File Offset: 0x003B0C2D
	private void OnConfirmClick()
	{
		HonamiStoryController.Instance.LeaveHonamiDungeon();
	}

	// Token: 0x0600F52D RID: 62765 RVA: 0x003B2A3C File Offset: 0x003B0C3C
	private void SetDialogAndSound()
	{
		HonamiStoryOutDialog? randomDialogData = HonamiStoryModel.Instance.GetRandomDialogData(3);
		AudioSystem.Instance.PostEvent(randomDialogData.Value.AudioEvent);
	}

	// Token: 0x04007165 RID: 29029
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<HonamiStorySettleItem, IHonamiStorySettleItemParams> ScrollView;

	// Token: 0x02008523 RID: 34083
	private enum EComponentType
	{
		// Token: 0x0402B552 RID: 177490
		ScrollView,
		// Token: 0x0402B553 RID: 177491
		RewardText,
		// Token: 0x0402B554 RID: 177492
		NewRecordItem,
		// Token: 0x0402B555 RID: 177493
		ConfirmButton,
		// Token: 0x0402B556 RID: 177494
		FailItem,
		// Token: 0x0402B557 RID: 177495
		FailItemValueText,
		// Token: 0x0402B558 RID: 177496
		BottomArrowItem
	}
}

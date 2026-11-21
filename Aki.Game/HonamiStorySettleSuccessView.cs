using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020013DC RID: 5084
public class HonamiStorySettleSuccessView : UiViewBase
{
	// Token: 0x0600C964 RID: 51556 RVA: 0x003BE6A8 File Offset: 0x003BC8A8
	[NullableContext(1)]
	public HonamiStorySettleSuccessView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C965 RID: 51557 RVA: 0x003BE6B4 File Offset: 0x003BC8B4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
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
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnConfirmClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C966 RID: 51558 RVA: 0x003BE79C File Offset: 0x003BC99C
	protected override void OnStart()
	{
		this.ScrollView = new GenericScrollViewNew<HonamiStorySettleItem, IHonamiStorySettleItemParams>(base.GetScrollViewWithScrollbar(0), new Func<HonamiStorySettleItem>(this.InitItem), null, false, null);
	}

	// Token: 0x0600C967 RID: 51559 RVA: 0x003BE7C0 File Offset: 0x003BC9C0
	protected override void OnBeforeShow()
	{
		IHonamiStorySettleSuccessViewParams honamiStorySettleSuccessViewParams = this.OpenParam as IHonamiStorySettleSuccessViewParams;
		if (honamiStorySettleSuccessViewParams == null)
		{
			return;
		}
		GenericScrollViewNew<HonamiStorySettleItem, IHonamiStorySettleItemParams> scrollView = this.ScrollView;
		if (scrollView != null)
		{
			scrollView.RefreshByData(honamiStorySettleSuccessViewParams.DisplayItems, null, true);
		}
		base.GetText(1).SetText(honamiStorySettleSuccessViewParams.TotalReward.ToString(), true);
		base.GetItem(2).SetUIActive(honamiStorySettleSuccessViewParams.IsNewRecord);
		this.SetDialogAndSound();
	}

	// Token: 0x0600C968 RID: 51560 RVA: 0x003BE829 File Offset: 0x003BCA29
	[NullableContext(1)]
	private HonamiStorySettleItem InitItem()
	{
		return new HonamiStorySettleItem();
	}

	// Token: 0x0600C969 RID: 51561 RVA: 0x003BE830 File Offset: 0x003BCA30
	private void OnConfirmClick()
	{
		HonamiStoryController.Instance.LeaveHonamiDungeon();
	}

	// Token: 0x0600C96A RID: 51562 RVA: 0x003BE840 File Offset: 0x003BCA40
	private void SetDialogAndSound()
	{
		HonamiStoryOutDialog? randomDialogData = HonamiStoryModel.Instance.GetRandomDialogData(2);
		AudioSystem.Instance.PostEvent(randomDialogData.Value.AudioEvent);
	}

	// Token: 0x0400724C RID: 29260
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<HonamiStorySettleItem, IHonamiStorySettleItemParams> ScrollView;

	// Token: 0x020076AA RID: 30378
	private enum EComponentType
	{
		// Token: 0x04026881 RID: 157825
		ScrollView,
		// Token: 0x04026882 RID: 157826
		RewardText,
		// Token: 0x04026883 RID: 157827
		NewRecordItem,
		// Token: 0x04026884 RID: 157828
		ConfirmButton
	}
}

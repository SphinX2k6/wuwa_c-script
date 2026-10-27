using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F1A RID: 7962
public class HonamiStorySettleSuccessView : UiViewBase
{
	// Token: 0x0600F545 RID: 62789 RVA: 0x003B2BBC File Offset: 0x003B0DBC
	[NullableContext(1)]
	public HonamiStorySettleSuccessView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F546 RID: 62790 RVA: 0x003B2BC8 File Offset: 0x003B0DC8
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

	// Token: 0x0600F547 RID: 62791 RVA: 0x003B2CB0 File Offset: 0x003B0EB0
	protected override void OnStart()
	{
		this.ScrollView = new GenericScrollViewNew<HonamiStorySettleItem, IHonamiStorySettleItemParams>(base.GetScrollViewWithScrollbar(0), new Func<HonamiStorySettleItem>(this.InitItem), null, false, null);
	}

	// Token: 0x0600F548 RID: 62792 RVA: 0x003B2CD4 File Offset: 0x003B0ED4
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

	// Token: 0x0600F549 RID: 62793 RVA: 0x003B2D3D File Offset: 0x003B0F3D
	[NullableContext(1)]
	private HonamiStorySettleItem InitItem()
	{
		return new HonamiStorySettleItem();
	}

	// Token: 0x0600F54A RID: 62794 RVA: 0x003B2D44 File Offset: 0x003B0F44
	private void OnConfirmClick()
	{
		HonamiStoryController.Instance.LeaveHonamiDungeon();
	}

	// Token: 0x0600F54B RID: 62795 RVA: 0x003B2D54 File Offset: 0x003B0F54
	private void SetDialogAndSound()
	{
		HonamiStoryOutDialog? randomDialogData = HonamiStoryModel.Instance.GetRandomDialogData(2);
		AudioSystem.Instance.PostEvent(randomDialogData.Value.AudioEvent);
	}

	// Token: 0x0400716B RID: 29035
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<HonamiStorySettleItem, IHonamiStorySettleItemParams> ScrollView;

	// Token: 0x02008525 RID: 34085
	private enum EComponentType
	{
		// Token: 0x0402B55D RID: 177501
		ScrollView,
		// Token: 0x0402B55E RID: 177502
		RewardText,
		// Token: 0x0402B55F RID: 177503
		NewRecordItem,
		// Token: 0x0402B560 RID: 177504
		ConfirmButton
	}
}

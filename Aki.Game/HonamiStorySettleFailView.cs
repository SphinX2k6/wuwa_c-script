using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020013D6 RID: 5078
public class HonamiStorySettleFailView : UiViewBase
{
	// Token: 0x0600C946 RID: 51526 RVA: 0x003BE2DB File Offset: 0x003BC4DB
	[NullableContext(1)]
	public HonamiStorySettleFailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C947 RID: 51527 RVA: 0x003BE2E4 File Offset: 0x003BC4E4
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

	// Token: 0x0600C948 RID: 51528 RVA: 0x003BE42F File Offset: 0x003BC62F
	protected override void OnStart()
	{
		this.ScrollView = new GenericScrollViewNew<HonamiStorySettleItem, IHonamiStorySettleItemParams>(base.GetScrollViewWithScrollbar(0), new Func<HonamiStorySettleItem>(this.InitItem), null, false, null);
	}

	// Token: 0x0600C949 RID: 51529 RVA: 0x003BE454 File Offset: 0x003BC654
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

	// Token: 0x0600C94A RID: 51530 RVA: 0x003BE512 File Offset: 0x003BC712
	[NullableContext(1)]
	private HonamiStorySettleItem InitItem()
	{
		return new HonamiStorySettleItem();
	}

	// Token: 0x0600C94B RID: 51531 RVA: 0x003BE519 File Offset: 0x003BC719
	private void OnConfirmClick()
	{
		HonamiStoryController.Instance.LeaveHonamiDungeon();
	}

	// Token: 0x0600C94C RID: 51532 RVA: 0x003BE528 File Offset: 0x003BC728
	private void SetDialogAndSound()
	{
		HonamiStoryOutDialog? randomDialogData = HonamiStoryModel.Instance.GetRandomDialogData(3);
		AudioSystem.Instance.PostEvent(randomDialogData.Value.AudioEvent);
	}

	// Token: 0x04007246 RID: 29254
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<HonamiStorySettleItem, IHonamiStorySettleItemParams> ScrollView;

	// Token: 0x020076A8 RID: 30376
	private enum EComponentType
	{
		// Token: 0x04026876 RID: 157814
		ScrollView,
		// Token: 0x04026877 RID: 157815
		RewardText,
		// Token: 0x04026878 RID: 157816
		NewRecordItem,
		// Token: 0x04026879 RID: 157817
		ConfirmButton,
		// Token: 0x0402687A RID: 157818
		FailItem,
		// Token: 0x0402687B RID: 157819
		FailItemValueText,
		// Token: 0x0402687C RID: 157820
		BottomArrowItem
	}
}

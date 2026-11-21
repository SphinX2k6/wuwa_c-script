using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001383 RID: 4995
public class HonamiStoryLeaveTip : UiViewBase
{
	// Token: 0x0600C653 RID: 50771 RVA: 0x003B0AD3 File Offset: 0x003AECD3
	[NullableContext(1)]
	public HonamiStoryLeaveTip(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C654 RID: 50772 RVA: 0x003B0ADC File Offset: 0x003AECDC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 4;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnCancelClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnConfirmClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnCancelClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnCancelClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C655 RID: 50773 RVA: 0x003B0CF8 File Offset: 0x003AEEF8
	protected override void OnStart()
	{
		IHonamiStoryLeaveTipParams honamiStoryLeaveTipParams = this.OpenParam as IHonamiStoryLeaveTipParams;
		if (honamiStoryLeaveTipParams == null)
		{
			return;
		}
		this.ShowSafeLeaveUpdate = honamiStoryLeaveTipParams.ShowSafeLeaveUpdate;
		this.ConfirmCallback = honamiStoryLeaveTipParams.ConfirmCallback;
		this.CancelCallback = honamiStoryLeaveTipParams.CancelCallback;
		EHonamiStoryLeaveType ehonamiStoryLeaveType = HonamiStoryUtil.CheckInHonamiStoryTopTower() ? EHonamiStoryLeaveType.TopTowerLeave : honamiStoryLeaveTipParams.LeaveType;
		string textStringId = string.Empty;
		string textStringId2 = string.Empty;
		string textStringId3 = string.Empty;
		string textStringId4 = string.Empty;
		string textStringId5 = string.Empty;
		string textStringId6 = string.Empty;
		switch (ehonamiStoryLeaveType)
		{
		case EHonamiStoryLeaveType.SafeLeave:
			textStringId = "HonamiStory_EvacuationWindow_1";
			textStringId2 = "HonamiStory_EvacuationWindow_4";
			textStringId3 = "HonamiStory_EvacuationWindow_5";
			textStringId4 = "HonamiStory_EvacuationWindow_6";
			textStringId5 = "HonamiStory_EvacuationWindow_2";
			textStringId6 = "HonamiStory_EvacuationWindow_3";
			break;
		case EHonamiStoryLeaveType.DangerLeave:
			textStringId = "HonamiStory_EvacuationWindow_9";
			textStringId2 = "HonamiStory_EvacuationWindow_12";
			textStringId3 = "HonamiStory_EvacuationWindow_13";
			textStringId4 = "HonamiStory_EvacuationWindow_14";
			textStringId5 = "HonamiStory_EvacuationWindow_10";
			textStringId6 = "HonamiStory_EvacuationWindow_11";
			break;
		case EHonamiStoryLeaveType.InteractLeave:
			textStringId = "HonamiStory_EvacuationWindow_1";
			textStringId2 = "HonamiStory_EvacuationWindow_4";
			textStringId3 = "HonamiStory_EvacuationWindow_5";
			textStringId4 = "HonamiStory_EvacuationWindow_6";
			textStringId5 = "HonamiStory_EvacuationWindow_7";
			textStringId6 = "HonamiStory_EvacuationWindow_8";
			break;
		case EHonamiStoryLeaveType.TopTowerLeave:
			textStringId = "HonamiStory_EvacuationWindow_15";
			textStringId2 = "HonamiStory_EvacuationWindow_18";
			textStringId3 = "HonamiStory_EvacuationWindow_19";
			textStringId4 = "HonamiStory_EvacuationWindow_20";
			textStringId5 = "HonamiStory_EvacuationWindow_16";
			textStringId6 = "HonamiStory_EvacuationWindow_17";
			break;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textStringId, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId5, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textStringId6, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textStringId2, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), textStringId3, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), textStringId4, Array.Empty<object>());
		if (this.UiViewSequence != null)
		{
			this.UiViewSequence.StartSequenceName = ((ehonamiStoryLeaveType == EHonamiStoryLeaveType.DangerLeave) ? "FailStart" : "SuccessStart");
		}
	}

	// Token: 0x0600C656 RID: 50774 RVA: 0x003B0EE8 File Offset: 0x003AF0E8
	protected override UniTask OnPlayingCloseSequenceAsync()
	{
		HonamiStoryLeaveTip.<OnPlayingCloseSequenceAsync>d__8 <OnPlayingCloseSequenceAsync>d__;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
		<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<HonamiStoryLeaveTip.<OnPlayingCloseSequenceAsync>d__8>(ref <OnPlayingCloseSequenceAsync>d__);
		return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C657 RID: 50775 RVA: 0x003B0F2B File Offset: 0x003AF12B
	protected override void OnBeforeDestroy()
	{
		if (this.ShowSafeLeaveUpdate)
		{
			HonamiStoryController.Instance.ShowSafeLeaveUpdate();
			this.ShowSafeLeaveUpdate = false;
		}
	}

	// Token: 0x0600C658 RID: 50776 RVA: 0x003B0F46 File Offset: 0x003AF146
	private void OnCancelClick()
	{
		this.IsConfirmClose = false;
		base.CloseMe(null);
		Action cancelCallback = this.CancelCallback;
		if (cancelCallback == null)
		{
			return;
		}
		cancelCallback();
	}

	// Token: 0x0600C659 RID: 50777 RVA: 0x003B0F66 File Offset: 0x003AF166
	private void OnConfirmClick()
	{
		this.IsConfirmClose = true;
		base.CloseMe(null);
		Action confirmCallback = this.ConfirmCallback;
		if (confirmCallback == null)
		{
			return;
		}
		confirmCallback();
	}

	// Token: 0x040070D1 RID: 28881
	private bool IsConfirmClose;

	// Token: 0x040070D2 RID: 28882
	private bool ShowSafeLeaveUpdate;

	// Token: 0x040070D3 RID: 28883
	[Nullable(2)]
	private Action ConfirmCallback;

	// Token: 0x040070D4 RID: 28884
	[Nullable(2)]
	private Action CancelCallback;

	// Token: 0x0200762D RID: 30253
	private enum EComponentType
	{
		// Token: 0x04026603 RID: 157187
		TitleText,
		// Token: 0x04026604 RID: 157188
		SubTitleText,
		// Token: 0x04026605 RID: 157189
		ContentText,
		// Token: 0x04026606 RID: 157190
		SubContentText,
		// Token: 0x04026607 RID: 157191
		CancelButton,
		// Token: 0x04026608 RID: 157192
		ConfirmButton,
		// Token: 0x04026609 RID: 157193
		BackButton,
		// Token: 0x0402660A RID: 157194
		BgButton,
		// Token: 0x0402660B RID: 157195
		CancelButtonText,
		// Token: 0x0402660C RID: 157196
		ConfirmButtonText
	}
}

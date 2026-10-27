using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001EC1 RID: 7873
public class HonamiStoryLeaveTip : UiViewBase
{
	// Token: 0x0600F234 RID: 62004 RVA: 0x003A4FD3 File Offset: 0x003A31D3
	[NullableContext(1)]
	public HonamiStoryLeaveTip(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F235 RID: 62005 RVA: 0x003A4FDC File Offset: 0x003A31DC
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

	// Token: 0x0600F236 RID: 62006 RVA: 0x003A51F8 File Offset: 0x003A33F8
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

	// Token: 0x0600F237 RID: 62007 RVA: 0x003A53E8 File Offset: 0x003A35E8
	protected override UniTask OnPlayingCloseSequenceAsync()
	{
		HonamiStoryLeaveTip.<OnPlayingCloseSequenceAsync>d__8 <OnPlayingCloseSequenceAsync>d__;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
		<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<HonamiStoryLeaveTip.<OnPlayingCloseSequenceAsync>d__8>(ref <OnPlayingCloseSequenceAsync>d__);
		return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F238 RID: 62008 RVA: 0x003A542B File Offset: 0x003A362B
	protected override void OnBeforeDestroy()
	{
		if (this.ShowSafeLeaveUpdate)
		{
			HonamiStoryController.Instance.ShowSafeLeaveUpdate();
			this.ShowSafeLeaveUpdate = false;
		}
	}

	// Token: 0x0600F239 RID: 62009 RVA: 0x003A5446 File Offset: 0x003A3646
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

	// Token: 0x0600F23A RID: 62010 RVA: 0x003A5466 File Offset: 0x003A3666
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

	// Token: 0x04006FF0 RID: 28656
	private bool IsConfirmClose;

	// Token: 0x04006FF1 RID: 28657
	private bool ShowSafeLeaveUpdate;

	// Token: 0x04006FF2 RID: 28658
	[Nullable(2)]
	private Action ConfirmCallback;

	// Token: 0x04006FF3 RID: 28659
	[Nullable(2)]
	private Action CancelCallback;

	// Token: 0x020084A8 RID: 33960
	private enum EComponentType
	{
		// Token: 0x0402B2DF RID: 176863
		TitleText,
		// Token: 0x0402B2E0 RID: 176864
		SubTitleText,
		// Token: 0x0402B2E1 RID: 176865
		ContentText,
		// Token: 0x0402B2E2 RID: 176866
		SubContentText,
		// Token: 0x0402B2E3 RID: 176867
		CancelButton,
		// Token: 0x0402B2E4 RID: 176868
		ConfirmButton,
		// Token: 0x0402B2E5 RID: 176869
		BackButton,
		// Token: 0x0402B2E6 RID: 176870
		BgButton,
		// Token: 0x0402B2E7 RID: 176871
		CancelButtonText,
		// Token: 0x0402B2E8 RID: 176872
		ConfirmButtonText
	}
}

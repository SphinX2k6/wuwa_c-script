using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001121 RID: 4385
public class GachaAccumulateBonusView : UiViewBase
{
	// Token: 0x0600AF30 RID: 44848 RVA: 0x00339C3D File Offset: 0x00337E3D
	[NullableContext(1)]
	public GachaAccumulateBonusView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600AF31 RID: 44849 RVA: 0x00339C48 File Offset: 0x00337E48
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnMaskButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600AF32 RID: 44850 RVA: 0x00339CEE File Offset: 0x00337EEE
	private void OnMaskButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600AF33 RID: 44851 RVA: 0x00339CF8 File Offset: 0x00337EF8
	protected override UniTask OnBeforeStartAsync()
	{
		GachaAccumulateBonusView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GachaAccumulateBonusView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AF34 RID: 44852 RVA: 0x00339D3B File Offset: 0x00337F3B
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.GachaAccumulateRewardClaimed, new Action<int>(this.OnGachaAccumulateRewardClaimed));
	}

	// Token: 0x0600AF35 RID: 44853 RVA: 0x00339D59 File Offset: 0x00337F59
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.GachaAccumulateRewardClaimed, new Action<int>(this.OnGachaAccumulateRewardClaimed));
	}

	// Token: 0x0600AF36 RID: 44854 RVA: 0x00339D77 File Offset: 0x00337F77
	private void OnGachaAccumulateRewardClaimed(int accumulateId)
	{
		if (accumulateId == this.CurrentAccumulateId)
		{
			this.Content.RefreshView(accumulateId);
		}
	}

	// Token: 0x0600AF37 RID: 44855 RVA: 0x00339D90 File Offset: 0x00337F90
	protected override UniTask OnPlayingStartSequenceAsync()
	{
		GachaAccumulateBonusView.<OnPlayingStartSequenceAsync>d__9 <OnPlayingStartSequenceAsync>d__;
		<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingStartSequenceAsync>d__.<>4__this = this;
		<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
		<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<GachaAccumulateBonusView.<OnPlayingStartSequenceAsync>d__9>(ref <OnPlayingStartSequenceAsync>d__);
		return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AF38 RID: 44856 RVA: 0x00339DD4 File Offset: 0x00337FD4
	protected override UniTask OnPlayingCloseSequenceAsync()
	{
		GachaAccumulateBonusView.<OnPlayingCloseSequenceAsync>d__10 <OnPlayingCloseSequenceAsync>d__;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
		<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<GachaAccumulateBonusView.<OnPlayingCloseSequenceAsync>d__10>(ref <OnPlayingCloseSequenceAsync>d__);
		return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AF39 RID: 44857 RVA: 0x00339E18 File Offset: 0x00338018
	protected override void OnBeforeShow()
	{
		object openParam = this.OpenParam;
		int num2;
		if (openParam is int)
		{
			int num = (int)openParam;
			num2 = num;
		}
		else
		{
			num2 = 0;
		}
		int accumulateId = num2;
		this.Content.RefreshView(accumulateId);
	}

	// Token: 0x0600AF3A RID: 44858 RVA: 0x00339E4E File Offset: 0x0033804E
	private void OnBackButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x04006518 RID: 25880
	[Nullable(2)]
	private GachaAccumulateBonusContentBase Content;

	// Token: 0x04006519 RID: 25881
	private int CurrentAccumulateId;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C62 RID: 7266
public class GachaAccumulateBonusView : UiViewBase
{
	// Token: 0x0600DB1A RID: 56090 RVA: 0x0032E7F1 File Offset: 0x0032C9F1
	[NullableContext(1)]
	public GachaAccumulateBonusView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600DB1B RID: 56091 RVA: 0x0032E7FC File Offset: 0x0032C9FC
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

	// Token: 0x0600DB1C RID: 56092 RVA: 0x0032E8A2 File Offset: 0x0032CAA2
	private void OnMaskButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600DB1D RID: 56093 RVA: 0x0032E8AC File Offset: 0x0032CAAC
	protected override UniTask OnBeforeStartAsync()
	{
		GachaAccumulateBonusView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GachaAccumulateBonusView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DB1E RID: 56094 RVA: 0x0032E8EF File Offset: 0x0032CAEF
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.GachaAccumulateRewardClaimed, new Action<int>(this.OnGachaAccumulateRewardClaimed));
	}

	// Token: 0x0600DB1F RID: 56095 RVA: 0x0032E90D File Offset: 0x0032CB0D
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.GachaAccumulateRewardClaimed, new Action<int>(this.OnGachaAccumulateRewardClaimed));
	}

	// Token: 0x0600DB20 RID: 56096 RVA: 0x0032E92B File Offset: 0x0032CB2B
	private void OnGachaAccumulateRewardClaimed(int accumulateId)
	{
		if (accumulateId == this.CurrentAccumulateId)
		{
			this.Content.RefreshView(accumulateId);
		}
	}

	// Token: 0x0600DB21 RID: 56097 RVA: 0x0032E944 File Offset: 0x0032CB44
	protected override UniTask OnPlayingStartSequenceAsync()
	{
		GachaAccumulateBonusView.<OnPlayingStartSequenceAsync>d__9 <OnPlayingStartSequenceAsync>d__;
		<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingStartSequenceAsync>d__.<>4__this = this;
		<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
		<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<GachaAccumulateBonusView.<OnPlayingStartSequenceAsync>d__9>(ref <OnPlayingStartSequenceAsync>d__);
		return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DB22 RID: 56098 RVA: 0x0032E988 File Offset: 0x0032CB88
	protected override UniTask OnPlayingCloseSequenceAsync()
	{
		GachaAccumulateBonusView.<OnPlayingCloseSequenceAsync>d__10 <OnPlayingCloseSequenceAsync>d__;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
		<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<GachaAccumulateBonusView.<OnPlayingCloseSequenceAsync>d__10>(ref <OnPlayingCloseSequenceAsync>d__);
		return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DB23 RID: 56099 RVA: 0x0032E9CC File Offset: 0x0032CBCC
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

	// Token: 0x0600DB24 RID: 56100 RVA: 0x0032EA02 File Offset: 0x0032CC02
	private void OnBackButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x04006446 RID: 25670
	[Nullable(2)]
	private GachaAccumulateBonusContentBase Content;

	// Token: 0x04006447 RID: 25671
	private int CurrentAccumulateId;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F4C RID: 8012
public class LockPredictedUnit : HudUnitBase
{
	// Token: 0x0600F7C2 RID: 63426 RVA: 0x003BED24 File Offset: 0x003BCF24
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F7C3 RID: 63427 RVA: 0x003BEDCF File Offset: 0x003BCFCF
	protected override void OnStart()
	{
		base.InitTweenAnim(2);
		base.InitTweenAnim(3);
	}

	// Token: 0x0600F7C4 RID: 63428 RVA: 0x003BEDDF File Offset: 0x003BCFDF
	protected override void OnAfterShow()
	{
		this.PlayStartAnim();
	}

	// Token: 0x0600F7C5 RID: 63429 RVA: 0x003BEDE8 File Offset: 0x003BCFE8
	protected override UniTask OnBeforeHideAsync()
	{
		LockPredictedUnit.<OnBeforeHideAsync>d__8 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<LockPredictedUnit.<OnBeforeHideAsync>d__8>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F7C6 RID: 63430 RVA: 0x003BEE2B File Offset: 0x003BD02B
	private void OnCloseAnimTimerEnd()
	{
		this.CloseTimer = null;
		this.Promise.SetResult();
		this.Promise = null;
	}

	// Token: 0x0600F7C7 RID: 63431 RVA: 0x003BEE46 File Offset: 0x003BD046
	protected override void OnBeforeDestroy()
	{
		if (this.CloseTimer != null)
		{
			TimerSystem.Instance.Remove(this.CloseTimer);
			this.CloseTimer = null;
			this.Promise.SetResult();
			this.Promise = null;
		}
	}

	// Token: 0x0600F7C8 RID: 63432 RVA: 0x003BEE7A File Offset: 0x003BD07A
	public void Activate()
	{
		base.SetVisible(true, 0);
	}

	// Token: 0x0600F7C9 RID: 63433 RVA: 0x003BEE84 File Offset: 0x003BD084
	public void Deactivate()
	{
		base.SetVisible(false, 0);
	}

	// Token: 0x0600F7CA RID: 63434 RVA: 0x003BEE8E File Offset: 0x003BD08E
	private void PlayStartAnim()
	{
		base.StopTweenAnim(3);
		base.PlayTweenAnim(2);
	}

	// Token: 0x0600F7CB RID: 63435 RVA: 0x003BEE9E File Offset: 0x003BD09E
	private void PlayCloseAnim()
	{
		base.StopTweenAnim(2);
		base.PlayTweenAnim(3);
	}

	// Token: 0x040072E2 RID: 29410
	private const int CLOSE_ANIM_TIME = 200;

	// Token: 0x040072E3 RID: 29411
	[Nullable(2)]
	private TimerHandle CloseTimer;

	// Token: 0x040072E4 RID: 29412
	[Nullable(2)]
	private CustomPromise Promise;

	// Token: 0x02008542 RID: 34114
	private enum EChildType
	{
		// Token: 0x0402B622 RID: 177698
		Arrow,
		// Token: 0x0402B623 RID: 177699
		CenterPoint,
		// Token: 0x0402B624 RID: 177700
		AnimStart,
		// Token: 0x0402B625 RID: 177701
		AnimClose
	}

	// Token: 0x02008543 RID: 34115
	private enum EVisibleReason
	{
		// Token: 0x0402B627 RID: 177703
		Default
	}
}

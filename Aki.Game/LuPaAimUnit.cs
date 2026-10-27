using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F4D RID: 8013
public class LuPaAimUnit : HudUnitBase
{
	// Token: 0x0600F7CE RID: 63438 RVA: 0x003BEEC0 File Offset: 0x003BD0C0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F7CF RID: 63439 RVA: 0x003BEFAD File Offset: 0x003BD1AD
	protected override void OnStart()
	{
		base.InitTweenAnim(3);
		base.InitTweenAnim(4);
		base.InitTweenAnim(5);
	}

	// Token: 0x0600F7D0 RID: 63440 RVA: 0x003BEFC4 File Offset: 0x003BD1C4
	protected override void OnBeforeShow()
	{
		base.StopTweenAnim(4);
		base.PlayTweenAnim(3);
	}

	// Token: 0x0600F7D1 RID: 63441 RVA: 0x003BEFD4 File Offset: 0x003BD1D4
	protected override UniTask OnBeforeHideAsync()
	{
		LuPaAimUnit.<OnBeforeHideAsync>d__10 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<LuPaAimUnit.<OnBeforeHideAsync>d__10>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F7D2 RID: 63442 RVA: 0x003BF017 File Offset: 0x003BD217
	private void OnCloseAnimTimerEnd()
	{
		this.CloseTimer = null;
		this.Promise.SetResult();
		this.Promise = null;
	}

	// Token: 0x0600F7D3 RID: 63443 RVA: 0x003BF032 File Offset: 0x003BD232
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

	// Token: 0x0600F7D4 RID: 63444 RVA: 0x003BF066 File Offset: 0x003BD266
	public void SetTargetVisible(bool visible)
	{
		this.TargetVisible = visible;
		base.SetVisible(visible, 0);
	}

	// Token: 0x0600F7D5 RID: 63445 RVA: 0x003BF077 File Offset: 0x003BD277
	public bool GetTargetVisible()
	{
		return this.TargetVisible;
	}

	// Token: 0x0600F7D6 RID: 63446 RVA: 0x003BF07F File Offset: 0x003BD27F
	public override void SetActive(bool visibility)
	{
		if (visibility && !this.TargetVisible)
		{
			return;
		}
		base.SetActive(visibility);
	}

	// Token: 0x0600F7D7 RID: 63447 RVA: 0x003BF094 File Offset: 0x003BD294
	public void SetProgress(float percent)
	{
		UUISprite sprite = base.GetSprite(0);
		if (sprite == null)
		{
			return;
		}
		sprite.SetFillAmount(percent);
	}

	// Token: 0x0600F7D8 RID: 63448 RVA: 0x003BF0A8 File Offset: 0x003BD2A8
	public void SetLockState(bool hasTarget)
	{
		if (this.LockState == hasTarget && this.IsInitLockState)
		{
			return;
		}
		this.LockState = hasTarget;
		base.GetItem(1).SetUIActive(!hasTarget);
		base.GetItem(2).SetUIActive(hasTarget);
		if (!this.IsInitLockState)
		{
			this.IsInitLockState = true;
		}
		if (base.IsShowOrShowing)
		{
			base.PlayTweenAnim(5);
		}
	}

	// Token: 0x040072E5 RID: 29413
	private const int CLOSE_ANIM_TIME = 100;

	// Token: 0x040072E6 RID: 29414
	private bool TargetVisible;

	// Token: 0x040072E7 RID: 29415
	private bool IsInitLockState;

	// Token: 0x040072E8 RID: 29416
	private bool LockState;

	// Token: 0x040072E9 RID: 29417
	[Nullable(2)]
	private TimerHandle CloseTimer;

	// Token: 0x040072EA RID: 29418
	[Nullable(2)]
	private CustomPromise Promise;

	// Token: 0x02008545 RID: 34117
	private enum EChildType
	{
		// Token: 0x0402B62D RID: 177709
		ProgressSprite,
		// Token: 0x0402B62E RID: 177710
		StateItem1,
		// Token: 0x0402B62F RID: 177711
		StateItem2,
		// Token: 0x0402B630 RID: 177712
		AniStart,
		// Token: 0x0402B631 RID: 177713
		AniClose,
		// Token: 0x0402B632 RID: 177714
		AniSwitch
	}
}

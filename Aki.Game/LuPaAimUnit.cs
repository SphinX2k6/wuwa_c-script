using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200140F RID: 5135
public class LuPaAimUnit : HudUnitBase
{
	// Token: 0x0600CBED RID: 52205 RVA: 0x003CA9AC File Offset: 0x003C8BAC
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

	// Token: 0x0600CBEE RID: 52206 RVA: 0x003CAA99 File Offset: 0x003C8C99
	protected override void OnStart()
	{
		base.InitTweenAnim(3);
		base.InitTweenAnim(4);
		base.InitTweenAnim(5);
	}

	// Token: 0x0600CBEF RID: 52207 RVA: 0x003CAAB0 File Offset: 0x003C8CB0
	protected override void OnBeforeShow()
	{
		base.StopTweenAnim(4);
		base.PlayTweenAnim(3);
	}

	// Token: 0x0600CBF0 RID: 52208 RVA: 0x003CAAC0 File Offset: 0x003C8CC0
	protected override UniTask OnBeforeHideAsync()
	{
		LuPaAimUnit.<OnBeforeHideAsync>d__10 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<LuPaAimUnit.<OnBeforeHideAsync>d__10>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CBF1 RID: 52209 RVA: 0x003CAB03 File Offset: 0x003C8D03
	private void OnCloseAnimTimerEnd()
	{
		this.CloseTimer = null;
		this.Promise.SetResult();
		this.Promise = null;
	}

	// Token: 0x0600CBF2 RID: 52210 RVA: 0x003CAB1E File Offset: 0x003C8D1E
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

	// Token: 0x0600CBF3 RID: 52211 RVA: 0x003CAB52 File Offset: 0x003C8D52
	public void SetTargetVisible(bool visible)
	{
		this.TargetVisible = visible;
		base.SetVisible(visible, 0);
	}

	// Token: 0x0600CBF4 RID: 52212 RVA: 0x003CAB63 File Offset: 0x003C8D63
	public bool GetTargetVisible()
	{
		return this.TargetVisible;
	}

	// Token: 0x0600CBF5 RID: 52213 RVA: 0x003CAB6B File Offset: 0x003C8D6B
	public override void SetActive(bool visibility)
	{
		if (visibility && !this.TargetVisible)
		{
			return;
		}
		base.SetActive(visibility);
	}

	// Token: 0x0600CBF6 RID: 52214 RVA: 0x003CAB80 File Offset: 0x003C8D80
	public void SetProgress(float percent)
	{
		UUISprite sprite = base.GetSprite(0);
		if (sprite == null)
		{
			return;
		}
		sprite.SetFillAmount(percent);
	}

	// Token: 0x0600CBF7 RID: 52215 RVA: 0x003CAB94 File Offset: 0x003C8D94
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

	// Token: 0x040073C6 RID: 29638
	private const int CLOSE_ANIM_TIME = 100;

	// Token: 0x040073C7 RID: 29639
	private bool TargetVisible;

	// Token: 0x040073C8 RID: 29640
	private bool IsInitLockState;

	// Token: 0x040073C9 RID: 29641
	private bool LockState;

	// Token: 0x040073CA RID: 29642
	[Nullable(2)]
	private TimerHandle CloseTimer;

	// Token: 0x040073CB RID: 29643
	[Nullable(2)]
	private CustomPromise Promise;

	// Token: 0x020076CA RID: 30410
	private enum EChildType
	{
		// Token: 0x04026951 RID: 158033
		ProgressSprite,
		// Token: 0x04026952 RID: 158034
		StateItem1,
		// Token: 0x04026953 RID: 158035
		StateItem2,
		// Token: 0x04026954 RID: 158036
		AniStart,
		// Token: 0x04026955 RID: 158037
		AniClose,
		// Token: 0x04026956 RID: 158038
		AniSwitch
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F4B RID: 8011
public class LockExecutionUnit : HudUnitBase
{
	// Token: 0x0600F7B8 RID: 63416 RVA: 0x003BEB98 File Offset: 0x003BCD98
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F7B9 RID: 63417 RVA: 0x003BEC22 File Offset: 0x003BCE22
	protected override void OnStart()
	{
		this.RootItem.SetAnchorAlign(UIAnchorHorizontalAlign.Center, UIAnchorVerticalAlign.Middle);
		base.InitTweenAnim(0);
		base.InitTweenAnim(1);
		base.InitTweenAnim(2);
	}

	// Token: 0x0600F7BA RID: 63418 RVA: 0x003BEC46 File Offset: 0x003BCE46
	public void TryShow()
	{
		if (!base.IsShowOrShowing)
		{
			base.Show(null);
		}
	}

	// Token: 0x0600F7BB RID: 63419 RVA: 0x003BEC57 File Offset: 0x003BCE57
	protected override void OnAfterShow()
	{
		base.StopTweenAnim(2);
		base.PlayTweenAnim(0);
		base.PlayTweenAnim(1);
	}

	// Token: 0x0600F7BC RID: 63420 RVA: 0x003BEC6E File Offset: 0x003BCE6E
	public void TryHide(bool playCloseAnim)
	{
		this.PlayCloseAnim = playCloseAnim;
		if (!base.IsHideOrHiding)
		{
			base.Hide(null);
		}
	}

	// Token: 0x0600F7BD RID: 63421 RVA: 0x003BEC88 File Offset: 0x003BCE88
	protected override UniTask OnBeforeHideAsync()
	{
		LockExecutionUnit.<OnBeforeHideAsync>d__10 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<LockExecutionUnit.<OnBeforeHideAsync>d__10>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F7BE RID: 63422 RVA: 0x003BECCB File Offset: 0x003BCECB
	private void OnCloseAnimTimerEnd()
	{
		this.CloseTimer = null;
		this.Promise.SetResult();
		this.Promise = null;
	}

	// Token: 0x0600F7BF RID: 63423 RVA: 0x003BECE6 File Offset: 0x003BCEE6
	protected override void OnBeforeDestroy()
	{
		if (this.CloseTimer != null)
		{
			TimerSystem.Instance.Remove(this.CloseTimer);
			this.CloseTimer = null;
			this.Promise.SetResult();
		}
	}

	// Token: 0x040072DE RID: 29406
	private const int CLOSE_ANIM_TIME = 200;

	// Token: 0x040072DF RID: 29407
	[Nullable(2)]
	private TimerHandle CloseTimer;

	// Token: 0x040072E0 RID: 29408
	private bool PlayCloseAnim;

	// Token: 0x040072E1 RID: 29409
	[Nullable(2)]
	private CustomPromise Promise;

	// Token: 0x02008540 RID: 34112
	private enum EChildType
	{
		// Token: 0x0402B61A RID: 177690
		AnimStart,
		// Token: 0x0402B61B RID: 177691
		AnimLoop,
		// Token: 0x0402B61C RID: 177692
		AnimClose
	}
}

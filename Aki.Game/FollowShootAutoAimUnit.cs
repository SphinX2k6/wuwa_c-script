using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F47 RID: 8007
[NullableContext(2)]
[Nullable(0)]
public class FollowShootAutoAimUnit : HudUnitBase
{
	// Token: 0x0600F77F RID: 63359 RVA: 0x003BDCDC File Offset: 0x003BBEDC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
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
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F780 RID: 63360 RVA: 0x003BDDEA File Offset: 0x003BBFEA
	protected override void OnStart()
	{
		this.TargetItem = base.GetItem(0);
		this.RingAimItem = base.GetItem(6);
		this.IsTargetItemActive = false;
		this.TargetItem.SetUIActive(false);
		this.InitAllTweenAnim();
		this.IsActive = true;
	}

	// Token: 0x0600F781 RID: 63361 RVA: 0x003BDE26 File Offset: 0x003BC026
	protected override void OnAfterShow()
	{
		base.StopTweenAnim(2);
		base.PlayTweenAnim(1);
	}

	// Token: 0x0600F782 RID: 63362 RVA: 0x003BDE38 File Offset: 0x003BC038
	protected override UniTask OnBeforeHideAsync()
	{
		FollowShootAutoAimUnit.<OnBeforeHideAsync>d__11 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<FollowShootAutoAimUnit.<OnBeforeHideAsync>d__11>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F783 RID: 63363 RVA: 0x003BDE7B File Offset: 0x003BC07B
	protected override void OnBeforeDestroy()
	{
		this.TargetItem = null;
		this.DestroyCloseAnimTimer();
		base.OnBeforeDestroy();
	}

	// Token: 0x0600F784 RID: 63364 RVA: 0x003BDE90 File Offset: 0x003BC090
	public void SetTargetItemOffset(float x, float y)
	{
		if (this.TargetItem == null)
		{
			return;
		}
		this.TargetItem.SetAnchorOffsetX(x);
		this.TargetItem.SetAnchorOffsetY(y);
	}

	// Token: 0x0600F785 RID: 63365 RVA: 0x003BDEB4 File Offset: 0x003BC0B4
	public void SetTargetAimVisible(bool isVisible, bool isTargetChanged)
	{
		if (this.TargetItem == null)
		{
			return;
		}
		if (this.IsTargetItemActive == isVisible)
		{
			return;
		}
		this.IsTargetItemActive = isVisible;
		this.TargetItem.SetUIActive(isVisible);
		if (isVisible)
		{
			this.TargetItem.SetUIActive(true);
			this.PlayStartAimAnim();
			this.PlayLoopAimAnim();
			return;
		}
		this.StopLoopAimAnim();
		this.PlayCloseAimAnim();
	}

	// Token: 0x0600F786 RID: 63366 RVA: 0x003BDF0F File Offset: 0x003BC10F
	public void SetRingAimVisible(bool isVisible)
	{
		if (this.RingAimItem == null)
		{
			return;
		}
		this.RingAimItem.SetUIActive(isVisible);
	}

	// Token: 0x0600F787 RID: 63367 RVA: 0x003BDF26 File Offset: 0x003BC126
	private void DestroyCloseAnimTimer()
	{
		if (this.CloseAnimTimer != null)
		{
			TimerSystem.Instance.Remove(this.CloseAnimTimer);
			this.CloseAnimTimer = null;
		}
		if (this.CloseAnimPromise != null)
		{
			this.CloseAnimPromise.SetResult();
			this.CloseAnimPromise = null;
		}
	}

	// Token: 0x0600F788 RID: 63368 RVA: 0x003BDF62 File Offset: 0x003BC162
	private void InitAllTweenAnim()
	{
		base.InitTweenAnim(1);
		base.InitTweenAnim(2);
		base.InitTweenAnim(3);
		base.InitTweenAnim(4);
		base.InitTweenAnim(5);
	}

	// Token: 0x0600F789 RID: 63369 RVA: 0x003BDF87 File Offset: 0x003BC187
	public void PlayStartAimAnim()
	{
		if (!this.IsActive)
		{
			return;
		}
		base.PlayTweenAnim(3);
	}

	// Token: 0x0600F78A RID: 63370 RVA: 0x003BDF99 File Offset: 0x003BC199
	public void PlayCloseAimAnim()
	{
		if (!this.IsActive)
		{
			return;
		}
		base.PlayTweenAnim(4);
	}

	// Token: 0x0600F78B RID: 63371 RVA: 0x003BDFAB File Offset: 0x003BC1AB
	public void PlayLoopAimAnim()
	{
		if (!this.IsActive)
		{
			return;
		}
		base.PlayTweenAnim(5);
	}

	// Token: 0x0600F78C RID: 63372 RVA: 0x003BDFBD File Offset: 0x003BC1BD
	public void StopLoopAimAnim()
	{
		if (!this.IsActive)
		{
			return;
		}
		base.StopTweenAnim(5);
	}

	// Token: 0x040072C4 RID: 29380
	private const int CLOSE_ANIM_TIME = 200;

	// Token: 0x040072C5 RID: 29381
	private UUIItem TargetItem;

	// Token: 0x040072C6 RID: 29382
	private TimerHandle CloseAnimTimer;

	// Token: 0x040072C7 RID: 29383
	private CustomPromise CloseAnimPromise;

	// Token: 0x040072C8 RID: 29384
	private bool IsActive;

	// Token: 0x040072C9 RID: 29385
	private bool IsTargetItemActive;

	// Token: 0x040072CA RID: 29386
	private UUIItem RingAimItem;

	// Token: 0x02008536 RID: 34102
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402B5EB RID: 177643
		TargetItem,
		// Token: 0x0402B5EC RID: 177644
		AnimStart,
		// Token: 0x0402B5ED RID: 177645
		AnimClose,
		// Token: 0x0402B5EE RID: 177646
		AnimStartAim,
		// Token: 0x0402B5EF RID: 177647
		AnimCloseAim,
		// Token: 0x0402B5F0 RID: 177648
		AnimLoopAim,
		// Token: 0x0402B5F1 RID: 177649
		RingAim
	}
}

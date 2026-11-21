using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001409 RID: 5129
[NullableContext(2)]
[Nullable(0)]
public class FollowShootAutoAimUnit : HudUnitBase
{
	// Token: 0x0600CB9E RID: 52126 RVA: 0x003C97C8 File Offset: 0x003C79C8
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

	// Token: 0x0600CB9F RID: 52127 RVA: 0x003C98D6 File Offset: 0x003C7AD6
	protected override void OnStart()
	{
		this.TargetItem = base.GetItem(0);
		this.RingAimItem = base.GetItem(6);
		this.IsTargetItemActive = false;
		this.TargetItem.SetUIActive(false);
		this.InitAllTweenAnim();
		this.IsActive = true;
	}

	// Token: 0x0600CBA0 RID: 52128 RVA: 0x003C9912 File Offset: 0x003C7B12
	protected override void OnAfterShow()
	{
		base.StopTweenAnim(2);
		base.PlayTweenAnim(1);
	}

	// Token: 0x0600CBA1 RID: 52129 RVA: 0x003C9924 File Offset: 0x003C7B24
	protected override UniTask OnBeforeHideAsync()
	{
		FollowShootAutoAimUnit.<OnBeforeHideAsync>d__11 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<FollowShootAutoAimUnit.<OnBeforeHideAsync>d__11>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CBA2 RID: 52130 RVA: 0x003C9967 File Offset: 0x003C7B67
	protected override void OnBeforeDestroy()
	{
		this.TargetItem = null;
		this.DestroyCloseAnimTimer();
		base.OnBeforeDestroy();
	}

	// Token: 0x0600CBA3 RID: 52131 RVA: 0x003C997C File Offset: 0x003C7B7C
	public void SetTargetItemOffset(float x, float y)
	{
		if (this.TargetItem == null)
		{
			return;
		}
		this.TargetItem.SetAnchorOffsetX(x);
		this.TargetItem.SetAnchorOffsetY(y);
	}

	// Token: 0x0600CBA4 RID: 52132 RVA: 0x003C99A0 File Offset: 0x003C7BA0
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

	// Token: 0x0600CBA5 RID: 52133 RVA: 0x003C99FB File Offset: 0x003C7BFB
	public void SetRingAimVisible(bool isVisible)
	{
		if (this.RingAimItem == null)
		{
			return;
		}
		this.RingAimItem.SetUIActive(isVisible);
	}

	// Token: 0x0600CBA6 RID: 52134 RVA: 0x003C9A12 File Offset: 0x003C7C12
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

	// Token: 0x0600CBA7 RID: 52135 RVA: 0x003C9A4E File Offset: 0x003C7C4E
	private void InitAllTweenAnim()
	{
		base.InitTweenAnim(1);
		base.InitTweenAnim(2);
		base.InitTweenAnim(3);
		base.InitTweenAnim(4);
		base.InitTweenAnim(5);
	}

	// Token: 0x0600CBA8 RID: 52136 RVA: 0x003C9A73 File Offset: 0x003C7C73
	public void PlayStartAimAnim()
	{
		if (!this.IsActive)
		{
			return;
		}
		base.PlayTweenAnim(3);
	}

	// Token: 0x0600CBA9 RID: 52137 RVA: 0x003C9A85 File Offset: 0x003C7C85
	public void PlayCloseAimAnim()
	{
		if (!this.IsActive)
		{
			return;
		}
		base.PlayTweenAnim(4);
	}

	// Token: 0x0600CBAA RID: 52138 RVA: 0x003C9A97 File Offset: 0x003C7C97
	public void PlayLoopAimAnim()
	{
		if (!this.IsActive)
		{
			return;
		}
		base.PlayTweenAnim(5);
	}

	// Token: 0x0600CBAB RID: 52139 RVA: 0x003C9AA9 File Offset: 0x003C7CA9
	public void StopLoopAimAnim()
	{
		if (!this.IsActive)
		{
			return;
		}
		base.StopTweenAnim(5);
	}

	// Token: 0x040073A5 RID: 29605
	private const int CLOSE_ANIM_TIME = 200;

	// Token: 0x040073A6 RID: 29606
	private UUIItem TargetItem;

	// Token: 0x040073A7 RID: 29607
	private TimerHandle CloseAnimTimer;

	// Token: 0x040073A8 RID: 29608
	private CustomPromise CloseAnimPromise;

	// Token: 0x040073A9 RID: 29609
	private bool IsActive;

	// Token: 0x040073AA RID: 29610
	private bool IsTargetItemActive;

	// Token: 0x040073AB RID: 29611
	private UUIItem RingAimItem;

	// Token: 0x020076BB RID: 30395
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402690F RID: 157967
		TargetItem,
		// Token: 0x04026910 RID: 157968
		AnimStart,
		// Token: 0x04026911 RID: 157969
		AnimClose,
		// Token: 0x04026912 RID: 157970
		AnimStartAim,
		// Token: 0x04026913 RID: 157971
		AnimCloseAim,
		// Token: 0x04026914 RID: 157972
		AnimLoopAim,
		// Token: 0x04026915 RID: 157973
		RingAim
	}
}

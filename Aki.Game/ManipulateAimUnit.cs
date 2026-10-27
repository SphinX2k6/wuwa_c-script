using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001F4E RID: 8014
[NullableContext(2)]
[Nullable(0)]
public class ManipulateAimUnit : HudUnitBase
{
	// Token: 0x0600F7DB RID: 63451 RVA: 0x003BF11C File Offset: 0x003BD31C
	protected unsafe override void OnRegisterComponent()
	{
		if (this.ResourceId == "UiView_Sight")
		{
			this.ExistAnim = true;
		}
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		if (this.ExistAnim)
		{
			num2 = 7;
			List<ValueTuple<int, Type>> list2 = new List<ValueTuple<int, Type>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list2, num2);
			span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list2);
			num = 0;
			*span[num] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num++;
			*span[num] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num++;
			*span[num] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num++;
			*span[num] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num++;
			*span[num] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num++;
			*span[num] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num++;
			*span[num] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list2;
		}
	}

	// Token: 0x0600F7DC RID: 63452 RVA: 0x003BF2AA File Offset: 0x003BD4AA
	protected override void OnStart()
	{
		this.TargetItem = base.GetItem(0);
		this.WeaknessItem = base.GetItem(1);
		this.IsTargetItemActive = false;
		this.TargetItem.SetUIActive(false);
		this.InitAllTweenAnim();
		this.PlayStartAnim();
	}

	// Token: 0x0600F7DD RID: 63453 RVA: 0x003BF2E5 File Offset: 0x003BD4E5
	protected override void OnBeforeDestroy()
	{
		this.TargetItem = null;
		this.WeaknessItem = null;
		this.CloseAnimCallback = null;
		base.OnBeforeDestroy();
	}

	// Token: 0x0600F7DE RID: 63454 RVA: 0x003BF302 File Offset: 0x003BD502
	public void SetTargetItemOffset(float x, float y)
	{
		if (this.TargetItem == null)
		{
			return;
		}
		this.TargetItem.SetAnchorOffsetX(x);
		this.TargetItem.SetAnchorOffsetY(y);
	}

	// Token: 0x0600F7DF RID: 63455 RVA: 0x003BF328 File Offset: 0x003BD528
	public void SetTargetAimVisible(bool isVisible)
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
		if (!this.ExistAnim)
		{
			this.TargetItem.SetUIActive(isVisible);
			return;
		}
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

	// Token: 0x0600F7E0 RID: 63456 RVA: 0x003BF38C File Offset: 0x003BD58C
	public void SetIsWeakness(bool isWeakness)
	{
		if (this.WeaknessItem == null)
		{
			return;
		}
		if (this.WeaknessItem.IsUIActiveSelf() == isWeakness)
		{
			return;
		}
		this.WeaknessItem.SetUIActive(isWeakness);
	}

	// Token: 0x0600F7E1 RID: 63457 RVA: 0x003BF3B2 File Offset: 0x003BD5B2
	private void InitAllTweenAnim()
	{
		if (!this.ExistAnim)
		{
			return;
		}
		base.InitTweenAnim(2);
		base.InitTweenAnim(3);
		base.InitTweenAnim(4);
		base.InitTweenAnim(5);
		base.InitTweenAnim(6);
	}

	// Token: 0x0600F7E2 RID: 63458 RVA: 0x003BF3E0 File Offset: 0x003BD5E0
	public void PlayStartAnim()
	{
		this.IsActive = true;
		this.StopCloseAnim();
		this.TryPlayTweenAnim(2);
	}

	// Token: 0x0600F7E3 RID: 63459 RVA: 0x003BF3F8 File Offset: 0x003BD5F8
	public void PlayCloseAnim()
	{
		if (!this.IsActive)
		{
			return;
		}
		this.IsActive = false;
		this.DestroyCloseTimer();
		if (!base.InAsyncLoading())
		{
			this.CloseTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.OnCloseAnimTimerEnd();
			}, 200f, null, null, true, 1f);
			this.TryPlayTweenAnim(3);
			return;
		}
		Action closeAnimCallback = this.CloseAnimCallback;
		if (closeAnimCallback == null)
		{
			return;
		}
		closeAnimCallback();
	}

	// Token: 0x0600F7E4 RID: 63460 RVA: 0x003BF464 File Offset: 0x003BD664
	private void OnCloseAnimTimerEnd()
	{
		this.CloseTimer = null;
		Action closeAnimCallback = this.CloseAnimCallback;
		if (closeAnimCallback == null)
		{
			return;
		}
		closeAnimCallback();
	}

	// Token: 0x0600F7E5 RID: 63461 RVA: 0x003BF47D File Offset: 0x003BD67D
	public void StopCloseAnim()
	{
		this.DestroyCloseTimer();
		this.TryStopTweenAnim(3);
	}

	// Token: 0x0600F7E6 RID: 63462 RVA: 0x003BF48C File Offset: 0x003BD68C
	private void DestroyCloseTimer()
	{
		if (this.CloseTimer != null)
		{
			TimerSystem.Instance.Remove(this.CloseTimer);
			this.CloseTimer = null;
		}
	}

	// Token: 0x0600F7E7 RID: 63463 RVA: 0x003BF4AE File Offset: 0x003BD6AE
	[NullableContext(1)]
	public void SetCloseAnimCallback(Action closeAnimCallback)
	{
		this.CloseAnimCallback = closeAnimCallback;
	}

	// Token: 0x0600F7E8 RID: 63464 RVA: 0x003BF4B7 File Offset: 0x003BD6B7
	public void PlayStartAimAnim()
	{
		if (!this.IsActive)
		{
			return;
		}
		this.TryPlayTweenAnim(4);
	}

	// Token: 0x0600F7E9 RID: 63465 RVA: 0x003BF4C9 File Offset: 0x003BD6C9
	public void PlayCloseAimAnim()
	{
		if (!this.IsActive)
		{
			return;
		}
		this.TryPlayTweenAnim(5);
	}

	// Token: 0x0600F7EA RID: 63466 RVA: 0x003BF4DB File Offset: 0x003BD6DB
	public void PlayLoopAimAnim()
	{
		if (!this.IsActive)
		{
			return;
		}
		this.TryPlayTweenAnim(6);
	}

	// Token: 0x0600F7EB RID: 63467 RVA: 0x003BF4ED File Offset: 0x003BD6ED
	public void StopLoopAimAnim()
	{
		if (!this.IsActive)
		{
			return;
		}
		this.TryStopTweenAnim(6);
	}

	// Token: 0x0600F7EC RID: 63468 RVA: 0x003BF4FF File Offset: 0x003BD6FF
	private void TryPlayTweenAnim(int componentType)
	{
		if (!this.ExistAnim)
		{
			return;
		}
		base.PlayTweenAnim(componentType);
	}

	// Token: 0x0600F7ED RID: 63469 RVA: 0x003BF511 File Offset: 0x003BD711
	private void TryStopTweenAnim(int componentType)
	{
		if (!this.ExistAnim)
		{
			return;
		}
		base.StopTweenAnim(componentType);
	}

	// Token: 0x040072EB RID: 29419
	private const int CLOSE_ANIM_TIME = 200;

	// Token: 0x040072EC RID: 29420
	private UUIItem TargetItem;

	// Token: 0x040072ED RID: 29421
	private UUIItem WeaknessItem;

	// Token: 0x040072EE RID: 29422
	private bool ExistAnim;

	// Token: 0x040072EF RID: 29423
	private TimerHandle CloseTimer;

	// Token: 0x040072F0 RID: 29424
	private Action CloseAnimCallback;

	// Token: 0x040072F1 RID: 29425
	private bool IsActive;

	// Token: 0x040072F2 RID: 29426
	private bool IsTargetItemActive;

	// Token: 0x02008547 RID: 34119
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402B638 RID: 177720
		TargetItem,
		// Token: 0x0402B639 RID: 177721
		WeaknessItem,
		// Token: 0x0402B63A RID: 177722
		AnimStart,
		// Token: 0x0402B63B RID: 177723
		AnimClose,
		// Token: 0x0402B63C RID: 177724
		AnimStartAim,
		// Token: 0x0402B63D RID: 177725
		AnimCloseAim,
		// Token: 0x0402B63E RID: 177726
		AnimLoopAim
	}
}

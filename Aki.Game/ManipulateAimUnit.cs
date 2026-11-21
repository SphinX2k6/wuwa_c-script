using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001410 RID: 5136
[NullableContext(2)]
[Nullable(0)]
public class ManipulateAimUnit : HudUnitBase
{
	// Token: 0x0600CBFA RID: 52218 RVA: 0x003CAC08 File Offset: 0x003C8E08
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

	// Token: 0x0600CBFB RID: 52219 RVA: 0x003CAD96 File Offset: 0x003C8F96
	protected override void OnStart()
	{
		this.TargetItem = base.GetItem(0);
		this.WeaknessItem = base.GetItem(1);
		this.IsTargetItemActive = false;
		this.TargetItem.SetUIActive(false);
		this.InitAllTweenAnim();
		this.PlayStartAnim();
	}

	// Token: 0x0600CBFC RID: 52220 RVA: 0x003CADD1 File Offset: 0x003C8FD1
	protected override void OnBeforeDestroy()
	{
		this.TargetItem = null;
		this.WeaknessItem = null;
		this.CloseAnimCallback = null;
		base.OnBeforeDestroy();
	}

	// Token: 0x0600CBFD RID: 52221 RVA: 0x003CADEE File Offset: 0x003C8FEE
	public void SetTargetItemOffset(float x, float y)
	{
		if (this.TargetItem == null)
		{
			return;
		}
		this.TargetItem.SetAnchorOffsetX(x);
		this.TargetItem.SetAnchorOffsetY(y);
	}

	// Token: 0x0600CBFE RID: 52222 RVA: 0x003CAE14 File Offset: 0x003C9014
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

	// Token: 0x0600CBFF RID: 52223 RVA: 0x003CAE78 File Offset: 0x003C9078
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

	// Token: 0x0600CC00 RID: 52224 RVA: 0x003CAE9E File Offset: 0x003C909E
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

	// Token: 0x0600CC01 RID: 52225 RVA: 0x003CAECC File Offset: 0x003C90CC
	public void PlayStartAnim()
	{
		this.IsActive = true;
		this.StopCloseAnim();
		this.TryPlayTweenAnim(2);
	}

	// Token: 0x0600CC02 RID: 52226 RVA: 0x003CAEE4 File Offset: 0x003C90E4
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

	// Token: 0x0600CC03 RID: 52227 RVA: 0x003CAF50 File Offset: 0x003C9150
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

	// Token: 0x0600CC04 RID: 52228 RVA: 0x003CAF69 File Offset: 0x003C9169
	public void StopCloseAnim()
	{
		this.DestroyCloseTimer();
		this.TryStopTweenAnim(3);
	}

	// Token: 0x0600CC05 RID: 52229 RVA: 0x003CAF78 File Offset: 0x003C9178
	private void DestroyCloseTimer()
	{
		if (this.CloseTimer != null)
		{
			TimerSystem.Instance.Remove(this.CloseTimer);
			this.CloseTimer = null;
		}
	}

	// Token: 0x0600CC06 RID: 52230 RVA: 0x003CAF9A File Offset: 0x003C919A
	[NullableContext(1)]
	public void SetCloseAnimCallback(Action closeAnimCallback)
	{
		this.CloseAnimCallback = closeAnimCallback;
	}

	// Token: 0x0600CC07 RID: 52231 RVA: 0x003CAFA3 File Offset: 0x003C91A3
	public void PlayStartAimAnim()
	{
		if (!this.IsActive)
		{
			return;
		}
		this.TryPlayTweenAnim(4);
	}

	// Token: 0x0600CC08 RID: 52232 RVA: 0x003CAFB5 File Offset: 0x003C91B5
	public void PlayCloseAimAnim()
	{
		if (!this.IsActive)
		{
			return;
		}
		this.TryPlayTweenAnim(5);
	}

	// Token: 0x0600CC09 RID: 52233 RVA: 0x003CAFC7 File Offset: 0x003C91C7
	public void PlayLoopAimAnim()
	{
		if (!this.IsActive)
		{
			return;
		}
		this.TryPlayTweenAnim(6);
	}

	// Token: 0x0600CC0A RID: 52234 RVA: 0x003CAFD9 File Offset: 0x003C91D9
	public void StopLoopAimAnim()
	{
		if (!this.IsActive)
		{
			return;
		}
		this.TryStopTweenAnim(6);
	}

	// Token: 0x0600CC0B RID: 52235 RVA: 0x003CAFEB File Offset: 0x003C91EB
	private void TryPlayTweenAnim(int componentType)
	{
		if (!this.ExistAnim)
		{
			return;
		}
		base.PlayTweenAnim(componentType);
	}

	// Token: 0x0600CC0C RID: 52236 RVA: 0x003CAFFD File Offset: 0x003C91FD
	private void TryStopTweenAnim(int componentType)
	{
		if (!this.ExistAnim)
		{
			return;
		}
		base.StopTweenAnim(componentType);
	}

	// Token: 0x040073CC RID: 29644
	private const int CLOSE_ANIM_TIME = 200;

	// Token: 0x040073CD RID: 29645
	private UUIItem TargetItem;

	// Token: 0x040073CE RID: 29646
	private UUIItem WeaknessItem;

	// Token: 0x040073CF RID: 29647
	private bool ExistAnim;

	// Token: 0x040073D0 RID: 29648
	private TimerHandle CloseTimer;

	// Token: 0x040073D1 RID: 29649
	private Action CloseAnimCallback;

	// Token: 0x040073D2 RID: 29650
	private bool IsActive;

	// Token: 0x040073D3 RID: 29651
	private bool IsTargetItemActive;

	// Token: 0x020076CC RID: 30412
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402695C RID: 158044
		TargetItem,
		// Token: 0x0402695D RID: 158045
		WeaknessItem,
		// Token: 0x0402695E RID: 158046
		AnimStart,
		// Token: 0x0402695F RID: 158047
		AnimClose,
		// Token: 0x04026960 RID: 158048
		AnimStartAim,
		// Token: 0x04026961 RID: 158049
		AnimCloseAim,
		// Token: 0x04026962 RID: 158050
		AnimLoopAim
	}
}

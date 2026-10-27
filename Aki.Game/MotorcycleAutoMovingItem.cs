using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F5F RID: 8031
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleAutoMovingItem : UiPanelBase
{
	// Token: 0x0600F8C2 RID: 63682 RVA: 0x003C3F2C File Offset: 0x003C212C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F8C3 RID: 63683 RVA: 0x003C403A File Offset: 0x003C223A
	protected override void OnStart()
	{
		this.InitTweenAnim(6);
		this.InitTweenAnim(4);
		this.InitTweenAnim(5);
		this.NitrogenIconSprite = base.GetSprite(3);
		this.AcceleratorIconSprite = base.GetSprite(1);
	}

	// Token: 0x0600F8C4 RID: 63684 RVA: 0x003C406B File Offset: 0x003C226B
	protected override void OnBeforeDestroy()
	{
		this.DestroyCloseAnimTimer();
		base.OnBeforeDestroy();
	}

	// Token: 0x0600F8C5 RID: 63685 RVA: 0x003C4079 File Offset: 0x003C2279
	public void SetVisible(bool bVisible)
	{
		if (this.TargetVisible == bVisible)
		{
			return;
		}
		this.TargetVisible = bVisible;
		if (bVisible)
		{
			this.SetActive(true);
			this.StopTweenAnim(5);
			this.PlayTweenAnim(6);
			return;
		}
		this.PlayCloseAnim();
	}

	// Token: 0x0600F8C6 RID: 63686 RVA: 0x003C40AC File Offset: 0x003C22AC
	private void PlayCloseAnim()
	{
		this.StopTweenAnim(6);
		this.PlayTweenAnim(5);
		this.DestroyCloseAnimTimer();
		this.CloseAnimTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.CloseAnimTimer = null;
			if (!this.TargetVisible)
			{
				this.SetActive(false);
			}
		}, 300f, MotorcycleAutoMovingItem.CloseAnimTimerStat, null, true, 1f);
	}

	// Token: 0x0600F8C7 RID: 63687 RVA: 0x003C40FA File Offset: 0x003C22FA
	private void DestroyCloseAnimTimer()
	{
		if (this.CloseAnimTimer != null)
		{
			TimerSystem.Instance.Remove(this.CloseAnimTimer);
			this.CloseAnimTimer = null;
		}
	}

	// Token: 0x0600F8C8 RID: 63688 RVA: 0x003C411C File Offset: 0x003C231C
	public void SetPercentNitrogen(float percent)
	{
		if (percent == this.LastPercentNitrogen)
		{
			return;
		}
		this.NitrogenIconSprite.SetFillAmount(percent);
		if (percent == 1f)
		{
			this.SetChangeColorNitrogen(true);
			this.PlayTweenAnim(4);
		}
		else if (this.LastPercentNitrogen == 1f)
		{
			this.SetChangeColorNitrogen(false);
		}
		this.LastPercentNitrogen = percent;
	}

	// Token: 0x0600F8C9 RID: 63689 RVA: 0x003C4174 File Offset: 0x003C2374
	public void SetPercentAccelerator(float percent)
	{
		if (percent == this.LastPercentAccelerator)
		{
			return;
		}
		this.AcceleratorIconSprite.SetFillAmount(percent);
		if (percent == 1f)
		{
			this.SetChangeColorAccelerator(true);
			this.PlayTweenAnim(4);
		}
		else if (this.LastPercentAccelerator == 1f)
		{
			this.SetChangeColorAccelerator(false);
		}
		this.LastPercentAccelerator = percent;
	}

	// Token: 0x0600F8CA RID: 63690 RVA: 0x003C41CC File Offset: 0x003C23CC
	public void SetChangeColorNitrogen(bool changeColor)
	{
		if (this.ChangeColorNitrogen == changeColor)
		{
			return;
		}
		this.ChangeColorNitrogen = changeColor;
		UUIItem nitrogenIconSprite = this.NitrogenIconSprite;
		FColor? fcolor = new FColor?(this.NitrogenIconSprite.changeColor);
		nitrogenIconSprite.SetChangeColor(changeColor, fcolor);
	}

	// Token: 0x0600F8CB RID: 63691 RVA: 0x003C420C File Offset: 0x003C240C
	public void SetChangeColorAccelerator(bool changeColor)
	{
		if (this.ChangeColorAccelerator == changeColor)
		{
			return;
		}
		this.ChangeColorAccelerator = changeColor;
		UUIItem acceleratorIconSprite = this.AcceleratorIconSprite;
		FColor? fcolor = new FColor?(this.AcceleratorIconSprite.changeColor);
		acceleratorIconSprite.SetChangeColor(changeColor, fcolor);
	}

	// Token: 0x0600F8CC RID: 63692 RVA: 0x003C4249 File Offset: 0x003C2449
	public void SetNitrogen(bool isNitrogen)
	{
		if (this.IsNitrogen == isNitrogen)
		{
			return;
		}
		this.IsNitrogen = isNitrogen;
		base.GetItem(0).SetUIActive(!isNitrogen);
		base.GetItem(2).SetUIActive(isNitrogen);
	}

	// Token: 0x0600F8CD RID: 63693 RVA: 0x003C4279 File Offset: 0x003C2479
	public bool GetTargetVisible()
	{
		return this.TargetVisible;
	}

	// Token: 0x0600F8CE RID: 63694 RVA: 0x003C4281 File Offset: 0x003C2481
	protected void InitTweenAnim(int componentType)
	{
		this.TweenAnimPlayer.InitTweenAnim(componentType, base.GetItem(componentType), false);
	}

	// Token: 0x0600F8CF RID: 63695 RVA: 0x003C4297 File Offset: 0x003C2497
	protected void PlayTweenAnim(int componentType)
	{
		this.TweenAnimPlayer.PlayTweenAnim(componentType);
	}

	// Token: 0x0600F8D0 RID: 63696 RVA: 0x003C42A5 File Offset: 0x003C24A5
	protected void StopTweenAnim(int componentType)
	{
		this.TweenAnimPlayer.StopTweenAnim(componentType);
	}

	// Token: 0x040073C6 RID: 29638
	private const int CLOSE_ANIM_TIME = 300;

	// Token: 0x040073C7 RID: 29639
	private TimerHandle CloseAnimTimer;

	// Token: 0x040073C8 RID: 29640
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat CloseAnimTimerStat = Stat.Create("MotorcycleAutoMovingItemCloseAnim", "", "");

	// Token: 0x040073C9 RID: 29641
	private float LastPercentNitrogen = -1f;

	// Token: 0x040073CA RID: 29642
	private float LastPercentAccelerator = -1f;

	// Token: 0x040073CB RID: 29643
	private bool TargetVisible;

	// Token: 0x040073CC RID: 29644
	private bool ChangeColorNitrogen;

	// Token: 0x040073CD RID: 29645
	private bool ChangeColorAccelerator;

	// Token: 0x040073CE RID: 29646
	private UUISprite NitrogenIconSprite;

	// Token: 0x040073CF RID: 29647
	private UUISprite AcceleratorIconSprite;

	// Token: 0x040073D0 RID: 29648
	private bool IsNitrogen;

	// Token: 0x040073D1 RID: 29649
	[Nullable(1)]
	protected BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();
}

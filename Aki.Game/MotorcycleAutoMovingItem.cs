using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001421 RID: 5153
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleAutoMovingItem : UiPanelBase
{
	// Token: 0x0600CCE1 RID: 52449 RVA: 0x003CFA18 File Offset: 0x003CDC18
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

	// Token: 0x0600CCE2 RID: 52450 RVA: 0x003CFB26 File Offset: 0x003CDD26
	protected override void OnStart()
	{
		this.InitTweenAnim(6);
		this.InitTweenAnim(4);
		this.InitTweenAnim(5);
		this.NitrogenIconSprite = base.GetSprite(3);
		this.AcceleratorIconSprite = base.GetSprite(1);
	}

	// Token: 0x0600CCE3 RID: 52451 RVA: 0x003CFB57 File Offset: 0x003CDD57
	protected override void OnBeforeDestroy()
	{
		this.DestroyCloseAnimTimer();
		base.OnBeforeDestroy();
	}

	// Token: 0x0600CCE4 RID: 52452 RVA: 0x003CFB65 File Offset: 0x003CDD65
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

	// Token: 0x0600CCE5 RID: 52453 RVA: 0x003CFB98 File Offset: 0x003CDD98
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

	// Token: 0x0600CCE6 RID: 52454 RVA: 0x003CFBE6 File Offset: 0x003CDDE6
	private void DestroyCloseAnimTimer()
	{
		if (this.CloseAnimTimer != null)
		{
			TimerSystem.Instance.Remove(this.CloseAnimTimer);
			this.CloseAnimTimer = null;
		}
	}

	// Token: 0x0600CCE7 RID: 52455 RVA: 0x003CFC08 File Offset: 0x003CDE08
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

	// Token: 0x0600CCE8 RID: 52456 RVA: 0x003CFC60 File Offset: 0x003CDE60
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

	// Token: 0x0600CCE9 RID: 52457 RVA: 0x003CFCB8 File Offset: 0x003CDEB8
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

	// Token: 0x0600CCEA RID: 52458 RVA: 0x003CFCF8 File Offset: 0x003CDEF8
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

	// Token: 0x0600CCEB RID: 52459 RVA: 0x003CFD35 File Offset: 0x003CDF35
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

	// Token: 0x0600CCEC RID: 52460 RVA: 0x003CFD65 File Offset: 0x003CDF65
	public bool GetTargetVisible()
	{
		return this.TargetVisible;
	}

	// Token: 0x0600CCED RID: 52461 RVA: 0x003CFD6D File Offset: 0x003CDF6D
	protected void InitTweenAnim(int componentType)
	{
		this.TweenAnimPlayer.InitTweenAnim(componentType, base.GetItem(componentType), false);
	}

	// Token: 0x0600CCEE RID: 52462 RVA: 0x003CFD83 File Offset: 0x003CDF83
	protected void PlayTweenAnim(int componentType)
	{
		this.TweenAnimPlayer.PlayTweenAnim(componentType);
	}

	// Token: 0x0600CCEF RID: 52463 RVA: 0x003CFD91 File Offset: 0x003CDF91
	protected void StopTweenAnim(int componentType)
	{
		this.TweenAnimPlayer.StopTweenAnim(componentType);
	}

	// Token: 0x040074A7 RID: 29863
	private const int CLOSE_ANIM_TIME = 300;

	// Token: 0x040074A8 RID: 29864
	private TimerHandle CloseAnimTimer;

	// Token: 0x040074A9 RID: 29865
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat CloseAnimTimerStat = Stat.Create("MotorcycleAutoMovingItemCloseAnim", "", "");

	// Token: 0x040074AA RID: 29866
	private float LastPercentNitrogen = -1f;

	// Token: 0x040074AB RID: 29867
	private float LastPercentAccelerator = -1f;

	// Token: 0x040074AC RID: 29868
	private bool TargetVisible;

	// Token: 0x040074AD RID: 29869
	private bool ChangeColorNitrogen;

	// Token: 0x040074AE RID: 29870
	private bool ChangeColorAccelerator;

	// Token: 0x040074AF RID: 29871
	private UUISprite NitrogenIconSprite;

	// Token: 0x040074B0 RID: 29872
	private UUISprite AcceleratorIconSprite;

	// Token: 0x040074B1 RID: 29873
	private bool IsNitrogen;

	// Token: 0x040074B2 RID: 29874
	[Nullable(1)]
	protected BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();
}

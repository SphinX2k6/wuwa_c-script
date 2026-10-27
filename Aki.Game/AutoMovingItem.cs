using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F58 RID: 8024
[NullableContext(1)]
[Nullable(0)]
public class AutoMovingItem : UiPanelBase
{
	// Token: 0x0600F86E RID: 63598 RVA: 0x003C25A0 File Offset: 0x003C07A0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F86F RID: 63599 RVA: 0x003C264B File Offset: 0x003C084B
	protected override void OnStart()
	{
		this.InitTweenAnim(3);
		this.InitTweenAnim(1);
		this.InitTweenAnim(2);
	}

	// Token: 0x0600F870 RID: 63600 RVA: 0x003C2662 File Offset: 0x003C0862
	protected override void OnBeforeDestroy()
	{
		this.DestroyCloseAnimTimer();
		base.OnBeforeDestroy();
	}

	// Token: 0x0600F871 RID: 63601 RVA: 0x003C2670 File Offset: 0x003C0870
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
			this.StopTweenAnim(2);
			this.PlayTweenAnim(3);
			return;
		}
		this.PlayCloseAnim();
	}

	// Token: 0x0600F872 RID: 63602 RVA: 0x003C26A4 File Offset: 0x003C08A4
	private void PlayCloseAnim()
	{
		this.StopTweenAnim(3);
		this.PlayTweenAnim(2);
		this.DestroyCloseAnimTimer();
		this.CloseAnimTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.CloseAnimTimer = null;
			if (!this.TargetVisible)
			{
				this.SetActive(false);
			}
		}, 300f, AutoMovingItem.CloseAnimTimerStat, null, true, 1f);
	}

	// Token: 0x0600F873 RID: 63603 RVA: 0x003C26F2 File Offset: 0x003C08F2
	private void DestroyCloseAnimTimer()
	{
		if (this.CloseAnimTimer != null)
		{
			TimerSystem.Instance.Remove(this.CloseAnimTimer);
			this.CloseAnimTimer = null;
		}
	}

	// Token: 0x0600F874 RID: 63604 RVA: 0x003C2714 File Offset: 0x003C0914
	public void SetPercent(float percent)
	{
		if (percent == this.LastPercent)
		{
			return;
		}
		base.GetSprite(0).SetFillAmount(percent);
		if (percent == 1f)
		{
			this.SetChangeColor(true);
			this.PlayTweenAnim(1);
		}
		else if (this.LastPercent == 1f)
		{
			this.SetChangeColor(false);
		}
		this.LastPercent = percent;
	}

	// Token: 0x0600F875 RID: 63605 RVA: 0x003C276C File Offset: 0x003C096C
	public void SetChangeColor(bool changeColor)
	{
		UUISprite sprite = base.GetSprite(0);
		UUIItem uuiitem = sprite;
		FColor? fcolor = new FColor?(sprite.changeColor);
		uuiitem.SetChangeColor(changeColor, fcolor);
	}

	// Token: 0x0600F876 RID: 63606 RVA: 0x003C2796 File Offset: 0x003C0996
	protected void InitTweenAnim(int componentType)
	{
		this.TweenAnimPlayer.InitTweenAnim(componentType, base.GetItem(componentType), false);
	}

	// Token: 0x0600F877 RID: 63607 RVA: 0x003C27AC File Offset: 0x003C09AC
	protected void PlayTweenAnim(int componentType)
	{
		this.TweenAnimPlayer.PlayTweenAnim(componentType);
	}

	// Token: 0x0600F878 RID: 63608 RVA: 0x003C27BA File Offset: 0x003C09BA
	protected void StopTweenAnim(int componentType)
	{
		this.TweenAnimPlayer.StopTweenAnim(componentType);
	}

	// Token: 0x04007377 RID: 29559
	private const int CLOSE_ANIM_TIME = 300;

	// Token: 0x04007378 RID: 29560
	[Nullable(2)]
	private TimerHandle CloseAnimTimer;

	// Token: 0x04007379 RID: 29561
	[StaticVariableRuleIgnore]
	private static readonly Stat CloseAnimTimerStat = Stat.Create("AutoMovingItemCloseAnim", "", "");

	// Token: 0x0400737A RID: 29562
	private float LastPercent = -1f;

	// Token: 0x0400737B RID: 29563
	private bool TargetVisible;

	// Token: 0x0400737C RID: 29564
	protected BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();
}

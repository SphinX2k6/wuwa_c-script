using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200141A RID: 5146
[NullableContext(1)]
[Nullable(0)]
public class AutoMovingItem : UiPanelBase
{
	// Token: 0x0600CC8D RID: 52365 RVA: 0x003CE08C File Offset: 0x003CC28C
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

	// Token: 0x0600CC8E RID: 52366 RVA: 0x003CE137 File Offset: 0x003CC337
	protected override void OnStart()
	{
		this.InitTweenAnim(3);
		this.InitTweenAnim(1);
		this.InitTweenAnim(2);
	}

	// Token: 0x0600CC8F RID: 52367 RVA: 0x003CE14E File Offset: 0x003CC34E
	protected override void OnBeforeDestroy()
	{
		this.DestroyCloseAnimTimer();
		base.OnBeforeDestroy();
	}

	// Token: 0x0600CC90 RID: 52368 RVA: 0x003CE15C File Offset: 0x003CC35C
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

	// Token: 0x0600CC91 RID: 52369 RVA: 0x003CE190 File Offset: 0x003CC390
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

	// Token: 0x0600CC92 RID: 52370 RVA: 0x003CE1DE File Offset: 0x003CC3DE
	private void DestroyCloseAnimTimer()
	{
		if (this.CloseAnimTimer != null)
		{
			TimerSystem.Instance.Remove(this.CloseAnimTimer);
			this.CloseAnimTimer = null;
		}
	}

	// Token: 0x0600CC93 RID: 52371 RVA: 0x003CE200 File Offset: 0x003CC400
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

	// Token: 0x0600CC94 RID: 52372 RVA: 0x003CE258 File Offset: 0x003CC458
	public void SetChangeColor(bool changeColor)
	{
		UUISprite sprite = base.GetSprite(0);
		UUIItem uuiitem = sprite;
		FColor? fcolor = new FColor?(sprite.changeColor);
		uuiitem.SetChangeColor(changeColor, fcolor);
	}

	// Token: 0x0600CC95 RID: 52373 RVA: 0x003CE282 File Offset: 0x003CC482
	protected void InitTweenAnim(int componentType)
	{
		this.TweenAnimPlayer.InitTweenAnim(componentType, base.GetItem(componentType), false);
	}

	// Token: 0x0600CC96 RID: 52374 RVA: 0x003CE298 File Offset: 0x003CC498
	protected void PlayTweenAnim(int componentType)
	{
		this.TweenAnimPlayer.PlayTweenAnim(componentType);
	}

	// Token: 0x0600CC97 RID: 52375 RVA: 0x003CE2A6 File Offset: 0x003CC4A6
	protected void StopTweenAnim(int componentType)
	{
		this.TweenAnimPlayer.StopTweenAnim(componentType);
	}

	// Token: 0x04007458 RID: 29784
	private const int CLOSE_ANIM_TIME = 300;

	// Token: 0x04007459 RID: 29785
	[Nullable(2)]
	private TimerHandle CloseAnimTimer;

	// Token: 0x0400745A RID: 29786
	[StaticVariableRuleIgnore]
	private static readonly Stat CloseAnimTimerStat = Stat.Create("AutoMovingItemCloseAnim", "", "");

	// Token: 0x0400745B RID: 29787
	private float LastPercent = -1f;

	// Token: 0x0400745C RID: 29788
	private bool TargetVisible;

	// Token: 0x0400745D RID: 29789
	protected BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();
}

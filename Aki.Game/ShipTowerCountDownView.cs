using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029A3 RID: 10659
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerCountDownView : UiViewBase
{
	// Token: 0x0601618B RID: 90507 RVA: 0x00596515 File Offset: 0x00594715
	public ShipTowerCountDownView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601618C RID: 90508 RVA: 0x0059652C File Offset: 0x0059472C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x0601618D RID: 90509 RVA: 0x00596586 File Offset: 0x00594786
	private void InitDataParam()
	{
	}

	// Token: 0x0601618E RID: 90510 RVA: 0x00596588 File Offset: 0x00594788
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerCountDownView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerCountDownView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601618F RID: 90511 RVA: 0x005965CB File Offset: 0x005947CB
	protected override void OnStart()
	{
		this.HideWave();
	}

	// Token: 0x06016190 RID: 90512 RVA: 0x005965D3 File Offset: 0x005947D3
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<double, double>(EEventName.OnGamePlayCdChanged, new Action<double, double>(this.EventUpdateCountDown));
		EventSystem.Instance.Add<string>(EEventName.ShipTowerBattleTip, new Action<string>(this.EventShipTowerBattleTip));
	}

	// Token: 0x06016191 RID: 90513 RVA: 0x0059660D File Offset: 0x0059480D
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnGamePlayCdChanged, new Action<double, double>(this.EventUpdateCountDown));
		EventSystem.Instance.Remove(EEventName.ShipTowerBattleTip, new Action<string>(this.EventShipTowerBattleTip));
	}

	// Token: 0x06016192 RID: 90514 RVA: 0x00596647 File Offset: 0x00594847
	protected override void OnBeforeDestroy()
	{
		this.ClearWaveTimer();
	}

	// Token: 0x06016193 RID: 90515 RVA: 0x0059664F File Offset: 0x0059484F
	private string FormatTimeUnit(int value)
	{
		return ((value < 10) ? "0" : "") + value.ToString();
	}

	// Token: 0x06016194 RID: 90516 RVA: 0x00596670 File Offset: 0x00594870
	private void EventUpdateCountDown(double remainTime, double timerEndTime)
	{
		int value = (int)Math.Floor(remainTime % TimeUtil.Instance.Hour / TimeUtil.Instance.Minute);
		int value2 = (int)Math.Floor(remainTime % TimeUtil.Instance.Minute);
		int value3 = (int)Math.Floor((remainTime - Math.Floor(remainTime)) * 100.0);
		string text = this.FormatTimeUnit(value);
		string text2 = this.FormatTimeUnit(value2);
		string text3 = this.FormatTimeUnit(value3);
		UUIText text4 = base.GetText(0);
		if (text4 == null)
		{
			return;
		}
		text4.SetText(string.Concat(new string[]
		{
			text,
			":",
			text2,
			":",
			text3
		}), true);
	}

	// Token: 0x06016195 RID: 90517 RVA: 0x0059671C File Offset: 0x0059491C
	private void EventShipTowerBattleTip(string text)
	{
		this.TipQueue.Add(text);
		this.TryShowNextTip();
	}

	// Token: 0x06016196 RID: 90518 RVA: 0x00596730 File Offset: 0x00594930
	private void TryShowNextTip()
	{
		if (this.IsTipShowing || this.TipQueue.Count == 0)
		{
			return;
		}
		string key = this.TipQueue[0];
		this.TipQueue.RemoveAt(0);
		this.IsTipShowing = true;
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.ShowTextNew(key);
		}
		this.ClearWaveTimer();
		int num = 3000;
		this.WaveTimer = TimerSystem.Instance.Delay(new TTimerAction(this.HideWaveCallback), (float)num, null, null, true, 1f);
		base.PlaySequence("WaveIn", null, false);
	}

	// Token: 0x06016197 RID: 90519 RVA: 0x005967D8 File Offset: 0x005949D8
	private void HideWave()
	{
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		this.IsTipShowing = false;
		this.TryShowNextTip();
	}

	// Token: 0x06016198 RID: 90520 RVA: 0x005967FA File Offset: 0x005949FA
	private void HideWaveCallback(float _)
	{
		this.HideWaveAsync().Forget();
	}

	// Token: 0x06016199 RID: 90521 RVA: 0x00596808 File Offset: 0x00594A08
	private UniTask HideWaveAsync()
	{
		ShipTowerCountDownView.<HideWaveAsync>d__19 <HideWaveAsync>d__;
		<HideWaveAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<HideWaveAsync>d__.<>4__this = this;
		<HideWaveAsync>d__.<>1__state = -1;
		<HideWaveAsync>d__.<>t__builder.Start<ShipTowerCountDownView.<HideWaveAsync>d__19>(ref <HideWaveAsync>d__);
		return <HideWaveAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601619A RID: 90522 RVA: 0x0059684B File Offset: 0x00594A4B
	private void ClearWaveTimer()
	{
		if (this.WaveTimer != null)
		{
			TimerSystem.Instance.Remove(this.WaveTimer);
		}
		this.WaveTimer = null;
	}

	// Token: 0x0400A4B5 RID: 42165
	[Nullable(2)]
	private TimerHandle WaveTimer;

	// Token: 0x0400A4B6 RID: 42166
	private readonly List<string> TipQueue = new List<string>();

	// Token: 0x0400A4B7 RID: 42167
	private bool IsTipShowing;

	// Token: 0x02008FAC RID: 36780
	[NullableContext(0)]
	public class Params
	{
		// Token: 0x0402E889 RID: 190601
		public double EndTime;
	}

	// Token: 0x02008FAD RID: 36781
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402E88A RID: 190602
		public const int TxtCountDown = 0;

		// Token: 0x0402E88B RID: 190603
		public const int ItemWaveRoot = 1;

		// Token: 0x0402E88C RID: 190604
		public const int TxtWave = 2;
	}
}

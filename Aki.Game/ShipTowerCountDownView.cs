using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F1E RID: 7966
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerCountDownView : UiViewBase
{
	// Token: 0x06013B91 RID: 80785 RVA: 0x005C14D5 File Offset: 0x005BF6D5
	public ShipTowerCountDownView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013B92 RID: 80786 RVA: 0x005C14EC File Offset: 0x005BF6EC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06013B93 RID: 80787 RVA: 0x005C1546 File Offset: 0x005BF746
	private void InitDataParam()
	{
	}

	// Token: 0x06013B94 RID: 80788 RVA: 0x005C1548 File Offset: 0x005BF748
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerCountDownView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerCountDownView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013B95 RID: 80789 RVA: 0x005C158B File Offset: 0x005BF78B
	protected override void OnStart()
	{
		this.HideWave();
	}

	// Token: 0x06013B96 RID: 80790 RVA: 0x005C1593 File Offset: 0x005BF793
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<double, double>(EEventName.OnGamePlayCdChanged, new Action<double, double>(this.EventUpdateCountDown));
		EventSystem.Instance.Add<string>(EEventName.ShipTowerBattleTip, new Action<string>(this.EventShipTowerBattleTip));
	}

	// Token: 0x06013B97 RID: 80791 RVA: 0x005C15CD File Offset: 0x005BF7CD
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnGamePlayCdChanged, new Action<double, double>(this.EventUpdateCountDown));
		EventSystem.Instance.Remove(EEventName.ShipTowerBattleTip, new Action<string>(this.EventShipTowerBattleTip));
	}

	// Token: 0x06013B98 RID: 80792 RVA: 0x005C1607 File Offset: 0x005BF807
	protected override void OnBeforeDestroy()
	{
		this.ClearWaveTimer();
	}

	// Token: 0x06013B99 RID: 80793 RVA: 0x005C160F File Offset: 0x005BF80F
	private string FormatTimeUnit(int value)
	{
		return ((value < 10) ? "0" : "") + value.ToString();
	}

	// Token: 0x06013B9A RID: 80794 RVA: 0x005C1630 File Offset: 0x005BF830
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

	// Token: 0x06013B9B RID: 80795 RVA: 0x005C16DC File Offset: 0x005BF8DC
	private void EventShipTowerBattleTip(string text)
	{
		this.TipQueue.Add(text);
		this.TryShowNextTip();
	}

	// Token: 0x06013B9C RID: 80796 RVA: 0x005C16F0 File Offset: 0x005BF8F0
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

	// Token: 0x06013B9D RID: 80797 RVA: 0x005C1798 File Offset: 0x005BF998
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

	// Token: 0x06013B9E RID: 80798 RVA: 0x005C17BA File Offset: 0x005BF9BA
	private void HideWaveCallback(float _)
	{
		this.HideWaveAsync().Forget();
	}

	// Token: 0x06013B9F RID: 80799 RVA: 0x005C17C8 File Offset: 0x005BF9C8
	private UniTask HideWaveAsync()
	{
		ShipTowerCountDownView.<HideWaveAsync>d__19 <HideWaveAsync>d__;
		<HideWaveAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<HideWaveAsync>d__.<>4__this = this;
		<HideWaveAsync>d__.<>1__state = -1;
		<HideWaveAsync>d__.<>t__builder.Start<ShipTowerCountDownView.<HideWaveAsync>d__19>(ref <HideWaveAsync>d__);
		return <HideWaveAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013BA0 RID: 80800 RVA: 0x005C180B File Offset: 0x005BFA0B
	private void ClearWaveTimer()
	{
		if (this.WaveTimer != null)
		{
			TimerSystem.Instance.Remove(this.WaveTimer);
		}
		this.WaveTimer = null;
	}

	// Token: 0x0400A89F RID: 43167
	[Nullable(2)]
	private TimerHandle WaveTimer;

	// Token: 0x0400A8A0 RID: 43168
	private readonly List<string> TipQueue = new List<string>();

	// Token: 0x0400A8A1 RID: 43169
	private bool IsTipShowing;

	// Token: 0x020081F5 RID: 33269
	[NullableContext(0)]
	public class Params
	{
		// Token: 0x04029F88 RID: 171912
		public double EndTime;
	}

	// Token: 0x020081F6 RID: 33270
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04029F89 RID: 171913
		public const int TxtCountDown = 0;

		// Token: 0x04029F8A RID: 171914
		public const int ItemWaveRoot = 1;

		// Token: 0x04029F8B RID: 171915
		public const int TxtWave = 2;
	}
}

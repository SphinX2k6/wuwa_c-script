using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001458 RID: 5208
[NullableContext(1)]
[Nullable(0)]
public class InfoDisplayAudioPlayerWithProgress : UiPanelBase
{
	// Token: 0x0600CF42 RID: 53058 RVA: 0x003D9190 File Offset: 0x003D7390
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISliderComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnClickPlayAudioBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600CF43 RID: 53059 RVA: 0x003D9258 File Offset: 0x003D7458
	protected override void OnStart()
	{
		this.TextTimer = base.GetText(0);
		this.SliderProgress = base.GetSlider(1);
		if (this.TextTimer != null)
		{
			this.TextTimer.SetText("00:00/00:00", true);
		}
		if (this.SliderProgress != null)
		{
			this.SliderProgress.SetValue(0f, true);
		}
	}

	// Token: 0x0600CF44 RID: 53060 RVA: 0x003D92B1 File Offset: 0x003D74B1
	protected override void OnBeforeDestroy()
	{
		InfoDisplayAudioPlayerImpl audioPlayer = this.AudioPlayer;
		if (audioPlayer == null)
		{
			return;
		}
		audioPlayer.Release();
	}

	// Token: 0x0600CF45 RID: 53061 RVA: 0x003D92C3 File Offset: 0x003D74C3
	public void Stop()
	{
		InfoDisplayAudioPlayerImpl audioPlayer = this.AudioPlayer;
		if (audioPlayer == null)
		{
			return;
		}
		audioPlayer.Stop();
	}

	// Token: 0x0600CF46 RID: 53062 RVA: 0x003D92D8 File Offset: 0x003D74D8
	public UniTask InitAudioPlayer(string clipPath)
	{
		InfoDisplayAudioPlayerWithProgress.<InitAudioPlayer>d__9 <InitAudioPlayer>d__;
		<InitAudioPlayer>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitAudioPlayer>d__.<>4__this = this;
		<InitAudioPlayer>d__.clipPath = clipPath;
		<InitAudioPlayer>d__.<>1__state = -1;
		<InitAudioPlayer>d__.<>t__builder.Start<InfoDisplayAudioPlayerWithProgress.<InitAudioPlayer>d__9>(ref <InitAudioPlayer>d__);
		return <InitAudioPlayer>d__.<>t__builder.Task;
	}

	// Token: 0x0600CF47 RID: 53063 RVA: 0x003D9323 File Offset: 0x003D7523
	public void SetOnAudioEnd(Action callback)
	{
		if (this.AudioPlayer == null)
		{
			return;
		}
		this.AudioPlayer.OverrideEndCallBack = callback;
	}

	// Token: 0x0600CF48 RID: 53064 RVA: 0x003D933A File Offset: 0x003D753A
	public void SetOnPlay(Action callback)
	{
		if (this.AudioPlayer == null)
		{
			return;
		}
		this.AudioPlayer.OnPlay = callback;
	}

	// Token: 0x0600CF49 RID: 53065 RVA: 0x003D9351 File Offset: 0x003D7551
	public void SetOnPause(Action callback)
	{
		if (this.AudioPlayer == null)
		{
			return;
		}
		this.AudioPlayer.OnPause = callback;
	}

	// Token: 0x0600CF4A RID: 53066 RVA: 0x003D9368 File Offset: 0x003D7568
	public void Tick(float deltaTime)
	{
		InfoDisplayAudioPlayerImpl audioPlayer = this.AudioPlayer;
		if (audioPlayer != null)
		{
			audioPlayer.OnTick(deltaTime);
		}
		InfoDisplayAudioPlayerImpl audioPlayer2 = this.AudioPlayer;
		if (audioPlayer2 != null && audioPlayer2.IsPlaying())
		{
			float currentRunningTimeInSecond = this.AudioPlayer.GetCurrentRunningTimeInSecond();
			this.TickTextTimer(currentRunningTimeInSecond);
			this.TickSliderProgress(currentRunningTimeInSecond);
		}
	}

	// Token: 0x0600CF4B RID: 53067 RVA: 0x003D93B5 File Offset: 0x003D75B5
	private void TickTextTimer(float playingTime)
	{
		if (this.TextTimer != null)
		{
			this.TextTimer.SetText(InfoDisplayModel.Instance.ConvertToHourMinuteString(playingTime), true);
		}
	}

	// Token: 0x0600CF4C RID: 53068 RVA: 0x003D93D8 File Offset: 0x003D75D8
	private void TickSliderProgress(float playingTime)
	{
		if (this.SliderProgress != null)
		{
			float maxValue = this.SliderProgress.GetMaxValue();
			this.SliderProgress.SetValue(playingTime / this.AudioDuration * maxValue, true);
		}
	}

	// Token: 0x0600CF4D RID: 53069 RVA: 0x003D940F File Offset: 0x003D760F
	private void OnClickPlayAudioBtn(EToggleState toggleState)
	{
		InfoDisplayAudioPlayerImpl audioPlayer = this.AudioPlayer;
		if (audioPlayer == null)
		{
			return;
		}
		audioPlayer.OnClickPlayAudioBtn();
	}

	// Token: 0x040075BB RID: 30139
	[Nullable(2)]
	private InfoDisplayAudioPlayerImpl AudioPlayer;

	// Token: 0x040075BC RID: 30140
	[Nullable(2)]
	private UUIText TextTimer;

	// Token: 0x040075BD RID: 30141
	[Nullable(2)]
	private UUISliderComponent SliderProgress;

	// Token: 0x040075BE RID: 30142
	private float AudioDuration = 1f;

	// Token: 0x02007708 RID: 30472
	[NullableContext(0)]
	private class EInfoDisplayAudioPlayerWithProgressComponents
	{
		// Token: 0x04026AA9 RID: 158377
		public const int TextTimer = 0;

		// Token: 0x04026AAA RID: 158378
		public const int SliderProgress = 1;

		// Token: 0x04026AAB RID: 158379
		public const int TogglePlay = 2;
	}
}

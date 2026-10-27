using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F96 RID: 8086
[NullableContext(1)]
[Nullable(0)]
public class InfoDisplayAudioPlayerWithProgress : UiPanelBase
{
	// Token: 0x0600FB20 RID: 64288 RVA: 0x003CD5D0 File Offset: 0x003CB7D0
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

	// Token: 0x0600FB21 RID: 64289 RVA: 0x003CD698 File Offset: 0x003CB898
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

	// Token: 0x0600FB22 RID: 64290 RVA: 0x003CD6F1 File Offset: 0x003CB8F1
	protected override void OnBeforeDestroy()
	{
		InfoDisplayAudioPlayerImpl audioPlayer = this.AudioPlayer;
		if (audioPlayer == null)
		{
			return;
		}
		audioPlayer.Release();
	}

	// Token: 0x0600FB23 RID: 64291 RVA: 0x003CD703 File Offset: 0x003CB903
	public void Stop()
	{
		InfoDisplayAudioPlayerImpl audioPlayer = this.AudioPlayer;
		if (audioPlayer == null)
		{
			return;
		}
		audioPlayer.Stop();
	}

	// Token: 0x0600FB24 RID: 64292 RVA: 0x003CD718 File Offset: 0x003CB918
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

	// Token: 0x0600FB25 RID: 64293 RVA: 0x003CD763 File Offset: 0x003CB963
	public void SetOnAudioEnd(Action callback)
	{
		if (this.AudioPlayer == null)
		{
			return;
		}
		this.AudioPlayer.OverrideEndCallBack = callback;
	}

	// Token: 0x0600FB26 RID: 64294 RVA: 0x003CD77A File Offset: 0x003CB97A
	public void SetOnPlay(Action callback)
	{
		if (this.AudioPlayer == null)
		{
			return;
		}
		this.AudioPlayer.OnPlay = callback;
	}

	// Token: 0x0600FB27 RID: 64295 RVA: 0x003CD791 File Offset: 0x003CB991
	public void SetOnPause(Action callback)
	{
		if (this.AudioPlayer == null)
		{
			return;
		}
		this.AudioPlayer.OnPause = callback;
	}

	// Token: 0x0600FB28 RID: 64296 RVA: 0x003CD7A8 File Offset: 0x003CB9A8
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

	// Token: 0x0600FB29 RID: 64297 RVA: 0x003CD7F5 File Offset: 0x003CB9F5
	private void TickTextTimer(float playingTime)
	{
		if (this.TextTimer != null)
		{
			this.TextTimer.SetText(InfoDisplayModel.Instance.ConvertToHourMinuteString(playingTime), true);
		}
	}

	// Token: 0x0600FB2A RID: 64298 RVA: 0x003CD818 File Offset: 0x003CBA18
	private void TickSliderProgress(float playingTime)
	{
		if (this.SliderProgress != null)
		{
			float maxValue = this.SliderProgress.GetMaxValue();
			this.SliderProgress.SetValue(playingTime / this.AudioDuration * maxValue, true);
		}
	}

	// Token: 0x0600FB2B RID: 64299 RVA: 0x003CD84F File Offset: 0x003CBA4F
	private void OnClickPlayAudioBtn(EToggleState toggleState)
	{
		InfoDisplayAudioPlayerImpl audioPlayer = this.AudioPlayer;
		if (audioPlayer == null)
		{
			return;
		}
		audioPlayer.OnClickPlayAudioBtn();
	}

	// Token: 0x040074D9 RID: 29913
	[Nullable(2)]
	private InfoDisplayAudioPlayerImpl AudioPlayer;

	// Token: 0x040074DA RID: 29914
	[Nullable(2)]
	private UUIText TextTimer;

	// Token: 0x040074DB RID: 29915
	[Nullable(2)]
	private UUISliderComponent SliderProgress;

	// Token: 0x040074DC RID: 29916
	private float AudioDuration = 1f;

	// Token: 0x02008583 RID: 34179
	[NullableContext(0)]
	private class EInfoDisplayAudioPlayerWithProgressComponents
	{
		// Token: 0x0402B786 RID: 178054
		public const int TextTimer = 0;

		// Token: 0x0402B787 RID: 178055
		public const int SliderProgress = 1;

		// Token: 0x0402B788 RID: 178056
		public const int TogglePlay = 2;
	}
}

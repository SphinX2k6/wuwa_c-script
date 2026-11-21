using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001457 RID: 5207
[NullableContext(1)]
[Nullable(0)]
public class InfoDisplayAudioPlayer : UiPanelBase
{
	// Token: 0x0600CF39 RID: 53049 RVA: 0x003D8FA4 File Offset: 0x003D71A4
	public void Initialize(AActor rootActor)
	{
		base.CreateThenShowByActor(rootActor, null);
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (this.RootActor != null && extendToggle != null)
		{
			this.AudioPlayer = new InfoDisplayAudioPlayerImpl(this.RootActor, extendToggle);
		}
	}

	// Token: 0x0600CF3A RID: 53050 RVA: 0x003D8FDE File Offset: 0x003D71DE
	public void SetShowTextComponent(UUIText textComponent)
	{
		this.TextComponent = textComponent;
		this.TextComponent.SetText("00:00/00:00", true);
	}

	// Token: 0x0600CF3B RID: 53051 RVA: 0x003D8FF8 File Offset: 0x003D71F8
	public void SetSpectrumCallBack(Action<TArray<float>, float> spectrumCall)
	{
		if (this.AudioPlayer != null)
		{
			this.AudioPlayer.SetSpectrumCallBack(spectrumCall);
		}
	}

	// Token: 0x0600CF3C RID: 53052 RVA: 0x003D9010 File Offset: 0x003D7210
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickPlayAudioBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600CF3D RID: 53053 RVA: 0x003D9098 File Offset: 0x003D7298
	public void OnTick(float deltaTime)
	{
		if (this.AudioPlayer == null)
		{
			return;
		}
		this.AudioPlayer.OnTick(deltaTime);
		if (this.AudioPlayer.IsPlaying())
		{
			string str = InfoDisplayModel.Instance.ConvertToHourMinuteString(this.AudioPlayer.GetCurrentRunningTimeInSecond());
			string str2 = InfoDisplayModel.Instance.ConvertToHourMinuteString(this.AudioPlayer.GetMaxDurationInSecond());
			if (this.TextComponent != null)
			{
				this.TextComponent.SetText(str + "/" + str2, true);
			}
		}
	}

	// Token: 0x0600CF3E RID: 53054 RVA: 0x003D9114 File Offset: 0x003D7314
	public UniTask Refresh(string param)
	{
		InfoDisplayAudioPlayer.<Refresh>d__8 <Refresh>d__;
		<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Refresh>d__.<>4__this = this;
		<Refresh>d__.param = param;
		<Refresh>d__.<>1__state = -1;
		<Refresh>d__.<>t__builder.Start<InfoDisplayAudioPlayer.<Refresh>d__8>(ref <Refresh>d__);
		return <Refresh>d__.<>t__builder.Task;
	}

	// Token: 0x0600CF3F RID: 53055 RVA: 0x003D915F File Offset: 0x003D735F
	protected override void OnBeforeDestroy()
	{
		if (this.AudioPlayer != null)
		{
			this.AudioPlayer.Release();
		}
	}

	// Token: 0x0600CF40 RID: 53056 RVA: 0x003D9174 File Offset: 0x003D7374
	private void OnClickPlayAudioBtn(EToggleState toggleState)
	{
		InfoDisplayAudioPlayerImpl audioPlayer = this.AudioPlayer;
		if (audioPlayer == null)
		{
			return;
		}
		audioPlayer.OnClickPlayAudioBtn();
	}

	// Token: 0x040075B9 RID: 30137
	[Nullable(2)]
	private InfoDisplayAudioPlayerImpl AudioPlayer;

	// Token: 0x040075BA RID: 30138
	[Nullable(2)]
	private UUIText TextComponent;

	// Token: 0x02007706 RID: 30470
	[NullableContext(0)]
	private class EInfoDisplayAudioPlayerComponents
	{
		// Token: 0x04026AA3 RID: 158371
		public const int PlayToggle = 0;
	}
}

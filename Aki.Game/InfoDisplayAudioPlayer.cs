using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F95 RID: 8085
[NullableContext(1)]
[Nullable(0)]
public class InfoDisplayAudioPlayer : UiPanelBase
{
	// Token: 0x0600FB17 RID: 64279 RVA: 0x003CD3E4 File Offset: 0x003CB5E4
	public void Initialize(AActor rootActor)
	{
		base.CreateThenShowByActor(rootActor, null);
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (this.RootActor != null && extendToggle != null)
		{
			this.AudioPlayer = new InfoDisplayAudioPlayerImpl(this.RootActor, extendToggle);
		}
	}

	// Token: 0x0600FB18 RID: 64280 RVA: 0x003CD41E File Offset: 0x003CB61E
	public void SetShowTextComponent(UUIText textComponent)
	{
		this.TextComponent = textComponent;
		this.TextComponent.SetText("00:00/00:00", true);
	}

	// Token: 0x0600FB19 RID: 64281 RVA: 0x003CD438 File Offset: 0x003CB638
	public void SetSpectrumCallBack(Action<TArray<float>, float> spectrumCall)
	{
		if (this.AudioPlayer != null)
		{
			this.AudioPlayer.SetSpectrumCallBack(spectrumCall);
		}
	}

	// Token: 0x0600FB1A RID: 64282 RVA: 0x003CD450 File Offset: 0x003CB650
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

	// Token: 0x0600FB1B RID: 64283 RVA: 0x003CD4D8 File Offset: 0x003CB6D8
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

	// Token: 0x0600FB1C RID: 64284 RVA: 0x003CD554 File Offset: 0x003CB754
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

	// Token: 0x0600FB1D RID: 64285 RVA: 0x003CD59F File Offset: 0x003CB79F
	protected override void OnBeforeDestroy()
	{
		if (this.AudioPlayer != null)
		{
			this.AudioPlayer.Release();
		}
	}

	// Token: 0x0600FB1E RID: 64286 RVA: 0x003CD5B4 File Offset: 0x003CB7B4
	private void OnClickPlayAudioBtn(EToggleState toggleState)
	{
		InfoDisplayAudioPlayerImpl audioPlayer = this.AudioPlayer;
		if (audioPlayer == null)
		{
			return;
		}
		audioPlayer.OnClickPlayAudioBtn();
	}

	// Token: 0x040074D7 RID: 29911
	[Nullable(2)]
	private InfoDisplayAudioPlayerImpl AudioPlayer;

	// Token: 0x040074D8 RID: 29912
	[Nullable(2)]
	private UUIText TextComponent;

	// Token: 0x02008581 RID: 34177
	[NullableContext(0)]
	private class EInfoDisplayAudioPlayerComponents
	{
		// Token: 0x0402B780 RID: 178048
		public const int PlayToggle = 0;
	}
}

using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F90 RID: 8080
[NullableContext(2)]
[Nullable(0)]
public class InfoDisplayAudioPlayerImpl
{
	// Token: 0x0600FAC3 RID: 64195 RVA: 0x003CC4AC File Offset: 0x003CA6AC
	[NullableContext(1)]
	public InfoDisplayAudioPlayerImpl(AActor rootActor, UUIExtendToggle togglePlay)
	{
		this.RootActor = rootActor;
		this.TogglePlay = togglePlay;
	}

	// Token: 0x0600FAC4 RID: 64196 RVA: 0x003CC4D4 File Offset: 0x003CA6D4
	public void Start()
	{
		this.InternalPlay();
	}

	// Token: 0x0600FAC5 RID: 64197 RVA: 0x003CC4DC File Offset: 0x003CA6DC
	public void Stop()
	{
		this.Release();
	}

	// Token: 0x0600FAC6 RID: 64198 RVA: 0x003CC4E4 File Offset: 0x003CA6E4
	public void Release()
	{
		this.ResetSpectrum();
		if (this.AudioDelegate != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<EAkCallbackType, UAkCallbackInfo>(this.EndCallBack));
			this.AudioDelegate = null;
		}
	}

	// Token: 0x0600FAC7 RID: 64199 RVA: 0x003CC50C File Offset: 0x003CA70C
	[NullableContext(1)]
	public void SetSpectrumCallBack(Action<TArray<float>, float> spectrumCall)
	{
	}

	// Token: 0x0600FAC8 RID: 64200 RVA: 0x003CC510 File Offset: 0x003CA710
	[NullableContext(1)]
	public UniTask SetAudioClipPathAndLoadAudio(string audioPath)
	{
		InfoDisplayAudioPlayerImpl.<SetAudioClipPathAndLoadAudio>d__19 <SetAudioClipPathAndLoadAudio>d__;
		<SetAudioClipPathAndLoadAudio>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SetAudioClipPathAndLoadAudio>d__.<>4__this = this;
		<SetAudioClipPathAndLoadAudio>d__.audioPath = audioPath;
		<SetAudioClipPathAndLoadAudio>d__.<>1__state = -1;
		<SetAudioClipPathAndLoadAudio>d__.<>t__builder.Start<InfoDisplayAudioPlayerImpl.<SetAudioClipPathAndLoadAudio>d__19>(ref <SetAudioClipPathAndLoadAudio>d__);
		return <SetAudioClipPathAndLoadAudio>d__.<>t__builder.Task;
	}

	// Token: 0x0600FAC9 RID: 64201 RVA: 0x003CC55B File Offset: 0x003CA75B
	public void OnClickPlayAudioBtn()
	{
		this.InternalPlay();
	}

	// Token: 0x0600FACA RID: 64202 RVA: 0x003CC563 File Offset: 0x003CA763
	public void OnTick(float deltaTime)
	{
		if (!this.IsPlaying())
		{
			return;
		}
		this.RefreshPlayInfo(deltaTime);
	}

	// Token: 0x0600FACB RID: 64203 RVA: 0x003CC575 File Offset: 0x003CA775
	public bool IsPlaying()
	{
		return this.PlayState && !this.PauseState;
	}

	// Token: 0x0600FACC RID: 64204 RVA: 0x003CC58A File Offset: 0x003CA78A
	public float GetMaxDurationInSecond()
	{
		return this.MaxDuration;
	}

	// Token: 0x0600FACD RID: 64205 RVA: 0x003CC592 File Offset: 0x003CA792
	public float GetCurrentRunningTimeInSecond()
	{
		return this.CurrentRunningTime / 1000f;
	}

	// Token: 0x0600FACE RID: 64206 RVA: 0x003CC5A0 File Offset: 0x003CA7A0
	[NullableContext(0)]
	private UniTask<bool> LoadAudio()
	{
		InfoDisplayAudioPlayerImpl.<LoadAudio>d__25 <LoadAudio>d__;
		<LoadAudio>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<LoadAudio>d__.<>4__this = this;
		<LoadAudio>d__.<>1__state = -1;
		<LoadAudio>d__.<>t__builder.Start<InfoDisplayAudioPlayerImpl.<LoadAudio>d__25>(ref <LoadAudio>d__);
		return <LoadAudio>d__.<>t__builder.Task;
	}

	// Token: 0x0600FACF RID: 64207 RVA: 0x003CC5E4 File Offset: 0x003CA7E4
	private void InternalPlay()
	{
		if (!this.AudioEventLoaded)
		{
			return;
		}
		if (this.PlayState)
		{
			if (this.PauseState)
			{
				this.ResumeMusic();
			}
			else
			{
				this.PauseMusic();
			}
		}
		else
		{
			if (this.AudioDelegate == null)
			{
				this.AudioDelegate = DelegateUtils.ToManualReleaseDelegate<FOnAkPostEventCallback>(new Action<EAkCallbackType, UAkCallbackInfo>(this.EndCallBack));
			}
			this.PlayAudio(this.AudioClipPath);
			this.PlayState = true;
			this.PauseState = false;
		}
		if (this.TogglePlay != null)
		{
			this.TogglePlay.SetToggleState(this.PauseState ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked, false, false, false);
		}
		if (this.PauseState)
		{
			if (this.OnPause != null)
			{
				this.OnPause();
				return;
			}
		}
		else if (this.OnPlay != null)
		{
			this.OnPlay();
		}
	}

	// Token: 0x0600FAD0 RID: 64208 RVA: 0x003CC6A8 File Offset: 0x003CA8A8
	private void PauseMusic()
	{
		this.PauseState = true;
		UAkAudioEvent audioEvent = AudioController.Instance.GetAudioEvent(this.AudioClipPath, false);
		if (audioEvent != null && this.RootActor != null)
		{
			AudioController.Instance.ExecuteActionOnEvent(audioEvent, EAkActionOnEventType.Pause, this.RootActor);
		}
	}

	// Token: 0x0600FAD1 RID: 64209 RVA: 0x003CC6EC File Offset: 0x003CA8EC
	private void ResumeMusic()
	{
		this.PauseState = false;
		UAkAudioEvent audioEvent = AudioController.Instance.GetAudioEvent(this.AudioClipPath, false);
		if (audioEvent != null && this.RootActor != null)
		{
			AudioController.Instance.ExecuteActionOnEvent(audioEvent, EAkActionOnEventType.Resume, this.RootActor);
		}
	}

	// Token: 0x0600FAD2 RID: 64210 RVA: 0x003CC730 File Offset: 0x003CA930
	private void EndCallBack(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
	{
		if (callbackType == EAkCallbackType.EndOfEvent && this.PlayState)
		{
			if (this.RootActor != null)
			{
				AudioController.Instance.StopAudio(this.RootActor);
			}
			if (this.OverrideEndCallBack != null)
			{
				this.OverrideEndCallBack();
			}
			else
			{
				string audioClipPath = this.AudioClipPath;
				if (AudioController.Instance.GetAudioEvent(audioClipPath, false) != null)
				{
					this.PlayAudio(audioClipPath);
				}
			}
			this.CurrentRunningTime = 0f;
		}
	}

	// Token: 0x0600FAD3 RID: 64211 RVA: 0x003CC79C File Offset: 0x003CA99C
	[NullableContext(1)]
	private void PlayAudio(string audioPath)
	{
		if (this.RootActor != null)
		{
			AudioController.Instance.PlayAudioByEventPath(audioPath, this.RootActor, new int?(this.PlayFlag), this.AudioDelegate, null, true, "");
		}
	}

	// Token: 0x0600FAD4 RID: 64212 RVA: 0x003CC7E3 File Offset: 0x003CA9E3
	private void RefreshPlayInfo(float deltaTime)
	{
		this.CurrentRunningTime += deltaTime;
		if (this.CurrentRunningTime >= this.MaxDuration * 1000f)
		{
			this.CurrentRunningTime = this.MaxDuration * 1000f;
		}
	}

	// Token: 0x0600FAD5 RID: 64213 RVA: 0x003CC819 File Offset: 0x003CAA19
	private void ResetSpectrum()
	{
		if (this.RootActor != null)
		{
			AudioController.Instance.StopAudio(this.RootActor);
		}
		this.CurrentRunningTime = 0f;
		this.PlayState = false;
		this.AudioEventLoaded = false;
	}

	// Token: 0x040074BB RID: 29883
	private const int MS_PER_SECOND = 1000;

	// Token: 0x040074BC RID: 29884
	private readonly UUIExtendToggle TogglePlay;

	// Token: 0x040074BD RID: 29885
	private readonly AActor RootActor;

	// Token: 0x040074BE RID: 29886
	private float CurrentRunningTime;

	// Token: 0x040074BF RID: 29887
	private readonly int PlayFlag = 1;

	// Token: 0x040074C0 RID: 29888
	private bool PlayState;

	// Token: 0x040074C1 RID: 29889
	private float MaxDuration;

	// Token: 0x040074C2 RID: 29890
	[Nullable(1)]
	private string AudioClipPath = "";

	// Token: 0x040074C3 RID: 29891
	private bool PauseState;

	// Token: 0x040074C4 RID: 29892
	private bool AudioEventLoaded;

	// Token: 0x040074C5 RID: 29893
	private FOnAkPostEventCallback AudioDelegate;

	// Token: 0x040074C6 RID: 29894
	public Action OverrideEndCallBack;

	// Token: 0x040074C7 RID: 29895
	public Action OnPlay;

	// Token: 0x040074C8 RID: 29896
	public Action OnPause;
}

using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001452 RID: 5202
[NullableContext(2)]
[Nullable(0)]
public class InfoDisplayAudioPlayerImpl
{
	// Token: 0x0600CEE2 RID: 52962 RVA: 0x003D7FE0 File Offset: 0x003D61E0
	[NullableContext(1)]
	public InfoDisplayAudioPlayerImpl(AActor rootActor, UUIExtendToggle togglePlay)
	{
		this.RootActor = rootActor;
		this.TogglePlay = togglePlay;
	}

	// Token: 0x0600CEE3 RID: 52963 RVA: 0x003D8008 File Offset: 0x003D6208
	public void Start()
	{
		this.InternalPlay();
	}

	// Token: 0x0600CEE4 RID: 52964 RVA: 0x003D8010 File Offset: 0x003D6210
	public void Stop()
	{
		this.Release();
	}

	// Token: 0x0600CEE5 RID: 52965 RVA: 0x003D8018 File Offset: 0x003D6218
	public void Release()
	{
		this.ResetSpectrum();
		if (this.AudioDelegate != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<EAkCallbackType, UAkCallbackInfo>(this.EndCallBack));
			this.AudioDelegate = null;
		}
	}

	// Token: 0x0600CEE6 RID: 52966 RVA: 0x003D8040 File Offset: 0x003D6240
	[NullableContext(1)]
	public void SetSpectrumCallBack(Action<TArray<float>, float> spectrumCall)
	{
	}

	// Token: 0x0600CEE7 RID: 52967 RVA: 0x003D8044 File Offset: 0x003D6244
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

	// Token: 0x0600CEE8 RID: 52968 RVA: 0x003D808F File Offset: 0x003D628F
	public void OnClickPlayAudioBtn()
	{
		this.InternalPlay();
	}

	// Token: 0x0600CEE9 RID: 52969 RVA: 0x003D8097 File Offset: 0x003D6297
	public void OnTick(float deltaTime)
	{
		if (!this.IsPlaying())
		{
			return;
		}
		this.RefreshPlayInfo(deltaTime);
	}

	// Token: 0x0600CEEA RID: 52970 RVA: 0x003D80A9 File Offset: 0x003D62A9
	public bool IsPlaying()
	{
		return this.PlayState && !this.PauseState;
	}

	// Token: 0x0600CEEB RID: 52971 RVA: 0x003D80BE File Offset: 0x003D62BE
	public float GetMaxDurationInSecond()
	{
		return this.MaxDuration;
	}

	// Token: 0x0600CEEC RID: 52972 RVA: 0x003D80C6 File Offset: 0x003D62C6
	public float GetCurrentRunningTimeInSecond()
	{
		return this.CurrentRunningTime / 1000f;
	}

	// Token: 0x0600CEED RID: 52973 RVA: 0x003D80D4 File Offset: 0x003D62D4
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

	// Token: 0x0600CEEE RID: 52974 RVA: 0x003D8118 File Offset: 0x003D6318
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

	// Token: 0x0600CEEF RID: 52975 RVA: 0x003D81DC File Offset: 0x003D63DC
	private void PauseMusic()
	{
		this.PauseState = true;
		UAkAudioEvent audioEvent = AudioController.Instance.GetAudioEvent(this.AudioClipPath, false);
		if (audioEvent != null && this.RootActor != null)
		{
			AudioController.Instance.ExecuteActionOnEvent(audioEvent, EAkActionOnEventType.Pause, this.RootActor);
		}
	}

	// Token: 0x0600CEF0 RID: 52976 RVA: 0x003D8220 File Offset: 0x003D6420
	private void ResumeMusic()
	{
		this.PauseState = false;
		UAkAudioEvent audioEvent = AudioController.Instance.GetAudioEvent(this.AudioClipPath, false);
		if (audioEvent != null && this.RootActor != null)
		{
			AudioController.Instance.ExecuteActionOnEvent(audioEvent, EAkActionOnEventType.Resume, this.RootActor);
		}
	}

	// Token: 0x0600CEF1 RID: 52977 RVA: 0x003D8264 File Offset: 0x003D6464
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

	// Token: 0x0600CEF2 RID: 52978 RVA: 0x003D82D0 File Offset: 0x003D64D0
	[NullableContext(1)]
	private void PlayAudio(string audioPath)
	{
		if (this.RootActor != null)
		{
			AudioController.Instance.PlayAudioByEventPath(audioPath, this.RootActor, new int?(this.PlayFlag), this.AudioDelegate, null, true, "");
		}
	}

	// Token: 0x0600CEF3 RID: 52979 RVA: 0x003D8317 File Offset: 0x003D6517
	private void RefreshPlayInfo(float deltaTime)
	{
		this.CurrentRunningTime += deltaTime;
		if (this.CurrentRunningTime >= this.MaxDuration * 1000f)
		{
			this.CurrentRunningTime = this.MaxDuration * 1000f;
		}
	}

	// Token: 0x0600CEF4 RID: 52980 RVA: 0x003D834D File Offset: 0x003D654D
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

	// Token: 0x0400759C RID: 30108
	private const int MS_PER_SECOND = 1000;

	// Token: 0x0400759D RID: 30109
	private readonly UUIExtendToggle TogglePlay;

	// Token: 0x0400759E RID: 30110
	private readonly AActor RootActor;

	// Token: 0x0400759F RID: 30111
	private float CurrentRunningTime;

	// Token: 0x040075A0 RID: 30112
	private readonly int PlayFlag = 1;

	// Token: 0x040075A1 RID: 30113
	private bool PlayState;

	// Token: 0x040075A2 RID: 30114
	private float MaxDuration;

	// Token: 0x040075A3 RID: 30115
	[Nullable(1)]
	private string AudioClipPath = "";

	// Token: 0x040075A4 RID: 30116
	private bool PauseState;

	// Token: 0x040075A5 RID: 30117
	private bool AudioEventLoaded;

	// Token: 0x040075A6 RID: 30118
	private FOnAkPostEventCallback AudioDelegate;

	// Token: 0x040075A7 RID: 30119
	public Action OverrideEndCallBack;

	// Token: 0x040075A8 RID: 30120
	public Action OnPlay;

	// Token: 0x040075A9 RID: 30121
	public Action OnPause;
}

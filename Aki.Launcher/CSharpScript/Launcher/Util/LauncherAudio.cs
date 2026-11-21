using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Platform;
using UnrealEngine;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x02000069 RID: 105
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherAudio : Singleton
	{
		// Token: 0x060002B0 RID: 688 RVA: 0x0000E188 File Offset: 0x0000C388
		public void Init()
		{
			UAkGameplayStatics.ClearSoundBanksAndMedia();
			UAkGameplayStatics.UnloadInitBank();
			UAkGameplayStatics.LoadInitBank();
			UAkGameplayStatics.ReloadAudioAssetData();
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000E1A0 File Offset: 0x0000C3A0
		public void InitIosAuditPackage()
		{
			if (this.IsInit)
			{
				return;
			}
			if (!Platform.Instance.IsIOSPlatform())
			{
				return;
			}
			if (!BaseConfigController.Instance.GetIosAuditFirstDownloadTip())
			{
				LauncherLog.Instance.Info("LauncherAudio 不是提审包 ~", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			UKuroAudioStatics.SetIosAuditPackage(true);
			UKuroAudioStatics.ChangeIosAudioSessionProperties();
			LauncherResourceLib.Instance.LoadAsync<UAkAudioEvent>("/Game/Aki/WwiseAudio/Events/pause_all_wwise_audio.pause_all_wwise_audio", delegate([Nullable(2)] UAkAudioEvent audioEvent, string path)
			{
				this.PauseAudioEvent = audioEvent;
				this.OnEventsLoaded();
			}, 0, "Launch.Audio");
			LauncherResourceLib.Instance.LoadAsync<UAkAudioEvent>("/Game/Aki/WwiseAudio/Events/resume_all_wwise_audio.resume_all_wwise_audio", delegate([Nullable(2)] UAkAudioEvent audioEvent, string path)
			{
				this.ResumeAudioEvent = audioEvent;
				this.OnEventsLoaded();
			}, 0, "Launch.Audio");
			this.IsInit = true;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000E240 File Offset: 0x0000C440
		private void OnEventsLoaded()
		{
			if (this.PauseAudioEvent != null && this.ResumeAudioEvent != null)
			{
				FKuroAudioPauseDelegate fkuroAudioPauseDelegate = DelegateUtils.ToManualReleaseDelegate<FKuroAudioPauseDelegate>(new Action(this.OnAudioPause));
				UKuroAudioDelegates.SetAudioPauseDelegate(fkuroAudioPauseDelegate);
				FKuroAudioResumeDelegate fkuroAudioResumeDelegate = DelegateUtils.ToManualReleaseDelegate<FKuroAudioResumeDelegate>(new Action(this.OnAudioResume));
				UKuroAudioDelegates.SetAudioResumeDelegate(fkuroAudioResumeDelegate);
			}
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000E290 File Offset: 0x0000C490
		public void Destroy()
		{
			if (!this.IsInit)
			{
				return;
			}
			if (this.PauseAudioEvent != null && this.ResumeAudioEvent != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action(this.OnAudioPause));
				UKuroAudioDelegates.UnbindAudioPauseDelegate();
				DelegateUtils.ReleaseManualReleaseDelegate(new Action(this.OnAudioResume));
				UKuroAudioDelegates.UnbindAudioResumeDelegate();
			}
			this.IsInit = false;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000E2EC File Offset: 0x0000C4EC
		private void OnAudioPause()
		{
			if (this.PauseAudioEvent != null)
			{
				if (this.IsPaused.GetValueOrDefault())
				{
					LauncherLog.Instance.Info("重复暂停音乐", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				LauncherLog.Instance.Info("暂停所有音乐", default(ReadOnlySpan<ValueTuple<string, object>>));
				UAkAudioEvent pauseAudioEvent = this.PauseAudioEvent;
				AActor actor = null;
				int callbackMask = 0;
				FOnAkPostEventCallback fonAkPostEventCallback = null;
				UAkGameplayStatics.PostEvent(pauseAudioEvent, actor, callbackMask, fonAkPostEventCallback, false, "");
				UAkGameplayStatics.RenderAudio();
				this.IsPaused = new bool?(true);
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000E368 File Offset: 0x0000C568
		private void OnAudioResume()
		{
			if (this.ResumeAudioEvent != null)
			{
				bool? isPaused = this.IsPaused;
				bool flag = false;
				if (isPaused.GetValueOrDefault() == flag & isPaused != null)
				{
					LauncherLog.Instance.Info("重复恢复音乐", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				LauncherLog.Instance.Info("恢复所有音乐", default(ReadOnlySpan<ValueTuple<string, object>>));
				UAkAudioEvent resumeAudioEvent = this.ResumeAudioEvent;
				AActor actor = null;
				int callbackMask = 0;
				FOnAkPostEventCallback fonAkPostEventCallback = null;
				UAkGameplayStatics.PostEvent(resumeAudioEvent, actor, callbackMask, fonAkPostEventCallback, false, "");
				UAkGameplayStatics.RenderAudio();
				this.IsPaused = new bool?(false);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x0000E3F4 File Offset: 0x0000C5F4
		public static LauncherAudio Instance
		{
			get
			{
				if (LauncherAudio._instance == null)
				{
					LauncherAudio._instance = new LauncherAudio();
					LauncherAudio._instance.OnInit();
				}
				return LauncherAudio._instance;
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000E417 File Offset: 0x0000C617
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000E419 File Offset: 0x0000C619
		public static void ResetStaticDefaultValue()
		{
			LauncherAudio instance = LauncherAudio._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			LauncherAudio._instance = null;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000E432 File Offset: 0x0000C632
		static LauncherAudio()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LauncherAudio.CreateStaticDefaultValue), new Action(LauncherAudio.ResetStaticDefaultValue));
		}

		// Token: 0x040001D9 RID: 473
		private const string PAUSE_AUDIO_EVENT = "/Game/Aki/WwiseAudio/Events/pause_all_wwise_audio.pause_all_wwise_audio";

		// Token: 0x040001DA RID: 474
		private const string RESUME_AUDIO_EVENT = "/Game/Aki/WwiseAudio/Events/resume_all_wwise_audio.resume_all_wwise_audio";

		// Token: 0x040001DB RID: 475
		[Nullable(2)]
		private UAkAudioEvent PauseAudioEvent;

		// Token: 0x040001DC RID: 476
		[Nullable(2)]
		private UAkAudioEvent ResumeAudioEvent;

		// Token: 0x040001DD RID: 477
		private bool IsInit;

		// Token: 0x040001DE RID: 478
		private bool? IsPaused;

		// Token: 0x040001DF RID: 479
		[Nullable(2)]
		private static LauncherAudio _instance;
	}
}

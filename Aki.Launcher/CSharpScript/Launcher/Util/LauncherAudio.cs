using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Platform;
using UnrealEngine;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x02000067 RID: 103
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherAudio : Singleton
	{
		// Token: 0x060002AE RID: 686 RVA: 0x0000DDDC File Offset: 0x0000BFDC
		public void Init()
		{
			UAkGameplayStatics.ClearSoundBanksAndMedia();
			UAkGameplayStatics.UnloadInitBank();
			UAkGameplayStatics.LoadInitBank();
			UAkGameplayStatics.ReloadAudioAssetData();
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000DDF4 File Offset: 0x0000BFF4
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

		// Token: 0x060002B0 RID: 688 RVA: 0x0000DE94 File Offset: 0x0000C094
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

		// Token: 0x060002B1 RID: 689 RVA: 0x0000DEE4 File Offset: 0x0000C0E4
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

		// Token: 0x060002B2 RID: 690 RVA: 0x0000DF40 File Offset: 0x0000C140
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

		// Token: 0x060002B3 RID: 691 RVA: 0x0000DFBC File Offset: 0x0000C1BC
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
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000E048 File Offset: 0x0000C248
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

		// Token: 0x060002B5 RID: 693 RVA: 0x0000E06B File Offset: 0x0000C26B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000E06D File Offset: 0x0000C26D
		public static void ResetStaticDefaultValue()
		{
			LauncherAudio instance = LauncherAudio._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			LauncherAudio._instance = null;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000E086 File Offset: 0x0000C286
		static LauncherAudio()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LauncherAudio.CreateStaticDefaultValue), new Action(LauncherAudio.ResetStaticDefaultValue));
		}

		// Token: 0x040001B2 RID: 434
		private const string PAUSE_AUDIO_EVENT = "/Game/Aki/WwiseAudio/Events/pause_all_wwise_audio.pause_all_wwise_audio";

		// Token: 0x040001B3 RID: 435
		private const string RESUME_AUDIO_EVENT = "/Game/Aki/WwiseAudio/Events/resume_all_wwise_audio.resume_all_wwise_audio";

		// Token: 0x040001B4 RID: 436
		[Nullable(2)]
		private UAkAudioEvent PauseAudioEvent;

		// Token: 0x040001B5 RID: 437
		[Nullable(2)]
		private UAkAudioEvent ResumeAudioEvent;

		// Token: 0x040001B6 RID: 438
		private bool IsInit;

		// Token: 0x040001B7 RID: 439
		private bool? IsPaused;

		// Token: 0x040001B8 RID: 440
		[Nullable(2)]
		private static LauncherAudio _instance;
	}
}

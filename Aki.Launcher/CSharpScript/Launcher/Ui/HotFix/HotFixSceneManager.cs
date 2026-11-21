using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Util;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000E6 RID: 230
	[NullableContext(1)]
	[Nullable(0)]
	public class HotFixSceneManager : IStaticVariableResetter
	{
		// Token: 0x06000795 RID: 1941 RVA: 0x0003D47B File Offset: 0x0003B67B
		static HotFixSceneManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HotFixSceneManager.CreateStaticDefaultValue), new Action(HotFixSceneManager.ResetStaticDefaultValue));
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0003D4BA File Offset: 0x0003B6BA
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0003D4BC File Offset: 0x0003B6BC
		public static void ResetStaticDefaultValue()
		{
			HotFixSceneManager.Camera = null;
			HotFixSceneManager.BgmAudioId = null;
			HotFixSceneManager.AudioEvent = null;
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0003D4D8 File Offset: 0x0003B6D8
		public void SetupScene(UObject worldContext)
		{
			this.WorldContext = worldContext;
			int hour = UKismetMathLibrary.GetHour(UKismetMathLibrary.Now());
			UKuroRenderingRuntimeBPPluginBPLibrary.SetGlobalGITime(this.WorldContext, (float)hour);
			HotFixSceneManager.SpawnCamera(worldContext);
			HotFixSceneManager.SetViewTarget(worldContext);
			this.PlayHotPatchBgm();
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x0003D517 File Offset: 0x0003B717
		public void Destroy()
		{
			this.DestroySequence();
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0003D520 File Offset: 0x0003B720
		protected static void SpawnCamera(UObject worldContext)
		{
			TSubclassOf<AActor> actorClass = ACineCameraActor.StaticClass();
			FTransformDouble ftransformDouble = new FTransformDouble();
			ACineCameraActor acineCameraActor = UKuroRenderingRuntimeBPPluginBPLibrary.D_SpawnActorFromClass(worldContext, actorClass, ftransformDouble, ESpawnActorCollisionHandlingMethod.Undefined, null, null, true) as ACineCameraActor;
			acineCameraActor.CameraComponent.bConstrainAspectRatio = false;
			acineCameraActor.GetCineCameraComponent().SetFilmbackPresetByName("16:9 DSLR");
			HotFixSceneManager.Camera = acineCameraActor;
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0003D570 File Offset: 0x0003B770
		public static void SetViewTarget(UObject worldContext)
		{
			APlayerController playerController = UGameplayStatics.GetPlayerController(worldContext, 0);
			if (playerController == null)
			{
				LauncherLog.Instance.Error("PlayerController为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			playerController.SetViewTargetWithBlend(HotFixSceneManager.Camera, 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, false, false);
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0003D5BC File Offset: 0x0003B7BC
		[NullableContext(2)]
		public void PlayBlackSeq(Action finishCallback)
		{
			ULevelSequence ulevelSequence = LauncherResourceLib.Instance.Load<ULevelSequence>("/Game/Aki/HotPatch/Sequence/XuanJue1_Black.XuanJue1_Black", 100, "js_call_launch");
			if (ulevelSequence == null || !ulevelSequence.IsValid())
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "热更场景开幕黑屏Sequence加载失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", "/Game/Aki/HotPatch/Sequence/XuanJue1_Black.XuanJue1_Black");
				instance.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				if (finishCallback != null)
				{
					finishCallback();
				}
				return;
			}
			ALevelSequenceActor alevelSequenceActor = new ALevelSequenceActor();
			ULevelSequencePlayer.CreateLevelSequencePlayer(this.WorldContext, ulevelSequence, new FMovieSceneSequencePlaybackSettings(), ref alevelSequenceActor);
			if (finishCallback != null)
			{
				alevelSequenceActor.SequencePlayer.OnFinished.Add(finishCallback);
			}
			alevelSequenceActor.SequencePlayer.Play();
			LauncherLog.Instance.Info("热更场景开幕黑屏Sequence播放", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0003D670 File Offset: 0x0003B870
		public void PlayStartLaunchSeq()
		{
			ULevelSequence ulevelSequence = LauncherResourceLib.Instance.Load<ULevelSequence>("/Game/Aki/HotPatch/Sequence/XuanJue1_Sky.XuanJue1_Sky", 100, "js_call_launch");
			if (ulevelSequence == null || !ulevelSequence.IsValid())
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "热更场景循环Sequence加载失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", "/Game/Aki/HotPatch/Sequence/XuanJue1_Sky.XuanJue1_Sky");
				instance.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			ALevelSequenceActor startSequence = new ALevelSequenceActor();
			ULevelSequencePlayer.CreateLevelSequencePlayer(this.WorldContext, ulevelSequence, new FMovieSceneSequencePlaybackSettings(), ref startSequence);
			this.StartSequence = startSequence;
			this.StartSequence.ResetBindings();
			this.StartSequence.AddBindingByTag(HotFixSceneManager.SEQUNCE_CAMERA_NAME, HotFixSceneManager.Camera, false, false);
			this.StartSequence.SequencePlayer.PlayLooping(-1);
			LauncherLog.Instance.Info("热更场景循环Sequence播放", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0003D734 File Offset: 0x0003B934
		private void DestroySequence()
		{
			LauncherLog.Instance.Info("热更场景结束", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0003D75C File Offset: 0x0003B95C
		public static void StopHotPatchBgm()
		{
			if (HotFixSceneManager.AudioEvent != null)
			{
				UAkGameplayStatics.ExecuteActionOnEvent(HotFixSceneManager.AudioEvent, EAkActionOnEventType.Stop, null, 1500, EAkCurveInterpolation.Linear, 0);
				HotFixSceneManager.AudioEvent = null;
			}
			if (HotFixSceneManager.BgmAudioId != null)
			{
				HotFixSceneManager.BgmAudioId = null;
			}
			LauncherLog instance = LauncherLog.Instance;
			string message = "背景音乐销毁";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", "/Game/Aki/WwiseAudio/Events/play_login_bgm.play_login_bgm");
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x0003D7C7 File Offset: 0x0003B9C7
		public void PlayHotPatchBgm()
		{
			LauncherResourceLib.Instance.LoadAsync<UAkAudioEvent>("/Game/Aki/WwiseAudio/Events/play_login_bgm.play_login_bgm", delegate([Nullable(2)] UAkAudioEvent audioEvent, string path)
			{
				HotFixSceneManager.AudioEvent = audioEvent;
				if (audioEvent == null || !audioEvent.IsValid())
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "背景音乐加载有问题";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", "/Game/Aki/WwiseAudio/Events/play_login_bgm.play_login_bgm");
					instance.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				AActor actor = null;
				int callbackMask = 0;
				FOnAkPostEventCallback fonAkPostEventCallback = null;
				HotFixSceneManager.BgmAudioId = new int?(UAkGameplayStatics.PostEvent(audioEvent, actor, callbackMask, fonAkPostEventCallback, false, ""));
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "播放背景音乐";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("path", "/Game/Aki/WwiseAudio/Events/play_login_bgm.play_login_bgm");
				instance2.Info(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}, 0, "Launch.Audio");
		}

		// Token: 0x0400049B RID: 1179
		private const string BLACK_SEQUENCE = "/Game/Aki/HotPatch/Sequence/XuanJue1_Black.XuanJue1_Black";

		// Token: 0x0400049C RID: 1180
		private const string HOTPATCH_START_SEQUENCE = "/Game/Aki/HotPatch/Sequence/XuanJue1_Sky.XuanJue1_Sky";

		// Token: 0x0400049D RID: 1181
		private const string HOTPATCH_BGM = "/Game/Aki/WwiseAudio/Events/play_login_bgm.play_login_bgm";

		// Token: 0x0400049E RID: 1182
		[StaticVariableRuleIgnore]
		private static readonly FName SEQUNCE_CAMERA_NAME = new FName("SequenceCamera");

		// Token: 0x0400049F RID: 1183
		private const int HOTPATCH_BGM_FADE_TIME = 1500;

		// Token: 0x040004A0 RID: 1184
		[Nullable(2)]
		private UObject WorldContext;

		// Token: 0x040004A1 RID: 1185
		[Nullable(2)]
		private static AActor Camera;

		// Token: 0x040004A2 RID: 1186
		[Nullable(2)]
		private ALevelSequenceActor StartSequence;

		// Token: 0x040004A3 RID: 1187
		private static int? BgmAudioId = null;

		// Token: 0x040004A4 RID: 1188
		[Nullable(2)]
		private static UAkAudioEvent AudioEvent = null;
	}
}

using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Util;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000E3 RID: 227
	[NullableContext(1)]
	[Nullable(0)]
	public class HotFixSceneManager : IStaticVariableResetter
	{
		// Token: 0x06000778 RID: 1912 RVA: 0x0003B88F File Offset: 0x00039A8F
		static HotFixSceneManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HotFixSceneManager.CreateStaticDefaultValue), new Action(HotFixSceneManager.ResetStaticDefaultValue));
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0003B8CE File Offset: 0x00039ACE
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x0003B8D0 File Offset: 0x00039AD0
		public static void ResetStaticDefaultValue()
		{
			HotFixSceneManager.Camera = null;
			HotFixSceneManager.BgmAudioId = null;
			HotFixSceneManager.AudioEvent = null;
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x0003B8EC File Offset: 0x00039AEC
		public void SetupScene(UObject worldContext)
		{
			this.WorldContext = worldContext;
			int hour = UKismetMathLibrary.GetHour(UKismetMathLibrary.Now());
			UKuroRenderingRuntimeBPPluginBPLibrary.SetGlobalGITime(this.WorldContext, (float)hour);
			HotFixSceneManager.SpawnCamera(worldContext);
			HotFixSceneManager.SetViewTarget(worldContext);
			this.PlayHotPatchBgm();
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x0003B92B File Offset: 0x00039B2B
		public void Destroy()
		{
			this.DestroySequence();
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x0003B934 File Offset: 0x00039B34
		protected static void SpawnCamera(UObject worldContext)
		{
			TSubclassOf<AActor> actorClass = ACineCameraActor.StaticClass();
			FTransformDouble ftransformDouble = new FTransformDouble();
			ACineCameraActor acineCameraActor = UKuroRenderingRuntimeBPPluginBPLibrary.D_SpawnActorFromClass(worldContext, actorClass, ftransformDouble, ESpawnActorCollisionHandlingMethod.Undefined, null, null, true) as ACineCameraActor;
			acineCameraActor.CameraComponent.bConstrainAspectRatio = false;
			acineCameraActor.GetCineCameraComponent().SetFilmbackPresetByName("16:9 DSLR");
			HotFixSceneManager.Camera = acineCameraActor;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0003B984 File Offset: 0x00039B84
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

		// Token: 0x0600077F RID: 1919 RVA: 0x0003B9D0 File Offset: 0x00039BD0
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

		// Token: 0x06000780 RID: 1920 RVA: 0x0003BA84 File Offset: 0x00039C84
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

		// Token: 0x06000781 RID: 1921 RVA: 0x0003BB48 File Offset: 0x00039D48
		private void DestroySequence()
		{
			LauncherLog.Instance.Info("热更场景结束", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x0003BB70 File Offset: 0x00039D70
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

		// Token: 0x06000783 RID: 1923 RVA: 0x0003BBDB File Offset: 0x00039DDB
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

		// Token: 0x0400046C RID: 1132
		private const string BLACK_SEQUENCE = "/Game/Aki/HotPatch/Sequence/XuanJue1_Black.XuanJue1_Black";

		// Token: 0x0400046D RID: 1133
		private const string HOTPATCH_START_SEQUENCE = "/Game/Aki/HotPatch/Sequence/XuanJue1_Sky.XuanJue1_Sky";

		// Token: 0x0400046E RID: 1134
		private const string HOTPATCH_BGM = "/Game/Aki/WwiseAudio/Events/play_login_bgm.play_login_bgm";

		// Token: 0x0400046F RID: 1135
		[StaticVariableRuleIgnore]
		private static readonly FName SEQUNCE_CAMERA_NAME = new FName("SequenceCamera");

		// Token: 0x04000470 RID: 1136
		private const int HOTPATCH_BGM_FADE_TIME = 1500;

		// Token: 0x04000471 RID: 1137
		[Nullable(2)]
		private UObject WorldContext;

		// Token: 0x04000472 RID: 1138
		[Nullable(2)]
		private static AActor Camera;

		// Token: 0x04000473 RID: 1139
		[Nullable(2)]
		private ALevelSequenceActor StartSequence;

		// Token: 0x04000474 RID: 1140
		private static int? BgmAudioId = null;

		// Token: 0x04000475 RID: 1141
		[Nullable(2)]
		private static UAkAudioEvent AudioEvent = null;
	}
}

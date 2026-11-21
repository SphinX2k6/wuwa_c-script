using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SundialControl
{
	// Token: 0x02005B63 RID: 23395
	[NullableContext(1)]
	[Nullable(0)]
	public class SundialControlController : UiControllerBase
	{
		// Token: 0x06039879 RID: 235641 RVA: 0x010274C0 File Offset: 0x010256C0
		public void GenerateModel(Action loadedCallback)
		{
			UObject world = GlobalData.World;
			string text = SundialControlModel.Instance.ModelConfig.场景交互物.AssetPathName.ToString();
			if (text != null && text.Contains('.'))
			{
				text = text.Split('.', StringSplitOptions.None)[0];
			}
			bool flag = false;
			ULevelStreamingDynamic ulevelStreamingDynamic = ULevelStreamingDynamic.LoadLevelInstance(world, text, global::Vector.ZeroVector, global::Rotator.ZeroRotator, ref flag, "", default(TSubclassOf<ULevelStreamingDynamic>));
			if (flag && ulevelStreamingDynamic != null)
			{
				this.SceneInteractionInfo = new SceneInteractionLevel();
				this.SceneInteractionInfo.Init(ulevelStreamingDynamic, text, global::Vector.ZeroVectorDouble, global::Rotator.ZeroRotator, -1, new EKuroSceneInteractionState?(EKuroSceneInteractionState.State1), delegate
				{
					this.SetupSceneInteractionWhenLoadCompleted(loadedCallback);
				}, true, false, 0, 0, null);
			}
		}

		// Token: 0x0603987A RID: 235642 RVA: 0x01027588 File Offset: 0x01025788
		private void SetupSceneInteractionWhenLoadCompleted(Action loadedCallback)
		{
			this.SceneInteractionInfo.MainActor.D_K2_SetActorLocation(SundialControlModel.Instance.TargetLocation, false, ref WorldGlobal.SweepHitResult, false);
			this.SceneInteractionInfo.MainActor.K2_SetActorRotation(SundialControlModel.Instance.TargetRotation, false);
			SundialControlModel.Instance.InitRingActors(this.SceneInteractionInfo);
			loadedCallback();
			this.SceneInteractionInfo.PlaySceneEffect(ESceneInteractionEffect.Effect3);
		}

		// Token: 0x0603987B RID: 235643 RVA: 0x010275F5 File Offset: 0x010257F5
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnSundialRingChangeShine, new Action<int, bool>(this.OnSundialRingChangeShine));
			EventSystem.Instance.Add(EEventName.OnSundialRingSwitch, new Action<int>(this.OnSundialRingSwitch));
		}

		// Token: 0x0603987C RID: 235644 RVA: 0x0102762F File Offset: 0x0102582F
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnSundialRingChangeShine, new Action<int, bool>(this.OnSundialRingChangeShine));
			EventSystem.Instance.Remove(EEventName.OnSundialRingSwitch, new Action<int>(this.OnSundialRingSwitch));
		}

		// Token: 0x0603987D RID: 235645 RVA: 0x0102766C File Offset: 0x0102586C
		private void OnSundialRingChangeShine(int ring, bool isShine)
		{
			ESceneInteractionEffect? esceneInteractionEffect = null;
			if (ring != 0)
			{
				if (ring == 1)
				{
					esceneInteractionEffect = new ESceneInteractionEffect?(ESceneInteractionEffect.Effect1);
				}
			}
			else
			{
				esceneInteractionEffect = new ESceneInteractionEffect?(ESceneInteractionEffect.Effect0);
			}
			if (esceneInteractionEffect == null)
			{
				return;
			}
			if (isShine)
			{
				this.SceneInteractionInfo.PlaySceneEffect(esceneInteractionEffect.Value);
				return;
			}
			this.SceneInteractionInfo.EndSceneEffect(esceneInteractionEffect.Value);
		}

		// Token: 0x0603987E RID: 235646 RVA: 0x010276CE File Offset: 0x010258CE
		private void OnSundialRingSwitch(int ring)
		{
			this.SceneInteractionInfo.EndSceneEffect((ring == 0) ? ESceneInteractionEffect.Effect4 : ESceneInteractionEffect.Effect3);
			this.SceneInteractionInfo.PlaySceneEffect((ring == 0) ? ESceneInteractionEffect.Effect3 : ESceneInteractionEffect.Effect4);
		}

		// Token: 0x0603987F RID: 235647 RVA: 0x010276F4 File Offset: 0x010258F4
		public void DestroyModel()
		{
			if (this.SceneInteractionInfo != null)
			{
				this.SceneInteractionInfo.Destroy();
				this.SceneInteractionInfo = null;
				SundialControlModel.Instance.ClearCacheActor();
			}
		}

		// Token: 0x06039880 RID: 235648 RVA: 0x0102771A File Offset: 0x0102591A
		public void SwitchCurrentRing()
		{
			if (this.IsRotating)
			{
				return;
			}
			SundialControlModel.Instance.ChangeCurrentRingIndex(1);
		}

		// Token: 0x06039881 RID: 235649 RVA: 0x01027730 File Offset: 0x01025930
		[NullableContext(2)]
		public void SetOnFinishCallback(Action callback)
		{
			this.OnFinish = callback;
		}

		// Token: 0x06039882 RID: 235650 RVA: 0x01027739 File Offset: 0x01025939
		[NullableContext(2)]
		public void StartRotate(Action callback)
		{
			if (!this.IsRotating)
			{
				this.IsRotating = true;
				this.StopRotationCallback = callback;
				SundialControlModel.Instance.SimpleAddCurRingSocket(1);
			}
		}

		// Token: 0x06039883 RID: 235651 RVA: 0x0102775C File Offset: 0x0102595C
		protected override void OnTick(float delta)
		{
			if (this.IsRotating && SundialControlModel.Instance.RotateCurrentRing((double)delta))
			{
				this.IsRotating = false;
				if (this.StopRotationCallback != null)
				{
					SundialControlModel.Instance.UpdateTips();
					this.StopRotationCallback();
					this.StopRotationCallback = null;
				}
			}
		}

		// Token: 0x06039884 RID: 235652 RVA: 0x010277AA File Offset: 0x010259AA
		public void ResetAll()
		{
			SundialControlModel.Instance.ResetAll();
		}

		// Token: 0x06039885 RID: 235653 RVA: 0x010277B8 File Offset: 0x010259B8
		public void PlayFinishAnimation()
		{
			if (this.OnFinish != null)
			{
				this.OnFinish();
			}
			this.SceneInteractionInfo.EndSceneEffect(ESceneInteractionEffect.Effect3);
			this.SceneInteractionInfo.EndSceneEffect(ESceneInteractionEffect.Effect4);
			this.SceneInteractionInfo.PlaySceneEffect(ESceneInteractionEffect.Effect2);
			ALevelSequenceActor directorActor = ActorSystem.Instance.Get(ALevelSequenceActor.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, false) as ALevelSequenceActor;
			TTimerAction <>9__2;
			Action <>9__1;
			ResourceSystem.Instance.LoadAsync<ULevelSequence>("/Game/Aki/Scene/InteractionLevel/Animation/Sundial/TPrefab_SM_Sundial_Finish.TPrefab_SM_Sundial_Finish", delegate([Nullable(2)] ULevelSequence result, string _)
			{
				if (result == null || !result.IsValid())
				{
					this.RequestFinish("MainQuest");
					return;
				}
				directorActor.SetActorTickEnabled(true);
				directorActor.SetSequence(result);
				AActor actorByKey = this.SceneInteractionInfo.GetActorByKey("Left");
				directorActor.AddBindingByTag(this.leftTag, actorByKey, false, false);
				AActor actorByKey2 = this.SceneInteractionInfo.GetActorByKey("Right");
				directorActor.AddBindingByTag(this.rightTag, actorByKey2, false, false);
				AActor actorByKey3 = this.SceneInteractionInfo.GetActorByKey("Roll");
				directorActor.AddBindingByTag(this.rollTag, actorByKey3, false, false);
				AActor actorByKey4 = this.SceneInteractionInfo.GetActorByKey("Decal");
				directorActor.AddBindingByTag(this.decalTag, actorByKey4, false, false);
				directorActor.SequencePlayer.SetPlayRate(1f);
				FOnMovieSceneSequencePlayerEvent onFinished = directorActor.SequencePlayer.OnFinished;
				Action callback;
				if ((callback = <>9__1) == null)
				{
					callback = (<>9__1 = delegate()
					{
						TimerSystemInstance instance = TimerSystem.Instance;
						TTimerAction action;
						if ((action = <>9__2) == null)
						{
							action = (<>9__2 = delegate(float _)
							{
								SundialControlController.Instance.RequestFinish("MainQuest");
								ActorSystem.Instance.Put("PlayFinishAnimation", directorActor, null);
							});
						}
						instance.Delay(action, 500f, null, null, true, 1f);
					});
				}
				onFinished.Add(callback);
				directorActor.SequencePlayer.Play();
			}, 100, "js_undefined");
		}

		// Token: 0x06039886 RID: 235654 RVA: 0x01027854 File Offset: 0x01025A54
		private void RequestFinish(string key = "MainQuest")
		{
			UiGamePlayRequest uiGamePlayRequest = UiGamePlayRequest.Create();
			uiGamePlayRequest.GamePlayKey = key;
			uiGamePlayRequest.Type = UiGamePlayType.SundialPuzzle;
			Net.Instance.Call(ERequestMessageId.UiGamePlayRequest, uiGamePlayRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				if (((UiGamePlayResponse)msg).ErrorId == ErrorCode.Success)
				{
					UiManager.Instance.CloseView(EUiViewName.SundialControlView, null);
				}
			}, 0);
		}

		// Token: 0x06039887 RID: 235655 RVA: 0x010278A5 File Offset: 0x01025AA5
		public void UpdateViewTips()
		{
			SundialControlModel.Instance.UpdateTips();
		}

		// Token: 0x06039888 RID: 235656 RVA: 0x010278B1 File Offset: 0x01025AB1
		[NullableContext(2)]
		public AActor GetMainActor()
		{
			SceneInteractionLevel sceneInteractionInfo = this.SceneInteractionInfo;
			if (sceneInteractionInfo == null)
			{
				return null;
			}
			return sceneInteractionInfo.MainActor;
		}

		// Token: 0x17006D72 RID: 28018
		// (get) Token: 0x06039889 RID: 235657 RVA: 0x010278C4 File Offset: 0x01025AC4
		public static SundialControlController Instance
		{
			get
			{
				return SundialControlController._Instance;
			}
		}

		// Token: 0x0603988A RID: 235658 RVA: 0x010278CB File Offset: 0x01025ACB
		public static SundialControlController GetOrCreateInstance()
		{
			if (SundialControlController._Instance == null)
			{
				SundialControlController.CreateInstance();
			}
			return SundialControlController._Instance;
		}

		// Token: 0x0603988B RID: 235659 RVA: 0x010278DF File Offset: 0x01025ADF
		public static bool CreateInstance()
		{
			if (SundialControlController._Instance != null)
			{
				return true;
			}
			SundialControlController._Instance = new SundialControlController();
			return true;
		}

		// Token: 0x0603988C RID: 235660 RVA: 0x010278F5 File Offset: 0x01025AF5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603988D RID: 235661 RVA: 0x010278F7 File Offset: 0x01025AF7
		public static void ResetStaticDefaultValue()
		{
			SundialControlController._Instance = null;
		}

		// Token: 0x0603988E RID: 235662 RVA: 0x010278FF File Offset: 0x01025AFF
		static SundialControlController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SundialControlController.CreateStaticDefaultValue), new Action(SundialControlController.ResetStaticDefaultValue));
		}

		// Token: 0x0401E5CE RID: 124366
		public const string SEQ_PATH = "/Game/Aki/Scene/InteractionLevel/Animation/Sundial/TPrefab_SM_Sundial_Finish.TPrefab_SM_Sundial_Finish";

		// Token: 0x0401E5CF RID: 124367
		public readonly FName leftTag = new FName("Left");

		// Token: 0x0401E5D0 RID: 124368
		public readonly FName rightTag = new FName("Right");

		// Token: 0x0401E5D1 RID: 124369
		public readonly FName rollTag = new FName("Roll");

		// Token: 0x0401E5D2 RID: 124370
		public readonly FName decalTag = new FName("Decal");

		// Token: 0x0401E5D3 RID: 124371
		[Nullable(2)]
		private SceneInteractionLevel SceneInteractionInfo;

		// Token: 0x0401E5D4 RID: 124372
		private bool IsRotating;

		// Token: 0x0401E5D5 RID: 124373
		[Nullable(2)]
		private Action StopRotationCallback;

		// Token: 0x0401E5D6 RID: 124374
		[Nullable(2)]
		private Action OnFinish;

		// Token: 0x0401E5D7 RID: 124375
		[Nullable(2)]
		private static SundialControlController _Instance;
	}
}

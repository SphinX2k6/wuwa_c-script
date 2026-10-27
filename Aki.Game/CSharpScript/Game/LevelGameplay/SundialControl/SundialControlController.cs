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
	// Token: 0x02006A06 RID: 27142
	[NullableContext(1)]
	[Nullable(0)]
	public class SundialControlController : UiControllerBase
	{
		// Token: 0x0604382D RID: 276525 RVA: 0x01082E9C File Offset: 0x0108109C
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

		// Token: 0x0604382E RID: 276526 RVA: 0x01082F64 File Offset: 0x01081164
		private void SetupSceneInteractionWhenLoadCompleted(Action loadedCallback)
		{
			this.SceneInteractionInfo.MainActor.D_K2_SetActorLocation(SundialControlModel.Instance.TargetLocation, false, ref WorldGlobal.SweepHitResult, false);
			this.SceneInteractionInfo.MainActor.K2_SetActorRotation(SundialControlModel.Instance.TargetRotation, false);
			SundialControlModel.Instance.InitRingActors(this.SceneInteractionInfo);
			loadedCallback();
			this.SceneInteractionInfo.PlaySceneEffect(ESceneInteractionEffect.Effect3);
		}

		// Token: 0x0604382F RID: 276527 RVA: 0x01082FD1 File Offset: 0x010811D1
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnSundialRingChangeShine, new Action<int, bool>(this.OnSundialRingChangeShine));
			EventSystem.Instance.Add(EEventName.OnSundialRingSwitch, new Action<int>(this.OnSundialRingSwitch));
		}

		// Token: 0x06043830 RID: 276528 RVA: 0x0108300B File Offset: 0x0108120B
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnSundialRingChangeShine, new Action<int, bool>(this.OnSundialRingChangeShine));
			EventSystem.Instance.Remove(EEventName.OnSundialRingSwitch, new Action<int>(this.OnSundialRingSwitch));
		}

		// Token: 0x06043831 RID: 276529 RVA: 0x01083048 File Offset: 0x01081248
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

		// Token: 0x06043832 RID: 276530 RVA: 0x010830AA File Offset: 0x010812AA
		private void OnSundialRingSwitch(int ring)
		{
			this.SceneInteractionInfo.EndSceneEffect((ring == 0) ? ESceneInteractionEffect.Effect4 : ESceneInteractionEffect.Effect3);
			this.SceneInteractionInfo.PlaySceneEffect((ring == 0) ? ESceneInteractionEffect.Effect3 : ESceneInteractionEffect.Effect4);
		}

		// Token: 0x06043833 RID: 276531 RVA: 0x010830D0 File Offset: 0x010812D0
		public void DestroyModel()
		{
			if (this.SceneInteractionInfo != null)
			{
				this.SceneInteractionInfo.Destroy();
				this.SceneInteractionInfo = null;
				SundialControlModel.Instance.ClearCacheActor();
			}
		}

		// Token: 0x06043834 RID: 276532 RVA: 0x010830F6 File Offset: 0x010812F6
		public void SwitchCurrentRing()
		{
			if (this.IsRotating)
			{
				return;
			}
			SundialControlModel.Instance.ChangeCurrentRingIndex(1);
		}

		// Token: 0x06043835 RID: 276533 RVA: 0x0108310C File Offset: 0x0108130C
		[NullableContext(2)]
		public void SetOnFinishCallback(Action callback)
		{
			this.OnFinish = callback;
		}

		// Token: 0x06043836 RID: 276534 RVA: 0x01083115 File Offset: 0x01081315
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

		// Token: 0x06043837 RID: 276535 RVA: 0x01083138 File Offset: 0x01081338
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

		// Token: 0x06043838 RID: 276536 RVA: 0x01083186 File Offset: 0x01081386
		public void ResetAll()
		{
			SundialControlModel.Instance.ResetAll();
		}

		// Token: 0x06043839 RID: 276537 RVA: 0x01083194 File Offset: 0x01081394
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

		// Token: 0x0604383A RID: 276538 RVA: 0x01083230 File Offset: 0x01081430
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

		// Token: 0x0604383B RID: 276539 RVA: 0x01083281 File Offset: 0x01081481
		public void UpdateViewTips()
		{
			SundialControlModel.Instance.UpdateTips();
		}

		// Token: 0x0604383C RID: 276540 RVA: 0x0108328D File Offset: 0x0108148D
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

		// Token: 0x1700988D RID: 39053
		// (get) Token: 0x0604383D RID: 276541 RVA: 0x010832A0 File Offset: 0x010814A0
		public static SundialControlController Instance
		{
			get
			{
				return SundialControlController._Instance;
			}
		}

		// Token: 0x0604383E RID: 276542 RVA: 0x010832A7 File Offset: 0x010814A7
		public static SundialControlController GetOrCreateInstance()
		{
			if (SundialControlController._Instance == null)
			{
				SundialControlController.CreateInstance();
			}
			return SundialControlController._Instance;
		}

		// Token: 0x0604383F RID: 276543 RVA: 0x010832BB File Offset: 0x010814BB
		public static bool CreateInstance()
		{
			if (SundialControlController._Instance != null)
			{
				return true;
			}
			SundialControlController._Instance = new SundialControlController();
			return true;
		}

		// Token: 0x06043840 RID: 276544 RVA: 0x010832D1 File Offset: 0x010814D1
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06043841 RID: 276545 RVA: 0x010832D3 File Offset: 0x010814D3
		public static void ResetStaticDefaultValue()
		{
			SundialControlController._Instance = null;
		}

		// Token: 0x06043842 RID: 276546 RVA: 0x010832DB File Offset: 0x010814DB
		static SundialControlController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SundialControlController.CreateStaticDefaultValue), new Action(SundialControlController.ResetStaticDefaultValue));
		}

		// Token: 0x040233DC RID: 144348
		public const string SEQ_PATH = "/Game/Aki/Scene/InteractionLevel/Animation/Sundial/TPrefab_SM_Sundial_Finish.TPrefab_SM_Sundial_Finish";

		// Token: 0x040233DD RID: 144349
		public readonly FName leftTag = new FName("Left");

		// Token: 0x040233DE RID: 144350
		public readonly FName rightTag = new FName("Right");

		// Token: 0x040233DF RID: 144351
		public readonly FName rollTag = new FName("Roll");

		// Token: 0x040233E0 RID: 144352
		public readonly FName decalTag = new FName("Decal");

		// Token: 0x040233E1 RID: 144353
		[Nullable(2)]
		private SceneInteractionLevel SceneInteractionInfo;

		// Token: 0x040233E2 RID: 144354
		private bool IsRotating;

		// Token: 0x040233E3 RID: 144355
		[Nullable(2)]
		private Action StopRotationCallback;

		// Token: 0x040233E4 RID: 144356
		[Nullable(2)]
		private Action OnFinish;

		// Token: 0x040233E5 RID: 144357
		[Nullable(2)]
		private static SundialControlController _Instance;
	}
}

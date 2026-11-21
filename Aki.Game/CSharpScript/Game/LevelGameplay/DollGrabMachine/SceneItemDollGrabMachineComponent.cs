using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.GamePlay.DollGrab;
using AkiClient.Game.Aki.Render.RuntimeBP.Interaction;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.DollGrabMachine.DollGrabMachineClawState;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x0200604E RID: 24654
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemDollGrabMachineComponent : EntityComponent
	{
		// Token: 0x1700700E RID: 28686
		// (get) Token: 0x0603B303 RID: 242435 RVA: 0x010BC2D3 File Offset: 0x010BA4D3
		public float TimeLimit
		{
			get
			{
				DollGrabMachineComponent config = this.Config;
				if (config == null)
				{
					return 0f;
				}
				return config.TimeLimit;
			}
		}

		// Token: 0x1700700F RID: 28687
		// (get) Token: 0x0603B304 RID: 242436 RVA: 0x010BC2EA File Offset: 0x010BA4EA
		public FTransformDouble ActorTransform
		{
			get
			{
				return this.ActorComp.ActorTransform;
			}
		}

		// Token: 0x17007010 RID: 28688
		// (get) Token: 0x0603B305 RID: 242437 RVA: 0x010BC2F7 File Offset: 0x010BA4F7
		public bool IsEndlessMode
		{
			get
			{
				return this.IsEndlessModeInternal;
			}
		}

		// Token: 0x17007011 RID: 28689
		// (get) Token: 0x0603B306 RID: 242438 RVA: 0x010BC2FF File Offset: 0x010BA4FF
		public int LeaveDollCount
		{
			get
			{
				return this.LeaveDollCountInternal;
			}
		}

		// Token: 0x17007012 RID: 28690
		// (get) Token: 0x0603B307 RID: 242439 RVA: 0x010BC308 File Offset: 0x010BA508
		[Nullable(1)]
		public List<IGrabItemData> CurrentDropItemList
		{
			[NullableContext(1)]
			get
			{
				List<IGrabItemData> list = new List<IGrabItemData>();
				foreach (KeyValuePair<int, int> keyValuePair in this.CurrentDropItemListInternal)
				{
					int num;
					int num2;
					keyValuePair.Deconstruct(out num, out num2);
					int itemId = num;
					int count = num2;
					list.Add(new GrabItemData
					{
						ItemId = itemId,
						Count = count
					});
				}
				return list;
			}
		}

		// Token: 0x17007013 RID: 28691
		// (get) Token: 0x0603B308 RID: 242440 RVA: 0x010BC388 File Offset: 0x010BA588
		public float PlayCost
		{
			get
			{
				DollGrabMachineComponent config = this.Config;
				return ((config != null) ? config.PlayCost : null).GetValueOrDefault();
			}
		}

		// Token: 0x17007014 RID: 28692
		// (get) Token: 0x0603B309 RID: 242441 RVA: 0x010BC3B7 File Offset: 0x010BA5B7
		public bool IsMachineActive
		{
			get
			{
				return this.IsActiveInternal;
			}
		}

		// Token: 0x17007015 RID: 28693
		// (get) Token: 0x0603B30A RID: 242442 RVA: 0x010BC3BF File Offset: 0x010BA5BF
		public bool IsMachinePause
		{
			get
			{
				return this.IsPauseInternal;
			}
		}

		// Token: 0x17007016 RID: 28694
		// (get) Token: 0x0603B30B RID: 242443 RVA: 0x010BC3C7 File Offset: 0x010BA5C7
		public IDollGrabInfiniteRewardData EndlessRewardData
		{
			get
			{
				return this.EndlessRewardDataInternal;
			}
		}

		// Token: 0x17007017 RID: 28695
		// (get) Token: 0x0603B30C RID: 242444 RVA: 0x010BC3CF File Offset: 0x010BA5CF
		public BP_DollActor_C MainDollActor
		{
			get
			{
				DollGrabMachineItem mainDollActorItem = this.MainDollActorItem;
				if (mainDollActorItem == null)
				{
					return null;
				}
				return mainDollActorItem.ItemActor;
			}
		}

		// Token: 0x17007018 RID: 28696
		// (get) Token: 0x0603B30D RID: 242445 RVA: 0x010BC3E4 File Offset: 0x010BA5E4
		public int ConditionId
		{
			get
			{
				DollGrabMachineComponent config = this.Config;
				int? num;
				if (config == null)
				{
					num = null;
				}
				else
				{
					IDollGrabInfiniteModeData infiniteModeData = config.InfiniteModeData;
					num = ((infiniteModeData != null) ? infiniteModeData.UnlockConditionGroupId : null);
				}
				int? num2 = num;
				return num2.GetValueOrDefault();
			}
		}

		// Token: 0x17007019 RID: 28697
		// (get) Token: 0x0603B30E RID: 242446 RVA: 0x010BC428 File Offset: 0x010BA628
		public IDollGrabInfiniteShowCaseRewardData CurrentScoreRewardData
		{
			get
			{
				DollGrabMachineComponent config = this.Config;
				IDollGrabInfiniteScoreReward dollGrabInfiniteScoreReward;
				if (config == null)
				{
					dollGrabInfiniteScoreReward = null;
				}
				else
				{
					IDollGrabInfiniteModeData infiniteModeData = config.InfiniteModeData;
					dollGrabInfiniteScoreReward = ((infiniteModeData != null) ? infiniteModeData.ScoreReward : null);
				}
				IDollGrabInfiniteScoreReward dollGrabInfiniteScoreReward2 = dollGrabInfiniteScoreReward;
				if (dollGrabInfiniteScoreReward2 == null)
				{
					return null;
				}
				IDollGrabInfiniteRewardData endlessRewardData = this.EndlessRewardData;
				int num = (endlessRewardData != null) ? endlessRewardData.CurrentAccumulatedScore : 0;
				return new DollGrabInfiniteShowCaseRewardData
				{
					DropId = dollGrabInfiniteScoreReward2.RewardId,
					GetRewardIndex = ((dollGrabInfiniteScoreReward2.TargetScore <= num) ? 1 : 0),
					NextRewardIndex = 1
				};
			}
		}

		// Token: 0x0603B30F RID: 242447 RVA: 0x010BC498 File Offset: 0x010BA698
		protected override bool OnInitData(IEntityArgs args = null)
		{
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			DollGrabMachineComponent dollGrabMachineComponent = args.GetP1<CreateEntityData>().GetParam<SceneItemDollGrabMachineComponent>() as DollGrabMachineComponent;
			if (dollGrabMachineComponent == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DollGrabMachine;
				ELogAuthor author = ELogAuthor.FJH;
				string message = "[DollGrabMachineComp] 组件配置缺失";
				string item = "PbDataId";
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			this.Config = dollGrabMachineComponent;
			this.IsEndlessModeInternal = (dollGrabMachineComponent.InfiniteModeData != null);
			if (!string.IsNullOrEmpty(dollGrabMachineComponent.AkEvent))
			{
				string[] array = dollGrabMachineComponent.AkEvent.Split(".", StringSplitOptions.None);
				this.AkEvent = array[array.Length - 1];
			}
			this.OnInitEndlessModeData();
			BP_DollGrabMachineGlobalConfig_C dollGrabMachineGlobalConfig = DollGrabModel.Instance.DollGrabMachineGlobalConfig;
			this.DissolveRadius = ((dollGrabMachineGlobalConfig != null) ? dollGrabMachineGlobalConfig.溶解半径 : 0f);
			if (this.DissolveRadius > 0f)
			{
				float dissolveRadius = this.DissolveRadius;
				BP_DollGrabMachineGlobalConfig_C dollGrabMachineGlobalConfig2 = DollGrabModel.Instance.DollGrabMachineGlobalConfig;
				this.DissolvePerSecond = dissolveRadius / ((dollGrabMachineGlobalConfig2 != null) ? dollGrabMachineGlobalConfig2.溶解时长 : 0f) / 1000f;
			}
			BP_DollGrabMachineGlobalConfig_C dollGrabMachineGlobalConfig3 = DollGrabModel.Instance.DollGrabMachineGlobalConfig;
			this.ItemRotationDamping = ((dollGrabMachineGlobalConfig3 != null) ? dollGrabMachineGlobalConfig3.旋转阻尼 : 0f);
			BP_DollGrabMachineGlobalConfig_C dollGrabMachineGlobalConfig4 = DollGrabModel.Instance.DollGrabMachineGlobalConfig;
			this.ItemMoveDamping = ((dollGrabMachineGlobalConfig4 != null) ? dollGrabMachineGlobalConfig4.平移阻尼 : 0f);
			return true;
		}

		// Token: 0x0603B310 RID: 242448 RVA: 0x010BC5FC File Offset: 0x010BA7FC
		private void OnInitEndlessModeData()
		{
			if (this.IsEndlessModeInternal)
			{
				if (this.Config.InfiniteModeData.RefreshIntervalCurve != "")
				{
					ResourceSystem.Instance.LoadAsync<UCurveFloat>(this.Config.InfiniteModeData.RefreshIntervalCurve, delegate([Nullable(2)] UCurveFloat curve, string _)
					{
						if (curve == null)
						{
							Log instance = Log.Instance;
							ELogModule module = ELogModule.DollGrabMachine;
							ELogAuthor author = ELogAuthor.FJH;
							string message = "[DollGrabMachineComp][无尽模式] 无尽关曲线加载失败";
							string item = "CurvePath";
							IDollGrabInfiniteModeData infiniteModeData = this.Config.InfiniteModeData;
							ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, ((infiniteModeData != null) ? infiniteModeData.RefreshIntervalCurve : null) ?? "NoPath");
							instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
							return;
						}
						this.RefreshIntervalCurve = curve;
					}, 100, "js_undefined");
				}
				if (this.Config.InfiniteModeData.StandbyItemPool.Count > 0)
				{
					foreach (IDollGrabStandbyPoolItem dollGrabStandbyPoolItem in this.Config.InfiniteModeData.StandbyItemPool)
					{
						this.EndlessIdleItemIdList.Add(dollGrabStandbyPoolItem.UniqueId);
						DollGrabMachineItem value = new DollGrabMachineItem(dollGrabStandbyPoolItem.UniqueId, dollGrabStandbyPoolItem.ItemId, null, null, null);
						this.EndlessIdleItemPool[dollGrabStandbyPoolItem.UniqueId] = value;
					}
				}
				IDollGrabInfiniteScoreReward scoreReward = this.Config.InfiniteModeData.ScoreReward;
				if (scoreReward != null)
				{
					DollGrabInfiniteRewardData dollGrabInfiniteRewardData = new DollGrabInfiniteRewardData();
					dollGrabInfiniteRewardData.DropId = scoreReward.RewardId;
					dollGrabInfiniteRewardData.CurrentScore = 0;
					dollGrabInfiniteRewardData.TargetAccumulatedScore = scoreReward.TargetScore;
					DollGrabMachineComponentPb dollGrabMachineInfo = this.CreatureDataComp.DollGrabMachineInfo;
					dollGrabInfiniteRewardData.CurrentAccumulatedScore = ((dollGrabMachineInfo != null) ? dollGrabMachineInfo.AccumulatedScore : 0);
					dollGrabInfiniteRewardData.IsFinalReward = false;
					DollGrabMachineComponentPb dollGrabMachineInfo2 = this.CreatureDataComp.DollGrabMachineInfo;
					dollGrabInfiniteRewardData.HighestScore = ((dollGrabMachineInfo2 != null) ? dollGrabMachineInfo2.HighScore : 0);
					dollGrabInfiniteRewardData.IsFirstGetReward = false;
					this.EndlessRewardDataInternal = dollGrabInfiniteRewardData;
					this.EndlessRewardDataInternal.IsFinalReward = (this.EndlessRewardDataInternal.CurrentAccumulatedScore >= this.EndlessRewardDataInternal.TargetAccumulatedScore);
				}
				List<IDollGrabInfiniteStageConfig> stageConfigs = this.Config.InfiniteModeData.StageConfigs;
				if (stageConfigs != null)
				{
					foreach (IDollGrabInfiniteStageConfig dollGrabInfiniteStageConfig in stageConfigs)
					{
						if (dollGrabInfiniteStageConfig.AudioState != null)
						{
							EndlessAudioStateInfo value2 = new EndlessAudioStateInfo(dollGrabInfiniteStageConfig.Duration, dollGrabInfiniteStageConfig.AudioState);
							this.EndlessAudioDataInternal[dollGrabInfiniteStageConfig.Duration] = value2;
						}
					}
				}
			}
		}

		// Token: 0x0603B311 RID: 242449 RVA: 0x010BC828 File Offset: 0x010BAA28
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<SceneItemActorComponent>();
			if (this.ActorComp == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DollGrabMachine;
				ELogAuthor author = ELogAuthor.FJH;
				string message = "[DollGrabMachineComp] Actor组件缺失";
				string item = "PbDataId";
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			this.StateComp = base.Entity.GetComponent<SceneItemStateComponent>();
			if (this.StateComp == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.DollGrabMachine;
				ELogAuthor author2 = ELogAuthor.FJH;
				string message2 = "[DollGrabMachineComp] State组件缺失";
				string item2 = "PbDataId";
				CreatureDataComponent creatureDataComp2 = this.CreatureDataComp;
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>(item2, (creatureDataComp2 != null) ? new int?(creatureDataComp2.GetPbDataId()) : null);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
			DollGrabMachineController.Instance.RegisterDollGrabMachine(this);
			if (!EventSystem.Instance.HasWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnStateChange)))
			{
				EventSystem.Instance.AddWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnStateChange));
			}
			return true;
		}

		// Token: 0x0603B312 RID: 242450 RVA: 0x010BC967 File Offset: 0x010BAB67
		protected override void OnActivate()
		{
			if (!this.ActorComp.GetIsSceneInteractionLoadCompleted())
			{
				EventSystem.Instance.OnceWithTarget(base.Entity, EEventName.OnSceneInteractionShowCompleted, new Action(this.OnSceneInteractionLoadCompleted));
				return;
			}
			this.OnSceneInteractionLoadCompleted();
		}

		// Token: 0x0603B313 RID: 242451 RVA: 0x010BC9A0 File Offset: 0x010BABA0
		protected override bool OnEnd()
		{
			DgmClawStateController clawStateController = this.ClawStateController;
			if (clawStateController != null)
			{
				clawStateController.Dispose();
			}
			this.ClawStateController = null;
			this.DollItemMap.Clear();
			this.GrabbedItemList.Clear();
			this.GrabbingActorList.Clear();
			this.IsActiveInternal = false;
			DollGrabMachineController.Instance.UnregisterDollGrabMachine(this);
			this.LightActorGroup = new List<AActor>();
			this.GrabEffectTransform = null;
			if (EventSystem.Instance.HasWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnStateChange)))
			{
				EventSystem.Instance.RemoveWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnStateChange));
			}
			if (this.EndlessDropTimer != null)
			{
				TimerSystem.Instance.Remove(this.EndlessDropTimer);
				this.EndlessDropTimer = null;
			}
			if (this.DissolveStartTimer != null)
			{
				TimerSystem.Instance.Remove(this.DissolveStartTimer);
				this.DissolveStartTimer = null;
			}
			if (this.DissolveCloseTimer != null)
			{
				TimerSystem.Instance.Remove(this.DissolveCloseTimer);
				this.DissolveCloseTimer = null;
			}
			return true;
		}

		// Token: 0x0603B314 RID: 242452 RVA: 0x010BCAB5 File Offset: 0x010BACB5
		private void OnStateChange(int stateId, bool isReady)
		{
			this.CheckSceneItemState();
		}

		// Token: 0x0603B315 RID: 242453 RVA: 0x010BCAC0 File Offset: 0x010BACC0
		public void ExecuteTick(float deltaTime)
		{
			if (!this.IsActiveInternal)
			{
				DgmClawStateController clawStateController = this.ClawStateController;
				bool flag;
				if (clawStateController == null)
				{
					flag = true;
				}
				else
				{
					DgmClawBaseMoveState currentState = clawStateController.CurrentState;
					EDollGrabMachineClawState? edollGrabMachineClawState = (currentState != null) ? new EDollGrabMachineClawState?(currentState.ClawState) : null;
					EDollGrabMachineClawState edollGrabMachineClawState2 = EDollGrabMachineClawState.Idle;
					flag = !(edollGrabMachineClawState.GetValueOrDefault() == edollGrabMachineClawState2 & edollGrabMachineClawState != null);
				}
				if (!flag)
				{
					this.DisableTick();
					goto IL_72;
				}
			}
			DgmClawStateController clawStateController2 = this.ClawStateController;
			if (clawStateController2 != null)
			{
				DgmClawBaseMoveState currentState2 = clawStateController2.CurrentState;
				if (currentState2 != null)
				{
					currentState2.Update(deltaTime);
				}
			}
			IL_72:
			if (this.IsEndlessModeInternal && this.IsActiveInternal)
			{
				this.EndlessElapsedTime += deltaTime;
			}
		}

		// Token: 0x0603B316 RID: 242454 RVA: 0x010BCB5D File Offset: 0x010BAD5D
		private bool IsTickEnabled()
		{
			return DollGrabMachineController.Instance.CheckRegisterTick(this);
		}

		// Token: 0x0603B317 RID: 242455 RVA: 0x010BCB6A File Offset: 0x010BAD6A
		private void EnableTick()
		{
			if (!this.IsTickEnabled())
			{
				DollGrabMachineController.Instance.RegisterTick(this);
			}
		}

		// Token: 0x0603B318 RID: 242456 RVA: 0x010BCB7F File Offset: 0x010BAD7F
		private void DisableTick()
		{
			if (this.IsTickEnabled())
			{
				DollGrabMachineController.Instance.UnregisterTick(this);
			}
		}

		// Token: 0x0603B319 RID: 242457 RVA: 0x010BCB94 File Offset: 0x010BAD94
		private void OnSceneInteractionLoadCompleted()
		{
			this.InitDropTriggerActor();
			AActor referenceActor = this.ActorComp.GetReferenceActor("ItemsPool");
			if (referenceActor == null)
			{
				Log.Instance.Error(ELogModule.DollGrabMachine, ELogAuthor.FJH, "[DollGrabMachineComp] 娃娃机实体没有娃娃物品池Actor", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			else
			{
				this.DollItemPoolActor = referenceActor;
			}
			AActor referenceActor2 = this.ActorComp.GetReferenceActor("ConveyBelt");
			if (referenceActor2 == null)
			{
				Log.Instance.Error(ELogModule.DollGrabMachine, ELogAuthor.FJH, "[DollGrabMachineComp] 娃娃机实体没有履带Actor", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			else
			{
				TArray<AActor> tarray = new TArray<AActor>();
				referenceActor2.GetAttachedActors(ref tarray, true);
				foreach (AActor aactor in tarray)
				{
					BP_DollGrabMahcineConveyorBelt_C bp_DollGrabMahcineConveyorBelt_C = aactor as BP_DollGrabMahcineConveyorBelt_C;
					if (bp_DollGrabMahcineConveyorBelt_C != null)
					{
						this.ConveyorBeltActorList.Add(bp_DollGrabMahcineConveyorBelt_C);
						AKuroSplineConveyorBelt akuroSplineConveyorBelt = bp_DollGrabMahcineConveyorBelt_C;
						BP_DollGrabMachineGlobalConfig_C dollGrabMachineGlobalConfig = DollGrabModel.Instance.DollGrabMachineGlobalConfig;
						akuroSplineConveyorBelt.ConveyorSpeed = ((dollGrabMachineGlobalConfig != null) ? dollGrabMachineGlobalConfig.履带移动速度 : 0f);
						AKuroSplineConveyorBelt akuroSplineConveyorBelt2 = bp_DollGrabMahcineConveyorBelt_C;
						BP_DollGrabMachineGlobalConfig_C dollGrabMachineGlobalConfig2 = DollGrabModel.Instance.DollGrabMachineGlobalConfig;
						akuroSplineConveyorBelt2.ConveyorAdsorbDistance = ((dollGrabMachineGlobalConfig2 != null) ? dollGrabMachineGlobalConfig2.履带吸附距离 : 0f);
						AKuroSplineConveyorBelt akuroSplineConveyorBelt3 = bp_DollGrabMahcineConveyorBelt_C;
						BP_DollGrabMachineGlobalConfig_C dollGrabMachineGlobalConfig3 = DollGrabModel.Instance.DollGrabMachineGlobalConfig;
						akuroSplineConveyorBelt3.ConveyorAdsorbSpeed = ((dollGrabMachineGlobalConfig3 != null) ? dollGrabMachineGlobalConfig3.履带吸附速度 : 0f);
						AKuroSplineConveyorBelt akuroSplineConveyorBelt4 = bp_DollGrabMahcineConveyorBelt_C;
						BP_DollGrabMachineGlobalConfig_C dollGrabMachineGlobalConfig4 = DollGrabModel.Instance.DollGrabMachineGlobalConfig;
						akuroSplineConveyorBelt4.SetConveyorTriggerZScale((dollGrabMachineGlobalConfig4 != null) ? dollGrabMachineGlobalConfig4.履带TriggerZ轴缩放值 : 0f);
						UStaticMeshComponent ustaticMeshComponent = aactor.GetComponentByClass(UStaticMeshComponent.StaticClass()) as UStaticMeshComponent;
						if (ustaticMeshComponent != null)
						{
							ustaticMeshComponent.SetCollisionResponseToAllChannels(ECollisionResponse.ECR_Ignore);
							ustaticMeshComponent.SetCollisionResponseToChannel(ECollisionChannel.ECC_PhysicsBody, ECollisionResponse.ECR_Overlap);
						}
					}
				}
			}
			AActor referenceActor3 = this.ActorComp.GetReferenceActor("ConveyBeltCtrl");
			if (referenceActor3 == null)
			{
				Log.Instance.Error(ELogModule.DollGrabMachine, ELogAuthor.FJH, "[DollGrabMachineComp] 娃娃机实体没有履带MeshBp", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			else
			{
				this.ConveyorBeltMeshBpActor = (referenceActor3 as BP_ConveyorBelt_C);
				this.ConveyorBeltMeshBpActor.RunningSpeed = 0f;
			}
			AActor referenceActor4 = this.ActorComp.GetReferenceActor("CenterDissolve");
			if (referenceActor4 == null)
			{
				Log.Instance.Error(ELogModule.DollGrabMachine, ELogAuthor.FJH, "[DollGrabMachineComp] 娃娃机实体没有溶解Actor", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			else
			{
				this.DissolveActor = (referenceActor4 as BP_CenterDissolvePosition_C);
			}
			AActor referenceActor5 = this.ActorComp.GetReferenceActor("BoundaryTriggerGroup");
			if (referenceActor5 == null)
			{
				Log.Instance.Error(ELogModule.DollGrabMachine, ELogAuthor.FJH, "[DollGrabMachineComp] 娃娃机实体没有包围盒Actor组", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			else
			{
				TArray<AActor> tarray2 = new TArray<AActor>();
				referenceActor5.GetAttachedActors(ref tarray2, true);
				int num = tarray2.Num();
				for (int i = 0; i < num; i++)
				{
					AActor aactor2 = tarray2.Get(i);
					aactor2.SetActorEnableCollision(false);
					this.BoundaryTriggerActorList.Add(aactor2);
				}
			}
			this.InitClawActor();
			this.InitDollItem();
			this.InitTeleportTriggerActor();
			if (this.IsEndlessModeInternal)
			{
				this.InitEndlessSpawnPoints();
			}
			this.InitLightGroup();
			this.CheckSceneItemState();
		}

		// Token: 0x0603B31A RID: 242458 RVA: 0x010BCE84 File Offset: 0x010BB084
		private void InitDropTriggerActor()
		{
			AActor referenceActor = this.ActorComp.GetReferenceActor("DropTriggerBox");
			if (referenceActor == null)
			{
				Log.Instance.Error(ELogModule.DollGrabMachine, ELogAuthor.FJH, "[DollGrabMachineComp] 娃娃机实体没有投入口Actor", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.DropTriggerActor = referenceActor;
			FVectorDouble fvectorDouble = referenceActor.D_K2_GetActorLocation();
			FTransformDouble value = new FTransformDouble();
			FVectorDouble fvectorDouble2 = new FVectorDouble(fvectorDouble.X, fvectorDouble.Y, fvectorDouble.Z);
			BP_DollGrabMachineGlobalConfig_C dollGrabMachineGlobalConfig = DollGrabModel.Instance.DollGrabMachineGlobalConfig;
			FVector? fvector = (dollGrabMachineGlobalConfig != null) ? new FVector?(dollGrabMachineGlobalConfig.投出口特效偏移位置) : null;
			FQuat rotation;
			if (fvector != null)
			{
				global::Vector commonTempVector = MathUtils.Instance.CommonTempVector;
				rotation = this.ActorTransform.GetRotation();
				FVector value2 = fvector.Value;
				FVector fvector2 = rotation.RotateVector(value2);
				commonTempVector.FromUeVector(fvector2);
				fvectorDouble2.X += MathUtils.Instance.CommonTempVector.X;
				fvectorDouble2.Y += MathUtils.Instance.CommonTempVector.Y;
				fvectorDouble2.Z += MathUtils.Instance.CommonTempVector.Z;
			}
			value.SetLocation(fvectorDouble2);
			rotation = this.ActorTransform.GetRotation();
			value.SetRotation(rotation);
			this.GrabEffectTransform = new FTransformDouble?(value);
		}

		// Token: 0x0603B31B RID: 242459 RVA: 0x010BCFD8 File Offset: 0x010BB1D8
		private void InitLightGroup()
		{
			AActor referenceActor = this.ActorComp.GetReferenceActor("Lights");
			if (referenceActor == null)
			{
				Log.Instance.Error(ELogModule.DollGrabMachine, ELogAuthor.FJH, "[DollGrabMachineComp] 娃娃机实体没有灯光组Actor", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			TArray<AActor> tarray = new TArray<AActor>();
			referenceActor.GetAttachedActors(ref tarray, true);
			for (int i = 0; i < tarray.Num(); i++)
			{
				AActor item = tarray.Get(i);
				this.LightActorGroup.Add(item);
			}
			AKuroLevelSequenceActor akuroLevelSequenceActor = ActorSystem.Instance.Get<AKuroLevelSequenceActor>(AKuroLevelSequenceActor.StaticClass(), this.ActorComp.ActorTransform, null, false);
			if (akuroLevelSequenceActor != null)
			{
				this.LightGroupSequenceActor = akuroLevelSequenceActor;
				this.SwitchLightGroup(EDollGrabMachineLightGroupState.Normal);
			}
		}

		// Token: 0x0603B31C RID: 242460 RVA: 0x010BD084 File Offset: 0x010BB284
		private void InitTeleportTriggerActor()
		{
			AActor referenceActor = this.ActorComp.GetReferenceActor("RecycleGroup");
			if (referenceActor == null)
			{
				Log.Instance.Error(ELogModule.DollGrabMachine, ELogAuthor.FJH, "[DollGrabMachineComp] 娃娃机实体没有传送门Actor", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			TArray<AActor> tarray = new TArray<AActor>();
			referenceActor.GetAttachedActors(ref tarray, true);
			foreach (AActor aactor in tarray)
			{
				TArray<AActor> tarray2 = new TArray<AActor>();
				aactor.GetAttachedActors(ref tarray2, true);
				if (tarray2.Count != 2)
				{
					Log.Instance.Error(ELogModule.DollGrabMachine, ELogAuthor.FJH, "[DollGrabMachineComp] 娃娃机实体传送门Actor组包含的Actor数量不正确", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				else
				{
					foreach (AActor aactor2 in tarray2)
					{
						if (aactor2 is ATriggerBox)
						{
							this.TeleportTriggerActorList.Add(aactor2);
						}
						else
						{
							this.TeleportTargetLocationList.Add(aactor2.D_K2_GetActorLocation());
						}
					}
				}
			}
		}

		// Token: 0x0603B31D RID: 242461 RVA: 0x010BD1B0 File Offset: 0x010BB3B0
		private void InitClawActor()
		{
			AActor referenceActor = this.ActorComp.GetReferenceActor("Claw");
			if (referenceActor == null)
			{
				Log.Instance.Error(ELogModule.DollGrabMachine, ELogAuthor.FJH, "[DollGrabMachineComp] 娃娃机实体抓钩Actor", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			else
			{
				this.ClawActor = referenceActor;
			}
			AActor referenceActor2 = this.ActorComp.GetReferenceActor("ClawCtrl");
			if (referenceActor2 == null)
			{
				Log.Instance.Error(ELogModule.DollGrabMachine, ELogAuthor.FJH, "[DollGrabMachineComp] 娃娃机实体没有钩爪根节点Actor", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			else
			{
				this.ClawRootCtrlActor = referenceActor2;
			}
			AActor referenceActor3 = this.ActorComp.GetReferenceActor("Chain");
			if (referenceActor3 == null)
			{
				Log.Instance.Error(ELogModule.DollGrabMachine, ELogAuthor.FJH, "[DollGrabMachineComp] 娃娃机实体没有钩爪锁链Actor", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			else
			{
				this.ClawChainActor = referenceActor3;
			}
			this.ClawStateController = new DgmClawStateController(this, this.ClawActor, this.ClawRootCtrlActor, this.ClawChainActor, this.ActorComp.ActorTransform);
			if (DollGrabModel.Instance.DollGrabClawSequence != null)
			{
				this.ClawStateController.Init();
			}
			else
			{
				this.NeedInitClawStateController = true;
			}
			AActor referenceActor4 = this.ActorComp.GetReferenceActor("Roof");
			if (referenceActor4 == null)
			{
				Log.Instance.Error(ELogModule.DollGrabMachine, ELogAuthor.FJH, "[DollGrabMachineComp] 娃娃机实体没有屋顶Actor", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.RoofActor = referenceActor4;
		}

		// Token: 0x0603B31E RID: 242462 RVA: 0x010BD2F9 File Offset: 0x010BB4F9
		public void OnClawSequenceLoaded()
		{
			if (this.NeedInitClawStateController && this.ClawStateController != null)
			{
				this.ClawStateController.Init();
			}
			this.NeedInitClawStateController = false;
		}

		// Token: 0x0603B31F RID: 242463 RVA: 0x010BD320 File Offset: 0x010BB520
		private void CheckSceneItemState()
		{
			if (this.StateComp != null && this.StateComp.State == SceneItemStateComponent.ESceneItemState.Completed)
			{
				this.SwitchLightGroup(EDollGrabMachineLightGroupState.Complete);
				foreach (DollGrabMachineItem dollGrabMachineItem in this.DollItemMap.Values)
				{
					this.ToggleEnableDollItemActor(dollGrabMachineItem.ItemActor, false, false, false);
				}
				if (this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.娃娃机.常态"]))
				{
					BaseTagComponent tagComp = this.TagComp;
					if (tagComp == null)
					{
						return;
					}
					tagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.娃娃机.常态"]));
					return;
				}
			}
			else if (!this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.娃娃机.常态"]))
			{
				BaseTagComponent tagComp2 = this.TagComp;
				if (tagComp2 == null)
				{
					return;
				}
				tagComp2.AddTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.娃娃机.常态"]));
			}
		}

		// Token: 0x0603B320 RID: 242464 RVA: 0x010BD428 File Offset: 0x010BB628
		public void OnStartDollGrabMachine()
		{
			if (this.DropTriggerActor != null)
			{
				this.DropTriggerActor.OnActorBeginOverlap.Add(new Action<AActor, AActor>(this.OnDropTriggerActorBeginOverlap));
			}
			foreach (DollGrabMachineItem dollGrabMachineItem in this.DollItemMap.Values)
			{
				if (!this.GrabbedItemList.Contains(dollGrabMachineItem.ItemId))
				{
					this.ToggleEnableDollItemActor(dollGrabMachineItem.ItemActor, true, true, true);
				}
			}
			DgmClawStateController clawStateController = this.ClawStateController;
			bool flag;
			if (clawStateController == null)
			{
				flag = true;
			}
			else
			{
				DgmClawBaseMoveState currentState = clawStateController.CurrentState;
				if (currentState == null)
				{
					flag = true;
				}
				else
				{
					EDollGrabMachineClawState clawState = currentState.ClawState;
					flag = false;
				}
			}
			if (flag)
			{
				DgmClawStateController clawStateController2 = this.ClawStateController;
				if (clawStateController2 != null)
				{
					clawStateController2.SetTargetState(EDollGrabMachineClawState.Idle);
				}
			}
			this.IsActiveInternal = true;
			this.EnableTick();
			foreach (AActor aactor in this.TeleportTriggerActorList)
			{
				aactor.OnActorBeginOverlap.Add(new Action<AActor, AActor>(this.OnTeleportTriggerActorBeginOverlap));
			}
			foreach (AActor aactor2 in this.BoundaryTriggerActorList)
			{
				aactor2.SetActorEnableCollision(true);
				aactor2.OnActorBeginOverlap.Add(new Action<AActor, AActor>(this.OnBoundaryTriggerActorBeginOverlap));
			}
			this.EnableConveyorBelt(true);
			this.StartGameplayAudio();
			AudioSystem.Instance.SetState("ui_music_3_5_wawaji", "stage1", true);
			if (this.IsEndlessModeInternal)
			{
				this.StartEndlessDropTimer();
				this.EndlessRewardDataInternal.CurrentScore = 0;
				foreach (AActor aactor3 in this.EndlessAvailableSpawnPoints)
				{
					aactor3.SetActorEnableCollision(true);
					aactor3.OnActorBeginOverlap.Add(new Action<AActor, AActor>(this.OnEndlessSpawnPointActorBeginOverlap));
					aactor3.OnActorEndOverlap.Add(new Action<AActor, AActor>(this.OnEndlessSpawnPointActorEndOverlap));
				}
				this.StartEndlessAudioState();
			}
			if (this.RoofActor != null)
			{
				this.RoofActor.SetActorEnableCollision(false);
			}
			this.SwitchLightGroup(EDollGrabMachineLightGroupState.Playing);
			this.CurrentDropItemListInternal.Clear();
		}

		// Token: 0x0603B321 RID: 242465 RVA: 0x010BD680 File Offset: 0x010BB880
		[NullableContext(1)]
		public void OnStopDollGrabMachine(DollGrabStopResponse response)
		{
			if (!this.IsMachineActive)
			{
				return;
			}
			if (this.DropTriggerActor != null)
			{
				this.DropTriggerActor.OnActorBeginOverlap.Remove(new Action<AActor, AActor>(this.OnDropTriggerActorBeginOverlap));
			}
			bool flag = this.LeaveDollCount == 0;
			foreach (DollGrabMachineItem dollGrabMachineItem in this.DollItemMap.Values)
			{
				if (this.GrabbedItemList.Contains(dollGrabMachineItem.ItemId))
				{
					if (dollGrabMachineItem.AddTime != null)
					{
						float? addTime = dollGrabMachineItem.AddTime;
						float num = 0f;
						if (addTime.GetValueOrDefault() > num & addTime != null)
						{
							this.GrabbedItemList.Remove(dollGrabMachineItem.ItemId);
						}
					}
				}
				else if (dollGrabMachineItem.ItemActor != null)
				{
					this.ToggleEnableDollItemActor(dollGrabMachineItem.ItemActor, !flag, false, false);
					FHitResult fhitResult = null;
					if (dollGrabMachineItem.OriginLocation != null)
					{
						AActor itemActor = dollGrabMachineItem.ItemActor;
						FTransformDouble actorTransform = this.ActorComp.ActorTransform;
						FVectorDouble fvectorDouble = dollGrabMachineItem.OriginLocation.ToUeVector(false);
						itemActor.D_K2_SetActorLocation(actorTransform.TransformPosition(fvectorDouble), false, ref fhitResult, true);
					}
					if (dollGrabMachineItem.OriginRotation != null)
					{
						dollGrabMachineItem.ItemActor.K2_SetActorRotation(dollGrabMachineItem.OriginRotation.ToUeRotator(), false);
					}
				}
			}
			this.StopClawTriggerOverlap();
			this.IsActiveInternal = false;
			this.IsPauseInternal = false;
			this.IsCacheCheckTouchAction = false;
			if (this.LeaveDollCount == 0)
			{
				this.SwitchLightGroup(EDollGrabMachineLightGroupState.Complete);
			}
			else
			{
				this.SwitchLightGroup(EDollGrabMachineLightGroupState.BeforePlay);
			}
			foreach (AActor aactor in this.TeleportTriggerActorList)
			{
				aactor.OnActorBeginOverlap.Remove(new Action<AActor, AActor>(this.OnTeleportTriggerActorBeginOverlap));
			}
			foreach (AActor aactor2 in this.BoundaryTriggerActorList)
			{
				aactor2.SetActorEnableCollision(false);
				aactor2.OnActorBeginOverlap.Remove(new Action<AActor, AActor>(this.OnBoundaryTriggerActorBeginOverlap));
			}
			this.EnableConveyorBelt(false);
			if (this.AkEventHandle > 0)
			{
				AudioSystem.Instance.ExecuteAction(this.AkEventHandle, EAudioActionType.Stop, null);
				this.AkEventHandle = -1;
			}
			this.ClawMoveDirectionInternal.X = 0f;
			this.ClawMoveDirectionInternal.Y = 0f;
			if (this.IsEndlessModeInternal)
			{
				if (this.EndlessDropTimer != null)
				{
					this.EndlessDropTimer.Remove();
				}
				this.EndlessDropTimer = null;
				this.EndlessElapsedTime = 0f;
				this.PendingDropItemInfoList.Clear();
				this.IsDropRefreshTime = false;
				this.ResetEndlessRewardData(response);
				foreach (AActor aactor3 in this.EndlessAvailableSpawnPoints)
				{
					aactor3.SetActorEnableCollision(false);
					aactor3.OnActorBeginOverlap.Remove(new Action<AActor, AActor>(this.OnEndlessSpawnPointActorBeginOverlap));
					aactor3.OnActorEndOverlap.Remove(new Action<AActor, AActor>(this.OnEndlessSpawnPointActorEndOverlap));
					this.EndlessAvailableSpawnPointsMap[aactor3].Clear();
				}
				this.RevertEndlessStartItem();
				this.StopEndlessAudioState();
			}
			if (this.RoofActor != null)
			{
				this.RoofActor.SetActorEnableCollision(true);
			}
			this.GrabbingActorList.Clear();
			DgmClawStateController clawStateController = this.ClawStateController;
			if (clawStateController == null)
			{
				return;
			}
			clawStateController.SetTargetState(EDollGrabMachineClawState.Reset);
		}

		// Token: 0x0603B322 RID: 242466 RVA: 0x010BDA20 File Offset: 0x010BBC20
		public void ChangeClawState(EDollGrabMachineClawState newState)
		{
			DgmClawStateController clawStateController = this.ClawStateController;
			if (clawStateController == null)
			{
				return;
			}
			clawStateController.SetTargetState(newState);
		}

		// Token: 0x0603B323 RID: 242467 RVA: 0x010BDA34 File Offset: 0x010BBC34
		public void StartClawTriggerOverlap()
		{
			if (this.ClawActor != null)
			{
				if (!this.ClawActor.OnActorBeginOverlap.IsBound())
				{
					this.ClawActor.OnActorBeginOverlap.Add(new Action<AActor, AActor>(this.OnClawTriggerActorBeginOverlap));
				}
				if (!this.ClawActor.OnActorEndOverlap.IsBound())
				{
					this.ClawActor.OnActorEndOverlap.Add(new Action<AActor, AActor>(this.OnClawTriggerActorEndOverlap));
				}
			}
		}

		// Token: 0x0603B324 RID: 242468 RVA: 0x010BDAA5 File Offset: 0x010BBCA5
		public void StopClawTriggerOverlap()
		{
			if (this.ClawActor != null)
			{
				this.ClawActor.OnActorBeginOverlap.Clear();
				this.ClawActor.OnActorEndOverlap.Clear();
			}
		}

		// Token: 0x0603B325 RID: 242469 RVA: 0x010BDAD0 File Offset: 0x010BBCD0
		private void OnClawTriggerActorBeginOverlap(AActor overlappedActor, AActor otherActor)
		{
			if (overlappedActor == null || otherActor == null || !this.IsMachineActive)
			{
				return;
			}
			BP_DollActor_C bp_DollActor_C = otherActor as BP_DollActor_C;
			if (bp_DollActor_C == null)
			{
				return;
			}
			DollGrabMachineItem dollGrabMachineItem;
			this.DollItemMap.TryGetValue(bp_DollActor_C.Id, out dollGrabMachineItem);
			if (dollGrabMachineItem == null)
			{
				return;
			}
			this.GrabbingActorList.Add(bp_DollActor_C);
			EventSystem.Instance.Emit<bool>(EEventName.OnDollGrabMachineGrabbingActorChanged, this.HasGrabbingActor);
		}

		// Token: 0x0603B326 RID: 242470 RVA: 0x010BDB31 File Offset: 0x010BBD31
		private void OnClawTriggerActorEndOverlap(AActor overlappedActor, AActor otherActor)
		{
			if (overlappedActor == null || otherActor == null)
			{
				return;
			}
			this.GrabbingActorList.Remove(otherActor);
			BP_DollActor_C bp_DollActor_C = otherActor as BP_DollActor_C;
			if (bp_DollActor_C != null)
			{
				bp_DollActor_C.TogglePlayIdleAnim(true);
			}
			EventSystem.Instance.Emit<bool>(EEventName.OnDollGrabMachineGrabbingActorChanged, this.HasGrabbingActor);
		}

		// Token: 0x0603B327 RID: 242471 RVA: 0x010BDB70 File Offset: 0x010BBD70
		public void CheckTouchGetItemInClawTrigger()
		{
			if (!this.IsMachineActive)
			{
				if (this.IsPauseInternal)
				{
					this.IsCacheCheckTouchAction = true;
				}
				return;
			}
			List<DollGrabMachineItem> list = new List<DollGrabMachineItem>();
			foreach (AActor aactor in this.GrabbingActorList)
			{
				BP_DollActor_C bp_DollActor_C = aactor as BP_DollActor_C;
				if (bp_DollActor_C != null)
				{
					DollGrabMachineItem dollGrabMachineItem;
					this.DollItemMap.TryGetValue(bp_DollActor_C.Id, out dollGrabMachineItem);
					if (dollGrabMachineItem != null)
					{
						if (dollGrabMachineItem.IsTouchGet)
						{
							list.Add(dollGrabMachineItem);
						}
						bp_DollActor_C.TogglePlayGrabAnim(true, 1f);
					}
				}
			}
			foreach (DollGrabMachineItem dollGrabMachineItem2 in list)
			{
				this.ToggleEnableDollItemActor(dollGrabMachineItem2.ItemActor, false, false, false);
				this.NotifyDollGrabRequest(dollGrabMachineItem2, true);
			}
		}

		// Token: 0x1700701A RID: 28698
		// (get) Token: 0x0603B328 RID: 242472 RVA: 0x010BDC68 File Offset: 0x010BBE68
		public bool HasGrabbingActor
		{
			get
			{
				return this.GrabbingActorList.Count > 0;
			}
		}

		// Token: 0x1700701B RID: 28699
		// (get) Token: 0x0603B329 RID: 242473 RVA: 0x010BDC78 File Offset: 0x010BBE78
		[Nullable(1)]
		public DgmClawBaseMoveState ClawState
		{
			[NullableContext(1)]
			get
			{
				DgmClawStateController clawStateController = this.ClawStateController;
				if (clawStateController == null)
				{
					return null;
				}
				return clawStateController.CurrentState;
			}
		}

		// Token: 0x1700701C RID: 28700
		// (get) Token: 0x0603B32A RID: 242474 RVA: 0x010BDC8B File Offset: 0x010BBE8B
		// (set) Token: 0x0603B32B RID: 242475 RVA: 0x010BDC93 File Offset: 0x010BBE93
		[Nullable(1)]
		public DollGrabMachineClawDirection ClawMoveDirection
		{
			[NullableContext(1)]
			get
			{
				return this.ClawMoveDirectionInternal;
			}
			[NullableContext(1)]
			set
			{
				this.ClawMoveDirectionInternal.X = value.X;
				this.ClawMoveDirectionInternal.Y = value.Y;
			}
		}

		// Token: 0x1700701D RID: 28701
		// (get) Token: 0x0603B32C RID: 242476 RVA: 0x010BDCB7 File Offset: 0x010BBEB7
		public AKuroLevelSequenceActor ClawAnimSeqActor
		{
			get
			{
				DgmClawStateController clawStateController = this.ClawStateController;
				if (clawStateController == null)
				{
					return null;
				}
				return clawStateController.ClawAnimSeqActor;
			}
		}

		// Token: 0x1700701E RID: 28702
		// (get) Token: 0x0603B32D RID: 242477 RVA: 0x010BDCCC File Offset: 0x010BBECC
		public EDollGrabMachineClawState? LastClawState
		{
			get
			{
				DgmClawStateController clawStateController = this.ClawStateController;
				if (clawStateController == null)
				{
					return null;
				}
				return clawStateController.LastState;
			}
		}

		// Token: 0x0603B32E RID: 242478 RVA: 0x010BDCF4 File Offset: 0x010BBEF4
		private unsafe void InitDollItem()
		{
			if (this.DollItemPoolActor == null || this.Config == null || this.Config.Items.Count == 0)
			{
				return;
			}
			this.LeaveDollCountInternal = 0;
			bool flag = this.StateComp != null && this.StateComp.State == SceneItemStateComponent.ESceneItemState.Completed;
			TArray<AActor> tarray = new TArray<AActor>();
			this.DollItemPoolActor.GetAttachedActors(ref tarray, true);
			int num = tarray.Num();
			for (int i = 0; i < num; i++)
			{
				BP_DollActor_C bp_DollActor_C = tarray.Get(i) as BP_DollActor_C;
				if (bp_DollActor_C != null)
				{
					int? num2 = null;
					foreach (IDollGrabItem dollGrabItem in this.Config.Items)
					{
						if (dollGrabItem.Id == bp_DollActor_C.Id)
						{
							num2 = new int?(dollGrabItem.ItemId);
							break;
						}
					}
					if (num2 == null)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.DollGrabMachine;
						ELogAuthor author = ELogAuthor.FJH;
						string message = "[DollGrabMachineComp] 娃娃实体物品配置缺失";
						<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
						ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
						string item = "PbDataId";
						CreatureDataComponent creatureDataComp = this.CreatureDataComp;
						ptr = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ItemId", bp_DollActor_C.Id);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("CategoryId", num2);
						instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					}
					else
					{
						global::Vector commonTempVector = MathUtils.Instance.CommonTempVector;
						FTransformDouble actorTransform = this.ActorComp.ActorTransform;
						FVectorDouble fvectorDouble = bp_DollActor_C.D_K2_GetActorLocation();
						FVectorDouble fvectorDouble2 = actorTransform.InverseTransformPosition(fvectorDouble);
						commonTempVector.FromUeVector(fvectorDouble2);
						global::Rotator commonTempRotator = MathUtils.Instance.CommonTempRotator;
						FRotator frotator = bp_DollActor_C.K2_GetActorRotation();
						commonTempRotator.FromUeRotator(frotator);
						DollGrabMachineItem dollGrabMachineItem = new DollGrabMachineItem(bp_DollActor_C.Id, num2.Value, bp_DollActor_C, MathUtils.Instance.CommonTempVector, MathUtils.Instance.CommonTempRotator);
						this.DollItemMap[bp_DollActor_C.Id] = dollGrabMachineItem;
						if (this.CreatureDataComp.DollGrabMachineInfo != null && !this.CreatureDataComp.DollGrabMachineInfo.CanCapturedItems.Contains(bp_DollActor_C.Id) && !this.IsEndlessModeInternal)
						{
							this.ToggleEnableDollItemActor(bp_DollActor_C, false, false, false);
							this.GrabbedItemList.Add(bp_DollActor_C.Id);
						}
						else if (dollGrabMachineItem.AddTime == null)
						{
							this.LeaveDollCountInternal++;
							this.ToggleEnableDollItemActor(bp_DollActor_C, true, false, false);
						}
						else if (flag)
						{
							this.ToggleEnableDollItemActor(bp_DollActor_C, false, false, false);
						}
						bp_DollActor_C.SetPhysicsParameters(this.ItemRotationDamping, this.ItemMoveDamping);
						if (this.IsEndlessModeInternal)
						{
							dollGrabMachineItem.IsEndlessStartItem = true;
							this.SetDollActorEndlessMaterial(dollGrabMachineItem).Forget();
						}
						else if (dollGrabMachineItem.AddTime == null)
						{
							bp_DollActor_C.OnBeginPlay.Add(new Action<BP_DollActor_C>(this.OnDollActorBeginPlay));
						}
					}
				}
			}
		}

		// Token: 0x0603B32F RID: 242479 RVA: 0x010BE01C File Offset: 0x010BC21C
		private void OnDropTriggerActorBeginOverlap(AActor overlappedActor, AActor otherActor)
		{
			if (overlappedActor == null || otherActor == null || !this.IsMachineActive)
			{
				return;
			}
			BP_DollActor_C bp_DollActor_C = otherActor as BP_DollActor_C;
			if (bp_DollActor_C == null)
			{
				return;
			}
			DollGrabMachineItem dollGrabMachineItem;
			this.DollItemMap.TryGetValue(bp_DollActor_C.Id, out dollGrabMachineItem);
			if (dollGrabMachineItem == null)
			{
				return;
			}
			if (this.GrabbedItemList.Contains(bp_DollActor_C.Id) || this.EndlessIdleItemIdList.Contains(bp_DollActor_C.Id))
			{
				return;
			}
			this.ToggleEnableDollItemActor(bp_DollActor_C, false, false, false);
			this.NotifyDollGrabRequest(dollGrabMachineItem, dollGrabMachineItem.IsTouchGet);
		}

		// Token: 0x0603B330 RID: 242480 RVA: 0x010BE09C File Offset: 0x010BC29C
		[NullableContext(1)]
		private void NotifyDollGrabRequest(DollGrabMachineItem itemInfo, bool isTimeBall = false)
		{
			if (isTimeBall)
			{
				DollGrabTimeBallRequest dollGrabTimeBallRequest = DollGrabTimeBallRequest.Create();
				dollGrabTimeBallRequest.EntityIncId = this.CreatureDataComp.GetCreatureDataId();
				dollGrabTimeBallRequest.ItemUniId = itemInfo.ItemId;
				if (itemInfo.AddTime != null)
				{
					float? addTime = itemInfo.AddTime;
					float num = 0f;
					if (!(addTime.GetValueOrDefault() <= num & addTime != null))
					{
						Net.Instance.Call(ERequestMessageId.DollGrabTimeBallRequest, dollGrabTimeBallRequest, delegate(IMessage msg, Net.CallbackStatus _)
						{
							DollGrabTimeBallResponse dollGrabTimeBallResponse = (DollGrabTimeBallResponse)msg;
							if (dollGrabTimeBallResponse == null)
							{
								return;
							}
							if (this.GrabbingActorList.Contains(itemInfo.ItemActor))
							{
								this.GrabbingActorList.Remove(itemInfo.ItemActor);
							}
							ErrorCode errorCode = dollGrabTimeBallResponse.ErrorCode;
							if (errorCode == ErrorCode.Success)
							{
								EventSystem.Instance.Emit<float>(EEventName.OnDollGrabMachineRemainingTimeAdd, itemInfo.AddTime.Value * 1000f);
								if (this.IsEndlessModeInternal)
								{
									this.OnEndlessDollGrabResponse(itemInfo, isTimeBall);
								}
								else
								{
									this.GrabbedItemList.Add(itemInfo.ItemId);
								}
								itemInfo.ItemActor.PlayGrabEffect(this.IsEndlessModeInternal, itemInfo.ItemActor.D_K2_GetActorLocation());
								itemInfo.ItemActor.PlayTimeEffect();
								return;
							}
							if (errorCode == ErrorCode.ErrDollGarbTimeOut)
							{
								DollGrabMachineController.Instance.PreExitDollGrabMachine(EDollGrabMachineEndReason.TimeUp, false);
								return;
							}
							if (errorCode != ErrorCode.ErrDollGrabAlreadyPaused)
							{
								Log instance = Log.Instance;
								ELogModule module = ELogModule.DollGrabMachine;
								ELogAuthor author = ELogAuthor.FJH;
								string message = "[DollGrabMachineComp] 抓取时间球请求失败";
								ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("errorCode", dollGrabTimeBallResponse.ErrorCode);
								instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
								return;
							}
							if (itemInfo.OriginLocation != null)
							{
								FHitResult fhitResult = null;
								AActor itemActor = itemInfo.ItemActor;
								FTransformDouble actorTransform = this.ActorComp.ActorTransform;
								FVectorDouble fvectorDouble = itemInfo.OriginLocation.ToUeVector(false);
								itemActor.D_K2_SetActorLocation(actorTransform.TransformPosition(fvectorDouble), false, ref fhitResult, true);
							}
							this.ToggleEnableDollItemActor(itemInfo.ItemActor, true, false, false);
							this.GrabbingActorList.Add(itemInfo.ItemActor);
						}, 0);
						return;
					}
				}
				return;
			}
			DollGrabRequest dollGrabRequest = DollGrabRequest.Create();
			dollGrabRequest.EntityIncId = this.CreatureDataComp.GetCreatureDataId();
			dollGrabRequest.ItemUniId = itemInfo.ItemId;
			Net.Instance.Call(ERequestMessageId.DollGrabRequest, dollGrabRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DollGrabResponse dollGrabResponse = (DollGrabResponse)msg;
				if (dollGrabResponse == null)
				{
					return;
				}
				ErrorCode errorCode = dollGrabResponse.ErrorCode;
				if (errorCode != ErrorCode.Success)
				{
					if (errorCode == ErrorCode.ErrDollGarbTimeOut)
					{
						DollGrabMachineController.Instance.PreExitDollGrabMachine(EDollGrabMachineEndReason.TimeUp, false);
						return;
					}
					if (errorCode == ErrorCode.ErrDollGrabAlreadyPaused)
					{
						if (itemInfo.OriginLocation != null)
						{
							FHitResult fhitResult = null;
							AActor itemActor = itemInfo.ItemActor;
							FTransformDouble actorTransform = this.ActorComp.ActorTransform;
							FVectorDouble fvectorDouble = itemInfo.OriginLocation.ToUeVector(false);
							itemActor.D_K2_SetActorLocation(actorTransform.TransformPosition(fvectorDouble), false, ref fhitResult, true);
						}
						this.ToggleEnableDollItemActor(itemInfo.ItemActor, true, false, false);
						return;
					}
					Log instance = Log.Instance;
					ELogModule module = ELogModule.DollGrabMachine;
					ELogAuthor author = ELogAuthor.FJH;
					string message = "[DollGrabMachineComp] 投入物品请求失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("errorCode", dollGrabResponse.ErrorCode);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					itemInfo.ItemActor.PlayGrabEffectByTransform(this.IsEndlessModeInternal, this.GrabEffectTransform.Value);
					if (this.IsEndlessModeInternal)
					{
						this.OnEndlessDollGrabResponse(itemInfo, isTimeBall);
						return;
					}
					this.GrabbedItemList.Add(itemInfo.ItemId);
					this.LeaveDollCountInternal--;
					List<IGrabItemData> list = new List<IGrabItemData>();
					foreach (DollGrabItemInfo dollGrabItemInfo in dollGrabResponse.GrabItemInfos)
					{
						list.Add(new GrabItemData
						{
							ItemId = dollGrabItemInfo.ItemId,
							Count = dollGrabItemInfo.ItemCount
						});
						if (this.CurrentDropItemListInternal.ContainsKey(dollGrabItemInfo.ItemId))
						{
							this.CurrentDropItemListInternal[dollGrabItemInfo.ItemId] = this.CurrentDropItemListInternal[dollGrabItemInfo.ItemId] + dollGrabItemInfo.ItemCount;
						}
						else
						{
							this.CurrentDropItemListInternal[dollGrabItemInfo.ItemId] = dollGrabItemInfo.ItemCount;
						}
					}
					EventSystem.Instance.Emit<int, List<IGrabItemData>>(EEventName.OnDollGrabMachineGrabDoll, this.LeaveDollCountInternal, list);
					BP_DollActor_C itemActor2 = itemInfo.ItemActor;
					if (itemActor2 != null && itemActor2.MainDoll)
					{
						this.MainDollActorItem = itemInfo;
					}
					if (this.LeaveDollCountInternal <= 0)
					{
						DollGrabMachineController.Instance.PreExitDollGrabMachine(EDollGrabMachineEndReason.GetAll, false);
						return;
					}
				}
			}, 0);
		}

		// Token: 0x0603B331 RID: 242481 RVA: 0x010BE19A File Offset: 0x010BC39A
		[NullableContext(1)]
		private void ToggleEnableDollItemActor(BP_DollActor_C dollActor, bool toggleVisibility, bool togglePhysics, bool toggleIdleAnim)
		{
			dollActor.SetVisible(toggleVisibility, togglePhysics);
			if (!togglePhysics)
			{
				dollActor.K2_AttachToActor(this.DollItemPoolActor, null, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, false, true);
			}
			if (toggleIdleAnim)
			{
				dollActor.TogglePlayIdleAnim(toggleIdleAnim);
			}
		}

		// Token: 0x0603B332 RID: 242482 RVA: 0x010BE1CC File Offset: 0x010BC3CC
		private void OnTeleportTriggerActorBeginOverlap(AActor overlappedActor, AActor otherActor)
		{
			if (overlappedActor == null || otherActor == null)
			{
				return;
			}
			BP_DollActor_C bp_DollActor_C = otherActor as BP_DollActor_C;
			if (bp_DollActor_C == null)
			{
				return;
			}
			DollGrabMachineItem dollGrabMachineItem;
			this.DollItemMap.TryGetValue(bp_DollActor_C.Id, out dollGrabMachineItem);
			if (dollGrabMachineItem == null)
			{
				return;
			}
			int num = this.TeleportTriggerActorList.IndexOf(overlappedActor);
			if (num == -1 || this.TeleportTargetLocationList.Count <= num)
			{
				return;
			}
			FHitResult fhitResult = null;
			bp_DollActor_C.D_K2_SetActorLocation(this.TeleportTargetLocationList[num], false, ref fhitResult, true);
		}

		// Token: 0x0603B333 RID: 242483 RVA: 0x010BE23C File Offset: 0x010BC43C
		private void EnableConveyorBelt(bool enable)
		{
			if (this.ConveyorBeltActorList.Count == 0)
			{
				return;
			}
			foreach (BP_DollGrabMahcineConveyorBelt_C bp_DollGrabMahcineConveyorBelt_C in this.ConveyorBeltActorList)
			{
				bp_DollGrabMahcineConveyorBelt_C.ToggleEnableConveyorBelt(enable);
			}
			if (this.ConveyorBeltMeshBpActor != null)
			{
				this.ConveyorBeltMeshBpActor.RunningSpeed = (enable > false);
			}
			if (enable)
			{
				this.ConveyorBeltEventHandle = AudioSystem.Instance.PostEvent("play_nteract_crane_game_conveyor_belt_loop");
			}
			else if (this.ConveyorBeltEventHandle > 0)
			{
				AudioSystem.Instance.ExecuteAction(this.ConveyorBeltEventHandle, EAudioActionType.Stop, null);
				this.ConveyorBeltEventHandle = -1;
			}
			DollGrabModel.Instance.ToggleCancelShadowCache(enable);
		}

		// Token: 0x0603B334 RID: 242484 RVA: 0x010BE304 File Offset: 0x010BC504
		private void InitEndlessSpawnPoints()
		{
			AActor referenceActor = this.ActorComp.GetReferenceActor("EndlessSpawnPoints");
			if (referenceActor == null)
			{
				Log.Instance.Error(ELogModule.DollGrabMachine, ELogAuthor.FJH, "[DollGrabMachineComp][无尽模式] 娃娃机无尽关实体没有掉落生成点Actor", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			TArray<AActor> tarray = new TArray<AActor>();
			referenceActor.GetAttachedActors(ref tarray, true);
			foreach (AActor aactor in tarray)
			{
				this.EndlessSpawnPoints[aactor] = aactor.D_K2_GetActorLocation();
				this.EndlessAvailableSpawnPoints.Add(aactor);
				this.EndlessAvailableSpawnPointsMap[aactor] = new HashSet<AActor>();
				aactor.SetActorEnableCollision(false);
			}
		}

		// Token: 0x0603B335 RID: 242485 RVA: 0x010BE3CC File Offset: 0x010BC5CC
		private void OnEndlessSpawnPointActorBeginOverlap(AActor overlappedActor, AActor otherActor)
		{
			if (overlappedActor == null || otherActor == null)
			{
				return;
			}
			if ((this.ClawStateController.CheckActorInClawPart(otherActor) || otherActor is BP_DollActor_C) && this.EndlessAvailableSpawnPoints.Contains(overlappedActor))
			{
				this.EndlessAvailableSpawnPointsMap[overlappedActor].Add(otherActor);
				this.EndlessAvailableSpawnPoints.Remove(overlappedActor);
			}
		}

		// Token: 0x0603B336 RID: 242486 RVA: 0x010BE42C File Offset: 0x010BC62C
		private void OnEndlessSpawnPointActorEndOverlap(AActor overlappedActor, AActor otherActor)
		{
			if (overlappedActor == null || otherActor == null)
			{
				return;
			}
			if (this.ClawStateController.CheckActorInClawPart(otherActor) || otherActor is BP_DollActor_C)
			{
				this.EndlessAvailableSpawnPointsMap[overlappedActor].Remove(otherActor);
			}
			if (!this.EndlessAvailableSpawnPoints.Contains(overlappedActor) && this.EndlessAvailableSpawnPointsMap[overlappedActor].Count == 0)
			{
				this.EndlessAvailableSpawnPoints.Add(overlappedActor);
			}
		}

		// Token: 0x0603B337 RID: 242487 RVA: 0x010BE49C File Offset: 0x010BC69C
		[NullableContext(1)]
		private void OnEndlessDollGrabResponse(DollGrabMachineItem itemInfo, bool isTimeBall)
		{
			if (itemInfo.EndlessScore > 0)
			{
				this.EndlessRewardData.CurrentScore += itemInfo.EndlessScore;
				EventSystem.Instance.Emit<int, int>(EEventName.OnDollGrabMachineEndlessScoreChanged, this.EndlessRewardData.CurrentScore, itemInfo.EndlessScore);
			}
			int randomItem = MathUtils.Instance.GetRandomItem<int>(this.EndlessIdleItemIdList);
			DollGrabMachineItem dollGrabMachineItem;
			this.EndlessIdleItemPool.TryGetValue(randomItem, out dollGrabMachineItem);
			if (dollGrabMachineItem == null)
			{
				return;
			}
			if (this.IsDropRefreshTime)
			{
				this.SpawnEndlessDollItemActor(dollGrabMachineItem);
				this.IsDropRefreshTime = false;
				this.StartEndlessDropTimer();
			}
			else
			{
				this.PendingDropItemInfoList.Add(dollGrabMachineItem);
			}
			this.EndlessIdleItemPool.Remove(randomItem);
			this.EndlessIdleItemIdList.Remove(randomItem);
			this.EndlessIdleItemPool[itemInfo.ItemId] = itemInfo;
			this.EndlessIdleItemIdList.Add(itemInfo.ItemId);
			this.DollItemMap.Remove(itemInfo.ItemId);
			this.DollItemMap[randomItem] = dollGrabMachineItem;
		}

		// Token: 0x0603B338 RID: 242488 RVA: 0x010BE598 File Offset: 0x010BC798
		[NullableContext(1)]
		private void SpawnEndlessDollItemActor(DollGrabMachineItem itemInfo)
		{
			AActor randomItem = MathUtils.Instance.GetRandomItem<AActor>(this.EndlessAvailableSpawnPoints);
			if (randomItem == null)
			{
				return;
			}
			FVectorDouble newLocation;
			if (!this.EndlessSpawnPoints.TryGetValue(randomItem, out newLocation))
			{
				return;
			}
			FTransformDouble transform = new FTransformDouble();
			transform.SetLocation(newLocation);
			if (itemInfo.ItemActor == null)
			{
				UClass uclass = ResourceSystem.Instance.Load<UClass>(itemInfo.ItemBpPath, "js_undefined");
				if (uclass == null)
				{
					return;
				}
				BP_DollActor_C bp_DollActor_C = ActorSystem.Instance.Spawn(uclass.ClassStackOnlyPtr, transform, this.ActorComp.Owner) as BP_DollActor_C;
				if (bp_DollActor_C == null || !bp_DollActor_C.IsValid())
				{
					return;
				}
				itemInfo.ItemActor = bp_DollActor_C;
				bp_DollActor_C.Id = itemInfo.ItemId;
				bp_DollActor_C.K2_AttachToActor(this.DollItemPoolActor, null, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, false, true);
			}
			else
			{
				FHitResult fhitResult = null;
				itemInfo.ItemActor.D_K2_SetActorLocation(newLocation, false, ref fhitResult, true);
			}
			itemInfo.ItemActor.PlaySpawnEffect();
			this.ToggleEnableDollItemActor(itemInfo.ItemActor, true, true, true);
		}

		// Token: 0x0603B339 RID: 242489 RVA: 0x010BE68C File Offset: 0x010BC88C
		private void StartEndlessDropTimer()
		{
			if (this.EndlessDropTimer != null || this.RefreshIntervalCurve == null)
			{
				return;
			}
			float floatValue = this.RefreshIntervalCurve.GetFloatValue(this.EndlessElapsedTime * 0.001f);
			TTimerAction ttimerAction = delegate(float delta)
			{
				this.IsDropRefreshTime = true;
				this.EndlessDropTimer = null;
				if (this.PendingDropItemInfoList.Count > 0)
				{
					DollGrabMachineItem itemInfo = this.PendingDropItemInfoList.Shift<DollGrabMachineItem>();
					this.SpawnEndlessDollItemActor(itemInfo);
					this.IsDropRefreshTime = false;
					this.StartEndlessDropTimer();
				}
			};
			if (floatValue <= 0f)
			{
				ttimerAction(0f);
				return;
			}
			this.EndlessDropTimer = TimerSystem.Instance.Delay(ttimerAction, floatValue * 1000f, null, null, true, 1f);
		}

		// Token: 0x0603B33A RID: 242490 RVA: 0x010BE704 File Offset: 0x010BC904
		private void RevertEndlessStartItem()
		{
			if (!this.IsEndlessModeInternal)
			{
				return;
			}
			FHitResult fhitResult = null;
			List<int> list = new List<int>();
			foreach (DollGrabMachineItem dollGrabMachineItem in this.DollItemMap.Values)
			{
				if (dollGrabMachineItem.IsEndlessStartItem)
				{
					this.ToggleEnableDollItemActor(dollGrabMachineItem.ItemActor, true, false, false);
					if (dollGrabMachineItem.OriginLocation != null)
					{
						AActor itemActor = dollGrabMachineItem.ItemActor;
						FTransformDouble actorTransform = this.ActorComp.ActorTransform;
						FVectorDouble fvectorDouble = dollGrabMachineItem.OriginLocation.ToUeVector(false);
						itemActor.D_K2_SetActorLocation(actorTransform.TransformPosition(fvectorDouble), false, ref fhitResult, true);
					}
					if (dollGrabMachineItem.OriginRotation != null)
					{
						dollGrabMachineItem.ItemActor.K2_SetActorRotation(dollGrabMachineItem.OriginRotation.ToUeRotator(), false);
					}
				}
				else
				{
					if (dollGrabMachineItem.ItemActor != null)
					{
						this.ToggleEnableDollItemActor(dollGrabMachineItem.ItemActor, false, false, false);
					}
					this.EndlessIdleItemPool[dollGrabMachineItem.ItemId] = dollGrabMachineItem;
					this.EndlessIdleItemIdList.Add(dollGrabMachineItem.ItemId);
					list.Add(dollGrabMachineItem.ItemId);
				}
			}
			foreach (int key in list)
			{
				this.DollItemMap.Remove(key);
			}
			list.Clear();
			foreach (DollGrabMachineItem dollGrabMachineItem2 in this.EndlessIdleItemPool.Values)
			{
				if (dollGrabMachineItem2.IsEndlessStartItem)
				{
					this.ToggleEnableDollItemActor(dollGrabMachineItem2.ItemActor, true, false, false);
					AActor itemActor2 = dollGrabMachineItem2.ItemActor;
					FTransformDouble actorTransform = this.ActorComp.ActorTransform;
					FVectorDouble fvectorDouble = dollGrabMachineItem2.OriginLocation.ToUeVector(false);
					itemActor2.D_K2_SetActorLocation(actorTransform.TransformPosition(fvectorDouble), false, ref fhitResult, true);
					if (dollGrabMachineItem2.OriginRotation != null)
					{
						dollGrabMachineItem2.ItemActor.K2_SetActorRotation(dollGrabMachineItem2.OriginRotation.ToUeRotator(), false);
					}
					this.DollItemMap[dollGrabMachineItem2.ItemId] = dollGrabMachineItem2;
					this.EndlessIdleItemIdList.Remove(dollGrabMachineItem2.ItemId);
					list.Add(dollGrabMachineItem2.ItemId);
				}
			}
			foreach (int key2 in list)
			{
				this.EndlessIdleItemPool.Remove(key2);
			}
		}

		// Token: 0x0603B33B RID: 242491 RVA: 0x010BE9AC File Offset: 0x010BCBAC
		private void StartEndlessAudioState()
		{
			foreach (EndlessAudioStateInfo endlessAudioStateInfo in this.EndlessAudioDataInternal.Values)
			{
				endlessAudioStateInfo.StartAudio();
			}
		}

		// Token: 0x0603B33C RID: 242492 RVA: 0x010BEA04 File Offset: 0x010BCC04
		private void StopEndlessAudioState()
		{
			foreach (EndlessAudioStateInfo endlessAudioStateInfo in this.EndlessAudioDataInternal.Values)
			{
				endlessAudioStateInfo.StopAudio();
			}
		}

		// Token: 0x0603B33D RID: 242493 RVA: 0x010BEA5C File Offset: 0x010BCC5C
		private void PauseEndlessAudioState()
		{
			foreach (EndlessAudioStateInfo endlessAudioStateInfo in this.EndlessAudioDataInternal.Values)
			{
				endlessAudioStateInfo.PauseAudio();
			}
			if (this.AkEventHandle != 0)
			{
				AudioSystem.Instance.ExecuteAction(this.AkEventHandle, EAudioActionType.Pause, null);
			}
		}

		// Token: 0x0603B33E RID: 242494 RVA: 0x010BEAD4 File Offset: 0x010BCCD4
		private void ResumeEndlessAudioState()
		{
			foreach (EndlessAudioStateInfo endlessAudioStateInfo in this.EndlessAudioDataInternal.Values)
			{
				endlessAudioStateInfo.ResumeAudio();
			}
			if (this.AkEventHandle != 0)
			{
				AudioSystem.Instance.ExecuteAction(this.AkEventHandle, EAudioActionType.Resume, null);
			}
		}

		// Token: 0x0603B33F RID: 242495 RVA: 0x010BEB4C File Offset: 0x010BCD4C
		private void StartGameplayAudio()
		{
			if (!this.IsMachineActive || string.IsNullOrEmpty(this.AkEvent))
			{
				return;
			}
			if (this.AkEventHandle > 0)
			{
				AudioSystem.Instance.ExecuteAction(this.AkEventHandle, EAudioActionType.Stop, null);
			}
			this.AkEventHandle = AudioSystem.Instance.PostEvent(this.AkEvent, this.ActorComp.Owner, new PostEventArgs?(new PostEventArgs
			{
				CallbackMask = new ECallbackMask?(ECallbackMask.EndOfEvent),
				CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
				{
					if (callbackType == EAkCallbackType.EndOfEvent && this.IsMachineActive)
					{
						this.StartGameplayAudio();
					}
				}
			}));
		}

		// Token: 0x0603B340 RID: 242496 RVA: 0x010BEBE4 File Offset: 0x010BCDE4
		public void StartDissolve()
		{
			if (this.DissolveActor == null || this.DissolveRadius <= 0f || this.DissolvePerSecond <= 0f || this.DissolveActor.DissolveRadius >= this.DissolveRadius || this.DissolveStartTimer != null)
			{
				return;
			}
			if (this.DissolveCloseTimer != null)
			{
				TimerSystem.Instance.Remove(this.DissolveCloseTimer);
				this.DissolveCloseTimer = null;
			}
			this.DissolveStartTimer = TimerSystem.Instance.Forever(delegate(float delta)
			{
				if (this.DissolveProgress >= this.DissolveRadius)
				{
					TimerSystem.Instance.Remove(this.DissolveStartTimer);
					this.DissolveStartTimer = null;
					return;
				}
				this.DissolveProgress += delta * this.DissolvePerSecond;
				this.DissolveProgress = Math.Min(this.DissolveProgress, this.DissolveRadius);
				this.DissolveActor.DissolveRadius = this.DissolveProgress;
			}, 20f, 1f, null, null, true);
			this.RoofDissolveEventHandle = AudioSystem.Instance.PostEvent("play_interact_crane_game_roof_melting");
			if (!this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.娃娃机.进行中"]))
			{
				BaseTagComponent tagComp = this.TagComp;
				if (tagComp != null)
				{
					tagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.娃娃机.进行中"]));
				}
			}
			if (this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.娃娃机.常态"]))
			{
				BaseTagComponent tagComp2 = this.TagComp;
				if (tagComp2 != null)
				{
					tagComp2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.娃娃机.常态"]));
				}
			}
			int playerId = CreatureModel.Instance.GetPlayerId();
			FormationDataController.Instance.AddPlayerTag(playerId, new int?(GameplayTagDefine.EGameplayTagId["系统.功能.休闲待机.禁用休闲待机"]));
			this.SwitchLightGroup(EDollGrabMachineLightGroupState.BeforePlay);
			foreach (DollGrabMachineItem dollGrabMachineItem in this.DollItemMap.Values)
			{
				if (dollGrabMachineItem.AddTime != null)
				{
					float? addTime = dollGrabMachineItem.AddTime;
					float num = 0f;
					if (addTime.GetValueOrDefault() > num & addTime != null)
					{
						this.ToggleEnableDollItemActor(dollGrabMachineItem.ItemActor, true, false, false);
					}
				}
			}
		}

		// Token: 0x0603B341 RID: 242497 RVA: 0x010BEDC4 File Offset: 0x010BCFC4
		public void StopDissolve()
		{
			if (this.DissolveActor == null || this.DissolveRadius <= 0f || this.DissolvePerSecond <= 0f || this.DissolveActor.DissolveRadius <= 0f || this.DissolveCloseTimer != null)
			{
				return;
			}
			if (this.DissolveStartTimer != null)
			{
				this.DissolveStartTimer.Remove();
				this.DissolveStartTimer = null;
			}
			this.DissolveCloseTimer = TimerSystem.Instance.Forever(delegate(float delta)
			{
				if (this.DissolveProgress <= 0f)
				{
					TimerSystem.Instance.Remove(this.DissolveCloseTimer);
					this.DissolveCloseTimer = null;
					return;
				}
				this.DissolveProgress -= delta * this.DissolvePerSecond;
				this.DissolveProgress = Math.Max(this.DissolveProgress, 0f);
				this.DissolveActor.DissolveRadius = this.DissolveProgress;
			}, 20f, 1f, null, null, true);
			if (this.RoofDissolveEventHandle > 0)
			{
				AudioSystem.Instance.ExecuteAction(this.RoofDissolveEventHandle, EAudioActionType.Stop, null);
				this.RoofDissolveEventHandle = -1;
			}
			if (this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.娃娃机.进行中"]))
			{
				BaseTagComponent tagComp = this.TagComp;
				if (tagComp != null)
				{
					tagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.娃娃机.进行中"]));
				}
			}
			int playerId = CreatureModel.Instance.GetPlayerId();
			FormationDataController.Instance.RemovePlayerTag(playerId, new int?(GameplayTagDefine.EGameplayTagId["系统.功能.休闲待机.禁用休闲待机"]));
			if (this.StateComp != null && this.StateComp.State != SceneItemStateComponent.ESceneItemState.Completed)
			{
				this.SwitchLightGroup(EDollGrabMachineLightGroupState.Normal);
				if (!this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.娃娃机.常态"]))
				{
					BaseTagComponent tagComp2 = this.TagComp;
					if (tagComp2 != null)
					{
						tagComp2.AddTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.娃娃机.常态"]));
					}
				}
			}
			foreach (DollGrabMachineItem dollGrabMachineItem in this.DollItemMap.Values)
			{
				if (dollGrabMachineItem.AddTime != null)
				{
					float? addTime = dollGrabMachineItem.AddTime;
					float num = 0f;
					if (addTime.GetValueOrDefault() > num & addTime != null)
					{
						this.ToggleEnableDollItemActor(dollGrabMachineItem.ItemActor, false, false, false);
					}
				}
			}
		}

		// Token: 0x0603B342 RID: 242498 RVA: 0x010BEFCC File Offset: 0x010BD1CC
		public void PauseDollGrabMachine()
		{
			if (!this.IsActiveInternal)
			{
				return;
			}
			this.IsActiveInternal = false;
			this.IsPauseInternal = true;
			foreach (BP_DollGrabMahcineConveyorBelt_C bp_DollGrabMahcineConveyorBelt_C in this.ConveyorBeltActorList)
			{
				bp_DollGrabMahcineConveyorBelt_C.ToggleEnableConveyorBelt(false);
			}
			if (this.ConveyorBeltEventHandle != 0)
			{
				AudioSystem.Instance.ExecuteAction(this.ConveyorBeltEventHandle, EAudioActionType.Stop, null);
				this.ConveyorBeltEventHandle = -1;
			}
			DgmClawStateController clawStateController = this.ClawStateController;
			if (((clawStateController != null) ? clawStateController.CurrentState : null) != null)
			{
				this.ClawStateController.CurrentState.Pause();
			}
			using (Dictionary<int, DollGrabMachineItem>.ValueCollection.Enumerator enumerator2 = this.DollItemMap.Values.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					DollGrabMachineItem itemInfo = enumerator2.Current;
					if (itemInfo.ItemActor != null && !this.GrabbedItemList.Contains(itemInfo.ItemId) && this.PendingDropItemInfoList.Find((DollGrabMachineItem item) => item.ItemId == itemInfo.ItemId) == null)
					{
						this.ToggleEnableDollItemActor(itemInfo.ItemActor, true, false, false);
					}
				}
			}
			if (this.EndlessDropTimer != null && this.EndlessDropTimer.Valid())
			{
				this.EndlessDropTimer.Pause();
			}
			this.PauseEndlessAudioState();
		}

		// Token: 0x0603B343 RID: 242499 RVA: 0x010BF148 File Offset: 0x010BD348
		public void ResumeDollGrabMachine()
		{
			this.IsActiveInternal = true;
			this.IsPauseInternal = false;
			foreach (BP_DollGrabMahcineConveyorBelt_C bp_DollGrabMahcineConveyorBelt_C in this.ConveyorBeltActorList)
			{
				bp_DollGrabMahcineConveyorBelt_C.ToggleEnableConveyorBelt(true);
			}
			if (this.ConveyorBeltEventHandle <= 0)
			{
				this.ConveyorBeltEventHandle = AudioSystem.Instance.PostEvent("play_nteract_crane_game_conveyor_belt_loop");
			}
			DgmClawStateController clawStateController = this.ClawStateController;
			if (((clawStateController != null) ? clawStateController.CurrentState : null) != null)
			{
				this.ClawStateController.CurrentState.Resume();
			}
			using (Dictionary<int, DollGrabMachineItem>.ValueCollection.Enumerator enumerator2 = this.DollItemMap.Values.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					DollGrabMachineItem itemInfo = enumerator2.Current;
					if (itemInfo.ItemActor != null && !this.GrabbedItemList.Contains(itemInfo.ItemId) && this.PendingDropItemInfoList.Find((DollGrabMachineItem item) => item.ItemId == itemInfo.ItemId) == null)
					{
						this.ToggleEnableDollItemActor(itemInfo.ItemActor, true, true, true);
					}
				}
			}
			if (this.IsCacheCheckTouchAction)
			{
				this.CheckTouchGetItemInClawTrigger();
				this.IsCacheCheckTouchAction = false;
			}
			if (this.EndlessDropTimer != null && this.EndlessDropTimer.Valid())
			{
				this.EndlessDropTimer.Resume();
			}
			this.ResumeEndlessAudioState();
		}

		// Token: 0x0603B344 RID: 242500 RVA: 0x010BF2C4 File Offset: 0x010BD4C4
		private void OnBoundaryTriggerActorBeginOverlap(AActor overlappedActor, AActor otherActor)
		{
			if (overlappedActor == null || otherActor == null)
			{
				return;
			}
			BP_DollActor_C bp_DollActor_C = otherActor as BP_DollActor_C;
			if (bp_DollActor_C == null)
			{
				return;
			}
			DollGrabMachineItem dollGrabMachineItem;
			this.DollItemMap.TryGetValue(bp_DollActor_C.Id, out dollGrabMachineItem);
			if (dollGrabMachineItem == null)
			{
				return;
			}
			FTransformDouble actorTransform = this.ActorComp.ActorTransform;
			FVectorDouble fvectorDouble = dollGrabMachineItem.OriginLocation.ToUeVector(false);
			FVectorDouble newLocation = actorTransform.TransformPosition(fvectorDouble);
			newLocation.Z += 200.0;
			dollGrabMachineItem.ItemActor.ResetPhysics();
			FHitResult fhitResult = null;
			dollGrabMachineItem.ItemActor.D_K2_SetActorLocation(newLocation, false, ref fhitResult, true);
		}

		// Token: 0x0603B345 RID: 242501 RVA: 0x010BF354 File Offset: 0x010BD554
		public void SwitchLightGroup(EDollGrabMachineLightGroupState state)
		{
			ULevelSequence sequence;
			if (!DollGrabModel.Instance.LightGroupSequenceMap.TryGetValue(state, out sequence))
			{
				return;
			}
			ULevelSequencePlayer sequencePlayer = this.LightGroupSequenceActor.SequencePlayer;
			if (sequencePlayer != null && sequencePlayer.IsPlaying())
			{
				ULevelSequencePlayer sequencePlayer2 = this.LightGroupSequenceActor.SequencePlayer;
				if (sequencePlayer2 != null)
				{
					sequencePlayer2.Stop();
				}
			}
			TArray<AActor> tarray = new TArray<AActor>();
			this.LightGroupSequenceActor.SetSequence(sequence);
			foreach (AActor aactor in this.LightActorGroup)
			{
				tarray.Add(aactor);
				this.LightGroupSequenceActor.SetBindingByTag(aactor.Tags.Get(0), tarray, false, false);
				tarray.Empty(true);
			}
			ULevelSequencePlayer sequencePlayer3 = this.LightGroupSequenceActor.SequencePlayer;
			if (sequencePlayer3 == null)
			{
				return;
			}
			sequencePlayer3.Play();
		}

		// Token: 0x0603B346 RID: 242502 RVA: 0x010BF434 File Offset: 0x010BD634
		[NullableContext(1)]
		private void ResetEndlessRewardData(DollGrabStopResponse response)
		{
			this.EndlessRewardData.CurrentScore = response.SessionScore;
			this.EndlessRewardData.CurrentAccumulatedScore = response.AccumulatedScore;
			this.EndlessRewardData.HighestScore = response.HighScore;
			this.EndlessRewardData.IsFirstGetReward = false;
			if (this.EndlessRewardData.CurrentAccumulatedScore >= this.EndlessRewardData.TargetAccumulatedScore && !this.EndlessRewardData.IsFinalReward)
			{
				this.EndlessRewardData.IsFinalReward = true;
				this.EndlessRewardData.IsFirstGetReward = true;
			}
		}

		// Token: 0x0603B347 RID: 242503 RVA: 0x010BF4C0 File Offset: 0x010BD6C0
		[NullableContext(1)]
		private UniTask SetDollActorEndlessMaterial(DollGrabMachineItem itemInfo)
		{
			SceneItemDollGrabMachineComponent.<SetDollActorEndlessMaterial>d__141 <SetDollActorEndlessMaterial>d__;
			<SetDollActorEndlessMaterial>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetDollActorEndlessMaterial>d__.itemInfo = itemInfo;
			<SetDollActorEndlessMaterial>d__.<>1__state = -1;
			<SetDollActorEndlessMaterial>d__.<>t__builder.Start<SceneItemDollGrabMachineComponent.<SetDollActorEndlessMaterial>d__141>(ref <SetDollActorEndlessMaterial>d__);
			return <SetDollActorEndlessMaterial>d__.<>t__builder.Task;
		}

		// Token: 0x0603B348 RID: 242504 RVA: 0x010BF504 File Offset: 0x010BD704
		public void ToggleShowMainDollActor(bool toggle, bool canClear)
		{
			if (this.MainDollActorItem == null)
			{
				return;
			}
			if (toggle)
			{
				this.ToggleEnableDollItemActor(this.MainDollActorItem.ItemActor, true, false, false);
				BP_DollActor_C itemActor = this.MainDollActorItem.ItemActor;
				bool toggle2 = true;
				BP_DollGrabMachineGlobalConfig_C dollGrabMachineGlobalConfig = DollGrabModel.Instance.DollGrabMachineGlobalConfig;
				itemActor.TogglePlayShow(toggle2, (dollGrabMachineGlobalConfig != null) ? dollGrabMachineGlobalConfig.展示动画播放速率 : 1f);
			}
			else
			{
				FHitResult fhitResult = null;
				AActor itemActor2 = this.MainDollActorItem.ItemActor;
				FTransformDouble actorTransform = this.ActorComp.ActorTransform;
				FVectorDouble fvectorDouble = this.MainDollActorItem.OriginLocation.ToUeVector(false);
				itemActor2.D_K2_SetActorLocation(actorTransform.TransformPosition(fvectorDouble), false, ref fhitResult, true);
				this.MainDollActorItem.ItemActor.TogglePlayShow(false, 1f);
				this.ToggleEnableDollItemActor(this.MainDollActorItem.ItemActor, false, false, false);
			}
			if (canClear)
			{
				this.MainDollActorItem = null;
			}
		}

		// Token: 0x0603B349 RID: 242505 RVA: 0x010BF5D0 File Offset: 0x010BD7D0
		private void OnDollActorBeginPlay(BP_DollActor_C actor)
		{
			Log.Instance.Info(ELogModule.DollGrabMachine, ELogAuthor.FJH, "[DollGrabMachineComp] OnDollActorBeginPlay", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (actor == null || this.IsActiveInternal)
			{
				return;
			}
			if (this.GrabbedItemList.Contains(actor.Id))
			{
				this.ToggleEnableDollItemActor(actor, false, false, false);
				return;
			}
			this.ToggleEnableDollItemActor(actor, true, false, false);
		}

		// Token: 0x0603B34A RID: 242506 RVA: 0x010BF630 File Offset: 0x010BD830
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemDollGrabMachineComponent sceneItemDollGrabMachineComponent = (SceneItemDollGrabMachineComponent)componentTemplate;
			if (sceneItemDollGrabMachineComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.StateComp == null)
			{
				this.StateComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StateComp), "StateComp"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.Config == null)
			{
				this.Config = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Config), "Config"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.ClawActor == null)
			{
				this.ClawActor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ClawActor), "ClawActor"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.ClawRootCtrlActor == null)
			{
				this.ClawRootCtrlActor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ClawRootCtrlActor), "ClawRootCtrlActor"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.ClawChainActor == null)
			{
				this.ClawChainActor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ClawChainActor), "ClawChainActor"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.DropTriggerActor == null)
			{
				this.DropTriggerActor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DropTriggerActor), "DropTriggerActor"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.DollItemPoolActor == null)
			{
				this.DollItemPoolActor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DollItemPoolActor), "DollItemPoolActor"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.TeleportTriggerActorList != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TeleportTriggerActorList), "TeleportTriggerActorList"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.TeleportTargetLocationList != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TeleportTargetLocationList), "TeleportTargetLocationList"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.ConveyorBeltActorList != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.ConveyorBeltActorList), "ConveyorBeltActorList"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.ConveyorBeltMeshBpActor == null)
			{
				this.ConveyorBeltMeshBpActor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ConveyorBeltMeshBpActor), "ConveyorBeltMeshBpActor"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.DissolveActor == null)
			{
				this.DissolveActor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DissolveActor), "DissolveActor"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.BoundaryTriggerActorList != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.BoundaryTriggerActorList), "BoundaryTriggerActorList"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.RoofActor == null)
			{
				this.RoofActor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RoofActor), "RoofActor"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.LightActorGroup == null)
			{
				this.LightActorGroup = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LightActorGroup), "LightActorGroup"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.ClawStateController == null)
			{
				this.ClawStateController = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ClawStateController), "ClawStateController"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.ClawMoveDirectionInternal != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.ClawMoveDirectionInternal), "ClawMoveDirectionInternal"))
			{
				return false;
			}
			this.NeedInitClawStateController = sceneItemDollGrabMachineComponent.NeedInitClawStateController;
			if (sceneItemDollGrabMachineComponent.DollItemMap == null)
			{
				this.DollItemMap = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DollItemMap), "DollItemMap"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.GrabbedItemList == null)
			{
				this.GrabbedItemList = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.GrabbedItemList), "GrabbedItemList"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.GrabbingActorList == null)
			{
				this.GrabbingActorList = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.GrabbingActorList), "GrabbingActorList"))
			{
				return false;
			}
			this.LeaveDollCountInternal = sceneItemDollGrabMachineComponent.LeaveDollCountInternal;
			if (sceneItemDollGrabMachineComponent.CurrentDropItemListInternal != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurrentDropItemListInternal), "CurrentDropItemListInternal"))
			{
				return false;
			}
			this.IsActiveInternal = sceneItemDollGrabMachineComponent.IsActiveInternal;
			this.IsPauseInternal = sceneItemDollGrabMachineComponent.IsPauseInternal;
			this.IsCacheCheckTouchAction = sceneItemDollGrabMachineComponent.IsCacheCheckTouchAction;
			this.AkEvent = sceneItemDollGrabMachineComponent.AkEvent;
			this.AkEventHandle = sceneItemDollGrabMachineComponent.AkEventHandle;
			this.GrabEffectTransform = sceneItemDollGrabMachineComponent.GrabEffectTransform;
			this.ItemRotationDamping = sceneItemDollGrabMachineComponent.ItemRotationDamping;
			this.ItemMoveDamping = sceneItemDollGrabMachineComponent.ItemMoveDamping;
			if (sceneItemDollGrabMachineComponent.LightGroupSequenceActor == null)
			{
				this.LightGroupSequenceActor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LightGroupSequenceActor), "LightGroupSequenceActor"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.MainDollActorItem == null)
			{
				this.MainDollActorItem = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MainDollActorItem), "MainDollActorItem"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.DissolveStartTimer == null)
			{
				this.DissolveStartTimer = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DissolveStartTimer), "DissolveStartTimer"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.DissolveCloseTimer == null)
			{
				this.DissolveCloseTimer = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DissolveCloseTimer), "DissolveCloseTimer"))
			{
				return false;
			}
			this.DissolvePerSecond = sceneItemDollGrabMachineComponent.DissolvePerSecond;
			this.DissolveProgress = sceneItemDollGrabMachineComponent.DissolveProgress;
			this.DissolveRadius = sceneItemDollGrabMachineComponent.DissolveRadius;
			this.IsEndlessModeInternal = sceneItemDollGrabMachineComponent.IsEndlessModeInternal;
			if (sceneItemDollGrabMachineComponent.EndlessSpawnPoints != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.EndlessSpawnPoints), "EndlessSpawnPoints"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.EndlessAvailableSpawnPoints != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.EndlessAvailableSpawnPoints), "EndlessAvailableSpawnPoints"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.EndlessAvailableSpawnPointsMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.EndlessAvailableSpawnPointsMap), "EndlessAvailableSpawnPointsMap"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.EndlessIdleItemPool != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.EndlessIdleItemPool), "EndlessIdleItemPool"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.EndlessIdleItemIdList != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.EndlessIdleItemIdList), "EndlessIdleItemIdList"))
			{
				return false;
			}
			this.IsDropRefreshTime = sceneItemDollGrabMachineComponent.IsDropRefreshTime;
			if (sceneItemDollGrabMachineComponent.PendingDropItemInfoList == null)
			{
				this.PendingDropItemInfoList = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PendingDropItemInfoList), "PendingDropItemInfoList"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.RefreshIntervalCurve == null)
			{
				this.RefreshIntervalCurve = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RefreshIntervalCurve), "RefreshIntervalCurve"))
			{
				return false;
			}
			this.EndlessElapsedTime = sceneItemDollGrabMachineComponent.EndlessElapsedTime;
			if (sceneItemDollGrabMachineComponent.EndlessDropTimer == null)
			{
				this.EndlessDropTimer = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.EndlessDropTimer), "EndlessDropTimer"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.EndlessRewardDataInternal == null)
			{
				this.EndlessRewardDataInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.EndlessRewardDataInternal), "EndlessRewardDataInternal"))
			{
				return false;
			}
			if (sceneItemDollGrabMachineComponent.EndlessAudioDataInternal != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.EndlessAudioDataInternal), "EndlessAudioDataInternal"))
			{
				return false;
			}
			this.ConveyorBeltEventHandle = sceneItemDollGrabMachineComponent.ConveyorBeltEventHandle;
			this.RoofDissolveEventHandle = sceneItemDollGrabMachineComponent.RoofDissolveEventHandle;
			return true;
		}

		// Token: 0x1700701F RID: 28703
		// (get) Token: 0x0603B34B RID: 242507 RVA: 0x010BFD1E File Offset: 0x010BDF1E
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007020 RID: 28704
		// (get) Token: 0x0603B34C RID: 242508 RVA: 0x010BFD21 File Offset: 0x010BDF21
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007021 RID: 28705
		// (get) Token: 0x0603B34D RID: 242509 RVA: 0x010BFD24 File Offset: 0x010BDF24
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401F23E RID: 127550
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x0401F23F RID: 127551
		private SceneItemActorComponent ActorComp;

		// Token: 0x0401F240 RID: 127552
		private SceneItemStateComponent StateComp;

		// Token: 0x0401F241 RID: 127553
		private BaseTagComponent TagComp;

		// Token: 0x0401F242 RID: 127554
		private DollGrabMachineComponent Config;

		// Token: 0x0401F243 RID: 127555
		private AActor ClawActor;

		// Token: 0x0401F244 RID: 127556
		private AActor ClawRootCtrlActor;

		// Token: 0x0401F245 RID: 127557
		private AActor ClawChainActor;

		// Token: 0x0401F246 RID: 127558
		private AActor DropTriggerActor;

		// Token: 0x0401F247 RID: 127559
		private AActor DollItemPoolActor;

		// Token: 0x0401F248 RID: 127560
		[Nullable(1)]
		private readonly List<AActor> TeleportTriggerActorList = new List<AActor>();

		// Token: 0x0401F249 RID: 127561
		[Nullable(1)]
		private readonly List<FVectorDouble> TeleportTargetLocationList = new List<FVectorDouble>();

		// Token: 0x0401F24A RID: 127562
		[Nullable(1)]
		private readonly List<BP_DollGrabMahcineConveyorBelt_C> ConveyorBeltActorList = new List<BP_DollGrabMahcineConveyorBelt_C>();

		// Token: 0x0401F24B RID: 127563
		private BP_ConveyorBelt_C ConveyorBeltMeshBpActor;

		// Token: 0x0401F24C RID: 127564
		private BP_CenterDissolvePosition_C DissolveActor;

		// Token: 0x0401F24D RID: 127565
		[Nullable(1)]
		private readonly List<AActor> BoundaryTriggerActorList = new List<AActor>();

		// Token: 0x0401F24E RID: 127566
		private AActor RoofActor;

		// Token: 0x0401F24F RID: 127567
		[Nullable(1)]
		private List<AActor> LightActorGroup = new List<AActor>();

		// Token: 0x0401F250 RID: 127568
		private DgmClawStateController ClawStateController;

		// Token: 0x0401F251 RID: 127569
		[Nullable(1)]
		private readonly DollGrabMachineClawDirection ClawMoveDirectionInternal = new DollGrabMachineClawDirection(0f, 0f);

		// Token: 0x0401F252 RID: 127570
		private bool NeedInitClawStateController;

		// Token: 0x0401F253 RID: 127571
		[Nullable(1)]
		private Dictionary<int, DollGrabMachineItem> DollItemMap = new Dictionary<int, DollGrabMachineItem>();

		// Token: 0x0401F254 RID: 127572
		[Nullable(1)]
		private List<int> GrabbedItemList = new List<int>();

		// Token: 0x0401F255 RID: 127573
		[Nullable(1)]
		private List<AActor> GrabbingActorList = new List<AActor>();

		// Token: 0x0401F256 RID: 127574
		private int LeaveDollCountInternal;

		// Token: 0x0401F257 RID: 127575
		[Nullable(1)]
		private readonly Dictionary<int, int> CurrentDropItemListInternal = new Dictionary<int, int>();

		// Token: 0x0401F258 RID: 127576
		private bool IsActiveInternal;

		// Token: 0x0401F259 RID: 127577
		private bool IsPauseInternal;

		// Token: 0x0401F25A RID: 127578
		private bool IsCacheCheckTouchAction;

		// Token: 0x0401F25B RID: 127579
		private string AkEvent;

		// Token: 0x0401F25C RID: 127580
		private int AkEventHandle = -1;

		// Token: 0x0401F25D RID: 127581
		private FTransformDouble? GrabEffectTransform;

		// Token: 0x0401F25E RID: 127582
		private float ItemRotationDamping;

		// Token: 0x0401F25F RID: 127583
		private float ItemMoveDamping;

		// Token: 0x0401F260 RID: 127584
		private AKuroLevelSequenceActor LightGroupSequenceActor;

		// Token: 0x0401F261 RID: 127585
		private DollGrabMachineItem MainDollActorItem;

		// Token: 0x0401F262 RID: 127586
		private TimerHandle DissolveStartTimer;

		// Token: 0x0401F263 RID: 127587
		private TimerHandle DissolveCloseTimer;

		// Token: 0x0401F264 RID: 127588
		private float DissolvePerSecond;

		// Token: 0x0401F265 RID: 127589
		private float DissolveProgress;

		// Token: 0x0401F266 RID: 127590
		private float DissolveRadius;

		// Token: 0x0401F267 RID: 127591
		private bool IsEndlessModeInternal;

		// Token: 0x0401F268 RID: 127592
		[Nullable(1)]
		private readonly Dictionary<AActor, FVectorDouble> EndlessSpawnPoints = new Dictionary<AActor, FVectorDouble>();

		// Token: 0x0401F269 RID: 127593
		[Nullable(1)]
		private readonly List<AActor> EndlessAvailableSpawnPoints = new List<AActor>();

		// Token: 0x0401F26A RID: 127594
		[Nullable(1)]
		private readonly Dictionary<AActor, HashSet<AActor>> EndlessAvailableSpawnPointsMap = new Dictionary<AActor, HashSet<AActor>>();

		// Token: 0x0401F26B RID: 127595
		[Nullable(1)]
		private readonly Dictionary<int, DollGrabMachineItem> EndlessIdleItemPool = new Dictionary<int, DollGrabMachineItem>();

		// Token: 0x0401F26C RID: 127596
		[Nullable(1)]
		private readonly List<int> EndlessIdleItemIdList = new List<int>();

		// Token: 0x0401F26D RID: 127597
		private bool IsDropRefreshTime;

		// Token: 0x0401F26E RID: 127598
		[Nullable(1)]
		private List<DollGrabMachineItem> PendingDropItemInfoList = new List<DollGrabMachineItem>();

		// Token: 0x0401F26F RID: 127599
		private UCurveFloat RefreshIntervalCurve;

		// Token: 0x0401F270 RID: 127600
		private float EndlessElapsedTime;

		// Token: 0x0401F271 RID: 127601
		private TimerHandle EndlessDropTimer;

		// Token: 0x0401F272 RID: 127602
		private IDollGrabInfiniteRewardData EndlessRewardDataInternal;

		// Token: 0x0401F273 RID: 127603
		[Nullable(1)]
		private readonly Dictionary<float, EndlessAudioStateInfo> EndlessAudioDataInternal = new Dictionary<float, EndlessAudioStateInfo>();

		// Token: 0x0401F274 RID: 127604
		private int ConveyorBeltEventHandle = -1;

		// Token: 0x0401F275 RID: 127605
		private int RoofDissolveEventHandle = -1;
	}
}

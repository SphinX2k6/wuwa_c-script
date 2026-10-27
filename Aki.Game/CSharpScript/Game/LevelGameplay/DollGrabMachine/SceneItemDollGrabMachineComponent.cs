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
	// Token: 0x02006ECE RID: 28366
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemDollGrabMachineComponent : EntityComponent
	{
		// Token: 0x17009AD7 RID: 39639
		// (get) Token: 0x06045162 RID: 282978 RVA: 0x011121F7 File Offset: 0x011103F7
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

		// Token: 0x17009AD8 RID: 39640
		// (get) Token: 0x06045163 RID: 282979 RVA: 0x0111220E File Offset: 0x0111040E
		public FTransformDouble ActorTransform
		{
			get
			{
				return this.ActorComp.ActorTransform;
			}
		}

		// Token: 0x17009AD9 RID: 39641
		// (get) Token: 0x06045164 RID: 282980 RVA: 0x0111221B File Offset: 0x0111041B
		public bool IsEndlessMode
		{
			get
			{
				return this.IsEndlessModeInternal;
			}
		}

		// Token: 0x17009ADA RID: 39642
		// (get) Token: 0x06045165 RID: 282981 RVA: 0x01112223 File Offset: 0x01110423
		public int LeaveDollCount
		{
			get
			{
				return this.LeaveDollCountInternal;
			}
		}

		// Token: 0x17009ADB RID: 39643
		// (get) Token: 0x06045166 RID: 282982 RVA: 0x0111222C File Offset: 0x0111042C
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

		// Token: 0x17009ADC RID: 39644
		// (get) Token: 0x06045167 RID: 282983 RVA: 0x011122AC File Offset: 0x011104AC
		public float PlayCost
		{
			get
			{
				DollGrabMachineComponent config = this.Config;
				return ((config != null) ? config.PlayCost : null).GetValueOrDefault();
			}
		}

		// Token: 0x17009ADD RID: 39645
		// (get) Token: 0x06045168 RID: 282984 RVA: 0x011122DB File Offset: 0x011104DB
		public bool IsMachineActive
		{
			get
			{
				return this.IsActiveInternal;
			}
		}

		// Token: 0x17009ADE RID: 39646
		// (get) Token: 0x06045169 RID: 282985 RVA: 0x011122E3 File Offset: 0x011104E3
		public bool IsMachinePause
		{
			get
			{
				return this.IsPauseInternal;
			}
		}

		// Token: 0x17009ADF RID: 39647
		// (get) Token: 0x0604516A RID: 282986 RVA: 0x011122EB File Offset: 0x011104EB
		public IDollGrabInfiniteRewardData EndlessRewardData
		{
			get
			{
				return this.EndlessRewardDataInternal;
			}
		}

		// Token: 0x17009AE0 RID: 39648
		// (get) Token: 0x0604516B RID: 282987 RVA: 0x011122F3 File Offset: 0x011104F3
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

		// Token: 0x17009AE1 RID: 39649
		// (get) Token: 0x0604516C RID: 282988 RVA: 0x01112308 File Offset: 0x01110508
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

		// Token: 0x17009AE2 RID: 39650
		// (get) Token: 0x0604516D RID: 282989 RVA: 0x0111234C File Offset: 0x0111054C
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

		// Token: 0x0604516E RID: 282990 RVA: 0x011123BC File Offset: 0x011105BC
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

		// Token: 0x0604516F RID: 282991 RVA: 0x01112520 File Offset: 0x01110720
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

		// Token: 0x06045170 RID: 282992 RVA: 0x0111274C File Offset: 0x0111094C
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

		// Token: 0x06045171 RID: 282993 RVA: 0x0111288B File Offset: 0x01110A8B
		protected override void OnActivate()
		{
			if (!this.ActorComp.GetIsSceneInteractionLoadCompleted())
			{
				EventSystem.Instance.OnceWithTarget(base.Entity, EEventName.OnSceneInteractionShowCompleted, new Action(this.OnSceneInteractionLoadCompleted));
				return;
			}
			this.OnSceneInteractionLoadCompleted();
		}

		// Token: 0x06045172 RID: 282994 RVA: 0x011128C4 File Offset: 0x01110AC4
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

		// Token: 0x06045173 RID: 282995 RVA: 0x011129D9 File Offset: 0x01110BD9
		private void OnStateChange(int stateId, bool isReady)
		{
			this.CheckSceneItemState();
		}

		// Token: 0x06045174 RID: 282996 RVA: 0x011129E4 File Offset: 0x01110BE4
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

		// Token: 0x06045175 RID: 282997 RVA: 0x01112A81 File Offset: 0x01110C81
		private bool IsTickEnabled()
		{
			return DollGrabMachineController.Instance.CheckRegisterTick(this);
		}

		// Token: 0x06045176 RID: 282998 RVA: 0x01112A8E File Offset: 0x01110C8E
		private void EnableTick()
		{
			if (!this.IsTickEnabled())
			{
				DollGrabMachineController.Instance.RegisterTick(this);
			}
		}

		// Token: 0x06045177 RID: 282999 RVA: 0x01112AA3 File Offset: 0x01110CA3
		private void DisableTick()
		{
			if (this.IsTickEnabled())
			{
				DollGrabMachineController.Instance.UnregisterTick(this);
			}
		}

		// Token: 0x06045178 RID: 283000 RVA: 0x01112AB8 File Offset: 0x01110CB8
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

		// Token: 0x06045179 RID: 283001 RVA: 0x01112DA4 File Offset: 0x01110FA4
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

		// Token: 0x0604517A RID: 283002 RVA: 0x01112EF8 File Offset: 0x011110F8
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

		// Token: 0x0604517B RID: 283003 RVA: 0x01112FA4 File Offset: 0x011111A4
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

		// Token: 0x0604517C RID: 283004 RVA: 0x011130C8 File Offset: 0x011112C8
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

		// Token: 0x0604517D RID: 283005 RVA: 0x01113211 File Offset: 0x01111411
		public void OnClawSequenceLoaded()
		{
			if (this.NeedInitClawStateController && this.ClawStateController != null)
			{
				this.ClawStateController.Init();
			}
			this.NeedInitClawStateController = false;
		}

		// Token: 0x0604517E RID: 283006 RVA: 0x01113238 File Offset: 0x01111438
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

		// Token: 0x0604517F RID: 283007 RVA: 0x01113340 File Offset: 0x01111540
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

		// Token: 0x06045180 RID: 283008 RVA: 0x01113598 File Offset: 0x01111798
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

		// Token: 0x06045181 RID: 283009 RVA: 0x01113938 File Offset: 0x01111B38
		public void ChangeClawState(EDollGrabMachineClawState newState)
		{
			DgmClawStateController clawStateController = this.ClawStateController;
			if (clawStateController == null)
			{
				return;
			}
			clawStateController.SetTargetState(newState);
		}

		// Token: 0x06045182 RID: 283010 RVA: 0x0111394C File Offset: 0x01111B4C
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

		// Token: 0x06045183 RID: 283011 RVA: 0x011139BD File Offset: 0x01111BBD
		public void StopClawTriggerOverlap()
		{
			if (this.ClawActor != null)
			{
				this.ClawActor.OnActorBeginOverlap.Clear();
				this.ClawActor.OnActorEndOverlap.Clear();
			}
		}

		// Token: 0x06045184 RID: 283012 RVA: 0x011139E8 File Offset: 0x01111BE8
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

		// Token: 0x06045185 RID: 283013 RVA: 0x01113A49 File Offset: 0x01111C49
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

		// Token: 0x06045186 RID: 283014 RVA: 0x01113A88 File Offset: 0x01111C88
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

		// Token: 0x17009AE3 RID: 39651
		// (get) Token: 0x06045187 RID: 283015 RVA: 0x01113B80 File Offset: 0x01111D80
		public bool HasGrabbingActor
		{
			get
			{
				return this.GrabbingActorList.Count > 0;
			}
		}

		// Token: 0x17009AE4 RID: 39652
		// (get) Token: 0x06045188 RID: 283016 RVA: 0x01113B90 File Offset: 0x01111D90
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

		// Token: 0x17009AE5 RID: 39653
		// (get) Token: 0x06045189 RID: 283017 RVA: 0x01113BA3 File Offset: 0x01111DA3
		// (set) Token: 0x0604518A RID: 283018 RVA: 0x01113BAB File Offset: 0x01111DAB
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

		// Token: 0x17009AE6 RID: 39654
		// (get) Token: 0x0604518B RID: 283019 RVA: 0x01113BCF File Offset: 0x01111DCF
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

		// Token: 0x17009AE7 RID: 39655
		// (get) Token: 0x0604518C RID: 283020 RVA: 0x01113BE4 File Offset: 0x01111DE4
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

		// Token: 0x0604518D RID: 283021 RVA: 0x01113C0C File Offset: 0x01111E0C
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

		// Token: 0x0604518E RID: 283022 RVA: 0x01113F34 File Offset: 0x01112134
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

		// Token: 0x0604518F RID: 283023 RVA: 0x01113FB4 File Offset: 0x011121B4
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

		// Token: 0x06045190 RID: 283024 RVA: 0x011140B2 File Offset: 0x011122B2
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

		// Token: 0x06045191 RID: 283025 RVA: 0x011140E4 File Offset: 0x011122E4
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

		// Token: 0x06045192 RID: 283026 RVA: 0x01114154 File Offset: 0x01112354
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

		// Token: 0x06045193 RID: 283027 RVA: 0x0111421C File Offset: 0x0111241C
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

		// Token: 0x06045194 RID: 283028 RVA: 0x011142DC File Offset: 0x011124DC
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

		// Token: 0x06045195 RID: 283029 RVA: 0x0111433C File Offset: 0x0111253C
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

		// Token: 0x06045196 RID: 283030 RVA: 0x011143AC File Offset: 0x011125AC
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

		// Token: 0x06045197 RID: 283031 RVA: 0x011144A8 File Offset: 0x011126A8
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

		// Token: 0x06045198 RID: 283032 RVA: 0x0111459C File Offset: 0x0111279C
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

		// Token: 0x06045199 RID: 283033 RVA: 0x01114614 File Offset: 0x01112814
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

		// Token: 0x0604519A RID: 283034 RVA: 0x011148BC File Offset: 0x01112ABC
		private void StartEndlessAudioState()
		{
			foreach (EndlessAudioStateInfo endlessAudioStateInfo in this.EndlessAudioDataInternal.Values)
			{
				endlessAudioStateInfo.StartAudio();
			}
		}

		// Token: 0x0604519B RID: 283035 RVA: 0x01114914 File Offset: 0x01112B14
		private void StopEndlessAudioState()
		{
			foreach (EndlessAudioStateInfo endlessAudioStateInfo in this.EndlessAudioDataInternal.Values)
			{
				endlessAudioStateInfo.StopAudio();
			}
		}

		// Token: 0x0604519C RID: 283036 RVA: 0x0111496C File Offset: 0x01112B6C
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

		// Token: 0x0604519D RID: 283037 RVA: 0x011149E4 File Offset: 0x01112BE4
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

		// Token: 0x0604519E RID: 283038 RVA: 0x01114A5C File Offset: 0x01112C5C
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

		// Token: 0x0604519F RID: 283039 RVA: 0x01114AF4 File Offset: 0x01112CF4
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

		// Token: 0x060451A0 RID: 283040 RVA: 0x01114CD4 File Offset: 0x01112ED4
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

		// Token: 0x060451A1 RID: 283041 RVA: 0x01114EDC File Offset: 0x011130DC
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

		// Token: 0x060451A2 RID: 283042 RVA: 0x01115058 File Offset: 0x01113258
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

		// Token: 0x060451A3 RID: 283043 RVA: 0x011151D4 File Offset: 0x011133D4
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

		// Token: 0x060451A4 RID: 283044 RVA: 0x01115264 File Offset: 0x01113464
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

		// Token: 0x060451A5 RID: 283045 RVA: 0x01115344 File Offset: 0x01113544
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

		// Token: 0x060451A6 RID: 283046 RVA: 0x011153D0 File Offset: 0x011135D0
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

		// Token: 0x060451A7 RID: 283047 RVA: 0x01115414 File Offset: 0x01113614
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

		// Token: 0x060451A8 RID: 283048 RVA: 0x011154E0 File Offset: 0x011136E0
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

		// Token: 0x060451A9 RID: 283049 RVA: 0x01115540 File Offset: 0x01113740
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemDollGrabMachineComponent sceneItemDollGrabMachineComponent = (SceneItemDollGrabMachineComponent)componentTemplate;
			if (base.CanResetComponentProperty("CreatureDataComp"))
			{
				if (sceneItemDollGrabMachineComponent.CreatureDataComp == null)
				{
					this.CreatureDataComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComp), "CreatureDataComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (sceneItemDollGrabMachineComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("StateComp"))
			{
				if (sceneItemDollGrabMachineComponent.StateComp == null)
				{
					this.StateComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemStateComponent>(this.StateComp), "StateComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TagComp"))
			{
				if (sceneItemDollGrabMachineComponent.TagComp == null)
				{
					this.TagComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("Config"))
			{
				if (sceneItemDollGrabMachineComponent.Config == null)
				{
					this.Config = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<DollGrabMachineComponent>(this.Config), "Config"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ClawActor"))
			{
				if (sceneItemDollGrabMachineComponent.ClawActor == null)
				{
					this.ClawActor = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AActor>(this.ClawActor), "ClawActor"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ClawRootCtrlActor"))
			{
				if (sceneItemDollGrabMachineComponent.ClawRootCtrlActor == null)
				{
					this.ClawRootCtrlActor = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AActor>(this.ClawRootCtrlActor), "ClawRootCtrlActor"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ClawChainActor"))
			{
				if (sceneItemDollGrabMachineComponent.ClawChainActor == null)
				{
					this.ClawChainActor = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AActor>(this.ClawChainActor), "ClawChainActor"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("DropTriggerActor"))
			{
				if (sceneItemDollGrabMachineComponent.DropTriggerActor == null)
				{
					this.DropTriggerActor = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AActor>(this.DropTriggerActor), "DropTriggerActor"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("DollItemPoolActor"))
			{
				if (sceneItemDollGrabMachineComponent.DollItemPoolActor == null)
				{
					this.DollItemPoolActor = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AActor>(this.DollItemPoolActor), "DollItemPoolActor"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TeleportTriggerActorList") && sceneItemDollGrabMachineComponent.TeleportTriggerActorList != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<AActor>>(this.TeleportTriggerActorList), "TeleportTriggerActorList"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TeleportTargetLocationList") && sceneItemDollGrabMachineComponent.TeleportTargetLocationList != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<FVectorDouble>>(this.TeleportTargetLocationList), "TeleportTargetLocationList"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("ConveyorBeltActorList") && sceneItemDollGrabMachineComponent.ConveyorBeltActorList != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<BP_DollGrabMahcineConveyorBelt_C>>(this.ConveyorBeltActorList), "ConveyorBeltActorList"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("ConveyorBeltMeshBpActor"))
			{
				if (sceneItemDollGrabMachineComponent.ConveyorBeltMeshBpActor == null)
				{
					this.ConveyorBeltMeshBpActor = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BP_ConveyorBelt_C>(this.ConveyorBeltMeshBpActor), "ConveyorBeltMeshBpActor"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("DissolveActor"))
			{
				if (sceneItemDollGrabMachineComponent.DissolveActor == null)
				{
					this.DissolveActor = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BP_CenterDissolvePosition_C>(this.DissolveActor), "DissolveActor"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("BoundaryTriggerActorList") && sceneItemDollGrabMachineComponent.BoundaryTriggerActorList != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<AActor>>(this.BoundaryTriggerActorList), "BoundaryTriggerActorList"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("RoofActor"))
			{
				if (sceneItemDollGrabMachineComponent.RoofActor == null)
				{
					this.RoofActor = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AActor>(this.RoofActor), "RoofActor"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("LightActorGroup"))
			{
				if (sceneItemDollGrabMachineComponent.LightActorGroup == null)
				{
					this.LightActorGroup = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<AActor>>(this.LightActorGroup), "LightActorGroup"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ClawStateController"))
			{
				if (sceneItemDollGrabMachineComponent.ClawStateController == null)
				{
					this.ClawStateController = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<DgmClawStateController>(this.ClawStateController), "ClawStateController"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ClawMoveDirectionInternal") && sceneItemDollGrabMachineComponent.ClawMoveDirectionInternal != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<DollGrabMachineClawDirection>(this.ClawMoveDirectionInternal), "ClawMoveDirectionInternal"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("NeedInitClawStateController"))
			{
				this.NeedInitClawStateController = sceneItemDollGrabMachineComponent.NeedInitClawStateController;
			}
			if (base.CanResetComponentProperty("DollItemMap"))
			{
				if (sceneItemDollGrabMachineComponent.DollItemMap == null)
				{
					this.DollItemMap = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, DollGrabMachineItem>>(this.DollItemMap), "DollItemMap"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("GrabbedItemList"))
			{
				if (sceneItemDollGrabMachineComponent.GrabbedItemList == null)
				{
					this.GrabbedItemList = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<int>>(this.GrabbedItemList), "GrabbedItemList"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("GrabbingActorList"))
			{
				if (sceneItemDollGrabMachineComponent.GrabbingActorList == null)
				{
					this.GrabbingActorList = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<AActor>>(this.GrabbingActorList), "GrabbingActorList"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("LeaveDollCountInternal"))
			{
				this.LeaveDollCountInternal = sceneItemDollGrabMachineComponent.LeaveDollCountInternal;
			}
			if (base.CanResetComponentProperty("CurrentDropItemListInternal") && sceneItemDollGrabMachineComponent.CurrentDropItemListInternal != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, int>>(this.CurrentDropItemListInternal), "CurrentDropItemListInternal"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("IsActiveInternal"))
			{
				this.IsActiveInternal = sceneItemDollGrabMachineComponent.IsActiveInternal;
			}
			if (base.CanResetComponentProperty("IsPauseInternal"))
			{
				this.IsPauseInternal = sceneItemDollGrabMachineComponent.IsPauseInternal;
			}
			if (base.CanResetComponentProperty("IsCacheCheckTouchAction"))
			{
				this.IsCacheCheckTouchAction = sceneItemDollGrabMachineComponent.IsCacheCheckTouchAction;
			}
			if (base.CanResetComponentProperty("AkEvent"))
			{
				this.AkEvent = sceneItemDollGrabMachineComponent.AkEvent;
			}
			if (base.CanResetComponentProperty("AkEventHandle"))
			{
				this.AkEventHandle = sceneItemDollGrabMachineComponent.AkEventHandle;
			}
			if (base.CanResetComponentProperty("GrabEffectTransform"))
			{
				this.GrabEffectTransform = sceneItemDollGrabMachineComponent.GrabEffectTransform;
			}
			if (base.CanResetComponentProperty("ItemRotationDamping"))
			{
				this.ItemRotationDamping = sceneItemDollGrabMachineComponent.ItemRotationDamping;
			}
			if (base.CanResetComponentProperty("ItemMoveDamping"))
			{
				this.ItemMoveDamping = sceneItemDollGrabMachineComponent.ItemMoveDamping;
			}
			if (base.CanResetComponentProperty("LightGroupSequenceActor"))
			{
				if (sceneItemDollGrabMachineComponent.LightGroupSequenceActor == null)
				{
					this.LightGroupSequenceActor = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AKuroLevelSequenceActor>(this.LightGroupSequenceActor), "LightGroupSequenceActor"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("MainDollActorItem"))
			{
				if (sceneItemDollGrabMachineComponent.MainDollActorItem == null)
				{
					this.MainDollActorItem = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<DollGrabMachineItem>(this.MainDollActorItem), "MainDollActorItem"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("DissolveStartTimer"))
			{
				if (sceneItemDollGrabMachineComponent.DissolveStartTimer == null)
				{
					this.DissolveStartTimer = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.DissolveStartTimer), "DissolveStartTimer"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("DissolveCloseTimer"))
			{
				if (sceneItemDollGrabMachineComponent.DissolveCloseTimer == null)
				{
					this.DissolveCloseTimer = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.DissolveCloseTimer), "DissolveCloseTimer"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("DissolvePerSecond"))
			{
				this.DissolvePerSecond = sceneItemDollGrabMachineComponent.DissolvePerSecond;
			}
			if (base.CanResetComponentProperty("DissolveProgress"))
			{
				this.DissolveProgress = sceneItemDollGrabMachineComponent.DissolveProgress;
			}
			if (base.CanResetComponentProperty("DissolveRadius"))
			{
				this.DissolveRadius = sceneItemDollGrabMachineComponent.DissolveRadius;
			}
			if (base.CanResetComponentProperty("IsEndlessModeInternal"))
			{
				this.IsEndlessModeInternal = sceneItemDollGrabMachineComponent.IsEndlessModeInternal;
			}
			if (base.CanResetComponentProperty("EndlessSpawnPoints") && sceneItemDollGrabMachineComponent.EndlessSpawnPoints != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<AActor, FVectorDouble>>(this.EndlessSpawnPoints), "EndlessSpawnPoints"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("EndlessAvailableSpawnPoints") && sceneItemDollGrabMachineComponent.EndlessAvailableSpawnPoints != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<AActor>>(this.EndlessAvailableSpawnPoints), "EndlessAvailableSpawnPoints"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("EndlessAvailableSpawnPointsMap") && sceneItemDollGrabMachineComponent.EndlessAvailableSpawnPointsMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<AActor, HashSet<AActor>>>(this.EndlessAvailableSpawnPointsMap), "EndlessAvailableSpawnPointsMap"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("EndlessIdleItemPool") && sceneItemDollGrabMachineComponent.EndlessIdleItemPool != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, DollGrabMachineItem>>(this.EndlessIdleItemPool), "EndlessIdleItemPool"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("EndlessIdleItemIdList") && sceneItemDollGrabMachineComponent.EndlessIdleItemIdList != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<int>>(this.EndlessIdleItemIdList), "EndlessIdleItemIdList"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("IsDropRefreshTime"))
			{
				this.IsDropRefreshTime = sceneItemDollGrabMachineComponent.IsDropRefreshTime;
			}
			if (base.CanResetComponentProperty("PendingDropItemInfoList"))
			{
				if (sceneItemDollGrabMachineComponent.PendingDropItemInfoList == null)
				{
					this.PendingDropItemInfoList = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<DollGrabMachineItem>>(this.PendingDropItemInfoList), "PendingDropItemInfoList"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("RefreshIntervalCurve"))
			{
				if (sceneItemDollGrabMachineComponent.RefreshIntervalCurve == null)
				{
					this.RefreshIntervalCurve = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UCurveFloat>(this.RefreshIntervalCurve), "RefreshIntervalCurve"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("EndlessElapsedTime"))
			{
				this.EndlessElapsedTime = sceneItemDollGrabMachineComponent.EndlessElapsedTime;
			}
			if (base.CanResetComponentProperty("EndlessDropTimer"))
			{
				if (sceneItemDollGrabMachineComponent.EndlessDropTimer == null)
				{
					this.EndlessDropTimer = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.EndlessDropTimer), "EndlessDropTimer"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("EndlessRewardDataInternal"))
			{
				if (sceneItemDollGrabMachineComponent.EndlessRewardDataInternal == null)
				{
					this.EndlessRewardDataInternal = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<IDollGrabInfiniteRewardData>(this.EndlessRewardDataInternal), "EndlessRewardDataInternal"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("EndlessAudioDataInternal") && sceneItemDollGrabMachineComponent.EndlessAudioDataInternal != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<float, EndlessAudioStateInfo>>(this.EndlessAudioDataInternal), "EndlessAudioDataInternal"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("ConveyorBeltEventHandle"))
			{
				this.ConveyorBeltEventHandle = sceneItemDollGrabMachineComponent.ConveyorBeltEventHandle;
			}
			if (base.CanResetComponentProperty("RoofDissolveEventHandle"))
			{
				this.RoofDissolveEventHandle = sceneItemDollGrabMachineComponent.RoofDissolveEventHandle;
			}
			return true;
		}

		// Token: 0x04023F8B RID: 147339
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x04023F8C RID: 147340
		private SceneItemActorComponent ActorComp;

		// Token: 0x04023F8D RID: 147341
		private SceneItemStateComponent StateComp;

		// Token: 0x04023F8E RID: 147342
		private BaseTagComponent TagComp;

		// Token: 0x04023F8F RID: 147343
		private DollGrabMachineComponent Config;

		// Token: 0x04023F90 RID: 147344
		private AActor ClawActor;

		// Token: 0x04023F91 RID: 147345
		private AActor ClawRootCtrlActor;

		// Token: 0x04023F92 RID: 147346
		private AActor ClawChainActor;

		// Token: 0x04023F93 RID: 147347
		private AActor DropTriggerActor;

		// Token: 0x04023F94 RID: 147348
		private AActor DollItemPoolActor;

		// Token: 0x04023F95 RID: 147349
		[Nullable(1)]
		private readonly List<AActor> TeleportTriggerActorList = new List<AActor>();

		// Token: 0x04023F96 RID: 147350
		[Nullable(1)]
		private readonly List<FVectorDouble> TeleportTargetLocationList = new List<FVectorDouble>();

		// Token: 0x04023F97 RID: 147351
		[Nullable(1)]
		private readonly List<BP_DollGrabMahcineConveyorBelt_C> ConveyorBeltActorList = new List<BP_DollGrabMahcineConveyorBelt_C>();

		// Token: 0x04023F98 RID: 147352
		private BP_ConveyorBelt_C ConveyorBeltMeshBpActor;

		// Token: 0x04023F99 RID: 147353
		private BP_CenterDissolvePosition_C DissolveActor;

		// Token: 0x04023F9A RID: 147354
		[Nullable(1)]
		private readonly List<AActor> BoundaryTriggerActorList = new List<AActor>();

		// Token: 0x04023F9B RID: 147355
		private AActor RoofActor;

		// Token: 0x04023F9C RID: 147356
		[Nullable(1)]
		private List<AActor> LightActorGroup = new List<AActor>();

		// Token: 0x04023F9D RID: 147357
		private DgmClawStateController ClawStateController;

		// Token: 0x04023F9E RID: 147358
		[Nullable(1)]
		private readonly DollGrabMachineClawDirection ClawMoveDirectionInternal = new DollGrabMachineClawDirection(0f, 0f);

		// Token: 0x04023F9F RID: 147359
		private bool NeedInitClawStateController;

		// Token: 0x04023FA0 RID: 147360
		[Nullable(1)]
		private Dictionary<int, DollGrabMachineItem> DollItemMap = new Dictionary<int, DollGrabMachineItem>();

		// Token: 0x04023FA1 RID: 147361
		[Nullable(1)]
		private List<int> GrabbedItemList = new List<int>();

		// Token: 0x04023FA2 RID: 147362
		[Nullable(1)]
		private List<AActor> GrabbingActorList = new List<AActor>();

		// Token: 0x04023FA3 RID: 147363
		private int LeaveDollCountInternal;

		// Token: 0x04023FA4 RID: 147364
		[Nullable(1)]
		private readonly Dictionary<int, int> CurrentDropItemListInternal = new Dictionary<int, int>();

		// Token: 0x04023FA5 RID: 147365
		private bool IsActiveInternal;

		// Token: 0x04023FA6 RID: 147366
		private bool IsPauseInternal;

		// Token: 0x04023FA7 RID: 147367
		private bool IsCacheCheckTouchAction;

		// Token: 0x04023FA8 RID: 147368
		private string AkEvent;

		// Token: 0x04023FA9 RID: 147369
		private int AkEventHandle = -1;

		// Token: 0x04023FAA RID: 147370
		private FTransformDouble? GrabEffectTransform;

		// Token: 0x04023FAB RID: 147371
		private float ItemRotationDamping;

		// Token: 0x04023FAC RID: 147372
		private float ItemMoveDamping;

		// Token: 0x04023FAD RID: 147373
		private AKuroLevelSequenceActor LightGroupSequenceActor;

		// Token: 0x04023FAE RID: 147374
		private DollGrabMachineItem MainDollActorItem;

		// Token: 0x04023FAF RID: 147375
		private TimerHandle DissolveStartTimer;

		// Token: 0x04023FB0 RID: 147376
		private TimerHandle DissolveCloseTimer;

		// Token: 0x04023FB1 RID: 147377
		private float DissolvePerSecond;

		// Token: 0x04023FB2 RID: 147378
		private float DissolveProgress;

		// Token: 0x04023FB3 RID: 147379
		private float DissolveRadius;

		// Token: 0x04023FB4 RID: 147380
		private bool IsEndlessModeInternal;

		// Token: 0x04023FB5 RID: 147381
		[Nullable(1)]
		private readonly Dictionary<AActor, FVectorDouble> EndlessSpawnPoints = new Dictionary<AActor, FVectorDouble>();

		// Token: 0x04023FB6 RID: 147382
		[Nullable(1)]
		private readonly List<AActor> EndlessAvailableSpawnPoints = new List<AActor>();

		// Token: 0x04023FB7 RID: 147383
		[Nullable(1)]
		private readonly Dictionary<AActor, HashSet<AActor>> EndlessAvailableSpawnPointsMap = new Dictionary<AActor, HashSet<AActor>>();

		// Token: 0x04023FB8 RID: 147384
		[Nullable(1)]
		private readonly Dictionary<int, DollGrabMachineItem> EndlessIdleItemPool = new Dictionary<int, DollGrabMachineItem>();

		// Token: 0x04023FB9 RID: 147385
		[Nullable(1)]
		private readonly List<int> EndlessIdleItemIdList = new List<int>();

		// Token: 0x04023FBA RID: 147386
		private bool IsDropRefreshTime;

		// Token: 0x04023FBB RID: 147387
		[Nullable(1)]
		private List<DollGrabMachineItem> PendingDropItemInfoList = new List<DollGrabMachineItem>();

		// Token: 0x04023FBC RID: 147388
		private UCurveFloat RefreshIntervalCurve;

		// Token: 0x04023FBD RID: 147389
		private float EndlessElapsedTime;

		// Token: 0x04023FBE RID: 147390
		private TimerHandle EndlessDropTimer;

		// Token: 0x04023FBF RID: 147391
		private IDollGrabInfiniteRewardData EndlessRewardDataInternal;

		// Token: 0x04023FC0 RID: 147392
		[Nullable(1)]
		private readonly Dictionary<float, EndlessAudioStateInfo> EndlessAudioDataInternal = new Dictionary<float, EndlessAudioStateInfo>();

		// Token: 0x04023FC1 RID: 147393
		private int ConveyorBeltEventHandle = -1;

		// Token: 0x04023FC2 RID: 147394
		private int RoofDissolveEventHandle = -1;
	}
}

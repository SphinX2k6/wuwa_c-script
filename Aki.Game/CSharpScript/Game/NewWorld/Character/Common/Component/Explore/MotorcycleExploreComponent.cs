using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Data.Fight.Enum;
using AkiClient.Game.Aki.Data.Fight.FollowShooter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Explore
{
	// Token: 0x02006353 RID: 25427
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleExploreComponent : BaseExploreComponent, IStaticVariableResetter
	{
		// Token: 0x0603D9D7 RID: 252375 RVA: 0x011D89F6 File Offset: 0x011D6BF6
		static MotorcycleExploreComponent()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleExploreComponent.CreateStaticDefaultValue), new Action(MotorcycleExploreComponent.ResetStaticDefaultValue));
		}

		// Token: 0x0603D9D8 RID: 252376 RVA: 0x011D8A15 File Offset: 0x011D6C15
		public static void CreateStaticDefaultValue()
		{
			MotorcycleExploreComponent.TraceDebug = false;
			MotorcycleExploreComponent._defaultStateTagId = GameplayTagDefine.EGameplayTagId["关卡.Common.状态.常态"];
		}

		// Token: 0x0603D9D9 RID: 252377 RVA: 0x011D8A31 File Offset: 0x011D6C31
		public static void ResetStaticDefaultValue()
		{
			MotorcycleExploreComponent.TraceDebug = false;
			MotorcycleExploreComponent._defaultStateTagId = 0;
		}

		// Token: 0x170074FB RID: 29947
		// (get) Token: 0x0603D9DA RID: 252378 RVA: 0x011D8A40 File Offset: 0x011D6C40
		// (set) Token: 0x0603D9DB RID: 252379 RVA: 0x011D8B34 File Offset: 0x011D6D34
		[Nullable(2)]
		public GrapplingHookPointComponent PullingTarget
		{
			[NullableContext(2)]
			get
			{
				BaseActorComponent actorComponent = this.ActorComponent;
				if (actorComponent == null || !actorComponent.IsAutonomousProxy)
				{
					if (this.SimulatePullingTarget != null && !this.SimulatePullingTarget.Valid)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Vehicle;
						ELogAuthor author = ELogAuthor.CK;
						string message = this.LogKey + "获取SimulatePullingTarget时钩锁点实体已失效, 重置为undefined";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", base.Entity.Id);
						instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						this.SimulatePullingTarget = null;
					}
					return this.SimulatePullingTarget;
				}
				if (this.PullingTargetInternal != null && !this.PullingTargetInternal.Valid)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Vehicle;
					ELogAuthor author2 = ELogAuthor.CK;
					string message2 = this.LogKey + "获取PullingTarget时钩锁点实体已失效, 重置为undefined";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("EntityId", base.Entity.Id);
					instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					this.PullingTargetInternal = null;
				}
				return this.PullingTargetInternal;
			}
			[NullableContext(2)]
			set
			{
				GrapplingHookPointComponent pullingTargetInternal = this.PullingTargetInternal;
				if (pullingTargetInternal != null && pullingTargetInternal.Valid && value != this.PullingTargetInternal)
				{
					this.PullingTargetInternal.ChangeHookPointState(EHookPointState.Normal);
				}
				this.PullingTargetInternal = value;
				this.PullingTargetEntityId = ((value != null) ? new int?(value.Entity.Id) : null);
			}
		}

		// Token: 0x170074FC RID: 29948
		// (get) Token: 0x0603D9DC RID: 252380 RVA: 0x011D8B98 File Offset: 0x011D6D98
		public override Type[] Dependencies
		{
			get
			{
				Type[] array = EntityComponentConstant.GetComponentDependencies(typeof(BaseExploreComponent)) ?? Array.Empty<Type>();
				int num = 0;
				Type[] array2 = new Type[1 + array.Length];
				ReadOnlySpan<Type> readOnlySpan = new ReadOnlySpan<Type>(array);
				readOnlySpan.CopyTo(new Span<Type>(array2).Slice(num, readOnlySpan.Length));
				num += readOnlySpan.Length;
				array2[num] = typeof(BaseVehiclePerformComponent);
				return array2;
			}
		}

		// Token: 0x0603D9DD RID: 252381 RVA: 0x011D8C0C File Offset: 0x011D6E0C
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			base.OnInitData(args);
			this.AutoDetectDistance = (float)ConfigCommonParamById.GetIntConfig("MotorcycleAutoDetectDistance").GetValueOrDefault();
			this.AutoDetectInterval = ConfigCommonParamById.GetFloatConfig("MotorcycleAutoDetectInterval").GetValueOrDefault(0.5f);
			IReadOnlyList<string> stringArrayConfig = ConfigCommonParamById.GetStringArrayConfig("DisableFollowShooterAutoDetectedAwakeTags");
			if (stringArrayConfig != null && stringArrayConfig.Count > 0)
			{
				foreach (string tagName in stringArrayConfig)
				{
					this.DisableAutoDetectTags.Add(GameplayTagUtils.GetTagIdByName(tagName));
				}
			}
			CreatureDataComponent creatureDataComponent = base.Entity.CheckGetComponent<CreatureDataComponent>();
			this.PlayerId = ((creatureDataComponent != null) ? creatureDataComponent.GetPlayerId() : 0);
			this.BatchCollectRangeEffectPath = ConfigCommonParamById.GetStringConfig("MotorcycleBatchPullRangeEffectPath");
			return true;
		}

		// Token: 0x0603D9DE RID: 252382 RVA: 0x011D8CE4 File Offset: 0x011D6EE4
		protected override bool OnStart()
		{
			base.OnStart();
			this.LogKey = "(摩托车)探索组件";
			this.TargetSelector.InitForMotorcycle(this);
			RouletteListDataBase rouletteListDataBase;
			this.RouletteListDataMotor = (RouletteModel.Instance.RouletteListDataMap.TryGetValue(ERouletteType.Motor, out rouletteListDataBase) ? (rouletteListDataBase as RouletteListDataMotor) : null);
			EventSystem.Instance.AddWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenEntered, new Action<VehiclePassengerInfo, bool>(this.OnVehicleBeenEntered));
			EventSystem.Instance.AddWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenLeaved, new Action<VehiclePassengerInfo, bool>(this.OnVehicleBeenLeaved));
			this.VehiclePerformComponent = base.Entity.GetComponent<BaseVehiclePerformComponent>();
			BaseVehiclePerformComponent vehiclePerformComponent = this.VehiclePerformComponent;
			if (((vehiclePerformComponent != null) ? vehiclePerformComponent.Driver : null) != null)
			{
				WorldEntity driver = this.VehiclePerformComponent.Driver;
				EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
				if (driver == ((getCurrentEntity != null) ? getCurrentEntity.Entity : null))
				{
					this.OnExploreComponentEnable("(摩托车)探索组件OnStart时驾驶位为主控角色");
				}
			}
			EventSystem.Instance.AddWithTarget<int, bool>(base.Entity, EEventName.CharBeforeSkillWithTarget, new Action<int, bool>(this.OnBeforeSkill));
			return true;
		}

		// Token: 0x0603D9DF RID: 252383 RVA: 0x011D8DEC File Offset: 0x011D6FEC
		protected override bool OnEnd()
		{
			base.OnEnd();
			this.CancelInteraction();
			EventSystem.Instance.RemoveWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenEntered, new Action<VehiclePassengerInfo, bool>(this.OnVehicleBeenEntered));
			EventSystem.Instance.RemoveWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenLeaved, new Action<VehiclePassengerInfo, bool>(this.OnVehicleBeenLeaved));
			this.OnExploreComponentDisable("OnEnd");
			foreach (int skillId in this.CurrentActiveSkillId)
			{
				BaseSkillComponent skillComponent = this.SkillComponent;
				if (skillComponent != null)
				{
					skillComponent.EndSkill(skillId, "(摩托车)探索组件OnEnd");
				}
			}
			EventSystem.Instance.RemoveWithTarget<int, bool>(base.Entity, EEventName.CharBeforeSkillWithTarget, new Action<int, bool>(this.OnBeforeSkill));
			return true;
		}

		// Token: 0x0603D9E0 RID: 252384 RVA: 0x011D8ECC File Offset: 0x011D70CC
		protected override bool OnExploreComponentEnable(string reason)
		{
			if (!base.OnExploreComponentEnable(reason))
			{
				return false;
			}
			EventSystem.Instance.Add<int>(EEventName.ChangeVisionSkillByTab, new Action<int>(this.OnChangeExploreVisionSkillByTab));
			EventSystem.Instance.AddWithTarget<int, int>(base.Entity, EEventName.OnSkillEnd, new Action<int, int>(this.OnSkillEnd));
			EventSystem.Instance.AddWithTarget<int, int, bool>(base.Entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnCharUseSkill));
			EventSystem.Instance.AddWithTarget<int, int>(base.Entity, EEventName.CharBeforeInterruptWithTarget, new Action<int, int>(this.OnBeforeInterruptWithTarget));
			EventSystem.Instance.Add<int, int>(EEventName.CharInterruptSkill, new Action<int, int>(this.OnFixHookSkillInterrupt));
			RouletteListDataMotor rouletteListDataMotor = this.RouletteListDataMotor;
			if (rouletteListDataMotor != null)
			{
				rouletteListDataMotor.ChangeRouletteActivateStatus(true);
			}
			return true;
		}

		// Token: 0x0603D9E1 RID: 252385 RVA: 0x011D8F8C File Offset: 0x011D718C
		protected override bool OnExploreComponentDisable(string reason)
		{
			if (!base.OnExploreComponentDisable(reason))
			{
				return false;
			}
			this.CancelInteraction();
			EventSystem.Instance.Remove<int>(EEventName.ChangeVisionSkillByTab, new Action<int>(this.OnChangeExploreVisionSkillByTab));
			EventSystem.Instance.RemoveWithTarget<int, int>(base.Entity, EEventName.OnSkillEnd, new Action<int, int>(this.OnSkillEnd));
			EventSystem.Instance.RemoveWithTarget<int, int, bool>(base.Entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnCharUseSkill));
			EventSystem.Instance.RemoveWithTarget<int, int>(base.Entity, EEventName.CharBeforeInterruptWithTarget, new Action<int, int>(this.OnBeforeInterruptWithTarget));
			EventSystem.Instance.Remove<int, int>(EEventName.CharInterruptSkill, new Action<int, int>(this.OnFixHookSkillInterrupt));
			this.EjectInterruptingSkillId = null;
			RouletteListDataMotor rouletteListDataMotor = this.RouletteListDataMotor;
			if (rouletteListDataMotor != null)
			{
				rouletteListDataMotor.ChangeRouletteActivateStatus(false);
			}
			this.PlatformRotationDriver.End();
			return true;
		}

		// Token: 0x0603D9E2 RID: 252386 RVA: 0x011D9068 File Offset: 0x011D7268
		protected override void OnExploreComponentTick(float delta)
		{
			this.TryDetectFollowShooterAutoEnable();
			this.TryDetectHookPoint();
			if (this.IsLockingTarget)
			{
				GrapplingHookPointComponent focusTarget = base.FocusTarget;
				if (focusTarget == null || !focusTarget.Valid)
				{
					base.CancelLockTarget("FocusTarget is Invalid", true);
				}
			}
			this.PlatformRotationDriver.Tick(delta);
		}

		// Token: 0x0603D9E3 RID: 252387 RVA: 0x011D90B8 File Offset: 0x011D72B8
		public override bool CheckAllowLevelEventHighlightSkill()
		{
			return !this.IsLockingTarget;
		}

		// Token: 0x0603D9E4 RID: 252388 RVA: 0x011D90C4 File Offset: 0x011D72C4
		public override void OnLevelEventHighlightSkillUpdate(bool enabled)
		{
			this.LevelEventHighlightingSkill = enabled;
			int? currentIconTagId = this.CurrentIconTagId;
			int? currentIconHighlightTagId = this.CurrentIconHighlightTagId;
			if (enabled)
			{
				if (currentIconTagId != null && currentIconTagId.GetValueOrDefault() != 0 && this.TagComponent.HasTag(currentIconTagId.Value))
				{
					this.TagComponent.RemoveTag(new int?(currentIconTagId.Value));
				}
				if (currentIconHighlightTagId != null && currentIconHighlightTagId.GetValueOrDefault() != 0 && this.TagComponent.HasTag(currentIconHighlightTagId.Value))
				{
					this.TagComponent.RemoveTag(new int?(currentIconHighlightTagId.Value));
					return;
				}
			}
			else
			{
				if (currentIconTagId != null && currentIconTagId.GetValueOrDefault() != 0 && !this.TagComponent.HasTag(currentIconTagId.Value))
				{
					this.TagComponent.AddTag(new int?(currentIconTagId.Value));
				}
				if (currentIconHighlightTagId != null && currentIconHighlightTagId.GetValueOrDefault() != 0 && !this.TagComponent.HasTag(currentIconHighlightTagId.Value))
				{
					this.TagComponent.AddTag(new int?(currentIconHighlightTagId.Value));
				}
			}
		}

		// Token: 0x0603D9E5 RID: 252389 RVA: 0x011D91EC File Offset: 0x011D73EC
		public int GetSkillIdByCurrentTarget()
		{
			HighlightExploreSkillLogic highlightLogic = this.HighlightLogic;
			int num = (highlightLogic != null) ? highlightLogic.GetHighlightSkillId() : 0;
			if (num != 0)
			{
				return num;
			}
			if (!base.FocusTargetLegal || base.FocusTarget == null)
			{
				return 0;
			}
			if (!this.IsLockingTarget && (CharacterExploreModel.Instance.MotorcycleHookDetectRestriction.IsDisabled() || this.IsFocusTypeDisabled()))
			{
				return 0;
			}
			IHookInteractType hookInteractConfig = base.FocusTarget.GetHookInteractConfig();
			EHookInteractType? ehookInteractType = (hookInteractConfig != null) ? new EHookInteractType?(hookInteractConfig.Type) : null;
			if (ehookInteractType != null)
			{
				EHookInteractType valueOrDefault = ehookInteractType.GetValueOrDefault();
				if (valueOrDefault == EHookInteractType.KiteHook)
				{
					return 10001035;
				}
				switch (valueOrDefault)
				{
				case EHookInteractType.PilotThrow:
					return 10001029;
				case EHookInteractType.CableWay:
					return 10001028;
				case EHookInteractType.MotorPullInteract:
					return 10001006;
				case EHookInteractType.MotorEject:
					return 10002001;
				}
			}
			return 10001027;
		}

		// Token: 0x0603D9E6 RID: 252390 RVA: 0x011D92D8 File Offset: 0x011D74D8
		public bool TryPullCollection()
		{
			GrapplingHookPointComponent pullingTarget = this.PullingTarget;
			return pullingTarget != null && pullingTarget.Valid && this.PullCollection(pullingTarget);
		}

		// Token: 0x0603D9E7 RID: 252391 RVA: 0x011D9308 File Offset: 0x011D7508
		private unsafe bool PullCollection(GrapplingHookPointComponent mainHook)
		{
			WorldEntity playerEntity = SceneTeamModel.Instance.GetCurrentEntity.Entity;
			List<long> list = null;
			if (mainHook.AllowBatchCollect)
			{
				list = new List<long>();
				float valueOrDefault = ConfigCommonParamById.GetFloatConfig("MotorcycleBatchPullCollectionRadius").GetValueOrDefault(5000f);
				if (valueOrDefault > 5000f)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Vehicle;
					ELogAuthor author = ELogAuthor.CK;
					string message = "(摩托车)探索组件批量拉取采集物范围超过最大限制, 检查配置";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Radius", valueOrDefault);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				int valueOrDefault2 = ConfigCommonParamById.GetIntConfig("MotorcycleBatchPullCollectionCount").GetValueOrDefault(15);
				if (valueOrDefault2 > 15)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Vehicle;
					ELogAuthor author2 = ELogAuthor.CK;
					string message2 = "(摩托车)探索组件批量拉取采集物数量超过最大限制, 检查配置";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("MaxCount", valueOrDefault2);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
				CreatureModel.Instance.GetEntitiesInRangeWithLocation(mainHook.HookLocation, valueOrDefault, EEntityTypeQuery.SceneItem, this.TmpHandles, true);
				foreach (EntityHandle entityHandle in this.TmpHandles)
				{
					GrapplingHookPointComponent component = entityHandle.Entity.GetComponent<GrapplingHookPointComponent>();
					if (component != null && component.HookInteractType.GetValueOrDefault() == EHookInteractType.MotorPullInteract && entityHandle.Id != mainHook.Entity.Id && !component.PullCollectionWithProgress)
					{
						if (list.Count >= valueOrDefault2)
						{
							Log.Instance.Error(ELogModule.Vehicle, ELogAuthor.CK, "(摩托车)探索组件拉取采集物失败, 数量超过限制", default(ReadOnlySpan<ValueTuple<string, object>>));
							break;
						}
						list.Add(component.ServerEntityId);
						if (!component.DisableCollectEffect)
						{
							BulletController.Instance.CreateBulletCustomTarget(playerEntity, "200300046", component.HookTransform, null, null, global::EBulletCreateSource.Others);
						}
					}
				}
			}
			int instanceId = CreatureModel.Instance.GetInstanceId();
			if (mainHook.PullCollectionWithProgress)
			{
				Action onCollectFailed = delegate()
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.Vehicle;
					ELogAuthor author3 = ELogAuthor.CK;
					string message3 = "(摩托车)探索组件拉取采集物失败, 回退采集客户端预表现的隐藏实体操作";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityConfigId", mainHook.EntityConfigId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ServerEntityId", mainHook.ServerEntityId);
					instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					mainHook.StopPullMove();
					LevelGeneralCommons.RollbackDestroyState(mainHook.EntityConfigId, MotorcycleExploreComponent._defaultStateTagId);
				};
				if (list != null)
				{
					this.RequestBatchCollect(instanceId, 0L, list, null);
				}
				return mainHook.StartPullMove(delegate
				{
					this.RequestBatchCollect(instanceId, mainHook.ServerEntityId, null, onCollectFailed);
					if (!mainHook.DisableCollectEffect)
					{
						BulletController.Instance.CreateBulletCustomTarget(playerEntity, "200300046", mainHook.HookTransform, null, null, global::EBulletCreateSource.Others);
					}
				});
			}
			this.RequestBatchCollect(instanceId, mainHook.ServerEntityId, list, null);
			return true;
		}

		// Token: 0x0603D9E8 RID: 252392 RVA: 0x011D95B4 File Offset: 0x011D77B4
		[NullableContext(2)]
		private void RequestBatchCollect(int instanceId, long mainTargetEntityId, List<long> batchTargetEntityIds = null, Action onCollectFailed = null)
		{
			HookLockBatchCollectRequest hookLockBatchCollectRequest = HookLockBatchCollectRequest.Create();
			hookLockBatchCollectRequest.InstId = instanceId;
			hookLockBatchCollectRequest.EntityId = mainTargetEntityId;
			if (batchTargetEntityIds != null)
			{
				hookLockBatchCollectRequest.BatchIds.AddRange(batchTargetEntityIds);
			}
			GrapplingHookPointComponent currentPullingTarget = this.PullingTarget;
			Net.Instance.Call(ERequestMessageId.HookLockBatchCollectRequest, hookLockBatchCollectRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				HookLockBatchCollectResponse hookLockBatchCollectResponse = (HookLockBatchCollectResponse)msg;
				if (hookLockBatchCollectResponse == null)
				{
					return;
				}
				if (hookLockBatchCollectResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Vehicle;
					ELogAuthor author = ELogAuthor.CK;
					string message = "RequestBatchCollect失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ErrorCode", hookLockBatchCollectResponse.ErrorCode);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					if (currentPullingTarget == this.PullingTarget)
					{
						this.PullingTarget = null;
					}
					Action onCollectFailed2 = onCollectFailed;
					if (onCollectFailed2 == null)
					{
						return;
					}
					onCollectFailed2();
				}
			}, 0);
		}

		// Token: 0x0603D9E9 RID: 252393 RVA: 0x011D9624 File Offset: 0x011D7824
		private void CancelInteraction()
		{
			GrapplingHookPointComponent pullingTarget = this.PullingTarget;
			if (pullingTarget == null || !pullingTarget.Valid)
			{
				this.PullingTarget = null;
				return;
			}
			GrapplingHookPointComponent pullingTarget2 = this.PullingTarget;
			if (pullingTarget2 != null && pullingTarget2.GetHookInteractType().GetValueOrDefault() == EHookInteractType.MotorPullInteract)
			{
				this.PullingTarget.StopPullMove();
			}
			GrapplingHookPointComponent pullingTarget3 = this.PullingTarget;
			if (pullingTarget3 != null)
			{
				pullingTarget3.ChangeHookPointState(EHookPointState.Normal);
			}
			base.SendHookEndRequest(this.PullingTarget, null);
			this.PullingTarget = null;
		}

		// Token: 0x0603D9EA RID: 252394 RVA: 0x011D96A4 File Offset: 0x011D78A4
		private void TryDetectHookPoint()
		{
			if (this.IsLockingTarget)
			{
				return;
			}
			if (CharacterExploreModel.Instance.MotorcycleHookDetectRestriction.IsDisabled())
			{
				if (base.FocusTarget != null)
				{
					this.ClearDetectedTarget("HookDetectDisabled");
				}
				return;
			}
			if (this.LevelEventHighlightingSkill)
			{
				base.SetFocusTarget(null, true);
				return;
			}
			this.TargetSelector.TraceDebugEnabled = MotorcycleExploreComponent.TraceDebug;
			this.TargetSelector.DetectBestTargetForMotorcycle(CharacterExploreModel.Instance.MotorcycleHookDetectRestriction.GetEnabledTypes());
			bool flag = this.TargetSelector.DetectedTargetLegal && this.DetectedTargetLegalOnceFlag;
			GrapplingHookPointComponent detectedTarget = this.TargetSelector.DetectedTarget;
			if (base.FocusTarget != detectedTarget)
			{
				this.DetectedTargetLegalOnceFlag = true;
			}
			if (base.FocusTarget != detectedTarget || base.FocusTargetLegal != flag)
			{
				base.SetFocusTarget(detectedTarget, flag);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Vehicle;
				ELogAuthor author = ELogAuthor.CK;
				string message = "(摩托车)探索组件锁定钩锁点";
				string item = "PbDataId";
				int? num;
				if (detectedTarget == null)
				{
					num = null;
				}
				else
				{
					CreatureDataComponent component = detectedTarget.Entity.GetComponent<CreatureDataComponent>();
					num = ((component != null) ? new int?(component.GetPbDataId()) : null);
				}
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, num);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x0603D9EB RID: 252395 RVA: 0x011D97C8 File Offset: 0x011D79C8
		public override void ClearDetectedTarget(string reason)
		{
			if (this.IsLockingTarget)
			{
				return;
			}
			this.TargetSelector.ClearDetectionData();
			this.DetectedTargetLegalOnceFlag = true;
			base.SetFocusTarget(null, true);
			this.CurrentIconTagId = null;
			this.CurrentIconHighlightTagId = null;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Vehicle;
			ELogAuthor author = ELogAuthor.CK;
			string message = "(摩托车)探索组件清理已探测钩锁目标";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Reason", reason);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0603D9EC RID: 252396 RVA: 0x011D983A File Offset: 0x011D7A3A
		private bool IsTypeDisabled(EHookInteractType hookType)
		{
			return CharacterExploreModel.Instance.MotorcycleHookDetectRestriction.IsTypeDisabled(hookType);
		}

		// Token: 0x0603D9ED RID: 252397 RVA: 0x011D984C File Offset: 0x011D7A4C
		private bool IsFocusTypeDisabled()
		{
			GrapplingHookPointComponent focusTarget = base.FocusTarget;
			EHookInteractType? ehookInteractType = (focusTarget != null) ? focusTarget.GetHookInteractType() : null;
			return ehookInteractType != null && this.IsTypeDisabled(ehookInteractType.Value);
		}

		// Token: 0x0603D9EE RID: 252398 RVA: 0x011D988C File Offset: 0x011D7A8C
		private void TryDetectFollowShooterAutoEnable()
		{
			if (Time.Instance.WorldTimeSeconds - (double)this.LastAutoDetectTimeStamp < (double)this.AutoDetectInterval)
			{
				return;
			}
			this.LastAutoDetectTimeStamp = (float)Time.Instance.WorldTimeSeconds;
			bool enable = false;
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent == null || !tagComponent.HasAnyTag(this.DisableAutoDetectTags))
			{
				EntityHandle playerFollowShooter = FollowUtils.GetPlayerFollowShooter(this.PlayerId);
				object obj;
				if (playerFollowShooter == null)
				{
					obj = null;
				}
				else
				{
					WorldEntity entity = playerFollowShooter.Entity;
					obj = ((entity != null) ? entity.CheckGetComponent<CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow.FollowShooterComponent>() : null);
				}
				object obj2 = obj;
				FGameplayTagContainer fgameplayTagContainer;
				if (obj2 == null)
				{
					fgameplayTagContainer = null;
				}
				else
				{
					BP_FollowShooterConfig_C followShooterConfig = obj2.FollowShooterConfig;
					fgameplayTagContainer = ((followShooterConfig != null) ? followShooterConfig.LockOnConfig.AutoDetectEnableTagContainer : null);
				}
				FGameplayTagContainer fgameplayTagContainer2 = fgameplayTagContainer;
				if (fgameplayTagContainer2 == null || fgameplayTagContainer2.GameplayTags.Num() == 0)
				{
					return;
				}
				enable = (this.TargetSelector.DetectEntityByRestrictTags(this.AutoDetectDistance, EEntityTypeQuery.SceneItemOrCharacter, fgameplayTagContainer2, true) != null);
			}
			CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
			if (component == null)
			{
				return;
			}
			FollowUtils.SetPlayerFollowShooterEnable(component.GetPlayerId(), enable, BPEEnableFollowShooter.AutoDetectedGamePartitionObject, "");
		}

		// Token: 0x0603D9EF RID: 252399 RVA: 0x011D997C File Offset: 0x011D7B7C
		private void OnChangeExploreVisionSkillByTab(int id)
		{
			this.DetectedTargetLegalOnceFlag = false;
		}

		// Token: 0x0603D9F0 RID: 252400 RVA: 0x011D9988 File Offset: 0x011D7B88
		[NullableContext(2)]
		protected override void OnDetectedTargetChanged(GrapplingHookPointComponent prevTarget)
		{
			if (prevTarget != null && prevTarget.Valid && prevTarget != base.FocusTarget)
			{
				prevTarget.ChangeHookPointState(EHookPointState.Normal);
			}
			GrapplingHookPointComponent focusTarget = base.FocusTarget;
			if (focusTarget != null && focusTarget.Valid)
			{
				base.FocusTarget.ChangeHookPointState(base.FocusTargetLegal ? EHookPointState.Interactive : EHookPointState.NonInteractive);
			}
			if (base.FocusTarget != null && base.FocusTargetLegal)
			{
				base.HandleSkillIconLogic(true, "(摩托车)探索组件当前选中的钩锁点有效");
				this.CreateBatchCollectRangeEffect(base.FocusTarget);
				return;
			}
			base.HandleSkillIconLogic(false, "(摩托车)探索组件当前未选中点或者选中的点无效");
			this.DestroyBatchCollectRangeEffect("(摩托车)探索组件当前未选中点或者选中的点无效");
		}

		// Token: 0x0603D9F1 RID: 252401 RVA: 0x011D9A1C File Offset: 0x011D7C1C
		private void CreateBatchCollectRangeEffect(GrapplingHookPointComponent target)
		{
			this.DestroyBatchCollectRangeEffect("(摩托车)探索组件选中新目标时尝试移除旧目标的特效");
			if (target.HookInteractType.GetValueOrDefault() != EHookInteractType.MotorPullInteract)
			{
				return;
			}
			if (string.IsNullOrEmpty(this.BatchCollectRangeEffectPath))
			{
				return;
			}
			EffectSystem instance = EffectSystem.Instance;
			UObject owner = target.ActorComp.Owner;
			FTransformDouble? ftransformDouble = new FTransformDouble?(target.ActorComp.ActorTransform);
			this.BatchCollectRangeEffectHandleId = new int?(instance.SpawnEffect(owner, ftransformDouble, this.BatchCollectRangeEffectPath, "[MotorcycleExploreComponent.OnDetectedTargetChanged]", new EffectContext(new int?(target.Entity.Id), null, false), EEffectType.Scene, null, null, null, false, false));
		}

		// Token: 0x0603D9F2 RID: 252402 RVA: 0x011D9AB0 File Offset: 0x011D7CB0
		private void DestroyBatchCollectRangeEffect(string reason)
		{
			bool flag = (this.BatchCollectRangeEffectHandleId ?? 0) == 0;
			if (flag)
			{
				return;
			}
			EffectSystem.Instance.StopEffectById(this.BatchCollectRangeEffectHandleId.Value, reason, true, null);
			this.BatchCollectRangeEffectHandleId = null;
		}

		// Token: 0x0603D9F3 RID: 252403 RVA: 0x011D9B10 File Offset: 0x011D7D10
		private unsafe void OnBeforeSkill(int skillId, bool IsAutonomousProxy)
		{
			BaseActorComponent actorComponent = this.ActorComponent;
			if (actorComponent == null || !actorComponent.IsAutonomousProxy)
			{
				return;
			}
			if (!MotorcycleHookDetectRestriction.MotorcycleHookSkillIds.Contains(skillId))
			{
				return;
			}
			if (skillId == 10002001)
			{
				this.EjectInterruptingSkillId = null;
			}
			GrapplingHookPointComponent focusTarget2 = base.FocusTarget;
			if (focusTarget2 == null || !focusTarget2.Valid)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Vehicle;
				ELogAuthor author = ELogAuthor.CK;
				string message = "使用探索技能时(摩托车)探索组件当前目标为空, 请检查技能Id配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SkillId", skillId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.IsHookEndByInterrupt = false;
			this.SimulateInteractingTarget = null;
			this.SimulateInteractingTargetLocation = null;
			GrapplingHookPointComponent focusTarget = base.FocusTarget;
			focusTarget.BeHooked(skillId);
			if (skillId == 10001006)
			{
				this.PullingTarget = focusTarget;
				this.SendPullCollectionPush();
			}
			else
			{
				base.InteractingTarget = focusTarget;
				base.SendHookMovePush();
			}
			ICompositeExploreSkillConfig compositeExploreSkillConfig;
			CompositeExploreSkillSession.CompositeExploreSkillConfigs.TryGetValue(skillId, out compositeExploreSkillConfig);
			if (compositeExploreSkillConfig != null)
			{
				CharacterExploreModel.Instance.CompositeExploreSkillSession.TryCleanStaleCompositeSession(skillId, ELogModule.Vehicle, "(摩托车)入口技能重新触发时检测到残留会话");
				CharacterExploreModel.Instance.CompositeExploreSkillSession.ActiveCompositeSession = new CompositeSkillSession
				{
					Config = compositeExploreSkillConfig,
					EnterSent = true,
					CreatedTime = Time.Instance.Now
				};
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Vehicle;
				ELogAuthor author2 = ELogAuthor.CK;
				string message2 = "(摩托车)复合探索技能会话已创建";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("SkillId", skillId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CompositeName", compositeExploreSkillConfig.Name);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			else
			{
				CharacterExploreModel.Instance.CompositeExploreSkillSession.TryCleanStaleCompositeSession(skillId, ELogModule.Vehicle, "(摩托车)非入口技能触发时检测到残留会话");
			}
			base.SendHookTargetRequest(focusTarget, delegate
			{
				this.IsHookEndByInterrupt = true;
				foreach (int skillId2 in MotorcycleHookDetectRestriction.MotorcycleHookSkillIds)
				{
					BaseSkillComponent skillComponent = this.SkillComponent;
					if (skillComponent != null)
					{
						skillComponent.EndSkill(skillId2, "(摩托车)探索组件请求服务器返回错误码");
					}
				}
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Vehicle;
				ELogAuthor author3 = ELogAuthor.CK;
				string message3 = "(摩托车)探索组件请求服务器返回错误码";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("EntityConfigId", focusTarget.EntityConfigId);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}, (compositeExploreSkillConfig != null) ? compositeExploreSkillConfig.Name : null);
			this.CurrentActiveSkillId.Add(skillId);
			this.EnsureRemoveEntityListener(skillId);
		}

		// Token: 0x0603D9F4 RID: 252404 RVA: 0x011D9D1C File Offset: 0x011D7F1C
		private void EnsureRemoveEntityListener(int skillId)
		{
			if (EventSystem.Instance.Has<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnEntityRemove)))
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Vehicle;
			ELogAuthor author = ELogAuthor.CK;
			string message = "(摩托车)探索组件添加RemoveEntity事件监听";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SkillId", skillId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			EventSystem.Instance.Add<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnEntityRemove));
		}

		// Token: 0x0603D9F5 RID: 252405 RVA: 0x011D9D94 File Offset: 0x011D7F94
		private void TryRemoveEntityListener(int skillId)
		{
			if (this.CurrentActiveSkillId.Count > 0 || !EventSystem.Instance.Has<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnEntityRemove)))
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Vehicle;
			ELogAuthor author = ELogAuthor.CK;
			string message = "(摩托车)探索组件移除RemoveEntity事件监听";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SkillId", skillId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			EventSystem.Instance.Remove<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnEntityRemove));
		}

		// Token: 0x0603D9F6 RID: 252406 RVA: 0x011D9E18 File Offset: 0x011D8018
		private unsafe void OnCharUseSkill(int entityId, int skillId, bool isAutonomousProxy)
		{
			if (skillId != 10002002 || !isAutonomousProxy)
			{
				return;
			}
			GrapplingHookPointComponent interactingTarget = base.InteractingTarget;
			if (interactingTarget == null || !interactingTarget.Valid)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Vehicle;
				ELogAuthor author = ELogAuthor.WRY;
				string message = "摩托弹射钩锁进入平台 idle 时,关联的钩锁目标失效或未缓存";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("SkillId", skillId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("hasInteractingTarget", base.InteractingTarget != null);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
				string item = "interactingTargetValid";
				GrapplingHookPointComponent interactingTarget2 = base.InteractingTarget;
				ptr = new ValueTuple<string, object>(item, interactingTarget2 != null && interactingTarget2.Valid);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			this.PlatformRotationDriver.Begin(this, interactingTarget);
			this.CurrentActiveSkillId.Add(skillId);
			this.EnsureRemoveEntityListener(skillId);
		}

		// Token: 0x0603D9F7 RID: 252407 RVA: 0x011D9F05 File Offset: 0x011D8105
		private void OnBeforeInterruptWithTarget(int newSkillId, int interruptedSkillId)
		{
			if (interruptedSkillId != 10002001)
			{
				return;
			}
			this.EjectInterruptingSkillId = new int?(newSkillId);
		}

		// Token: 0x0603D9F8 RID: 252408 RVA: 0x011D9F1C File Offset: 0x011D811C
		private void OnSkillEnd(int entityId, int skillId)
		{
			BaseActorComponent actorComponent = this.ActorComponent;
			if (actorComponent == null || !actorComponent.IsAutonomousProxy)
			{
				return;
			}
			if (!MotorcycleHookDetectRestriction.MotorcycleHookSkillIds.Contains(skillId) && skillId != 10002002)
			{
				return;
			}
			if (skillId == 10001006)
			{
				if (this.PullingTarget == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Vehicle;
					ELogAuthor author = ELogAuthor.CK;
					string message = "使用探索技能时(摩托车)探索组件当前目标为空, 请检查技能Id配置";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SkillId", skillId);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
			}
			else if (skillId == 10002002)
			{
				if (base.InteractingTarget == null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Vehicle;
					ELogAuthor author2 = ELogAuthor.WRY;
					string message2 = "摩托脱离弹射钩锁平台时，关联探索组件当前目标为空, 请检查技能Id配置";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("SkillId", skillId);
					instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
			}
			else if (base.InteractingTarget == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Vehicle;
				ELogAuthor author3 = ELogAuthor.CK;
				string message3 = "使用探索技能时(摩托车)探索组件当前目标为空, 请检查技能Id配置";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("SkillId", skillId);
				instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return;
			}
			this.DoSkillEnd(skillId, "OnSkillEnd");
		}

		// Token: 0x0603D9F9 RID: 252409 RVA: 0x011DA020 File Offset: 0x011D8220
		private unsafe void DoSkillEnd(int skillId, string reason)
		{
			if (!this.CurrentActiveSkillId.Contains(skillId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Vehicle;
				ELogAuthor author = ELogAuthor.CK;
				string message = "(摩托车)探索组件技能重复触发结束处理函数";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("SkillId", skillId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Reason", reason);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Vehicle;
			ELogAuthor author2 = ELogAuthor.CK;
			string message2 = "(摩托车)探索组件技能结束";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("SkillId", skillId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Reason", reason);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			this.CurrentActiveSkillId.Remove(skillId);
			GrapplingHookPointComponent grapplingHookPointComponent;
			if (skillId == 10001006)
			{
				grapplingHookPointComponent = this.PullingTarget;
				this.PullingTarget = null;
			}
			else if (skillId == 10002001)
			{
				VehicleCatapultComponent component = base.Entity.GetComponent<VehicleCatapultComponent>();
				bool flag;
				if (this.EjectInterruptingSkillId.GetValueOrDefault() == 10002002 && component != null && component.GetHasReachedTarget())
				{
					GrapplingHookPointComponent interactingTarget = base.InteractingTarget;
					flag = (interactingTarget != null && interactingTarget.Valid);
				}
				else
				{
					flag = false;
				}
				this.EjectInterruptingSkillId = null;
				if (flag)
				{
					return;
				}
				grapplingHookPointComponent = base.InteractingTarget;
				base.InteractingTarget = null;
			}
			else if (skillId == 10002002)
			{
				grapplingHookPointComponent = base.InteractingTarget;
				this.PlatformRotationDriver.End();
				base.InteractingTarget = null;
			}
			else
			{
				grapplingHookPointComponent = base.InteractingTarget;
				base.InteractingTarget = null;
			}
			if (grapplingHookPointComponent != null && grapplingHookPointComponent.Valid)
			{
				grapplingHookPointComponent.ChangeHookPointState(EHookPointState.Normal);
				ICompositeSkillSession activeCompositeSession = CharacterExploreModel.Instance.CompositeExploreSkillSession.ActiveCompositeSession;
				if (activeCompositeSession != null && activeCompositeSession.Config.EntrySkillId == skillId)
				{
					if (this.IsHookEndByInterrupt)
					{
						base.SendHookEndRequest(grapplingHookPointComponent, activeCompositeSession.Config.Name);
						CharacterExploreModel.Instance.CompositeExploreSkillSession.ActiveCompositeSession = null;
						Log instance3 = Log.Instance;
						ELogModule module3 = ELogModule.Vehicle;
						ELogAuthor author3 = ELogAuthor.CK;
						string message3 = "(摩托车)复合探索技能被打断, 入口技能保底发送Exit并清除会话";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("SkillId", skillId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("CompositeName", activeCompositeSession.Config.Name);
						instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
					}
					else
					{
						Log instance4 = Log.Instance;
						ELogModule module4 = ELogModule.Vehicle;
						ELogAuthor author4 = ELogAuthor.CK;
						string message4 = "(摩托车)复合探索技能: 入口技能正常结束, 跳过SendHookEndRequest";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("SkillId", skillId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("CompositeName", activeCompositeSession.Config.Name);
						instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 2));
					}
				}
				else
				{
					base.SendHookEndRequest(grapplingHookPointComponent, null);
				}
			}
			base.CancelLockTarget("DoSkillEnd", false);
			this.TryRemoveEntityListener(skillId);
		}

		// Token: 0x0603D9FA RID: 252410 RVA: 0x011DA310 File Offset: 0x011D8510
		private void OnFixHookSkillInterrupt(int entityId, int skillId)
		{
			if (entityId != base.Entity.Id || !MotorcycleHookDetectRestriction.MotorcycleHookSkillIds.Contains(skillId) || skillId == 10002002)
			{
				return;
			}
			this.IsHookEndByInterrupt = true;
		}

		// Token: 0x0603D9FB RID: 252411 RVA: 0x011DA340 File Offset: 0x011D8540
		private unsafe void OnEntityRemove(ERemoveEntityType removeType, EntityHandle handle)
		{
			int? interactingTargetEntityId = this.InteractingTargetEntityId;
			int id = handle.Id;
			if (!(interactingTargetEntityId.GetValueOrDefault() == id & interactingTargetEntityId != null))
			{
				return;
			}
			Log.Instance.Info(ELogModule.Vehicle, ELogAuthor.CK, "(摩托车)探索组件当前交互目标实体被移除", default(ReadOnlySpan<ValueTuple<string, object>>));
			base.InteractingTarget = null;
			this.PlatformRotationDriver.End();
			this.IsHookEndByInterrupt = true;
			foreach (int num in this.CurrentActiveSkillId)
			{
				if (num != 10001006)
				{
					BaseSkillComponent skillComponent = this.SkillComponent;
					if (skillComponent != null)
					{
						skillComponent.EndSkill(num, "(摩托车)探索组件当前交互目标实体被移除");
					}
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Vehicle;
					ELogAuthor author = ELogAuthor.CK;
					string message = "(摩托车)探索组件当前交互目标点在技能释放过程中被删除，请检查配置";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
					string item = "EntityConfigId";
					CreatureDataComponent component = handle.Entity.GetComponent<CreatureDataComponent>();
					ptr = new ValueTuple<string, object>(item, (component != null) ? new int?(component.GetPbDataId()) : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SkillId", num);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}
			this.TryRemoveEntityListener(0);
		}

		// Token: 0x0603D9FC RID: 252412 RVA: 0x011DA4A0 File Offset: 0x011D86A0
		private void OnVehicleBeenEntered(VehiclePassengerInfo info, bool byChangeRole)
		{
			if (!info.IsDriver || info.PassengerEntity == null || !info.IsRolePassenger(true))
			{
				return;
			}
			this.DriverEntityId = info.PassengerEntity.Id;
			Log.Instance.Info(ELogModule.Vehicle, ELogAuthor.CK, "主控角色进入摩托车激活(摩托车)探索组件", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.OnExploreComponentEnable("OnVehicleBeenEntered");
		}

		// Token: 0x0603D9FD RID: 252413 RVA: 0x011DA504 File Offset: 0x011D8704
		private void OnVehicleBeenLeaved(VehiclePassengerInfo info, bool byChangeRole)
		{
			if (info.IsDriver)
			{
				int driverEntityId = this.DriverEntityId;
				Entity passengerEntity = info.PassengerEntity;
				int? num = (passengerEntity != null) ? new int?(passengerEntity.Id) : null;
				if (driverEntityId == num.GetValueOrDefault() & num != null)
				{
					Log.Instance.Info(ELogModule.Vehicle, ELogAuthor.CK, "主控角色离开摩托车关闭(摩托车)探索组件", default(ReadOnlySpan<ValueTuple<string, object>>));
					this.OnExploreComponentDisable("OnVehicleBeenLeaved");
					return;
				}
			}
		}

		// Token: 0x0603D9FE RID: 252414 RVA: 0x011DA580 File Offset: 0x011D8780
		private void SendPullCollectionPush()
		{
			GrapplingHookPointComponent pullingTarget = this.PullingTarget;
			if (pullingTarget != null && pullingTarget.Valid)
			{
				BaseActorComponent actorComponent = this.ActorComponent;
				if (actorComponent != null && actorComponent.IsAutonomousProxy)
				{
					RoleSceneInteractController.SendPullCollectionPush(base.Entity, pullingTarget);
					return;
				}
			}
		}

		// Token: 0x0603D9FF RID: 252415 RVA: 0x011DA5CC File Offset: 0x011D87CC
		public unsafe long GetPullCollectionBuffIdByTarget()
		{
			GrapplingHookPointComponent pullingTarget = this.PullingTarget;
			if (pullingTarget == null || !pullingTarget.Valid)
			{
				return 640003034L;
			}
			long valueOrDefault = pullingTarget.GetMotorHookEffectBuffId().GetValueOrDefault(640003034L);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[MotorcycleExploreComponent] GetPullCollectionBuffIdByTarget";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityConfigId", pullingTarget.EntityConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BuffId", valueOrDefault);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return valueOrDefault;
		}

		// Token: 0x0603DA00 RID: 252416 RVA: 0x011DA670 File Offset: 0x011D8870
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			MotorcycleExploreComponent motorcycleExploreComponent = (MotorcycleExploreComponent)componentTemplate;
			if (motorcycleExploreComponent.VehiclePerformComponent == null)
			{
				this.VehiclePerformComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.VehiclePerformComponent), "VehiclePerformComponent"))
			{
				return false;
			}
			if (motorcycleExploreComponent.TargetSelector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TargetSelector), "TargetSelector"))
			{
				return false;
			}
			if (motorcycleExploreComponent.TmpHandles != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpHandles), "TmpHandles"))
			{
				return false;
			}
			this.LevelEventHighlightingSkill = motorcycleExploreComponent.LevelEventHighlightingSkill;
			if (motorcycleExploreComponent.RouletteListDataMotor == null)
			{
				this.RouletteListDataMotor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RouletteListDataMotor), "RouletteListDataMotor"))
			{
				return false;
			}
			this.DetectedTargetLegalOnceFlag = motorcycleExploreComponent.DetectedTargetLegalOnceFlag;
			if (motorcycleExploreComponent.CurrentActiveSkillId != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.CurrentActiveSkillId), "CurrentActiveSkillId"))
			{
				return false;
			}
			this.EjectInterruptingSkillId = motorcycleExploreComponent.EjectInterruptingSkillId;
			this.DriverEntityId = motorcycleExploreComponent.DriverEntityId;
			this.PlayerId = motorcycleExploreComponent.PlayerId;
			if (motorcycleExploreComponent.PlatformRotationDriver != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.PlatformRotationDriver), "PlatformRotationDriver"))
			{
				return false;
			}
			if (motorcycleExploreComponent.PullingTargetInternal == null)
			{
				this.PullingTargetInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PullingTargetInternal), "PullingTargetInternal"))
			{
				return false;
			}
			this.PullingTargetEntityId = motorcycleExploreComponent.PullingTargetEntityId;
			if (motorcycleExploreComponent.SimulatePullingTarget == null)
			{
				this.SimulatePullingTarget = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SimulatePullingTarget), "SimulatePullingTarget"))
			{
				return false;
			}
			this.BatchCollectRangeEffectHandleId = motorcycleExploreComponent.BatchCollectRangeEffectHandleId;
			this.BatchCollectRangeEffectPath = motorcycleExploreComponent.BatchCollectRangeEffectPath;
			this.AutoDetectDistance = motorcycleExploreComponent.AutoDetectDistance;
			this.AutoDetectInterval = motorcycleExploreComponent.AutoDetectInterval;
			if (motorcycleExploreComponent.DisableAutoDetectTags == null)
			{
				this.DisableAutoDetectTags = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DisableAutoDetectTags), "DisableAutoDetectTags"))
			{
				return false;
			}
			this.LastAutoDetectTimeStamp = motorcycleExploreComponent.LastAutoDetectTimeStamp;
			return true;
		}

		// Token: 0x170074FD RID: 29949
		// (get) Token: 0x0603DA01 RID: 252417 RVA: 0x011DA873 File Offset: 0x011D8A73
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170074FE RID: 29950
		// (get) Token: 0x0603DA02 RID: 252418 RVA: 0x011DA876 File Offset: 0x011D8A76
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170074FF RID: 29951
		// (get) Token: 0x0603DA03 RID: 252419 RVA: 0x011DA879 File Offset: 0x011D8A79
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020AED RID: 133869
		private static int _defaultStateTagId;

		// Token: 0x04020AEE RID: 133870
		private const float BATCH_PULL_COLLECTION_MAX_RADIUS = 5000f;

		// Token: 0x04020AEF RID: 133871
		private const int BATCH_PULL_COLLECTION_MAX_COUNT = 15;

		// Token: 0x04020AF0 RID: 133872
		private const long DEFAULT_PULL_COLLECTION_BUFF_ID = 640003034L;

		// Token: 0x04020AF1 RID: 133873
		public static bool TraceDebug;

		// Token: 0x04020AF2 RID: 133874
		[Nullable(2)]
		protected BaseVehiclePerformComponent VehiclePerformComponent;

		// Token: 0x04020AF3 RID: 133875
		private readonly InteractionTargetSelector TargetSelector = new InteractionTargetSelector();

		// Token: 0x04020AF4 RID: 133876
		private readonly List<EntityHandle> TmpHandles = new List<EntityHandle>();

		// Token: 0x04020AF5 RID: 133877
		private bool LevelEventHighlightingSkill;

		// Token: 0x04020AF6 RID: 133878
		[Nullable(2)]
		private RouletteListDataMotor RouletteListDataMotor;

		// Token: 0x04020AF7 RID: 133879
		public bool DetectedTargetLegalOnceFlag = true;

		// Token: 0x04020AF8 RID: 133880
		private readonly HashSet<int> CurrentActiveSkillId = new HashSet<int>();

		// Token: 0x04020AF9 RID: 133881
		private int? EjectInterruptingSkillId;

		// Token: 0x04020AFA RID: 133882
		private int DriverEntityId;

		// Token: 0x04020AFB RID: 133883
		private int PlayerId;

		// Token: 0x04020AFC RID: 133884
		private readonly MotorcyclePlatformRotationDriver PlatformRotationDriver = new MotorcyclePlatformRotationDriver();

		// Token: 0x04020AFD RID: 133885
		[Nullable(2)]
		private GrapplingHookPointComponent PullingTargetInternal;

		// Token: 0x04020AFE RID: 133886
		protected int? PullingTargetEntityId;

		// Token: 0x04020AFF RID: 133887
		[Nullable(2)]
		public GrapplingHookPointComponent SimulatePullingTarget;

		// Token: 0x04020B00 RID: 133888
		private int? BatchCollectRangeEffectHandleId;

		// Token: 0x04020B01 RID: 133889
		[Nullable(2)]
		private string BatchCollectRangeEffectPath;

		// Token: 0x04020B02 RID: 133890
		protected float AutoDetectDistance;

		// Token: 0x04020B03 RID: 133891
		protected float AutoDetectInterval = 0.5f;

		// Token: 0x04020B04 RID: 133892
		protected List<int> DisableAutoDetectTags = new List<int>();

		// Token: 0x04020B05 RID: 133893
		protected float LastAutoDetectTimeStamp;
	}
}

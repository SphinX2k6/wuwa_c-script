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
	// Token: 0x02007125 RID: 28965
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleExploreComponent : BaseExploreComponent, IStaticVariableResetter
	{
		// Token: 0x06046B8C RID: 289676 RVA: 0x011CFDA6 File Offset: 0x011CDFA6
		static MotorcycleExploreComponent()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleExploreComponent.CreateStaticDefaultValue), new Action(MotorcycleExploreComponent.ResetStaticDefaultValue));
		}

		// Token: 0x06046B8D RID: 289677 RVA: 0x011CFDC5 File Offset: 0x011CDFC5
		public static void CreateStaticDefaultValue()
		{
			MotorcycleExploreComponent.TraceDebug = false;
			MotorcycleExploreComponent._defaultStateTagId = GameplayTagDefine.EGameplayTagId["关卡.Common.状态.常态"];
		}

		// Token: 0x06046B8E RID: 289678 RVA: 0x011CFDE1 File Offset: 0x011CDFE1
		public static void ResetStaticDefaultValue()
		{
			MotorcycleExploreComponent.TraceDebug = false;
			MotorcycleExploreComponent._defaultStateTagId = 0;
		}

		// Token: 0x17009D2F RID: 40239
		// (get) Token: 0x06046B8F RID: 289679 RVA: 0x011CFDF0 File Offset: 0x011CDFF0
		// (set) Token: 0x06046B90 RID: 289680 RVA: 0x011CFEE4 File Offset: 0x011CE0E4
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

		// Token: 0x17009D30 RID: 40240
		// (get) Token: 0x06046B91 RID: 289681 RVA: 0x011CFF48 File Offset: 0x011CE148
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public new static Type[] Dependencies
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				Type[] array = BaseExploreComponent.Dependencies ?? Array.Empty<Type>();
				int num = 0;
				Type[] array2 = new Type[1 + array.Length];
				ReadOnlySpan<Type> readOnlySpan = new ReadOnlySpan<Type>(array);
				readOnlySpan.CopyTo(new Span<Type>(array2).Slice(num, readOnlySpan.Length));
				num += readOnlySpan.Length;
				array2[num] = typeof(BaseVehiclePerformComponent);
				return array2;
			}
		}

		// Token: 0x06046B92 RID: 289682 RVA: 0x011CFFB0 File Offset: 0x011CE1B0
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

		// Token: 0x06046B93 RID: 289683 RVA: 0x011D0088 File Offset: 0x011CE288
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

		// Token: 0x06046B94 RID: 289684 RVA: 0x011D0190 File Offset: 0x011CE390
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

		// Token: 0x06046B95 RID: 289685 RVA: 0x011D0270 File Offset: 0x011CE470
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

		// Token: 0x06046B96 RID: 289686 RVA: 0x011D0330 File Offset: 0x011CE530
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

		// Token: 0x06046B97 RID: 289687 RVA: 0x011D040C File Offset: 0x011CE60C
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

		// Token: 0x06046B98 RID: 289688 RVA: 0x011D045C File Offset: 0x011CE65C
		public override bool CheckAllowLevelEventHighlightSkill()
		{
			return !this.IsLockingTarget;
		}

		// Token: 0x06046B99 RID: 289689 RVA: 0x011D0468 File Offset: 0x011CE668
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

		// Token: 0x06046B9A RID: 289690 RVA: 0x011D0590 File Offset: 0x011CE790
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

		// Token: 0x06046B9B RID: 289691 RVA: 0x011D067C File Offset: 0x011CE87C
		public bool TryPullCollection()
		{
			GrapplingHookPointComponent pullingTarget = this.PullingTarget;
			return pullingTarget != null && pullingTarget.Valid && this.PullCollection(pullingTarget);
		}

		// Token: 0x06046B9C RID: 289692 RVA: 0x011D06AC File Offset: 0x011CE8AC
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

		// Token: 0x06046B9D RID: 289693 RVA: 0x011D0958 File Offset: 0x011CEB58
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

		// Token: 0x06046B9E RID: 289694 RVA: 0x011D09C8 File Offset: 0x011CEBC8
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

		// Token: 0x06046B9F RID: 289695 RVA: 0x011D0A48 File Offset: 0x011CEC48
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

		// Token: 0x06046BA0 RID: 289696 RVA: 0x011D0B6C File Offset: 0x011CED6C
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

		// Token: 0x06046BA1 RID: 289697 RVA: 0x011D0BDE File Offset: 0x011CEDDE
		private bool IsTypeDisabled(EHookInteractType hookType)
		{
			return CharacterExploreModel.Instance.MotorcycleHookDetectRestriction.IsTypeDisabled(hookType);
		}

		// Token: 0x06046BA2 RID: 289698 RVA: 0x011D0BF0 File Offset: 0x011CEDF0
		private bool IsFocusTypeDisabled()
		{
			GrapplingHookPointComponent focusTarget = base.FocusTarget;
			EHookInteractType? ehookInteractType = (focusTarget != null) ? focusTarget.GetHookInteractType() : null;
			return ehookInteractType != null && this.IsTypeDisabled(ehookInteractType.Value);
		}

		// Token: 0x06046BA3 RID: 289699 RVA: 0x011D0C30 File Offset: 0x011CEE30
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

		// Token: 0x06046BA4 RID: 289700 RVA: 0x011D0D20 File Offset: 0x011CEF20
		private void OnChangeExploreVisionSkillByTab(int id)
		{
			this.DetectedTargetLegalOnceFlag = false;
		}

		// Token: 0x06046BA5 RID: 289701 RVA: 0x011D0D2C File Offset: 0x011CEF2C
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

		// Token: 0x06046BA6 RID: 289702 RVA: 0x011D0DC0 File Offset: 0x011CEFC0
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

		// Token: 0x06046BA7 RID: 289703 RVA: 0x011D0E54 File Offset: 0x011CF054
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

		// Token: 0x06046BA8 RID: 289704 RVA: 0x011D0EB4 File Offset: 0x011CF0B4
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

		// Token: 0x06046BA9 RID: 289705 RVA: 0x011D10C0 File Offset: 0x011CF2C0
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

		// Token: 0x06046BAA RID: 289706 RVA: 0x011D1138 File Offset: 0x011CF338
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

		// Token: 0x06046BAB RID: 289707 RVA: 0x011D11BC File Offset: 0x011CF3BC
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

		// Token: 0x06046BAC RID: 289708 RVA: 0x011D12A9 File Offset: 0x011CF4A9
		private void OnBeforeInterruptWithTarget(int newSkillId, int interruptedSkillId)
		{
			if (interruptedSkillId != 10002001)
			{
				return;
			}
			this.EjectInterruptingSkillId = new int?(newSkillId);
		}

		// Token: 0x06046BAD RID: 289709 RVA: 0x011D12C0 File Offset: 0x011CF4C0
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

		// Token: 0x06046BAE RID: 289710 RVA: 0x011D13C4 File Offset: 0x011CF5C4
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

		// Token: 0x06046BAF RID: 289711 RVA: 0x011D16B4 File Offset: 0x011CF8B4
		private void OnFixHookSkillInterrupt(int entityId, int skillId)
		{
			if (entityId != base.Entity.Id || !MotorcycleHookDetectRestriction.MotorcycleHookSkillIds.Contains(skillId) || skillId == 10002002)
			{
				return;
			}
			this.IsHookEndByInterrupt = true;
		}

		// Token: 0x06046BB0 RID: 289712 RVA: 0x011D16E4 File Offset: 0x011CF8E4
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

		// Token: 0x06046BB1 RID: 289713 RVA: 0x011D1844 File Offset: 0x011CFA44
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

		// Token: 0x06046BB2 RID: 289714 RVA: 0x011D18A8 File Offset: 0x011CFAA8
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

		// Token: 0x06046BB3 RID: 289715 RVA: 0x011D1924 File Offset: 0x011CFB24
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

		// Token: 0x06046BB4 RID: 289716 RVA: 0x011D1970 File Offset: 0x011CFB70
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

		// Token: 0x06046BB5 RID: 289717 RVA: 0x011D1A14 File Offset: 0x011CFC14
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			MotorcycleExploreComponent motorcycleExploreComponent = (MotorcycleExploreComponent)componentTemplate;
			if (base.CanResetComponentProperty("VehiclePerformComponent"))
			{
				if (motorcycleExploreComponent.VehiclePerformComponent == null)
				{
					this.VehiclePerformComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseVehiclePerformComponent>(this.VehiclePerformComponent), "VehiclePerformComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TargetSelector") && motorcycleExploreComponent.TargetSelector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<InteractionTargetSelector>(this.TargetSelector), "TargetSelector"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TmpHandles") && motorcycleExploreComponent.TmpHandles != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<EntityHandle>>(this.TmpHandles), "TmpHandles"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("LevelEventHighlightingSkill"))
			{
				this.LevelEventHighlightingSkill = motorcycleExploreComponent.LevelEventHighlightingSkill;
			}
			if (base.CanResetComponentProperty("RouletteListDataMotor"))
			{
				if (motorcycleExploreComponent.RouletteListDataMotor == null)
				{
					this.RouletteListDataMotor = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<RouletteListDataMotor>(this.RouletteListDataMotor), "RouletteListDataMotor"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("DetectedTargetLegalOnceFlag"))
			{
				this.DetectedTargetLegalOnceFlag = motorcycleExploreComponent.DetectedTargetLegalOnceFlag;
			}
			if (base.CanResetComponentProperty("CurrentActiveSkillId") && motorcycleExploreComponent.CurrentActiveSkillId != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.CurrentActiveSkillId), "CurrentActiveSkillId"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("EjectInterruptingSkillId"))
			{
				this.EjectInterruptingSkillId = motorcycleExploreComponent.EjectInterruptingSkillId;
			}
			if (base.CanResetComponentProperty("DriverEntityId"))
			{
				this.DriverEntityId = motorcycleExploreComponent.DriverEntityId;
			}
			if (base.CanResetComponentProperty("PlayerId"))
			{
				this.PlayerId = motorcycleExploreComponent.PlayerId;
			}
			if (base.CanResetComponentProperty("PlatformRotationDriver") && motorcycleExploreComponent.PlatformRotationDriver != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<MotorcyclePlatformRotationDriver>(this.PlatformRotationDriver), "PlatformRotationDriver"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("PullingTargetInternal"))
			{
				if (motorcycleExploreComponent.PullingTargetInternal == null)
				{
					this.PullingTargetInternal = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<GrapplingHookPointComponent>(this.PullingTargetInternal), "PullingTargetInternal"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("PullingTargetEntityId"))
			{
				this.PullingTargetEntityId = motorcycleExploreComponent.PullingTargetEntityId;
			}
			if (base.CanResetComponentProperty("SimulatePullingTarget"))
			{
				if (motorcycleExploreComponent.SimulatePullingTarget == null)
				{
					this.SimulatePullingTarget = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<GrapplingHookPointComponent>(this.SimulatePullingTarget), "SimulatePullingTarget"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("BatchCollectRangeEffectHandleId"))
			{
				this.BatchCollectRangeEffectHandleId = motorcycleExploreComponent.BatchCollectRangeEffectHandleId;
			}
			if (base.CanResetComponentProperty("BatchCollectRangeEffectPath"))
			{
				this.BatchCollectRangeEffectPath = motorcycleExploreComponent.BatchCollectRangeEffectPath;
			}
			if (base.CanResetComponentProperty("AutoDetectDistance"))
			{
				this.AutoDetectDistance = motorcycleExploreComponent.AutoDetectDistance;
			}
			if (base.CanResetComponentProperty("AutoDetectInterval"))
			{
				this.AutoDetectInterval = motorcycleExploreComponent.AutoDetectInterval;
			}
			if (base.CanResetComponentProperty("DisableAutoDetectTags"))
			{
				if (motorcycleExploreComponent.DisableAutoDetectTags == null)
				{
					this.DisableAutoDetectTags = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<int>>(this.DisableAutoDetectTags), "DisableAutoDetectTags"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("LastAutoDetectTimeStamp"))
			{
				this.LastAutoDetectTimeStamp = motorcycleExploreComponent.LastAutoDetectTimeStamp;
			}
			return true;
		}

		// Token: 0x0402520D RID: 152077
		private static int _defaultStateTagId;

		// Token: 0x0402520E RID: 152078
		private const float BATCH_PULL_COLLECTION_MAX_RADIUS = 5000f;

		// Token: 0x0402520F RID: 152079
		private const int BATCH_PULL_COLLECTION_MAX_COUNT = 15;

		// Token: 0x04025210 RID: 152080
		private const long DEFAULT_PULL_COLLECTION_BUFF_ID = 640003034L;

		// Token: 0x04025211 RID: 152081
		public static bool TraceDebug;

		// Token: 0x04025212 RID: 152082
		[Nullable(2)]
		protected BaseVehiclePerformComponent VehiclePerformComponent;

		// Token: 0x04025213 RID: 152083
		private readonly InteractionTargetSelector TargetSelector = new InteractionTargetSelector();

		// Token: 0x04025214 RID: 152084
		private readonly List<EntityHandle> TmpHandles = new List<EntityHandle>();

		// Token: 0x04025215 RID: 152085
		private bool LevelEventHighlightingSkill;

		// Token: 0x04025216 RID: 152086
		[Nullable(2)]
		private RouletteListDataMotor RouletteListDataMotor;

		// Token: 0x04025217 RID: 152087
		public bool DetectedTargetLegalOnceFlag = true;

		// Token: 0x04025218 RID: 152088
		private readonly HashSet<int> CurrentActiveSkillId = new HashSet<int>();

		// Token: 0x04025219 RID: 152089
		private int? EjectInterruptingSkillId;

		// Token: 0x0402521A RID: 152090
		private int DriverEntityId;

		// Token: 0x0402521B RID: 152091
		private int PlayerId;

		// Token: 0x0402521C RID: 152092
		private readonly MotorcyclePlatformRotationDriver PlatformRotationDriver = new MotorcyclePlatformRotationDriver();

		// Token: 0x0402521D RID: 152093
		[Nullable(2)]
		private GrapplingHookPointComponent PullingTargetInternal;

		// Token: 0x0402521E RID: 152094
		protected int? PullingTargetEntityId;

		// Token: 0x0402521F RID: 152095
		[Nullable(2)]
		public GrapplingHookPointComponent SimulatePullingTarget;

		// Token: 0x04025220 RID: 152096
		private int? BatchCollectRangeEffectHandleId;

		// Token: 0x04025221 RID: 152097
		[Nullable(2)]
		private string BatchCollectRangeEffectPath;

		// Token: 0x04025222 RID: 152098
		protected float AutoDetectDistance;

		// Token: 0x04025223 RID: 152099
		protected float AutoDetectInterval = 0.5f;

		// Token: 0x04025224 RID: 152100
		protected List<int> DisableAutoDetectTags = new List<int>();

		// Token: 0x04025225 RID: 152101
		protected float LastAutoDetectTimeStamp;
	}
}

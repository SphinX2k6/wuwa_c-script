using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Vehicle.Common
{
	// Token: 0x02007054 RID: 28756
	[NullableContext(1)]
	[Nullable(0)]
	public class VehicleLockOnComponent : BaseLockOnComponent
	{
		// Token: 0x17009BF0 RID: 39920
		// (get) Token: 0x06045FC0 RID: 286656 RVA: 0x01171B65 File Offset: 0x0116FD65
		public new static Type[] Dependencies
		{
			get
			{
				return new Type[]
				{
					typeof(VehicleActorComponent)
				};
			}
		}

		// Token: 0x06045FC1 RID: 286657 RVA: 0x01171B7C File Offset: 0x0116FD7C
		protected override bool OnStart()
		{
			base.OnStart();
			this.IsLookAt = false;
			this.ActorComp = base.Entity.GetComponent<VehicleActorComponent>();
			this.CreatureComp = base.Entity.GetComponent<CreatureDataComponent>();
			this.InputComp = base.Entity.GetComponent<VehicleInputComponent>();
			this.MoveComp = base.Entity.GetComponent<VehicleMoveComponent>();
			base.SetLockOnConfig(6, 0);
			return true;
		}

		// Token: 0x06045FC2 RID: 286658 RVA: 0x01171BE4 File Offset: 0x0116FDE4
		protected override void OnTick(float delta)
		{
			this.TickMoveDir();
			this.TickCurrentInfo();
			base.Check(delta);
			base.OnTick(delta);
		}

		// Token: 0x06045FC3 RID: 286659 RVA: 0x01171C00 File Offset: 0x0116FE00
		private void TickCurrentInfo()
		{
			if (base.IsHardLock || this.IsLookAt)
			{
				return;
			}
			LockOnInfo getCurrentInfo = base.GetCurrentInfo;
			bool flag;
			if (getCurrentInfo == null)
			{
				flag = false;
			}
			else
			{
				EntityHandle entityHandle = getCurrentInfo.EntityHandle;
				flag = ((entityHandle != null) ? new bool?(entityHandle.Valid) : null).GetValueOrDefault();
			}
			if (flag && this.CurSoftLockConfig != null && (base.IsEntityContainsDisableSoftLockTag(base.GetCurrentInfo.EntityHandle) || base.CannotBeDetected(this.CurSoftLockConfig.Value, base.GetCurrentInfo.EntityHandle, base.GetCurrentInfo.EntityHandle.Entity.GetComponent<BaseActorComponent>().ActorLocationProxy)))
			{
				base.SetCurrentInfo(null);
				this.SetShowTarget(null, "", false);
			}
		}

		// Token: 0x06045FC4 RID: 286660 RVA: 0x01171CC0 File Offset: 0x0116FEC0
		private void TickMoveDir()
		{
			if (!this.InputComp)
			{
				return;
			}
			Vector moveDirectionCache = this.InputComp.GetMoveDirectionCache();
			if (this.InputComp.GetCameraInput().Item1 != 0f || !this.MoveDirCache.Equals(moveDirectionCache, 1E-08))
			{
				this.MoveDirCache.Set(moveDirectionCache.X, moveDirectionCache.Y, 0.0);
				this.InputDirect.DeepCopy(this.ActorComp.InputDirectProxy);
				Vector moveDirCache = this.MoveDirCache;
				if (moveDirCache == null || !moveDirCache.IsNearlyZero(1E-08))
				{
					this.HasChangeInput = true;
					return;
				}
			}
			if (this.SpeedUpCleanTarget())
			{
				this.HasChangeInput = true;
			}
		}

		// Token: 0x06045FC5 RID: 286661 RVA: 0x01171D84 File Offset: 0x0116FF84
		public bool SpeedUpCleanTarget()
		{
			VehicleMoveComponent moveComp = this.MoveComp;
			return moveComp != null && moveComp.Valid && this.MoveComp.Speed > 420f && !this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]);
		}

		// Token: 0x06045FC6 RID: 286662 RVA: 0x01171DD8 File Offset: 0x0116FFD8
		protected override int GetSelfCamp()
		{
			if (this.ActorComp.Owner is TsBaseVehicle)
			{
				BaseVehiclePerformComponent component = base.Entity.GetComponent<BaseVehiclePerformComponent>();
				if (((component != null) ? component.Driver : null) != null)
				{
					BaseActorComponent component2 = component.Driver.GetComponent<BaseActorComponent>();
					TsBaseCharacter tsBaseCharacter = ((component2 != null) ? component2.Owner : null) as TsBaseCharacter;
					if (tsBaseCharacter != null)
					{
						return (int)tsBaseCharacter.Camp;
					}
				}
			}
			return -1;
		}

		// Token: 0x06045FC7 RID: 286663 RVA: 0x01171E3C File Offset: 0x0117003C
		[NullableContext(2)]
		protected override void SetAndShowTarget(LockOnInfo bestInfo, bool showTarget)
		{
			base.SetCurrentInfo(bestInfo);
			if (bestInfo != null)
			{
				EntityHandle entityHandle = bestInfo.EntityHandle;
				if (((entityHandle != null) ? new bool?(entityHandle.Valid) : null).GetValueOrDefault())
				{
					LockOnDebug.SetDebugArrow(bestInfo, EColorType.Green);
				}
			}
			if (showTarget)
			{
				this.SetShowTargetBySkill(base.GetCurrentTarget(), base.GetCurrentTargetSocketName());
			}
		}

		// Token: 0x06045FC8 RID: 286664 RVA: 0x01171E9C File Offset: 0x0117009C
		private bool SetShowTargetBySkill([Nullable(2)] EntityHandle target, string socketName = "")
		{
			if (base.IsHardLock)
			{
				return false;
			}
			if (target == null || !target.Valid || !target.Entity.Active)
			{
				return this.SetShowTarget(null, "", false);
			}
			return this.SetShowTarget(target, socketName, false);
		}

		// Token: 0x06045FC9 RID: 286665 RVA: 0x01171EE8 File Offset: 0x011700E8
		public override bool SetShowTarget([Nullable(2)] EntityHandle target, string socketName = "", bool isHardLock = false)
		{
			if (base.ShowTarget == target && base.ShowTargetSocket == socketName)
			{
				return true;
			}
			this.ShowTargetSetTime = Time.Instance.WorldTime;
			this.ShowTargetInternal = target;
			this.ShowTargetSocketInternal = socketName;
			return true;
		}

		// Token: 0x06045FCA RID: 286666 RVA: 0x01171F24 File Offset: 0x01170124
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			VehicleLockOnComponent vehicleLockOnComponent = (VehicleLockOnComponent)componentTemplate;
			if (base.CanResetComponentProperty("StatTickMoveDir") && vehicleLockOnComponent.StatTickMoveDir != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Stat>(this.StatTickMoveDir), "StatTickMoveDir"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("StatTickCurrentInfo") && vehicleLockOnComponent.StatTickCurrentInfo != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Stat>(this.StatTickCurrentInfo), "StatTickCurrentInfo"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("StatCheck") && vehicleLockOnComponent.StatCheck != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Stat>(this.StatCheck), "StatCheck"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (vehicleLockOnComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<VehicleActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("InputComp"))
			{
				if (vehicleLockOnComponent.InputComp == null)
				{
					this.InputComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<VehicleInputComponent>(this.InputComp), "InputComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("MoveComp"))
			{
				if (vehicleLockOnComponent.MoveComp == null)
				{
					this.MoveComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<VehicleMoveComponent>(this.MoveComp), "MoveComp"))
				{
					return false;
				}
			}
			return !base.CanResetComponentProperty("MoveDirCache") || vehicleLockOnComponent.MoveDirCache == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.MoveDirCache), "MoveDirCache");
		}

		// Token: 0x04024A28 RID: 150056
		private const int VEHICLE_SKILLTARGET_LOCKON_ID = 6;

		// Token: 0x04024A29 RID: 150057
		private const float VEHICLE_CLEAN_TARGET_SPEED_THRESHOLD = 420f;

		// Token: 0x04024A2A RID: 150058
		[StaticVariableRuleIgnore]
		private readonly Stat StatTickMoveDir = Stat.Create("VehicleLockOnComponent.StatTickMoveDir", "", "");

		// Token: 0x04024A2B RID: 150059
		[StaticVariableRuleIgnore]
		private readonly Stat StatTickCurrentInfo = Stat.Create("VehicleLockOnComponent.StatTickCurrentInfo", "", "");

		// Token: 0x04024A2C RID: 150060
		[StaticVariableRuleIgnore]
		private readonly Stat StatCheck = Stat.Create("VehicleLockOnComponent.StatCheck", "", "");

		// Token: 0x04024A2D RID: 150061
		[Nullable(2)]
		private VehicleActorComponent ActorComp;

		// Token: 0x04024A2E RID: 150062
		[Nullable(2)]
		private VehicleInputComponent InputComp;

		// Token: 0x04024A2F RID: 150063
		[Nullable(2)]
		private VehicleMoveComponent MoveComp;

		// Token: 0x04024A30 RID: 150064
		private readonly Vector MoveDirCache = Vector.Create();
	}
}

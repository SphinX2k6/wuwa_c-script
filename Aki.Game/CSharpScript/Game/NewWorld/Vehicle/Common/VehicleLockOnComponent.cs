using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Vehicle.Common
{
	// Token: 0x020061D5 RID: 25045
	[NullableContext(1)]
	[Nullable(0)]
	public class VehicleLockOnComponent : BaseLockOnComponent
	{
		// Token: 0x17007166 RID: 29030
		// (get) Token: 0x0603C1AB RID: 246187 RVA: 0x0111B875 File Offset: 0x01119A75
		public override Type[] Dependencies
		{
			get
			{
				return new Type[]
				{
					typeof(VehicleActorComponent)
				};
			}
		}

		// Token: 0x0603C1AC RID: 246188 RVA: 0x0111B88C File Offset: 0x01119A8C
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

		// Token: 0x0603C1AD RID: 246189 RVA: 0x0111B8F4 File Offset: 0x01119AF4
		protected override void OnTick(float delta)
		{
			this.TickMoveDir();
			this.TickCurrentInfo();
			base.Check(delta);
			base.OnTick(delta);
		}

		// Token: 0x0603C1AE RID: 246190 RVA: 0x0111B910 File Offset: 0x01119B10
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

		// Token: 0x0603C1AF RID: 246191 RVA: 0x0111B9D0 File Offset: 0x01119BD0
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

		// Token: 0x0603C1B0 RID: 246192 RVA: 0x0111BA94 File Offset: 0x01119C94
		public bool SpeedUpCleanTarget()
		{
			VehicleMoveComponent moveComp = this.MoveComp;
			return moveComp != null && moveComp.Valid && this.MoveComp.Speed > 420f && !this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]);
		}

		// Token: 0x0603C1B1 RID: 246193 RVA: 0x0111BAE8 File Offset: 0x01119CE8
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

		// Token: 0x0603C1B2 RID: 246194 RVA: 0x0111BB4C File Offset: 0x01119D4C
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

		// Token: 0x0603C1B3 RID: 246195 RVA: 0x0111BBAC File Offset: 0x01119DAC
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

		// Token: 0x0603C1B4 RID: 246196 RVA: 0x0111BBF8 File Offset: 0x01119DF8
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

		// Token: 0x0603C1B5 RID: 246197 RVA: 0x0111BC34 File Offset: 0x01119E34
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			VehicleLockOnComponent vehicleLockOnComponent = (VehicleLockOnComponent)componentTemplate;
			if (vehicleLockOnComponent.StatTickMoveDir != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.StatTickMoveDir), "StatTickMoveDir"))
			{
				return false;
			}
			if (vehicleLockOnComponent.StatTickCurrentInfo != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.StatTickCurrentInfo), "StatTickCurrentInfo"))
			{
				return false;
			}
			if (vehicleLockOnComponent.StatCheck != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.StatCheck), "StatCheck"))
			{
				return false;
			}
			if (vehicleLockOnComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (vehicleLockOnComponent.InputComp == null)
			{
				this.InputComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.InputComp), "InputComp"))
			{
				return false;
			}
			if (vehicleLockOnComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
			{
				return false;
			}
			return vehicleLockOnComponent.MoveDirCache == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveDirCache), "MoveDirCache");
		}

		// Token: 0x17007167 RID: 29031
		// (get) Token: 0x0603C1B6 RID: 246198 RVA: 0x0111BD5D File Offset: 0x01119F5D
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007168 RID: 29032
		// (get) Token: 0x0603C1B7 RID: 246199 RVA: 0x0111BD60 File Offset: 0x01119F60
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007169 RID: 29033
		// (get) Token: 0x0603C1B8 RID: 246200 RVA: 0x0111BD63 File Offset: 0x01119F63
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FCDE RID: 130270
		private const int VEHICLE_SKILLTARGET_LOCKON_ID = 6;

		// Token: 0x0401FCDF RID: 130271
		private const float VEHICLE_CLEAN_TARGET_SPEED_THRESHOLD = 420f;

		// Token: 0x0401FCE0 RID: 130272
		[StaticVariableRuleIgnore]
		private readonly Stat StatTickMoveDir = Stat.Create("VehicleLockOnComponent.StatTickMoveDir", "", "");

		// Token: 0x0401FCE1 RID: 130273
		[StaticVariableRuleIgnore]
		private readonly Stat StatTickCurrentInfo = Stat.Create("VehicleLockOnComponent.StatTickCurrentInfo", "", "");

		// Token: 0x0401FCE2 RID: 130274
		[StaticVariableRuleIgnore]
		private readonly Stat StatCheck = Stat.Create("VehicleLockOnComponent.StatCheck", "", "");

		// Token: 0x0401FCE3 RID: 130275
		[Nullable(2)]
		private VehicleActorComponent ActorComp;

		// Token: 0x0401FCE4 RID: 130276
		[Nullable(2)]
		private VehicleInputComponent InputComp;

		// Token: 0x0401FCE5 RID: 130277
		[Nullable(2)]
		private VehicleMoveComponent MoveComp;

		// Token: 0x0401FCE6 RID: 130278
		private readonly Vector MoveDirCache = Vector.Create();
	}
}

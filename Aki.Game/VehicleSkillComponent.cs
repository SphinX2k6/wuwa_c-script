using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game;
using UnrealEngine;

// Token: 0x020032DB RID: 13019
[NullableContext(1)]
[Nullable(0)]
public class VehicleSkillComponent : BaseSkillComponent, IComponentDependency
{
	// Token: 0x17002739 RID: 10041
	// (get) Token: 0x0601C4E4 RID: 115940 RVA: 0x007E7163 File Offset: 0x007E5363
	public static Type[] Dependencies
	{
		get
		{
			return new Type[]
			{
				typeof(VehicleActorComponent)
			};
		}
	}

	// Token: 0x0601C4E5 RID: 115941 RVA: 0x007E7178 File Offset: 0x007E5378
	protected override bool OnInit()
	{
		if (!base.OnInit())
		{
			return false;
		}
		this.AnimComp = base.Entity.GetComponent<VehicleAnimationComponent>();
		this.MoveComp = base.Entity.GetComponent<VehicleMoveComponent>();
		this.VehicleActorComp = (this.ActorComp as VehicleActorComponent);
		return true;
	}

	// Token: 0x0601C4E6 RID: 115942 RVA: 0x007E71B8 File Offset: 0x007E53B8
	[NullableContext(2)]
	public override UAnimInstance GetMainAnimInstance()
	{
		return this.AnimComp.MainAnimInstance;
	}

	// Token: 0x0601C4E7 RID: 115943 RVA: 0x007E71C8 File Offset: 0x007E53C8
	protected override void DoSkillBeginMoveAction(Skill skill, SSkillInfo info)
	{
		BaseTagComponent tagComp = this.TagComp;
		if (tagComp != null && tagComp.HasTag(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止移动"]))
		{
			VehicleMoveComponent moveComp = this.MoveComp;
			if (moveComp != null)
			{
				moveComp.SetForceSpeed(Vector.ZeroVectorProxy);
			}
		}
		this.SetSkillTargetDirection(info.SkillDirection, info.SkillTarget.SkillTargetPriority);
		VehicleAnimationComponent animComp = this.AnimComp;
		if (animComp == null)
		{
			return;
		}
		animComp.StartForceDisableAnimOptimization(EForceDisableAnimOptimization.Skill, false);
	}

	// Token: 0x0601C4E8 RID: 115944 RVA: 0x007E7244 File Offset: 0x007E5444
	public void SetSkillTargetDirection(ESkillTargetDirection direction, ESkillTargetPriority priority = ESkillTargetPriority.摇杆方向优先)
	{
		BaseLockOnComponent lockOnComp = this.LockOnComp;
		if (lockOnComp != null && lockOnComp.Valid)
		{
			switch (direction)
			{
			case ESkillTargetDirection.技能目标方向:
			{
				EntityHandle skillTarget = this.SkillTarget;
				if (skillTarget != null && skillTarget.Valid)
				{
					this.TurnToSkillTarget();
					return;
				}
				if (priority == ESkillTargetPriority.镜头方向优先_精准模式_)
				{
					this.TurnToCameraDir();
					return;
				}
				this.TurnToInputDir();
				return;
			}
			case ESkillTargetDirection.摇杆方向:
				this.TurnToInputDir();
				return;
			case ESkillTargetDirection.角色方向:
				break;
			case ESkillTargetDirection.相机方向:
				this.TurnToCameraDir();
				break;
			case ESkillTargetDirection.技能目标方向_载具专用_:
			{
				EntityHandle skillTarget2 = this.SkillTarget;
				if (skillTarget2 != null && skillTarget2.Valid)
				{
					this.TurnToSkillTarget();
					return;
				}
				if (priority == ESkillTargetPriority.镜头方向优先_精准模式_)
				{
					this.TurnToCameraDir();
					return;
				}
				break;
			}
			default:
				return;
			}
		}
	}

	// Token: 0x0601C4E9 RID: 115945 RVA: 0x007E72E0 File Offset: 0x007E54E0
	private void TurnToInputDir()
	{
		if (!this.VehicleActorComp.IsAutonomousProxy)
		{
			return;
		}
		if (!this.IsHasInputDir())
		{
			return;
		}
		MathUtils.Instance.LookRotationUpFirst(this.VehicleActorComp.InputDirectProxy, this.MoveComp.GravityUp, this.TmpRotator);
		this.TmpTransform.Set(this.VehicleActorComp.ActorLocationProxy, this.TmpRotator.Quaternion(null), this.VehicleActorComp.ActorScaleProxy);
		this.VehicleActorComp.SetActorTransform(this.TmpTransform.ToUeTransform(), "载具.释放技能.转向输入方向", false, new ESetRotationPriority?(ESetRotationPriority.Skill));
	}

	// Token: 0x0601C4EA RID: 115946 RVA: 0x007E737C File Offset: 0x007E557C
	public bool IsHasInputDir()
	{
		if (!base.CheckIsLoaded())
		{
			return false;
		}
		Vector inputDirectProxy = this.VehicleActorComp.InputDirectProxy;
		return 0.0 < Math.Abs(inputDirectProxy.X) || 0.0 < Math.Abs(inputDirectProxy.Y);
	}

	// Token: 0x0601C4EB RID: 115947 RVA: 0x007E73D0 File Offset: 0x007E55D0
	private void TurnToCameraDir()
	{
		Rotator tmpRotator = this.TmpRotator;
		FRotator cameraRotation = Global.CharacterCameraManager.GetCameraRotation();
		tmpRotator.FromUeRotator(cameraRotation);
		this.TmpRotator.Vector(this.TmpVector);
		MathUtils instance = MathUtils.Instance;
		Vector tmpVector = this.TmpVector;
		VehicleActorComponent vehicleActorComp = this.VehicleActorComp;
		Vector vector;
		if (vehicleActorComp == null)
		{
			vector = null;
		}
		else
		{
			BaseMoveComponent moveComp = vehicleActorComp.MoveComp;
			vector = ((moveComp != null) ? moveComp.GravityUp : null);
		}
		instance.LookRotationUpFirst(tmpVector, vector ?? Vector.UpVectorProxy, this.TmpRotator);
		this.TmpTransform.Set(this.VehicleActorComp.ActorLocationProxy, this.TmpRotator.Quaternion(null), this.VehicleActorComp.ActorScaleProxy);
		this.VehicleActorComp.SetActorTransform(this.TmpTransform.ToUeTransform(), "载具.释放技能.转向摄像机方向", false, new ESetRotationPriority?(ESetRotationPriority.Skill));
	}

	// Token: 0x0601C4EC RID: 115948 RVA: 0x007E7494 File Offset: 0x007E5694
	private void TurnToSkillTarget()
	{
		if (this.SkillTarget == null)
		{
			return;
		}
		Vector tmpVector = this.TmpVector;
		FVectorDouble location = base.GetTargetTransform().GetLocation();
		tmpVector.FromUeVector(location);
		this.TmpVector.SubtractionEqual(this.VehicleActorComp.ActorLocationProxy);
		MathUtils instance = MathUtils.Instance;
		Vector tmpVector2 = this.TmpVector;
		VehicleActorComponent vehicleActorComp = this.VehicleActorComp;
		Vector vector;
		if (vehicleActorComp == null)
		{
			vector = null;
		}
		else
		{
			BaseMoveComponent moveComp = vehicleActorComp.MoveComp;
			vector = ((moveComp != null) ? moveComp.GravityUp : null);
		}
		instance.LookRotationUpFirst(tmpVector2, vector ?? Vector.UpVectorProxy, this.TmpRotator);
		this.VehicleActorComp.SetActorRotation(this.TmpRotator.ToUeRotator(), "载具.释放技能.转向技能目标", false);
	}

	// Token: 0x0601C4ED RID: 115949 RVA: 0x007E7537 File Offset: 0x007E5737
	protected override void DoSkillEndMoveAction(SSkillInfo info)
	{
		VehicleAnimationComponent animComp = this.AnimComp;
		if (animComp == null)
		{
			return;
		}
		animComp.CancelForceDisableAnimOptimization(EForceDisableAnimOptimization.Skill);
	}

	// Token: 0x0601C4EE RID: 115950 RVA: 0x007E754C File Offset: 0x007E574C
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		VehicleSkillComponent vehicleSkillComponent = (VehicleSkillComponent)componentTemplate;
		if (base.CanResetComponentProperty("AnimComp"))
		{
			if (vehicleSkillComponent.AnimComp == null)
			{
				this.AnimComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<VehicleAnimationComponent>(this.AnimComp), "AnimComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MoveComp"))
		{
			if (vehicleSkillComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<VehicleMoveComponent>(this.MoveComp), "MoveComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("VehicleActorComp"))
		{
			if (vehicleSkillComponent.VehicleActorComp == null)
			{
				this.VehicleActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<VehicleActorComponent>(this.VehicleActorComp), "VehicleActorComp"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400E04E RID: 57422
	[StaticVariableRuleIgnore]
	private static readonly Stat StatDoSkillBegin6 = Stat.Create("Vehicle DoSkillBegin Target&Rotation", "", "");

	// Token: 0x0400E04F RID: 57423
	[Nullable(2)]
	private VehicleAnimationComponent AnimComp;

	// Token: 0x0400E050 RID: 57424
	[Nullable(2)]
	private VehicleMoveComponent MoveComp;

	// Token: 0x0400E051 RID: 57425
	[Nullable(2)]
	private VehicleActorComponent VehicleActorComp;
}

using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game;
using UnrealEngine;

// Token: 0x0200284D RID: 10317
[NullableContext(1)]
[Nullable(0)]
public class VehicleSkillComponent : BaseSkillComponent
{
	// Token: 0x17002A7A RID: 10874
	// (get) Token: 0x0601A17A RID: 106874 RVA: 0x0080D980 File Offset: 0x0080BB80
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

	// Token: 0x0601A17B RID: 106875 RVA: 0x0080D995 File Offset: 0x0080BB95
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

	// Token: 0x0601A17C RID: 106876 RVA: 0x0080D9D5 File Offset: 0x0080BBD5
	[NullableContext(2)]
	public override UAnimInstance GetMainAnimInstance()
	{
		return this.AnimComp.MainAnimInstance;
	}

	// Token: 0x0601A17D RID: 106877 RVA: 0x0080D9E4 File Offset: 0x0080BBE4
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

	// Token: 0x0601A17E RID: 106878 RVA: 0x0080DA60 File Offset: 0x0080BC60
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

	// Token: 0x0601A17F RID: 106879 RVA: 0x0080DAFC File Offset: 0x0080BCFC
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

	// Token: 0x0601A180 RID: 106880 RVA: 0x0080DB98 File Offset: 0x0080BD98
	public bool IsHasInputDir()
	{
		if (!base.CheckIsLoaded())
		{
			return false;
		}
		Vector inputDirectProxy = this.VehicleActorComp.InputDirectProxy;
		return 0.0 < Math.Abs(inputDirectProxy.X) || 0.0 < Math.Abs(inputDirectProxy.Y);
	}

	// Token: 0x0601A181 RID: 106881 RVA: 0x0080DBEC File Offset: 0x0080BDEC
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

	// Token: 0x0601A182 RID: 106882 RVA: 0x0080DCB0 File Offset: 0x0080BEB0
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

	// Token: 0x0601A183 RID: 106883 RVA: 0x0080DD53 File Offset: 0x0080BF53
	protected override void DoSkillEndMoveAction(SSkillInfo info)
	{
		VehicleAnimationComponent animComp = this.AnimComp;
		if (animComp == null)
		{
			return;
		}
		animComp.CancelForceDisableAnimOptimization(EForceDisableAnimOptimization.Skill);
	}

	// Token: 0x0601A184 RID: 106884 RVA: 0x0080DD68 File Offset: 0x0080BF68
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		VehicleSkillComponent vehicleSkillComponent = (VehicleSkillComponent)componentTemplate;
		if (vehicleSkillComponent.AnimComp == null)
		{
			this.AnimComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AnimComp), "AnimComp"))
		{
			return false;
		}
		if (vehicleSkillComponent.MoveComp == null)
		{
			this.MoveComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
		{
			return false;
		}
		if (vehicleSkillComponent.VehicleActorComp == null)
		{
			this.VehicleActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.VehicleActorComp), "VehicleActorComp"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x17002A7B RID: 10875
	// (get) Token: 0x0601A185 RID: 106885 RVA: 0x0080DE09 File Offset: 0x0080C009
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A7C RID: 10876
	// (get) Token: 0x0601A186 RID: 106886 RVA: 0x0080DE0C File Offset: 0x0080C00C
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A7D RID: 10877
	// (get) Token: 0x0601A187 RID: 106887 RVA: 0x0080DE0F File Offset: 0x0080C00F
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A7E RID: 10878
	// (get) Token: 0x0601A188 RID: 106888 RVA: 0x0080DE12 File Offset: 0x0080C012
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A7F RID: 10879
	// (get) Token: 0x0601A189 RID: 106889 RVA: 0x0080DE15 File Offset: 0x0080C015
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A80 RID: 10880
	// (get) Token: 0x0601A18A RID: 106890 RVA: 0x0080DE18 File Offset: 0x0080C018
	public override bool NeedDisableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A81 RID: 10881
	// (get) Token: 0x0601A18B RID: 106891 RVA: 0x0080DE1B File Offset: 0x0080C01B
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A82 RID: 10882
	// (get) Token: 0x0601A18C RID: 106892 RVA: 0x0080DE1E File Offset: 0x0080C01E
	public override bool NeedChangeTimeDilationInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E4F9 RID: 58617
	[StaticVariableRuleIgnore]
	private static readonly Stat StatDoSkillBegin6 = Stat.Create("Vehicle DoSkillBegin Target&Rotation", "", "");

	// Token: 0x0400E4FA RID: 58618
	[Nullable(2)]
	private VehicleAnimationComponent AnimComp;

	// Token: 0x0400E4FB RID: 58619
	[Nullable(2)]
	private VehicleMoveComponent MoveComp;

	// Token: 0x0400E4FC RID: 58620
	[Nullable(2)]
	private VehicleActorComponent VehicleActorComp;
}

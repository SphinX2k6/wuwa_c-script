using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game;
using UnrealEngine;

// Token: 0x020026A8 RID: 9896
[NullableContext(1)]
[Nullable(0)]
public class CharacterSkillComponent : BaseSkillComponent, IStaticVariableResetter
{
	// Token: 0x06018CCB RID: 101579 RVA: 0x00788004 File Offset: 0x00786204
	static CharacterSkillComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterSkillComponent.CreateStaticDefaultValue), new Action(CharacterSkillComponent.ResetStaticDefaultValue));
	}

	// Token: 0x17002758 RID: 10072
	// (get) Token: 0x06018CCC RID: 101580 RVA: 0x00788079 File Offset: 0x00786279
	[Nullable(2)]
	protected new CharacterActorComponent ActorComp
	{
		[NullableContext(2)]
		get
		{
			return this.ActorComp as CharacterActorComponent;
		}
	}

	// Token: 0x06018CCD RID: 101581 RVA: 0x00788088 File Offset: 0x00786288
	[NullableContext(2)]
	protected override bool OnInitData(IEntityArgs args = null)
	{
		if (!base.OnInitData(null))
		{
			return false;
		}
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		if (!CharacterSkillComponent._isConfigInited)
		{
			CharacterSkillComponent._jumpPriority = ConfigCommonParamById.GetIntConfig("jump_priority").GetValueOrDefault();
			CharacterSkillComponent._glidePriority = ConfigCommonParamById.GetIntConfig("fly_priority").GetValueOrDefault();
			CharacterSkillComponent._isConfigInited = true;
		}
		return true;
	}

	// Token: 0x06018CCE RID: 101582 RVA: 0x007880ED File Offset: 0x007862ED
	protected override bool OnInit()
	{
		if (!base.OnInit())
		{
			return false;
		}
		this.MoveComp = base.Entity.GetComponent<CharacterMoveComponent>();
		this.StateComp = base.Entity.CheckGetComponent<CharacterUnifiedStateComponent>();
		this.AnimComp = base.Entity.GetComponent<CharacterAnimationComponent>();
		return true;
	}

	// Token: 0x06018CCF RID: 101583 RVA: 0x00788130 File Offset: 0x00786330
	protected override bool OnEnd()
	{
		if (!base.OnEnd())
		{
			return false;
		}
		this.SkillElevationAngleInternal = 0f;
		this.LastActivateSkillTimeInternal = 0f;
		if (this.RollingGroundEndTimer != null)
		{
			TimerSystem.Instance.Remove(this.RollingGroundEndTimer);
			this.RollingGroundEndTimer = null;
		}
		return true;
	}

	// Token: 0x06018CD0 RID: 101584 RVA: 0x00788180 File Offset: 0x00786380
	protected override void DoSkillBeginMoveAction(global::Skill skill, SSkillInfo info)
	{
		this.StateComp.ExitHitState("释放技能");
		this.SetSkillTargetDirection(info.SkillDirection, info.SkillTarget.SkillTargetPriority);
		this.SetSkillMoveState(skill.SkillId, info);
		CharacterAnimationComponent animComp = this.AnimComp;
		if (animComp == null)
		{
			return;
		}
		animComp.StartForceDisableAnimOptimization(EForceDisableAnimOptimization.Skill, false);
	}

	// Token: 0x06018CD1 RID: 101585 RVA: 0x007881E0 File Offset: 0x007863E0
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
			default:
				return;
			}
		}
	}

	// Token: 0x06018CD2 RID: 101586 RVA: 0x00788254 File Offset: 0x00786454
	public void SetDisableTurnToInputDir(bool disable)
	{
		this.IsDisableTurnToInputDir = disable;
		CombatLog instance = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
		Entity entity = base.Entity;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 1);
		defaultInterpolatedStringHandler.AppendLiteral("SetDisableTurnToInputDir: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(disable);
		instance.Info(flag, entity, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06018CD3 RID: 101587 RVA: 0x007882A8 File Offset: 0x007864A8
	private void TurnToInputDir()
	{
		if (this.IsDisableTurnToInputDir)
		{
			return;
		}
		if (!this.ActorComp.IsAutonomousProxy)
		{
			return;
		}
		if (!this.IsHasInputDir())
		{
			return;
		}
		CharacterInputComponent component = base.Entity.GetComponent<CharacterInputComponent>();
		if (component != null && component.IsLocalInput)
		{
			return;
		}
		MathUtils.Instance.LookRotationUpFirst(this.ActorComp.InputDirectProxy, this.MoveComp.GravityUp, this.TmpRotator);
		this.TmpTransform.Set(this.ActorComp.ActorLocationProxy, this.TmpRotator.Quaternion(null), this.ActorComp.ActorScaleProxy);
		this.ActorComp.SetActorTransform(this.TmpTransform.ToUeTransform(), "释放技能.转向输入方向", false, new ESetRotationPriority?(ESetRotationPriority.Skill));
	}

	// Token: 0x06018CD4 RID: 101588 RVA: 0x00788368 File Offset: 0x00786568
	public bool IsHasInputDir()
	{
		if (!base.CheckIsLoaded())
		{
			return false;
		}
		global::Vector inputDirectProxy = this.ActorComp.InputDirectProxy;
		return 0.0 < Math.Abs(inputDirectProxy.X) || 0.0 < Math.Abs(inputDirectProxy.Y);
	}

	// Token: 0x06018CD5 RID: 101589 RVA: 0x007883BC File Offset: 0x007865BC
	private void TurnToCameraDir()
	{
		Rotator tmpRotator = this.TmpRotator;
		FRotator cameraRotation = Global.CharacterCameraManager.GetCameraRotation();
		tmpRotator.FromUeRotator(cameraRotation);
		this.TmpRotator.Vector(this.TmpVector);
		MathUtils instance = MathUtils.Instance;
		global::Vector tmpVector = this.TmpVector;
		CharacterActorComponent actorComp = this.ActorComp;
		global::Vector vector;
		if (actorComp == null)
		{
			vector = null;
		}
		else
		{
			BaseMoveComponent moveComp = actorComp.MoveComp;
			vector = ((moveComp != null) ? moveComp.GravityUp : null);
		}
		instance.LookRotationUpFirst(tmpVector, vector ?? global::Vector.UpVectorProxy, this.TmpRotator);
		this.TmpTransform.Set(this.ActorComp.ActorLocationProxy, this.TmpRotator.Quaternion(null), this.ActorComp.ActorScaleProxy);
		this.ActorComp.SetActorTransform(this.TmpTransform.ToUeTransform(), "释放技能.转向摄像机方向", false, new ESetRotationPriority?(ESetRotationPriority.Skill));
	}

	// Token: 0x06018CD6 RID: 101590 RVA: 0x00788480 File Offset: 0x00786680
	private void TurnToSkillTarget()
	{
		if (this.SkillTarget == null)
		{
			return;
		}
		global::Vector tmpVector = this.TmpVector;
		FVectorDouble location = base.GetTargetTransform().GetLocation();
		tmpVector.FromUeVector(location);
		this.TmpVector.SubtractionEqual(this.ActorComp.ActorLocationProxy);
		MathUtils instance = MathUtils.Instance;
		global::Vector tmpVector2 = this.TmpVector;
		CharacterActorComponent actorComp = this.ActorComp;
		global::Vector vector;
		if (actorComp == null)
		{
			vector = null;
		}
		else
		{
			BaseMoveComponent moveComp = actorComp.MoveComp;
			vector = ((moveComp != null) ? moveComp.GravityUp : null);
		}
		instance.LookRotationUpFirst(tmpVector2, vector ?? global::Vector.UpVectorProxy, this.TmpRotator);
		this.ActorComp.SetActorRotation(this.TmpRotator.ToUeRotator(), "释放技能.转向技能目标", false);
	}

	// Token: 0x06018CD7 RID: 101591 RVA: 0x00788523 File Offset: 0x00786723
	private Rotator GetInputRotatorOfWorld()
	{
		return this.ActorComp.InputRotatorProxy;
	}

	// Token: 0x06018CD8 RID: 101592 RVA: 0x00788530 File Offset: 0x00786730
	private void SetSkillMoveState(int skillId, SSkillInfo info)
	{
		if (info.WalkOffLedge)
		{
			this.MoveComp.SetWalkOffLedgeRecord(false);
		}
		if (info.SkillStepUp)
		{
			this.MoveComp.SetStepUpParamsRecord(false);
		}
		if (1 == info.GroupId)
		{
			if (this.MoveComp != null && this.MoveComp.CharacterMovement.MovementMode == EMovementMode.MOVE_Custom)
			{
				byte customMovementMode = this.MoveComp.CharacterMovement.CustomMovementMode;
				if (customMovementMode == 2)
				{
					CharacterGlideComponent component = base.Entity.GetComponent<CharacterGlideComponent>();
					if (component.Valid)
					{
						component.ExitGlideState("Skill");
					}
				}
				else if (customMovementMode == 7)
				{
					CharacterGlideComponent component2 = base.Entity.GetComponent<CharacterGlideComponent>();
					if (component2.Valid)
					{
						component2.ExitSoarState(EMovementMode.MOVE_Falling, "Skill");
					}
				}
			}
			switch (this.StateComp.MoveState)
			{
			case ECharMoveState.WalkStop:
			case ECharMoveState.RunStop:
			case ECharMoveState.SprintStop:
				this.StateComp.SetMoveState(ECharMoveState.Stand);
				break;
			case ECharMoveState.Sprint:
				if (!this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.闪避"]))
				{
					int value = GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冲刺保持"];
					this.TagComp.RemoveTag(new int?(value));
					CharacterBuffComponent buffComp = this.BuffComp;
					if (buffComp != null)
					{
						int? tagId = new int?(value);
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
						defaultInterpolatedStringHandler.AppendLiteral("技能");
						defaultInterpolatedStringHandler.AppendFormatted<int>(skillId);
						defaultInterpolatedStringHandler.AppendLiteral("结束移动");
						buffComp.RemoveBuffByTag(tagId, defaultInterpolatedStringHandler.ToStringAndClear(), null);
					}
					this.StateComp.SetMoveState(ECharMoveState.Run);
				}
				break;
			}
		}
		this.MoveComp.CharacterMovement.OverrideTerminalVelocity = 99999f;
		this.MoveComp.SetFallingHorizontalMaxSpeed(99999f);
	}

	// Token: 0x06018CD9 RID: 101593 RVA: 0x007886F4 File Offset: 0x007868F4
	protected override void DoSkillEndMoveAction(SSkillInfo info)
	{
		if (info.WalkOffLedge)
		{
			this.MoveComp.SetWalkOffLedgeRecord(true);
		}
		if (info.SkillStepUp)
		{
			this.MoveComp.SetStepUpParamsRecord(true);
		}
		this.MoveComp.CharacterMovement.OverrideTerminalVelocity = 0f;
		this.MoveComp.ClearFallingHorizontalMaxSpeed();
		CharacterAnimationComponent animComp = this.AnimComp;
		if (animComp == null)
		{
			return;
		}
		animComp.CancelForceDisableAnimOptimization(EForceDisableAnimOptimization.Skill);
	}

	// Token: 0x06018CDA RID: 101594 RVA: 0x0078875A File Offset: 0x0078695A
	protected override void OnBeforePlaySkillMontage()
	{
		this.StateComp.ExitHitState("播放技能蒙太奇");
	}

	// Token: 0x06018CDB RID: 101595 RVA: 0x0078876C File Offset: 0x0078696C
	[NullableContext(2)]
	public override UAnimInstance GetMainAnimInstance()
	{
		return this.AnimComp.GetAnimInstance();
	}

	// Token: 0x06018CDC RID: 101596 RVA: 0x0078877C File Offset: 0x0078697C
	public void RollingGrounded()
	{
		this.IsMainSkillReadyEnd = false;
		this.RollingGroundEndTimer = TimerSystem.Instance.Delay(new TTimerAction(this.RollingGroundedDelay), 600f, null, null, true, 1f);
		if (this.StateComp.PositionState == ECharPositionState.Ground)
		{
			this.StateComp.SetMoveState(ECharMoveState.LandRoll);
		}
	}

	// Token: 0x06018CDD RID: 101597 RVA: 0x007887D4 File Offset: 0x007869D4
	private void RollingGroundedDelay(float delta)
	{
		if (!this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]))
		{
			CombatLog.Instance.Info(CombatLog.EDebugModule.Skill, base.Entity, "疑难杂症debug日志，RollingGroundedDelay", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.IsMainSkillReadyEnd = true;
		}
		this.RollingGroundEndTimer = null;
	}

	// Token: 0x06018CDE RID: 101598 RVA: 0x0078882C File Offset: 0x00786A2C
	public bool UpdateAllSkillRotator(float deltaSeconds)
	{
		if (!base.CheckIsLoaded() || this.MoveComp == null)
		{
			return false;
		}
		if (this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.攀爬"]))
		{
			return false;
		}
		if (!this.SkillCanRotateInternal)
		{
			return false;
		}
		if (!this.ActorComp.IsMoveAutonomousProxy)
		{
			return false;
		}
		float speed = Math.Abs(this.SkillRotateSpeedInternal);
		if (this.SkillRotateToTargetInternal)
		{
			global::Vector currentSkillRotateDirect = base.GetCurrentSkillRotateDirect();
			if (currentSkillRotateDirect.IsNearlyZero(9.999999747378752E-05))
			{
				return false;
			}
			MathUtils instance = MathUtils.Instance;
			global::Vector forward = currentSkillRotateDirect;
			CharacterActorComponent actorComp = this.ActorComp;
			global::Vector vector;
			if (actorComp == null)
			{
				vector = null;
			}
			else
			{
				BaseMoveComponent moveComp = actorComp.MoveComp;
				vector = ((moveComp != null) ? moveComp.GravityUp : null);
			}
			instance.LookRotationUpFirst(forward, vector ?? global::Vector.UpVectorProxy, this.TmpRotator);
			this.MoveComp.SmoothCharacterRotation(this.TmpRotator, speed, deltaSeconds, false, "Skill.UpdateAllSkillRotator", true);
		}
		else
		{
			this.MoveComp.SmoothCharacterRotation(this.GetInputRotatorOfWorld(), speed, deltaSeconds, false, "Skill.UpdateAllSkillRotator", true);
		}
		return true;
	}

	// Token: 0x06018CDF RID: 101599 RVA: 0x0078891F File Offset: 0x00786B1F
	public bool CheckJumpCanInterrupt()
	{
		return base.DoCheckInterrupt(1, CharacterSkillComponent._jumpPriority, null, null, null);
	}

	// Token: 0x06018CE0 RID: 101600 RVA: 0x00788930 File Offset: 0x00786B30
	public bool CheckGlideCanInterrupt()
	{
		return base.DoCheckInterrupt(1, CharacterSkillComponent._glidePriority, null, null, null);
	}

	// Token: 0x17002759 RID: 10073
	// (get) Token: 0x06018CE1 RID: 101601 RVA: 0x00788941 File Offset: 0x00786B41
	public float SkillElevationAngle
	{
		get
		{
			return this.SkillElevationAngleInternal;
		}
	}

	// Token: 0x06018CE2 RID: 101602 RVA: 0x00788949 File Offset: 0x00786B49
	public void SetSkillElevationAngle(float angle)
	{
		this.SkillElevationAngleInternal = angle;
	}

	// Token: 0x1700275A RID: 10074
	// (get) Token: 0x06018CE3 RID: 101603 RVA: 0x00788952 File Offset: 0x00786B52
	public float LastActivateSkillTime
	{
		get
		{
			return this.LastActivateSkillTimeInternal;
		}
	}

	// Token: 0x06018CE4 RID: 101604 RVA: 0x0078895A File Offset: 0x00786B5A
	public void SetLastActivateSkillTime(float time)
	{
		this.LastActivateSkillTimeInternal = time;
	}

	// Token: 0x06018CE5 RID: 101605 RVA: 0x00788963 File Offset: 0x00786B63
	public static void CreateStaticDefaultValue()
	{
		CharacterSkillComponent._isConfigInited = false;
		CharacterSkillComponent._jumpPriority = 0;
		CharacterSkillComponent._glidePriority = 0;
	}

	// Token: 0x06018CE6 RID: 101606 RVA: 0x00788977 File Offset: 0x00786B77
	public static void ResetStaticDefaultValue()
	{
		CharacterSkillComponent._isConfigInited = false;
		CharacterSkillComponent._jumpPriority = 0;
		CharacterSkillComponent._glidePriority = 0;
	}

	// Token: 0x06018CE7 RID: 101607 RVA: 0x0078898C File Offset: 0x00786B8C
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterSkillComponent characterSkillComponent = (CharacterSkillComponent)componentTemplate;
		if (characterSkillComponent.MoveComp == null)
		{
			this.MoveComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
		{
			return false;
		}
		if (characterSkillComponent.StateComp == null)
		{
			this.StateComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StateComp), "StateComp"))
		{
			return false;
		}
		if (characterSkillComponent.AnimComp == null)
		{
			this.AnimComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AnimComp), "AnimComp"))
		{
			return false;
		}
		this.IsDisableTurnToInputDir = characterSkillComponent.IsDisableTurnToInputDir;
		if (characterSkillComponent.RollingGroundEndTimer == null)
		{
			this.RollingGroundEndTimer = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RollingGroundEndTimer), "RollingGroundEndTimer"))
		{
			return false;
		}
		this.SkillElevationAngleInternal = characterSkillComponent.SkillElevationAngleInternal;
		this.LastActivateSkillTimeInternal = characterSkillComponent.LastActivateSkillTimeInternal;
		return true;
	}

	// Token: 0x1700275B RID: 10075
	// (get) Token: 0x06018CE8 RID: 101608 RVA: 0x00788A7C File Offset: 0x00786C7C
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700275C RID: 10076
	// (get) Token: 0x06018CE9 RID: 101609 RVA: 0x00788A7F File Offset: 0x00786C7F
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700275D RID: 10077
	// (get) Token: 0x06018CEA RID: 101610 RVA: 0x00788A82 File Offset: 0x00786C82
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700275E RID: 10078
	// (get) Token: 0x06018CEB RID: 101611 RVA: 0x00788A85 File Offset: 0x00786C85
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700275F RID: 10079
	// (get) Token: 0x06018CEC RID: 101612 RVA: 0x00788A88 File Offset: 0x00786C88
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002760 RID: 10080
	// (get) Token: 0x06018CED RID: 101613 RVA: 0x00788A8B File Offset: 0x00786C8B
	public override bool NeedDisableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002761 RID: 10081
	// (get) Token: 0x06018CEE RID: 101614 RVA: 0x00788A8E File Offset: 0x00786C8E
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002762 RID: 10082
	// (get) Token: 0x06018CEF RID: 101615 RVA: 0x00788A91 File Offset: 0x00786C91
	public override bool NeedChangeTimeDilationInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400D758 RID: 55128
	private const int ROLLING_GROUNDED_RECOVER_TIME = 600;

	// Token: 0x0400D759 RID: 55129
	[StaticVariableRuleIgnore]
	private static readonly Stat StatDoSkillBegin5 = Stat.Create("DoSkillBegin5 SetAnimState", "", "");

	// Token: 0x0400D75A RID: 55130
	[StaticVariableRuleIgnore]
	private static readonly Stat StatDoSkillBegin6 = Stat.Create("DoSkillBegin6 Target&Rotation", "", "");

	// Token: 0x0400D75B RID: 55131
	[StaticVariableRuleIgnore]
	private static readonly Stat StatDoSkillBegin7 = Stat.Create("DoSkillBegin7 SetMoveState", "", "");

	// Token: 0x0400D75C RID: 55132
	[Nullable(2)]
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400D75D RID: 55133
	[Nullable(2)]
	private CharacterUnifiedStateComponent StateComp;

	// Token: 0x0400D75E RID: 55134
	[Nullable(2)]
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400D75F RID: 55135
	private static bool _isConfigInited;

	// Token: 0x0400D760 RID: 55136
	private static int _jumpPriority;

	// Token: 0x0400D761 RID: 55137
	private static int _glidePriority;

	// Token: 0x0400D762 RID: 55138
	private bool IsDisableTurnToInputDir;

	// Token: 0x0400D763 RID: 55139
	[Nullable(2)]
	private TimerHandle RollingGroundEndTimer;

	// Token: 0x0400D764 RID: 55140
	private float SkillElevationAngleInternal;

	// Token: 0x0400D765 RID: 55141
	private float LastActivateSkillTimeInternal;
}

using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game;
using UnrealEngine;

// Token: 0x02003146 RID: 12614
[NullableContext(1)]
[Nullable(0)]
public class CharacterSkillComponent : BaseSkillComponent, IStaticVariableResetter
{
	// Token: 0x0601B22C RID: 111148 RVA: 0x00761708 File Offset: 0x0075F908
	static CharacterSkillComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterSkillComponent.CreateStaticDefaultValue), new Action(CharacterSkillComponent.ResetStaticDefaultValue));
	}

	// Token: 0x17002591 RID: 9617
	// (get) Token: 0x0601B22D RID: 111149 RVA: 0x0076177D File Offset: 0x0075F97D
	[Nullable(2)]
	protected new CharacterActorComponent ActorComp
	{
		[NullableContext(2)]
		get
		{
			return this.ActorComp as CharacterActorComponent;
		}
	}

	// Token: 0x0601B22E RID: 111150 RVA: 0x0076178C File Offset: 0x0075F98C
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

	// Token: 0x0601B22F RID: 111151 RVA: 0x007617F1 File Offset: 0x0075F9F1
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

	// Token: 0x0601B230 RID: 111152 RVA: 0x00761834 File Offset: 0x0075FA34
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

	// Token: 0x0601B231 RID: 111153 RVA: 0x00761884 File Offset: 0x0075FA84
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

	// Token: 0x0601B232 RID: 111154 RVA: 0x007618E4 File Offset: 0x0075FAE4
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

	// Token: 0x0601B233 RID: 111155 RVA: 0x00761958 File Offset: 0x0075FB58
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

	// Token: 0x0601B234 RID: 111156 RVA: 0x007619AC File Offset: 0x0075FBAC
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

	// Token: 0x0601B235 RID: 111157 RVA: 0x00761A6C File Offset: 0x0075FC6C
	public bool IsHasInputDir()
	{
		if (!base.CheckIsLoaded())
		{
			return false;
		}
		global::Vector inputDirectProxy = this.ActorComp.InputDirectProxy;
		return 0.0 < Math.Abs(inputDirectProxy.X) || 0.0 < Math.Abs(inputDirectProxy.Y);
	}

	// Token: 0x0601B236 RID: 111158 RVA: 0x00761AC0 File Offset: 0x0075FCC0
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

	// Token: 0x0601B237 RID: 111159 RVA: 0x00761B84 File Offset: 0x0075FD84
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

	// Token: 0x0601B238 RID: 111160 RVA: 0x00761C27 File Offset: 0x0075FE27
	private Rotator GetInputRotatorOfWorld()
	{
		return this.ActorComp.InputRotatorProxy;
	}

	// Token: 0x0601B239 RID: 111161 RVA: 0x00761C34 File Offset: 0x0075FE34
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

	// Token: 0x0601B23A RID: 111162 RVA: 0x00761DF8 File Offset: 0x0075FFF8
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

	// Token: 0x0601B23B RID: 111163 RVA: 0x00761E5E File Offset: 0x0076005E
	protected override void OnBeforePlaySkillMontage()
	{
		this.StateComp.ExitHitState("播放技能蒙太奇");
	}

	// Token: 0x0601B23C RID: 111164 RVA: 0x00761E70 File Offset: 0x00760070
	[NullableContext(2)]
	public override UAnimInstance GetMainAnimInstance()
	{
		return this.AnimComp.GetAnimInstance();
	}

	// Token: 0x0601B23D RID: 111165 RVA: 0x00761E80 File Offset: 0x00760080
	public void RollingGrounded()
	{
		this.IsMainSkillReadyEnd = false;
		this.RollingGroundEndTimer = TimerSystem.Instance.Delay(new TTimerAction(this.RollingGroundedDelay), 600f, null, null, true, 1f);
		if (this.StateComp.PositionState == ECharPositionState.Ground)
		{
			this.StateComp.SetMoveState(ECharMoveState.LandRoll);
		}
	}

	// Token: 0x0601B23E RID: 111166 RVA: 0x00761ED8 File Offset: 0x007600D8
	private void RollingGroundedDelay(float delta)
	{
		if (!this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]))
		{
			CombatLog.Instance.Info(CombatLog.EDebugModule.Skill, base.Entity, "疑难杂症debug日志，RollingGroundedDelay", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.IsMainSkillReadyEnd = true;
		}
		this.RollingGroundEndTimer = null;
	}

	// Token: 0x0601B23F RID: 111167 RVA: 0x00761F30 File Offset: 0x00760130
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

	// Token: 0x0601B240 RID: 111168 RVA: 0x00762023 File Offset: 0x00760223
	public bool CheckJumpCanInterrupt()
	{
		return base.DoCheckInterrupt(1, CharacterSkillComponent._jumpPriority, null, null, null);
	}

	// Token: 0x0601B241 RID: 111169 RVA: 0x00762034 File Offset: 0x00760234
	public bool CheckGlideCanInterrupt()
	{
		return base.DoCheckInterrupt(1, CharacterSkillComponent._glidePriority, null, null, null);
	}

	// Token: 0x17002592 RID: 9618
	// (get) Token: 0x0601B242 RID: 111170 RVA: 0x00762045 File Offset: 0x00760245
	public float SkillElevationAngle
	{
		get
		{
			return this.SkillElevationAngleInternal;
		}
	}

	// Token: 0x0601B243 RID: 111171 RVA: 0x0076204D File Offset: 0x0076024D
	public void SetSkillElevationAngle(float angle)
	{
		this.SkillElevationAngleInternal = angle;
	}

	// Token: 0x17002593 RID: 9619
	// (get) Token: 0x0601B244 RID: 111172 RVA: 0x00762056 File Offset: 0x00760256
	public float LastActivateSkillTime
	{
		get
		{
			return this.LastActivateSkillTimeInternal;
		}
	}

	// Token: 0x0601B245 RID: 111173 RVA: 0x0076205E File Offset: 0x0076025E
	public void SetLastActivateSkillTime(float time)
	{
		this.LastActivateSkillTimeInternal = time;
	}

	// Token: 0x0601B246 RID: 111174 RVA: 0x00762067 File Offset: 0x00760267
	public static void CreateStaticDefaultValue()
	{
		CharacterSkillComponent._isConfigInited = false;
		CharacterSkillComponent._jumpPriority = 0;
		CharacterSkillComponent._glidePriority = 0;
	}

	// Token: 0x0601B247 RID: 111175 RVA: 0x0076207B File Offset: 0x0076027B
	public static void ResetStaticDefaultValue()
	{
		CharacterSkillComponent._isConfigInited = false;
		CharacterSkillComponent._jumpPriority = 0;
		CharacterSkillComponent._glidePriority = 0;
	}

	// Token: 0x0601B248 RID: 111176 RVA: 0x00762090 File Offset: 0x00760290
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterSkillComponent characterSkillComponent = (CharacterSkillComponent)componentTemplate;
		if (base.CanResetComponentProperty("MoveComp"))
		{
			if (characterSkillComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterMoveComponent>(this.MoveComp), "MoveComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("StateComp"))
		{
			if (characterSkillComponent.StateComp == null)
			{
				this.StateComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterUnifiedStateComponent>(this.StateComp), "StateComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AnimComp"))
		{
			if (characterSkillComponent.AnimComp == null)
			{
				this.AnimComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterAnimationComponent>(this.AnimComp), "AnimComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("IsDisableTurnToInputDir"))
		{
			this.IsDisableTurnToInputDir = characterSkillComponent.IsDisableTurnToInputDir;
		}
		if (base.CanResetComponentProperty("RollingGroundEndTimer"))
		{
			if (characterSkillComponent.RollingGroundEndTimer == null)
			{
				this.RollingGroundEndTimer = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.RollingGroundEndTimer), "RollingGroundEndTimer"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SkillElevationAngleInternal"))
		{
			this.SkillElevationAngleInternal = characterSkillComponent.SkillElevationAngleInternal;
		}
		if (base.CanResetComponentProperty("LastActivateSkillTimeInternal"))
		{
			this.LastActivateSkillTimeInternal = characterSkillComponent.LastActivateSkillTimeInternal;
		}
		return true;
	}

	// Token: 0x0400D31A RID: 54042
	private const int ROLLING_GROUNDED_RECOVER_TIME = 600;

	// Token: 0x0400D31B RID: 54043
	[StaticVariableRuleIgnore]
	private static readonly Stat StatDoSkillBegin5 = Stat.Create("DoSkillBegin5 SetAnimState", "", "");

	// Token: 0x0400D31C RID: 54044
	[StaticVariableRuleIgnore]
	private static readonly Stat StatDoSkillBegin6 = Stat.Create("DoSkillBegin6 Target&Rotation", "", "");

	// Token: 0x0400D31D RID: 54045
	[StaticVariableRuleIgnore]
	private static readonly Stat StatDoSkillBegin7 = Stat.Create("DoSkillBegin7 SetMoveState", "", "");

	// Token: 0x0400D31E RID: 54046
	[Nullable(2)]
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400D31F RID: 54047
	[Nullable(2)]
	private CharacterUnifiedStateComponent StateComp;

	// Token: 0x0400D320 RID: 54048
	[Nullable(2)]
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400D321 RID: 54049
	private static bool _isConfigInited;

	// Token: 0x0400D322 RID: 54050
	private static int _jumpPriority;

	// Token: 0x0400D323 RID: 54051
	private static int _glidePriority;

	// Token: 0x0400D324 RID: 54052
	private bool IsDisableTurnToInputDir;

	// Token: 0x0400D325 RID: 54053
	[Nullable(2)]
	private TimerHandle RollingGroundEndTimer;

	// Token: 0x0400D326 RID: 54054
	private float SkillElevationAngleInternal;

	// Token: 0x0400D327 RID: 54055
	private float LastActivateSkillTimeInternal;
}

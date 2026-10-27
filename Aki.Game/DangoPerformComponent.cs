using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.NPC.Tuanzi;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using UnrealEngine;

// Token: 0x020030A1 RID: 12449
[NullableContext(1)]
[Nullable(0)]
public class DangoPerformComponent : StackableChessComponent
{
	// Token: 0x170024A1 RID: 9377
	// (get) Token: 0x0601AAB6 RID: 109238 RVA: 0x0072E144 File Offset: 0x0072C344
	// (set) Token: 0x0601AAB7 RID: 109239 RVA: 0x0072E151 File Offset: 0x0072C351
	[Nullable(2)]
	protected new BaseCharacterComponent ActorComp
	{
		[NullableContext(2)]
		get
		{
			return this.ActorComp as BaseCharacterComponent;
		}
		[NullableContext(2)]
		set
		{
			this.ActorComp = value;
		}
	}

	// Token: 0x0601AAB8 RID: 109240 RVA: 0x0072E15A File Offset: 0x0072C35A
	protected override bool OnStart()
	{
		if (!base.OnStart())
		{
			return false;
		}
		this.ActorComp = base.Entity.CheckGetComponent<BaseCharacterComponent>();
		return true;
	}

	// Token: 0x0601AAB9 RID: 109241 RVA: 0x0072E178 File Offset: 0x0072C378
	protected override void OnActivate()
	{
		CharacterAnimationComponent component = base.Entity.GetComponent<CharacterAnimationComponent>();
		UAnimInstance uanimInstance = (component != null) ? component.MainAnimInstance : null;
		if (uanimInstance != null && UKuroStaticLibrary.IsObjectClassByName(uanimInstance, new FName("ABP_TuanziNPC_C")))
		{
			this.AnimInstance = uanimInstance;
		}
		BaseCharacterComponent actorComp = this.ActorComp;
		AActor aactor = (actorComp != null) ? actorComp.Owner : null;
		if (aactor == null || !aactor.IsValid())
		{
			return;
		}
		this.TempVector.Set(1.2000000476837158, 1.2000000476837158, 1.2000000476837158);
		aactor.D_SetActorScale3D(this.TempVector.ToUeVector(false));
		UCharacterMovementComponent ucharacterMovementComponent = aactor.GetComponentByClass(UCharacterMovementComponent.StaticClass()) as UCharacterMovementComponent;
		if (ucharacterMovementComponent != null)
		{
			ucharacterMovementComponent.SetComponentTickEnabled(false);
		}
	}

	// Token: 0x0601AABA RID: 109242 RVA: 0x0072E230 File Offset: 0x0072C430
	protected override void OnTick(float delta)
	{
		if (this.MoveState == DangoPerformComponent.EMoveState.Idle)
		{
			return;
		}
		DangoGlobalConfig config = DangoGlobalModel.Instance.Config;
		if (config == null)
		{
			return;
		}
		if (this.CurrentMoveTime >= (float)config.MoveTotalTime)
		{
			this.MoveEnd();
			return;
		}
		this.CurrentMoveTime += delta;
		if (this.CurrentMoveTime <= (float)config.MoveStartingTime)
		{
			return;
		}
		if (this.MoveState != DangoPerformComponent.EMoveState.Starting && this.CurrentMoveTime >= (float)(config.MoveStartingTime + config.MoveTime))
		{
			if (this.MoveState == DangoPerformComponent.EMoveState.Moving)
			{
				this.ActorComp.SetActorLocationAndRotation(this.MoveTargetLocation.ToUeVector(false), this.MoveTargetRotator.ToUeRotator(), "ChessMove", false, null);
				this.MoveState = DangoPerformComponent.EMoveState.Recovering;
			}
			return;
		}
		if (this.MoveState != DangoPerformComponent.EMoveState.Moving)
		{
			this.MoveState = DangoPerformComponent.EMoveState.Moving;
			DangoGlobalController.Instance.ApplyDangoMoveCamera(this.MoveTargetLocation);
		}
		float num = MathCommon.Clamp((this.CurrentMoveTime - (float)config.MoveStartingTime) / (float)config.MoveTime, 0f, 1f);
		Vector.Lerp(this.MoveStartLocation, this.MoveTargetLocation, (double)num, this.TempVector);
		float powerCurveValue = this.GetPowerCurveValue(num, 2f);
		float floatValue;
		if (this.SignOffsetRate > 0f)
		{
			floatValue = config.MoveRiseCurve.GetFloatValue(num);
		}
		else
		{
			floatValue = config.MoveFallCurve.GetFloatValue(num);
		}
		float num2 = Math.Abs(this.SignOffsetRate);
		float num3 = (powerCurveValue * (1f - num2) + floatValue * num2) * (float)config.MoveBaseHeightOffset;
		this.TempVector.Z += (double)num3;
		Rotator actorRotationProxy = this.ActorComp.ActorRotationProxy;
		if (!actorRotationProxy.Equals2(this.MoveTargetRotator, 0.0001f))
		{
			this.TempRotator.DeepCopy(this.MoveTargetRotator);
			MathUtils.Instance.RotatorInterpConstantTo(actorRotationProxy, this.TempRotator, delta * 0.001f, (float)config.MoveRotateSpeed, this.TempRotator);
		}
		this.ActorComp.SetActorLocationAndRotation(this.TempVector.ToUeVector(false), this.TempRotator.ToUeRotator(), "ChessMove", false, null);
	}

	// Token: 0x0601AABB RID: 109243 RVA: 0x0072E448 File Offset: 0x0072C648
	private float GetPowerCurveValue(float key, float pow)
	{
		return 1f - (float)Math.Pow((double)Math.Abs(2f * key - 1f), (double)pow);
	}

	// Token: 0x0601AABC RID: 109244 RVA: 0x0072E46C File Offset: 0x0072C66C
	[NullableContext(2)]
	public override Vector GetStackableLocation()
	{
		BaseCharacterComponent actorComp = this.ActorComp;
		if (actorComp == null || !actorComp.Valid)
		{
			return null;
		}
		this.TempVector.DeepCopy(this.ActorComp.ActorLocationProxy);
		DangoGlobalConfig config = DangoGlobalModel.Instance.Config;
		Number a = (config != null) ? config.StackInterval : 0;
		Vector tempVector = this.TempVector;
		tempVector.Z += a * 1.2f;
		return this.TempVector;
	}

	// Token: 0x0601AABD RID: 109245 RVA: 0x0072E4FC File Offset: 0x0072C6FC
	public override void OnPreviousMoveStateChange(IStackableChessAgent agent, bool isMoving, bool previousIsForward, bool isSameDirection)
	{
		if (!isMoving)
		{
			this.JumpHeight = 0f;
			this.JumpDistance = 0f;
			this.ReturnStand();
			return;
		}
		this.JumpHeight = ((DangoPerformComponent)agent).JumpHeight;
		this.JumpDistance = ((DangoPerformComponent)agent).JumpDistance;
		if (isSameDirection ? previousIsForward : (!previousIsForward))
		{
			this.StartJumpPerform(this.JumpHeight, this.JumpDistance);
			return;
		}
		this.StartJumpBackwardPerform(this.JumpHeight, this.JumpDistance);
	}

	// Token: 0x0601AABE RID: 109246 RVA: 0x0072E580 File Offset: 0x0072C780
	public override void Move(Vector location, Rotator rotator, bool performIsForward, Action finishCallback)
	{
		BaseCharacterComponent actorComp = this.ActorComp;
		if (actorComp == null || !actorComp.Valid)
		{
			this.MoveEnd();
			return;
		}
		DangoGlobalConfig config = DangoGlobalModel.Instance.Config;
		if (config == null)
		{
			return;
		}
		this.MoveStartLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
		this.MoveTargetLocation.DeepCopy(location);
		this.MoveTargetLocation.Z += (double)(this.ActorComp.HalfHeight * 1.2f);
		this.MoveTargetRotator.DeepCopy(rotator);
		this.MoveFinishCallback = finishCallback;
		this.MoveState = DangoPerformComponent.EMoveState.Starting;
		this.CurrentMoveTime = 0f;
		double num = this.MoveTargetLocation.Z - this.MoveStartLocation.Z;
		if (num >= 0.0)
		{
			this.SignOffsetRate = (float)MathCommon.Clamp(num / (double)config.MaxRiseHeightEdge, 0.0, 1.0);
		}
		else
		{
			this.SignOffsetRate = (float)MathCommon.Clamp(num / (double)config.MaxFallHeightEdge, -1.0, 0.0);
		}
		this.JumpHeight = (float)num;
		this.JumpDistance = (float)Vector.Distance(this.MoveTargetLocation, this.MoveStartLocation);
		if (performIsForward)
		{
			this.StartJumpPerform(this.JumpHeight, this.JumpDistance);
			return;
		}
		this.StartJumpBackwardPerform(this.JumpHeight, this.JumpDistance);
	}

	// Token: 0x0601AABF RID: 109247 RVA: 0x0072E6E4 File Offset: 0x0072C8E4
	public override void Teleport(Vector location, Rotator rotator)
	{
		if (this.ActorComp == null)
		{
			return;
		}
		this.TempVector.DeepCopy(location);
		this.TempVector.Z += (double)(this.ActorComp.HalfHeight * 1.2f);
		this.ActorComp.SetActorLocationAndRotation(this.TempVector.ToUeVector(false), rotator.ToUeRotator(), "ChessTeleport", false, null);
	}

	// Token: 0x0601AAC0 RID: 109248 RVA: 0x0072E758 File Offset: 0x0072C958
	private void MoveEnd()
	{
		this.MoveState = DangoPerformComponent.EMoveState.Idle;
		this.CurrentMoveTime = 0f;
		this.ReturnStand();
		this.JumpHeight = 0f;
		this.JumpDistance = 0f;
		TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			Action moveFinishCallback = this.MoveFinishCallback;
			if (moveFinishCallback == null)
			{
				return;
			}
			moveFinishCallback();
		}, 100f, null, null, true, 1f);
	}

	// Token: 0x0601AAC1 RID: 109249 RVA: 0x0072E7B8 File Offset: 0x0072C9B8
	public override bool IsPerformRecursion(int type)
	{
		EDangoPerformType type2;
		if (!Enum.TryParse<EDangoPerformType>(type.ToString(), out type2))
		{
			return false;
		}
		DangoGlobalConfig config = DangoGlobalModel.Instance.Config;
		if (config == null)
		{
			return false;
		}
		DangoPerformConfig performConfig = config.GetPerformConfig(type2);
		EDangoActionTargetType? edangoActionTargetType = (performConfig != null) ? new EDangoActionTargetType?(performConfig.ActionTargetType) : null;
		EDangoActionTargetType edangoActionTargetType2 = EDangoActionTargetType.自身与堆叠上方团子;
		return edangoActionTargetType.GetValueOrDefault() == edangoActionTargetType2 & edangoActionTargetType != null;
	}

	// Token: 0x0601AAC2 RID: 109250 RVA: 0x0072E81C File Offset: 0x0072CA1C
	public override void Perform(int type, [Nullable(2)] Vector pointLocation, Action finishCallback)
	{
		DangoPerformConfig dangoPerformConfig = null;
		EDangoPerformType type2;
		if (Enum.TryParse<EDangoPerformType>(type.ToString(), out type2))
		{
			DangoGlobalConfig config = DangoGlobalModel.Instance.Config;
			dangoPerformConfig = ((config != null) ? config.GetPerformConfig(type2) : null);
		}
		if (dangoPerformConfig != null)
		{
			BaseCharacterComponent actorComp = this.ActorComp;
			if (actorComp != null && actorComp.Valid)
			{
				Vector actorLocationProxy = this.ActorComp.ActorLocationProxy;
				using (List<DangoPerformEffectConfig>.Enumerator enumerator = dangoPerformConfig.EffectConfigList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						DangoPerformEffectConfig effectConfig = enumerator.Current;
						Vector location = Vector.Create();
						location.DeepCopy(actorLocationProxy);
						if (effectConfig.PerformLocationType == EDangoPerformLocationType.当前底座位置 && pointLocation != null)
						{
							location.DeepCopy(pointLocation);
						}
						location.AdditionEqual(effectConfig.LocationOffset);
						FName? attachSocket = null;
						if (effectConfig.PerformLocationType == EDangoPerformLocationType.跟随团子骨骼)
						{
							attachSocket = effectConfig.AttachSocket;
						}
						int delayTime = effectConfig.DelayTime;
						if (delayTime <= 0)
						{
							this.SpawnEffect(location, effectConfig.EffectPath, attachSocket);
						}
						else
						{
							TimerSystem.FlowTimeInstance.Delay(delegate(float _)
							{
								this.SpawnEffect(location, effectConfig.EffectPath, attachSocket);
							}, (float)delayTime, null, null, true, 1f);
						}
					}
				}
				this.StartActionPerform(dangoPerformConfig.ActionType);
				TTimerAction <>9__2;
				TimerSystem.FlowTimeInstance.Delay(delegate(float _)
				{
					this.ReturnStand();
					TimerSystemInstance flowTimeInstance = TimerSystem.FlowTimeInstance;
					TTimerAction action;
					if ((action = <>9__2) == null)
					{
						action = (<>9__2 = delegate(float _)
						{
							finishCallback();
						});
					}
					flowTimeInstance.Delay(action, 100f, null, null, true, 1f);
				}, (float)dangoPerformConfig.Duration, null, null, true, 1f);
				return;
			}
		}
		finishCallback();
	}

	// Token: 0x0601AAC3 RID: 109251 RVA: 0x0072EA0C File Offset: 0x0072CC0C
	public override void OnPreviousPerformStateChange(IStackableChessAgent agent, int type, bool isPerforming)
	{
		if (!isPerforming)
		{
			this.ReturnStand();
			return;
		}
		DangoPerformConfig dangoPerformConfig = null;
		EDangoPerformType type2;
		if (Enum.TryParse<EDangoPerformType>(type.ToString(), out type2))
		{
			DangoGlobalConfig config = DangoGlobalModel.Instance.Config;
			dangoPerformConfig = ((config != null) ? config.GetPerformConfig(type2) : null);
		}
		if (dangoPerformConfig != null)
		{
			this.StartActionPerform(dangoPerformConfig.RecursionActionType);
		}
	}

	// Token: 0x0601AAC4 RID: 109252 RVA: 0x0072EA5C File Offset: 0x0072CC5C
	private void StartJumpPerform(float jumpHeight, float jumpDistance)
	{
		UAnimInstance animInstance = this.AnimInstance;
		if (animInstance != null && animInstance.IsValid())
		{
			(this.AnimInstance as ABP_TuanziNPC_C).StartJumpWithParams(jumpHeight, jumpDistance);
		}
	}

	// Token: 0x0601AAC5 RID: 109253 RVA: 0x0072EA84 File Offset: 0x0072CC84
	private void StartJumpBackwardPerform(float jumpHeight, float jumpDistance)
	{
		UAnimInstance animInstance = this.AnimInstance;
		if (animInstance != null && animInstance.IsValid())
		{
			(this.AnimInstance as ABP_TuanziNPC_C).StartJumpBackwardWithParams(jumpHeight, jumpDistance);
		}
	}

	// Token: 0x0601AAC6 RID: 109254 RVA: 0x0072EAAC File Offset: 0x0072CCAC
	private void StartActionPerform(EDangoActionPerformType type)
	{
		UAnimInstance animInstance = this.AnimInstance;
		if (animInstance != null && animInstance.IsValid())
		{
			(this.AnimInstance as ABP_TuanziNPC_C).StartActionPerform(type);
		}
	}

	// Token: 0x0601AAC7 RID: 109255 RVA: 0x0072EAD3 File Offset: 0x0072CCD3
	private void ReturnStand()
	{
		UAnimInstance animInstance = this.AnimInstance;
		if (animInstance != null && animInstance.IsValid())
		{
			(this.AnimInstance as ABP_TuanziNPC_C).ReturnStand();
		}
	}

	// Token: 0x0601AAC8 RID: 109256 RVA: 0x0072EAFC File Offset: 0x0072CCFC
	protected override FName? GetAttachSocketName()
	{
		DangoGlobalConfig config = DangoGlobalModel.Instance.Config;
		if (config == null)
		{
			return null;
		}
		return config.AttachSocketName;
	}

	// Token: 0x0601AAC9 RID: 109257 RVA: 0x0072EB28 File Offset: 0x0072CD28
	private void SpawnEffect(Vector location, string effectPath, FName? socketName)
	{
		BaseCharacterComponent actorComp = this.ActorComp;
		USkeletalMeshComponent uskeletalMeshComponent = (actorComp != null) ? actorComp.SkeletalMesh : null;
		if (uskeletalMeshComponent == null || !uskeletalMeshComponent.IsValid())
		{
			return;
		}
		EffectSystem instance = EffectSystem.Instance;
		UObject world = GlobalData.World;
		FVectorDouble fvectorDouble = location.ToUeVector(false);
		FVector fvector = Vector.OneVectorDouble;
		FTransformDouble? ftransformDouble = new FTransformDouble?(new FTransformDouble(ref Rotator.ZeroRotator, ref fvectorDouble, ref fvector));
		int id = instance.SpawnEffect(world, ftransformDouble, effectPath, "[DangoPerformComponent.SpawnEffect]", new EffectContext(new int?(base.Entity.Id), null, false), EEffectType.Scene, null, null, null, false, false);
		if (!FNameUtil.IsNothing(socketName))
		{
			EffectSystem.Instance.GetEffectActor(id).K2_AttachToComponent(uskeletalMeshComponent, socketName, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false);
		}
	}

	// Token: 0x0601AACA RID: 109258 RVA: 0x0072EBD0 File Offset: 0x0072CDD0
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		DangoPerformComponent dangoPerformComponent = (DangoPerformComponent)componentTemplate;
		if (base.CanResetComponentProperty("AnimInstance"))
		{
			if (dangoPerformComponent.AnimInstance == null)
			{
				this.AnimInstance = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UAnimInstance>(this.AnimInstance), "AnimInstance"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("IsBeginJump"))
		{
			this.IsBeginJump = dangoPerformComponent.IsBeginJump;
		}
		if (base.CanResetComponentProperty("IsInterruptJump"))
		{
			this.IsInterruptJump = dangoPerformComponent.IsInterruptJump;
		}
		if (base.CanResetComponentProperty("JumpHeight"))
		{
			this.JumpHeight = dangoPerformComponent.JumpHeight;
		}
		if (base.CanResetComponentProperty("JumpDistance"))
		{
			this.JumpDistance = dangoPerformComponent.JumpDistance;
		}
		if (base.CanResetComponentProperty("MoveState"))
		{
			this.MoveState = dangoPerformComponent.MoveState;
		}
		if (base.CanResetComponentProperty("CurrentMoveTime"))
		{
			this.CurrentMoveTime = dangoPerformComponent.CurrentMoveTime;
		}
		if (base.CanResetComponentProperty("SignOffsetRate"))
		{
			this.SignOffsetRate = dangoPerformComponent.SignOffsetRate;
		}
		if (base.CanResetComponentProperty("MoveFinishCallback"))
		{
			if (dangoPerformComponent.MoveFinishCallback == null)
			{
				this.MoveFinishCallback = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Action>(this.MoveFinishCallback), "MoveFinishCallback"))
			{
				return false;
			}
		}
		return (!base.CanResetComponentProperty("MoveStartLocation") || dangoPerformComponent.MoveStartLocation == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.MoveStartLocation), "MoveStartLocation")) && (!base.CanResetComponentProperty("MoveTargetLocation") || dangoPerformComponent.MoveTargetLocation == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.MoveTargetLocation), "MoveTargetLocation")) && (!base.CanResetComponentProperty("MoveTargetRotator") || dangoPerformComponent.MoveTargetRotator == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Rotator>(this.MoveTargetRotator), "MoveTargetRotator")) && (!base.CanResetComponentProperty("TempVector") || dangoPerformComponent.TempVector == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TempVector), "TempVector")) && (!base.CanResetComponentProperty("TempRotator") || dangoPerformComponent.TempRotator == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Rotator>(this.TempRotator), "TempRotator"));
	}

	// Token: 0x0400CDB2 RID: 52658
	public const int STAND_DELAY_TIME = 100;

	// Token: 0x0400CDB3 RID: 52659
	public const float SCALE_SIZE = 1.2f;

	// Token: 0x0400CDB4 RID: 52660
	[Nullable(2)]
	private UAnimInstance AnimInstance;

	// Token: 0x0400CDB5 RID: 52661
	public bool IsBeginJump;

	// Token: 0x0400CDB6 RID: 52662
	public bool IsInterruptJump;

	// Token: 0x0400CDB7 RID: 52663
	public float JumpHeight;

	// Token: 0x0400CDB8 RID: 52664
	public float JumpDistance;

	// Token: 0x0400CDB9 RID: 52665
	private DangoPerformComponent.EMoveState MoveState;

	// Token: 0x0400CDBA RID: 52666
	private float CurrentMoveTime;

	// Token: 0x0400CDBB RID: 52667
	private float SignOffsetRate;

	// Token: 0x0400CDBC RID: 52668
	[Nullable(2)]
	private Action MoveFinishCallback;

	// Token: 0x0400CDBD RID: 52669
	private readonly Vector MoveStartLocation = Vector.Create();

	// Token: 0x0400CDBE RID: 52670
	private readonly Vector MoveTargetLocation = Vector.Create();

	// Token: 0x0400CDBF RID: 52671
	private readonly Rotator MoveTargetRotator = Rotator.Create();

	// Token: 0x0400CDC0 RID: 52672
	private readonly Vector TempVector = Vector.Create();

	// Token: 0x0400CDC1 RID: 52673
	private readonly Rotator TempRotator = Rotator.Create();

	// Token: 0x0200966B RID: 38507
	[NullableContext(0)]
	public enum EMoveState
	{
		// Token: 0x040303D8 RID: 197592
		Idle,
		// Token: 0x040303D9 RID: 197593
		Starting,
		// Token: 0x040303DA RID: 197594
		Moving,
		// Token: 0x040303DB RID: 197595
		Recovering
	}
}

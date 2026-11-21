using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.NPC.Tuanzi;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using UnrealEngine;

// Token: 0x020025F8 RID: 9720
[NullableContext(1)]
[Nullable(0)]
public class DangoPerformComponent : StackableChessComponent
{
	// Token: 0x1700261C RID: 9756
	// (get) Token: 0x060184BC RID: 99516 RVA: 0x0075372C File Offset: 0x0075192C
	// (set) Token: 0x060184BD RID: 99517 RVA: 0x00753739 File Offset: 0x00751939
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

	// Token: 0x060184BE RID: 99518 RVA: 0x00753742 File Offset: 0x00751942
	protected override bool OnStart()
	{
		if (!base.OnStart())
		{
			return false;
		}
		this.ActorComp = base.Entity.CheckGetComponent<BaseCharacterComponent>();
		return true;
	}

	// Token: 0x060184BF RID: 99519 RVA: 0x00753760 File Offset: 0x00751960
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

	// Token: 0x060184C0 RID: 99520 RVA: 0x00753818 File Offset: 0x00751A18
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

	// Token: 0x060184C1 RID: 99521 RVA: 0x00753A30 File Offset: 0x00751C30
	private float GetPowerCurveValue(float key, float pow)
	{
		return 1f - (float)Math.Pow((double)Math.Abs(2f * key - 1f), (double)pow);
	}

	// Token: 0x060184C2 RID: 99522 RVA: 0x00753A54 File Offset: 0x00751C54
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

	// Token: 0x060184C3 RID: 99523 RVA: 0x00753AE4 File Offset: 0x00751CE4
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

	// Token: 0x060184C4 RID: 99524 RVA: 0x00753B68 File Offset: 0x00751D68
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

	// Token: 0x060184C5 RID: 99525 RVA: 0x00753CCC File Offset: 0x00751ECC
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

	// Token: 0x060184C6 RID: 99526 RVA: 0x00753D40 File Offset: 0x00751F40
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

	// Token: 0x060184C7 RID: 99527 RVA: 0x00753DA0 File Offset: 0x00751FA0
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

	// Token: 0x060184C8 RID: 99528 RVA: 0x00753E04 File Offset: 0x00752004
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

	// Token: 0x060184C9 RID: 99529 RVA: 0x00753FF4 File Offset: 0x007521F4
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

	// Token: 0x060184CA RID: 99530 RVA: 0x00754044 File Offset: 0x00752244
	private void StartJumpPerform(float jumpHeight, float jumpDistance)
	{
		UAnimInstance animInstance = this.AnimInstance;
		if (animInstance != null && animInstance.IsValid())
		{
			(this.AnimInstance as ABP_TuanziNPC_C).StartJumpWithParams(jumpHeight, jumpDistance);
		}
	}

	// Token: 0x060184CB RID: 99531 RVA: 0x0075406C File Offset: 0x0075226C
	private void StartJumpBackwardPerform(float jumpHeight, float jumpDistance)
	{
		UAnimInstance animInstance = this.AnimInstance;
		if (animInstance != null && animInstance.IsValid())
		{
			(this.AnimInstance as ABP_TuanziNPC_C).StartJumpBackwardWithParams(jumpHeight, jumpDistance);
		}
	}

	// Token: 0x060184CC RID: 99532 RVA: 0x00754094 File Offset: 0x00752294
	private void StartActionPerform(EDangoActionPerformType type)
	{
		UAnimInstance animInstance = this.AnimInstance;
		if (animInstance != null && animInstance.IsValid())
		{
			(this.AnimInstance as ABP_TuanziNPC_C).StartActionPerform(type);
		}
	}

	// Token: 0x060184CD RID: 99533 RVA: 0x007540BB File Offset: 0x007522BB
	private void ReturnStand()
	{
		UAnimInstance animInstance = this.AnimInstance;
		if (animInstance != null && animInstance.IsValid())
		{
			(this.AnimInstance as ABP_TuanziNPC_C).ReturnStand();
		}
	}

	// Token: 0x060184CE RID: 99534 RVA: 0x007540E4 File Offset: 0x007522E4
	protected override FName? GetAttachSocketName()
	{
		DangoGlobalConfig config = DangoGlobalModel.Instance.Config;
		if (config == null)
		{
			return null;
		}
		return config.AttachSocketName;
	}

	// Token: 0x060184CF RID: 99535 RVA: 0x00754110 File Offset: 0x00752310
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

	// Token: 0x060184D0 RID: 99536 RVA: 0x007541B8 File Offset: 0x007523B8
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		DangoPerformComponent dangoPerformComponent = (DangoPerformComponent)componentTemplate;
		if (dangoPerformComponent.AnimInstance == null)
		{
			this.AnimInstance = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AnimInstance), "AnimInstance"))
		{
			return false;
		}
		this.IsBeginJump = dangoPerformComponent.IsBeginJump;
		this.IsInterruptJump = dangoPerformComponent.IsInterruptJump;
		this.JumpHeight = dangoPerformComponent.JumpHeight;
		this.JumpDistance = dangoPerformComponent.JumpDistance;
		this.MoveState = dangoPerformComponent.MoveState;
		this.CurrentMoveTime = dangoPerformComponent.CurrentMoveTime;
		this.SignOffsetRate = dangoPerformComponent.SignOffsetRate;
		if (dangoPerformComponent.MoveFinishCallback == null)
		{
			this.MoveFinishCallback = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveFinishCallback), "MoveFinishCallback"))
		{
			return false;
		}
		return (dangoPerformComponent.MoveStartLocation == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveStartLocation), "MoveStartLocation")) && (dangoPerformComponent.MoveTargetLocation == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveTargetLocation), "MoveTargetLocation")) && (dangoPerformComponent.MoveTargetRotator == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveTargetRotator), "MoveTargetRotator")) && (dangoPerformComponent.TempVector == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector), "TempVector")) && (dangoPerformComponent.TempRotator == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempRotator), "TempRotator"));
	}

	// Token: 0x1700261D RID: 9757
	// (get) Token: 0x060184D1 RID: 99537 RVA: 0x0075432C File Offset: 0x0075252C
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700261E RID: 9758
	// (get) Token: 0x060184D2 RID: 99538 RVA: 0x0075432F File Offset: 0x0075252F
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700261F RID: 9759
	// (get) Token: 0x060184D3 RID: 99539 RVA: 0x00754332 File Offset: 0x00752532
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400D195 RID: 53653
	public const int STAND_DELAY_TIME = 100;

	// Token: 0x0400D196 RID: 53654
	public const float SCALE_SIZE = 1.2f;

	// Token: 0x0400D197 RID: 53655
	[Nullable(2)]
	private UAnimInstance AnimInstance;

	// Token: 0x0400D198 RID: 53656
	public bool IsBeginJump;

	// Token: 0x0400D199 RID: 53657
	public bool IsInterruptJump;

	// Token: 0x0400D19A RID: 53658
	public float JumpHeight;

	// Token: 0x0400D19B RID: 53659
	public float JumpDistance;

	// Token: 0x0400D19C RID: 53660
	private DangoPerformComponent.EMoveState MoveState;

	// Token: 0x0400D19D RID: 53661
	private float CurrentMoveTime;

	// Token: 0x0400D19E RID: 53662
	private float SignOffsetRate;

	// Token: 0x0400D19F RID: 53663
	[Nullable(2)]
	private Action MoveFinishCallback;

	// Token: 0x0400D1A0 RID: 53664
	private readonly Vector MoveStartLocation = Vector.Create();

	// Token: 0x0400D1A1 RID: 53665
	private readonly Vector MoveTargetLocation = Vector.Create();

	// Token: 0x0400D1A2 RID: 53666
	private readonly Rotator MoveTargetRotator = Rotator.Create();

	// Token: 0x0400D1A3 RID: 53667
	private readonly Vector TempVector = Vector.Create();

	// Token: 0x0400D1A4 RID: 53668
	private readonly Rotator TempRotator = Rotator.Create();

	// Token: 0x0200888C RID: 34956
	[NullableContext(0)]
	public enum EMoveState
	{
		// Token: 0x0402BA65 RID: 178789
		Idle,
		// Token: 0x0402BA66 RID: 178790
		Starting,
		// Token: 0x0402BA67 RID: 178791
		Moving,
		// Token: 0x0402BA68 RID: 178792
		Recovering
	}
}

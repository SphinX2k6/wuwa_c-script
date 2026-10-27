using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02003080 RID: 12416
[NullableContext(1)]
[Nullable(0)]
public class CharacterPendulumComponent : EntityComponent
{
	// Token: 0x1700247C RID: 9340
	// (get) Token: 0x0601A851 RID: 108625 RVA: 0x007192FC File Offset: 0x007174FC
	// (set) Token: 0x0601A852 RID: 108626 RVA: 0x00719304 File Offset: 0x00717504
	public bool Hooked
	{
		get
		{
			return this.HookedInternal;
		}
		set
		{
			this.HookedInternal = value;
		}
	}

	// Token: 0x1700247D RID: 9341
	// (get) Token: 0x0601A853 RID: 108627 RVA: 0x0071930D File Offset: 0x0071750D
	// (set) Token: 0x0601A854 RID: 108628 RVA: 0x00719315 File Offset: 0x00717515
	public double UpLength
	{
		get
		{
			return this.UpLengthInternal;
		}
		set
		{
			this.UpLengthInternal = value;
		}
	}

	// Token: 0x1700247E RID: 9342
	// (get) Token: 0x0601A855 RID: 108629 RVA: 0x0071931E File Offset: 0x0071751E
	// (set) Token: 0x0601A856 RID: 108630 RVA: 0x0071932C File Offset: 0x0071752C
	public FVectorDouble GrabPoint
	{
		get
		{
			return this.GrabPointInternal.ToUeVector(false);
		}
		set
		{
			this.GrabPointInternal.FromUeVector(value);
		}
	}

	// Token: 0x1700247F RID: 9343
	// (get) Token: 0x0601A857 RID: 108631 RVA: 0x0071933B File Offset: 0x0071753B
	// (set) Token: 0x0601A858 RID: 108632 RVA: 0x00719343 File Offset: 0x00717543
	public string SocketName
	{
		get
		{
			return this.SocketNameInternal;
		}
		set
		{
			this.SocketNameInternal = value;
		}
	}

	// Token: 0x17002480 RID: 9344
	// (get) Token: 0x0601A859 RID: 108633 RVA: 0x0071934C File Offset: 0x0071754C
	// (set) Token: 0x0601A85A RID: 108634 RVA: 0x00719354 File Offset: 0x00717554
	public double RopeForce
	{
		get
		{
			return this.RopeForceInternal;
		}
		set
		{
			this.RopeForceInternal = value;
		}
	}

	// Token: 0x17002481 RID: 9345
	// (get) Token: 0x0601A85B RID: 108635 RVA: 0x0071935D File Offset: 0x0071755D
	// (set) Token: 0x0601A85C RID: 108636 RVA: 0x00719365 File Offset: 0x00717565
	public double DistanceRopeToActor
	{
		get
		{
			return this.DistanceRopeToActorInternal;
		}
		set
		{
			this.DistanceRopeToActorInternal = value;
		}
	}

	// Token: 0x17002482 RID: 9346
	// (get) Token: 0x0601A85D RID: 108637 RVA: 0x0071936E File Offset: 0x0071756E
	// (set) Token: 0x0601A85E RID: 108638 RVA: 0x00719376 File Offset: 0x00717576
	public float AirControl
	{
		get
		{
			return this.AirControlInternal;
		}
		set
		{
			this.AirControlInternal = value;
		}
	}

	// Token: 0x0601A85F RID: 108639 RVA: 0x00719380 File Offset: 0x00717580
	protected override bool OnStart()
	{
		CharacterActorComponent characterActorComponent = base.Entity.CheckGetComponent<CharacterActorComponent>();
		this.Player = characterActorComponent.Actor;
		EventSystem.Instance.AddWithTarget<float>(base.Entity, EEventName.CustomMovePendulum, this.ReceivePendulumEvent);
		EventSystem.Instance.AddWithTarget<int, EMovementMode, EMovementMode, byte, byte>(base.Entity, EEventName.CharMovementModeChanged, this.OnCharMovementModeChanged);
		UCharacterMovementComponent characterMovement = base.Entity.GetComponent<CharacterMoveComponent>().CharacterMovement;
		this.DefaultAirControl = characterMovement.AirControl;
		return true;
	}

	// Token: 0x0601A860 RID: 108640 RVA: 0x007193F8 File Offset: 0x007175F8
	protected override bool OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget<float>(base.Entity, EEventName.CustomMovePendulum, this.ReceivePendulumEvent);
		EventSystem.Instance.RemoveWithTarget<int, EMovementMode, EMovementMode, byte, byte>(base.Entity, EEventName.CharMovementModeChanged, this.OnCharMovementModeChanged);
		this.BreakRope();
		return true;
	}

	// Token: 0x0601A861 RID: 108641 RVA: 0x00719436 File Offset: 0x00717636
	protected override void OnTick(float delta)
	{
		if (1 == this.FrameIndex)
		{
			this.FrameIndex = 0;
			return;
		}
		this.ThrowRopeAndSwing((double)delta);
	}

	// Token: 0x0601A862 RID: 108642 RVA: 0x00719454 File Offset: 0x00717654
	protected void DrawCube(FTransformDouble transform, float duration)
	{
		int num = 156;
		FLinearColor lineColor = new FLinearColor((float)num, (float)num, (float)num, (float)num);
		FVectorDouble location = transform.GetLocation();
		int num2 = 10;
		FVector fvector = new FVector((float)num2, (float)num2, (float)num2);
		FVectorDouble extent = new FVectorDouble((double)fvector.X * 0.5, (double)fvector.Y * 0.5, (double)fvector.Z * 0.5);
		FRotator rotation = transform.Rotator();
		int num3 = 30;
		UKismetSystemLibrary.D_DrawDebugBox(GlobalData.World, location, extent, lineColor, rotation, duration, (float)num3);
		double num4 = 0.5;
		FVectorDouble lineStart = UKismetMathLibrary.D_TransformLocation(transform, new FVectorDouble(num4, num4, num4));
		FVectorDouble lineEnd = UKismetMathLibrary.D_TransformLocation(transform, new FVectorDouble(-num4, -num4, -num4));
		int num5 = 15;
		UKismetSystemLibrary.D_DrawDebugLine(GlobalData.World, lineStart, lineEnd, lineColor, duration, (float)num5);
		FVectorDouble lineStart2 = UKismetMathLibrary.D_TransformLocation(transform, new FVectorDouble(num4, -num4, num4));
		FVectorDouble lineEnd2 = UKismetMathLibrary.D_TransformLocation(transform, new FVectorDouble(-num4, num4, num4));
		UKismetSystemLibrary.D_DrawDebugLine(GlobalData.World, lineStart2, lineEnd2, lineColor, duration, (float)num5);
	}

	// Token: 0x0601A863 RID: 108643 RVA: 0x00719578 File Offset: 0x00717778
	private void ThrowRopeAndSwing(double delta)
	{
		if (!this.HookedInternal)
		{
			return;
		}
		Vector velocity = this.Velocity;
		FVectorDouble fvectorDouble = this.Player.D_GetVelocity();
		velocity.FromUeVector(fvectorDouble);
		if (delta > 33.0)
		{
			double num = (delta > 50.0) ? (delta / 50.0) : (delta / 33.0);
			double num2 = this.Velocity.Size() / num;
			if (1.0 < num2 && this.Velocity.Z < 0.0)
			{
				BaseMoveComponent component = base.Entity.GetComponent<CharacterMoveComponent>();
				int num3 = (delta > 50.0) ? 11 : 5;
				CharacterPendulumComponent.TmpVector.Set(0.0, 0.0, Math.Abs(this.Velocity.Z) / num2 * (double)num3);
				component.MoveCharacter(CharacterPendulumComponent.TmpVector, (float)(delta * 0.0010000000474974513), "钩锁.ThrowRopeAndSwing");
			}
		}
		Vector vector = Vector.Create(this.Player.D_K2_GetActorLocation());
		vector.Subtraction(this.GrabPointInternal, vector);
		double inB = Vector.DotProduct(this.Velocity, vector);
		vector.Normalize(9.99999993922529E-09);
		Vector vector2 = Vector.Create();
		vector.Multiply(inB, vector2);
		vector2.Multiply(this.RopeForce, vector2);
		UCharacterMovementComponent characterMovement = base.Entity.GetComponent<CharacterMoveComponent>().CharacterMovement;
		if (vector2.Size() > 600000.0)
		{
			vector2.Normalize(9.99999993922529E-09);
			vector2.Multiply(600000.0, vector2);
		}
		characterMovement.AddForce(vector2.ToUeVectorOld());
		characterMovement.AirControl = this.AirControlInternal;
	}

	// Token: 0x0601A864 RID: 108644 RVA: 0x0071973D File Offset: 0x0071793D
	private void BreakRope()
	{
		this.HookedInternal = false;
		base.Entity.GetComponent<CharacterMoveComponent>().CharacterMovement.AirControl = this.DefaultAirControl;
	}

	// Token: 0x0601A865 RID: 108645 RVA: 0x00719761 File Offset: 0x00717961
	public void SetPendulumData(double addVelocityX, double addVelocityY, double addVelocityZ, double forwardLossPercentage, double lossPercentage, double gravity, double friction, double deceleration, double accelerator, double maxSpeed, double maxFallingSpeed)
	{
		this.HookedInternal = true;
		this.FrameIndex = 1;
	}

	// Token: 0x0601A866 RID: 108646 RVA: 0x00719771 File Offset: 0x00717971
	public void Reset()
	{
		this.FrameIndex = 0;
		this.BreakRope();
	}

	// Token: 0x0601A867 RID: 108647 RVA: 0x00719780 File Offset: 0x00717980
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterPendulumComponent characterPendulumComponent = (CharacterPendulumComponent)componentTemplate;
		if (base.CanResetComponentProperty("Player"))
		{
			if (characterPendulumComponent.Player == null)
			{
				this.Player = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TsBaseCharacter>(this.Player), "Player"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("HookedInternal"))
		{
			this.HookedInternal = characterPendulumComponent.HookedInternal;
		}
		if (base.CanResetComponentProperty("UpLengthInternal"))
		{
			this.UpLengthInternal = characterPendulumComponent.UpLengthInternal;
		}
		if (base.CanResetComponentProperty("GrabPointInternal") && characterPendulumComponent.GrabPointInternal != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.GrabPointInternal), "GrabPointInternal"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("SocketNameInternal"))
		{
			this.SocketNameInternal = characterPendulumComponent.SocketNameInternal;
		}
		if (base.CanResetComponentProperty("RopeForceInternal"))
		{
			this.RopeForceInternal = characterPendulumComponent.RopeForceInternal;
		}
		if (base.CanResetComponentProperty("DistanceRopeToActorInternal"))
		{
			this.DistanceRopeToActorInternal = characterPendulumComponent.DistanceRopeToActorInternal;
		}
		if (base.CanResetComponentProperty("AirControlInternal"))
		{
			this.AirControlInternal = characterPendulumComponent.AirControlInternal;
		}
		if (base.CanResetComponentProperty("FrameIndex"))
		{
			this.FrameIndex = characterPendulumComponent.FrameIndex;
		}
		if (base.CanResetComponentProperty("DefaultAirControl"))
		{
			this.DefaultAirControl = characterPendulumComponent.DefaultAirControl;
		}
		return (!base.CanResetComponentProperty("Velocity") || characterPendulumComponent.Velocity == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.Velocity), "Velocity")) && (!base.CanResetComponentProperty("ReceivePendulumEvent") || characterPendulumComponent.ReceivePendulumEvent == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Action<float>>(this.ReceivePendulumEvent), "ReceivePendulumEvent")) && (!base.CanResetComponentProperty("OnCharMovementModeChanged") || characterPendulumComponent.OnCharMovementModeChanged == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Action<int, EMovementMode, EMovementMode, byte, byte>>(this.OnCharMovementModeChanged), "OnCharMovementModeChanged"));
	}

	// Token: 0x0400CBA1 RID: 52129
	private const int LIMIT_FRAME_TIME = 33;

	// Token: 0x0400CBA2 RID: 52130
	private const int LIMIT_FRAME_TIME2 = 50;

	// Token: 0x0400CBA3 RID: 52131
	private const int UPDATE_UP_Z = 5;

	// Token: 0x0400CBA4 RID: 52132
	private const int UPDATE_UP_Z2 = 11;

	// Token: 0x0400CBA5 RID: 52133
	private const int LIMIT_FORCE = 600000;

	// Token: 0x0400CBA6 RID: 52134
	[StaticVariableRuleIgnore]
	protected static Vector TmpVector = Vector.Create();

	// Token: 0x0400CBA7 RID: 52135
	[Nullable(2)]
	private TsBaseCharacter Player;

	// Token: 0x0400CBA8 RID: 52136
	private bool HookedInternal;

	// Token: 0x0400CBA9 RID: 52137
	private double UpLengthInternal;

	// Token: 0x0400CBAA RID: 52138
	private readonly Vector GrabPointInternal = Vector.Create();

	// Token: 0x0400CBAB RID: 52139
	private string SocketNameInternal = "";

	// Token: 0x0400CBAC RID: 52140
	private double RopeForceInternal;

	// Token: 0x0400CBAD RID: 52141
	private double DistanceRopeToActorInternal;

	// Token: 0x0400CBAE RID: 52142
	private float AirControlInternal;

	// Token: 0x0400CBAF RID: 52143
	private int FrameIndex;

	// Token: 0x0400CBB0 RID: 52144
	private float DefaultAirControl;

	// Token: 0x0400CBB1 RID: 52145
	private readonly Vector Velocity = Vector.Create();

	// Token: 0x0400CBB2 RID: 52146
	private readonly Action<float> ReceivePendulumEvent = delegate(float deltaTime)
	{
	};

	// Token: 0x0400CBB3 RID: 52147
	private readonly Action<int, EMovementMode, EMovementMode, byte, byte> OnCharMovementModeChanged = delegate(int charId, EMovementMode prevMovementMode, EMovementMode newMovementMode, byte prevCustomMode, byte newCustomMode)
	{
	};
}

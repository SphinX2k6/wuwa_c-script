using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020025D7 RID: 9687
[NullableContext(1)]
[Nullable(0)]
public class CharacterPendulumComponent : EntityComponent
{
	// Token: 0x170025CA RID: 9674
	// (get) Token: 0x0601822B RID: 98859 RVA: 0x0073F8F0 File Offset: 0x0073DAF0
	// (set) Token: 0x0601822C RID: 98860 RVA: 0x0073F8F8 File Offset: 0x0073DAF8
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

	// Token: 0x170025CB RID: 9675
	// (get) Token: 0x0601822D RID: 98861 RVA: 0x0073F901 File Offset: 0x0073DB01
	// (set) Token: 0x0601822E RID: 98862 RVA: 0x0073F909 File Offset: 0x0073DB09
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

	// Token: 0x170025CC RID: 9676
	// (get) Token: 0x0601822F RID: 98863 RVA: 0x0073F912 File Offset: 0x0073DB12
	// (set) Token: 0x06018230 RID: 98864 RVA: 0x0073F920 File Offset: 0x0073DB20
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

	// Token: 0x170025CD RID: 9677
	// (get) Token: 0x06018231 RID: 98865 RVA: 0x0073F92F File Offset: 0x0073DB2F
	// (set) Token: 0x06018232 RID: 98866 RVA: 0x0073F937 File Offset: 0x0073DB37
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

	// Token: 0x170025CE RID: 9678
	// (get) Token: 0x06018233 RID: 98867 RVA: 0x0073F940 File Offset: 0x0073DB40
	// (set) Token: 0x06018234 RID: 98868 RVA: 0x0073F948 File Offset: 0x0073DB48
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

	// Token: 0x170025CF RID: 9679
	// (get) Token: 0x06018235 RID: 98869 RVA: 0x0073F951 File Offset: 0x0073DB51
	// (set) Token: 0x06018236 RID: 98870 RVA: 0x0073F959 File Offset: 0x0073DB59
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

	// Token: 0x170025D0 RID: 9680
	// (get) Token: 0x06018237 RID: 98871 RVA: 0x0073F962 File Offset: 0x0073DB62
	// (set) Token: 0x06018238 RID: 98872 RVA: 0x0073F96A File Offset: 0x0073DB6A
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

	// Token: 0x06018239 RID: 98873 RVA: 0x0073F974 File Offset: 0x0073DB74
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

	// Token: 0x0601823A RID: 98874 RVA: 0x0073F9EC File Offset: 0x0073DBEC
	protected override bool OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget<float>(base.Entity, EEventName.CustomMovePendulum, this.ReceivePendulumEvent);
		EventSystem.Instance.RemoveWithTarget<int, EMovementMode, EMovementMode, byte, byte>(base.Entity, EEventName.CharMovementModeChanged, this.OnCharMovementModeChanged);
		this.BreakRope();
		return true;
	}

	// Token: 0x0601823B RID: 98875 RVA: 0x0073FA2A File Offset: 0x0073DC2A
	protected override void OnTick(float delta)
	{
		if (1 == this.FrameIndex)
		{
			this.FrameIndex = 0;
			return;
		}
		this.ThrowRopeAndSwing((double)delta);
	}

	// Token: 0x0601823C RID: 98876 RVA: 0x0073FA48 File Offset: 0x0073DC48
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

	// Token: 0x0601823D RID: 98877 RVA: 0x0073FB6C File Offset: 0x0073DD6C
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

	// Token: 0x0601823E RID: 98878 RVA: 0x0073FD31 File Offset: 0x0073DF31
	private void BreakRope()
	{
		this.HookedInternal = false;
		base.Entity.GetComponent<CharacterMoveComponent>().CharacterMovement.AirControl = this.DefaultAirControl;
	}

	// Token: 0x0601823F RID: 98879 RVA: 0x0073FD55 File Offset: 0x0073DF55
	public void SetPendulumData(double addVelocityX, double addVelocityY, double addVelocityZ, double forwardLossPercentage, double lossPercentage, double gravity, double friction, double deceleration, double accelerator, double maxSpeed, double maxFallingSpeed)
	{
		this.HookedInternal = true;
		this.FrameIndex = 1;
	}

	// Token: 0x06018240 RID: 98880 RVA: 0x0073FD65 File Offset: 0x0073DF65
	public void Reset()
	{
		this.FrameIndex = 0;
		this.BreakRope();
	}

	// Token: 0x06018241 RID: 98881 RVA: 0x0073FD74 File Offset: 0x0073DF74
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterPendulumComponent characterPendulumComponent = (CharacterPendulumComponent)componentTemplate;
		if (characterPendulumComponent.Player == null)
		{
			this.Player = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Player), "Player"))
		{
			return false;
		}
		this.HookedInternal = characterPendulumComponent.HookedInternal;
		this.UpLengthInternal = characterPendulumComponent.UpLengthInternal;
		if (characterPendulumComponent.GrabPointInternal != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.GrabPointInternal), "GrabPointInternal"))
		{
			return false;
		}
		this.SocketNameInternal = characterPendulumComponent.SocketNameInternal;
		this.RopeForceInternal = characterPendulumComponent.RopeForceInternal;
		this.DistanceRopeToActorInternal = characterPendulumComponent.DistanceRopeToActorInternal;
		this.AirControlInternal = characterPendulumComponent.AirControlInternal;
		this.FrameIndex = characterPendulumComponent.FrameIndex;
		this.DefaultAirControl = characterPendulumComponent.DefaultAirControl;
		return (characterPendulumComponent.Velocity == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.Velocity), "Velocity")) && (characterPendulumComponent.ReceivePendulumEvent == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.ReceivePendulumEvent), "ReceivePendulumEvent")) && (characterPendulumComponent.OnCharMovementModeChanged == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnCharMovementModeChanged), "OnCharMovementModeChanged"));
	}

	// Token: 0x170025D1 RID: 9681
	// (get) Token: 0x06018242 RID: 98882 RVA: 0x0073FEA7 File Offset: 0x0073E0A7
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025D2 RID: 9682
	// (get) Token: 0x06018243 RID: 98883 RVA: 0x0073FEAA File Offset: 0x0073E0AA
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025D3 RID: 9683
	// (get) Token: 0x06018244 RID: 98884 RVA: 0x0073FEAD File Offset: 0x0073E0AD
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400CF84 RID: 53124
	private const int LIMIT_FRAME_TIME = 33;

	// Token: 0x0400CF85 RID: 53125
	private const int LIMIT_FRAME_TIME2 = 50;

	// Token: 0x0400CF86 RID: 53126
	private const int UPDATE_UP_Z = 5;

	// Token: 0x0400CF87 RID: 53127
	private const int UPDATE_UP_Z2 = 11;

	// Token: 0x0400CF88 RID: 53128
	private const int LIMIT_FORCE = 600000;

	// Token: 0x0400CF89 RID: 53129
	[StaticVariableRuleIgnore]
	protected static Vector TmpVector = Vector.Create();

	// Token: 0x0400CF8A RID: 53130
	[Nullable(2)]
	private TsBaseCharacter Player;

	// Token: 0x0400CF8B RID: 53131
	private bool HookedInternal;

	// Token: 0x0400CF8C RID: 53132
	private double UpLengthInternal;

	// Token: 0x0400CF8D RID: 53133
	private readonly Vector GrabPointInternal = Vector.Create();

	// Token: 0x0400CF8E RID: 53134
	private string SocketNameInternal = "";

	// Token: 0x0400CF8F RID: 53135
	private double RopeForceInternal;

	// Token: 0x0400CF90 RID: 53136
	private double DistanceRopeToActorInternal;

	// Token: 0x0400CF91 RID: 53137
	private float AirControlInternal;

	// Token: 0x0400CF92 RID: 53138
	private int FrameIndex;

	// Token: 0x0400CF93 RID: 53139
	private float DefaultAirControl;

	// Token: 0x0400CF94 RID: 53140
	private readonly Vector Velocity = Vector.Create();

	// Token: 0x0400CF95 RID: 53141
	private readonly Action<float> ReceivePendulumEvent = delegate(float deltaTime)
	{
	};

	// Token: 0x0400CF96 RID: 53142
	private readonly Action<int, EMovementMode, EMovementMode, byte, byte> OnCharMovementModeChanged = delegate(int charId, EMovementMode prevMovementMode, EMovementMode newMovementMode, byte prevCustomMode, byte newCustomMode)
	{
	};
}

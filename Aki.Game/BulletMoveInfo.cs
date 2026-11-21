using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002373 RID: 9075
[NullableContext(1)]
[Nullable(0)]
public class BulletMoveInfo : IStaticVariableResetter
{
	// Token: 0x06016615 RID: 91669 RVA: 0x00684BA8 File Offset: 0x00682DA8
	static BulletMoveInfo()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BulletMoveInfo.CreateStaticDefaultValue), new Action(BulletMoveInfo.ResetStaticDefaultValue));
	}

	// Token: 0x06016616 RID: 91670 RVA: 0x00684BE4 File Offset: 0x00682DE4
	public void Clear()
	{
		this.SocketTransform.Reset();
		this.BulletSpeedDir.Reset();
		this.UpdateDirVector.Reset();
		this.BulletSpeedRatio = 0f;
		this.BulletSpeed = 0f;
		this.GravityMoveRotator.Reset();
		this.GravityMoveForward.Reset();
		this.BulletSpeedZ = 0f;
		this.BulletSpeed2D = 0f;
		this.Gravity = 0f;
		this.BeginSpeedRotator.Reset();
		this.TraceRotator.Reset();
		this.RoundCenterLastLocation.Reset();
		this.RoundCenter.Reset();
		this.RoundOnceAxis.Reset();
		this.IsOnBaseMovement = false;
		this.LastBaseMovementSpeed.Reset();
		this.Gravity = 0f;
		this.FollowBoneBulletRotator.Reset();
		this.BaseAdditiveAccelerate.Reset();
		this.AdditiveAccelerate.Reset();
		this.AdditiveAccelerateCurve = null;
		this.V0.Reset();
		this.MinFollowHeight = 0.0;
		this.SpeedFollowTarget = 0.0;
		this.FollowTargetBottom = true;
		this.ObstaclesOffset.Reset();
		this.LastFramePosition.Reset();
		BulletTraceElementPool.RecycleTraceLineElement(this.AimedLineTraceElement);
		this.AimedLineTraceElement = null;
		this.ActorRotateParabola = false;
		this.AroundAngle = 0f;
	}

	// Token: 0x06016617 RID: 91671 RVA: 0x00684D45 File Offset: 0x00682F45
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06016618 RID: 91672 RVA: 0x00684D47 File Offset: 0x00682F47
	public static void ResetStaticDefaultValue()
	{
		BulletMoveInfo.StickGroundLineTrace = null;
		BulletMoveInfo.StickWaterLineTrace = null;
		BulletMoveInfo.StickWaterSphereTrace = null;
	}

	// Token: 0x0400BDC0 RID: 48576
	public Transform SocketTransform = Transform.Create();

	// Token: 0x0400BDC1 RID: 48577
	public Vector BulletSpeedDir = Vector.Create();

	// Token: 0x0400BDC2 RID: 48578
	public Vector UpdateDirVector = Vector.Create();

	// Token: 0x0400BDC3 RID: 48579
	public float BulletSpeedRatio;

	// Token: 0x0400BDC4 RID: 48580
	public float BulletSpeed;

	// Token: 0x0400BDC5 RID: 48581
	public Rotator GravityMoveRotator = Rotator.Create();

	// Token: 0x0400BDC6 RID: 48582
	public Vector GravityMoveForward = Vector.Create();

	// Token: 0x0400BDC7 RID: 48583
	public float BulletSpeedZ;

	// Token: 0x0400BDC8 RID: 48584
	public float BulletSpeed2D;

	// Token: 0x0400BDC9 RID: 48585
	public float Gravity;

	// Token: 0x0400BDCA RID: 48586
	public Rotator BeginSpeedRotator = Rotator.Create();

	// Token: 0x0400BDCB RID: 48587
	public Rotator TraceRotator = Rotator.Create();

	// Token: 0x0400BDCC RID: 48588
	public Vector RoundCenterLastLocation = Vector.Create();

	// Token: 0x0400BDCD RID: 48589
	public Vector RoundCenter = Vector.Create();

	// Token: 0x0400BDCE RID: 48590
	public Vector RoundOnceAxis = Vector.Create();

	// Token: 0x0400BDCF RID: 48591
	public bool IsOnBaseMovement;

	// Token: 0x0400BDD0 RID: 48592
	public Vector LastBaseMovementSpeed = Vector.Create();

	// Token: 0x0400BDD1 RID: 48593
	public Rotator FollowBoneBulletRotator = Rotator.Create();

	// Token: 0x0400BDD2 RID: 48594
	public Vector BaseAdditiveAccelerate = Vector.Create();

	// Token: 0x0400BDD3 RID: 48595
	public Vector AdditiveAccelerate = Vector.Create();

	// Token: 0x0400BDD4 RID: 48596
	[Nullable(2)]
	public UCurveVector AdditiveAccelerateCurve;

	// Token: 0x0400BDD5 RID: 48597
	public Vector V0 = Vector.Create();

	// Token: 0x0400BDD6 RID: 48598
	public double MinFollowHeight;

	// Token: 0x0400BDD7 RID: 48599
	public double SpeedFollowTarget = 1.0;

	// Token: 0x0400BDD8 RID: 48600
	public bool FollowTargetBottom = true;

	// Token: 0x0400BDD9 RID: 48601
	public Vector LocationFollowTarget = Vector.Create();

	// Token: 0x0400BDDA RID: 48602
	public Vector ObstaclesOffset = Vector.Create();

	// Token: 0x0400BDDB RID: 48603
	public Vector LastFramePosition = Vector.Create();

	// Token: 0x0400BDDC RID: 48604
	[StaticVariableRuleIgnore]
	public static readonly Transform TempTransform1 = Transform.Create();

	// Token: 0x0400BDDD RID: 48605
	[Nullable(2)]
	public UTraceLineElement AimedLineTraceElement;

	// Token: 0x0400BDDE RID: 48606
	[Nullable(2)]
	public static UTraceLineElement StickGroundLineTrace = null;

	// Token: 0x0400BDDF RID: 48607
	[Nullable(2)]
	public static UTraceLineElement StickWaterLineTrace = null;

	// Token: 0x0400BDE0 RID: 48608
	[Nullable(2)]
	public static UTraceSphereElement StickWaterSphereTrace = null;

	// Token: 0x0400BDE1 RID: 48609
	public bool ActorRotateParabola;

	// Token: 0x0400BDE2 RID: 48610
	public float AroundAngle;
}

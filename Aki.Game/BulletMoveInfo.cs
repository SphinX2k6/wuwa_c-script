using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002E17 RID: 11799
[NullableContext(1)]
[Nullable(0)]
public class BulletMoveInfo : IStaticVariableResetter
{
	// Token: 0x06018D53 RID: 101715 RVA: 0x0065EA20 File Offset: 0x0065CC20
	static BulletMoveInfo()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BulletMoveInfo.CreateStaticDefaultValue), new Action(BulletMoveInfo.ResetStaticDefaultValue));
	}

	// Token: 0x06018D54 RID: 101716 RVA: 0x0065EA5C File Offset: 0x0065CC5C
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

	// Token: 0x06018D55 RID: 101717 RVA: 0x0065EBBD File Offset: 0x0065CDBD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06018D56 RID: 101718 RVA: 0x0065EBBF File Offset: 0x0065CDBF
	public static void ResetStaticDefaultValue()
	{
		BulletMoveInfo.StickGroundLineTrace = null;
		BulletMoveInfo.StickWaterLineTrace = null;
		BulletMoveInfo.StickWaterSphereTrace = null;
	}

	// Token: 0x0400BA32 RID: 47666
	public Transform SocketTransform = Transform.Create();

	// Token: 0x0400BA33 RID: 47667
	public Vector BulletSpeedDir = Vector.Create();

	// Token: 0x0400BA34 RID: 47668
	public Vector UpdateDirVector = Vector.Create();

	// Token: 0x0400BA35 RID: 47669
	public float BulletSpeedRatio;

	// Token: 0x0400BA36 RID: 47670
	public float BulletSpeed;

	// Token: 0x0400BA37 RID: 47671
	public Rotator GravityMoveRotator = Rotator.Create();

	// Token: 0x0400BA38 RID: 47672
	public Vector GravityMoveForward = Vector.Create();

	// Token: 0x0400BA39 RID: 47673
	public float BulletSpeedZ;

	// Token: 0x0400BA3A RID: 47674
	public float BulletSpeed2D;

	// Token: 0x0400BA3B RID: 47675
	public float Gravity;

	// Token: 0x0400BA3C RID: 47676
	public Rotator BeginSpeedRotator = Rotator.Create();

	// Token: 0x0400BA3D RID: 47677
	public Rotator TraceRotator = Rotator.Create();

	// Token: 0x0400BA3E RID: 47678
	public Vector RoundCenterLastLocation = Vector.Create();

	// Token: 0x0400BA3F RID: 47679
	public Vector RoundCenter = Vector.Create();

	// Token: 0x0400BA40 RID: 47680
	public Vector RoundOnceAxis = Vector.Create();

	// Token: 0x0400BA41 RID: 47681
	public bool IsOnBaseMovement;

	// Token: 0x0400BA42 RID: 47682
	public Vector LastBaseMovementSpeed = Vector.Create();

	// Token: 0x0400BA43 RID: 47683
	public Rotator FollowBoneBulletRotator = Rotator.Create();

	// Token: 0x0400BA44 RID: 47684
	public Vector BaseAdditiveAccelerate = Vector.Create();

	// Token: 0x0400BA45 RID: 47685
	public Vector AdditiveAccelerate = Vector.Create();

	// Token: 0x0400BA46 RID: 47686
	[Nullable(2)]
	public UCurveVector AdditiveAccelerateCurve;

	// Token: 0x0400BA47 RID: 47687
	public Vector V0 = Vector.Create();

	// Token: 0x0400BA48 RID: 47688
	public double MinFollowHeight;

	// Token: 0x0400BA49 RID: 47689
	public double SpeedFollowTarget = 1.0;

	// Token: 0x0400BA4A RID: 47690
	public bool FollowTargetBottom = true;

	// Token: 0x0400BA4B RID: 47691
	public Vector LocationFollowTarget = Vector.Create();

	// Token: 0x0400BA4C RID: 47692
	public Vector ObstaclesOffset = Vector.Create();

	// Token: 0x0400BA4D RID: 47693
	public Vector LastFramePosition = Vector.Create();

	// Token: 0x0400BA4E RID: 47694
	[StaticVariableRuleIgnore]
	public static readonly Transform TempTransform1 = Transform.Create();

	// Token: 0x0400BA4F RID: 47695
	[Nullable(2)]
	public UTraceLineElement AimedLineTraceElement;

	// Token: 0x0400BA50 RID: 47696
	[Nullable(2)]
	public static UTraceLineElement StickGroundLineTrace = null;

	// Token: 0x0400BA51 RID: 47697
	[Nullable(2)]
	public static UTraceLineElement StickWaterLineTrace = null;

	// Token: 0x0400BA52 RID: 47698
	[Nullable(2)]
	public static UTraceSphereElement StickWaterSphereTrace = null;

	// Token: 0x0400BA53 RID: 47699
	public bool ActorRotateParabola;

	// Token: 0x0400BA54 RID: 47700
	public float AroundAngle;
}

using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Movement;
using UnrealEngine;

// Token: 0x020025B5 RID: 9653
[NullableContext(1)]
[Nullable(0)]
public class SoarConfigParams : IStaticVariableResetter
{
	// Token: 0x06017F32 RID: 98098 RVA: 0x00726A64 File Offset: 0x00724C64
	static SoarConfigParams()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SoarConfigParams.CreateStaticDefaultValue), new Action(SoarConfigParams.ResetStaticDefaultValue));
	}

	// Token: 0x1700256F RID: 9583
	// (get) Token: 0x06017F33 RID: 98099 RVA: 0x00726A83 File Offset: 0x00724C83
	public static SoarConfigParams SoarConfigBase
	{
		get
		{
			if (SoarConfigParams.SoarConfigBaseInternal == null)
			{
				SoarConfigParams.SoarConfigBaseInternal = new SoarConfigParams();
				SoarConfigParams.SoarConfigBaseInternal.Init(ResourceSystem.Instance.GetLoadedAsset<BP_SoarConfig_C>("/Game/Aki/Data/Fight/Movement/DA_SoarConfigBase.DA_SoarConfigBase"));
			}
			return SoarConfigParams.SoarConfigBaseInternal;
		}
	}

	// Token: 0x06017F34 RID: 98100 RVA: 0x00726AB4 File Offset: 0x00724CB4
	public static void ReInitSoarConfigBase()
	{
		if (SoarConfigParams.SoarConfigBaseInternal == null)
		{
			SoarConfigParams.SoarConfigBaseInternal = new SoarConfigParams();
		}
		SoarConfigParams.SoarConfigBaseInternal.Init(ResourceSystem.Instance.GetLoadedAsset<BP_SoarConfig_C>("/Game/Aki/Data/Fight/Movement/DA_SoarConfigBase.DA_SoarConfigBase"));
	}

	// Token: 0x06017F35 RID: 98101 RVA: 0x00726AE0 File Offset: 0x00724CE0
	public SoarConfigParams()
	{
		this.SoarBalanceSpeed = (float)this.SoarBalanceVelocity.Size();
		this.SoarSplineInputAngleCos = (float)Math.Cos((double)(this.SoarSplineInputAngle * 0.017453292f));
		this.SoarSplineInputAngleSin = (float)Math.Sin((double)(this.SoarSplineInputAngle * 0.017453292f));
		this.SoarSplineInputDirectMinX = (float)Math.Sin((double)(this.SoarPitchMin * 0.017453292f));
	}

	// Token: 0x06017F36 RID: 98102 RVA: 0x00726CF8 File Offset: 0x00724EF8
	public void Init(BP_SoarConfig_C ueConfig)
	{
		this.SoarInputNormalAngleMin = ueConfig.阻挡面角度极限最小值;
		this.SoarInputNormalAngleMax = ueConfig.阻挡面角度极限最大值;
		this.SoarAerodynamicsMin = ueConfig.空气阻力面系数最小值;
		this.SoarAerodynamicsMax = ueConfig.空气阻力面系数最大值;
		this.SoarSpeedThresholdMin = ueConfig.阻挡面最小值对应速度值;
		this.SoarSpeedThresholdMax = ueConfig.阻挡面最大值对应速度值;
		this.SoarPitchMin = ueConfig.阻挡面最小角度;
		this.SoarPitchMax = ueConfig.阻挡面最大角度;
		this.SoarNormalSpeedNoInput = ueConfig.无输入时阻挡面转速;
		Vector soarBalanceVelocity = this.SoarBalanceVelocity;
		FVector 满抬升输入时平衡速度向量 = ueConfig.满抬升输入时平衡速度向量;
		FVectorDouble fvectorDouble = 满抬升输入时平衡速度向量;
		soarBalanceVelocity.DeepCopy(fvectorDouble);
		this.SoarBalanceSpeed = (float)this.SoarBalanceVelocity.Size();
		this.SoarBalanceInputThreshold = ueConfig.满抬升输入判定阈值;
		this.SoarBalanceAccelMin = ueConfig.平衡用最小加速度;
		this.SoarBalanceAccelMax = ueConfig.平衡用最大加速度;
		this.SoarBalanceAccelOffset = ueConfig.平衡使用最大值对应速度差;
		this.SoarBalanceSpeedThreshold = ueConfig.满抬升输入平衡开启速度阈值;
		this.SoarBalanceSpeed2 = ueConfig.非满抬升输入平衡速度值;
		this.SoarBalanceSpeedThreshold2 = ueConfig.非满抬升输入平衡开启速度阈值;
		this.SoarNormalSpeed = ueConfig.阻挡面转速第一段线性;
		this.SoarNormalLerp = ueConfig.阻挡面转速第二段比例;
		this.SoarRotateSpeed = ueConfig.面向转速第一段线性;
		this.SoarRotateLerp = ueConfig.面向转速第二段比例;
		this.SoarBoostNormalSpeed = ueConfig.Boost阻挡面转速第一段线性;
		this.SoarBoostNormalLerp = ueConfig.Boost阻挡面转速第二段比例;
		this.SoarBoostAccel = ueConfig.Boost加速度;
		this.SoarSplineMinSpeed = ueConfig.风道最小速度;
		this.SoarSplineAccel = ueConfig.风道最大加速度;
		this.SoarSplineRotateAngleSpeedWithoutInput = ueConfig.风道无输入面向修正速度;
		this.SoarSplineRotateAngleSpeedWithInput = ueConfig.风道有输入面向修正速度;
		this.SoarSplineRotateLerp = ueConfig.风道转向第二段比例;
		this.SoarSplinePushCenterDistMin = ueConfig.风道中线拉回最小速对应距离;
		this.SoarSplinePushCenterDistMax = ueConfig.风道中线拉回最大速对应距离;
		this.SoarSplinePushCenterSpeedMin = ueConfig.风道中线拉回最小速度;
		this.SoarSplinePushCenterSpeedMax = ueConfig.风道中线拉回最大速度;
		this.SoarSplineInputAngle = ueConfig.风道输入对应偏转;
		this.SoarSplineInputAngleCos = (float)Math.Cos((double)(this.SoarSplineInputAngle * 0.017453292f));
		this.SoarSplineInputAngleSin = (float)Math.Sin((double)(this.SoarSplineInputAngle * 0.017453292f));
		this.SoarSplineInputDirectMinX = (float)Math.Sin((double)(this.SoarPitchMin * 0.017453292f));
		this.SoarAirFriction = ueConfig.空气阻力;
		this.SoarGravityValue = ueConfig.重力加速度;
		this.SoarMaxSpeed = ueConfig.最大速度;
		this.SoarHitWallExitTimeLength = ueConfig.撞墙结束时间;
		this.DebugDraw = (GlobalData.IsPlayInEditor && ueConfig.DebugDraw);
	}

	// Token: 0x06017F37 RID: 98103 RVA: 0x00726F50 File Offset: 0x00725150
	public static void CreateStaticDefaultValue()
	{
		SoarConfigParams.SoarConfigBaseInternal = null;
	}

	// Token: 0x06017F38 RID: 98104 RVA: 0x00726F58 File Offset: 0x00725158
	public static void ResetStaticDefaultValue()
	{
		SoarConfigParams.SoarConfigBaseInternal = null;
	}

	// Token: 0x0400CD0C RID: 52492
	[Nullable(2)]
	private static SoarConfigParams SoarConfigBaseInternal;

	// Token: 0x0400CD0D RID: 52493
	public float SoarInputNormalAngleMin = 12.38f;

	// Token: 0x0400CD0E RID: 52494
	public float SoarInputNormalAngleMax = 45f;

	// Token: 0x0400CD0F RID: 52495
	public float SoarAerodynamicsMin = 4.9f;

	// Token: 0x0400CD10 RID: 52496
	public float SoarAerodynamicsMax = 30f;

	// Token: 0x0400CD11 RID: 52497
	public float SoarSpeedThresholdMin = 1700f;

	// Token: 0x0400CD12 RID: 52498
	public float SoarSpeedThresholdMax = 2200f;

	// Token: 0x0400CD13 RID: 52499
	public float SoarPitchMin = 10f;

	// Token: 0x0400CD14 RID: 52500
	public float SoarPitchMax = 140f;

	// Token: 0x0400CD15 RID: 52501
	public float SoarNormalSpeedNoInput = 6f;

	// Token: 0x0400CD16 RID: 52502
	public Vector SoarBalanceVelocity = Vector.Create(1650.0, 0.0, -385.0);

	// Token: 0x0400CD17 RID: 52503
	public float SoarBalanceSpeed;

	// Token: 0x0400CD18 RID: 52504
	public float SoarBalanceInputThreshold = -0.8f;

	// Token: 0x0400CD19 RID: 52505
	public float SoarBalanceAccelMin = 100f;

	// Token: 0x0400CD1A RID: 52506
	public float SoarBalanceAccelMax = 1000f;

	// Token: 0x0400CD1B RID: 52507
	public float SoarBalanceAccelOffset = 400f;

	// Token: 0x0400CD1C RID: 52508
	public float SoarBalanceSpeedThreshold = 1700f;

	// Token: 0x0400CD1D RID: 52509
	public float SoarBalanceSpeed2 = 1500f;

	// Token: 0x0400CD1E RID: 52510
	public float SoarBalanceSpeedThreshold2 = 1500f;

	// Token: 0x0400CD1F RID: 52511
	public float SoarNormalSpeed = 200f;

	// Token: 0x0400CD20 RID: 52512
	public float SoarNormalLerp = 0.95f;

	// Token: 0x0400CD21 RID: 52513
	public float SoarRotateSpeed = 65f;

	// Token: 0x0400CD22 RID: 52514
	public float SoarRotateLerp = 0.98f;

	// Token: 0x0400CD23 RID: 52515
	public float SoarBoostNormalSpeed = 50f;

	// Token: 0x0400CD24 RID: 52516
	public float SoarBoostNormalLerp = 0.95f;

	// Token: 0x0400CD25 RID: 52517
	public float SoarBoostAccel = 5000f;

	// Token: 0x0400CD26 RID: 52518
	public float SoarSplineMinSpeed = 500f;

	// Token: 0x0400CD27 RID: 52519
	public float SoarSplineAccel = 500f;

	// Token: 0x0400CD28 RID: 52520
	public float SoarSplineRotateAngleSpeedWithoutInput = 360f;

	// Token: 0x0400CD29 RID: 52521
	public float SoarSplineRotateAngleSpeedWithInput = 180f;

	// Token: 0x0400CD2A RID: 52522
	public float SoarSplineRotateLerp = 0.95f;

	// Token: 0x0400CD2B RID: 52523
	public float SoarSplinePushCenterDistMin;

	// Token: 0x0400CD2C RID: 52524
	public float SoarSplinePushCenterDistMax = 800f;

	// Token: 0x0400CD2D RID: 52525
	public float SoarSplinePushCenterSpeedMin;

	// Token: 0x0400CD2E RID: 52526
	public float SoarSplinePushCenterSpeedMax = 300f;

	// Token: 0x0400CD2F RID: 52527
	public float SoarSplineInputAngle = 30f;

	// Token: 0x0400CD30 RID: 52528
	public float SoarSplineInputAngleCos;

	// Token: 0x0400CD31 RID: 52529
	public float SoarSplineInputAngleSin;

	// Token: 0x0400CD32 RID: 52530
	public float SoarSplineInputDirectMinX;

	// Token: 0x0400CD33 RID: 52531
	public float SoarAirFriction = 0.02f;

	// Token: 0x0400CD34 RID: 52532
	public float SoarGravityValue = 1900f;

	// Token: 0x0400CD35 RID: 52533
	public float SoarMaxSpeed = 3000f;

	// Token: 0x0400CD36 RID: 52534
	public float SoarHitWallExitTimeLength = 1500f;

	// Token: 0x0400CD37 RID: 52535
	public bool DebugDraw;
}

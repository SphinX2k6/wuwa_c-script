using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Movement;
using UnrealEngine;

// Token: 0x0200305F RID: 12383
[NullableContext(1)]
[Nullable(0)]
public class SoarConfigParams : IStaticVariableResetter
{
	// Token: 0x0601A585 RID: 107909 RVA: 0x006FFD64 File Offset: 0x006FDF64
	static SoarConfigParams()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SoarConfigParams.CreateStaticDefaultValue), new Action(SoarConfigParams.ResetStaticDefaultValue));
	}

	// Token: 0x17002443 RID: 9283
	// (get) Token: 0x0601A586 RID: 107910 RVA: 0x006FFD83 File Offset: 0x006FDF83
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

	// Token: 0x0601A587 RID: 107911 RVA: 0x006FFDB4 File Offset: 0x006FDFB4
	public static void ReInitSoarConfigBase()
	{
		if (SoarConfigParams.SoarConfigBaseInternal == null)
		{
			SoarConfigParams.SoarConfigBaseInternal = new SoarConfigParams();
		}
		SoarConfigParams.SoarConfigBaseInternal.Init(ResourceSystem.Instance.GetLoadedAsset<BP_SoarConfig_C>("/Game/Aki/Data/Fight/Movement/DA_SoarConfigBase.DA_SoarConfigBase"));
	}

	// Token: 0x0601A588 RID: 107912 RVA: 0x006FFDE0 File Offset: 0x006FDFE0
	public SoarConfigParams()
	{
		this.SoarBalanceSpeed = (float)this.SoarBalanceVelocity.Size();
		this.SoarSplineInputAngleCos = (float)Math.Cos((double)(this.SoarSplineInputAngle * 0.017453292f));
		this.SoarSplineInputAngleSin = (float)Math.Sin((double)(this.SoarSplineInputAngle * 0.017453292f));
		this.SoarSplineInputDirectMinX = (float)Math.Sin((double)(this.SoarPitchMin * 0.017453292f));
	}

	// Token: 0x0601A589 RID: 107913 RVA: 0x006FFFF8 File Offset: 0x006FE1F8
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

	// Token: 0x0601A58A RID: 107914 RVA: 0x00700250 File Offset: 0x006FE450
	public static void CreateStaticDefaultValue()
	{
		SoarConfigParams.SoarConfigBaseInternal = null;
	}

	// Token: 0x0601A58B RID: 107915 RVA: 0x00700258 File Offset: 0x006FE458
	public static void ResetStaticDefaultValue()
	{
		SoarConfigParams.SoarConfigBaseInternal = null;
	}

	// Token: 0x0400C932 RID: 51506
	[Nullable(2)]
	private static SoarConfigParams SoarConfigBaseInternal;

	// Token: 0x0400C933 RID: 51507
	public float SoarInputNormalAngleMin = 12.38f;

	// Token: 0x0400C934 RID: 51508
	public float SoarInputNormalAngleMax = 45f;

	// Token: 0x0400C935 RID: 51509
	public float SoarAerodynamicsMin = 4.9f;

	// Token: 0x0400C936 RID: 51510
	public float SoarAerodynamicsMax = 30f;

	// Token: 0x0400C937 RID: 51511
	public float SoarSpeedThresholdMin = 1700f;

	// Token: 0x0400C938 RID: 51512
	public float SoarSpeedThresholdMax = 2200f;

	// Token: 0x0400C939 RID: 51513
	public float SoarPitchMin = 10f;

	// Token: 0x0400C93A RID: 51514
	public float SoarPitchMax = 140f;

	// Token: 0x0400C93B RID: 51515
	public float SoarNormalSpeedNoInput = 6f;

	// Token: 0x0400C93C RID: 51516
	public Vector SoarBalanceVelocity = Vector.Create(1650.0, 0.0, -385.0);

	// Token: 0x0400C93D RID: 51517
	public float SoarBalanceSpeed;

	// Token: 0x0400C93E RID: 51518
	public float SoarBalanceInputThreshold = -0.8f;

	// Token: 0x0400C93F RID: 51519
	public float SoarBalanceAccelMin = 100f;

	// Token: 0x0400C940 RID: 51520
	public float SoarBalanceAccelMax = 1000f;

	// Token: 0x0400C941 RID: 51521
	public float SoarBalanceAccelOffset = 400f;

	// Token: 0x0400C942 RID: 51522
	public float SoarBalanceSpeedThreshold = 1700f;

	// Token: 0x0400C943 RID: 51523
	public float SoarBalanceSpeed2 = 1500f;

	// Token: 0x0400C944 RID: 51524
	public float SoarBalanceSpeedThreshold2 = 1500f;

	// Token: 0x0400C945 RID: 51525
	public float SoarNormalSpeed = 200f;

	// Token: 0x0400C946 RID: 51526
	public float SoarNormalLerp = 0.95f;

	// Token: 0x0400C947 RID: 51527
	public float SoarRotateSpeed = 65f;

	// Token: 0x0400C948 RID: 51528
	public float SoarRotateLerp = 0.98f;

	// Token: 0x0400C949 RID: 51529
	public float SoarBoostNormalSpeed = 50f;

	// Token: 0x0400C94A RID: 51530
	public float SoarBoostNormalLerp = 0.95f;

	// Token: 0x0400C94B RID: 51531
	public float SoarBoostAccel = 5000f;

	// Token: 0x0400C94C RID: 51532
	public float SoarSplineMinSpeed = 500f;

	// Token: 0x0400C94D RID: 51533
	public float SoarSplineAccel = 500f;

	// Token: 0x0400C94E RID: 51534
	public float SoarSplineRotateAngleSpeedWithoutInput = 360f;

	// Token: 0x0400C94F RID: 51535
	public float SoarSplineRotateAngleSpeedWithInput = 180f;

	// Token: 0x0400C950 RID: 51536
	public float SoarSplineRotateLerp = 0.95f;

	// Token: 0x0400C951 RID: 51537
	public float SoarSplinePushCenterDistMin;

	// Token: 0x0400C952 RID: 51538
	public float SoarSplinePushCenterDistMax = 800f;

	// Token: 0x0400C953 RID: 51539
	public float SoarSplinePushCenterSpeedMin;

	// Token: 0x0400C954 RID: 51540
	public float SoarSplinePushCenterSpeedMax = 300f;

	// Token: 0x0400C955 RID: 51541
	public float SoarSplineInputAngle = 30f;

	// Token: 0x0400C956 RID: 51542
	public float SoarSplineInputAngleCos;

	// Token: 0x0400C957 RID: 51543
	public float SoarSplineInputAngleSin;

	// Token: 0x0400C958 RID: 51544
	public float SoarSplineInputDirectMinX;

	// Token: 0x0400C959 RID: 51545
	public float SoarAirFriction = 0.02f;

	// Token: 0x0400C95A RID: 51546
	public float SoarGravityValue = 1900f;

	// Token: 0x0400C95B RID: 51547
	public float SoarMaxSpeed = 3000f;

	// Token: 0x0400C95C RID: 51548
	public float SoarHitWallExitTimeLength = 1500f;

	// Token: 0x0400C95D RID: 51549
	public bool DebugDraw;
}

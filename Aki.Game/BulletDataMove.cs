using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x02002DAF RID: 11695
[NullableContext(1)]
[Nullable(0)]
public class BulletDataMove
{
	// Token: 0x1700217F RID: 8575
	// (get) Token: 0x06018969 RID: 100713 RVA: 0x00648B64 File Offset: 0x00646D64
	public EInitialVelocityDirection InitVelocityDirStandard
	{
		get
		{
			if (this.InitVelocityDirStandardInternal == null)
			{
				this.InitVelocityDirStandardInternal = new EInitialVelocityDirection?(this.Data.出生初速度方向基准);
			}
			return this.InitVelocityDirStandardInternal.Value;
		}
	}

	// Token: 0x17002180 RID: 8576
	// (get) Token: 0x0601896A RID: 100714 RVA: 0x00648B99 File Offset: 0x00646D99
	public bool InitVelocityKeepUp
	{
		get
		{
			if (this.InitVelocityKeepUpInternal == null)
			{
				this.InitVelocityKeepUpInternal = new bool?(this.Data.初速度仅Z轴朝向);
			}
			return this.InitVelocityKeepUpInternal.Value;
		}
	}

	// Token: 0x17002181 RID: 8577
	// (get) Token: 0x0601896B RID: 100715 RVA: 0x00648BC9 File Offset: 0x00646DC9
	public string InitVelocityDirParam
	{
		get
		{
			if (this.InitVelocityDirParamInternal == null)
			{
				this.InitVelocityDirParamInternal = this.Data.出生初速度方向基准参数;
			}
			return this.InitVelocityDirParamInternal;
		}
	}

	// Token: 0x17002182 RID: 8578
	// (get) Token: 0x0601896C RID: 100716 RVA: 0x00648BEA File Offset: 0x00646DEA
	public Rotator InitVelocityRot
	{
		get
		{
			if (this.InitVelocityRotInternal == null)
			{
				this.InitVelocityRotInternal = Rotator.Create(this.Data.初速度偏移方向);
			}
			return this.InitVelocityRotInternal;
		}
	}

	// Token: 0x17002183 RID: 8579
	// (get) Token: 0x0601896D RID: 100717 RVA: 0x00648C15 File Offset: 0x00646E15
	public Vector InitVelocityDirRandom
	{
		get
		{
			if (this.InitVelocityDirRandomInternal == null)
			{
				this.InitVelocityDirRandomInternal = Vector.Create(this.Data.初速度方向随机);
			}
			return this.InitVelocityDirRandomInternal;
		}
	}

	// Token: 0x17002184 RID: 8580
	// (get) Token: 0x0601896E RID: 100718 RVA: 0x00648C40 File Offset: 0x00646E40
	public float UpDownAngleLimit
	{
		get
		{
			if (this.UpDownAngleLimitInternal == null)
			{
				this.UpDownAngleLimitInternal = new float?(this.Data.发射上下角度限制);
			}
			return this.UpDownAngleLimitInternal.Value;
		}
	}

	// Token: 0x17002185 RID: 8581
	// (get) Token: 0x0601896F RID: 100719 RVA: 0x00648C70 File Offset: 0x00646E70
	public EBulletFollowType FollowType
	{
		get
		{
			if (this.FollowTypeInternal == null)
			{
				this.FollowTypeInternal = new EBulletFollowType?(this.Data.子弹跟随类型);
			}
			return this.FollowTypeInternal.Value;
		}
	}

	// Token: 0x17002186 RID: 8582
	// (get) Token: 0x06018970 RID: 100720 RVA: 0x00648CA5 File Offset: 0x00646EA5
	public bool IsLockScale
	{
		get
		{
			if (this.IsLockScaleInternal == null)
			{
				this.IsLockScaleInternal = new bool?(this.Data.是否锁定缩放);
			}
			return this.IsLockScaleInternal.Value;
		}
	}

	// Token: 0x17002187 RID: 8583
	// (get) Token: 0x06018971 RID: 100721 RVA: 0x00648CD5 File Offset: 0x00646ED5
	public bool IsDetachOnSkillEnd
	{
		get
		{
			if (this.IsDetachOnSkillEndInternal == null)
			{
				this.IsDetachOnSkillEndInternal = new bool?(this.Data.技能结束解除跟随骨骼);
			}
			return this.IsDetachOnSkillEndInternal.Value;
		}
	}

	// Token: 0x17002188 RID: 8584
	// (get) Token: 0x06018972 RID: 100722 RVA: 0x00648D05 File Offset: 0x00646F05
	public float Speed
	{
		get
		{
			if (this.SpeedInternal == null)
			{
				this.SpeedInternal = new float?(this.Data.移动速度);
			}
			return this.SpeedInternal.Value;
		}
	}

	// Token: 0x17002189 RID: 8585
	// (get) Token: 0x06018973 RID: 100723 RVA: 0x00648D35 File Offset: 0x00646F35
	public UCurveFloat SpeedCurve
	{
		get
		{
			if (!this.SpeedCurveInit)
			{
				this.SpeedCurveInit = true;
				this.SpeedCurveInternal = this.Data.移动速度曲线;
			}
			return this.SpeedCurveInternal;
		}
	}

	// Token: 0x1700218A RID: 8586
	// (get) Token: 0x06018974 RID: 100724 RVA: 0x00648D5D File Offset: 0x00646F5D
	public Vector FollowSkeletonRotLimit
	{
		get
		{
			if (this.FollowSkeletonRotLimitInternal == null)
			{
				this.FollowSkeletonRotLimitInternal = Vector.Create(this.Data.跟随骨骼限制旋转);
			}
			return this.FollowSkeletonRotLimitInternal;
		}
	}

	// Token: 0x1700218B RID: 8587
	// (get) Token: 0x06018975 RID: 100725 RVA: 0x00648D88 File Offset: 0x00646F88
	public Vector[] TrackParams
	{
		get
		{
			if (this.TrackParamsInternal == null)
			{
				TArray<FVector> 运动轨迹参数数据 = this.Data.运动轨迹参数数据;
				int num = 运动轨迹参数数据.Num();
				this.TrackParamsInternal = new Vector[num];
				for (int i = 0; i < num; i++)
				{
					FVector fvector = 运动轨迹参数数据.Get(i);
					this.TrackParamsInternal[i] = Vector.Create(fvector);
				}
			}
			return this.TrackParamsInternal;
		}
	}

	// Token: 0x1700218C RID: 8588
	// (get) Token: 0x06018976 RID: 100726 RVA: 0x00648DEC File Offset: 0x00646FEC
	public UCurveVector[] TrackCurves
	{
		get
		{
			if (this.TrackCurvesInternal == null)
			{
				TArray<UCurveVector> 运动轨迹参数曲线 = this.Data.运动轨迹参数曲线;
				int num = 运动轨迹参数曲线.Num();
				this.TrackCurvesInternal = new UCurveVector[num];
				for (int i = 0; i < num; i++)
				{
					this.TrackCurvesInternal[i] = 运动轨迹参数曲线.Get(i);
				}
			}
			return this.TrackCurvesInternal;
		}
	}

	// Token: 0x1700218D RID: 8589
	// (get) Token: 0x06018977 RID: 100727 RVA: 0x00648E41 File Offset: 0x00647041
	public EBulletTarget TrackTarget
	{
		get
		{
			if (this.TrackTargetInternal == null)
			{
				this.TrackTargetInternal = new EBulletTarget?((EBulletTarget)this.Data.运动轨迹参数目标);
			}
			return this.TrackTargetInternal.Value;
		}
	}

	// Token: 0x1700218E RID: 8590
	// (get) Token: 0x06018978 RID: 100728 RVA: 0x00648E76 File Offset: 0x00647076
	public string TrackTargetBlackboardKey
	{
		get
		{
			if (this.TrackTargetBlackboardKeyInternal == null)
			{
				this.TrackTargetBlackboardKeyInternal = this.Data.运动轨迹目标黑板Key值;
			}
			return this.TrackTargetBlackboardKeyInternal;
		}
	}

	// Token: 0x1700218F RID: 8591
	// (get) Token: 0x06018979 RID: 100729 RVA: 0x00648E97 File Offset: 0x00647097
	public EMoveTrajectory Trajectory
	{
		get
		{
			if (this.TrajectoryInternal == null)
			{
				this.TrajectoryInternal = new EMoveTrajectory?((EMoveTrajectory)this.Data.运动轨迹类型);
			}
			return this.TrajectoryInternal.Value;
		}
	}

	// Token: 0x17002190 RID: 8592
	// (get) Token: 0x0601897A RID: 100730 RVA: 0x00648ECC File Offset: 0x006470CC
	public FName BoneName
	{
		get
		{
			if (this.BoneNameInternal == null)
			{
				this.BoneNameInternal = new FName?(this.Data.骨骼名字);
			}
			return this.BoneNameInternal.Value;
		}
	}

	// Token: 0x17002191 RID: 8593
	// (get) Token: 0x0601897B RID: 100731 RVA: 0x00648EFC File Offset: 0x006470FC
	public string BoneNameString
	{
		get
		{
			if (this.BoneNameStringInternal == null)
			{
				this.BoneNameStringInternal = this.BoneName.ToString();
			}
			return this.BoneNameStringInternal;
		}
	}

	// Token: 0x17002192 RID: 8594
	// (get) Token: 0x0601897C RID: 100732 RVA: 0x00648F31 File Offset: 0x00647131
	public string SkeletonComponentName
	{
		get
		{
			if (this.SkeletonComponentNameInternal == null)
			{
				this.SkeletonComponentNameInternal = this.Data.骨骼网格体名字;
			}
			return this.SkeletonComponentNameInternal;
		}
	}

	// Token: 0x17002193 RID: 8595
	// (get) Token: 0x0601897D RID: 100733 RVA: 0x00648F54 File Offset: 0x00647154
	public Dictionary<EBulletBeginVelocityLimit, float> BeginVelocityLimitMap
	{
		get
		{
			if (this.BeginVelocityLimitMapInternal == null)
			{
				TMap<TEnumAsByte<EBulletBeginVelocityLimit>, float> 初速度角度限制 = this.Data.初速度角度限制;
				this.BeginVelocityLimitMapInternal = new Dictionary<EBulletBeginVelocityLimit, float>();
				foreach (KeyValuePair<TEnumAsByte<EBulletBeginVelocityLimit>, float> keyValuePair in 初速度角度限制)
				{
					TEnumAsByte<EBulletBeginVelocityLimit> tenumAsByte;
					float num;
					keyValuePair.Deconstruct(out tenumAsByte, out num);
					TEnumAsByte<EBulletBeginVelocityLimit> value = tenumAsByte;
					float value2 = num;
					this.BeginVelocityLimitMapInternal.Add(value, value2);
				}
			}
			return this.BeginVelocityLimitMapInternal;
		}
	}

	// Token: 0x17002194 RID: 8596
	// (get) Token: 0x0601897E RID: 100734 RVA: 0x00648FDC File Offset: 0x006471DC
	public EBulletDestOffset DestOffsetForward
	{
		get
		{
			if (this.DestOffsetForwardInternal == null)
			{
				this.DestOffsetForwardInternal = new EBulletDestOffset?(this.Data.终点偏移基准朝向);
			}
			return this.DestOffsetForwardInternal.Value;
		}
	}

	// Token: 0x17002195 RID: 8597
	// (get) Token: 0x0601897F RID: 100735 RVA: 0x00649011 File Offset: 0x00647211
	public Vector DestOffset
	{
		get
		{
			if (this.DestOffsetInternal == null)
			{
				this.DestOffsetInternal = Vector.Create(this.Data.终点偏移);
			}
			return this.DestOffsetInternal;
		}
	}

	// Token: 0x17002196 RID: 8598
	// (get) Token: 0x06018980 RID: 100736 RVA: 0x0064903C File Offset: 0x0064723C
	public string TrackTargetBone
	{
		get
		{
			if (this.TrackTargetBoneInternal == null)
			{
				this.TrackTargetBoneInternal = this.Data.运动轨迹目标骨骼;
			}
			return this.TrackTargetBoneInternal;
		}
	}

	// Token: 0x06018981 RID: 100737 RVA: 0x0064905D File Offset: 0x0064725D
	public BulletDataMove(SReBulletDataMove data)
	{
		this.Data = data;
	}

	// Token: 0x06018982 RID: 100738 RVA: 0x0064906C File Offset: 0x0064726C
	public bool Preload()
	{
		EInitialVelocityDirection initVelocityDirStandard = this.InitVelocityDirStandard;
		string initVelocityDirParam = this.InitVelocityDirParam;
		Rotator initVelocityRot = this.InitVelocityRot;
		EBulletFollowType followType = this.FollowType;
		float speed = this.Speed;
		UCurveFloat speedCurve = this.SpeedCurve;
		Vector[] trackParams = this.TrackParams;
		UCurveVector[] trackCurves = this.TrackCurves;
		EBulletTarget trackTarget = this.TrackTarget;
		EMoveTrajectory trajectory = this.Trajectory;
		FName boneName = this.BoneName;
		string skeletonComponentName = this.SkeletonComponentName;
		return true;
	}

	// Token: 0x0400B696 RID: 46742
	private readonly SReBulletDataMove Data;

	// Token: 0x0400B697 RID: 46743
	private EInitialVelocityDirection? InitVelocityDirStandardInternal;

	// Token: 0x0400B698 RID: 46744
	private bool? InitVelocityKeepUpInternal;

	// Token: 0x0400B699 RID: 46745
	[Nullable(2)]
	private string InitVelocityDirParamInternal;

	// Token: 0x0400B69A RID: 46746
	[Nullable(2)]
	private Rotator InitVelocityRotInternal;

	// Token: 0x0400B69B RID: 46747
	[Nullable(2)]
	private Vector InitVelocityDirRandomInternal;

	// Token: 0x0400B69C RID: 46748
	private float? UpDownAngleLimitInternal;

	// Token: 0x0400B69D RID: 46749
	private EBulletFollowType? FollowTypeInternal;

	// Token: 0x0400B69E RID: 46750
	private bool? IsLockScaleInternal;

	// Token: 0x0400B69F RID: 46751
	private bool? IsDetachOnSkillEndInternal;

	// Token: 0x0400B6A0 RID: 46752
	private float? SpeedInternal;

	// Token: 0x0400B6A1 RID: 46753
	[Nullable(2)]
	private UCurveFloat SpeedCurveInternal;

	// Token: 0x0400B6A2 RID: 46754
	private bool SpeedCurveInit;

	// Token: 0x0400B6A3 RID: 46755
	[Nullable(2)]
	private Vector FollowSkeletonRotLimitInternal;

	// Token: 0x0400B6A4 RID: 46756
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Vector[] TrackParamsInternal;

	// Token: 0x0400B6A5 RID: 46757
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private UCurveVector[] TrackCurvesInternal;

	// Token: 0x0400B6A6 RID: 46758
	private EBulletTarget? TrackTargetInternal;

	// Token: 0x0400B6A7 RID: 46759
	[Nullable(2)]
	private string TrackTargetBlackboardKeyInternal;

	// Token: 0x0400B6A8 RID: 46760
	private EMoveTrajectory? TrajectoryInternal;

	// Token: 0x0400B6A9 RID: 46761
	private FName? BoneNameInternal;

	// Token: 0x0400B6AA RID: 46762
	[Nullable(2)]
	private string BoneNameStringInternal;

	// Token: 0x0400B6AB RID: 46763
	[Nullable(2)]
	private string SkeletonComponentNameInternal;

	// Token: 0x0400B6AC RID: 46764
	[Nullable(2)]
	private Dictionary<EBulletBeginVelocityLimit, float> BeginVelocityLimitMapInternal;

	// Token: 0x0400B6AD RID: 46765
	private EBulletDestOffset? DestOffsetForwardInternal;

	// Token: 0x0400B6AE RID: 46766
	[Nullable(2)]
	private Vector DestOffsetInternal;

	// Token: 0x0400B6AF RID: 46767
	[Nullable(2)]
	private string TrackTargetBoneInternal;
}

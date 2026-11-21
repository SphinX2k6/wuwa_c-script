using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x02002309 RID: 8969
[NullableContext(1)]
[Nullable(0)]
public class BulletDataMove
{
	// Token: 0x170021DB RID: 8667
	// (get) Token: 0x06016211 RID: 90641 RVA: 0x0066E94C File Offset: 0x0066CB4C
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

	// Token: 0x170021DC RID: 8668
	// (get) Token: 0x06016212 RID: 90642 RVA: 0x0066E981 File Offset: 0x0066CB81
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

	// Token: 0x170021DD RID: 8669
	// (get) Token: 0x06016213 RID: 90643 RVA: 0x0066E9B1 File Offset: 0x0066CBB1
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

	// Token: 0x170021DE RID: 8670
	// (get) Token: 0x06016214 RID: 90644 RVA: 0x0066E9D2 File Offset: 0x0066CBD2
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

	// Token: 0x170021DF RID: 8671
	// (get) Token: 0x06016215 RID: 90645 RVA: 0x0066E9FD File Offset: 0x0066CBFD
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

	// Token: 0x170021E0 RID: 8672
	// (get) Token: 0x06016216 RID: 90646 RVA: 0x0066EA28 File Offset: 0x0066CC28
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

	// Token: 0x170021E1 RID: 8673
	// (get) Token: 0x06016217 RID: 90647 RVA: 0x0066EA58 File Offset: 0x0066CC58
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

	// Token: 0x170021E2 RID: 8674
	// (get) Token: 0x06016218 RID: 90648 RVA: 0x0066EA8D File Offset: 0x0066CC8D
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

	// Token: 0x170021E3 RID: 8675
	// (get) Token: 0x06016219 RID: 90649 RVA: 0x0066EABD File Offset: 0x0066CCBD
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

	// Token: 0x170021E4 RID: 8676
	// (get) Token: 0x0601621A RID: 90650 RVA: 0x0066EAED File Offset: 0x0066CCED
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

	// Token: 0x170021E5 RID: 8677
	// (get) Token: 0x0601621B RID: 90651 RVA: 0x0066EB1D File Offset: 0x0066CD1D
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

	// Token: 0x170021E6 RID: 8678
	// (get) Token: 0x0601621C RID: 90652 RVA: 0x0066EB45 File Offset: 0x0066CD45
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

	// Token: 0x170021E7 RID: 8679
	// (get) Token: 0x0601621D RID: 90653 RVA: 0x0066EB70 File Offset: 0x0066CD70
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

	// Token: 0x170021E8 RID: 8680
	// (get) Token: 0x0601621E RID: 90654 RVA: 0x0066EBD4 File Offset: 0x0066CDD4
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

	// Token: 0x170021E9 RID: 8681
	// (get) Token: 0x0601621F RID: 90655 RVA: 0x0066EC29 File Offset: 0x0066CE29
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

	// Token: 0x170021EA RID: 8682
	// (get) Token: 0x06016220 RID: 90656 RVA: 0x0066EC5E File Offset: 0x0066CE5E
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

	// Token: 0x170021EB RID: 8683
	// (get) Token: 0x06016221 RID: 90657 RVA: 0x0066EC7F File Offset: 0x0066CE7F
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

	// Token: 0x170021EC RID: 8684
	// (get) Token: 0x06016222 RID: 90658 RVA: 0x0066ECB4 File Offset: 0x0066CEB4
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

	// Token: 0x170021ED RID: 8685
	// (get) Token: 0x06016223 RID: 90659 RVA: 0x0066ECE4 File Offset: 0x0066CEE4
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

	// Token: 0x170021EE RID: 8686
	// (get) Token: 0x06016224 RID: 90660 RVA: 0x0066ED19 File Offset: 0x0066CF19
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

	// Token: 0x170021EF RID: 8687
	// (get) Token: 0x06016225 RID: 90661 RVA: 0x0066ED3C File Offset: 0x0066CF3C
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

	// Token: 0x170021F0 RID: 8688
	// (get) Token: 0x06016226 RID: 90662 RVA: 0x0066EDCC File Offset: 0x0066CFCC
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

	// Token: 0x170021F1 RID: 8689
	// (get) Token: 0x06016227 RID: 90663 RVA: 0x0066EE01 File Offset: 0x0066D001
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

	// Token: 0x170021F2 RID: 8690
	// (get) Token: 0x06016228 RID: 90664 RVA: 0x0066EE2C File Offset: 0x0066D02C
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

	// Token: 0x06016229 RID: 90665 RVA: 0x0066EE4D File Offset: 0x0066D04D
	public BulletDataMove(SReBulletDataMove data)
	{
		this.Data = data;
	}

	// Token: 0x0601622A RID: 90666 RVA: 0x0066EE5C File Offset: 0x0066D05C
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

	// Token: 0x0400BA10 RID: 47632
	private readonly SReBulletDataMove Data;

	// Token: 0x0400BA11 RID: 47633
	private EInitialVelocityDirection? InitVelocityDirStandardInternal;

	// Token: 0x0400BA12 RID: 47634
	private bool? InitVelocityKeepUpInternal;

	// Token: 0x0400BA13 RID: 47635
	[Nullable(2)]
	private string InitVelocityDirParamInternal;

	// Token: 0x0400BA14 RID: 47636
	[Nullable(2)]
	private Rotator InitVelocityRotInternal;

	// Token: 0x0400BA15 RID: 47637
	[Nullable(2)]
	private Vector InitVelocityDirRandomInternal;

	// Token: 0x0400BA16 RID: 47638
	private float? UpDownAngleLimitInternal;

	// Token: 0x0400BA17 RID: 47639
	private EBulletFollowType? FollowTypeInternal;

	// Token: 0x0400BA18 RID: 47640
	private bool? IsLockScaleInternal;

	// Token: 0x0400BA19 RID: 47641
	private bool? IsDetachOnSkillEndInternal;

	// Token: 0x0400BA1A RID: 47642
	private float? SpeedInternal;

	// Token: 0x0400BA1B RID: 47643
	[Nullable(2)]
	private UCurveFloat SpeedCurveInternal;

	// Token: 0x0400BA1C RID: 47644
	private bool SpeedCurveInit;

	// Token: 0x0400BA1D RID: 47645
	[Nullable(2)]
	private Vector FollowSkeletonRotLimitInternal;

	// Token: 0x0400BA1E RID: 47646
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Vector[] TrackParamsInternal;

	// Token: 0x0400BA1F RID: 47647
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private UCurveVector[] TrackCurvesInternal;

	// Token: 0x0400BA20 RID: 47648
	private EBulletTarget? TrackTargetInternal;

	// Token: 0x0400BA21 RID: 47649
	[Nullable(2)]
	private string TrackTargetBlackboardKeyInternal;

	// Token: 0x0400BA22 RID: 47650
	private EMoveTrajectory? TrajectoryInternal;

	// Token: 0x0400BA23 RID: 47651
	private FName? BoneNameInternal;

	// Token: 0x0400BA24 RID: 47652
	[Nullable(2)]
	private string BoneNameStringInternal;

	// Token: 0x0400BA25 RID: 47653
	[Nullable(2)]
	private string SkeletonComponentNameInternal;

	// Token: 0x0400BA26 RID: 47654
	[Nullable(2)]
	private Dictionary<EBulletBeginVelocityLimit, float> BeginVelocityLimitMapInternal;

	// Token: 0x0400BA27 RID: 47655
	private EBulletDestOffset? DestOffsetForwardInternal;

	// Token: 0x0400BA28 RID: 47656
	[Nullable(2)]
	private Vector DestOffsetInternal;

	// Token: 0x0400BA29 RID: 47657
	[Nullable(2)]
	private string TrackTargetBoneInternal;
}

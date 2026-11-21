using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Structure;
using AkiClient.Game.Aki.Data.Level.KeepFollowing;
using UnrealEngine;

// Token: 0x020025BC RID: 9660
[NullableContext(1)]
[Nullable(0)]
public class HoldingHandsParams
{
	// Token: 0x06017FDF RID: 98271 RVA: 0x0072E8D4 File Offset: 0x0072CAD4
	[NullableContext(2)]
	public HoldingHandsParams(BP_HoldingHandsConfig_C asset = null)
	{
		if (asset == null)
		{
			return;
		}
		this.Debug = asset.Debug;
		this.ReachableTag = asset.牵手范围内.TagId();
		this.InvitingTags = GameplayTagUtils.ConvertFromUeContainer(asset.邀请中);
		this.LeadingTags = GameplayTagUtils.ConvertFromUeContainer(asset.牵手中);
		this.FollowingTags = GameplayTagUtils.ConvertFromUeContainer(asset.被牵手中);
		this.DisableTags = GameplayTagUtils.ConvertFromUeContainer(asset.牵手禁止);
		this.EndTime = (double)asset.超时终止时长;
		this.LongPressDuration = (double)asset.长按退出时长;
		this.IkAlphaDamping = (double)asset.进出牵手阻尼;
		this.BindVecDamping = (double)asset.牵手点阻尼;
		this.WalkRotateSpeedMax = (double)asset.走路最大旋转速度;
		this.RunRotateSpeedMax = (double)asset.跑步最大旋转速度;
		this.InputScaleRun = (double)asset.跑步速度缩放;
		FFloatRange 牵手点偏转角范围 = asset.牵手点偏转角范围;
		this.YawRange = new HoldingHandsRange(牵手点偏转角范围.LowerBound.Value, 牵手点偏转角范围.UpperBound.Value);
		FFloatRange 牵手点俯仰角范围 = asset.牵手点俯仰角范围;
		this.PitchRange = new HoldingHandsRange(牵手点俯仰角范围.LowerBound.Value, 牵手点俯仰角范围.UpperBound.Value);
		FFloatRange 肩部偏转角范围 = asset.肩部偏转角范围;
		this.ShoulderYawRange = new HoldingHandsRange(肩部偏转角范围.LowerBound.Value, 肩部偏转角范围.UpperBound.Value);
		FFloatRange 肩部俯仰角范围 = asset.肩部俯仰角范围;
		this.ShoulderPitchRange = new HoldingHandsRange(肩部俯仰角范围.LowerBound.Value, 肩部俯仰角范围.UpperBound.Value);
		this.ReachableExtraAngle = (double)asset.范围内额外角度;
		this.BindDistanceUnReachable = (double)asset.范围外牵手点最大距离;
		this.BindDistanceReachable = (double)asset.范围内牵手点最大距离;
		this.ReachableDistanceScale = (double)asset.范围内可达距离缩放;
		this.UnReachableDistanceScale = (double)asset.范围外可达距离缩放;
		this.ShoulderDeltaHeightReachable = (double)asset.范围内肩部最大高度差;
		this.ShoulderDeltaHeightUnReachable = (double)asset.范围外肩部最大高度差;
		this.LeaderHitPriority = asset.牵手者碰撞优先级;
		this.FollowerHitPriority = asset.被牵手者碰撞优先级;
		this.LeaderMass = asset.牵手者质量;
		this.FollowerMass = asset.被牵手者质量;
		this.InvitationDistance = (double)asset.邀请距离;
		this.InvitationDistanceTolerance = asset.邀请距离容差;
		this.InvitationEndDistance = (double)asset.邀请结束距离;
		this.InvitationEndDistanceTolerance = asset.邀请结束距离容差;
		this.InvitationEndMoveSpeed = asset.邀请结束移动速度;
		this.InvitationTurnSpeed = asset.邀请旋转速度;
		this.BindVecDampingInvitation = (double)asset.邀请时牵手点阻尼;
		this.HandMinAngle = (double)asset.手掌最小夹角;
		this.LeaderBindPosScale = (double)asset.牵手者牵手点位置缩放;
		this.FollowerBindPosScale = (double)asset.被牵手者牵手点位置缩放;
		this.BindPosDistance = (double)asset.贴合距离;
		this.KeepFollowingDa = asset.跟随配置;
	}

	// Token: 0x0400CDE2 RID: 52706
	public bool Debug;

	// Token: 0x0400CDE3 RID: 52707
	public int ReachableTag;

	// Token: 0x0400CDE4 RID: 52708
	public List<int> InvitingTags = new List<int>();

	// Token: 0x0400CDE5 RID: 52709
	public List<int> LeadingTags = new List<int>();

	// Token: 0x0400CDE6 RID: 52710
	public List<int> FollowingTags = new List<int>();

	// Token: 0x0400CDE7 RID: 52711
	public List<int> DisableTags = new List<int>();

	// Token: 0x0400CDE8 RID: 52712
	public double EndTime = 5.0;

	// Token: 0x0400CDE9 RID: 52713
	public double LongPressDuration = 1.0;

	// Token: 0x0400CDEA RID: 52714
	public double IkAlphaDamping = 500.0;

	// Token: 0x0400CDEB RID: 52715
	public double BindVecDamping = 100.0;

	// Token: 0x0400CDEC RID: 52716
	public double BindVecDampingInvitation = 400.0;

	// Token: 0x0400CDED RID: 52717
	public double WalkRotateSpeedMax = 180.0;

	// Token: 0x0400CDEE RID: 52718
	public double RunRotateSpeedMax = 180.0;

	// Token: 0x0400CDEF RID: 52719
	public double InputScaleRun = 1.0;

	// Token: 0x0400CDF0 RID: 52720
	public HoldingHandsRange YawRange = new HoldingHandsRange(-90f, 90f);

	// Token: 0x0400CDF1 RID: 52721
	public HoldingHandsRange PitchRange = new HoldingHandsRange(-90f, 90f);

	// Token: 0x0400CDF2 RID: 52722
	public HoldingHandsRange ShoulderYawRange = new HoldingHandsRange(-90f, 90f);

	// Token: 0x0400CDF3 RID: 52723
	public HoldingHandsRange ShoulderPitchRange = new HoldingHandsRange(-90f, 90f);

	// Token: 0x0400CDF4 RID: 52724
	public double ReachableExtraAngle = 5.0;

	// Token: 0x0400CDF5 RID: 52725
	public double BindDistanceUnReachable = 10.0;

	// Token: 0x0400CDF6 RID: 52726
	public double BindDistanceReachable = 30.0;

	// Token: 0x0400CDF7 RID: 52727
	public double UnReachableDistanceScale = 0.8;

	// Token: 0x0400CDF8 RID: 52728
	public double ReachableDistanceScale = 1.0;

	// Token: 0x0400CDF9 RID: 52729
	public double ShoulderDeltaHeightUnReachable = 35.0;

	// Token: 0x0400CDFA RID: 52730
	public double ShoulderDeltaHeightReachable = 40.0;

	// Token: 0x0400CDFB RID: 52731
	public int LeaderHitPriority = 50;

	// Token: 0x0400CDFC RID: 52732
	public int FollowerHitPriority = 49;

	// Token: 0x0400CDFD RID: 52733
	public float LeaderMass = 90f;

	// Token: 0x0400CDFE RID: 52734
	public float FollowerMass = 60f;

	// Token: 0x0400CDFF RID: 52735
	public double InvitationDistance = 83.0;

	// Token: 0x0400CE00 RID: 52736
	public float InvitationDistanceTolerance = 5f;

	// Token: 0x0400CE01 RID: 52737
	public double InvitationEndDistance = 55.0;

	// Token: 0x0400CE02 RID: 52738
	public float InvitationEndDistanceTolerance;

	// Token: 0x0400CE03 RID: 52739
	public float InvitationEndMoveSpeed = 50f;

	// Token: 0x0400CE04 RID: 52740
	public float InvitationTurnSpeed = 200f;

	// Token: 0x0400CE05 RID: 52741
	public double HandMinAngle = 45.0;

	// Token: 0x0400CE06 RID: 52742
	public double LeaderBindPosScale = 1.0;

	// Token: 0x0400CE07 RID: 52743
	public double FollowerBindPosScale = 1.0;

	// Token: 0x0400CE08 RID: 52744
	public double BindPosDistance = 2.0;

	// Token: 0x0400CE09 RID: 52745
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public TSoftObjectPtr<BP_KeepFollowingConfig_C> KeepFollowingDa;
}

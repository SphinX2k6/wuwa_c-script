using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Structure;
using AkiClient.Game.Aki.Data.Level.KeepFollowing;
using UnrealEngine;

// Token: 0x02003066 RID: 12390
[NullableContext(1)]
[Nullable(0)]
public class HoldingHandsParams
{
	// Token: 0x0601A62B RID: 108075 RVA: 0x00707F98 File Offset: 0x00706198
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

	// Token: 0x0400CA08 RID: 51720
	public bool Debug;

	// Token: 0x0400CA09 RID: 51721
	public int ReachableTag;

	// Token: 0x0400CA0A RID: 51722
	public List<int> InvitingTags = new List<int>();

	// Token: 0x0400CA0B RID: 51723
	public List<int> LeadingTags = new List<int>();

	// Token: 0x0400CA0C RID: 51724
	public List<int> FollowingTags = new List<int>();

	// Token: 0x0400CA0D RID: 51725
	public List<int> DisableTags = new List<int>();

	// Token: 0x0400CA0E RID: 51726
	public double EndTime = 5.0;

	// Token: 0x0400CA0F RID: 51727
	public double LongPressDuration = 1.0;

	// Token: 0x0400CA10 RID: 51728
	public double IkAlphaDamping = 500.0;

	// Token: 0x0400CA11 RID: 51729
	public double BindVecDamping = 100.0;

	// Token: 0x0400CA12 RID: 51730
	public double BindVecDampingInvitation = 400.0;

	// Token: 0x0400CA13 RID: 51731
	public double WalkRotateSpeedMax = 180.0;

	// Token: 0x0400CA14 RID: 51732
	public double RunRotateSpeedMax = 180.0;

	// Token: 0x0400CA15 RID: 51733
	public double InputScaleRun = 1.0;

	// Token: 0x0400CA16 RID: 51734
	public HoldingHandsRange YawRange = new HoldingHandsRange(-90f, 90f);

	// Token: 0x0400CA17 RID: 51735
	public HoldingHandsRange PitchRange = new HoldingHandsRange(-90f, 90f);

	// Token: 0x0400CA18 RID: 51736
	public HoldingHandsRange ShoulderYawRange = new HoldingHandsRange(-90f, 90f);

	// Token: 0x0400CA19 RID: 51737
	public HoldingHandsRange ShoulderPitchRange = new HoldingHandsRange(-90f, 90f);

	// Token: 0x0400CA1A RID: 51738
	public double ReachableExtraAngle = 5.0;

	// Token: 0x0400CA1B RID: 51739
	public double BindDistanceUnReachable = 10.0;

	// Token: 0x0400CA1C RID: 51740
	public double BindDistanceReachable = 30.0;

	// Token: 0x0400CA1D RID: 51741
	public double UnReachableDistanceScale = 0.8;

	// Token: 0x0400CA1E RID: 51742
	public double ReachableDistanceScale = 1.0;

	// Token: 0x0400CA1F RID: 51743
	public double ShoulderDeltaHeightUnReachable = 35.0;

	// Token: 0x0400CA20 RID: 51744
	public double ShoulderDeltaHeightReachable = 40.0;

	// Token: 0x0400CA21 RID: 51745
	public int LeaderHitPriority = 50;

	// Token: 0x0400CA22 RID: 51746
	public int FollowerHitPriority = 49;

	// Token: 0x0400CA23 RID: 51747
	public float LeaderMass = 90f;

	// Token: 0x0400CA24 RID: 51748
	public float FollowerMass = 60f;

	// Token: 0x0400CA25 RID: 51749
	public double InvitationDistance = 83.0;

	// Token: 0x0400CA26 RID: 51750
	public float InvitationDistanceTolerance = 5f;

	// Token: 0x0400CA27 RID: 51751
	public double InvitationEndDistance = 55.0;

	// Token: 0x0400CA28 RID: 51752
	public float InvitationEndDistanceTolerance;

	// Token: 0x0400CA29 RID: 51753
	public float InvitationEndMoveSpeed = 50f;

	// Token: 0x0400CA2A RID: 51754
	public float InvitationTurnSpeed = 200f;

	// Token: 0x0400CA2B RID: 51755
	public double HandMinAngle = 45.0;

	// Token: 0x0400CA2C RID: 51756
	public double LeaderBindPosScale = 1.0;

	// Token: 0x0400CA2D RID: 51757
	public double FollowerBindPosScale = 1.0;

	// Token: 0x0400CA2E RID: 51758
	public double BindPosDistance = 2.0;

	// Token: 0x0400CA2F RID: 51759
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public TSoftObjectPtr<BP_KeepFollowingConfig_C> KeepFollowingDa;
}

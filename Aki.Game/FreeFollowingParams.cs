using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.KeepFollowing;

// Token: 0x02002666 RID: 9830
[NullableContext(1)]
[Nullable(0)]
public class FreeFollowingParams
{
	// Token: 0x060189B8 RID: 100792 RVA: 0x00775E0C File Offset: 0x0077400C
	public FreeFollowingParams()
	{
	}

	// Token: 0x060189B9 RID: 100793 RVA: 0x00775EC0 File Offset: 0x007740C0
	public FreeFollowingParams(SFreeFollowingConfig data)
	{
		this.Enable = data.Enable;
		this.FollowOnRight = data.FollowOnRight;
		this.AutoChangeSide = data.AutoChangeSide;
		this.EnableLocalMovementHold = data.EnableLocalMovementHold;
		this.MovementIntentSmoothingTime = (double)data.MovementIntentSmoothingTime;
		this.LocalMovementEnterRate = MathUtils.Instance.Clamp((double)data.LocalMovementEnterRate, 0.0, 0.7);
		this.LocalMovementEnterConfirmTime = (double)data.LocalMovementEnterConfirmTime;
		this.RunReferenceDirectionSmoothingTime = (double)data.RunReferenceDirectionSmoothingTime;
		this.SprintReferenceDirectionSmoothingTime = (double)data.SprintReferenceDirectionSmoothingTime;
		this.StopConfirmTime = (double)data.StopConfirmTime;
		this.WalkBehindTargetPauseTime = (double)data.WalkBehindTargetPauseTime;
		this.StartFollowingRadius = (double)data.StartFollowingRadius;
		this.FollowRadius = (double)data.FollowRadius;
		this.MaxForwardOffset = (double)Math.Max(0f, data.MaxForwardOffset);
		this.FullForwardOffsetSpeed = (double)((data.FullForwardOffsetSpeed <= 0f) ? 600f : data.FullForwardOffsetSpeed);
		this.SideAngleTolerance = (double)MathUtils.Instance.Clamp(data.SideAngleTolerance, 0f, 89f);
		this.OffsetAngle = (double)MathUtils.Instance.Clamp(data.OffsetAngle, -89f, 89f);
		this.EnableNavMeshPath = data.EnableNavMeshPath;
		this.DebugDraw = data.DebugDraw;
		if (!this.Enable)
		{
			return;
		}
		if (this.FollowRadius <= 0.0)
		{
			this.Enable = false;
			this.InvalidReason = "FollowRadius必须大于0";
			return;
		}
		if (this.StartFollowingRadius < this.FollowRadius)
		{
			this.StartFollowingRadius = this.FollowRadius;
			this.ClampedStartFollowingRadius = true;
		}
		this.WalkFollowRadius = ((data.WalkFollowRadius <= 0f) ? this.FollowRadius : ((double)data.WalkFollowRadius));
		this.WalkStartFollowingRadius = ((data.WalkStartFollowingRadius <= 0f) ? this.StartFollowingRadius : ((double)data.WalkStartFollowingRadius));
		if (this.WalkStartFollowingRadius < this.WalkFollowRadius)
		{
			this.WalkStartFollowingRadius = this.WalkFollowRadius;
			this.ClampedWalkStartFollowingRadius = true;
		}
	}

	// Token: 0x0400D57E RID: 54654
	public bool Enable;

	// Token: 0x0400D57F RID: 54655
	public bool FollowOnRight = true;

	// Token: 0x0400D580 RID: 54656
	public bool AutoChangeSide;

	// Token: 0x0400D581 RID: 54657
	public bool EnableLocalMovementHold = true;

	// Token: 0x0400D582 RID: 54658
	public double MovementIntentSmoothingTime = 0.5;

	// Token: 0x0400D583 RID: 54659
	public double LocalMovementEnterRate = 0.55;

	// Token: 0x0400D584 RID: 54660
	public double LocalMovementEnterConfirmTime = 0.35;

	// Token: 0x0400D585 RID: 54661
	public double RunReferenceDirectionSmoothingTime = 0.2;

	// Token: 0x0400D586 RID: 54662
	public double SprintReferenceDirectionSmoothingTime = 0.12;

	// Token: 0x0400D587 RID: 54663
	public double StopConfirmTime = 0.2;

	// Token: 0x0400D588 RID: 54664
	public double WalkBehindTargetPauseTime = 1.0;

	// Token: 0x0400D589 RID: 54665
	public double StartFollowingRadius;

	// Token: 0x0400D58A RID: 54666
	public double FollowRadius;

	// Token: 0x0400D58B RID: 54667
	public double WalkStartFollowingRadius;

	// Token: 0x0400D58C RID: 54668
	public double WalkFollowRadius;

	// Token: 0x0400D58D RID: 54669
	public double MaxForwardOffset;

	// Token: 0x0400D58E RID: 54670
	public double FullForwardOffsetSpeed = 600.0;

	// Token: 0x0400D58F RID: 54671
	public double SideAngleTolerance = 30.0;

	// Token: 0x0400D590 RID: 54672
	public double OffsetAngle;

	// Token: 0x0400D591 RID: 54673
	public bool EnableNavMeshPath;

	// Token: 0x0400D592 RID: 54674
	public string InvalidReason = "";

	// Token: 0x0400D593 RID: 54675
	public bool ClampedStartFollowingRadius;

	// Token: 0x0400D594 RID: 54676
	public bool ClampedWalkStartFollowingRadius;

	// Token: 0x0400D595 RID: 54677
	public bool DebugDraw;
}

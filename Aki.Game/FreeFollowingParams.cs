using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.KeepFollowing;

// Token: 0x0200310B RID: 12555
[NullableContext(1)]
[Nullable(0)]
public class FreeFollowingParams
{
	// Token: 0x0601AF69 RID: 110441 RVA: 0x0074FC50 File Offset: 0x0074DE50
	public FreeFollowingParams()
	{
	}

	// Token: 0x0601AF6A RID: 110442 RVA: 0x0074FD04 File Offset: 0x0074DF04
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
		this.OffsetAngle = (double)MathUtils.Instance.Clamp(data.OffsetAngle, 0f, 89f);
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

	// Token: 0x0400D15E RID: 53598
	public bool Enable;

	// Token: 0x0400D15F RID: 53599
	public bool FollowOnRight = true;

	// Token: 0x0400D160 RID: 53600
	public bool AutoChangeSide;

	// Token: 0x0400D161 RID: 53601
	public bool EnableLocalMovementHold = true;

	// Token: 0x0400D162 RID: 53602
	public double MovementIntentSmoothingTime = 0.5;

	// Token: 0x0400D163 RID: 53603
	public double LocalMovementEnterRate = 0.55;

	// Token: 0x0400D164 RID: 53604
	public double LocalMovementEnterConfirmTime = 0.35;

	// Token: 0x0400D165 RID: 53605
	public double RunReferenceDirectionSmoothingTime = 0.2;

	// Token: 0x0400D166 RID: 53606
	public double SprintReferenceDirectionSmoothingTime = 0.12;

	// Token: 0x0400D167 RID: 53607
	public double StopConfirmTime = 0.2;

	// Token: 0x0400D168 RID: 53608
	public double WalkBehindTargetPauseTime = 1.0;

	// Token: 0x0400D169 RID: 53609
	public double StartFollowingRadius;

	// Token: 0x0400D16A RID: 53610
	public double FollowRadius;

	// Token: 0x0400D16B RID: 53611
	public double WalkStartFollowingRadius;

	// Token: 0x0400D16C RID: 53612
	public double WalkFollowRadius;

	// Token: 0x0400D16D RID: 53613
	public double MaxForwardOffset;

	// Token: 0x0400D16E RID: 53614
	public double FullForwardOffsetSpeed = 600.0;

	// Token: 0x0400D16F RID: 53615
	public double SideAngleTolerance = 30.0;

	// Token: 0x0400D170 RID: 53616
	public double OffsetAngle;

	// Token: 0x0400D171 RID: 53617
	public string InvalidReason = "";

	// Token: 0x0400D172 RID: 53618
	public bool ClampedStartFollowingRadius;

	// Token: 0x0400D173 RID: 53619
	public bool ClampedWalkStartFollowingRadius;

	// Token: 0x0400D174 RID: 53620
	public bool DebugDraw;
}

using System;
using Aki.Config;

// Token: 0x020000F3 RID: 243
public class AiSenseObject
{
	// Token: 0x06000DC5 RID: 3525 RVA: 0x0004D030 File Offset: 0x0004B230
	public AiSenseObject(AiSense aiSense)
	{
		this.AiSense = aiSense;
		this.WithAngleHorizontal = (this.AiSense.HorizontalAngle.Value.Min > -180f || this.AiSense.HorizontalAngle.Value.Max < 180f);
		this.WithAngleVertical = (this.AiSense.VerticalAngle.Value.Min > -90f || this.AiSense.VerticalAngle.Value.Max < 90f);
		this.SquaredDisMin = this.AiSense.SenseDistanceRange.Value.Min * this.AiSense.SenseDistanceRange.Value.Min;
		this.SquaredDisMax = this.AiSense.SenseDistanceRange.Value.Max * this.AiSense.SenseDistanceRange.Value.Max;
		this.SquaredWalkSenseRate = this.AiSense.WalkSenseRate * this.AiSense.WalkSenseRate;
		this.SquaredAirSenseRate = this.AiSense.AirSenseRate * this.AiSense.AirSenseRate;
	}

	// Token: 0x06000DC6 RID: 3526 RVA: 0x0004D198 File Offset: 0x0004B398
	public bool InArea(double squaredDist, float angleHorizontal, float angleVertical, ECharPositionState positionState, ECharMoveState moveState, bool inSenseBefore)
	{
		if (this.WithAngleHorizontal && !MathUtils.Instance.InRange((double)angleHorizontal, this.AiSense.HorizontalAngle.Value))
		{
			return false;
		}
		if (this.WithAngleVertical && !MathUtils.Instance.InRange((double)angleVertical, this.AiSense.VerticalAngle.Value))
		{
			return false;
		}
		double num = squaredDist;
		if (positionState == ECharPositionState.Ground)
		{
			if (moveState == ECharMoveState.Other || moveState == ECharMoveState.Stand || moveState == ECharMoveState.Walk || moveState == ECharMoveState.WalkStop)
			{
				num /= (double)this.SquaredWalkSenseRate;
			}
		}
		else if (moveState == ECharMoveState.Glide)
		{
			num /= (double)this.SquaredAirSenseRate;
		}
		return !(inSenseBefore ? (num > (double)this.SquaredDisMax) : (num > (double)this.SquaredDisMin));
	}

	// Token: 0x04000B1D RID: 2845
	public readonly bool WithAngleHorizontal;

	// Token: 0x04000B1E RID: 2846
	public readonly bool WithAngleVertical;

	// Token: 0x04000B1F RID: 2847
	private readonly float SquaredDisMin;

	// Token: 0x04000B20 RID: 2848
	private readonly float SquaredDisMax;

	// Token: 0x04000B21 RID: 2849
	private readonly float SquaredWalkSenseRate;

	// Token: 0x04000B22 RID: 2850
	private readonly float SquaredAirSenseRate;

	// Token: 0x04000B23 RID: 2851
	public readonly AiSense AiSense;

	// Token: 0x04000B24 RID: 2852
	private const float MINUS_HALF = -180f;

	// Token: 0x04000B25 RID: 2853
	private const float MINUS_QUATER = -90f;
}

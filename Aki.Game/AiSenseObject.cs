using System;
using Aki.Config;

// Token: 0x020000F3 RID: 243
public class AiSenseObject
{
	// Token: 0x06000DCB RID: 3531 RVA: 0x0004DBC0 File Offset: 0x0004BDC0
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

	// Token: 0x06000DCC RID: 3532 RVA: 0x0004DD28 File Offset: 0x0004BF28
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

	// Token: 0x04000B25 RID: 2853
	public readonly bool WithAngleHorizontal;

	// Token: 0x04000B26 RID: 2854
	public readonly bool WithAngleVertical;

	// Token: 0x04000B27 RID: 2855
	private readonly float SquaredDisMin;

	// Token: 0x04000B28 RID: 2856
	private readonly float SquaredDisMax;

	// Token: 0x04000B29 RID: 2857
	private readonly float SquaredWalkSenseRate;

	// Token: 0x04000B2A RID: 2858
	private readonly float SquaredAirSenseRate;

	// Token: 0x04000B2B RID: 2859
	public readonly AiSense AiSense;

	// Token: 0x04000B2C RID: 2860
	private const float MINUS_HALF = -180f;

	// Token: 0x04000B2D RID: 2861
	private const float MINUS_QUATER = -90f;
}

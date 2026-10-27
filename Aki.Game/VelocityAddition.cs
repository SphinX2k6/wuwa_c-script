using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003034 RID: 12340
[NullableContext(2)]
[Nullable(0)]
public class VelocityAddition
{
	// Token: 0x0601A25B RID: 107099 RVA: 0x006DEA7C File Offset: 0x006DCC7C
	public float VelocityCurveFunc(float delta)
	{
		float currentValue = delta;
		switch (this.VelocityCurveType)
		{
		case EVelocityCurveType.Convex:
			currentValue = (float)MathUtils.Instance.BlendEaseIn((double)this.VelocityCurveMax, (double)this.VelocityCurveMin, delta, 2.0);
			break;
		case EVelocityCurveType.LinearityDown:
			currentValue = this.VelocityCurveMax + (this.VelocityCurveMin - this.VelocityCurveMax) * delta;
			break;
		case EVelocityCurveType.Concave:
			currentValue = (float)MathUtils.Instance.BlendEaseIn((double)this.VelocityCurveMin, (double)this.VelocityCurveMax, delta - 1f, 2.0);
			break;
		}
		return MathUtils.Instance.Clamp(currentValue, 0f, 1f);
	}

	// Token: 0x0601A25C RID: 107100 RVA: 0x006DEB28 File Offset: 0x006DCD28
	public VelocityAddition(float duration, FVectorDouble velocity, UCurveFloat curveFloat, int movementMode, EVelocityCurveType velocityCurveType, float velocityCurveMin, float velocityCurveMax)
	{
		this.ElapsedTime = 0f;
		this.Duration = duration;
		this.Velocity = new FVectorDouble?(velocity);
		this.CurveFloat = curveFloat;
		this.MovementMode = movementMode;
		this.VelocityCurveType = velocityCurveType;
		this.VelocityCurveMin = velocityCurveMin;
		this.VelocityCurveMax = velocityCurveMax;
	}

	// Token: 0x0400C696 RID: 50838
	public float ElapsedTime;

	// Token: 0x0400C697 RID: 50839
	public float Duration;

	// Token: 0x0400C698 RID: 50840
	public FVectorDouble? Velocity;

	// Token: 0x0400C699 RID: 50841
	public UCurveFloat CurveFloat;

	// Token: 0x0400C69A RID: 50842
	public int MovementMode;

	// Token: 0x0400C69B RID: 50843
	public EVelocityCurveType VelocityCurveType;

	// Token: 0x0400C69C RID: 50844
	public float VelocityCurveMin;

	// Token: 0x0400C69D RID: 50845
	public float VelocityCurveMax;
}

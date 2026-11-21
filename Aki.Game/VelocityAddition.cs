using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200258A RID: 9610
[NullableContext(2)]
[Nullable(0)]
public class VelocityAddition
{
	// Token: 0x06017BB9 RID: 97209 RVA: 0x00706770 File Offset: 0x00704970
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

	// Token: 0x06017BBA RID: 97210 RVA: 0x0070681C File Offset: 0x00704A1C
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

	// Token: 0x0400CA65 RID: 51813
	public float ElapsedTime;

	// Token: 0x0400CA66 RID: 51814
	public float Duration;

	// Token: 0x0400CA67 RID: 51815
	public FVectorDouble? Velocity;

	// Token: 0x0400CA68 RID: 51816
	public UCurveFloat CurveFloat;

	// Token: 0x0400CA69 RID: 51817
	public int MovementMode;

	// Token: 0x0400CA6A RID: 51818
	public EVelocityCurveType VelocityCurveType;

	// Token: 0x0400CA6B RID: 51819
	public float VelocityCurveMin;

	// Token: 0x0400CA6C RID: 51820
	public float VelocityCurveMax;
}

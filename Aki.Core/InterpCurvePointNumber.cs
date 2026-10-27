using System;
using UnrealEngine;

// Token: 0x020000E9 RID: 233
public class InterpCurvePointNumber : ICurvePoint<float>
{
	// Token: 0x060006F8 RID: 1784 RVA: 0x00024EDC File Offset: 0x000230DC
	public InterpCurvePointNumber(global::EInterpCurveMode param)
	{
		this.InterpMode = param;
	}

	// Token: 0x060006F9 RID: 1785 RVA: 0x00024EEB File Offset: 0x000230EB
	public InterpCurvePointNumber(UnrealEngine.EInterpCurveMode param)
	{
		this.InterpMode = SplineCurve.getTsInterpCurveMode(param);
	}

	// Token: 0x060006FA RID: 1786 RVA: 0x00024F00 File Offset: 0x00023100
	public void DeepCopy(FInterpCurvePointFloat param)
	{
		this.InVal = param.InVal;
		this.OutVal = param.OutVal;
		this.ArriveTangent = param.ArriveTangent;
		this.LeaveTangent = param.LeaveTangent;
		this.InterpMode = SplineCurve.getTsInterpCurveMode(param.InterpMode);
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x00024F53 File Offset: 0x00023153
	public void Clear()
	{
		this.InVal = 0f;
		this.ArriveTangent = 0f;
		this.LeaveTangent = 0f;
		this.OutVal = 0f;
	}

	// Token: 0x0400059F RID: 1439
	public global::EInterpCurveMode InterpMode;
}

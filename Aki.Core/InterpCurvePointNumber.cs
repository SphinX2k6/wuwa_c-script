using System;
using UnrealEngine;

// Token: 0x020000EB RID: 235
public class InterpCurvePointNumber : ICurvePoint<float>
{
	// Token: 0x06000739 RID: 1849 RVA: 0x000254B0 File Offset: 0x000236B0
	public InterpCurvePointNumber(global::EInterpCurveMode param)
	{
		this.InterpMode = param;
	}

	// Token: 0x0600073A RID: 1850 RVA: 0x000254BF File Offset: 0x000236BF
	public InterpCurvePointNumber(UnrealEngine.EInterpCurveMode param)
	{
		this.InterpMode = SplineCurve.getTsInterpCurveMode(param);
	}

	// Token: 0x0600073B RID: 1851 RVA: 0x000254D4 File Offset: 0x000236D4
	public void DeepCopy(FInterpCurvePointFloat param)
	{
		this.InVal = param.InVal;
		this.OutVal = param.OutVal;
		this.ArriveTangent = param.ArriveTangent;
		this.LeaveTangent = param.LeaveTangent;
		this.InterpMode = SplineCurve.getTsInterpCurveMode(param.InterpMode);
	}

	// Token: 0x0600073C RID: 1852 RVA: 0x00025527 File Offset: 0x00023727
	public void Clear()
	{
		this.InVal = 0f;
		this.ArriveTangent = 0f;
		this.LeaveTangent = 0f;
		this.OutVal = 0f;
	}

	// Token: 0x040005AE RID: 1454
	public global::EInterpCurveMode InterpMode;
}

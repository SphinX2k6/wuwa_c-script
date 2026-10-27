using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000E8 RID: 232
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class InterpCurvePointQuat : ICurvePoint<Quat>
{
	// Token: 0x060006F4 RID: 1780 RVA: 0x00024E1B File Offset: 0x0002301B
	public InterpCurvePointQuat(global::EInterpCurveMode param)
	{
		this.InterpMode = param;
	}

	// Token: 0x060006F5 RID: 1781 RVA: 0x00024E31 File Offset: 0x00023031
	public InterpCurvePointQuat(UnrealEngine.EInterpCurveMode param)
	{
		this.InterpMode = SplineCurve.getTsInterpCurveMode(param);
	}

	// Token: 0x060006F6 RID: 1782 RVA: 0x00024E4C File Offset: 0x0002304C
	public void DeepCopy(FInterpCurvePointQuat param)
	{
		this.InVal = param.InVal;
		this.OutVal.DeepCopy(param.OutVal);
		this.ArriveTangent.DeepCopy(param.ArriveTangent);
		this.LeaveTangent.DeepCopy(param.LeaveTangent);
		this.InterpMode = SplineCurve.getTsInterpCurveMode(param.InterpMode);
	}

	// Token: 0x060006F7 RID: 1783 RVA: 0x00024EAE File Offset: 0x000230AE
	public void Clear()
	{
		this.InVal = 0f;
		this.ArriveTangent.Reset();
		this.LeaveTangent.Reset();
		this.OutVal.Reset();
	}

	// Token: 0x0400059E RID: 1438
	public global::EInterpCurveMode InterpMode = global::EInterpCurveMode.CurveAuto;
}

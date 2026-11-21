using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000EA RID: 234
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class InterpCurvePointQuat : ICurvePoint<Quat>
{
	// Token: 0x06000735 RID: 1845 RVA: 0x000253EF File Offset: 0x000235EF
	public InterpCurvePointQuat(global::EInterpCurveMode param)
	{
		this.InterpMode = param;
	}

	// Token: 0x06000736 RID: 1846 RVA: 0x00025405 File Offset: 0x00023605
	public InterpCurvePointQuat(UnrealEngine.EInterpCurveMode param)
	{
		this.InterpMode = SplineCurve.getTsInterpCurveMode(param);
	}

	// Token: 0x06000737 RID: 1847 RVA: 0x00025420 File Offset: 0x00023620
	public void DeepCopy(FInterpCurvePointQuat param)
	{
		this.InVal = param.InVal;
		this.OutVal.DeepCopy(param.OutVal);
		this.ArriveTangent.DeepCopy(param.ArriveTangent);
		this.LeaveTangent.DeepCopy(param.LeaveTangent);
		this.InterpMode = SplineCurve.getTsInterpCurveMode(param.InterpMode);
	}

	// Token: 0x06000738 RID: 1848 RVA: 0x00025482 File Offset: 0x00023682
	public void Clear()
	{
		this.InVal = 0f;
		this.ArriveTangent.Reset();
		this.LeaveTangent.Reset();
		this.OutVal.Reset();
	}

	// Token: 0x040005AD RID: 1453
	public global::EInterpCurveMode InterpMode = global::EInterpCurveMode.CurveAuto;
}

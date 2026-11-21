using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000E9 RID: 233
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class InterpCurvePointVector : ICurvePoint<Vector>
{
	// Token: 0x06000730 RID: 1840 RVA: 0x000252C9 File Offset: 0x000234C9
	public InterpCurvePointVector(global::EInterpCurveMode param)
	{
		this.InterpMode = param;
	}

	// Token: 0x06000731 RID: 1841 RVA: 0x000252D8 File Offset: 0x000234D8
	public InterpCurvePointVector(UnrealEngine.EInterpCurveMode param)
	{
		this.InterpMode = SplineCurve.getTsInterpCurveMode(param);
	}

	// Token: 0x06000732 RID: 1842 RVA: 0x000252EC File Offset: 0x000234EC
	public void DeepCopy(InterpCurvePointVector param)
	{
		this.InVal = param.InVal;
		this.OutVal.DeepCopy(param.OutVal);
		this.ArriveTangent.DeepCopy(param.ArriveTangent);
		this.LeaveTangent.DeepCopy(param.LeaveTangent);
		this.InterpMode = param.InterpMode;
	}

	// Token: 0x06000733 RID: 1843 RVA: 0x00025344 File Offset: 0x00023544
	public void DeepCopy(FInterpCurvePointVector param)
	{
		this.InVal = param.InVal;
		Vector outVal = this.OutVal;
		FVectorDouble fvectorDouble = param.OutVal;
		outVal.DeepCopy(fvectorDouble);
		Vector arriveTangent = this.ArriveTangent;
		fvectorDouble = param.ArriveTangent;
		arriveTangent.DeepCopy(fvectorDouble);
		Vector leaveTangent = this.LeaveTangent;
		fvectorDouble = param.LeaveTangent;
		leaveTangent.DeepCopy(fvectorDouble);
		this.InterpMode = SplineCurve.getTsInterpCurveMode(param.InterpMode);
	}

	// Token: 0x06000734 RID: 1844 RVA: 0x000253C1 File Offset: 0x000235C1
	public void Clear()
	{
		this.InVal = 0f;
		this.ArriveTangent.Reset();
		this.LeaveTangent.Reset();
		this.OutVal.Reset();
	}

	// Token: 0x040005AC RID: 1452
	public global::EInterpCurveMode InterpMode;
}

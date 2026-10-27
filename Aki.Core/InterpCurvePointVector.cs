using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000E7 RID: 231
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class InterpCurvePointVector : ICurvePoint<Vector>
{
	// Token: 0x060006EF RID: 1775 RVA: 0x00024CF5 File Offset: 0x00022EF5
	public InterpCurvePointVector(global::EInterpCurveMode param)
	{
		this.InterpMode = param;
	}

	// Token: 0x060006F0 RID: 1776 RVA: 0x00024D04 File Offset: 0x00022F04
	public InterpCurvePointVector(UnrealEngine.EInterpCurveMode param)
	{
		this.InterpMode = SplineCurve.getTsInterpCurveMode(param);
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x00024D18 File Offset: 0x00022F18
	public void DeepCopy(InterpCurvePointVector param)
	{
		this.InVal = param.InVal;
		this.OutVal.DeepCopy(param.OutVal);
		this.ArriveTangent.DeepCopy(param.ArriveTangent);
		this.LeaveTangent.DeepCopy(param.LeaveTangent);
		this.InterpMode = param.InterpMode;
	}

	// Token: 0x060006F2 RID: 1778 RVA: 0x00024D70 File Offset: 0x00022F70
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

	// Token: 0x060006F3 RID: 1779 RVA: 0x00024DED File Offset: 0x00022FED
	public void Clear()
	{
		this.InVal = 0f;
		this.ArriveTangent.Reset();
		this.LeaveTangent.Reset();
		this.OutVal.Reset();
	}

	// Token: 0x0400059D RID: 1437
	public global::EInterpCurveMode InterpMode;
}

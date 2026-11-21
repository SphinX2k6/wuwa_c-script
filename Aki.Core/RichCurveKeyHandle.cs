using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000DC RID: 220
public class RichCurveKeyHandle
{
	// Token: 0x0600070D RID: 1805 RVA: 0x000246E1 File Offset: 0x000228E1
	public RichCurveKeyHandle()
	{
	}

	// Token: 0x0600070E RID: 1806 RVA: 0x000246EC File Offset: 0x000228EC
	[NullableContext(2)]
	public RichCurveKeyHandle(RichCurveKeyHandle richCurveKey = null)
	{
		if (richCurveKey == null)
		{
			return;
		}
		this.ArriveTangent = richCurveKey.ArriveTangent;
		this.ArriveTangentWeight = richCurveKey.ArriveTangentWeight;
		this.InterpMode = richCurveKey.InterpMode;
		this.LeaveTangent = richCurveKey.LeaveTangent;
		this.LeaveTangentWeight = richCurveKey.LeaveTangentWeight;
		this.TangentMode = richCurveKey.TangentMode;
		this.TangentWeightMode = richCurveKey.TangentWeightMode;
		this.Time = richCurveKey.Time;
		this.Value = richCurveKey.Value;
	}

	// Token: 0x0600070F RID: 1807 RVA: 0x00024770 File Offset: 0x00022970
	public RichCurveKeyHandle(FRichCurveKey? richCurveKey = null)
	{
		if (richCurveKey == null)
		{
			return;
		}
		FRichCurveKey value = richCurveKey.Value;
		this.ArriveTangent = value.ArriveTangent;
		this.ArriveTangentWeight = value.ArriveTangentWeight;
		this.InterpMode = value.InterpMode;
		this.LeaveTangent = value.LeaveTangent;
		this.LeaveTangentWeight = value.LeaveTangentWeight;
		this.TangentMode = value.TangentMode;
		this.TangentWeightMode = value.TangentWeightMode;
		this.Time = value.Time;
		this.Value = value.Value;
	}

	// Token: 0x06000710 RID: 1808 RVA: 0x00024810 File Offset: 0x00022A10
	public FRichCurveKey ToUeRichCurveKey()
	{
		return new FRichCurveKey(this.InterpMode, this.TangentMode, this.TangentWeightMode, this.Time, this.Value, this.ArriveTangent, this.ArriveTangentWeight, this.LeaveTangent, this.LeaveTangentWeight);
	}

	// Token: 0x04000581 RID: 1409
	public float ArriveTangent;

	// Token: 0x04000582 RID: 1410
	public float ArriveTangentWeight;

	// Token: 0x04000583 RID: 1411
	public ERichCurveInterpMode InterpMode;

	// Token: 0x04000584 RID: 1412
	public float LeaveTangent;

	// Token: 0x04000585 RID: 1413
	public float LeaveTangentWeight;

	// Token: 0x04000586 RID: 1414
	public ERichCurveTangentMode TangentMode;

	// Token: 0x04000587 RID: 1415
	public ERichCurveTangentWeightMode TangentWeightMode;

	// Token: 0x04000588 RID: 1416
	public float Time;

	// Token: 0x04000589 RID: 1417
	public float Value;
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000DA RID: 218
public class RichCurveKeyHandle
{
	// Token: 0x060006CC RID: 1740 RVA: 0x0002410D File Offset: 0x0002230D
	public RichCurveKeyHandle()
	{
	}

	// Token: 0x060006CD RID: 1741 RVA: 0x00024118 File Offset: 0x00022318
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

	// Token: 0x060006CE RID: 1742 RVA: 0x0002419C File Offset: 0x0002239C
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

	// Token: 0x060006CF RID: 1743 RVA: 0x0002423C File Offset: 0x0002243C
	public FRichCurveKey ToUeRichCurveKey()
	{
		return new FRichCurveKey(this.InterpMode, this.TangentMode, this.TangentWeightMode, this.Time, this.Value, this.ArriveTangent, this.ArriveTangentWeight, this.LeaveTangent, this.LeaveTangentWeight);
	}

	// Token: 0x04000572 RID: 1394
	public float ArriveTangent;

	// Token: 0x04000573 RID: 1395
	public float ArriveTangentWeight;

	// Token: 0x04000574 RID: 1396
	public ERichCurveInterpMode InterpMode;

	// Token: 0x04000575 RID: 1397
	public float LeaveTangent;

	// Token: 0x04000576 RID: 1398
	public float LeaveTangentWeight;

	// Token: 0x04000577 RID: 1399
	public ERichCurveTangentMode TangentMode;

	// Token: 0x04000578 RID: 1400
	public ERichCurveTangentWeightMode TangentWeightMode;

	// Token: 0x04000579 RID: 1401
	public float Time;

	// Token: 0x0400057A RID: 1402
	public float Value;
}

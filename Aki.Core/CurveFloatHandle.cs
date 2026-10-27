using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000DB RID: 219
[NullableContext(1)]
[Nullable(0)]
public class CurveFloatHandle
{
	// Token: 0x060006D0 RID: 1744 RVA: 0x00024294 File Offset: 0x00022494
	[NullableContext(2)]
	public CurveFloatHandle(UCurveFloat curveFloat = null)
	{
		if (curveFloat == null)
		{
			return;
		}
		this.IsEventCurve = curveFloat.bIsEventCurve;
		for (int i = 0; i < curveFloat.FloatCurve.Keys.Num(); i++)
		{
			FRichCurveKey value = curveFloat.FloatCurve.Keys.Get(i);
			this.FloatCurveKeys.Add(new RichCurveKeyHandle(new FRichCurveKey?(value)));
		}
		this.FloatCurveDefaultValue = curveFloat.FloatCurve.DefaultValue;
		this.FloatCurvePostInfinityExtrap = curveFloat.FloatCurve.PostInfinityExtrap;
		this.FloatCurvePreInfinityExtrap = curveFloat.FloatCurve.PreInfinityExtrap;
	}

	// Token: 0x060006D1 RID: 1745 RVA: 0x0002435C File Offset: 0x0002255C
	public void MapRangeClampedTimeAndValue(float oldTimeMin, float oldTimeMax, float newTimeMin, float newTimeMax, float oldValueMin, float oldValueMax, float newValueMin, float newValueMax)
	{
		float num = (newValueMax - newValueMin) / (oldValueMax - oldValueMin);
		float num2 = (newTimeMax - newTimeMin) / (oldTimeMax - oldTimeMin);
		float num3 = num / num2;
		foreach (RichCurveKeyHandle richCurveKeyHandle in this.FloatCurveKeys)
		{
			richCurveKeyHandle.Time = MathUtils.Instance.RangeClamp(richCurveKeyHandle.Time, oldTimeMin, oldTimeMax, newTimeMin, newTimeMax);
			richCurveKeyHandle.Value = MathUtils.Instance.RangeClamp(richCurveKeyHandle.Value, oldValueMin, oldValueMax, newValueMin, newValueMax);
			if (richCurveKeyHandle.Time == newTimeMin)
			{
				richCurveKeyHandle.ArriveTangent = 0f;
				richCurveKeyHandle.ArriveTangentWeight = 0f;
				if (richCurveKeyHandle.TangentWeightMode == ERichCurveTangentWeightMode.RCTWM_WeightedBoth)
				{
					richCurveKeyHandle.TangentWeightMode = ERichCurveTangentWeightMode.RCTWM_WeightedLeave;
				}
				else if (richCurveKeyHandle.TangentWeightMode == ERichCurveTangentWeightMode.RCTWM_WeightedArrive)
				{
					richCurveKeyHandle.TangentWeightMode = ERichCurveTangentWeightMode.RCTWM_WeightedNone;
				}
			}
			else
			{
				if (richCurveKeyHandle.TangentWeightMode != ERichCurveTangentWeightMode.RCTWM_WeightedNone && richCurveKeyHandle.TangentWeightMode != ERichCurveTangentWeightMode.RCTWM_WeightedLeave)
				{
					float num4 = (float)Math.Atan((double)richCurveKeyHandle.ArriveTangent);
					float value = (float)Math.Cos((double)num4) * richCurveKeyHandle.ArriveTangentWeight;
					float value2 = (float)Math.Sin((double)num4) * richCurveKeyHandle.ArriveTangentWeight;
					float num5 = MathUtils.Instance.Lerp(newTimeMin, newTimeMax, MathUtils.Instance.GetRangePct(oldTimeMin, oldTimeMax, value));
					float num6 = MathUtils.Instance.Lerp(newValueMin, newValueMax, MathUtils.Instance.GetRangePct(oldValueMin, oldValueMax, value2));
					richCurveKeyHandle.ArriveTangentWeight = (float)Math.Sqrt((double)(num5 * num5 + num6 * num6));
				}
				richCurveKeyHandle.ArriveTangent *= num3;
			}
			if (richCurveKeyHandle.Time == newTimeMax)
			{
				richCurveKeyHandle.LeaveTangent = 0f;
				richCurveKeyHandle.LeaveTangentWeight = 0f;
				if (richCurveKeyHandle.TangentWeightMode == ERichCurveTangentWeightMode.RCTWM_WeightedBoth)
				{
					richCurveKeyHandle.TangentWeightMode = ERichCurveTangentWeightMode.RCTWM_WeightedArrive;
				}
				else if (richCurveKeyHandle.TangentWeightMode == ERichCurveTangentWeightMode.RCTWM_WeightedLeave)
				{
					richCurveKeyHandle.TangentWeightMode = ERichCurveTangentWeightMode.RCTWM_WeightedNone;
				}
			}
			else
			{
				if (richCurveKeyHandle.TangentWeightMode != ERichCurveTangentWeightMode.RCTWM_WeightedNone && richCurveKeyHandle.TangentWeightMode != ERichCurveTangentWeightMode.RCTWM_WeightedArrive)
				{
					float num7 = (float)Math.Atan((double)richCurveKeyHandle.LeaveTangent);
					float value3 = (float)Math.Cos((double)num7) * richCurveKeyHandle.LeaveTangentWeight;
					float value4 = (float)Math.Sin((double)num7) * richCurveKeyHandle.LeaveTangentWeight;
					float num8 = MathUtils.Instance.Lerp(newTimeMin, newTimeMax, MathUtils.Instance.GetRangePct(oldTimeMin, oldTimeMax, value3));
					float num9 = MathUtils.Instance.Lerp(newValueMin, newValueMax, MathUtils.Instance.GetRangePct(oldValueMin, oldValueMax, value4));
					richCurveKeyHandle.LeaveTangentWeight = (float)Math.Sqrt((double)(num8 * num8 + num9 * num9));
				}
				richCurveKeyHandle.LeaveTangent *= num3;
			}
		}
	}

	// Token: 0x060006D2 RID: 1746 RVA: 0x000245F4 File Offset: 0x000227F4
	public void AddKey(RichCurveKeyHandle dataKey)
	{
		this.AddKeyInternal(dataKey);
	}

	// Token: 0x060006D3 RID: 1747 RVA: 0x00024600 File Offset: 0x00022800
	public void AddKey(FRichCurveKey ueDataKey)
	{
		RichCurveKeyHandle dataKey = new RichCurveKeyHandle(new FRichCurveKey?(ueDataKey));
		this.AddKeyInternal(dataKey);
	}

	// Token: 0x060006D4 RID: 1748 RVA: 0x00024620 File Offset: 0x00022820
	public void AddKey(float time, float? value, ERichCurveInterpMode? interpMode = null)
	{
		RichCurveKeyHandle richCurveKeyHandle = new RichCurveKeyHandle();
		richCurveKeyHandle.Time = time;
		richCurveKeyHandle.Value = value.GetValueOrDefault();
		if (interpMode != null)
		{
			richCurveKeyHandle.InterpMode = interpMode.Value;
		}
		this.AddKeyInternal(richCurveKeyHandle);
	}

	// Token: 0x060006D5 RID: 1749 RVA: 0x00024664 File Offset: 0x00022864
	private void AddKeyInternal(RichCurveKeyHandle dataKey)
	{
		int num = -1;
		for (int i = 0; i < this.FloatCurveKeys.Count; i++)
		{
			if (this.FloatCurveKeys[i].Time > dataKey.Time)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			this.FloatCurveKeys.Add(dataKey);
			return;
		}
		this.FloatCurveKeys.Insert(num, dataKey);
	}

	// Token: 0x060006D6 RID: 1750 RVA: 0x000246C4 File Offset: 0x000228C4
	public UCurveFloat ToUeCurveFloat()
	{
		UCurveFloat ucurveFloat = new UCurveFloat();
		FRichCurve floatCurve = ucurveFloat.FloatCurve;
		ucurveFloat.bIsEventCurve = this.IsEventCurve;
		floatCurve.Keys.Empty(true);
		foreach (RichCurveKeyHandle richCurveKeyHandle in this.FloatCurveKeys)
		{
			floatCurve.Keys.Add(richCurveKeyHandle.ToUeRichCurveKey());
		}
		floatCurve.DefaultValue = this.FloatCurveDefaultValue;
		floatCurve.PostInfinityExtrap = this.FloatCurvePostInfinityExtrap;
		floatCurve.PreInfinityExtrap = this.FloatCurvePreInfinityExtrap;
		ucurveFloat.FloatCurve = floatCurve;
		return ucurveFloat;
	}

	// Token: 0x0400057B RID: 1403
	public bool IsEventCurve;

	// Token: 0x0400057C RID: 1404
	public List<RichCurveKeyHandle> FloatCurveKeys = new List<RichCurveKeyHandle>();

	// Token: 0x0400057D RID: 1405
	public float FloatCurveDefaultValue = float.MaxValue;

	// Token: 0x0400057E RID: 1406
	public ERichCurveExtrapolation FloatCurvePostInfinityExtrap = ERichCurveExtrapolation.RCCE_Constant;

	// Token: 0x0400057F RID: 1407
	public ERichCurveExtrapolation FloatCurvePreInfinityExtrap = ERichCurveExtrapolation.RCCE_Constant;
}

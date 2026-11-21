using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Pawn.Component
{
	// Token: 0x020061F3 RID: 25075
	[NullableContext(2)]
	[Nullable(0)]
	public class TimeScale
	{
		// Token: 0x0603C363 RID: 246627 RVA: 0x01126BE4 File Offset: 0x01124DE4
		public TimeScale(double startTime, double endTime, int priority, float timeDilation, UCurveFloat timeCurveFloat, float duration, int id, ETimeScaleSourceType sourceType, ETimeScaleSourceGroup sourceTypeGroup, bool needAddSceneItemTag = false, bool immuneSelfCenter = false)
		{
		}

		// Token: 0x0603C364 RID: 246628 RVA: 0x01126C4C File Offset: 0x01124E4C
		private void ReadCurveTimeRange()
		{
			float num = 0f;
			float num2 = 0f;
			this.TimeCurveFloat.GetTimeRange(ref num, ref num2);
			this.CurveTimeRangeMinInternal = new double?((double)num);
			this.CurveTimeRangeMaxInternal = new double?((double)num2);
		}

		// Token: 0x170071A2 RID: 29090
		// (get) Token: 0x0603C365 RID: 246629 RVA: 0x01126C8E File Offset: 0x01124E8E
		public double CurveTimeRangeMin
		{
			get
			{
				if (this.CurveTimeRangeMinInternal == null)
				{
					this.ReadCurveTimeRange();
				}
				return this.CurveTimeRangeMinInternal.GetValueOrDefault(double.NegativeInfinity);
			}
		}

		// Token: 0x170071A3 RID: 29091
		// (get) Token: 0x0603C366 RID: 246630 RVA: 0x01126CB7 File Offset: 0x01124EB7
		public double CurveTimeRangeMax
		{
			get
			{
				if (this.CurveTimeRangeMaxInternal == null)
				{
					this.ReadCurveTimeRange();
				}
				return this.CurveTimeRangeMaxInternal.GetValueOrDefault(double.PositiveInfinity);
			}
		}

		// Token: 0x0603C367 RID: 246631 RVA: 0x01126CE0 File Offset: 0x01124EE0
		private void ReadCurveValueRange()
		{
			float num = 0f;
			float num2 = 0f;
			this.TimeCurveFloat.GetValueRange(ref num, ref num2);
			this.CurveValueRangeMinInternal = new double?((double)num);
			this.CurveValueRangeMaxInternal = new double?((double)num2);
		}

		// Token: 0x170071A4 RID: 29092
		// (get) Token: 0x0603C368 RID: 246632 RVA: 0x01126D22 File Offset: 0x01124F22
		private double CurveValueRangeMin
		{
			get
			{
				if (this.CurveValueRangeMinInternal == null)
				{
					this.ReadCurveValueRange();
				}
				return this.CurveValueRangeMinInternal.GetValueOrDefault(double.NegativeInfinity);
			}
		}

		// Token: 0x170071A5 RID: 29093
		// (get) Token: 0x0603C369 RID: 246633 RVA: 0x01126D4B File Offset: 0x01124F4B
		private double CurveValueRangeMax
		{
			get
			{
				if (this.CurveValueRangeMaxInternal == null)
				{
					this.ReadCurveValueRange();
				}
				return this.CurveValueRangeMaxInternal.GetValueOrDefault(double.PositiveInfinity);
			}
		}

		// Token: 0x0603C36A RID: 246634 RVA: 0x01126D74 File Offset: 0x01124F74
		public double GetCurrentTime()
		{
			if (!this.ImmuneSelfCenter)
			{
				return Time.Instance.WorldTimeSeconds;
			}
			return Time.Instance.PlayerWorldTimeSeconds;
		}

		// Token: 0x0603C36B RID: 246635 RVA: 0x01126D94 File Offset: 0x01124F94
		public float CalculateTimeScale()
		{
			if (this.TimeCurveFloat != null)
			{
				double curveTimeRangeMin = this.CurveTimeRangeMin;
				double curveTimeRangeMax = this.CurveTimeRangeMax;
				double value = (this.GetCurrentTime() - this.StartTime) / (double)this.Duration;
				double num = MathUtils.Instance.RangeClamp(value, 0.0, 1.0, curveTimeRangeMin, curveTimeRangeMax);
				float floatValue = this.TimeCurveFloat.GetFloatValue((float)num);
				double num2 = MathUtils.Instance.RangeClamp((double)floatValue, this.CurveValueRangeMin, this.CurveValueRangeMax, 0.0, 1.0);
				return (float)(1.0 - num2 * (double)(1f - this.TimeDilation));
			}
			return this.TimeDilation;
		}

		// Token: 0x0401FE10 RID: 130576
		public readonly double StartTime = startTime;

		// Token: 0x0401FE11 RID: 130577
		public readonly double EndTime = endTime;

		// Token: 0x0401FE12 RID: 130578
		public readonly int Priority = priority;

		// Token: 0x0401FE13 RID: 130579
		public readonly float TimeDilation = timeDilation;

		// Token: 0x0401FE14 RID: 130580
		public readonly UCurveFloat TimeCurveFloat = timeCurveFloat;

		// Token: 0x0401FE15 RID: 130581
		public readonly float Duration = duration;

		// Token: 0x0401FE16 RID: 130582
		public readonly int Id = id;

		// Token: 0x0401FE17 RID: 130583
		public readonly ETimeScaleSourceType SourceType = sourceType;

		// Token: 0x0401FE18 RID: 130584
		public readonly ETimeScaleSourceGroup SourceTypeGroup = sourceTypeGroup;

		// Token: 0x0401FE19 RID: 130585
		public readonly bool NeedAddSceneItemTag = needAddSceneItemTag;

		// Token: 0x0401FE1A RID: 130586
		public readonly bool ImmuneSelfCenter = immuneSelfCenter;

		// Token: 0x0401FE1B RID: 130587
		public bool MarkDelete;

		// Token: 0x0401FE1C RID: 130588
		private double? CurveTimeRangeMinInternal;

		// Token: 0x0401FE1D RID: 130589
		private double? CurveTimeRangeMaxInternal;

		// Token: 0x0401FE1E RID: 130590
		private double? CurveValueRangeMinInternal;

		// Token: 0x0401FE1F RID: 130591
		private double? CurveValueRangeMaxInternal;
	}
}

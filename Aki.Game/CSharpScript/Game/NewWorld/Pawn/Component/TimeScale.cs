using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Pawn.Component
{
	// Token: 0x02007072 RID: 28786
	[NullableContext(2)]
	[Nullable(0)]
	public class TimeScale
	{
		// Token: 0x0604615C RID: 287068 RVA: 0x0117D2F4 File Offset: 0x0117B4F4
		public TimeScale(double startTime, double endTime, int priority, float timeDilation, UCurveFloat timeCurveFloat, float duration, int id, ETimeScaleSourceType sourceType, ETimeScaleSourceGroup sourceTypeGroup, bool needAddSceneItemTag = false, bool immuneSelfCenter = false)
		{
		}

		// Token: 0x0604615D RID: 287069 RVA: 0x0117D35C File Offset: 0x0117B55C
		private void ReadCurveTimeRange()
		{
			float num = 0f;
			float num2 = 0f;
			this.TimeCurveFloat.GetTimeRange(ref num, ref num2);
			this.CurveTimeRangeMinInternal = new double?((double)num);
			this.CurveTimeRangeMaxInternal = new double?((double)num2);
		}

		// Token: 0x17009C10 RID: 39952
		// (get) Token: 0x0604615E RID: 287070 RVA: 0x0117D39E File Offset: 0x0117B59E
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

		// Token: 0x17009C11 RID: 39953
		// (get) Token: 0x0604615F RID: 287071 RVA: 0x0117D3C7 File Offset: 0x0117B5C7
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

		// Token: 0x06046160 RID: 287072 RVA: 0x0117D3F0 File Offset: 0x0117B5F0
		private void ReadCurveValueRange()
		{
			float num = 0f;
			float num2 = 0f;
			this.TimeCurveFloat.GetValueRange(ref num, ref num2);
			this.CurveValueRangeMinInternal = new double?((double)num);
			this.CurveValueRangeMaxInternal = new double?((double)num2);
		}

		// Token: 0x17009C12 RID: 39954
		// (get) Token: 0x06046161 RID: 287073 RVA: 0x0117D432 File Offset: 0x0117B632
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

		// Token: 0x17009C13 RID: 39955
		// (get) Token: 0x06046162 RID: 287074 RVA: 0x0117D45B File Offset: 0x0117B65B
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

		// Token: 0x06046163 RID: 287075 RVA: 0x0117D484 File Offset: 0x0117B684
		public double GetCurrentTime()
		{
			if (!this.ImmuneSelfCenter)
			{
				return Time.Instance.WorldTimeSeconds;
			}
			return Time.Instance.PlayerWorldTimeSeconds;
		}

		// Token: 0x06046164 RID: 287076 RVA: 0x0117D4A4 File Offset: 0x0117B6A4
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

		// Token: 0x04024B55 RID: 150357
		public readonly double StartTime = startTime;

		// Token: 0x04024B56 RID: 150358
		public readonly double EndTime = endTime;

		// Token: 0x04024B57 RID: 150359
		public readonly int Priority = priority;

		// Token: 0x04024B58 RID: 150360
		public readonly float TimeDilation = timeDilation;

		// Token: 0x04024B59 RID: 150361
		public readonly UCurveFloat TimeCurveFloat = timeCurveFloat;

		// Token: 0x04024B5A RID: 150362
		public readonly float Duration = duration;

		// Token: 0x04024B5B RID: 150363
		public readonly int Id = id;

		// Token: 0x04024B5C RID: 150364
		public readonly ETimeScaleSourceType SourceType = sourceType;

		// Token: 0x04024B5D RID: 150365
		public readonly ETimeScaleSourceGroup SourceTypeGroup = sourceTypeGroup;

		// Token: 0x04024B5E RID: 150366
		public readonly bool NeedAddSceneItemTag = needAddSceneItemTag;

		// Token: 0x04024B5F RID: 150367
		public readonly bool ImmuneSelfCenter = immuneSelfCenter;

		// Token: 0x04024B60 RID: 150368
		public bool MarkDelete;

		// Token: 0x04024B61 RID: 150369
		private double? CurveTimeRangeMinInternal;

		// Token: 0x04024B62 RID: 150370
		private double? CurveTimeRangeMaxInternal;

		// Token: 0x04024B63 RID: 150371
		private double? CurveValueRangeMinInternal;

		// Token: 0x04024B64 RID: 150372
		private double? CurveValueRangeMaxInternal;
	}
}

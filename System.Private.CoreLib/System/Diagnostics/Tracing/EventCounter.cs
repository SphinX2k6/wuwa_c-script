using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Threading;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008D2 RID: 2258
	[NullableContext(1)]
	[Nullable(0)]
	[UnsupportedOSPlatform("browser")]
	public class EventCounter : DiagnosticCounter
	{
		// Token: 0x06008B64 RID: 35684 RVA: 0x0015089C File Offset: 0x0014EA9C
		public EventCounter(string name, EventSource eventSource) : base(name, eventSource)
		{
			this._min = double.PositiveInfinity;
			this._max = double.NegativeInfinity;
			double[] array = new double[10];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = double.NegativeInfinity;
			}
			this._bufferedValues = array;
			base.Publish();
		}

		// Token: 0x06008B65 RID: 35685 RVA: 0x001508FE File Offset: 0x0014EAFE
		public void WriteMetric(float value)
		{
			this.Enqueue((double)value);
		}

		// Token: 0x06008B66 RID: 35686 RVA: 0x00150908 File Offset: 0x0014EB08
		public void WriteMetric(double value)
		{
			this.Enqueue(value);
		}

		// Token: 0x06008B67 RID: 35687 RVA: 0x00150914 File Offset: 0x0014EB14
		public override string ToString()
		{
			int num = Volatile.Read(ref this._count);
			if (num != 0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 3);
				defaultInterpolatedStringHandler.AppendLiteral("EventCounter '");
				defaultInterpolatedStringHandler.AppendFormatted(base.Name);
				defaultInterpolatedStringHandler.AppendLiteral("' Count ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				defaultInterpolatedStringHandler.AppendLiteral(" Mean ");
				defaultInterpolatedStringHandler.AppendFormatted<double>(this._sum / (double)num, "n3");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			return "EventCounter '" + base.Name + "' Count 0";
		}

		// Token: 0x06008B68 RID: 35688 RVA: 0x001509A8 File Offset: 0x0014EBA8
		internal void OnMetricWritten(double value)
		{
			this._sum += value;
			this._sumSquared += value * value;
			if (value > this._max)
			{
				this._max = value;
			}
			if (value < this._min)
			{
				this._min = value;
			}
			this._count++;
		}

		// Token: 0x06008B69 RID: 35689 RVA: 0x00150A04 File Offset: 0x0014EC04
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "The DynamicDependency will preserve the properties of CounterPayload")]
		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties, typeof(CounterPayload))]
		internal override void WritePayload(float intervalSec, int pollingIntervalMillisec)
		{
			lock (this)
			{
				this.Flush();
				CounterPayload counterPayload = new CounterPayload();
				counterPayload.Count = this._count;
				counterPayload.IntervalSec = intervalSec;
				if (0 < this._count)
				{
					counterPayload.Mean = this._sum / (double)this._count;
					counterPayload.StandardDeviation = Math.Sqrt(this._sumSquared / (double)this._count - this._sum * this._sum / (double)this._count / (double)this._count);
				}
				else
				{
					counterPayload.Mean = 0.0;
					counterPayload.StandardDeviation = 0.0;
				}
				counterPayload.Min = this._min;
				counterPayload.Max = this._max;
				CounterPayload counterPayload2 = counterPayload;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Interval=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(pollingIntervalMillisec);
				counterPayload2.Series = defaultInterpolatedStringHandler.ToStringAndClear();
				counterPayload.CounterType = "Mean";
				counterPayload.Metadata = base.GetMetadataString();
				counterPayload.DisplayName = (base.DisplayName ?? "");
				counterPayload.DisplayUnits = (base.DisplayUnits ?? "");
				counterPayload.Name = base.Name;
				this.ResetStatistics();
				base.EventSource.Write<CounterPayloadType>("EventCounters", new EventSourceOptions
				{
					Level = EventLevel.LogAlways
				}, new CounterPayloadType(counterPayload));
			}
		}

		// Token: 0x06008B6A RID: 35690 RVA: 0x00150B98 File Offset: 0x0014ED98
		internal void ResetStatistics()
		{
			lock (this)
			{
				this._count = 0;
				this._sum = 0.0;
				this._sumSquared = 0.0;
				this._min = double.PositiveInfinity;
				this._max = double.NegativeInfinity;
			}
		}

		// Token: 0x06008B6B RID: 35691 RVA: 0x00150C10 File Offset: 0x0014EE10
		private void Enqueue(double value)
		{
			int num = this._bufferedValuesIndex;
			double num2;
			do
			{
				num2 = Interlocked.CompareExchange(ref this._bufferedValues[num], value, double.NegativeInfinity);
				num++;
				if (this._bufferedValues.Length <= num)
				{
					lock (this)
					{
						this.Flush();
					}
					num = 0;
				}
			}
			while (num2 != double.NegativeInfinity);
			this._bufferedValuesIndex = num;
		}

		// Token: 0x06008B6C RID: 35692 RVA: 0x00150C98 File Offset: 0x0014EE98
		private void Flush()
		{
			for (int i = 0; i < this._bufferedValues.Length; i++)
			{
				double num = Interlocked.Exchange(ref this._bufferedValues[i], double.NegativeInfinity);
				if (num != double.NegativeInfinity)
				{
					this.OnMetricWritten(num);
				}
			}
			this._bufferedValuesIndex = 0;
		}

		// Token: 0x04001F4D RID: 8013
		private int _count;

		// Token: 0x04001F4E RID: 8014
		private double _sum;

		// Token: 0x04001F4F RID: 8015
		private double _sumSquared;

		// Token: 0x04001F50 RID: 8016
		private double _min;

		// Token: 0x04001F51 RID: 8017
		private double _max;

		// Token: 0x04001F52 RID: 8018
		private readonly double[] _bufferedValues;

		// Token: 0x04001F53 RID: 8019
		private volatile int _bufferedValuesIndex;
	}
}

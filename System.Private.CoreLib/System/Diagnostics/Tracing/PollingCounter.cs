using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System.Diagnostics.Tracing
{
	// Token: 0x0200090E RID: 2318
	[NullableContext(1)]
	[Nullable(0)]
	[UnsupportedOSPlatform("browser")]
	public class PollingCounter : DiagnosticCounter
	{
		// Token: 0x06008D3B RID: 36155 RVA: 0x0015BF40 File Offset: 0x0015A140
		public PollingCounter(string name, EventSource eventSource, Func<double> metricProvider) : base(name, eventSource)
		{
			ArgumentNullException.ThrowIfNull(metricProvider, "metricProvider");
			this._metricProvider = metricProvider;
			base.Publish();
		}

		// Token: 0x06008D3C RID: 36156 RVA: 0x0015BF64 File Offset: 0x0015A164
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 2);
			defaultInterpolatedStringHandler.AppendLiteral("PollingCounter '");
			defaultInterpolatedStringHandler.AppendFormatted(base.Name);
			defaultInterpolatedStringHandler.AppendLiteral("' Count 1 Mean ");
			defaultInterpolatedStringHandler.AppendFormatted<double>(this._lastVal, "n3");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06008D3D RID: 36157 RVA: 0x0015BFBC File Offset: 0x0015A1BC
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "The DynamicDependency will preserve the properties of CounterPayload")]
		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties, typeof(CounterPayload))]
		internal override void WritePayload(float intervalSec, int pollingIntervalMillisec)
		{
			lock (this)
			{
				double num = 0.0;
				try
				{
					num = this._metricProvider();
				}
				catch (Exception ex)
				{
					base.ReportOutOfBandMessage("ERROR: Exception during EventCounter " + base.Name + " metricProvider callback: " + ex.Message);
				}
				CounterPayload counterPayload = new CounterPayload();
				counterPayload.Name = base.Name;
				counterPayload.DisplayName = (base.DisplayName ?? "");
				counterPayload.Count = 1;
				counterPayload.IntervalSec = intervalSec;
				CounterPayload counterPayload2 = counterPayload;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Interval=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(pollingIntervalMillisec);
				counterPayload2.Series = defaultInterpolatedStringHandler.ToStringAndClear();
				counterPayload.CounterType = "Mean";
				counterPayload.Mean = num;
				counterPayload.Max = num;
				counterPayload.Min = num;
				counterPayload.Metadata = base.GetMetadataString();
				counterPayload.StandardDeviation = 0.0;
				counterPayload.DisplayUnits = (base.DisplayUnits ?? "");
				this._lastVal = num;
				base.EventSource.Write<PollingPayloadType>("EventCounters", new EventSourceOptions
				{
					Level = EventLevel.LogAlways
				}, new PollingPayloadType(counterPayload));
			}
		}

		// Token: 0x04002067 RID: 8295
		private readonly Func<double> _metricProvider;

		// Token: 0x04002068 RID: 8296
		private double _lastVal;
	}
}

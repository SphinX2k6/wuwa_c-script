using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System.Diagnostics.Tracing
{
	// Token: 0x0200090C RID: 2316
	[NullableContext(1)]
	[Nullable(0)]
	[UnsupportedOSPlatform("browser")]
	public class IncrementingPollingCounter : DiagnosticCounter
	{
		// Token: 0x06008D32 RID: 36146 RVA: 0x0015BCE4 File Offset: 0x00159EE4
		public IncrementingPollingCounter(string name, EventSource eventSource, Func<double> totalValueProvider) : base(name, eventSource)
		{
			ArgumentNullException.ThrowIfNull(totalValueProvider, "totalValueProvider");
			this._totalValueProvider = totalValueProvider;
			base.Publish();
		}

		// Token: 0x06008D33 RID: 36147 RVA: 0x0015BD08 File Offset: 0x00159F08
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 2);
			defaultInterpolatedStringHandler.AppendLiteral("IncrementingPollingCounter '");
			defaultInterpolatedStringHandler.AppendFormatted(base.Name);
			defaultInterpolatedStringHandler.AppendLiteral("' Increment ");
			defaultInterpolatedStringHandler.AppendFormatted<double>(this._increment);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x06008D34 RID: 36148 RVA: 0x0015BD58 File Offset: 0x00159F58
		// (set) Token: 0x06008D35 RID: 36149 RVA: 0x0015BD60 File Offset: 0x00159F60
		public TimeSpan DisplayRateTimeScale { get; set; }

		// Token: 0x06008D36 RID: 36150 RVA: 0x0015BD6C File Offset: 0x00159F6C
		internal void UpdateMetric()
		{
			try
			{
				lock (this)
				{
					this._prevIncrement = this._increment;
					this._increment = this._totalValueProvider();
				}
			}
			catch (Exception ex)
			{
				base.ReportOutOfBandMessage("ERROR: Exception during EventCounter " + base.Name + " getMetricFunction callback: " + ex.Message);
			}
		}

		// Token: 0x06008D37 RID: 36151 RVA: 0x0015BDF0 File Offset: 0x00159FF0
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "The DynamicDependency will preserve the properties of IncrementingCounterPayload")]
		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties, typeof(IncrementingCounterPayload))]
		internal override void WritePayload(float intervalSec, int pollingIntervalMillisec)
		{
			this.UpdateMetric();
			lock (this)
			{
				IncrementingCounterPayload incrementingCounterPayload = new IncrementingCounterPayload();
				incrementingCounterPayload.Name = base.Name;
				incrementingCounterPayload.DisplayName = (base.DisplayName ?? "");
				incrementingCounterPayload.DisplayRateTimeScale = ((this.DisplayRateTimeScale == TimeSpan.Zero) ? "" : this.DisplayRateTimeScale.ToString("c"));
				incrementingCounterPayload.IntervalSec = intervalSec;
				IncrementingCounterPayload incrementingCounterPayload2 = incrementingCounterPayload;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Interval=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(pollingIntervalMillisec);
				incrementingCounterPayload2.Series = defaultInterpolatedStringHandler.ToStringAndClear();
				incrementingCounterPayload.CounterType = "Sum";
				incrementingCounterPayload.Metadata = base.GetMetadataString();
				incrementingCounterPayload.Increment = this._increment - this._prevIncrement;
				incrementingCounterPayload.DisplayUnits = (base.DisplayUnits ?? "");
				base.EventSource.Write<IncrementingPollingCounterPayloadType>("EventCounters", new EventSourceOptions
				{
					Level = EventLevel.LogAlways
				}, new IncrementingPollingCounterPayloadType(incrementingCounterPayload));
			}
		}

		// Token: 0x04002063 RID: 8291
		private double _increment;

		// Token: 0x04002064 RID: 8292
		private double _prevIncrement;

		// Token: 0x04002065 RID: 8293
		private readonly Func<double> _totalValueProvider;
	}
}

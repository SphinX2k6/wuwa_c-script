using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System.Diagnostics.Tracing
{
	// Token: 0x0200090A RID: 2314
	[NullableContext(1)]
	[Nullable(0)]
	[UnsupportedOSPlatform("browser")]
	public class IncrementingEventCounter : DiagnosticCounter
	{
		// Token: 0x06008D28 RID: 36136 RVA: 0x0015BA86 File Offset: 0x00159C86
		public IncrementingEventCounter(string name, EventSource eventSource) : base(name, eventSource)
		{
			base.Publish();
		}

		// Token: 0x06008D29 RID: 36137 RVA: 0x0015BA98 File Offset: 0x00159C98
		public void Increment(double increment = 1.0)
		{
			lock (this)
			{
				this._increment += increment;
			}
		}

		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x06008D2A RID: 36138 RVA: 0x0015BADC File Offset: 0x00159CDC
		// (set) Token: 0x06008D2B RID: 36139 RVA: 0x0015BAE4 File Offset: 0x00159CE4
		public TimeSpan DisplayRateTimeScale { get; set; }

		// Token: 0x06008D2C RID: 36140 RVA: 0x0015BAF0 File Offset: 0x00159CF0
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(38, 2);
			defaultInterpolatedStringHandler.AppendLiteral("IncrementingEventCounter '");
			defaultInterpolatedStringHandler.AppendFormatted(base.Name);
			defaultInterpolatedStringHandler.AppendLiteral("' Increment ");
			defaultInterpolatedStringHandler.AppendFormatted<double>(this._increment);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06008D2D RID: 36141 RVA: 0x0015BB40 File Offset: 0x00159D40
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "The DynamicDependency will preserve the properties of IncrementingCounterPayload")]
		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties, typeof(IncrementingCounterPayload))]
		internal override void WritePayload(float intervalSec, int pollingIntervalMillisec)
		{
			lock (this)
			{
				IncrementingCounterPayload incrementingCounterPayload = new IncrementingCounterPayload();
				incrementingCounterPayload.Name = base.Name;
				incrementingCounterPayload.IntervalSec = intervalSec;
				incrementingCounterPayload.DisplayName = (base.DisplayName ?? "");
				incrementingCounterPayload.DisplayRateTimeScale = ((this.DisplayRateTimeScale == TimeSpan.Zero) ? "" : this.DisplayRateTimeScale.ToString("c"));
				IncrementingCounterPayload incrementingCounterPayload2 = incrementingCounterPayload;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Interval=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(pollingIntervalMillisec);
				incrementingCounterPayload2.Series = defaultInterpolatedStringHandler.ToStringAndClear();
				incrementingCounterPayload.CounterType = "Sum";
				incrementingCounterPayload.Metadata = base.GetMetadataString();
				incrementingCounterPayload.Increment = this._increment - this._prevIncrement;
				incrementingCounterPayload.DisplayUnits = (base.DisplayUnits ?? "");
				this._prevIncrement = this._increment;
				base.EventSource.Write<IncrementingEventCounterPayloadType>("EventCounters", new EventSourceOptions
				{
					Level = EventLevel.LogAlways
				}, new IncrementingEventCounterPayloadType(incrementingCounterPayload));
			}
		}

		// Token: 0x06008D2E RID: 36142 RVA: 0x0015BC80 File Offset: 0x00159E80
		internal void UpdateMetric()
		{
			lock (this)
			{
				this._prevIncrement = this._increment;
			}
		}

		// Token: 0x0400205F RID: 8287
		private double _increment;

		// Token: 0x04002060 RID: 8288
		private double _prevIncrement;
	}
}

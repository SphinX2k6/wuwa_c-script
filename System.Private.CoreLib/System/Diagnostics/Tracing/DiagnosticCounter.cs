using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Text;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008CA RID: 2250
	[NullableContext(1)]
	[Nullable(0)]
	[UnsupportedOSPlatform("browser")]
	public abstract class DiagnosticCounter : IDisposable
	{
		// Token: 0x06008B08 RID: 35592 RVA: 0x0014F898 File Offset: 0x0014DA98
		internal DiagnosticCounter(string Name, EventSource EventSource)
		{
			ArgumentNullException.ThrowIfNull(Name, "Name");
			ArgumentNullException.ThrowIfNull(EventSource, "EventSource");
			this.Name = Name;
			this.EventSource = EventSource;
		}

		// Token: 0x06008B09 RID: 35593 RVA: 0x0014F8E5 File Offset: 0x0014DAE5
		private protected void Publish()
		{
			this._group = CounterGroup.GetCounterGroup(this.EventSource);
			this._group.Add(this);
		}

		// Token: 0x06008B0A RID: 35594 RVA: 0x0014F904 File Offset: 0x0014DB04
		public void Dispose()
		{
			if (this._group != null)
			{
				this._group.Remove(this);
				this._group = null;
			}
		}

		// Token: 0x06008B0B RID: 35595 RVA: 0x0014F924 File Offset: 0x0014DB24
		public void AddMetadata(string key, [Nullable(2)] string value)
		{
			lock (this)
			{
				if (this._metadata == null)
				{
					this._metadata = new Dictionary<string, string>();
				}
				this._metadata.Add(key, value);
			}
		}

		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x06008B0C RID: 35596 RVA: 0x0014F97C File Offset: 0x0014DB7C
		// (set) Token: 0x06008B0D RID: 35597 RVA: 0x0014F984 File Offset: 0x0014DB84
		public string DisplayName
		{
			get
			{
				return this._displayName;
			}
			set
			{
				ArgumentNullException.ThrowIfNull(this.DisplayName, "DisplayName");
				this._displayName = value;
			}
		}

		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x06008B0E RID: 35598 RVA: 0x0014F99D File Offset: 0x0014DB9D
		// (set) Token: 0x06008B0F RID: 35599 RVA: 0x0014F9A5 File Offset: 0x0014DBA5
		public string DisplayUnits
		{
			get
			{
				return this._displayUnits;
			}
			set
			{
				ArgumentNullException.ThrowIfNull(this.DisplayUnits, "DisplayUnits");
				this._displayUnits = value;
			}
		}

		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x06008B10 RID: 35600 RVA: 0x0014F9BE File Offset: 0x0014DBBE
		public string Name { get; }

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x06008B11 RID: 35601 RVA: 0x0014F9C6 File Offset: 0x0014DBC6
		public EventSource EventSource { get; }

		// Token: 0x06008B12 RID: 35602
		internal abstract void WritePayload(float intervalSec, int pollingIntervalMillisec);

		// Token: 0x06008B13 RID: 35603 RVA: 0x0014F9CE File Offset: 0x0014DBCE
		internal void ReportOutOfBandMessage(string message)
		{
			this.EventSource.ReportOutOfBandMessage(message);
		}

		// Token: 0x06008B14 RID: 35604 RVA: 0x0014F9DC File Offset: 0x0014DBDC
		internal string GetMetadataString()
		{
			if (this._metadata == null)
			{
				return "";
			}
			Dictionary<string, string>.Enumerator enumerator = this._metadata.GetEnumerator();
			enumerator.MoveNext();
			KeyValuePair<string, string> keyValuePair = enumerator.Current;
			if (!enumerator.MoveNext())
			{
				return keyValuePair.Key + ":" + keyValuePair.Value;
			}
			StringBuilder stringBuilder = new StringBuilder().Append(keyValuePair.Key).Append(':').Append(keyValuePair.Value);
			do
			{
				keyValuePair = enumerator.Current;
				stringBuilder.Append(',').Append(keyValuePair.Key).Append(':').Append(keyValuePair.Value);
			}
			while (enumerator.MoveNext());
			return stringBuilder.ToString();
		}

		// Token: 0x04001F19 RID: 7961
		private string _displayName = "";

		// Token: 0x04001F1A RID: 7962
		private string _displayUnits = "";

		// Token: 0x04001F1D RID: 7965
		private CounterGroup _group;

		// Token: 0x04001F1E RID: 7966
		private Dictionary<string, string> _metadata;
	}
}

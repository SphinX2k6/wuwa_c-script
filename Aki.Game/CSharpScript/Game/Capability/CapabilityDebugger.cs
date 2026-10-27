using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Capability
{
	// Token: 0x0200729D RID: 29341
	[NullableContext(1)]
	[Nullable(0)]
	public class CapabilityDebugger
	{
		// Token: 0x06047FAA RID: 294826 RVA: 0x01270BEA File Offset: 0x0126EDEA
		public void SetEnabled(bool enabled)
		{
			this.Enabled = enabled;
		}

		// Token: 0x06047FAB RID: 294827 RVA: 0x01270BF3 File Offset: 0x0126EDF3
		public bool IsEnabled()
		{
			return this.Enabled;
		}

		// Token: 0x06047FAC RID: 294828 RVA: 0x01270BFB File Offset: 0x0126EDFB
		public void SetMaxRecords(int n)
		{
			if (n > 0)
			{
				this.MaxRecords = n;
			}
		}

		// Token: 0x06047FAD RID: 294829 RVA: 0x01270C08 File Offset: 0x0126EE08
		public void Clear()
		{
			this.Records.Clear();
			this.ClosedSpans.Clear();
			this.OpenSpans.Clear();
			this.NextSeq = 1;
		}

		// Token: 0x06047FAE RID: 294830 RVA: 0x01270C34 File Offset: 0x0126EE34
		public void LogEvent(double time, Capability cap, CapabilityCommonDefine.ECapabilityDebugEvent @event, [Nullable(2)] string detail = null, double? durationMs = null)
		{
			if (!this.Enabled)
			{
				return;
			}
			CapabilityDebugRecord capabilityDebugRecord = new CapabilityDebugRecord();
			int nextSeq = this.NextSeq;
			this.NextSeq = nextSeq + 1;
			capabilityDebugRecord.Seq = nextSeq;
			capabilityDebugRecord.Time = time;
			capabilityDebugRecord.Event = @event;
			capabilityDebugRecord.CapabilityId = cap.GetCapabilityId();
			ICapabilityGameObject ownerGameObject = cap.OwnerGameObject;
			capabilityDebugRecord.GameObjectId = (((ownerGameObject != null) ? ownerGameObject.GetId() : null) ?? "");
			capabilityDebugRecord.ClassName = cap.GetType().Name;
			capabilityDebugRecord.Detail = detail;
			capabilityDebugRecord.DurationMs = durationMs;
			CapabilityDebugRecord item = capabilityDebugRecord;
			this.Records.Add(item);
			if (this.Records.Count > this.MaxRecords)
			{
				this.Records.RemoveAt(0);
			}
		}

		// Token: 0x06047FAF RID: 294831 RVA: 0x01270CF0 File Offset: 0x0126EEF0
		public void BeginActiveSpan(double time, Capability cap)
		{
			if (!this.Enabled)
			{
				return;
			}
			string capabilityId = cap.GetCapabilityId();
			if (this.OpenSpans.ContainsKey(capabilityId))
			{
				return;
			}
			CapabilityDebugActiveSpan capabilityDebugActiveSpan = new CapabilityDebugActiveSpan();
			capabilityDebugActiveSpan.CapabilityId = capabilityId;
			ICapabilityGameObject ownerGameObject = cap.OwnerGameObject;
			capabilityDebugActiveSpan.GameObjectId = (((ownerGameObject != null) ? ownerGameObject.GetId() : null) ?? "");
			capabilityDebugActiveSpan.ClassName = cap.GetType().Name;
			capabilityDebugActiveSpan.StartTime = time;
			capabilityDebugActiveSpan.EndTime = -1.0;
			CapabilityDebugActiveSpan value = capabilityDebugActiveSpan;
			this.OpenSpans[capabilityId] = value;
		}

		// Token: 0x06047FB0 RID: 294832 RVA: 0x01270D80 File Offset: 0x0126EF80
		public void EndActiveSpan(double time, Capability cap)
		{
			if (!this.Enabled)
			{
				return;
			}
			string capabilityId = cap.GetCapabilityId();
			ICapabilityDebugActiveSpan capabilityDebugActiveSpan;
			if (!this.OpenSpans.TryGetValue(capabilityId, out capabilityDebugActiveSpan))
			{
				return;
			}
			capabilityDebugActiveSpan.EndTime = time;
			this.ClosedSpans.Add(capabilityDebugActiveSpan);
			this.OpenSpans.Remove(capabilityId);
			if (this.ClosedSpans.Count > this.MaxRecords)
			{
				this.ClosedSpans.RemoveAt(0);
			}
		}

		// Token: 0x06047FB1 RID: 294833 RVA: 0x01270DED File Offset: 0x0126EFED
		public IReadOnlyList<ICapabilityDebugRecord> GetRecords()
		{
			return this.Records;
		}

		// Token: 0x06047FB2 RID: 294834 RVA: 0x01270DF5 File Offset: 0x0126EFF5
		public IReadOnlyList<ICapabilityDebugActiveSpan> GetClosedSpans()
		{
			return this.ClosedSpans;
		}

		// Token: 0x06047FB3 RID: 294835 RVA: 0x01270DFD File Offset: 0x0126EFFD
		public IEnumerable<ICapabilityDebugActiveSpan> GetOpenSpans()
		{
			return this.OpenSpans.Values;
		}

		// Token: 0x06047FB4 RID: 294836 RVA: 0x01270E0C File Offset: 0x0126F00C
		public List<ICapabilityDebugActiveSpan> QuerySpansInRange(float startTime, float endTime)
		{
			List<ICapabilityDebugActiveSpan> list = new List<ICapabilityDebugActiveSpan>();
			foreach (ICapabilityDebugActiveSpan capabilityDebugActiveSpan in this.ClosedSpans)
			{
				if (capabilityDebugActiveSpan.EndTime >= (double)startTime && capabilityDebugActiveSpan.StartTime <= (double)endTime)
				{
					list.Add(capabilityDebugActiveSpan);
				}
			}
			foreach (ICapabilityDebugActiveSpan capabilityDebugActiveSpan2 in this.OpenSpans.Values)
			{
				if (capabilityDebugActiveSpan2.StartTime <= (double)endTime)
				{
					list.Add(capabilityDebugActiveSpan2);
				}
			}
			return list;
		}

		// Token: 0x06047FB5 RID: 294837 RVA: 0x01270ED0 File Offset: 0x0126F0D0
		public List<ICapabilityDebugRecord> QueryRecordsInRange(float startTime, float endTime)
		{
			List<ICapabilityDebugRecord> list = new List<ICapabilityDebugRecord>();
			foreach (ICapabilityDebugRecord capabilityDebugRecord in this.Records)
			{
				if (capabilityDebugRecord.Time >= (double)startTime && capabilityDebugRecord.Time <= (double)endTime)
				{
					list.Add(capabilityDebugRecord);
				}
			}
			return list;
		}

		// Token: 0x06047FB6 RID: 294838 RVA: 0x01270F40 File Offset: 0x0126F140
		public List<string> CollectAllCapabilityIds()
		{
			HashSet<string> hashSet = new HashSet<string>();
			List<string> list = new List<string>();
			foreach (ICapabilityDebugActiveSpan capabilityDebugActiveSpan in this.ClosedSpans)
			{
				if (!hashSet.Contains(capabilityDebugActiveSpan.CapabilityId))
				{
					hashSet.Add(capabilityDebugActiveSpan.CapabilityId);
					list.Add(capabilityDebugActiveSpan.CapabilityId);
				}
			}
			foreach (ICapabilityDebugActiveSpan capabilityDebugActiveSpan2 in this.OpenSpans.Values)
			{
				if (!hashSet.Contains(capabilityDebugActiveSpan2.CapabilityId))
				{
					hashSet.Add(capabilityDebugActiveSpan2.CapabilityId);
					list.Add(capabilityDebugActiveSpan2.CapabilityId);
				}
			}
			foreach (ICapabilityDebugRecord capabilityDebugRecord in this.Records)
			{
				if (!hashSet.Contains(capabilityDebugRecord.CapabilityId))
				{
					hashSet.Add(capabilityDebugRecord.CapabilityId);
					list.Add(capabilityDebugRecord.CapabilityId);
				}
			}
			return list;
		}

		// Token: 0x04025EEB RID: 155371
		private bool Enabled = true;

		// Token: 0x04025EEC RID: 155372
		private readonly List<ICapabilityDebugRecord> Records = new List<ICapabilityDebugRecord>();

		// Token: 0x04025EED RID: 155373
		private int MaxRecords = 5000;

		// Token: 0x04025EEE RID: 155374
		private readonly Dictionary<string, ICapabilityDebugActiveSpan> OpenSpans = new Dictionary<string, ICapabilityDebugActiveSpan>();

		// Token: 0x04025EEF RID: 155375
		private readonly List<ICapabilityDebugActiveSpan> ClosedSpans = new List<ICapabilityDebugActiveSpan>();

		// Token: 0x04025EF0 RID: 155376
		private int NextSeq = 1;
	}
}

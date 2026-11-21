using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Capability
{
	// Token: 0x0200641C RID: 25628
	[NullableContext(1)]
	[Nullable(0)]
	public class CapabilityDebugger
	{
		// Token: 0x0603E370 RID: 254832 RVA: 0x01211BE6 File Offset: 0x0120FDE6
		public void SetEnabled(bool enabled)
		{
			this.Enabled = enabled;
		}

		// Token: 0x0603E371 RID: 254833 RVA: 0x01211BEF File Offset: 0x0120FDEF
		public bool IsEnabled()
		{
			return this.Enabled;
		}

		// Token: 0x0603E372 RID: 254834 RVA: 0x01211BF7 File Offset: 0x0120FDF7
		public void SetMaxRecords(int n)
		{
			if (n > 0)
			{
				this.MaxRecords = n;
			}
		}

		// Token: 0x0603E373 RID: 254835 RVA: 0x01211C04 File Offset: 0x0120FE04
		public void Clear()
		{
			this.Records.Clear();
			this.ClosedSpans.Clear();
			this.OpenSpans.Clear();
			this.NextSeq = 1;
		}

		// Token: 0x0603E374 RID: 254836 RVA: 0x01211C30 File Offset: 0x0120FE30
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

		// Token: 0x0603E375 RID: 254837 RVA: 0x01211CEC File Offset: 0x0120FEEC
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

		// Token: 0x0603E376 RID: 254838 RVA: 0x01211D7C File Offset: 0x0120FF7C
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

		// Token: 0x0603E377 RID: 254839 RVA: 0x01211DE9 File Offset: 0x0120FFE9
		public IReadOnlyList<ICapabilityDebugRecord> GetRecords()
		{
			return this.Records;
		}

		// Token: 0x0603E378 RID: 254840 RVA: 0x01211DF1 File Offset: 0x0120FFF1
		public IReadOnlyList<ICapabilityDebugActiveSpan> GetClosedSpans()
		{
			return this.ClosedSpans;
		}

		// Token: 0x0603E379 RID: 254841 RVA: 0x01211DF9 File Offset: 0x0120FFF9
		public IEnumerable<ICapabilityDebugActiveSpan> GetOpenSpans()
		{
			return this.OpenSpans.Values;
		}

		// Token: 0x0603E37A RID: 254842 RVA: 0x01211E08 File Offset: 0x01210008
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

		// Token: 0x0603E37B RID: 254843 RVA: 0x01211ECC File Offset: 0x012100CC
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

		// Token: 0x0603E37C RID: 254844 RVA: 0x01211F3C File Offset: 0x0121013C
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

		// Token: 0x040211BE RID: 135614
		private bool Enabled = true;

		// Token: 0x040211BF RID: 135615
		private readonly List<ICapabilityDebugRecord> Records = new List<ICapabilityDebugRecord>();

		// Token: 0x040211C0 RID: 135616
		private int MaxRecords = 5000;

		// Token: 0x040211C1 RID: 135617
		private readonly Dictionary<string, ICapabilityDebugActiveSpan> OpenSpans = new Dictionary<string, ICapabilityDebugActiveSpan>();

		// Token: 0x040211C2 RID: 135618
		private readonly List<ICapabilityDebugActiveSpan> ClosedSpans = new List<ICapabilityDebugActiveSpan>();

		// Token: 0x040211C3 RID: 135619
		private int NextSeq = 1;
	}
}

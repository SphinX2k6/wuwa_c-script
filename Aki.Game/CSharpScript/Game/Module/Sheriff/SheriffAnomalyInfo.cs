using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Map;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003BE3 RID: 15331
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffAnomalyInfo
	{
		// Token: 0x06027534 RID: 161076 RVA: 0x00B07860 File Offset: 0x00B05A60
		public void UpdateByProto(SheriffAnomalyInfo proto, int? zoneId = null)
		{
			if (zoneId != null)
			{
				this.ZoneId = zoneId.Value;
			}
			this.AnomalyId = proto.AnomalyId;
			this.ClueIds = ((proto.ClueIds != null) ? new List<int>(proto.ClueIds) : this.ClueIds);
			if (proto.ProgressIds != null)
			{
				this.DoProgressIdLogic(proto.ProgressIds);
			}
			this.Progress = this.CalAnomalyProgress();
			this.EndingId = proto.EndingId;
			long num = proto.CompleteTime / 1000L;
			SheriffAnomaly? anomalyConfigById = SheriffConfig.Instance.GetAnomalyConfigById(this.AnomalyId);
			bool flag = anomalyConfigById == null || anomalyConfigById.GetValueOrDefault().MarkId != 0;
			this.NeedOpenReport = (this.HasInit && this.EndingTime == 0L && num != 0L && flag);
			this.HasInit = true;
			this.EndingTime = num;
			this.IsActivated = proto.IsActivated;
			SheriffAnomaly? anomalyConfigById2 = SheriffConfig.Instance.GetAnomalyConfigById(this.AnomalyId);
			this.CriminalId = ((anomalyConfigById2 != null) ? anomalyConfigById2.GetValueOrDefault().CriminalId : 0);
			this.MarkId = ((anomalyConfigById2 != null) ? anomalyConfigById2.GetValueOrDefault().MarkId : 0);
			this.IsUnlocked = proto.IsUnlocked;
			this.State = this.CalAnomalyState();
		}

		// Token: 0x06027535 RID: 161077 RVA: 0x00B079C4 File Offset: 0x00B05BC4
		protected void DoProgressIdLogic(IEnumerable<int> progressIds)
		{
			this.ProgressIds.Clear();
			Dictionary<int, ValueTuple<int, int>> dictionary = new Dictionary<int, ValueTuple<int, int>>();
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int num in progressIds)
			{
				SheriffProgress value = SheriffConfig.Instance.GetProgressConfigById(num).Value;
				if (value.GroupId != 0)
				{
					if (dictionary.ContainsKey(value.GroupId))
					{
						if (dictionary[value.GroupId].Item2 < value.GroupPriority)
						{
							dictionary[value.GroupId] = new ValueTuple<int, int>(num, value.GroupPriority);
						}
					}
					else
					{
						dictionary[value.GroupId] = new ValueTuple<int, int>(num, value.GroupPriority);
					}
				}
				else
				{
					hashSet.Add(num);
				}
			}
			foreach (KeyValuePair<int, ValueTuple<int, int>> keyValuePair in dictionary)
			{
				hashSet.Add(keyValuePair.Value.Item1);
			}
			foreach (int item in progressIds)
			{
				if (hashSet.Contains(item))
				{
					this.ProgressIds.Add(item);
				}
			}
		}

		// Token: 0x06027536 RID: 161078 RVA: 0x00B07B40 File Offset: 0x00B05D40
		private int CalAnomalyProgress()
		{
			int num = 0;
			foreach (int id in this.ProgressIds)
			{
				SheriffProgress? progressConfigById = SheriffConfig.Instance.GetProgressConfigById(id);
				if (progressConfigById != null)
				{
					num = Math.Max(num, progressConfigById.Value.Percent);
				}
			}
			return num;
		}

		// Token: 0x06027537 RID: 161079 RVA: 0x00B07BBC File Offset: 0x00B05DBC
		public ESheriffAnomalyState CalAnomalyState()
		{
			SheriffAnomaly? anomalyConfigById = SheriffConfig.Instance.GetAnomalyConfigById(this.AnomalyId);
			if (anomalyConfigById == null)
			{
				return ESheriffAnomalyState.Lock;
			}
			if (!this.IsUnlocked)
			{
				return ESheriffAnomalyState.Lock;
			}
			if (this.EndingTime > 0L)
			{
				return ESheriffAnomalyState.Completed;
			}
			bool flag = false;
			foreach (int markId in anomalyConfigById.Value.UnlockMarkIdsIter())
			{
				if (MapModel.Instance.IsTeleportLocked(markId))
				{
					flag = true;
					break;
				}
			}
			if (!this.IsActivated && flag)
			{
				return ESheriffAnomalyState.UnActivated;
			}
			if (this.Progress == 0)
			{
				return ESheriffAnomalyState.UnOpened;
			}
			return ESheriffAnomalyState.Opened;
		}

		// Token: 0x04015730 RID: 87856
		public int ZoneId;

		// Token: 0x04015731 RID: 87857
		public int AnomalyId;

		// Token: 0x04015732 RID: 87858
		public List<int> ClueIds = new List<int>();

		// Token: 0x04015733 RID: 87859
		public List<int> ProgressIds = new List<int>();

		// Token: 0x04015734 RID: 87860
		public int EndingId;

		// Token: 0x04015735 RID: 87861
		public long EndingTime;

		// Token: 0x04015736 RID: 87862
		public int Progress;

		// Token: 0x04015737 RID: 87863
		public ESheriffAnomalyState State;

		// Token: 0x04015738 RID: 87864
		public bool IsActivated;

		// Token: 0x04015739 RID: 87865
		public int CriminalId;

		// Token: 0x0401573A RID: 87866
		public bool IsUnlocked;

		// Token: 0x0401573B RID: 87867
		public int MarkId;

		// Token: 0x0401573C RID: 87868
		protected bool HasInit;

		// Token: 0x0401573D RID: 87869
		public bool NeedOpenReport;
	}
}

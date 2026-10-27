using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Map;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C32 RID: 19506
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffAnomalyInfo
	{
		// Token: 0x06032781 RID: 206721 RVA: 0x00BC2C38 File Offset: 0x00BC0E38
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
				this.DoProgressIdLogic(proto.ProgressIds.ToList<int>());
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

		// Token: 0x06032782 RID: 206722 RVA: 0x00BC2DA0 File Offset: 0x00BC0FA0
		protected void DoProgressIdLogic(List<int> progressIds)
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

		// Token: 0x06032783 RID: 206723 RVA: 0x00BC2F28 File Offset: 0x00BC1128
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

		// Token: 0x06032784 RID: 206724 RVA: 0x00BC2FA4 File Offset: 0x00BC11A4
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

		// Token: 0x0401ADD3 RID: 110035
		public int ZoneId;

		// Token: 0x0401ADD4 RID: 110036
		public int AnomalyId;

		// Token: 0x0401ADD5 RID: 110037
		public List<int> ClueIds = new List<int>();

		// Token: 0x0401ADD6 RID: 110038
		public List<int> ProgressIds = new List<int>();

		// Token: 0x0401ADD7 RID: 110039
		public int EndingId;

		// Token: 0x0401ADD8 RID: 110040
		public long EndingTime;

		// Token: 0x0401ADD9 RID: 110041
		public int Progress;

		// Token: 0x0401ADDA RID: 110042
		public ESheriffAnomalyState State;

		// Token: 0x0401ADDB RID: 110043
		public bool IsActivated;

		// Token: 0x0401ADDC RID: 110044
		public int CriminalId;

		// Token: 0x0401ADDD RID: 110045
		public bool IsUnlocked;

		// Token: 0x0401ADDE RID: 110046
		public int MarkId;

		// Token: 0x0401ADDF RID: 110047
		protected bool HasInit;

		// Token: 0x0401ADE0 RID: 110048
		public bool NeedOpenReport;
	}
}

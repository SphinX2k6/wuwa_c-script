using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200505C RID: 20572
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeLevelSelectData
	{
		// Token: 0x060337DA RID: 210906 RVA: 0x00E6B6A4 File Offset: 0x00E698A4
		public int GetSelectedRoleTypeId(int instId)
		{
			int result;
			if (!this.SelectedRoleTypeByInst.TryGetValue(instId, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x060337DB RID: 210907 RVA: 0x00E6B6C4 File Offset: 0x00E698C4
		public void SetSelectedRoleTypeId(int instId, int roleTypeId)
		{
			if (instId > 0)
			{
				this.SelectedRoleTypeByInst[instId] = roleTypeId;
			}
		}

		// Token: 0x060337DC RID: 210908 RVA: 0x00E6B6D7 File Offset: 0x00E698D7
		public void Reset()
		{
			this.LastSelectedInstId = 0;
			this.EntryById.Clear();
			this.SelectedRoleTypeByInst.Clear();
		}

		// Token: 0x060337DD RID: 210909 RVA: 0x00E6B6F8 File Offset: 0x00E698F8
		public void PhraseEx(int activityId, RoverRogueActivityData roverData)
		{
			this.ActivityId = activityId;
			RoverRogueHistoryInsInfo historyInsInfo = roverData.HistoryInsInfo;
			this.LastSelectedInstId = ((historyInsInfo != null) ? historyInsInfo.CurInsId : 0);
			this.UpdateEntries(roverData.InsInfoList);
		}

		// Token: 0x060337DE RID: 210910 RVA: 0x00E6B734 File Offset: 0x00E69934
		public void UpdateEntries(IReadOnlyList<RoverRogueInsEntry> entries)
		{
			if (entries.Count <= 0)
			{
				return;
			}
			foreach (RoverRogueInsEntry roverRogueInsEntry in entries)
			{
				this.EntryById[roverRogueInsEntry.InstId] = roverRogueInsEntry;
			}
			EventSystem.Instance.Emit(EEventName.RoverlikeLevelInfoUpdate);
		}

		// Token: 0x060337DF RID: 210911 RVA: 0x00E6B7A4 File Offset: 0x00E699A4
		public bool IsUnlocked(int instId)
		{
			RoverRogueInsEntry roverRogueInsEntry;
			return this.EntryById.TryGetValue(instId, out roverRogueInsEntry) && roverRogueInsEntry.Unlocked;
		}

		// Token: 0x060337E0 RID: 210912 RVA: 0x00E6B7CC File Offset: 0x00E699CC
		public List<int> GetUnlockedInsIdList()
		{
			List<int> list = new List<int>();
			foreach (KeyValuePair<int, RoverRogueInsEntry> keyValuePair in this.EntryById)
			{
				if (keyValuePair.Value.Unlocked)
				{
					list.Add(keyValuePair.Key);
				}
			}
			return list;
		}

		// Token: 0x060337E1 RID: 210913 RVA: 0x00E6B83C File Offset: 0x00E69A3C
		public bool IsPassed(int instId)
		{
			RoverRogueInsEntry roverRogueInsEntry;
			if (this.EntryById.TryGetValue(instId, out roverRogueInsEntry))
			{
				return this.IsGradePassed(new RoverRogueGrade?(roverRogueInsEntry.BestGrade));
			}
			return this.IsGradePassed(null);
		}

		// Token: 0x060337E2 RID: 210914 RVA: 0x00E6B87C File Offset: 0x00E69A7C
		public List<RoverlikeLevelSelectItemData> GetItemDataList()
		{
			List<RoverlikeLevelSelectItemData> list = new List<RoverlikeLevelSelectItemData>();
			foreach (RoverRogueIns roverRogueIns in this.GetSortedConfigs())
			{
				list.Add(this.BuildItemData(roverRogueIns.InstId));
			}
			return list;
		}

		// Token: 0x060337E3 RID: 210915 RVA: 0x00E6B8E4 File Offset: 0x00E69AE4
		[NullableContext(2)]
		public RoverlikeLevelSelectItemData GetItemData(int instId)
		{
			if (RoverlikeConfig.Instance.GetInsConfig(instId) == null)
			{
				return null;
			}
			return this.BuildItemData(instId);
		}

		// Token: 0x060337E4 RID: 210916 RVA: 0x00E6B910 File Offset: 0x00E69B10
		public int GetDefaultSelectInstId()
		{
			List<RoverRogueIns> sortedConfigs = this.GetSortedConfigs();
			if (sortedConfigs.Count == 0)
			{
				return 0;
			}
			if (!this.LastEnterPassed && this.LastSelectedInstId > 0 && this.IsUnlocked(this.LastSelectedInstId))
			{
				return this.LastSelectedInstId;
			}
			int num = 0;
			foreach (RoverRogueIns roverRogueIns in sortedConfigs)
			{
				if (this.IsUnlocked(roverRogueIns.InstId))
				{
					num = roverRogueIns.InstId;
				}
			}
			if (num <= 0)
			{
				return sortedConfigs[0].InstId;
			}
			return num;
		}

		// Token: 0x060337E5 RID: 210917 RVA: 0x00E6B9C0 File Offset: 0x00E69BC0
		public int GetMaxLevelSortId()
		{
			List<RoverRogueIns> sortedConfigs = this.GetSortedConfigs();
			if (sortedConfigs.Count == 0)
			{
				return 0;
			}
			return sortedConfigs[sortedConfigs.Count - 1].SortId;
		}

		// Token: 0x060337E6 RID: 210918 RVA: 0x00E6B9F4 File Offset: 0x00E69BF4
		private RoverlikeLevelSelectItemData BuildItemData(int instId)
		{
			RoverRogueInsEntry roverRogueInsEntry;
			bool flag = this.EntryById.TryGetValue(instId, out roverRogueInsEntry);
			return new RoverlikeLevelSelectItemData
			{
				InstId = instId,
				Unlocked = (flag && roverRogueInsEntry.Unlocked),
				Passed = this.IsGradePassed(flag ? new RoverRogueGrade?(roverRogueInsEntry.BestGrade) : null)
			};
		}

		// Token: 0x060337E7 RID: 210919 RVA: 0x00E6BA54 File Offset: 0x00E69C54
		private List<RoverRogueIns> GetSortedConfigs()
		{
			List<RoverRogueIns> list = new List<RoverRogueIns>();
			foreach (RoverRogueIns item in (RoverlikeConfig.Instance.GetInsConfigList() ?? new List<RoverRogueIns>()))
			{
				if (this.ActivityId <= 0 || item.ActivityId == this.ActivityId)
				{
					list.Add(item);
				}
			}
			list.Sort((RoverRogueIns a, RoverRogueIns b) => a.SortId - b.SortId);
			return list;
		}

		// Token: 0x060337E8 RID: 210920 RVA: 0x00E6BAF4 File Offset: 0x00E69CF4
		private bool IsGradePassed(RoverRogueGrade? grade)
		{
			return grade != null && grade.Value > RoverRogueGrade.B;
		}

		// Token: 0x0401B58F RID: 112015
		public int ActivityId;

		// Token: 0x0401B590 RID: 112016
		public int LastSelectedInstId;

		// Token: 0x0401B591 RID: 112017
		public bool LastEnterPassed = true;

		// Token: 0x0401B592 RID: 112018
		public int SelectedLootId;

		// Token: 0x0401B593 RID: 112019
		public int SelectedLootLv;

		// Token: 0x0401B594 RID: 112020
		private readonly Dictionary<int, RoverRogueInsEntry> EntryById = new Dictionary<int, RoverRogueInsEntry>();

		// Token: 0x0401B595 RID: 112021
		private readonly Dictionary<int, int> SelectedRoleTypeByInst = new Dictionary<int, int>();
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020060DE RID: 24798
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeLevelSelectData
	{
		// Token: 0x0603EB16 RID: 256790 RVA: 0x00F248B0 File Offset: 0x00F22AB0
		public int GetSelectedRoleTypeId(int instId)
		{
			int result;
			if (!this.SelectedRoleTypeByInst.TryGetValue(instId, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x0603EB17 RID: 256791 RVA: 0x00F248D0 File Offset: 0x00F22AD0
		public void SetSelectedRoleTypeId(int instId, int roleTypeId)
		{
			if (instId > 0)
			{
				this.SelectedRoleTypeByInst[instId] = roleTypeId;
			}
		}

		// Token: 0x0603EB18 RID: 256792 RVA: 0x00F248E3 File Offset: 0x00F22AE3
		public void Reset()
		{
			this.LastSelectedInstId = 0;
			this.EntryById.Clear();
			this.SelectedRoleTypeByInst.Clear();
		}

		// Token: 0x0603EB19 RID: 256793 RVA: 0x00F24904 File Offset: 0x00F22B04
		public void PhraseEx(int activityId, RoverRogueActivityData roverData)
		{
			this.ActivityId = activityId;
			RoverRogueHistoryInsInfo historyInsInfo = roverData.HistoryInsInfo;
			this.LastSelectedInstId = ((historyInsInfo != null) ? historyInsInfo.CurInsId : 0);
			this.UpdateEntries(roverData.InsInfoList);
		}

		// Token: 0x0603EB1A RID: 256794 RVA: 0x00F24940 File Offset: 0x00F22B40
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

		// Token: 0x0603EB1B RID: 256795 RVA: 0x00F249B0 File Offset: 0x00F22BB0
		public bool IsUnlocked(int instId)
		{
			RoverRogueInsEntry roverRogueInsEntry;
			return this.EntryById.TryGetValue(instId, out roverRogueInsEntry) && roverRogueInsEntry.Unlocked;
		}

		// Token: 0x0603EB1C RID: 256796 RVA: 0x00F249D8 File Offset: 0x00F22BD8
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

		// Token: 0x0603EB1D RID: 256797 RVA: 0x00F24A48 File Offset: 0x00F22C48
		public bool IsPassed(int instId)
		{
			RoverRogueInsEntry roverRogueInsEntry;
			if (this.EntryById.TryGetValue(instId, out roverRogueInsEntry))
			{
				return this.IsGradePassed(new RoverRogueGrade?(roverRogueInsEntry.BestGrade));
			}
			return this.IsGradePassed(null);
		}

		// Token: 0x0603EB1E RID: 256798 RVA: 0x00F24A86 File Offset: 0x00F22C86
		public List<RoverlikeLevelSelectItemData> GetItemDataList()
		{
			return (from cfg in this.GetSortedConfigs()
			select this.BuildItemData(cfg.InstId)).ToList<RoverlikeLevelSelectItemData>();
		}

		// Token: 0x0603EB1F RID: 256799 RVA: 0x00F24AA4 File Offset: 0x00F22CA4
		[NullableContext(2)]
		public RoverlikeLevelSelectItemData GetItemData(int instId)
		{
			if (RoverlikeConfig.Instance.GetInsConfig(instId) == null)
			{
				return null;
			}
			return this.BuildItemData(instId);
		}

		// Token: 0x0603EB20 RID: 256800 RVA: 0x00F24AD0 File Offset: 0x00F22CD0
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

		// Token: 0x0603EB21 RID: 256801 RVA: 0x00F24B80 File Offset: 0x00F22D80
		public int GetMaxLevelSortId()
		{
			List<RoverRogueIns> sortedConfigs = this.GetSortedConfigs();
			if (sortedConfigs.Count == 0)
			{
				return 0;
			}
			return sortedConfigs[sortedConfigs.Count - 1].SortId;
		}

		// Token: 0x0603EB22 RID: 256802 RVA: 0x00F24BB4 File Offset: 0x00F22DB4
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

		// Token: 0x0603EB23 RID: 256803 RVA: 0x00F24C14 File Offset: 0x00F22E14
		private List<RoverRogueIns> GetSortedConfigs()
		{
			List<RoverRogueIns> list = (from cfg in RoverlikeConfig.Instance.GetInsConfigList() ?? new List<RoverRogueIns>()
			where this.ActivityId <= 0 || cfg.ActivityId == this.ActivityId
			select cfg).ToList<RoverRogueIns>();
			list.Sort((RoverRogueIns a, RoverRogueIns b) => a.SortId - b.SortId);
			return list;
		}

		// Token: 0x0603EB24 RID: 256804 RVA: 0x00F24C6F File Offset: 0x00F22E6F
		private bool IsGradePassed(RoverRogueGrade? grade)
		{
			return grade != null && grade.Value > RoverRogueGrade.B;
		}

		// Token: 0x04020C62 RID: 134242
		public int ActivityId;

		// Token: 0x04020C63 RID: 134243
		public int LastSelectedInstId;

		// Token: 0x04020C64 RID: 134244
		public bool LastEnterPassed = true;

		// Token: 0x04020C65 RID: 134245
		public int SelectedLootId;

		// Token: 0x04020C66 RID: 134246
		public int SelectedLootLv;

		// Token: 0x04020C67 RID: 134247
		private readonly Dictionary<int, RoverRogueInsEntry> EntryById = new Dictionary<int, RoverRogueInsEntry>();

		// Token: 0x04020C68 RID: 134248
		private readonly Dictionary<int, int> SelectedRoleTypeByInst = new Dictionary<int, int>();
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058CC RID: 22732
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolEndingSnapshot
	{
		// Token: 0x17006B5F RID: 27487
		// (get) Token: 0x06037FA8 RID: 229288 RVA: 0x00FA5C1D File Offset: 0x00FA3E1D
		public int CycleCount { get; }

		// Token: 0x06037FA9 RID: 229289 RVA: 0x00FA5C28 File Offset: 0x00FA3E28
		public SolarSchoolEndingSnapshot(SolarSchoolGamePlayModel model)
		{
			this.CycleCount = model.CycleCount;
			foreach (ESolarSchoolSecondAttr esolarSchoolSecondAttr in Enum.GetValues<ESolarSchoolSecondAttr>())
			{
				if (esolarSchoolSecondAttr != ESolarSchoolSecondAttr.None)
				{
					this.Attrs[esolarSchoolSecondAttr] = model.PlayerData.GetAttr(esolarSchoolSecondAttr);
				}
			}
			foreach (ESolarSchoolInfluence esolarSchoolInfluence in Enum.GetValues<ESolarSchoolInfluence>())
			{
				if (esolarSchoolInfluence != ESolarSchoolInfluence.None)
				{
					this.InfluenceLevels[esolarSchoolInfluence] = model.PlayerData.GetInfluenceLevel(esolarSchoolInfluence);
				}
			}
			foreach (KeyValuePair<int, SolarSchoolExamResult> keyValuePair in model.PlayerData.GetExamResults())
			{
				this.ExamResults[keyValuePair.Key] = new SolarSchoolExamResult(keyValuePair.Value.ExamId, keyValuePair.Value.Score, keyValuePair.Value.Rank, keyValuePair.Value.IsPublished);
			}
			foreach (SolarSchoolRoleData solarSchoolRoleData in model.FriendData.Roles)
			{
				this.Roles[solarSchoolRoleData.RoleId] = new SolarSchoolEndingSnapshotRoleEntry(solarSchoolRoleData);
			}
		}

		// Token: 0x06037FAA RID: 229290 RVA: 0x00FA5DC4 File Offset: 0x00FA3FC4
		public int GetAttr(ESolarSchoolSecondAttr attr)
		{
			return this.Attrs.GetValueOrDefault(attr, 0);
		}

		// Token: 0x06037FAB RID: 229291 RVA: 0x00FA5DD3 File Offset: 0x00FA3FD3
		public int GetInfluenceLevel(ESolarSchoolInfluence influence)
		{
			return this.InfluenceLevels.GetValueOrDefault(influence, 0);
		}

		// Token: 0x06037FAC RID: 229292 RVA: 0x00FA5DE4 File Offset: 0x00FA3FE4
		public int GetExamScore(int examId)
		{
			SolarSchoolExamResult solarSchoolExamResult;
			if (!this.ExamResults.TryGetValue(examId, out solarSchoolExamResult))
			{
				return 0;
			}
			return solarSchoolExamResult.Score;
		}

		// Token: 0x06037FAD RID: 229293 RVA: 0x00FA5E09 File Offset: 0x00FA4009
		public bool IsRoleUnlocked(int roleId)
		{
			SolarSchoolEndingSnapshotRoleEntry valueOrDefault = this.Roles.GetValueOrDefault(roleId);
			return valueOrDefault != null && valueOrDefault.IsUnlocked;
		}

		// Token: 0x06037FAE RID: 229294 RVA: 0x00FA5E22 File Offset: 0x00FA4022
		public int GetFavorLevel(int roleId)
		{
			SolarSchoolEndingSnapshotRoleEntry valueOrDefault = this.Roles.GetValueOrDefault(roleId);
			if (valueOrDefault == null)
			{
				return 0;
			}
			return valueOrDefault.FavorLevel;
		}

		// Token: 0x06037FAF RID: 229295 RVA: 0x00FA5E3B File Offset: 0x00FA403B
		public bool IsFavorValueFull(int roleId)
		{
			SolarSchoolEndingSnapshotRoleEntry valueOrDefault = this.Roles.GetValueOrDefault(roleId);
			return valueOrDefault != null && valueOrDefault.IsFavorValueFull;
		}

		// Token: 0x06037FB0 RID: 229296 RVA: 0x00FA5E54 File Offset: 0x00FA4054
		public int GetGiftReceivedCount(int roleId)
		{
			SolarSchoolEndingSnapshotRoleEntry valueOrDefault = this.Roles.GetValueOrDefault(roleId);
			if (valueOrDefault == null)
			{
				return 0;
			}
			return valueOrDefault.GiftReceivedCount;
		}

		// Token: 0x0401D865 RID: 120933
		private readonly Dictionary<ESolarSchoolSecondAttr, int> Attrs = new Dictionary<ESolarSchoolSecondAttr, int>();

		// Token: 0x0401D866 RID: 120934
		private readonly Dictionary<ESolarSchoolInfluence, int> InfluenceLevels = new Dictionary<ESolarSchoolInfluence, int>();

		// Token: 0x0401D867 RID: 120935
		private readonly Dictionary<int, SolarSchoolExamResult> ExamResults = new Dictionary<int, SolarSchoolExamResult>();

		// Token: 0x0401D868 RID: 120936
		private readonly Dictionary<int, SolarSchoolEndingSnapshotRoleEntry> Roles = new Dictionary<int, SolarSchoolEndingSnapshotRoleEntry>();
	}
}

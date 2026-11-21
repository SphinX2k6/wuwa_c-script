using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x02003803 RID: 14339
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class VillageInfrConfig : ConfigBase
	{
		// Token: 0x06025465 RID: 152677 RVA: 0x00A83544 File Offset: 0x00A81744
		protected override bool OnInit()
		{
			this.TreeRelativeAreas.Clear();
			this.ItemIdToTree.Clear();
			foreach (InfrV2TreeBuild infrV2TreeBuild in this.GetInfrTreeBuildAll())
			{
				this.TreeRelativeAreas.Add(infrV2TreeBuild.AreaId);
				Dictionary<int, int>.KeyCollection.Enumerator enumerator2 = infrV2TreeBuild.Requirement().Keys.GetEnumerator();
				enumerator2.MoveNext();
				this.ItemIdToTree[enumerator2.Current] = infrV2TreeBuild.Id;
			}
			return true;
		}

		// Token: 0x06025466 RID: 152678 RVA: 0x00A835E8 File Offset: 0x00A817E8
		protected override bool OnClear()
		{
			this.TreeRelativeAreas.Clear();
			this.ItemIdToTree.Clear();
			return true;
		}

		// Token: 0x06025467 RID: 152679 RVA: 0x00A83601 File Offset: 0x00A81801
		public InfrV2Reward? GetInfrActivityTaskConfig(int configId)
		{
			return ConfigInfrV2RewardById.GetConfig(configId, true);
		}

		// Token: 0x06025468 RID: 152680 RVA: 0x00A8360A File Offset: 0x00A8180A
		public IReadOnlyList<InfrV2TreeBuild> GetInfrTreeBuildAll()
		{
			return ConfigInfrV2TreeBuildAll.GetConfigList(true) ?? new List<InfrV2TreeBuild>();
		}

		// Token: 0x06025469 RID: 152681 RVA: 0x00A8361B File Offset: 0x00A8181B
		public InfrV2TreeBuild? GetInfrTreeBuild(int configId)
		{
			return ConfigInfrV2TreeBuildById.GetConfig(configId, true);
		}

		// Token: 0x0602546A RID: 152682 RVA: 0x00A83624 File Offset: 0x00A81824
		public InfrV2Level? GetInfrLevel(int level)
		{
			return ConfigInfrV2LevelByLevel.GetConfig(level, true);
		}

		// Token: 0x0602546B RID: 152683 RVA: 0x00A8362D File Offset: 0x00A8182D
		public IReadOnlyList<InfrV2Level> GetInfrLevelAll()
		{
			return ConfigInfrV2LevelAll.GetConfigList(true) ?? new List<InfrV2Level>();
		}

		// Token: 0x0602546C RID: 152684 RVA: 0x00A83640 File Offset: 0x00A81840
		public int GetInfrMaxLevel()
		{
			int num = 0;
			foreach (InfrV2Level infrV2Level in this.GetInfrLevelAll())
			{
				if (infrV2Level.Level > num)
				{
					num = infrV2Level.Level;
				}
			}
			return num;
		}

		// Token: 0x0602546D RID: 152685 RVA: 0x00A8369C File Offset: 0x00A8189C
		public IReadOnlyList<InfrV2ScoreReward> GetScoreReward()
		{
			return ConfigInfrV2ScoreRewardAll.GetConfigList(true) ?? new List<InfrV2ScoreReward>();
		}

		// Token: 0x0602546E RID: 152686 RVA: 0x00A836AD File Offset: 0x00A818AD
		public InfrV2ScoreReward? GetScoreRewardById(int id)
		{
			return ConfigInfrV2ScoreRewardById.GetConfig(id, true);
		}

		// Token: 0x0602546F RID: 152687 RVA: 0x00A836B6 File Offset: 0x00A818B6
		public InfrV2TreeBuild? GetTreeConfigByMarkId(int markId)
		{
			return ConfigInfrV2TreeBuildByMarkId.GetConfig(markId, true);
		}

		// Token: 0x06025470 RID: 152688 RVA: 0x00A836C0 File Offset: 0x00A818C0
		public InfrV2TreeBuild? GetTreeConfigByAreaId(int areaId)
		{
			if (!this.TreeRelativeAreas.Contains(areaId))
			{
				return null;
			}
			return ConfigInfrV2TreeBuildByAreaId.GetConfig(areaId, true);
		}

		// Token: 0x06025471 RID: 152689 RVA: 0x00A836EC File Offset: 0x00A818EC
		public IReadOnlyList<InfrV2PopupMsg> GetPopupMsgAll()
		{
			return ConfigInfrV2PopupMsgAll.GetConfigList(true) ?? new List<InfrV2PopupMsg>();
		}

		// Token: 0x06025472 RID: 152690 RVA: 0x00A83700 File Offset: 0x00A81900
		public int? GetTreeIdByItemId(int itemId)
		{
			int value;
			if (this.ItemIdToTree.TryGetValue(itemId, out value))
			{
				return new int?(value);
			}
			return null;
		}

		// Token: 0x06025473 RID: 152691 RVA: 0x00A83730 File Offset: 0x00A81930
		public int GetMainHelpId()
		{
			return ConfigCommonParamById.GetIntConfig("VillageInfrMainHelpId").GetValueOrDefault();
		}

		// Token: 0x17004C96 RID: 19606
		// (get) Token: 0x06025474 RID: 152692 RVA: 0x00A8374F File Offset: 0x00A8194F
		public static VillageInfrConfig Instance
		{
			get
			{
				return VillageInfrConfig._Instance;
			}
		}

		// Token: 0x06025475 RID: 152693 RVA: 0x00A83756 File Offset: 0x00A81956
		public static VillageInfrConfig GetOrCreateInstance()
		{
			if (VillageInfrConfig._Instance == null)
			{
				VillageInfrConfig.CreateInstance();
			}
			return VillageInfrConfig._Instance;
		}

		// Token: 0x06025476 RID: 152694 RVA: 0x00A8376A File Offset: 0x00A8196A
		public static bool CreateInstance()
		{
			if (VillageInfrConfig._Instance != null)
			{
				return true;
			}
			VillageInfrConfig._Instance = new VillageInfrConfig();
			return true;
		}

		// Token: 0x06025477 RID: 152695 RVA: 0x00A83780 File Offset: 0x00A81980
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06025478 RID: 152696 RVA: 0x00A83782 File Offset: 0x00A81982
		public static void ResetStaticDefaultValue()
		{
			VillageInfrConfig._Instance = null;
		}

		// Token: 0x06025479 RID: 152697 RVA: 0x00A8378A File Offset: 0x00A8198A
		static VillageInfrConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(VillageInfrConfig.CreateStaticDefaultValue), new Action(VillageInfrConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04014A22 RID: 84514
		private readonly HashSet<int> TreeRelativeAreas = new HashSet<int>();

		// Token: 0x04014A23 RID: 84515
		private readonly Dictionary<int, int> ItemIdToTree = new Dictionary<int, int>();

		// Token: 0x04014A24 RID: 84516
		[Nullable(2)]
		private static VillageInfrConfig _Instance;
	}
}

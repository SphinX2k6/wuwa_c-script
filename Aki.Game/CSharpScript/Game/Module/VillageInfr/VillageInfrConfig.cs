using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x0200488C RID: 18572
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class VillageInfrConfig : ConfigBase
	{
		// Token: 0x06030939 RID: 198969 RVA: 0x00B4873C File Offset: 0x00B4693C
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

		// Token: 0x0603093A RID: 198970 RVA: 0x00B487E0 File Offset: 0x00B469E0
		protected override bool OnClear()
		{
			this.TreeRelativeAreas.Clear();
			this.ItemIdToTree.Clear();
			return true;
		}

		// Token: 0x0603093B RID: 198971 RVA: 0x00B487F9 File Offset: 0x00B469F9
		public InfrV2Reward? GetInfrActivityTaskConfig(int configId)
		{
			return ConfigInfrV2RewardById.GetConfig(configId, true);
		}

		// Token: 0x0603093C RID: 198972 RVA: 0x00B48802 File Offset: 0x00B46A02
		public IReadOnlyList<InfrV2TreeBuild> GetInfrTreeBuildAll()
		{
			return ConfigInfrV2TreeBuildAll.GetConfigList(true) ?? new List<InfrV2TreeBuild>();
		}

		// Token: 0x0603093D RID: 198973 RVA: 0x00B48813 File Offset: 0x00B46A13
		public InfrV2TreeBuild? GetInfrTreeBuild(int configId)
		{
			return ConfigInfrV2TreeBuildById.GetConfig(configId, true);
		}

		// Token: 0x0603093E RID: 198974 RVA: 0x00B4881C File Offset: 0x00B46A1C
		public InfrV2Level? GetInfrLevel(int level)
		{
			return ConfigInfrV2LevelByLevel.GetConfig(level, true);
		}

		// Token: 0x0603093F RID: 198975 RVA: 0x00B48825 File Offset: 0x00B46A25
		public IReadOnlyList<InfrV2Level> GetInfrLevelAll()
		{
			return ConfigInfrV2LevelAll.GetConfigList(true) ?? new List<InfrV2Level>();
		}

		// Token: 0x06030940 RID: 198976 RVA: 0x00B48838 File Offset: 0x00B46A38
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

		// Token: 0x06030941 RID: 198977 RVA: 0x00B48894 File Offset: 0x00B46A94
		public IReadOnlyList<InfrV2ScoreReward> GetScoreReward()
		{
			return ConfigInfrV2ScoreRewardAll.GetConfigList(true) ?? new List<InfrV2ScoreReward>();
		}

		// Token: 0x06030942 RID: 198978 RVA: 0x00B488A5 File Offset: 0x00B46AA5
		public InfrV2ScoreReward? GetScoreRewardById(int id)
		{
			return ConfigInfrV2ScoreRewardById.GetConfig(id, true);
		}

		// Token: 0x06030943 RID: 198979 RVA: 0x00B488AE File Offset: 0x00B46AAE
		public InfrV2TreeBuild? GetTreeConfigByMarkId(int markId)
		{
			return ConfigInfrV2TreeBuildByMarkId.GetConfig(markId, true);
		}

		// Token: 0x06030944 RID: 198980 RVA: 0x00B488B8 File Offset: 0x00B46AB8
		public InfrV2TreeBuild? GetTreeConfigByAreaId(int areaId)
		{
			if (!this.TreeRelativeAreas.Contains(areaId))
			{
				return null;
			}
			return ConfigInfrV2TreeBuildByAreaId.GetConfig(areaId, true);
		}

		// Token: 0x06030945 RID: 198981 RVA: 0x00B488E4 File Offset: 0x00B46AE4
		public IReadOnlyList<InfrV2PopupMsg> GetPopupMsgAll()
		{
			return ConfigInfrV2PopupMsgAll.GetConfigList(true) ?? new List<InfrV2PopupMsg>();
		}

		// Token: 0x06030946 RID: 198982 RVA: 0x00B488F8 File Offset: 0x00B46AF8
		public int? GetTreeIdByItemId(int itemId)
		{
			int value;
			if (this.ItemIdToTree.TryGetValue(itemId, out value))
			{
				return new int?(value);
			}
			return null;
		}

		// Token: 0x06030947 RID: 198983 RVA: 0x00B48928 File Offset: 0x00B46B28
		public int GetMainHelpId()
		{
			return ConfigCommonParamById.GetIntConfig("VillageInfrMainHelpId").GetValueOrDefault();
		}

		// Token: 0x1700792E RID: 31022
		// (get) Token: 0x06030948 RID: 198984 RVA: 0x00B48947 File Offset: 0x00B46B47
		public static VillageInfrConfig Instance
		{
			get
			{
				return VillageInfrConfig._Instance;
			}
		}

		// Token: 0x06030949 RID: 198985 RVA: 0x00B4894E File Offset: 0x00B46B4E
		public static VillageInfrConfig GetOrCreateInstance()
		{
			if (VillageInfrConfig._Instance == null)
			{
				VillageInfrConfig.CreateInstance();
			}
			return VillageInfrConfig._Instance;
		}

		// Token: 0x0603094A RID: 198986 RVA: 0x00B48962 File Offset: 0x00B46B62
		public static bool CreateInstance()
		{
			if (VillageInfrConfig._Instance != null)
			{
				return true;
			}
			VillageInfrConfig._Instance = new VillageInfrConfig();
			return true;
		}

		// Token: 0x0603094B RID: 198987 RVA: 0x00B48978 File Offset: 0x00B46B78
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603094C RID: 198988 RVA: 0x00B4897A File Offset: 0x00B46B7A
		public static void ResetStaticDefaultValue()
		{
			VillageInfrConfig._Instance = null;
		}

		// Token: 0x0603094D RID: 198989 RVA: 0x00B48982 File Offset: 0x00B46B82
		static VillageInfrConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(VillageInfrConfig.CreateStaticDefaultValue), new Action(VillageInfrConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401A1AF RID: 106927
		private readonly HashSet<int> TreeRelativeAreas = new HashSet<int>();

		// Token: 0x0401A1B0 RID: 106928
		private readonly Dictionary<int, int> ItemIdToTree = new Dictionary<int, int>();

		// Token: 0x0401A1B1 RID: 106929
		[Nullable(2)]
		private static VillageInfrConfig _Instance;
	}
}

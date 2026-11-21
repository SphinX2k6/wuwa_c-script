using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048D9 RID: 18649
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class InfrastructureConfig : ConfigBase
	{
		// Token: 0x0602EC84 RID: 191620 RVA: 0x00D0BCA1 File Offset: 0x00D09EA1
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0602EC85 RID: 191621 RVA: 0x00D0BCA4 File Offset: 0x00D09EA4
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x0602EC86 RID: 191622 RVA: 0x00D0BCA7 File Offset: 0x00D09EA7
		public InfrRoadBuild? GetRoadConfigById(int roadId)
		{
			return ConfigInfrRoadBuildById.GetConfig(roadId, true);
		}

		// Token: 0x0602EC87 RID: 191623 RVA: 0x00D0BCB0 File Offset: 0x00D09EB0
		public IReadOnlyList<InfrRoadBuild> GetRoadConfigList()
		{
			return ConfigInfrRoadBuildAll.GetConfigList(true) ?? Array.Empty<InfrRoadBuild>();
		}

		// Token: 0x0602EC88 RID: 191624 RVA: 0x00D0BCC1 File Offset: 0x00D09EC1
		public InfrRoadBuild? GetRoadConfigByMarkId(int markId)
		{
			return ConfigInfrRoadBuildByMarkId.GetConfig(markId, true);
		}

		// Token: 0x0602EC89 RID: 191625 RVA: 0x00D0BCCA File Offset: 0x00D09ECA
		public InfrLevel? GetLevelConfigById(int levelId)
		{
			return ConfigInfrLevelByLevel.GetConfig(levelId, true);
		}

		// Token: 0x0602EC8A RID: 191626 RVA: 0x00D0BCD4 File Offset: 0x00D09ED4
		public int GetMaxLevel()
		{
			IReadOnlyList<InfrLevel> allLevelConfigs = this.GetAllLevelConfigs();
			if (allLevelConfigs.Count == 0)
			{
				throw new InvalidOperationException("Sequence contains no elements");
			}
			int level = allLevelConfigs[0].Level;
			for (int i = 1; i < allLevelConfigs.Count; i++)
			{
				if (allLevelConfigs[i].Level > level)
				{
					level = allLevelConfigs[i].Level;
				}
			}
			return level;
		}

		// Token: 0x0602EC8B RID: 191627 RVA: 0x00D0BD3F File Offset: 0x00D09F3F
		public IReadOnlyList<InfrLevel> GetAllLevelConfigs()
		{
			return ConfigInfrLevelAll.GetConfigList(true) ?? Array.Empty<InfrLevel>();
		}

		// Token: 0x0602EC8C RID: 191628 RVA: 0x00D0BD50 File Offset: 0x00D09F50
		public string GetItemQualityColor(int quality)
		{
			InfrItemQuality? infrItemQuality;
			return ((ConfigInfrItemQualityById.GetConfig(quality, true) != null) ? infrItemQuality.GetValueOrDefault().Color : null) ?? "#FFE65A";
		}

		// Token: 0x0602EC8D RID: 191629 RVA: 0x00D0BD89 File Offset: 0x00D09F89
		public InfrActivityTask? GetInfrActivityTaskConfig(int configId)
		{
			return ConfigInfrActivityTaskByTaskId.GetConfig(configId, true);
		}

		// Token: 0x0602EC8E RID: 191630 RVA: 0x00D0BD94 File Offset: 0x00D09F94
		public string GetArchiveItemQualityPath(int quality)
		{
			InfrArchiveItemQuality? infrArchiveItemQuality;
			return ((ConfigInfrArchiveItemQualityById.GetConfig(quality, true) != null) ? infrArchiveItemQuality.GetValueOrDefault().Path : null) ?? "";
		}

		// Token: 0x0602EC8F RID: 191631 RVA: 0x00D0BDCD File Offset: 0x00D09FCD
		public InfrArchiveItem? GetArchiveItemConfig(int configId)
		{
			return ConfigInfrArchiveItemById.GetConfig(configId, true);
		}

		// Token: 0x0602EC90 RID: 191632 RVA: 0x00D0BDD6 File Offset: 0x00D09FD6
		public InfrArchiveItem? GetArchiveItemById(int itemId)
		{
			return ConfigInfrArchiveItemById.GetConfig(itemId, true);
		}

		// Token: 0x0602EC91 RID: 191633 RVA: 0x00D0BDDF File Offset: 0x00D09FDF
		public IReadOnlyList<InfrArchiveItem> GetArchiveItemIdConfigList()
		{
			return ConfigInfrArchiveItemAll.GetConfigList(true) ?? Array.Empty<InfrArchiveItem>();
		}

		// Token: 0x0602EC92 RID: 191634 RVA: 0x00D0BDF0 File Offset: 0x00D09FF0
		public IReadOnlyList<InfrArchiveTask> GetInfrArchiveTaskList()
		{
			return ConfigInfrArchiveTaskAll.GetConfigList(true) ?? Array.Empty<InfrArchiveTask>();
		}

		// Token: 0x0602EC93 RID: 191635 RVA: 0x00D0BE01 File Offset: 0x00D0A001
		public IReadOnlyList<InfrPhoneTask> GetInfrPhoneTaskList()
		{
			return ConfigInfrPhoneTaskAll.GetConfigList(true) ?? Array.Empty<InfrPhoneTask>();
		}

		// Token: 0x0602EC94 RID: 191636 RVA: 0x00D0BE12 File Offset: 0x00D0A012
		public IReadOnlyList<InfrPasser> GetInfrPasserConfigList()
		{
			return ConfigInfrPasserAll.GetConfigList(true) ?? Array.Empty<InfrPasser>();
		}

		// Token: 0x0602EC95 RID: 191637 RVA: 0x00D0BE23 File Offset: 0x00D0A023
		public InfrPasser? GetInfrPasserConfigById(int passerId)
		{
			return ConfigInfrPasserById.GetConfig(passerId, true);
		}

		// Token: 0x0602EC96 RID: 191638 RVA: 0x00D0BE2C File Offset: 0x00D0A02C
		public InfrPhoneMessage? GetInfrPhoneMessageConfigById(int messageId)
		{
			return ConfigInfrPhoneMessageById.GetConfig(messageId, true);
		}

		// Token: 0x0602EC97 RID: 191639 RVA: 0x00D0BE35 File Offset: 0x00D0A035
		public IReadOnlyList<InfrPhoneMessage> GetInfrPhoneMessageConfigList()
		{
			return ConfigInfrPhoneMessageAll.GetConfigList(true) ?? Array.Empty<InfrPhoneMessage>();
		}

		// Token: 0x0602EC98 RID: 191640 RVA: 0x00D0BE48 File Offset: 0x00D0A048
		public int GetHelpIdActivity()
		{
			return ConfigCommonParamById.GetIntConfig("BuildRoad_ActivityHelpId").GetValueOrDefault();
		}

		// Token: 0x0602EC99 RID: 191641 RVA: 0x00D0BE68 File Offset: 0x00D0A068
		public int GetHelpIdRoadProcess()
		{
			return ConfigCommonParamById.GetIntConfig("BuildRoad_RoadProcessHelpId").GetValueOrDefault();
		}

		// Token: 0x0602EC9A RID: 191642 RVA: 0x00D0BE87 File Offset: 0x00D0A087
		public IReadOnlyList<InfrAutoPilotCircle> GetAutoPilotCircle()
		{
			return ConfigInfrAutoPilotCircleAll.GetConfigList(true) ?? Array.Empty<InfrAutoPilotCircle>();
		}

		// Token: 0x17005E95 RID: 24213
		// (get) Token: 0x0602EC9B RID: 191643 RVA: 0x00D0BE98 File Offset: 0x00D0A098
		public static InfrastructureConfig Instance
		{
			get
			{
				return InfrastructureConfig._Instance;
			}
		}

		// Token: 0x0602EC9C RID: 191644 RVA: 0x00D0BE9F File Offset: 0x00D0A09F
		public static InfrastructureConfig GetOrCreateInstance()
		{
			if (InfrastructureConfig._Instance == null)
			{
				InfrastructureConfig.CreateInstance();
			}
			return InfrastructureConfig._Instance;
		}

		// Token: 0x0602EC9D RID: 191645 RVA: 0x00D0BEB3 File Offset: 0x00D0A0B3
		public static bool CreateInstance()
		{
			if (InfrastructureConfig._Instance != null)
			{
				return true;
			}
			InfrastructureConfig._Instance = new InfrastructureConfig();
			return true;
		}

		// Token: 0x0602EC9E RID: 191646 RVA: 0x00D0BEC9 File Offset: 0x00D0A0C9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602EC9F RID: 191647 RVA: 0x00D0BECB File Offset: 0x00D0A0CB
		public static void ResetStaticDefaultValue()
		{
			InfrastructureConfig._Instance = null;
		}

		// Token: 0x0602ECA0 RID: 191648 RVA: 0x00D0BED3 File Offset: 0x00D0A0D3
		static InfrastructureConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InfrastructureConfig.CreateStaticDefaultValue), new Action(InfrastructureConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04018D7D RID: 101757
		[Nullable(2)]
		private static InfrastructureConfig _Instance;
	}
}

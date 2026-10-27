using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x02005900 RID: 22784
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class InfrastructureConfig : ConfigBase
	{
		// Token: 0x06039D5E RID: 236894 RVA: 0x00DBCCA9 File Offset: 0x00DBAEA9
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x06039D5F RID: 236895 RVA: 0x00DBCCAC File Offset: 0x00DBAEAC
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x06039D60 RID: 236896 RVA: 0x00DBCCAF File Offset: 0x00DBAEAF
		public InfrRoadBuild? GetRoadConfigById(int roadId)
		{
			return ConfigInfrRoadBuildById.GetConfig(roadId, true);
		}

		// Token: 0x06039D61 RID: 236897 RVA: 0x00DBCCB8 File Offset: 0x00DBAEB8
		public IReadOnlyList<InfrRoadBuild> GetRoadConfigList()
		{
			return ConfigInfrRoadBuildAll.GetConfigList(true) ?? Array.Empty<InfrRoadBuild>();
		}

		// Token: 0x06039D62 RID: 236898 RVA: 0x00DBCCC9 File Offset: 0x00DBAEC9
		public InfrRoadBuild? GetRoadConfigByMarkId(int markId)
		{
			return ConfigInfrRoadBuildByMarkId.GetConfig(markId, true);
		}

		// Token: 0x06039D63 RID: 236899 RVA: 0x00DBCCD2 File Offset: 0x00DBAED2
		public InfrLevel? GetLevelConfigById(int levelId)
		{
			return ConfigInfrLevelByLevel.GetConfig(levelId, true);
		}

		// Token: 0x06039D64 RID: 236900 RVA: 0x00DBCCDC File Offset: 0x00DBAEDC
		public int GetMaxLevel()
		{
			return this.GetAllLevelConfigs().ToList<InfrLevel>().Aggregate(delegate(InfrLevel prev, InfrLevel cur)
			{
				if (prev.Level <= cur.Level)
				{
					return cur;
				}
				return prev;
			}).Level;
		}

		// Token: 0x06039D65 RID: 236901 RVA: 0x00DBCD20 File Offset: 0x00DBAF20
		public IReadOnlyList<InfrLevel> GetAllLevelConfigs()
		{
			return ConfigInfrLevelAll.GetConfigList(true) ?? Array.Empty<InfrLevel>();
		}

		// Token: 0x06039D66 RID: 236902 RVA: 0x00DBCD34 File Offset: 0x00DBAF34
		public string GetItemQualityColor(int quality)
		{
			InfrItemQuality? infrItemQuality;
			return ((ConfigInfrItemQualityById.GetConfig(quality, true) != null) ? infrItemQuality.GetValueOrDefault().Color : null) ?? "#FFE65A";
		}

		// Token: 0x06039D67 RID: 236903 RVA: 0x00DBCD6D File Offset: 0x00DBAF6D
		public InfrActivityTask? GetInfrActivityTaskConfig(int configId)
		{
			return ConfigInfrActivityTaskByTaskId.GetConfig(configId, true);
		}

		// Token: 0x06039D68 RID: 236904 RVA: 0x00DBCD78 File Offset: 0x00DBAF78
		public string GetArchiveItemQualityPath(int quality)
		{
			InfrArchiveItemQuality? infrArchiveItemQuality;
			return ((ConfigInfrArchiveItemQualityById.GetConfig(quality, true) != null) ? infrArchiveItemQuality.GetValueOrDefault().Path : null) ?? "";
		}

		// Token: 0x06039D69 RID: 236905 RVA: 0x00DBCDB1 File Offset: 0x00DBAFB1
		public InfrArchiveItem? GetArchiveItemConfig(int configId)
		{
			return ConfigInfrArchiveItemById.GetConfig(configId, true);
		}

		// Token: 0x06039D6A RID: 236906 RVA: 0x00DBCDBA File Offset: 0x00DBAFBA
		public InfrArchiveItem? GetArchiveItemById(int itemId)
		{
			return ConfigInfrArchiveItemById.GetConfig(itemId, true);
		}

		// Token: 0x06039D6B RID: 236907 RVA: 0x00DBCDC3 File Offset: 0x00DBAFC3
		public IReadOnlyList<InfrArchiveItem> GetArchiveItemIdConfigList()
		{
			return ConfigInfrArchiveItemAll.GetConfigList(true) ?? Array.Empty<InfrArchiveItem>();
		}

		// Token: 0x06039D6C RID: 236908 RVA: 0x00DBCDD4 File Offset: 0x00DBAFD4
		public IReadOnlyList<InfrArchiveTask> GetInfrArchiveTaskList()
		{
			return ConfigInfrArchiveTaskAll.GetConfigList(true) ?? Array.Empty<InfrArchiveTask>();
		}

		// Token: 0x06039D6D RID: 236909 RVA: 0x00DBCDE5 File Offset: 0x00DBAFE5
		public IReadOnlyList<InfrPhoneTask> GetInfrPhoneTaskList()
		{
			return ConfigInfrPhoneTaskAll.GetConfigList(true) ?? Array.Empty<InfrPhoneTask>();
		}

		// Token: 0x06039D6E RID: 236910 RVA: 0x00DBCDF6 File Offset: 0x00DBAFF6
		public IReadOnlyList<InfrPasser> GetInfrPasserConfigList()
		{
			return ConfigInfrPasserAll.GetConfigList(true) ?? Array.Empty<InfrPasser>();
		}

		// Token: 0x06039D6F RID: 236911 RVA: 0x00DBCE07 File Offset: 0x00DBB007
		public InfrPasser? GetInfrPasserConfigById(int passerId)
		{
			return ConfigInfrPasserById.GetConfig(passerId, true);
		}

		// Token: 0x06039D70 RID: 236912 RVA: 0x00DBCE10 File Offset: 0x00DBB010
		public InfrPhoneMessage? GetInfrPhoneMessageConfigById(int messageId)
		{
			return ConfigInfrPhoneMessageById.GetConfig(messageId, true);
		}

		// Token: 0x06039D71 RID: 236913 RVA: 0x00DBCE19 File Offset: 0x00DBB019
		public IReadOnlyList<InfrPhoneMessage> GetInfrPhoneMessageConfigList()
		{
			return ConfigInfrPhoneMessageAll.GetConfigList(true) ?? Array.Empty<InfrPhoneMessage>();
		}

		// Token: 0x06039D72 RID: 236914 RVA: 0x00DBCE2C File Offset: 0x00DBB02C
		public int GetHelpIdActivity()
		{
			return ConfigCommonParamById.GetIntConfig("BuildRoad_ActivityHelpId").GetValueOrDefault();
		}

		// Token: 0x06039D73 RID: 236915 RVA: 0x00DBCE4C File Offset: 0x00DBB04C
		public int GetHelpIdRoadProcess()
		{
			return ConfigCommonParamById.GetIntConfig("BuildRoad_RoadProcessHelpId").GetValueOrDefault();
		}

		// Token: 0x06039D74 RID: 236916 RVA: 0x00DBCE6B File Offset: 0x00DBB06B
		public IReadOnlyList<InfrAutoPilotCircle> GetAutoPilotCircle()
		{
			return ConfigInfrAutoPilotCircleAll.GetConfigList(true) ?? Array.Empty<InfrAutoPilotCircle>();
		}

		// Token: 0x17008AC9 RID: 35529
		// (get) Token: 0x06039D75 RID: 236917 RVA: 0x00DBCE7C File Offset: 0x00DBB07C
		public static InfrastructureConfig Instance
		{
			get
			{
				return InfrastructureConfig._Instance;
			}
		}

		// Token: 0x06039D76 RID: 236918 RVA: 0x00DBCE83 File Offset: 0x00DBB083
		public static InfrastructureConfig GetOrCreateInstance()
		{
			if (InfrastructureConfig._Instance == null)
			{
				InfrastructureConfig.CreateInstance();
			}
			return InfrastructureConfig._Instance;
		}

		// Token: 0x06039D77 RID: 236919 RVA: 0x00DBCE97 File Offset: 0x00DBB097
		public static bool CreateInstance()
		{
			if (InfrastructureConfig._Instance != null)
			{
				return true;
			}
			InfrastructureConfig._Instance = new InfrastructureConfig();
			return true;
		}

		// Token: 0x06039D78 RID: 236920 RVA: 0x00DBCEAD File Offset: 0x00DBB0AD
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039D79 RID: 236921 RVA: 0x00DBCEAF File Offset: 0x00DBB0AF
		public static void ResetStaticDefaultValue()
		{
			InfrastructureConfig._Instance = null;
		}

		// Token: 0x06039D7A RID: 236922 RVA: 0x00DBCEB7 File Offset: 0x00DBB0B7
		static InfrastructureConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InfrastructureConfig.CreateStaticDefaultValue), new Action(InfrastructureConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401E2E0 RID: 123616
		[Nullable(2)]
		private static InfrastructureConfig _Instance;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007A4 RID: 1956
	public class ConfigQuestTrackingConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DEA RID: 11754 RVA: 0x0016038B File Offset: 0x0015E58B
		static ConfigQuestTrackingConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTrackingConfigAll.CreateStaticDefaultValue), new Action(ConfigQuestTrackingConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002DEB RID: 11755 RVA: 0x001603AC File Offset: 0x0015E5AC
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestTrackingConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestTrackingConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questtrackingconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/r.任务追踪配置/*.csv*"),
				new ValueTuple<string, object>("表名", "QuestTrackingConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestTrackingConfig`")
			});
		}

		// Token: 0x06002DEC RID: 11756 RVA: 0x0016042B File Offset: 0x0015E62B
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTrackingConfigAll.LogPair = null;
			ConfigQuestTrackingConfigAll.HandleId = 0;
		}

		// Token: 0x06002DED RID: 11757 RVA: 0x00160439 File Offset: 0x0015E639
		public static void Init()
		{
			ConfigQuestTrackingConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTrackingConfigAll.HandleId, "db_questtrackingconfig.db", "select BinData from `QuestTrackingConfig`");
		}

		// Token: 0x06002DEE RID: 11758 RVA: 0x00160454 File Offset: 0x0015E654
		[NullableContext(2)]
		public static IReadOnlyList<QuestTrackingConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestTrackingConfigAll.HandleId, ConfigQuestTrackingConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<QuestTrackingConfig> readOnlyList = (IReadOnlyList<QuestTrackingConfig>)ConfigCommon.GetConfig("QuestTrackingConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<QuestTrackingConfig> list = new List<QuestTrackingConfig>();
			while (ConfigCommon.Step(ConfigQuestTrackingConfigAll.HandleId, false, ConfigQuestTrackingConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestTrackingConfigAll.HandleId, 0, ConfigQuestTrackingConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigQuestTrackingConfigAll.HandleId, ConfigQuestTrackingConfigAll.LogPair);
					return null;
				}
				QuestTrackingConfig rootAsQuestTrackingConfig = QuestTrackingConfig.GetRootAsQuestTrackingConfig(new ByteBuffer(item2));
				list.Add(rootAsQuestTrackingConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("QuestTrackingConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigQuestTrackingConfigAll.HandleId, ConfigQuestTrackingConfigAll.LogPair);
			return list;
		}

		// Token: 0x04003562 RID: 13666
		private const string DB = "db_questtrackingconfig.db";

		// Token: 0x04003563 RID: 13667
		private const string FILE = "k.可视化编辑/c.Csv/r.任务追踪配置/*.csv*";

		// Token: 0x04003564 RID: 13668
		private const string TABLE = "QuestTrackingConfig";

		// Token: 0x04003565 RID: 13669
		private const string COMMAND = "select BinData from `QuestTrackingConfig`";

		// Token: 0x04003566 RID: 13670
		private const string KEY_PREFIX = "QuestTrackingConfigAll";

		// Token: 0x04003567 RID: 13671
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003568 RID: 13672
		private static int HandleId;
	}
}

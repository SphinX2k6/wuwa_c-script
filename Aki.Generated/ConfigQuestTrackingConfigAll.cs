using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200078A RID: 1930
	public class ConfigQuestTrackingConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D4E RID: 11598 RVA: 0x0015947F File Offset: 0x0015767F
		static ConfigQuestTrackingConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTrackingConfigAll.CreateStaticDefaultValue), new Action(ConfigQuestTrackingConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002D4F RID: 11599 RVA: 0x001594A0 File Offset: 0x001576A0
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

		// Token: 0x06002D50 RID: 11600 RVA: 0x0015951F File Offset: 0x0015771F
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTrackingConfigAll.LogPair = null;
			ConfigQuestTrackingConfigAll.HandleId = 0;
		}

		// Token: 0x06002D51 RID: 11601 RVA: 0x0015952D File Offset: 0x0015772D
		public static void Init()
		{
			ConfigQuestTrackingConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTrackingConfigAll.HandleId, "db_questtrackingconfig.db", "select BinData from `QuestTrackingConfig`");
		}

		// Token: 0x06002D52 RID: 11602 RVA: 0x00159548 File Offset: 0x00157748
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

		// Token: 0x040034AC RID: 13484
		private const string DB = "db_questtrackingconfig.db";

		// Token: 0x040034AD RID: 13485
		private const string FILE = "k.可视化编辑/c.Csv/r.任务追踪配置/*.csv*";

		// Token: 0x040034AE RID: 13486
		private const string TABLE = "QuestTrackingConfig";

		// Token: 0x040034AF RID: 13487
		private const string COMMAND = "select BinData from `QuestTrackingConfig`";

		// Token: 0x040034B0 RID: 13488
		private const string KEY_PREFIX = "QuestTrackingConfigAll";

		// Token: 0x040034B1 RID: 13489
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040034B2 RID: 13490
		private static int HandleId;
	}
}

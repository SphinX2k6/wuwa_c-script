using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007A2 RID: 1954
	public class ConfigQuestTimePointConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DDD RID: 11741 RVA: 0x0015FE48 File Offset: 0x0015E048
		static ConfigQuestTimePointConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTimePointConfigAll.CreateStaticDefaultValue), new Action(ConfigQuestTimePointConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002DDE RID: 11742 RVA: 0x0015FE68 File Offset: 0x0015E068
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestTimePointConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestTimePointConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questmultiline.db"),
				new ValueTuple<string, object>("文件", "r.任务分线.xlsx"),
				new ValueTuple<string, object>("表名", "QuestTimePointConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestTimePointConfig`")
			});
		}

		// Token: 0x06002DDF RID: 11743 RVA: 0x0015FEE7 File Offset: 0x0015E0E7
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTimePointConfigAll.LogPair = null;
			ConfigQuestTimePointConfigAll.HandleId = 0;
		}

		// Token: 0x06002DE0 RID: 11744 RVA: 0x0015FEF5 File Offset: 0x0015E0F5
		public static void Init()
		{
			ConfigQuestTimePointConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTimePointConfigAll.HandleId, "db_questmultiline.db", "select BinData from `QuestTimePointConfig`");
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x0015FF10 File Offset: 0x0015E110
		[NullableContext(2)]
		public static IReadOnlyList<QuestTimePointConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestTimePointConfigAll.HandleId, ConfigQuestTimePointConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<QuestTimePointConfig> readOnlyList = (IReadOnlyList<QuestTimePointConfig>)ConfigCommon.GetConfig("QuestTimePointConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<QuestTimePointConfig> list = new List<QuestTimePointConfig>();
			while (ConfigCommon.Step(ConfigQuestTimePointConfigAll.HandleId, false, ConfigQuestTimePointConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestTimePointConfigAll.HandleId, 0, ConfigQuestTimePointConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigQuestTimePointConfigAll.HandleId, ConfigQuestTimePointConfigAll.LogPair);
					return null;
				}
				QuestTimePointConfig rootAsQuestTimePointConfig = QuestTimePointConfig.GetRootAsQuestTimePointConfig(new ByteBuffer(item2));
				list.Add(rootAsQuestTimePointConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("QuestTimePointConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigQuestTimePointConfigAll.HandleId, ConfigQuestTimePointConfigAll.LogPair);
			return list;
		}

		// Token: 0x04003554 RID: 13652
		private const string DB = "db_questmultiline.db";

		// Token: 0x04003555 RID: 13653
		private const string FILE = "r.任务分线.xlsx";

		// Token: 0x04003556 RID: 13654
		private const string TABLE = "QuestTimePointConfig";

		// Token: 0x04003557 RID: 13655
		private const string COMMAND = "select BinData from `QuestTimePointConfig`";

		// Token: 0x04003558 RID: 13656
		private const string KEY_PREFIX = "QuestTimePointConfigAll";

		// Token: 0x04003559 RID: 13657
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400355A RID: 13658
		private static int HandleId;
	}
}

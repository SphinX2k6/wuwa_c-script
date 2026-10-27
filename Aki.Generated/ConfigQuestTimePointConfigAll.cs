using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000788 RID: 1928
	public class ConfigQuestTimePointConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D41 RID: 11585 RVA: 0x00158F3C File Offset: 0x0015713C
		static ConfigQuestTimePointConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTimePointConfigAll.CreateStaticDefaultValue), new Action(ConfigQuestTimePointConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002D42 RID: 11586 RVA: 0x00158F5C File Offset: 0x0015715C
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

		// Token: 0x06002D43 RID: 11587 RVA: 0x00158FDB File Offset: 0x001571DB
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTimePointConfigAll.LogPair = null;
			ConfigQuestTimePointConfigAll.HandleId = 0;
		}

		// Token: 0x06002D44 RID: 11588 RVA: 0x00158FE9 File Offset: 0x001571E9
		public static void Init()
		{
			ConfigQuestTimePointConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTimePointConfigAll.HandleId, "db_questmultiline.db", "select BinData from `QuestTimePointConfig`");
		}

		// Token: 0x06002D45 RID: 11589 RVA: 0x00159004 File Offset: 0x00157204
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

		// Token: 0x0400349E RID: 13470
		private const string DB = "db_questmultiline.db";

		// Token: 0x0400349F RID: 13471
		private const string FILE = "r.任务分线.xlsx";

		// Token: 0x040034A0 RID: 13472
		private const string TABLE = "QuestTimePointConfig";

		// Token: 0x040034A1 RID: 13473
		private const string COMMAND = "select BinData from `QuestTimePointConfig`";

		// Token: 0x040034A2 RID: 13474
		private const string KEY_PREFIX = "QuestTimePointConfigAll";

		// Token: 0x040034A3 RID: 13475
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040034A4 RID: 13476
		private static int HandleId;
	}
}

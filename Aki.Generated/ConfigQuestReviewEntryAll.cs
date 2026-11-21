using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000799 RID: 1945
	public class ConfigQuestReviewEntryAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DA7 RID: 11687 RVA: 0x0015EA83 File Offset: 0x0015CC83
		static ConfigQuestReviewEntryAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestReviewEntryAll.CreateStaticDefaultValue), new Action(ConfigQuestReviewEntryAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x0015EAA4 File Offset: 0x0015CCA4
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestReviewEntryAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestReviewEntryAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questreview.db"),
				new ValueTuple<string, object>("文件", "j.剧情历程.xlsx"),
				new ValueTuple<string, object>("表名", "QuestReviewEntry"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestReviewEntry`")
			});
		}

		// Token: 0x06002DA9 RID: 11689 RVA: 0x0015EB23 File Offset: 0x0015CD23
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestReviewEntryAll.LogPair = null;
			ConfigQuestReviewEntryAll.HandleId = 0;
		}

		// Token: 0x06002DAA RID: 11690 RVA: 0x0015EB31 File Offset: 0x0015CD31
		public static void Init()
		{
			ConfigQuestReviewEntryAll.HandleId = ConfigCommon.InitDataStatement(ConfigQuestReviewEntryAll.HandleId, "db_questreview.db", "select BinData from `QuestReviewEntry`");
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x0015EB4C File Offset: 0x0015CD4C
		[NullableContext(2)]
		public static IReadOnlyList<QuestReviewEntry> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestReviewEntryAll.HandleId, ConfigQuestReviewEntryAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<QuestReviewEntry> readOnlyList = (IReadOnlyList<QuestReviewEntry>)ConfigCommon.GetConfig("QuestReviewEntryAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<QuestReviewEntry> list = new List<QuestReviewEntry>();
			while (ConfigCommon.Step(ConfigQuestReviewEntryAll.HandleId, false, ConfigQuestReviewEntryAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestReviewEntryAll.HandleId, 0, ConfigQuestReviewEntryAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigQuestReviewEntryAll.HandleId, ConfigQuestReviewEntryAll.LogPair);
					return null;
				}
				QuestReviewEntry rootAsQuestReviewEntry = QuestReviewEntry.GetRootAsQuestReviewEntry(new ByteBuffer(item2));
				list.Add(rootAsQuestReviewEntry);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("QuestReviewEntryAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigQuestReviewEntryAll.HandleId, ConfigQuestReviewEntryAll.LogPair);
			return list;
		}

		// Token: 0x04003515 RID: 13589
		private const string DB = "db_questreview.db";

		// Token: 0x04003516 RID: 13590
		private const string FILE = "j.剧情历程.xlsx";

		// Token: 0x04003517 RID: 13591
		private const string TABLE = "QuestReviewEntry";

		// Token: 0x04003518 RID: 13592
		private const string COMMAND = "select BinData from `QuestReviewEntry`";

		// Token: 0x04003519 RID: 13593
		private const string KEY_PREFIX = "QuestReviewEntryAll";

		// Token: 0x0400351A RID: 13594
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400351B RID: 13595
		private static int HandleId;
	}
}

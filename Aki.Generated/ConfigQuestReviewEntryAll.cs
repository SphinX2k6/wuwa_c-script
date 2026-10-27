using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200077F RID: 1919
	public class ConfigQuestReviewEntryAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D0B RID: 11531 RVA: 0x00157B77 File Offset: 0x00155D77
		static ConfigQuestReviewEntryAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestReviewEntryAll.CreateStaticDefaultValue), new Action(ConfigQuestReviewEntryAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002D0C RID: 11532 RVA: 0x00157B98 File Offset: 0x00155D98
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

		// Token: 0x06002D0D RID: 11533 RVA: 0x00157C17 File Offset: 0x00155E17
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestReviewEntryAll.LogPair = null;
			ConfigQuestReviewEntryAll.HandleId = 0;
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x00157C25 File Offset: 0x00155E25
		public static void Init()
		{
			ConfigQuestReviewEntryAll.HandleId = ConfigCommon.InitDataStatement(ConfigQuestReviewEntryAll.HandleId, "db_questreview.db", "select BinData from `QuestReviewEntry`");
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x00157C40 File Offset: 0x00155E40
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

		// Token: 0x0400345F RID: 13407
		private const string DB = "db_questreview.db";

		// Token: 0x04003460 RID: 13408
		private const string FILE = "j.剧情历程.xlsx";

		// Token: 0x04003461 RID: 13409
		private const string TABLE = "QuestReviewEntry";

		// Token: 0x04003462 RID: 13410
		private const string COMMAND = "select BinData from `QuestReviewEntry`";

		// Token: 0x04003463 RID: 13411
		private const string KEY_PREFIX = "QuestReviewEntryAll";

		// Token: 0x04003464 RID: 13412
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003465 RID: 13413
		private static int HandleId;
	}
}

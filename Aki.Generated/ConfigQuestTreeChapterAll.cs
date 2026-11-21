using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007A6 RID: 1958
	public class ConfigQuestTreeChapterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DF6 RID: 11766 RVA: 0x00160768 File Offset: 0x0015E968
		static ConfigQuestTreeChapterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTreeChapterAll.CreateStaticDefaultValue), new Action(ConfigQuestTreeChapterAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x00160788 File Offset: 0x0015E988
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestTreeChapterAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestTreeChapterAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questtree.db"),
				new ValueTuple<string, object>("文件", "r.任务树.xlsx"),
				new ValueTuple<string, object>("表名", "QuestTreeChapter"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestTreeChapter`")
			});
		}

		// Token: 0x06002DF8 RID: 11768 RVA: 0x00160807 File Offset: 0x0015EA07
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTreeChapterAll.LogPair = null;
			ConfigQuestTreeChapterAll.HandleId = 0;
		}

		// Token: 0x06002DF9 RID: 11769 RVA: 0x00160815 File Offset: 0x0015EA15
		public static void Init()
		{
			ConfigQuestTreeChapterAll.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTreeChapterAll.HandleId, "db_questtree.db", "select BinData from `QuestTreeChapter`");
		}

		// Token: 0x06002DFA RID: 11770 RVA: 0x00160830 File Offset: 0x0015EA30
		[NullableContext(2)]
		public static IReadOnlyList<QuestTreeChapter> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestTreeChapterAll.HandleId, ConfigQuestTreeChapterAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<QuestTreeChapter> readOnlyList = (IReadOnlyList<QuestTreeChapter>)ConfigCommon.GetConfig("QuestTreeChapterAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<QuestTreeChapter> list = new List<QuestTreeChapter>();
			while (ConfigCommon.Step(ConfigQuestTreeChapterAll.HandleId, false, ConfigQuestTreeChapterAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestTreeChapterAll.HandleId, 0, ConfigQuestTreeChapterAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigQuestTreeChapterAll.HandleId, ConfigQuestTreeChapterAll.LogPair);
					return null;
				}
				QuestTreeChapter rootAsQuestTreeChapter = QuestTreeChapter.GetRootAsQuestTreeChapter(new ByteBuffer(item2));
				list.Add(rootAsQuestTreeChapter);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("QuestTreeChapterAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigQuestTreeChapterAll.HandleId, ConfigQuestTreeChapterAll.LogPair);
			return list;
		}

		// Token: 0x04003570 RID: 13680
		private const string DB = "db_questtree.db";

		// Token: 0x04003571 RID: 13681
		private const string FILE = "r.任务树.xlsx";

		// Token: 0x04003572 RID: 13682
		private const string TABLE = "QuestTreeChapter";

		// Token: 0x04003573 RID: 13683
		private const string COMMAND = "select BinData from `QuestTreeChapter`";

		// Token: 0x04003574 RID: 13684
		private const string KEY_PREFIX = "QuestTreeChapterAll";

		// Token: 0x04003575 RID: 13685
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003576 RID: 13686
		private static int HandleId;
	}
}

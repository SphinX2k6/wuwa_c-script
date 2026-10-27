using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200078C RID: 1932
	public class ConfigQuestTreeChapterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D5A RID: 11610 RVA: 0x0015985C File Offset: 0x00157A5C
		static ConfigQuestTreeChapterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTreeChapterAll.CreateStaticDefaultValue), new Action(ConfigQuestTreeChapterAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x0015987C File Offset: 0x00157A7C
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

		// Token: 0x06002D5C RID: 11612 RVA: 0x001598FB File Offset: 0x00157AFB
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTreeChapterAll.LogPair = null;
			ConfigQuestTreeChapterAll.HandleId = 0;
		}

		// Token: 0x06002D5D RID: 11613 RVA: 0x00159909 File Offset: 0x00157B09
		public static void Init()
		{
			ConfigQuestTreeChapterAll.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTreeChapterAll.HandleId, "db_questtree.db", "select BinData from `QuestTreeChapter`");
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x00159924 File Offset: 0x00157B24
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

		// Token: 0x040034BA RID: 13498
		private const string DB = "db_questtree.db";

		// Token: 0x040034BB RID: 13499
		private const string FILE = "r.任务树.xlsx";

		// Token: 0x040034BC RID: 13500
		private const string TABLE = "QuestTreeChapter";

		// Token: 0x040034BD RID: 13501
		private const string COMMAND = "select BinData from `QuestTreeChapter`";

		// Token: 0x040034BE RID: 13502
		private const string KEY_PREFIX = "QuestTreeChapterAll";

		// Token: 0x040034BF RID: 13503
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040034C0 RID: 13504
		private static int HandleId;
	}
}

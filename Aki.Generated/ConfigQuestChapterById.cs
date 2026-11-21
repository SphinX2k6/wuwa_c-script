using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200078E RID: 1934
	public class ConfigQuestChapterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D65 RID: 11621 RVA: 0x0015D48C File Offset: 0x0015B68C
		static ConfigQuestChapterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestChapterById.CreateStaticDefaultValue), new Action(ConfigQuestChapterById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D66 RID: 11622 RVA: 0x0015D4AC File Offset: 0x0015B6AC
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestChapterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestChapterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_quest_chapter.db"),
				new ValueTuple<string, object>("文件", "r.任务章节.xlsx"),
				new ValueTuple<string, object>("表名", "QuestChapter"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestChapter` where Id=?")
			});
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x0015D52B File Offset: 0x0015B72B
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestChapterById.LogPair = null;
			ConfigQuestChapterById.HandleId = 0;
		}

		// Token: 0x06002D68 RID: 11624 RVA: 0x0015D539 File Offset: 0x0015B739
		public static void Init()
		{
			ConfigQuestChapterById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestChapterById.HandleId, "db_quest_chapter.db", "select BinData from `QuestChapter` where Id=?");
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x0015D554 File Offset: 0x0015B754
		public static QuestChapter? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestChapterById.HandleId, ConfigQuestChapterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestChapterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QuestChapter?(QuestChapter.GetRootAsQuestChapter(configBuffer));
				}
			}
			ConfigQuestChapterById.LogPair.Clear();
			ConfigQuestChapterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigQuestChapterById.HandleId, 1, p0Id, ConfigQuestChapterById.LogPair) || ConfigCommon.Step(ConfigQuestChapterById.HandleId, true, ConfigQuestChapterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestChapterById.HandleId, ConfigQuestChapterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestChapterById.HandleId, 0, ConfigQuestChapterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestChapterById.HandleId, ConfigQuestChapterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuestChapter rootAsQuestChapter = QuestChapter.GetRootAsQuestChapter(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestChapterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestChapterById.HandleId, ConfigQuestChapterById.LogPair);
			return new QuestChapter?(rootAsQuestChapter);
		}

		// Token: 0x040034C8 RID: 13512
		private const string DB = "db_quest_chapter.db";

		// Token: 0x040034C9 RID: 13513
		private const string FILE = "r.任务章节.xlsx";

		// Token: 0x040034CA RID: 13514
		private const string TABLE = "QuestChapter";

		// Token: 0x040034CB RID: 13515
		private const string COMMAND = "select BinData from `QuestChapter` where Id=?";

		// Token: 0x040034CC RID: 13516
		private const string KEY_PREFIX = "QuestChapterById";

		// Token: 0x040034CD RID: 13517
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040034CE RID: 13518
		private static int HandleId;
	}
}

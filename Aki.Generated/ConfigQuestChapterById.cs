using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000774 RID: 1908
	public class ConfigQuestChapterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CC9 RID: 11465 RVA: 0x00156580 File Offset: 0x00154780
		static ConfigQuestChapterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestChapterById.CreateStaticDefaultValue), new Action(ConfigQuestChapterById.ResetStaticDefaultValue));
		}

		// Token: 0x06002CCA RID: 11466 RVA: 0x001565A0 File Offset: 0x001547A0
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

		// Token: 0x06002CCB RID: 11467 RVA: 0x0015661F File Offset: 0x0015481F
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestChapterById.LogPair = null;
			ConfigQuestChapterById.HandleId = 0;
		}

		// Token: 0x06002CCC RID: 11468 RVA: 0x0015662D File Offset: 0x0015482D
		public static void Init()
		{
			ConfigQuestChapterById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestChapterById.HandleId, "db_quest_chapter.db", "select BinData from `QuestChapter` where Id=?");
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x00156648 File Offset: 0x00154848
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

		// Token: 0x04003412 RID: 13330
		private const string DB = "db_quest_chapter.db";

		// Token: 0x04003413 RID: 13331
		private const string FILE = "r.任务章节.xlsx";

		// Token: 0x04003414 RID: 13332
		private const string TABLE = "QuestChapter";

		// Token: 0x04003415 RID: 13333
		private const string COMMAND = "select BinData from `QuestChapter` where Id=?";

		// Token: 0x04003416 RID: 13334
		private const string KEY_PREFIX = "QuestChapterById";

		// Token: 0x04003417 RID: 13335
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003418 RID: 13336
		private static int HandleId;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200078D RID: 1933
	public class ConfigQuestTreeChapterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D60 RID: 11616 RVA: 0x001599EF File Offset: 0x00157BEF
		static ConfigQuestTreeChapterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTreeChapterById.CreateStaticDefaultValue), new Action(ConfigQuestTreeChapterById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D61 RID: 11617 RVA: 0x00159A10 File Offset: 0x00157C10
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestTreeChapterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestTreeChapterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questtree.db"),
				new ValueTuple<string, object>("文件", "r.任务树.xlsx"),
				new ValueTuple<string, object>("表名", "QuestTreeChapter"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestTreeChapter` where Id=?")
			});
		}

		// Token: 0x06002D62 RID: 11618 RVA: 0x00159A8F File Offset: 0x00157C8F
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTreeChapterById.LogPair = null;
			ConfigQuestTreeChapterById.HandleId = 0;
		}

		// Token: 0x06002D63 RID: 11619 RVA: 0x00159A9D File Offset: 0x00157C9D
		public static void Init()
		{
			ConfigQuestTreeChapterById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTreeChapterById.HandleId, "db_questtree.db", "select BinData from `QuestTreeChapter` where Id=?");
		}

		// Token: 0x06002D64 RID: 11620 RVA: 0x00159AB8 File Offset: 0x00157CB8
		public static QuestTreeChapter? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestTreeChapterById.HandleId, ConfigQuestTreeChapterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestTreeChapterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QuestTreeChapter?(QuestTreeChapter.GetRootAsQuestTreeChapter(configBuffer));
				}
			}
			ConfigQuestTreeChapterById.LogPair.Clear();
			ConfigQuestTreeChapterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigQuestTreeChapterById.HandleId, 1, p0Id, ConfigQuestTreeChapterById.LogPair) || ConfigCommon.Step(ConfigQuestTreeChapterById.HandleId, true, ConfigQuestTreeChapterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestTreeChapterById.HandleId, ConfigQuestTreeChapterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestTreeChapterById.HandleId, 0, ConfigQuestTreeChapterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestTreeChapterById.HandleId, ConfigQuestTreeChapterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuestTreeChapter rootAsQuestTreeChapter = QuestTreeChapter.GetRootAsQuestTreeChapter(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestTreeChapterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestTreeChapterById.HandleId, ConfigQuestTreeChapterById.LogPair);
			return new QuestTreeChapter?(rootAsQuestTreeChapter);
		}

		// Token: 0x040034C1 RID: 13505
		private const string DB = "db_questtree.db";

		// Token: 0x040034C2 RID: 13506
		private const string FILE = "r.任务树.xlsx";

		// Token: 0x040034C3 RID: 13507
		private const string TABLE = "QuestTreeChapter";

		// Token: 0x040034C4 RID: 13508
		private const string COMMAND = "select BinData from `QuestTreeChapter` where Id=?";

		// Token: 0x040034C5 RID: 13509
		private const string KEY_PREFIX = "QuestTreeChapterById";

		// Token: 0x040034C6 RID: 13510
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040034C7 RID: 13511
		private static int HandleId;
	}
}

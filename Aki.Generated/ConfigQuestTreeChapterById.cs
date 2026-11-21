using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007A7 RID: 1959
	public class ConfigQuestTreeChapterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DFC RID: 11772 RVA: 0x001608FB File Offset: 0x0015EAFB
		static ConfigQuestTreeChapterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTreeChapterById.CreateStaticDefaultValue), new Action(ConfigQuestTreeChapterById.ResetStaticDefaultValue));
		}

		// Token: 0x06002DFD RID: 11773 RVA: 0x0016091C File Offset: 0x0015EB1C
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

		// Token: 0x06002DFE RID: 11774 RVA: 0x0016099B File Offset: 0x0015EB9B
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTreeChapterById.LogPair = null;
			ConfigQuestTreeChapterById.HandleId = 0;
		}

		// Token: 0x06002DFF RID: 11775 RVA: 0x001609A9 File Offset: 0x0015EBA9
		public static void Init()
		{
			ConfigQuestTreeChapterById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTreeChapterById.HandleId, "db_questtree.db", "select BinData from `QuestTreeChapter` where Id=?");
		}

		// Token: 0x06002E00 RID: 11776 RVA: 0x001609C4 File Offset: 0x0015EBC4
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

		// Token: 0x04003577 RID: 13687
		private const string DB = "db_questtree.db";

		// Token: 0x04003578 RID: 13688
		private const string FILE = "r.任务树.xlsx";

		// Token: 0x04003579 RID: 13689
		private const string TABLE = "QuestTreeChapter";

		// Token: 0x0400357A RID: 13690
		private const string COMMAND = "select BinData from `QuestTreeChapter` where Id=?";

		// Token: 0x0400357B RID: 13691
		private const string KEY_PREFIX = "QuestTreeChapterById";

		// Token: 0x0400357C RID: 13692
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400357D RID: 13693
		private static int HandleId;
	}
}

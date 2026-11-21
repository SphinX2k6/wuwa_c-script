using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200079A RID: 1946
	public class ConfigQuestReviewEntryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DAD RID: 11693 RVA: 0x0015EC17 File Offset: 0x0015CE17
		static ConfigQuestReviewEntryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestReviewEntryById.CreateStaticDefaultValue), new Action(ConfigQuestReviewEntryById.ResetStaticDefaultValue));
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x0015EC38 File Offset: 0x0015CE38
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestReviewEntryById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestReviewEntryById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questreview.db"),
				new ValueTuple<string, object>("文件", "j.剧情历程.xlsx"),
				new ValueTuple<string, object>("表名", "QuestReviewEntry"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestReviewEntry` where Id=?")
			});
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x0015ECB7 File Offset: 0x0015CEB7
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestReviewEntryById.LogPair = null;
			ConfigQuestReviewEntryById.HandleId = 0;
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x0015ECC5 File Offset: 0x0015CEC5
		public static void Init()
		{
			ConfigQuestReviewEntryById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestReviewEntryById.HandleId, "db_questreview.db", "select BinData from `QuestReviewEntry` where Id=?");
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x0015ECE0 File Offset: 0x0015CEE0
		public static QuestReviewEntry? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestReviewEntryById.HandleId, ConfigQuestReviewEntryById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestReviewEntryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QuestReviewEntry?(QuestReviewEntry.GetRootAsQuestReviewEntry(configBuffer));
				}
			}
			ConfigQuestReviewEntryById.LogPair.Clear();
			ConfigQuestReviewEntryById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigQuestReviewEntryById.HandleId, 1, p0Id, ConfigQuestReviewEntryById.LogPair) || ConfigCommon.Step(ConfigQuestReviewEntryById.HandleId, true, ConfigQuestReviewEntryById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestReviewEntryById.HandleId, ConfigQuestReviewEntryById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestReviewEntryById.HandleId, 0, ConfigQuestReviewEntryById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestReviewEntryById.HandleId, ConfigQuestReviewEntryById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuestReviewEntry rootAsQuestReviewEntry = QuestReviewEntry.GetRootAsQuestReviewEntry(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestReviewEntryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestReviewEntryById.HandleId, ConfigQuestReviewEntryById.LogPair);
			return new QuestReviewEntry?(rootAsQuestReviewEntry);
		}

		// Token: 0x0400351C RID: 13596
		private const string DB = "db_questreview.db";

		// Token: 0x0400351D RID: 13597
		private const string FILE = "j.剧情历程.xlsx";

		// Token: 0x0400351E RID: 13598
		private const string TABLE = "QuestReviewEntry";

		// Token: 0x0400351F RID: 13599
		private const string COMMAND = "select BinData from `QuestReviewEntry` where Id=?";

		// Token: 0x04003520 RID: 13600
		private const string KEY_PREFIX = "QuestReviewEntryById";

		// Token: 0x04003521 RID: 13601
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003522 RID: 13602
		private static int HandleId;
	}
}

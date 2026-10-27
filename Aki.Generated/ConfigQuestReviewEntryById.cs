using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000780 RID: 1920
	public class ConfigQuestReviewEntryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D11 RID: 11537 RVA: 0x00157D0B File Offset: 0x00155F0B
		static ConfigQuestReviewEntryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestReviewEntryById.CreateStaticDefaultValue), new Action(ConfigQuestReviewEntryById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x00157D2C File Offset: 0x00155F2C
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

		// Token: 0x06002D13 RID: 11539 RVA: 0x00157DAB File Offset: 0x00155FAB
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestReviewEntryById.LogPair = null;
			ConfigQuestReviewEntryById.HandleId = 0;
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x00157DB9 File Offset: 0x00155FB9
		public static void Init()
		{
			ConfigQuestReviewEntryById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestReviewEntryById.HandleId, "db_questreview.db", "select BinData from `QuestReviewEntry` where Id=?");
		}

		// Token: 0x06002D15 RID: 11541 RVA: 0x00157DD4 File Offset: 0x00155FD4
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

		// Token: 0x04003466 RID: 13414
		private const string DB = "db_questreview.db";

		// Token: 0x04003467 RID: 13415
		private const string FILE = "j.剧情历程.xlsx";

		// Token: 0x04003468 RID: 13416
		private const string TABLE = "QuestReviewEntry";

		// Token: 0x04003469 RID: 13417
		private const string COMMAND = "select BinData from `QuestReviewEntry` where Id=?";

		// Token: 0x0400346A RID: 13418
		private const string KEY_PREFIX = "QuestReviewEntryById";

		// Token: 0x0400346B RID: 13419
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400346C RID: 13420
		private static int HandleId;
	}
}

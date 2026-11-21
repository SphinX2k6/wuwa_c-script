using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200079B RID: 1947
	public class ConfigQuestReviewLineById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DB3 RID: 11699 RVA: 0x0015EE60 File Offset: 0x0015D060
		static ConfigQuestReviewLineById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestReviewLineById.CreateStaticDefaultValue), new Action(ConfigQuestReviewLineById.ResetStaticDefaultValue));
		}

		// Token: 0x06002DB4 RID: 11700 RVA: 0x0015EE80 File Offset: 0x0015D080
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestReviewLineById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestReviewLineById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questreview.db"),
				new ValueTuple<string, object>("文件", "j.剧情历程.xlsx"),
				new ValueTuple<string, object>("表名", "QuestReviewLine"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestReviewLine` where Id=?")
			});
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x0015EEFF File Offset: 0x0015D0FF
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestReviewLineById.LogPair = null;
			ConfigQuestReviewLineById.HandleId = 0;
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x0015EF0D File Offset: 0x0015D10D
		public static void Init()
		{
			ConfigQuestReviewLineById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestReviewLineById.HandleId, "db_questreview.db", "select BinData from `QuestReviewLine` where Id=?");
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x0015EF28 File Offset: 0x0015D128
		public static QuestReviewLine? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestReviewLineById.HandleId, ConfigQuestReviewLineById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestReviewLineById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QuestReviewLine?(QuestReviewLine.GetRootAsQuestReviewLine(configBuffer));
				}
			}
			ConfigQuestReviewLineById.LogPair.Clear();
			ConfigQuestReviewLineById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigQuestReviewLineById.HandleId, 1, p0Id, ConfigQuestReviewLineById.LogPair) || ConfigCommon.Step(ConfigQuestReviewLineById.HandleId, true, ConfigQuestReviewLineById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestReviewLineById.HandleId, ConfigQuestReviewLineById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestReviewLineById.HandleId, 0, ConfigQuestReviewLineById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestReviewLineById.HandleId, ConfigQuestReviewLineById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuestReviewLine rootAsQuestReviewLine = QuestReviewLine.GetRootAsQuestReviewLine(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestReviewLineById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestReviewLineById.HandleId, ConfigQuestReviewLineById.LogPair);
			return new QuestReviewLine?(rootAsQuestReviewLine);
		}

		// Token: 0x04003523 RID: 13603
		private const string DB = "db_questreview.db";

		// Token: 0x04003524 RID: 13604
		private const string FILE = "j.剧情历程.xlsx";

		// Token: 0x04003525 RID: 13605
		private const string TABLE = "QuestReviewLine";

		// Token: 0x04003526 RID: 13606
		private const string COMMAND = "select BinData from `QuestReviewLine` where Id=?";

		// Token: 0x04003527 RID: 13607
		private const string KEY_PREFIX = "QuestReviewLineById";

		// Token: 0x04003528 RID: 13608
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003529 RID: 13609
		private static int HandleId;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200079C RID: 1948
	public class ConfigQuestReviewNodeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DB9 RID: 11705 RVA: 0x0015F0A8 File Offset: 0x0015D2A8
		static ConfigQuestReviewNodeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestReviewNodeById.CreateStaticDefaultValue), new Action(ConfigQuestReviewNodeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x0015F0C8 File Offset: 0x0015D2C8
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestReviewNodeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestReviewNodeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questreview.db"),
				new ValueTuple<string, object>("文件", "j.剧情历程.xlsx"),
				new ValueTuple<string, object>("表名", "QuestReviewNode"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestReviewNode` where Id=?")
			});
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x0015F147 File Offset: 0x0015D347
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestReviewNodeById.LogPair = null;
			ConfigQuestReviewNodeById.HandleId = 0;
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x0015F155 File Offset: 0x0015D355
		public static void Init()
		{
			ConfigQuestReviewNodeById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestReviewNodeById.HandleId, "db_questreview.db", "select BinData from `QuestReviewNode` where Id=?");
		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x0015F170 File Offset: 0x0015D370
		public static QuestReviewNode? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestReviewNodeById.HandleId, ConfigQuestReviewNodeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestReviewNodeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QuestReviewNode?(QuestReviewNode.GetRootAsQuestReviewNode(configBuffer));
				}
			}
			ConfigQuestReviewNodeById.LogPair.Clear();
			ConfigQuestReviewNodeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigQuestReviewNodeById.HandleId, 1, p0Id, ConfigQuestReviewNodeById.LogPair) || ConfigCommon.Step(ConfigQuestReviewNodeById.HandleId, true, ConfigQuestReviewNodeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestReviewNodeById.HandleId, ConfigQuestReviewNodeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestReviewNodeById.HandleId, 0, ConfigQuestReviewNodeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestReviewNodeById.HandleId, ConfigQuestReviewNodeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuestReviewNode rootAsQuestReviewNode = QuestReviewNode.GetRootAsQuestReviewNode(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestReviewNodeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestReviewNodeById.HandleId, ConfigQuestReviewNodeById.LogPair);
			return new QuestReviewNode?(rootAsQuestReviewNode);
		}

		// Token: 0x0400352A RID: 13610
		private const string DB = "db_questreview.db";

		// Token: 0x0400352B RID: 13611
		private const string FILE = "j.剧情历程.xlsx";

		// Token: 0x0400352C RID: 13612
		private const string TABLE = "QuestReviewNode";

		// Token: 0x0400352D RID: 13613
		private const string COMMAND = "select BinData from `QuestReviewNode` where Id=?";

		// Token: 0x0400352E RID: 13614
		private const string KEY_PREFIX = "QuestReviewNodeById";

		// Token: 0x0400352F RID: 13615
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003530 RID: 13616
		private static int HandleId;
	}
}

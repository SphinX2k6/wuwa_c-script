using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200079F RID: 1951
	public class ConfigQuestReviewTreeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DCB RID: 11723 RVA: 0x0015F770 File Offset: 0x0015D970
		static ConfigQuestReviewTreeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestReviewTreeById.CreateStaticDefaultValue), new Action(ConfigQuestReviewTreeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002DCC RID: 11724 RVA: 0x0015F790 File Offset: 0x0015D990
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestReviewTreeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestReviewTreeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questreview.db"),
				new ValueTuple<string, object>("文件", "j.剧情历程.xlsx"),
				new ValueTuple<string, object>("表名", "QuestReviewTree"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestReviewTree` where Id=?")
			});
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x0015F80F File Offset: 0x0015DA0F
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestReviewTreeById.LogPair = null;
			ConfigQuestReviewTreeById.HandleId = 0;
		}

		// Token: 0x06002DCE RID: 11726 RVA: 0x0015F81D File Offset: 0x0015DA1D
		public static void Init()
		{
			ConfigQuestReviewTreeById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestReviewTreeById.HandleId, "db_questreview.db", "select BinData from `QuestReviewTree` where Id=?");
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x0015F838 File Offset: 0x0015DA38
		public static QuestReviewTree? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestReviewTreeById.HandleId, ConfigQuestReviewTreeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestReviewTreeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QuestReviewTree?(QuestReviewTree.GetRootAsQuestReviewTree(configBuffer));
				}
			}
			ConfigQuestReviewTreeById.LogPair.Clear();
			ConfigQuestReviewTreeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigQuestReviewTreeById.HandleId, 1, p0Id, ConfigQuestReviewTreeById.LogPair) || ConfigCommon.Step(ConfigQuestReviewTreeById.HandleId, true, ConfigQuestReviewTreeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestReviewTreeById.HandleId, ConfigQuestReviewTreeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestReviewTreeById.HandleId, 0, ConfigQuestReviewTreeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestReviewTreeById.HandleId, ConfigQuestReviewTreeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuestReviewTree rootAsQuestReviewTree = QuestReviewTree.GetRootAsQuestReviewTree(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestReviewTreeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestReviewTreeById.HandleId, ConfigQuestReviewTreeById.LogPair);
			return new QuestReviewTree?(rootAsQuestReviewTree);
		}

		// Token: 0x0400353F RID: 13631
		private const string DB = "db_questreview.db";

		// Token: 0x04003540 RID: 13632
		private const string FILE = "j.剧情历程.xlsx";

		// Token: 0x04003541 RID: 13633
		private const string TABLE = "QuestReviewTree";

		// Token: 0x04003542 RID: 13634
		private const string COMMAND = "select BinData from `QuestReviewTree` where Id=?";

		// Token: 0x04003543 RID: 13635
		private const string KEY_PREFIX = "QuestReviewTreeById";

		// Token: 0x04003544 RID: 13636
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003545 RID: 13637
		private static int HandleId;
	}
}

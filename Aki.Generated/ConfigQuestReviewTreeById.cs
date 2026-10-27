using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000785 RID: 1925
	public class ConfigQuestReviewTreeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D2F RID: 11567 RVA: 0x00158864 File Offset: 0x00156A64
		static ConfigQuestReviewTreeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestReviewTreeById.CreateStaticDefaultValue), new Action(ConfigQuestReviewTreeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x00158884 File Offset: 0x00156A84
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

		// Token: 0x06002D31 RID: 11569 RVA: 0x00158903 File Offset: 0x00156B03
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestReviewTreeById.LogPair = null;
			ConfigQuestReviewTreeById.HandleId = 0;
		}

		// Token: 0x06002D32 RID: 11570 RVA: 0x00158911 File Offset: 0x00156B11
		public static void Init()
		{
			ConfigQuestReviewTreeById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestReviewTreeById.HandleId, "db_questreview.db", "select BinData from `QuestReviewTree` where Id=?");
		}

		// Token: 0x06002D33 RID: 11571 RVA: 0x0015892C File Offset: 0x00156B2C
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

		// Token: 0x04003489 RID: 13449
		private const string DB = "db_questreview.db";

		// Token: 0x0400348A RID: 13450
		private const string FILE = "j.剧情历程.xlsx";

		// Token: 0x0400348B RID: 13451
		private const string TABLE = "QuestReviewTree";

		// Token: 0x0400348C RID: 13452
		private const string COMMAND = "select BinData from `QuestReviewTree` where Id=?";

		// Token: 0x0400348D RID: 13453
		private const string KEY_PREFIX = "QuestReviewTreeById";

		// Token: 0x0400348E RID: 13454
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400348F RID: 13455
		private static int HandleId;
	}
}

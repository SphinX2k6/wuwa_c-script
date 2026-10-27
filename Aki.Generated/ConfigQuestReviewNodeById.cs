using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000782 RID: 1922
	public class ConfigQuestReviewNodeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D1D RID: 11549 RVA: 0x0015819C File Offset: 0x0015639C
		static ConfigQuestReviewNodeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestReviewNodeById.CreateStaticDefaultValue), new Action(ConfigQuestReviewNodeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x001581BC File Offset: 0x001563BC
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

		// Token: 0x06002D1F RID: 11551 RVA: 0x0015823B File Offset: 0x0015643B
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestReviewNodeById.LogPair = null;
			ConfigQuestReviewNodeById.HandleId = 0;
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x00158249 File Offset: 0x00156449
		public static void Init()
		{
			ConfigQuestReviewNodeById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestReviewNodeById.HandleId, "db_questreview.db", "select BinData from `QuestReviewNode` where Id=?");
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x00158264 File Offset: 0x00156464
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

		// Token: 0x04003474 RID: 13428
		private const string DB = "db_questreview.db";

		// Token: 0x04003475 RID: 13429
		private const string FILE = "j.剧情历程.xlsx";

		// Token: 0x04003476 RID: 13430
		private const string TABLE = "QuestReviewNode";

		// Token: 0x04003477 RID: 13431
		private const string COMMAND = "select BinData from `QuestReviewNode` where Id=?";

		// Token: 0x04003478 RID: 13432
		private const string KEY_PREFIX = "QuestReviewNodeById";

		// Token: 0x04003479 RID: 13433
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400347A RID: 13434
		private static int HandleId;
	}
}

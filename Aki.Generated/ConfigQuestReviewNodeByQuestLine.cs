using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000783 RID: 1923
	public class ConfigQuestReviewNodeByQuestLine : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D23 RID: 11555 RVA: 0x001583E4 File Offset: 0x001565E4
		static ConfigQuestReviewNodeByQuestLine()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestReviewNodeByQuestLine.CreateStaticDefaultValue), new Action(ConfigQuestReviewNodeByQuestLine.ResetStaticDefaultValue));
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x00158404 File Offset: 0x00156604
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestReviewNodeByQuestLine.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestReviewNodeByQuestLine.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questreview.db"),
				new ValueTuple<string, object>("文件", "j.剧情历程.xlsx"),
				new ValueTuple<string, object>("表名", "QuestReviewNode"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestReviewNode` where QuestLine=?")
			});
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x00158483 File Offset: 0x00156683
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestReviewNodeByQuestLine.LogPair = null;
			ConfigQuestReviewNodeByQuestLine.HandleId = 0;
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x00158491 File Offset: 0x00156691
		public static void Init()
		{
			ConfigQuestReviewNodeByQuestLine.HandleId = ConfigCommon.InitDataStatement(ConfigQuestReviewNodeByQuestLine.HandleId, "db_questreview.db", "select BinData from `QuestReviewNode` where QuestLine=?");
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x001584AC File Offset: 0x001566AC
		[NullableContext(2)]
		public static IReadOnlyList<QuestReviewNode> GetConfigList(int p0QuestLine, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestReviewNodeByQuestLine.HandleId, ConfigQuestReviewNodeByQuestLine.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestReviewNodeByQuestLine");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QuestLine);
				IReadOnlyList<QuestReviewNode> readOnlyList = (IReadOnlyList<QuestReviewNode>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigQuestReviewNodeByQuestLine.LogPair.Clear();
			ConfigQuestReviewNodeByQuestLine.LogPair.Add(new ValueTuple<string, object>("QuestLine", p0QuestLine));
			if (!ConfigCommon.BindInt(ConfigQuestReviewNodeByQuestLine.HandleId, 1, p0QuestLine, ConfigQuestReviewNodeByQuestLine.LogPair))
			{
				ConfigCommon.Reset(ConfigQuestReviewNodeByQuestLine.HandleId, ConfigQuestReviewNodeByQuestLine.LogPair);
				return null;
			}
			List<QuestReviewNode> list = new List<QuestReviewNode>();
			while (ConfigCommon.Step(ConfigQuestReviewNodeByQuestLine.HandleId, false, ConfigQuestReviewNodeByQuestLine.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestReviewNodeByQuestLine.HandleId, 0, ConfigQuestReviewNodeByQuestLine.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigQuestReviewNodeByQuestLine.HandleId, ConfigQuestReviewNodeByQuestLine.LogPair);
					return null;
				}
				QuestReviewNode rootAsQuestReviewNode = QuestReviewNode.GetRootAsQuestReviewNode(new ByteBuffer(item2));
				list.Add(rootAsQuestReviewNode);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestReviewNodeByQuestLine");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QuestLine);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigQuestReviewNodeByQuestLine.HandleId, ConfigQuestReviewNodeByQuestLine.LogPair);
			return list;
		}

		// Token: 0x0400347B RID: 13435
		private const string DB = "db_questreview.db";

		// Token: 0x0400347C RID: 13436
		private const string FILE = "j.剧情历程.xlsx";

		// Token: 0x0400347D RID: 13437
		private const string TABLE = "QuestReviewNode";

		// Token: 0x0400347E RID: 13438
		private const string COMMAND = "select BinData from `QuestReviewNode` where QuestLine=?";

		// Token: 0x0400347F RID: 13439
		private const string KEY_PREFIX = "QuestReviewNodeByQuestLine";

		// Token: 0x04003480 RID: 13440
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003481 RID: 13441
		private static int HandleId;
	}
}

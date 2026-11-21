using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200079D RID: 1949
	public class ConfigQuestReviewNodeByQuestLine : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DBF RID: 11711 RVA: 0x0015F2F0 File Offset: 0x0015D4F0
		static ConfigQuestReviewNodeByQuestLine()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestReviewNodeByQuestLine.CreateStaticDefaultValue), new Action(ConfigQuestReviewNodeByQuestLine.ResetStaticDefaultValue));
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x0015F310 File Offset: 0x0015D510
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

		// Token: 0x06002DC1 RID: 11713 RVA: 0x0015F38F File Offset: 0x0015D58F
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestReviewNodeByQuestLine.LogPair = null;
			ConfigQuestReviewNodeByQuestLine.HandleId = 0;
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x0015F39D File Offset: 0x0015D59D
		public static void Init()
		{
			ConfigQuestReviewNodeByQuestLine.HandleId = ConfigCommon.InitDataStatement(ConfigQuestReviewNodeByQuestLine.HandleId, "db_questreview.db", "select BinData from `QuestReviewNode` where QuestLine=?");
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x0015F3B8 File Offset: 0x0015D5B8
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

		// Token: 0x04003531 RID: 13617
		private const string DB = "db_questreview.db";

		// Token: 0x04003532 RID: 13618
		private const string FILE = "j.剧情历程.xlsx";

		// Token: 0x04003533 RID: 13619
		private const string TABLE = "QuestReviewNode";

		// Token: 0x04003534 RID: 13620
		private const string COMMAND = "select BinData from `QuestReviewNode` where QuestLine=?";

		// Token: 0x04003535 RID: 13621
		private const string KEY_PREFIX = "QuestReviewNodeByQuestLine";

		// Token: 0x04003536 RID: 13622
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003537 RID: 13623
		private static int HandleId;
	}
}

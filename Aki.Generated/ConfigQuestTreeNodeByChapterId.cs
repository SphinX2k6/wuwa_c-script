using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000790 RID: 1936
	public class ConfigQuestTreeNodeByChapterId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D72 RID: 11634 RVA: 0x0015A064 File Offset: 0x00158264
		static ConfigQuestTreeNodeByChapterId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTreeNodeByChapterId.CreateStaticDefaultValue), new Action(ConfigQuestTreeNodeByChapterId.ResetStaticDefaultValue));
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x0015A084 File Offset: 0x00158284
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestTreeNodeByChapterId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestTreeNodeByChapterId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questtree.db"),
				new ValueTuple<string, object>("文件", "r.任务树.xlsx"),
				new ValueTuple<string, object>("表名", "QuestTreeNode"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestTreeNode` where ChapterId=?")
			});
		}

		// Token: 0x06002D74 RID: 11636 RVA: 0x0015A103 File Offset: 0x00158303
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTreeNodeByChapterId.LogPair = null;
			ConfigQuestTreeNodeByChapterId.HandleId = 0;
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x0015A111 File Offset: 0x00158311
		public static void Init()
		{
			ConfigQuestTreeNodeByChapterId.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTreeNodeByChapterId.HandleId, "db_questtree.db", "select BinData from `QuestTreeNode` where ChapterId=?");
		}

		// Token: 0x06002D76 RID: 11638 RVA: 0x0015A12C File Offset: 0x0015832C
		[NullableContext(2)]
		public static IReadOnlyList<QuestTreeNode> GetConfigList(int p0ChapterId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestTreeNodeByChapterId.HandleId, ConfigQuestTreeNodeByChapterId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestTreeNodeByChapterId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ChapterId);
				IReadOnlyList<QuestTreeNode> readOnlyList = (IReadOnlyList<QuestTreeNode>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigQuestTreeNodeByChapterId.LogPair.Clear();
			ConfigQuestTreeNodeByChapterId.LogPair.Add(new ValueTuple<string, object>("ChapterId", p0ChapterId));
			if (!ConfigCommon.BindInt(ConfigQuestTreeNodeByChapterId.HandleId, 1, p0ChapterId, ConfigQuestTreeNodeByChapterId.LogPair))
			{
				ConfigCommon.Reset(ConfigQuestTreeNodeByChapterId.HandleId, ConfigQuestTreeNodeByChapterId.LogPair);
				return null;
			}
			List<QuestTreeNode> list = new List<QuestTreeNode>();
			while (ConfigCommon.Step(ConfigQuestTreeNodeByChapterId.HandleId, false, ConfigQuestTreeNodeByChapterId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestTreeNodeByChapterId.HandleId, 0, ConfigQuestTreeNodeByChapterId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigQuestTreeNodeByChapterId.HandleId, ConfigQuestTreeNodeByChapterId.LogPair);
					return null;
				}
				QuestTreeNode rootAsQuestTreeNode = QuestTreeNode.GetRootAsQuestTreeNode(new ByteBuffer(item2));
				list.Add(rootAsQuestTreeNode);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestTreeNodeByChapterId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ChapterId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigQuestTreeNodeByChapterId.HandleId, ConfigQuestTreeNodeByChapterId.LogPair);
			return list;
		}

		// Token: 0x040034D6 RID: 13526
		private const string DB = "db_questtree.db";

		// Token: 0x040034D7 RID: 13527
		private const string FILE = "r.任务树.xlsx";

		// Token: 0x040034D8 RID: 13528
		private const string TABLE = "QuestTreeNode";

		// Token: 0x040034D9 RID: 13529
		private const string COMMAND = "select BinData from `QuestTreeNode` where ChapterId=?";

		// Token: 0x040034DA RID: 13530
		private const string KEY_PREFIX = "QuestTreeNodeByChapterId";

		// Token: 0x040034DB RID: 13531
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040034DC RID: 13532
		private static int HandleId;
	}
}

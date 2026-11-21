using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007AA RID: 1962
	public class ConfigQuestTreeNodeByChapterId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E0E RID: 11790 RVA: 0x00160F70 File Offset: 0x0015F170
		static ConfigQuestTreeNodeByChapterId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTreeNodeByChapterId.CreateStaticDefaultValue), new Action(ConfigQuestTreeNodeByChapterId.ResetStaticDefaultValue));
		}

		// Token: 0x06002E0F RID: 11791 RVA: 0x00160F90 File Offset: 0x0015F190
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

		// Token: 0x06002E10 RID: 11792 RVA: 0x0016100F File Offset: 0x0015F20F
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTreeNodeByChapterId.LogPair = null;
			ConfigQuestTreeNodeByChapterId.HandleId = 0;
		}

		// Token: 0x06002E11 RID: 11793 RVA: 0x0016101D File Offset: 0x0015F21D
		public static void Init()
		{
			ConfigQuestTreeNodeByChapterId.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTreeNodeByChapterId.HandleId, "db_questtree.db", "select BinData from `QuestTreeNode` where ChapterId=?");
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x00161038 File Offset: 0x0015F238
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

		// Token: 0x0400358C RID: 13708
		private const string DB = "db_questtree.db";

		// Token: 0x0400358D RID: 13709
		private const string FILE = "r.任务树.xlsx";

		// Token: 0x0400358E RID: 13710
		private const string TABLE = "QuestTreeNode";

		// Token: 0x0400358F RID: 13711
		private const string COMMAND = "select BinData from `QuestTreeNode` where ChapterId=?";

		// Token: 0x04003590 RID: 13712
		private const string KEY_PREFIX = "QuestTreeNodeByChapterId";

		// Token: 0x04003591 RID: 13713
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003592 RID: 13714
		private static int HandleId;
	}
}

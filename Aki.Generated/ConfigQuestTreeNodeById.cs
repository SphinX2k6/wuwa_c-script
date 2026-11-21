using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007AB RID: 1963
	public class ConfigQuestTreeNodeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E14 RID: 11796 RVA: 0x001611A7 File Offset: 0x0015F3A7
		static ConfigQuestTreeNodeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTreeNodeById.CreateStaticDefaultValue), new Action(ConfigQuestTreeNodeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002E15 RID: 11797 RVA: 0x001611C8 File Offset: 0x0015F3C8
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestTreeNodeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestTreeNodeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questtree.db"),
				new ValueTuple<string, object>("文件", "r.任务树.xlsx"),
				new ValueTuple<string, object>("表名", "QuestTreeNode"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestTreeNode` where Id=?")
			});
		}

		// Token: 0x06002E16 RID: 11798 RVA: 0x00161247 File Offset: 0x0015F447
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTreeNodeById.LogPair = null;
			ConfigQuestTreeNodeById.HandleId = 0;
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x00161255 File Offset: 0x0015F455
		public static void Init()
		{
			ConfigQuestTreeNodeById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTreeNodeById.HandleId, "db_questtree.db", "select BinData from `QuestTreeNode` where Id=?");
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x00161270 File Offset: 0x0015F470
		public static QuestTreeNode? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestTreeNodeById.HandleId, ConfigQuestTreeNodeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestTreeNodeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QuestTreeNode?(QuestTreeNode.GetRootAsQuestTreeNode(configBuffer));
				}
			}
			ConfigQuestTreeNodeById.LogPair.Clear();
			ConfigQuestTreeNodeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigQuestTreeNodeById.HandleId, 1, p0Id, ConfigQuestTreeNodeById.LogPair) || ConfigCommon.Step(ConfigQuestTreeNodeById.HandleId, true, ConfigQuestTreeNodeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestTreeNodeById.HandleId, ConfigQuestTreeNodeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestTreeNodeById.HandleId, 0, ConfigQuestTreeNodeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestTreeNodeById.HandleId, ConfigQuestTreeNodeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuestTreeNode rootAsQuestTreeNode = QuestTreeNode.GetRootAsQuestTreeNode(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestTreeNodeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestTreeNodeById.HandleId, ConfigQuestTreeNodeById.LogPair);
			return new QuestTreeNode?(rootAsQuestTreeNode);
		}

		// Token: 0x04003593 RID: 13715
		private const string DB = "db_questtree.db";

		// Token: 0x04003594 RID: 13716
		private const string FILE = "r.任务树.xlsx";

		// Token: 0x04003595 RID: 13717
		private const string TABLE = "QuestTreeNode";

		// Token: 0x04003596 RID: 13718
		private const string COMMAND = "select BinData from `QuestTreeNode` where Id=?";

		// Token: 0x04003597 RID: 13719
		private const string KEY_PREFIX = "QuestTreeNodeById";

		// Token: 0x04003598 RID: 13720
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003599 RID: 13721
		private static int HandleId;
	}
}

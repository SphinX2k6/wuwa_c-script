using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000791 RID: 1937
	public class ConfigQuestTreeNodeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D78 RID: 11640 RVA: 0x0015A29B File Offset: 0x0015849B
		static ConfigQuestTreeNodeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTreeNodeById.CreateStaticDefaultValue), new Action(ConfigQuestTreeNodeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x0015A2BC File Offset: 0x001584BC
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

		// Token: 0x06002D7A RID: 11642 RVA: 0x0015A33B File Offset: 0x0015853B
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTreeNodeById.LogPair = null;
			ConfigQuestTreeNodeById.HandleId = 0;
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x0015A349 File Offset: 0x00158549
		public static void Init()
		{
			ConfigQuestTreeNodeById.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTreeNodeById.HandleId, "db_questtree.db", "select BinData from `QuestTreeNode` where Id=?");
		}

		// Token: 0x06002D7C RID: 11644 RVA: 0x0015A364 File Offset: 0x00158564
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

		// Token: 0x040034DD RID: 13533
		private const string DB = "db_questtree.db";

		// Token: 0x040034DE RID: 13534
		private const string FILE = "r.任务树.xlsx";

		// Token: 0x040034DF RID: 13535
		private const string TABLE = "QuestTreeNode";

		// Token: 0x040034E0 RID: 13536
		private const string COMMAND = "select BinData from `QuestTreeNode` where Id=?";

		// Token: 0x040034E1 RID: 13537
		private const string KEY_PREFIX = "QuestTreeNodeById";

		// Token: 0x040034E2 RID: 13538
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040034E3 RID: 13539
		private static int HandleId;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000792 RID: 1938
	public class ConfigQuestNodeDataByKey : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D7D RID: 11645 RVA: 0x0015DDAC File Offset: 0x0015BFAC
		static ConfigQuestNodeDataByKey()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestNodeDataByKey.CreateStaticDefaultValue), new Action(ConfigQuestNodeDataByKey.ResetStaticDefaultValue));
		}

		// Token: 0x06002D7E RID: 11646 RVA: 0x0015DDCC File Offset: 0x0015BFCC
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestNodeDataByKey.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestNodeDataByKey.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questnodedata.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/Quest/节点_*"),
				new ValueTuple<string, object>("表名", "QuestNodeData"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestNodeData` where Key=?")
			});
		}

		// Token: 0x06002D7F RID: 11647 RVA: 0x0015DE4B File Offset: 0x0015C04B
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestNodeDataByKey.LogPair = null;
			ConfigQuestNodeDataByKey.HandleId = 0;
		}

		// Token: 0x06002D80 RID: 11648 RVA: 0x0015DE59 File Offset: 0x0015C059
		public static void Init()
		{
			ConfigQuestNodeDataByKey.HandleId = ConfigCommon.InitDataStatement(ConfigQuestNodeDataByKey.HandleId, "db_questnodedata.db", "select BinData from `QuestNodeData` where Key=?");
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x0015DE74 File Offset: 0x0015C074
		public static QuestNodeData? GetConfig(string p0Key, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestNodeDataByKey.HandleId, ConfigQuestNodeDataByKey.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("QuestNodeDataByKey#" + p0Key);
				if (configBuffer != null)
				{
					return new QuestNodeData?(QuestNodeData.GetRootAsQuestNodeData(configBuffer));
				}
			}
			ConfigQuestNodeDataByKey.LogPair.Clear();
			ConfigQuestNodeDataByKey.LogPair.Add(new ValueTuple<string, object>("Key", p0Key));
			if (!ConfigCommon.BindString(ConfigQuestNodeDataByKey.HandleId, 1, p0Key, ConfigQuestNodeDataByKey.LogPair) || ConfigCommon.Step(ConfigQuestNodeDataByKey.HandleId, true, ConfigQuestNodeDataByKey.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestNodeDataByKey.HandleId, ConfigQuestNodeDataByKey.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestNodeDataByKey.HandleId, 0, ConfigQuestNodeDataByKey.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestNodeDataByKey.HandleId, ConfigQuestNodeDataByKey.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuestNodeData rootAsQuestNodeData = QuestNodeData.GetRootAsQuestNodeData(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("QuestNodeDataByKey#" + p0Key, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestNodeDataByKey.HandleId, ConfigQuestNodeDataByKey.LogPair);
			return new QuestNodeData?(rootAsQuestNodeData);
		}

		// Token: 0x040034E4 RID: 13540
		private const string DB = "db_questnodedata.db";

		// Token: 0x040034E5 RID: 13541
		private const string FILE = "UniverseEditor/Quest/节点_*";

		// Token: 0x040034E6 RID: 13542
		private const string TABLE = "QuestNodeData";

		// Token: 0x040034E7 RID: 13543
		private const string COMMAND = "select BinData from `QuestNodeData` where Key=?";

		// Token: 0x040034E8 RID: 13544
		private const string KEY_PREFIX = "QuestNodeDataByKey";

		// Token: 0x040034E9 RID: 13545
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040034EA RID: 13546
		private static int HandleId;
	}
}

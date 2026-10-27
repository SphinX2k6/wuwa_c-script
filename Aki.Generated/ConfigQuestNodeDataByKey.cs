using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000778 RID: 1912
	public class ConfigQuestNodeDataByKey : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CE1 RID: 11489 RVA: 0x00156EA0 File Offset: 0x001550A0
		static ConfigQuestNodeDataByKey()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestNodeDataByKey.CreateStaticDefaultValue), new Action(ConfigQuestNodeDataByKey.ResetStaticDefaultValue));
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x00156EC0 File Offset: 0x001550C0
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

		// Token: 0x06002CE3 RID: 11491 RVA: 0x00156F3F File Offset: 0x0015513F
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestNodeDataByKey.LogPair = null;
			ConfigQuestNodeDataByKey.HandleId = 0;
		}

		// Token: 0x06002CE4 RID: 11492 RVA: 0x00156F4D File Offset: 0x0015514D
		public static void Init()
		{
			ConfigQuestNodeDataByKey.HandleId = ConfigCommon.InitDataStatement(ConfigQuestNodeDataByKey.HandleId, "db_questnodedata.db", "select BinData from `QuestNodeData` where Key=?");
		}

		// Token: 0x06002CE5 RID: 11493 RVA: 0x00156F68 File Offset: 0x00155168
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

		// Token: 0x0400342E RID: 13358
		private const string DB = "db_questnodedata.db";

		// Token: 0x0400342F RID: 13359
		private const string FILE = "UniverseEditor/Quest/节点_*";

		// Token: 0x04003430 RID: 13360
		private const string TABLE = "QuestNodeData";

		// Token: 0x04003431 RID: 13361
		private const string COMMAND = "select BinData from `QuestNodeData` where Key=?";

		// Token: 0x04003432 RID: 13362
		private const string KEY_PREFIX = "QuestNodeDataByKey";

		// Token: 0x04003433 RID: 13363
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003434 RID: 13364
		private static int HandleId;
	}
}

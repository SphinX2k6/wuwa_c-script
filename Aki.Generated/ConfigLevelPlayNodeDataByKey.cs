using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004D1 RID: 1233
	public class ConfigLevelPlayNodeDataByKey : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CF1 RID: 7409 RVA: 0x000FCB58 File Offset: 0x000FAD58
		static ConfigLevelPlayNodeDataByKey()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLevelPlayNodeDataByKey.CreateStaticDefaultValue), new Action(ConfigLevelPlayNodeDataByKey.ResetStaticDefaultValue));
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x000FCB78 File Offset: 0x000FAD78
		public static void CreateStaticDefaultValue()
		{
			ConfigLevelPlayNodeDataByKey.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLevelPlayNodeDataByKey.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_levelplaynodedata.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/LevelPlay/节点_*"),
				new ValueTuple<string, object>("表名", "LevelPlayNodeData"),
				new ValueTuple<string, object>("语句", "select BinData from `LevelPlayNodeData` where Key=?")
			});
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x000FCBF7 File Offset: 0x000FADF7
		public static void ResetStaticDefaultValue()
		{
			ConfigLevelPlayNodeDataByKey.LogPair = null;
			ConfigLevelPlayNodeDataByKey.HandleId = 0;
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x000FCC05 File Offset: 0x000FAE05
		public static void Init()
		{
			ConfigLevelPlayNodeDataByKey.HandleId = ConfigCommon.InitDataStatement(ConfigLevelPlayNodeDataByKey.HandleId, "db_levelplaynodedata.db", "select BinData from `LevelPlayNodeData` where Key=?");
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x000FCC20 File Offset: 0x000FAE20
		public static LevelPlayNodeData? GetConfig(string p0Key, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLevelPlayNodeDataByKey.HandleId, ConfigLevelPlayNodeDataByKey.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("LevelPlayNodeDataByKey#" + p0Key);
				if (configBuffer != null)
				{
					return new LevelPlayNodeData?(LevelPlayNodeData.GetRootAsLevelPlayNodeData(configBuffer));
				}
			}
			ConfigLevelPlayNodeDataByKey.LogPair.Clear();
			ConfigLevelPlayNodeDataByKey.LogPair.Add(new ValueTuple<string, object>("Key", p0Key));
			if (!ConfigCommon.BindString(ConfigLevelPlayNodeDataByKey.HandleId, 1, p0Key, ConfigLevelPlayNodeDataByKey.LogPair) || ConfigCommon.Step(ConfigLevelPlayNodeDataByKey.HandleId, true, ConfigLevelPlayNodeDataByKey.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLevelPlayNodeDataByKey.HandleId, ConfigLevelPlayNodeDataByKey.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLevelPlayNodeDataByKey.HandleId, 0, ConfigLevelPlayNodeDataByKey.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLevelPlayNodeDataByKey.HandleId, ConfigLevelPlayNodeDataByKey.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LevelPlayNodeData rootAsLevelPlayNodeData = LevelPlayNodeData.GetRootAsLevelPlayNodeData(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("LevelPlayNodeDataByKey#" + p0Key, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLevelPlayNodeDataByKey.HandleId, ConfigLevelPlayNodeDataByKey.LogPair);
			return new LevelPlayNodeData?(rootAsLevelPlayNodeData);
		}

		// Token: 0x0400219B RID: 8603
		private const string DB = "db_levelplaynodedata.db";

		// Token: 0x0400219C RID: 8604
		private const string FILE = "UniverseEditor/LevelPlay/节点_*";

		// Token: 0x0400219D RID: 8605
		private const string TABLE = "LevelPlayNodeData";

		// Token: 0x0400219E RID: 8606
		private const string COMMAND = "select BinData from `LevelPlayNodeData` where Key=?";

		// Token: 0x0400219F RID: 8607
		private const string KEY_PREFIX = "LevelPlayNodeDataByKey";

		// Token: 0x040021A0 RID: 8608
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021A1 RID: 8609
		private static int HandleId;
	}
}

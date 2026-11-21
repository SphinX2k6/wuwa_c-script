using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004E7 RID: 1255
	public class ConfigLevelPlayNodeDataByKey : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D75 RID: 7541 RVA: 0x001032AC File Offset: 0x001014AC
		static ConfigLevelPlayNodeDataByKey()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLevelPlayNodeDataByKey.CreateStaticDefaultValue), new Action(ConfigLevelPlayNodeDataByKey.ResetStaticDefaultValue));
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x001032CC File Offset: 0x001014CC
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

		// Token: 0x06001D77 RID: 7543 RVA: 0x0010334B File Offset: 0x0010154B
		public static void ResetStaticDefaultValue()
		{
			ConfigLevelPlayNodeDataByKey.LogPair = null;
			ConfigLevelPlayNodeDataByKey.HandleId = 0;
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x00103359 File Offset: 0x00101559
		public static void Init()
		{
			ConfigLevelPlayNodeDataByKey.HandleId = ConfigCommon.InitDataStatement(ConfigLevelPlayNodeDataByKey.HandleId, "db_levelplaynodedata.db", "select BinData from `LevelPlayNodeData` where Key=?");
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x00103374 File Offset: 0x00101574
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

		// Token: 0x04002235 RID: 8757
		private const string DB = "db_levelplaynodedata.db";

		// Token: 0x04002236 RID: 8758
		private const string FILE = "UniverseEditor/LevelPlay/节点_*";

		// Token: 0x04002237 RID: 8759
		private const string TABLE = "LevelPlayNodeData";

		// Token: 0x04002238 RID: 8760
		private const string COMMAND = "select BinData from `LevelPlayNodeData` where Key=?";

		// Token: 0x04002239 RID: 8761
		private const string KEY_PREFIX = "LevelPlayNodeDataByKey";

		// Token: 0x0400223A RID: 8762
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400223B RID: 8763
		private static int HandleId;
	}
}

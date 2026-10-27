using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004CA RID: 1226
	public class ConfigLevelCustomPrimitiveDataAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CC7 RID: 7367 RVA: 0x000FBCE8 File Offset: 0x000F9EE8
		static ConfigLevelCustomPrimitiveDataAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLevelCustomPrimitiveDataAll.CreateStaticDefaultValue), new Action(ConfigLevelCustomPrimitiveDataAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x000FBD08 File Offset: 0x000F9F08
		public static void CreateStaticDefaultValue()
		{
			ConfigLevelCustomPrimitiveDataAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLevelCustomPrimitiveDataAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_levelcustomprimitivedata.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/LevelPlay/CustomPrimitiveData_*"),
				new ValueTuple<string, object>("表名", "LevelCustomPrimitiveData"),
				new ValueTuple<string, object>("语句", "select BinData from `LevelCustomPrimitiveData`")
			});
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x000FBD87 File Offset: 0x000F9F87
		public static void ResetStaticDefaultValue()
		{
			ConfigLevelCustomPrimitiveDataAll.LogPair = null;
			ConfigLevelCustomPrimitiveDataAll.HandleId = 0;
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x000FBD95 File Offset: 0x000F9F95
		public static void Init()
		{
			ConfigLevelCustomPrimitiveDataAll.HandleId = ConfigCommon.InitDataStatement(ConfigLevelCustomPrimitiveDataAll.HandleId, "db_levelcustomprimitivedata.db", "select BinData from `LevelCustomPrimitiveData`");
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x000FBDB0 File Offset: 0x000F9FB0
		[NullableContext(2)]
		public static IReadOnlyList<LevelCustomPrimitiveData> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLevelCustomPrimitiveDataAll.HandleId, ConfigLevelCustomPrimitiveDataAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<LevelCustomPrimitiveData> readOnlyList = (IReadOnlyList<LevelCustomPrimitiveData>)ConfigCommon.GetConfig("LevelCustomPrimitiveDataAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<LevelCustomPrimitiveData> list = new List<LevelCustomPrimitiveData>();
			while (ConfigCommon.Step(ConfigLevelCustomPrimitiveDataAll.HandleId, false, ConfigLevelCustomPrimitiveDataAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLevelCustomPrimitiveDataAll.HandleId, 0, ConfigLevelCustomPrimitiveDataAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigLevelCustomPrimitiveDataAll.HandleId, ConfigLevelCustomPrimitiveDataAll.LogPair);
					return null;
				}
				LevelCustomPrimitiveData rootAsLevelCustomPrimitiveData = LevelCustomPrimitiveData.GetRootAsLevelCustomPrimitiveData(new ByteBuffer(item2));
				list.Add(rootAsLevelCustomPrimitiveData);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("LevelCustomPrimitiveDataAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigLevelCustomPrimitiveDataAll.HandleId, ConfigLevelCustomPrimitiveDataAll.LogPair);
			return list;
		}

		// Token: 0x0400216A RID: 8554
		private const string DB = "db_levelcustomprimitivedata.db";

		// Token: 0x0400216B RID: 8555
		private const string FILE = "UniverseEditor/LevelPlay/CustomPrimitiveData_*";

		// Token: 0x0400216C RID: 8556
		private const string TABLE = "LevelCustomPrimitiveData";

		// Token: 0x0400216D RID: 8557
		private const string COMMAND = "select BinData from `LevelCustomPrimitiveData`";

		// Token: 0x0400216E RID: 8558
		private const string KEY_PREFIX = "LevelCustomPrimitiveDataAll";

		// Token: 0x0400216F RID: 8559
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002170 RID: 8560
		private static int HandleId;
	}
}

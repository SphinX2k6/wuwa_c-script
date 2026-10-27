using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004CB RID: 1227
	public class ConfigLevelEntityConfigByBlueprintType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CCD RID: 7373 RVA: 0x000FBE7B File Offset: 0x000FA07B
		static ConfigLevelEntityConfigByBlueprintType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLevelEntityConfigByBlueprintType.CreateStaticDefaultValue), new Action(ConfigLevelEntityConfigByBlueprintType.ResetStaticDefaultValue));
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x000FBE9C File Offset: 0x000FA09C
		public static void CreateStaticDefaultValue()
		{
			ConfigLevelEntityConfigByBlueprintType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLevelEntityConfigByBlueprintType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_level_entity.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/Entity/LevelEntity.csv"),
				new ValueTuple<string, object>("表名", "LevelEntityConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `LevelEntityConfig` where BlueprintType=?")
			});
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x000FBF1B File Offset: 0x000FA11B
		public static void ResetStaticDefaultValue()
		{
			ConfigLevelEntityConfigByBlueprintType.LogPair = null;
			ConfigLevelEntityConfigByBlueprintType.HandleId = 0;
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x000FBF29 File Offset: 0x000FA129
		public static void Init()
		{
			ConfigLevelEntityConfigByBlueprintType.HandleId = ConfigCommon.InitDataStatement(ConfigLevelEntityConfigByBlueprintType.HandleId, "db_level_entity.db", "select BinData from `LevelEntityConfig` where BlueprintType=?");
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x000FBF44 File Offset: 0x000FA144
		[return: Nullable(2)]
		public static IReadOnlyList<LevelEntityConfig> GetConfigList(string p0BlueprintType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLevelEntityConfigByBlueprintType.HandleId, ConfigLevelEntityConfigByBlueprintType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<LevelEntityConfig> readOnlyList = (IReadOnlyList<LevelEntityConfig>)ConfigCommon.GetConfig("LevelEntityConfigByBlueprintType#" + p0BlueprintType);
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigLevelEntityConfigByBlueprintType.LogPair.Clear();
			ConfigLevelEntityConfigByBlueprintType.LogPair.Add(new ValueTuple<string, object>("BlueprintType", p0BlueprintType));
			if (!ConfigCommon.BindString(ConfigLevelEntityConfigByBlueprintType.HandleId, 1, p0BlueprintType, ConfigLevelEntityConfigByBlueprintType.LogPair))
			{
				ConfigCommon.Reset(ConfigLevelEntityConfigByBlueprintType.HandleId, ConfigLevelEntityConfigByBlueprintType.LogPair);
				return null;
			}
			List<LevelEntityConfig> list = new List<LevelEntityConfig>();
			while (ConfigCommon.Step(ConfigLevelEntityConfigByBlueprintType.HandleId, false, ConfigLevelEntityConfigByBlueprintType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLevelEntityConfigByBlueprintType.HandleId, 0, ConfigLevelEntityConfigByBlueprintType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigLevelEntityConfigByBlueprintType.HandleId, ConfigLevelEntityConfigByBlueprintType.LogPair);
					return null;
				}
				LevelEntityConfig rootAsLevelEntityConfig = LevelEntityConfig.GetRootAsLevelEntityConfig(new ByteBuffer(item2));
				list.Add(rootAsLevelEntityConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("LevelEntityConfigByBlueprintType#" + p0BlueprintType, list, list.Count);
			}
			ConfigCommon.Reset(ConfigLevelEntityConfigByBlueprintType.HandleId, ConfigLevelEntityConfigByBlueprintType.LogPair);
			return list;
		}

		// Token: 0x04002171 RID: 8561
		private const string DB = "db_level_entity.db";

		// Token: 0x04002172 RID: 8562
		private const string FILE = "UniverseEditor/Entity/LevelEntity.csv";

		// Token: 0x04002173 RID: 8563
		private const string TABLE = "LevelEntityConfig";

		// Token: 0x04002174 RID: 8564
		private const string COMMAND = "select BinData from `LevelEntityConfig` where BlueprintType=?";

		// Token: 0x04002175 RID: 8565
		private const string KEY_PREFIX = "LevelEntityConfigByBlueprintType";

		// Token: 0x04002176 RID: 8566
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002177 RID: 8567
		private static int HandleId;
	}
}

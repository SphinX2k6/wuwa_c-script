using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004E1 RID: 1249
	public class ConfigLevelEntityConfigByBlueprintType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D51 RID: 7505 RVA: 0x001025CF File Offset: 0x001007CF
		static ConfigLevelEntityConfigByBlueprintType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLevelEntityConfigByBlueprintType.CreateStaticDefaultValue), new Action(ConfigLevelEntityConfigByBlueprintType.ResetStaticDefaultValue));
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x001025F0 File Offset: 0x001007F0
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

		// Token: 0x06001D53 RID: 7507 RVA: 0x0010266F File Offset: 0x0010086F
		public static void ResetStaticDefaultValue()
		{
			ConfigLevelEntityConfigByBlueprintType.LogPair = null;
			ConfigLevelEntityConfigByBlueprintType.HandleId = 0;
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x0010267D File Offset: 0x0010087D
		public static void Init()
		{
			ConfigLevelEntityConfigByBlueprintType.HandleId = ConfigCommon.InitDataStatement(ConfigLevelEntityConfigByBlueprintType.HandleId, "db_level_entity.db", "select BinData from `LevelEntityConfig` where BlueprintType=?");
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x00102698 File Offset: 0x00100898
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

		// Token: 0x0400220B RID: 8715
		private const string DB = "db_level_entity.db";

		// Token: 0x0400220C RID: 8716
		private const string FILE = "UniverseEditor/Entity/LevelEntity.csv";

		// Token: 0x0400220D RID: 8717
		private const string TABLE = "LevelEntityConfig";

		// Token: 0x0400220E RID: 8718
		private const string COMMAND = "select BinData from `LevelEntityConfig` where BlueprintType=?";

		// Token: 0x0400220F RID: 8719
		private const string KEY_PREFIX = "LevelEntityConfigByBlueprintType";

		// Token: 0x04002210 RID: 8720
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002211 RID: 8721
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004CF RID: 1231
	public class ConfigLevelPlayInfoMappingConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CE5 RID: 7397 RVA: 0x000FC77C File Offset: 0x000FA97C
		static ConfigLevelPlayInfoMappingConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLevelPlayInfoMappingConfigAll.CreateStaticDefaultValue), new Action(ConfigLevelPlayInfoMappingConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x000FC79C File Offset: 0x000FA99C
		public static void CreateStaticDefaultValue()
		{
			ConfigLevelPlayInfoMappingConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLevelPlayInfoMappingConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_levelplayinfomappingconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/w.玩法信息映射/*.csv*"),
				new ValueTuple<string, object>("表名", "LevelPlayInfoMappingConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `LevelPlayInfoMappingConfig`")
			});
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x000FC81B File Offset: 0x000FAA1B
		public static void ResetStaticDefaultValue()
		{
			ConfigLevelPlayInfoMappingConfigAll.LogPair = null;
			ConfigLevelPlayInfoMappingConfigAll.HandleId = 0;
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x000FC829 File Offset: 0x000FAA29
		public static void Init()
		{
			ConfigLevelPlayInfoMappingConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigLevelPlayInfoMappingConfigAll.HandleId, "db_levelplayinfomappingconfig.db", "select BinData from `LevelPlayInfoMappingConfig`");
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x000FC844 File Offset: 0x000FAA44
		[NullableContext(2)]
		public static IReadOnlyList<LevelPlayInfoMappingConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLevelPlayInfoMappingConfigAll.HandleId, ConfigLevelPlayInfoMappingConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<LevelPlayInfoMappingConfig> readOnlyList = (IReadOnlyList<LevelPlayInfoMappingConfig>)ConfigCommon.GetConfig("LevelPlayInfoMappingConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<LevelPlayInfoMappingConfig> list = new List<LevelPlayInfoMappingConfig>();
			while (ConfigCommon.Step(ConfigLevelPlayInfoMappingConfigAll.HandleId, false, ConfigLevelPlayInfoMappingConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLevelPlayInfoMappingConfigAll.HandleId, 0, ConfigLevelPlayInfoMappingConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigLevelPlayInfoMappingConfigAll.HandleId, ConfigLevelPlayInfoMappingConfigAll.LogPair);
					return null;
				}
				LevelPlayInfoMappingConfig rootAsLevelPlayInfoMappingConfig = LevelPlayInfoMappingConfig.GetRootAsLevelPlayInfoMappingConfig(new ByteBuffer(item2));
				list.Add(rootAsLevelPlayInfoMappingConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("LevelPlayInfoMappingConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigLevelPlayInfoMappingConfigAll.HandleId, ConfigLevelPlayInfoMappingConfigAll.LogPair);
			return list;
		}

		// Token: 0x0400218D RID: 8589
		private const string DB = "db_levelplayinfomappingconfig.db";

		// Token: 0x0400218E RID: 8590
		private const string FILE = "k.可视化编辑/c.Csv/w.玩法信息映射/*.csv*";

		// Token: 0x0400218F RID: 8591
		private const string TABLE = "LevelPlayInfoMappingConfig";

		// Token: 0x04002190 RID: 8592
		private const string COMMAND = "select BinData from `LevelPlayInfoMappingConfig`";

		// Token: 0x04002191 RID: 8593
		private const string KEY_PREFIX = "LevelPlayInfoMappingConfigAll";

		// Token: 0x04002192 RID: 8594
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002193 RID: 8595
		private static int HandleId;
	}
}

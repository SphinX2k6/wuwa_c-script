using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004E5 RID: 1253
	public class ConfigLevelPlayInfoMappingConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D69 RID: 7529 RVA: 0x00102ED0 File Offset: 0x001010D0
		static ConfigLevelPlayInfoMappingConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLevelPlayInfoMappingConfigAll.CreateStaticDefaultValue), new Action(ConfigLevelPlayInfoMappingConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x00102EF0 File Offset: 0x001010F0
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

		// Token: 0x06001D6B RID: 7531 RVA: 0x00102F6F File Offset: 0x0010116F
		public static void ResetStaticDefaultValue()
		{
			ConfigLevelPlayInfoMappingConfigAll.LogPair = null;
			ConfigLevelPlayInfoMappingConfigAll.HandleId = 0;
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x00102F7D File Offset: 0x0010117D
		public static void Init()
		{
			ConfigLevelPlayInfoMappingConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigLevelPlayInfoMappingConfigAll.HandleId, "db_levelplayinfomappingconfig.db", "select BinData from `LevelPlayInfoMappingConfig`");
		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x00102F98 File Offset: 0x00101198
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

		// Token: 0x04002227 RID: 8743
		private const string DB = "db_levelplayinfomappingconfig.db";

		// Token: 0x04002228 RID: 8744
		private const string FILE = "k.可视化编辑/c.Csv/w.玩法信息映射/*.csv*";

		// Token: 0x04002229 RID: 8745
		private const string TABLE = "LevelPlayInfoMappingConfig";

		// Token: 0x0400222A RID: 8746
		private const string COMMAND = "select BinData from `LevelPlayInfoMappingConfig`";

		// Token: 0x0400222B RID: 8747
		private const string KEY_PREFIX = "LevelPlayInfoMappingConfigAll";

		// Token: 0x0400222C RID: 8748
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400222D RID: 8749
		private static int HandleId;
	}
}

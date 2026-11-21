using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000111 RID: 273
	public class ConfigBlueprintConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000667 RID: 1639 RVA: 0x000817C0 File Offset: 0x0007F9C0
		static ConfigBlueprintConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlueprintConfigAll.CreateStaticDefaultValue), new Action(ConfigBlueprintConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x000817E0 File Offset: 0x0007F9E0
		public static void CreateStaticDefaultValue()
		{
			ConfigBlueprintConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBlueprintConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_blueprint.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/Entity/Blueprint.csv"),
				new ValueTuple<string, object>("表名", "BlueprintConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `BlueprintConfig`")
			});
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0008185F File Offset: 0x0007FA5F
		public static void ResetStaticDefaultValue()
		{
			ConfigBlueprintConfigAll.LogPair = null;
			ConfigBlueprintConfigAll.HandleId = 0;
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0008186D File Offset: 0x0007FA6D
		public static void Init()
		{
			ConfigBlueprintConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigBlueprintConfigAll.HandleId, "db_blueprint.db", "select BinData from `BlueprintConfig`");
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00081888 File Offset: 0x0007FA88
		[NullableContext(2)]
		public static IReadOnlyList<BlueprintConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBlueprintConfigAll.HandleId, ConfigBlueprintConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<BlueprintConfig> readOnlyList = (IReadOnlyList<BlueprintConfig>)ConfigCommon.GetConfig("BlueprintConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<BlueprintConfig> list = new List<BlueprintConfig>();
			while (ConfigCommon.Step(ConfigBlueprintConfigAll.HandleId, false, ConfigBlueprintConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBlueprintConfigAll.HandleId, 0, ConfigBlueprintConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBlueprintConfigAll.HandleId, ConfigBlueprintConfigAll.LogPair);
					return null;
				}
				BlueprintConfig rootAsBlueprintConfig = BlueprintConfig.GetRootAsBlueprintConfig(new ByteBuffer(item2));
				list.Add(rootAsBlueprintConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BlueprintConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigBlueprintConfigAll.HandleId, ConfigBlueprintConfigAll.LogPair);
			return list;
		}

		// Token: 0x0400075B RID: 1883
		private const string DB = "db_blueprint.db";

		// Token: 0x0400075C RID: 1884
		private const string FILE = "UniverseEditor/Entity/Blueprint.csv";

		// Token: 0x0400075D RID: 1885
		private const string TABLE = "BlueprintConfig";

		// Token: 0x0400075E RID: 1886
		private const string COMMAND = "select BinData from `BlueprintConfig`";

		// Token: 0x0400075F RID: 1887
		private const string KEY_PREFIX = "BlueprintConfigAll";

		// Token: 0x04000760 RID: 1888
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000761 RID: 1889
		private static int HandleId;
	}
}

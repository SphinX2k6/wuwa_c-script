using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000102 RID: 258
	public class ConfigBlueprintConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600060D RID: 1549 RVA: 0x0007BE5C File Offset: 0x0007A05C
		static ConfigBlueprintConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlueprintConfigAll.CreateStaticDefaultValue), new Action(ConfigBlueprintConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0007BE7C File Offset: 0x0007A07C
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

		// Token: 0x0600060F RID: 1551 RVA: 0x0007BEFB File Offset: 0x0007A0FB
		public static void ResetStaticDefaultValue()
		{
			ConfigBlueprintConfigAll.LogPair = null;
			ConfigBlueprintConfigAll.HandleId = 0;
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0007BF09 File Offset: 0x0007A109
		public static void Init()
		{
			ConfigBlueprintConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigBlueprintConfigAll.HandleId, "db_blueprint.db", "select BinData from `BlueprintConfig`");
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0007BF24 File Offset: 0x0007A124
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

		// Token: 0x040006F2 RID: 1778
		private const string DB = "db_blueprint.db";

		// Token: 0x040006F3 RID: 1779
		private const string FILE = "UniverseEditor/Entity/Blueprint.csv";

		// Token: 0x040006F4 RID: 1780
		private const string TABLE = "BlueprintConfig";

		// Token: 0x040006F5 RID: 1781
		private const string COMMAND = "select BinData from `BlueprintConfig`";

		// Token: 0x040006F6 RID: 1782
		private const string KEY_PREFIX = "BlueprintConfigAll";

		// Token: 0x040006F7 RID: 1783
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006F8 RID: 1784
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200020F RID: 527
	public class ConfigDebugEntranceTypeConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C5D RID: 3165 RVA: 0x000A31D4 File Offset: 0x000A13D4
		static ConfigDebugEntranceTypeConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDebugEntranceTypeConfigAll.CreateStaticDefaultValue), new Action(ConfigDebugEntranceTypeConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x000A31F4 File Offset: 0x000A13F4
		public static void CreateStaticDefaultValue()
		{
			ConfigDebugEntranceTypeConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDebugEntranceTypeConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_debugview.db"),
				new ValueTuple<string, object>("文件", "t.调试界面.xlsx"),
				new ValueTuple<string, object>("表名", "DebugEntranceTypeConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `DebugEntranceTypeConfig`")
			});
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x000A3273 File Offset: 0x000A1473
		public static void ResetStaticDefaultValue()
		{
			ConfigDebugEntranceTypeConfigAll.LogPair = null;
			ConfigDebugEntranceTypeConfigAll.HandleId = 0;
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x000A3281 File Offset: 0x000A1481
		public static void Init()
		{
			ConfigDebugEntranceTypeConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigDebugEntranceTypeConfigAll.HandleId, "db_debugview.db", "select BinData from `DebugEntranceTypeConfig`");
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x000A329C File Offset: 0x000A149C
		[NullableContext(2)]
		public static IReadOnlyList<DebugEntranceTypeConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDebugEntranceTypeConfigAll.HandleId, ConfigDebugEntranceTypeConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DebugEntranceTypeConfig> readOnlyList = (IReadOnlyList<DebugEntranceTypeConfig>)ConfigCommon.GetConfig("DebugEntranceTypeConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DebugEntranceTypeConfig> list = new List<DebugEntranceTypeConfig>();
			while (ConfigCommon.Step(ConfigDebugEntranceTypeConfigAll.HandleId, false, ConfigDebugEntranceTypeConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDebugEntranceTypeConfigAll.HandleId, 0, ConfigDebugEntranceTypeConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDebugEntranceTypeConfigAll.HandleId, ConfigDebugEntranceTypeConfigAll.LogPair);
					return null;
				}
				DebugEntranceTypeConfig rootAsDebugEntranceTypeConfig = DebugEntranceTypeConfig.GetRootAsDebugEntranceTypeConfig(new ByteBuffer(item2));
				list.Add(rootAsDebugEntranceTypeConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DebugEntranceTypeConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDebugEntranceTypeConfigAll.HandleId, ConfigDebugEntranceTypeConfigAll.LogPair);
			return list;
		}

		// Token: 0x04000E4D RID: 3661
		private const string DB = "db_debugview.db";

		// Token: 0x04000E4E RID: 3662
		private const string FILE = "t.调试界面.xlsx";

		// Token: 0x04000E4F RID: 3663
		private const string TABLE = "DebugEntranceTypeConfig";

		// Token: 0x04000E50 RID: 3664
		private const string COMMAND = "select BinData from `DebugEntranceTypeConfig`";

		// Token: 0x04000E51 RID: 3665
		private const string KEY_PREFIX = "DebugEntranceTypeConfigAll";

		// Token: 0x04000E52 RID: 3666
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E53 RID: 3667
		private static int HandleId;
	}
}

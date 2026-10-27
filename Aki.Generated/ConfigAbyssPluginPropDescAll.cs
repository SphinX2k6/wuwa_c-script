using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000019 RID: 25
	public class ConfigAbyssPluginPropDescAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000096 RID: 150 RVA: 0x0005D450 File Offset: 0x0005B650
		static ConfigAbyssPluginPropDescAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssPluginPropDescAll.CreateStaticDefaultValue), new Action(ConfigAbyssPluginPropDescAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0005D470 File Offset: 0x0005B670
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssPluginPropDescAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssPluginPropDescAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabysssuit.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssPluginPropDesc"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssPluginPropDesc`")
			});
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0005D4EF File Offset: 0x0005B6EF
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssPluginPropDescAll.LogPair = null;
			ConfigAbyssPluginPropDescAll.HandleId = 0;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0005D4FD File Offset: 0x0005B6FD
		public static void Init()
		{
			ConfigAbyssPluginPropDescAll.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssPluginPropDescAll.HandleId, "db_dangoabysssuit.db", "select BinData from `AbyssPluginPropDesc`");
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0005D518 File Offset: 0x0005B718
		[NullableContext(2)]
		public static IReadOnlyList<AbyssPluginPropDesc> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssPluginPropDescAll.HandleId, ConfigAbyssPluginPropDescAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AbyssPluginPropDesc> readOnlyList = (IReadOnlyList<AbyssPluginPropDesc>)ConfigCommon.GetConfig("AbyssPluginPropDescAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AbyssPluginPropDesc> list = new List<AbyssPluginPropDesc>();
			while (ConfigCommon.Step(ConfigAbyssPluginPropDescAll.HandleId, false, ConfigAbyssPluginPropDescAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssPluginPropDescAll.HandleId, 0, ConfigAbyssPluginPropDescAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAbyssPluginPropDescAll.HandleId, ConfigAbyssPluginPropDescAll.LogPair);
					return null;
				}
				AbyssPluginPropDesc rootAsAbyssPluginPropDesc = AbyssPluginPropDesc.GetRootAsAbyssPluginPropDesc(new ByteBuffer(item2));
				list.Add(rootAsAbyssPluginPropDesc);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AbyssPluginPropDescAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAbyssPluginPropDescAll.HandleId, ConfigAbyssPluginPropDescAll.LogPair);
			return list;
		}

		// Token: 0x04000093 RID: 147
		private const string DB = "db_dangoabysssuit.db";

		// Token: 0x04000094 RID: 148
		private const string FILE = "s.深渊爬塔.xlsx";

		// Token: 0x04000095 RID: 149
		private const string TABLE = "AbyssPluginPropDesc";

		// Token: 0x04000096 RID: 150
		private const string COMMAND = "select BinData from `AbyssPluginPropDesc`";

		// Token: 0x04000097 RID: 151
		private const string KEY_PREFIX = "AbyssPluginPropDescAll";

		// Token: 0x04000098 RID: 152
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000099 RID: 153
		private static int HandleId;
	}
}

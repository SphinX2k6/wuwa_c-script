using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005D7 RID: 1495
	public class ConfigMultiMapAreaConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002317 RID: 8983 RVA: 0x0011FDBF File Offset: 0x0011DFBF
		static ConfigMultiMapAreaConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMultiMapAreaConfigAll.CreateStaticDefaultValue), new Action(ConfigMultiMapAreaConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x0011FDE0 File Offset: 0x0011DFE0
		public static void CreateStaticDefaultValue()
		{
			ConfigMultiMapAreaConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMultiMapAreaConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map.db"),
				new ValueTuple<string, object>("文件", "d.地图.xlsx"),
				new ValueTuple<string, object>("表名", "MultiMapAreaConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `MultiMapAreaConfig`")
			});
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x0011FE5F File Offset: 0x0011E05F
		public static void ResetStaticDefaultValue()
		{
			ConfigMultiMapAreaConfigAll.LogPair = null;
			ConfigMultiMapAreaConfigAll.HandleId = 0;
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x0011FE6D File Offset: 0x0011E06D
		public static void Init()
		{
			ConfigMultiMapAreaConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigMultiMapAreaConfigAll.HandleId, "db_map.db", "select BinData from `MultiMapAreaConfig`");
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x0011FE88 File Offset: 0x0011E088
		[NullableContext(2)]
		public static IReadOnlyList<MultiMapAreaConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMultiMapAreaConfigAll.HandleId, ConfigMultiMapAreaConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MultiMapAreaConfig> readOnlyList = (IReadOnlyList<MultiMapAreaConfig>)ConfigCommon.GetConfig("MultiMapAreaConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MultiMapAreaConfig> list = new List<MultiMapAreaConfig>();
			while (ConfigCommon.Step(ConfigMultiMapAreaConfigAll.HandleId, false, ConfigMultiMapAreaConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMultiMapAreaConfigAll.HandleId, 0, ConfigMultiMapAreaConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMultiMapAreaConfigAll.HandleId, ConfigMultiMapAreaConfigAll.LogPair);
					return null;
				}
				MultiMapAreaConfig rootAsMultiMapAreaConfig = MultiMapAreaConfig.GetRootAsMultiMapAreaConfig(new ByteBuffer(item2));
				list.Add(rootAsMultiMapAreaConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MultiMapAreaConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMultiMapAreaConfigAll.HandleId, ConfigMultiMapAreaConfigAll.LogPair);
			return list;
		}

		// Token: 0x040028C5 RID: 10437
		private const string DB = "db_map.db";

		// Token: 0x040028C6 RID: 10438
		private const string FILE = "d.地图.xlsx";

		// Token: 0x040028C7 RID: 10439
		private const string TABLE = "MultiMapAreaConfig";

		// Token: 0x040028C8 RID: 10440
		private const string COMMAND = "select BinData from `MultiMapAreaConfig`";

		// Token: 0x040028C9 RID: 10441
		private const string KEY_PREFIX = "MultiMapAreaConfigAll";

		// Token: 0x040028CA RID: 10442
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028CB RID: 10443
		private static int HandleId;
	}
}

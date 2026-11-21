using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005EF RID: 1519
	public class ConfigMultiMapAreaConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023A7 RID: 9127 RVA: 0x0012683B File Offset: 0x00124A3B
		static ConfigMultiMapAreaConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMultiMapAreaConfigAll.CreateStaticDefaultValue), new Action(ConfigMultiMapAreaConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x0012685C File Offset: 0x00124A5C
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

		// Token: 0x060023A9 RID: 9129 RVA: 0x001268DB File Offset: 0x00124ADB
		public static void ResetStaticDefaultValue()
		{
			ConfigMultiMapAreaConfigAll.LogPair = null;
			ConfigMultiMapAreaConfigAll.HandleId = 0;
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x001268E9 File Offset: 0x00124AE9
		public static void Init()
		{
			ConfigMultiMapAreaConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigMultiMapAreaConfigAll.HandleId, "db_map.db", "select BinData from `MultiMapAreaConfig`");
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x00126904 File Offset: 0x00124B04
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

		// Token: 0x0400296D RID: 10605
		private const string DB = "db_map.db";

		// Token: 0x0400296E RID: 10606
		private const string FILE = "d.地图.xlsx";

		// Token: 0x0400296F RID: 10607
		private const string TABLE = "MultiMapAreaConfig";

		// Token: 0x04002970 RID: 10608
		private const string COMMAND = "select BinData from `MultiMapAreaConfig`";

		// Token: 0x04002971 RID: 10609
		private const string KEY_PREFIX = "MultiMapAreaConfigAll";

		// Token: 0x04002972 RID: 10610
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002973 RID: 10611
		private static int HandleId;
	}
}

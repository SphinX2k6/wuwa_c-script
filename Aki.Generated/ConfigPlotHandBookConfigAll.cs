using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000763 RID: 1891
	public class ConfigPlotHandBookConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C63 RID: 11363 RVA: 0x00157DB0 File Offset: 0x00155FB0
		static ConfigPlotHandBookConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlotHandBookConfigAll.CreateStaticDefaultValue), new Action(ConfigPlotHandBookConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x00157DD0 File Offset: 0x00155FD0
		public static void CreateStaticDefaultValue()
		{
			ConfigPlotHandBookConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPlotHandBookConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_plothandbook.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/PlotHandBook/剧情图鉴_Json_PlotHandBook.csv"),
				new ValueTuple<string, object>("表名", "PlotHandBookConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PlotHandBookConfig`")
			});
		}

		// Token: 0x06002C65 RID: 11365 RVA: 0x00157E4F File Offset: 0x0015604F
		public static void ResetStaticDefaultValue()
		{
			ConfigPlotHandBookConfigAll.LogPair = null;
			ConfigPlotHandBookConfigAll.HandleId = 0;
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x00157E5D File Offset: 0x0015605D
		public static void Init()
		{
			ConfigPlotHandBookConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigPlotHandBookConfigAll.HandleId, "db_plothandbook.db", "select BinData from `PlotHandBookConfig`");
		}

		// Token: 0x06002C67 RID: 11367 RVA: 0x00157E78 File Offset: 0x00156078
		[NullableContext(2)]
		public static IReadOnlyList<PlotHandBookConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPlotHandBookConfigAll.HandleId, ConfigPlotHandBookConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PlotHandBookConfig> readOnlyList = (IReadOnlyList<PlotHandBookConfig>)ConfigCommon.GetConfig("PlotHandBookConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PlotHandBookConfig> list = new List<PlotHandBookConfig>();
			while (ConfigCommon.Step(ConfigPlotHandBookConfigAll.HandleId, false, ConfigPlotHandBookConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPlotHandBookConfigAll.HandleId, 0, ConfigPlotHandBookConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPlotHandBookConfigAll.HandleId, ConfigPlotHandBookConfigAll.LogPair);
					return null;
				}
				PlotHandBookConfig rootAsPlotHandBookConfig = PlotHandBookConfig.GetRootAsPlotHandBookConfig(new ByteBuffer(item2));
				list.Add(rootAsPlotHandBookConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PlotHandBookConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPlotHandBookConfigAll.HandleId, ConfigPlotHandBookConfigAll.LogPair);
			return list;
		}

		// Token: 0x0400339B RID: 13211
		private const string DB = "db_plothandbook.db";

		// Token: 0x0400339C RID: 13212
		private const string FILE = "UniverseEditor/PlotHandBook/剧情图鉴_Json_PlotHandBook.csv";

		// Token: 0x0400339D RID: 13213
		private const string TABLE = "PlotHandBookConfig";

		// Token: 0x0400339E RID: 13214
		private const string COMMAND = "select BinData from `PlotHandBookConfig`";

		// Token: 0x0400339F RID: 13215
		private const string KEY_PREFIX = "PlotHandBookConfigAll";

		// Token: 0x040033A0 RID: 13216
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033A1 RID: 13217
		private static int HandleId;
	}
}

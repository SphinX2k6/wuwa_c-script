using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200074B RID: 1867
	public class ConfigPlotHandBookConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BD3 RID: 11219 RVA: 0x00151334 File Offset: 0x0014F534
		static ConfigPlotHandBookConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlotHandBookConfigAll.CreateStaticDefaultValue), new Action(ConfigPlotHandBookConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002BD4 RID: 11220 RVA: 0x00151354 File Offset: 0x0014F554
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

		// Token: 0x06002BD5 RID: 11221 RVA: 0x001513D3 File Offset: 0x0014F5D3
		public static void ResetStaticDefaultValue()
		{
			ConfigPlotHandBookConfigAll.LogPair = null;
			ConfigPlotHandBookConfigAll.HandleId = 0;
		}

		// Token: 0x06002BD6 RID: 11222 RVA: 0x001513E1 File Offset: 0x0014F5E1
		public static void Init()
		{
			ConfigPlotHandBookConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigPlotHandBookConfigAll.HandleId, "db_plothandbook.db", "select BinData from `PlotHandBookConfig`");
		}

		// Token: 0x06002BD7 RID: 11223 RVA: 0x001513FC File Offset: 0x0014F5FC
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

		// Token: 0x040032F3 RID: 13043
		private const string DB = "db_plothandbook.db";

		// Token: 0x040032F4 RID: 13044
		private const string FILE = "UniverseEditor/PlotHandBook/剧情图鉴_Json_PlotHandBook.csv";

		// Token: 0x040032F5 RID: 13045
		private const string TABLE = "PlotHandBookConfig";

		// Token: 0x040032F6 RID: 13046
		private const string COMMAND = "select BinData from `PlotHandBookConfig`";

		// Token: 0x040032F7 RID: 13047
		private const string KEY_PREFIX = "PlotHandBookConfigAll";

		// Token: 0x040032F8 RID: 13048
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040032F9 RID: 13049
		private static int HandleId;
	}
}

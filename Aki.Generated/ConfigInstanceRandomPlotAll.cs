using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200044A RID: 1098
	public class ConfigInstanceRandomPlotAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019C6 RID: 6598 RVA: 0x000EB390 File Offset: 0x000E9590
		static ConfigInstanceRandomPlotAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInstanceRandomPlotAll.CreateStaticDefaultValue), new Action(ConfigInstanceRandomPlotAll.ResetStaticDefaultValue));
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x000EB3B0 File Offset: 0x000E95B0
		public static void CreateStaticDefaultValue()
		{
			ConfigInstanceRandomPlotAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInstanceRandomPlotAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_randomplot.db"),
				new ValueTuple<string, object>("文件", "x.系统随机剧情.xlsx"),
				new ValueTuple<string, object>("表名", "InstanceRandomPlot"),
				new ValueTuple<string, object>("语句", "select BinData from `InstanceRandomPlot`")
			});
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x000EB42F File Offset: 0x000E962F
		public static void ResetStaticDefaultValue()
		{
			ConfigInstanceRandomPlotAll.LogPair = null;
			ConfigInstanceRandomPlotAll.HandleId = 0;
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x000EB43D File Offset: 0x000E963D
		public static void Init()
		{
			ConfigInstanceRandomPlotAll.HandleId = ConfigCommon.InitDataStatement(ConfigInstanceRandomPlotAll.HandleId, "db_randomplot.db", "select BinData from `InstanceRandomPlot`");
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x000EB458 File Offset: 0x000E9658
		[NullableContext(2)]
		public static IReadOnlyList<InstanceRandomPlot> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInstanceRandomPlotAll.HandleId, ConfigInstanceRandomPlotAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<InstanceRandomPlot> readOnlyList = (IReadOnlyList<InstanceRandomPlot>)ConfigCommon.GetConfig("InstanceRandomPlotAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<InstanceRandomPlot> list = new List<InstanceRandomPlot>();
			while (ConfigCommon.Step(ConfigInstanceRandomPlotAll.HandleId, false, ConfigInstanceRandomPlotAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInstanceRandomPlotAll.HandleId, 0, ConfigInstanceRandomPlotAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigInstanceRandomPlotAll.HandleId, ConfigInstanceRandomPlotAll.LogPair);
					return null;
				}
				InstanceRandomPlot rootAsInstanceRandomPlot = InstanceRandomPlot.GetRootAsInstanceRandomPlot(new ByteBuffer(item2));
				list.Add(rootAsInstanceRandomPlot);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("InstanceRandomPlotAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigInstanceRandomPlotAll.HandleId, ConfigInstanceRandomPlotAll.LogPair);
			return list;
		}

		// Token: 0x04001DEA RID: 7658
		private const string DB = "db_randomplot.db";

		// Token: 0x04001DEB RID: 7659
		private const string FILE = "x.系统随机剧情.xlsx";

		// Token: 0x04001DEC RID: 7660
		private const string TABLE = "InstanceRandomPlot";

		// Token: 0x04001DED RID: 7661
		private const string COMMAND = "select BinData from `InstanceRandomPlot`";

		// Token: 0x04001DEE RID: 7662
		private const string KEY_PREFIX = "InstanceRandomPlotAll";

		// Token: 0x04001DEF RID: 7663
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001DF0 RID: 7664
		private static int HandleId;
	}
}

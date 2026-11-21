using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000460 RID: 1120
	public class ConfigInstanceRandomPlotAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A4A RID: 6730 RVA: 0x000F1AE4 File Offset: 0x000EFCE4
		static ConfigInstanceRandomPlotAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInstanceRandomPlotAll.CreateStaticDefaultValue), new Action(ConfigInstanceRandomPlotAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x000F1B04 File Offset: 0x000EFD04
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

		// Token: 0x06001A4C RID: 6732 RVA: 0x000F1B83 File Offset: 0x000EFD83
		public static void ResetStaticDefaultValue()
		{
			ConfigInstanceRandomPlotAll.LogPair = null;
			ConfigInstanceRandomPlotAll.HandleId = 0;
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x000F1B91 File Offset: 0x000EFD91
		public static void Init()
		{
			ConfigInstanceRandomPlotAll.HandleId = ConfigCommon.InitDataStatement(ConfigInstanceRandomPlotAll.HandleId, "db_randomplot.db", "select BinData from `InstanceRandomPlot`");
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x000F1BAC File Offset: 0x000EFDAC
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

		// Token: 0x04001E84 RID: 7812
		private const string DB = "db_randomplot.db";

		// Token: 0x04001E85 RID: 7813
		private const string FILE = "x.系统随机剧情.xlsx";

		// Token: 0x04001E86 RID: 7814
		private const string TABLE = "InstanceRandomPlot";

		// Token: 0x04001E87 RID: 7815
		private const string COMMAND = "select BinData from `InstanceRandomPlot`";

		// Token: 0x04001E88 RID: 7816
		private const string KEY_PREFIX = "InstanceRandomPlotAll";

		// Token: 0x04001E89 RID: 7817
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E8A RID: 7818
		private static int HandleId;
	}
}

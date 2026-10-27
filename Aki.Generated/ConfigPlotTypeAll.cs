using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200074E RID: 1870
	public class ConfigPlotTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BE5 RID: 11237 RVA: 0x00151958 File Offset: 0x0014FB58
		static ConfigPlotTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlotTypeAll.CreateStaticDefaultValue), new Action(ConfigPlotTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x00151978 File Offset: 0x0014FB78
		public static void CreateStaticDefaultValue()
		{
			ConfigPlotTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPlotTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "PlotType"),
				new ValueTuple<string, object>("语句", "select BinData from `PlotType`")
			});
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x001519F7 File Offset: 0x0014FBF7
		public static void ResetStaticDefaultValue()
		{
			ConfigPlotTypeAll.LogPair = null;
			ConfigPlotTypeAll.HandleId = 0;
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x00151A05 File Offset: 0x0014FC05
		public static void Init()
		{
			ConfigPlotTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigPlotTypeAll.HandleId, "db_handbook.db", "select BinData from `PlotType`");
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x00151A20 File Offset: 0x0014FC20
		[NullableContext(2)]
		public static IReadOnlyList<PlotType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPlotTypeAll.HandleId, ConfigPlotTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PlotType> readOnlyList = (IReadOnlyList<PlotType>)ConfigCommon.GetConfig("PlotTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PlotType> list = new List<PlotType>();
			while (ConfigCommon.Step(ConfigPlotTypeAll.HandleId, false, ConfigPlotTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPlotTypeAll.HandleId, 0, ConfigPlotTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPlotTypeAll.HandleId, ConfigPlotTypeAll.LogPair);
					return null;
				}
				PlotType rootAsPlotType = PlotType.GetRootAsPlotType(new ByteBuffer(item2));
				list.Add(rootAsPlotType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PlotTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPlotTypeAll.HandleId, ConfigPlotTypeAll.LogPair);
			return list;
		}

		// Token: 0x04003308 RID: 13064
		private const string DB = "db_handbook.db";

		// Token: 0x04003309 RID: 13065
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x0400330A RID: 13066
		private const string TABLE = "PlotType";

		// Token: 0x0400330B RID: 13067
		private const string COMMAND = "select BinData from `PlotType`";

		// Token: 0x0400330C RID: 13068
		private const string KEY_PREFIX = "PlotTypeAll";

		// Token: 0x0400330D RID: 13069
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400330E RID: 13070
		private static int HandleId;
	}
}

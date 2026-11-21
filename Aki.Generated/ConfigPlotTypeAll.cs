using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000766 RID: 1894
	public class ConfigPlotTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C75 RID: 11381 RVA: 0x001583D4 File Offset: 0x001565D4
		static ConfigPlotTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlotTypeAll.CreateStaticDefaultValue), new Action(ConfigPlotTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x001583F4 File Offset: 0x001565F4
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

		// Token: 0x06002C77 RID: 11383 RVA: 0x00158473 File Offset: 0x00156673
		public static void ResetStaticDefaultValue()
		{
			ConfigPlotTypeAll.LogPair = null;
			ConfigPlotTypeAll.HandleId = 0;
		}

		// Token: 0x06002C78 RID: 11384 RVA: 0x00158481 File Offset: 0x00156681
		public static void Init()
		{
			ConfigPlotTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigPlotTypeAll.HandleId, "db_handbook.db", "select BinData from `PlotType`");
		}

		// Token: 0x06002C79 RID: 11385 RVA: 0x0015849C File Offset: 0x0015669C
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

		// Token: 0x040033B0 RID: 13232
		private const string DB = "db_handbook.db";

		// Token: 0x040033B1 RID: 13233
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x040033B2 RID: 13234
		private const string TABLE = "PlotType";

		// Token: 0x040033B3 RID: 13235
		private const string COMMAND = "select BinData from `PlotType`";

		// Token: 0x040033B4 RID: 13236
		private const string KEY_PREFIX = "PlotTypeAll";

		// Token: 0x040033B5 RID: 13237
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033B6 RID: 13238
		private static int HandleId;
	}
}

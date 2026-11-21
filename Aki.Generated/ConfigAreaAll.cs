using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000A6 RID: 166
	public class ConfigAreaAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003E4 RID: 996 RVA: 0x000730D0 File Offset: 0x000712D0
		static ConfigAreaAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaAll.CreateStaticDefaultValue), new Action(ConfigAreaAll.ResetStaticDefaultValue));
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x000730F0 File Offset: 0x000712F0
		public static void CreateStaticDefaultValue()
		{
			ConfigAreaAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAreaAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_area.db"),
				new ValueTuple<string, object>("文件", "q.区域.xlsx"),
				new ValueTuple<string, object>("表名", "Area"),
				new ValueTuple<string, object>("语句", "select BinData from `Area`")
			});
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0007316F File Offset: 0x0007136F
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaAll.LogPair = null;
			ConfigAreaAll.HandleId = 0;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0007317D File Offset: 0x0007137D
		public static void Init()
		{
			ConfigAreaAll.HandleId = ConfigCommon.InitDataStatement(ConfigAreaAll.HandleId, "db_area.db", "select BinData from `Area`");
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00073198 File Offset: 0x00071398
		[NullableContext(2)]
		public static IReadOnlyList<Area> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAreaAll.HandleId, ConfigAreaAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<Area> readOnlyList = (IReadOnlyList<Area>)ConfigCommon.GetConfig("AreaAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<Area> list = new List<Area>();
			while (ConfigCommon.Step(ConfigAreaAll.HandleId, false, ConfigAreaAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAreaAll.HandleId, 0, ConfigAreaAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAreaAll.HandleId, ConfigAreaAll.LogPair);
					return null;
				}
				Area rootAsArea = Area.GetRootAsArea(new ByteBuffer(item2));
				list.Add(rootAsArea);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AreaAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAreaAll.HandleId, ConfigAreaAll.LogPair);
			return list;
		}

		// Token: 0x0400046E RID: 1134
		private const string DB = "db_area.db";

		// Token: 0x0400046F RID: 1135
		private const string FILE = "q.区域.xlsx";

		// Token: 0x04000470 RID: 1136
		private const string TABLE = "Area";

		// Token: 0x04000471 RID: 1137
		private const string COMMAND = "select BinData from `Area`";

		// Token: 0x04000472 RID: 1138
		private const string KEY_PREFIX = "AreaAll";

		// Token: 0x04000473 RID: 1139
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000474 RID: 1140
		private static int HandleId;
	}
}

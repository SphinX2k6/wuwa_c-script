using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000524 RID: 1316
	public class ConfigMapBorderAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001EE3 RID: 7907 RVA: 0x0010B483 File Offset: 0x00109683
		static ConfigMapBorderAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapBorderAll.CreateStaticDefaultValue), new Action(ConfigMapBorderAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x0010B4A4 File Offset: 0x001096A4
		public static void CreateStaticDefaultValue()
		{
			ConfigMapBorderAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapBorderAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map.db"),
				new ValueTuple<string, object>("文件", "d.地图.xlsx"),
				new ValueTuple<string, object>("表名", "MapBorder"),
				new ValueTuple<string, object>("语句", "select BinData from `MapBorder`")
			});
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x0010B523 File Offset: 0x00109723
		public static void ResetStaticDefaultValue()
		{
			ConfigMapBorderAll.LogPair = null;
			ConfigMapBorderAll.HandleId = 0;
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x0010B531 File Offset: 0x00109731
		public static void Init()
		{
			ConfigMapBorderAll.HandleId = ConfigCommon.InitDataStatement(ConfigMapBorderAll.HandleId, "db_map.db", "select BinData from `MapBorder`");
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x0010B54C File Offset: 0x0010974C
		[NullableContext(2)]
		public static IReadOnlyList<MapBorder> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapBorderAll.HandleId, ConfigMapBorderAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MapBorder> readOnlyList = (IReadOnlyList<MapBorder>)ConfigCommon.GetConfig("MapBorderAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MapBorder> list = new List<MapBorder>();
			while (ConfigCommon.Step(ConfigMapBorderAll.HandleId, false, ConfigMapBorderAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapBorderAll.HandleId, 0, ConfigMapBorderAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMapBorderAll.HandleId, ConfigMapBorderAll.LogPair);
					return null;
				}
				MapBorder rootAsMapBorder = MapBorder.GetRootAsMapBorder(new ByteBuffer(item2));
				list.Add(rootAsMapBorder);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MapBorderAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMapBorderAll.HandleId, ConfigMapBorderAll.LogPair);
			return list;
		}

		// Token: 0x040023E0 RID: 9184
		private const string DB = "db_map.db";

		// Token: 0x040023E1 RID: 9185
		private const string FILE = "d.地图.xlsx";

		// Token: 0x040023E2 RID: 9186
		private const string TABLE = "MapBorder";

		// Token: 0x040023E3 RID: 9187
		private const string COMMAND = "select BinData from `MapBorder`";

		// Token: 0x040023E4 RID: 9188
		private const string KEY_PREFIX = "MapBorderAll";

		// Token: 0x040023E5 RID: 9189
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040023E6 RID: 9190
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000526 RID: 1318
	public class ConfigMapRangeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001EEF RID: 7919 RVA: 0x00108204 File Offset: 0x00106404
		static ConfigMapRangeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapRangeAll.CreateStaticDefaultValue), new Action(ConfigMapRangeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x00108224 File Offset: 0x00106424
		public static void CreateStaticDefaultValue()
		{
			ConfigMapRangeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapRangeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map.db"),
				new ValueTuple<string, object>("文件", "d.地图参数.xlsx"),
				new ValueTuple<string, object>("表名", "MapRange"),
				new ValueTuple<string, object>("语句", "select BinData from `MapRange`")
			});
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x001082A3 File Offset: 0x001064A3
		public static void ResetStaticDefaultValue()
		{
			ConfigMapRangeAll.LogPair = null;
			ConfigMapRangeAll.HandleId = 0;
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x001082B1 File Offset: 0x001064B1
		public static void Init()
		{
			ConfigMapRangeAll.HandleId = ConfigCommon.InitDataStatement(ConfigMapRangeAll.HandleId, "db_map.db", "select BinData from `MapRange`");
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x001082CC File Offset: 0x001064CC
		[NullableContext(2)]
		public static IReadOnlyList<MapRange> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapRangeAll.HandleId, ConfigMapRangeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MapRange> readOnlyList = (IReadOnlyList<MapRange>)ConfigCommon.GetConfig("MapRangeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MapRange> list = new List<MapRange>();
			while (ConfigCommon.Step(ConfigMapRangeAll.HandleId, false, ConfigMapRangeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapRangeAll.HandleId, 0, ConfigMapRangeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMapRangeAll.HandleId, ConfigMapRangeAll.LogPair);
					return null;
				}
				MapRange rootAsMapRange = MapRange.GetRootAsMapRange(new ByteBuffer(item2));
				list.Add(rootAsMapRange);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MapRangeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMapRangeAll.HandleId, ConfigMapRangeAll.LogPair);
			return list;
		}

		// Token: 0x040023EE RID: 9198
		private const string DB = "db_map.db";

		// Token: 0x040023EF RID: 9199
		private const string FILE = "d.地图参数.xlsx";

		// Token: 0x040023F0 RID: 9200
		private const string TABLE = "MapRange";

		// Token: 0x040023F1 RID: 9201
		private const string COMMAND = "select BinData from `MapRange`";

		// Token: 0x040023F2 RID: 9202
		private const string KEY_PREFIX = "MapRangeAll";

		// Token: 0x040023F3 RID: 9203
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040023F4 RID: 9204
		private static int HandleId;
	}
}

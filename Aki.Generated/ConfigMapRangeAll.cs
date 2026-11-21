using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200053C RID: 1340
	public class ConfigMapRangeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F73 RID: 8051 RVA: 0x0010E958 File Offset: 0x0010CB58
		static ConfigMapRangeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapRangeAll.CreateStaticDefaultValue), new Action(ConfigMapRangeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x0010E978 File Offset: 0x0010CB78
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

		// Token: 0x06001F75 RID: 8053 RVA: 0x0010E9F7 File Offset: 0x0010CBF7
		public static void ResetStaticDefaultValue()
		{
			ConfigMapRangeAll.LogPair = null;
			ConfigMapRangeAll.HandleId = 0;
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x0010EA05 File Offset: 0x0010CC05
		public static void Init()
		{
			ConfigMapRangeAll.HandleId = ConfigCommon.InitDataStatement(ConfigMapRangeAll.HandleId, "db_map.db", "select BinData from `MapRange`");
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x0010EA20 File Offset: 0x0010CC20
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

		// Token: 0x04002488 RID: 9352
		private const string DB = "db_map.db";

		// Token: 0x04002489 RID: 9353
		private const string FILE = "d.地图参数.xlsx";

		// Token: 0x0400248A RID: 9354
		private const string TABLE = "MapRange";

		// Token: 0x0400248B RID: 9355
		private const string COMMAND = "select BinData from `MapRange`";

		// Token: 0x0400248C RID: 9356
		private const string KEY_PREFIX = "MapRangeAll";

		// Token: 0x0400248D RID: 9357
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400248E RID: 9358
		private static int HandleId;
	}
}

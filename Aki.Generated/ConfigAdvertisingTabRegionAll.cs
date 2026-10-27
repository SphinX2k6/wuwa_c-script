using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200006E RID: 110
	public class ConfigAdvertisingTabRegionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000294 RID: 660 RVA: 0x00068268 File Offset: 0x00066468
		static ConfigAdvertisingTabRegionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabRegionAll.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabRegionAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00068288 File Offset: 0x00066488
		public static void CreateStaticDefaultValue()
		{
			ConfigAdvertisingTabRegionAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdvertisingTabRegionAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advertisingpage.db"),
				new ValueTuple<string, object>("文件", "x.下一版本核心内容展示.xlsx"),
				new ValueTuple<string, object>("表名", "AdvertisingTabRegion"),
				new ValueTuple<string, object>("语句", "select BinData from `AdvertisingTabRegion`")
			});
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00068307 File Offset: 0x00066507
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabRegionAll.LogPair = null;
			ConfigAdvertisingTabRegionAll.HandleId = 0;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00068315 File Offset: 0x00066515
		public static void Init()
		{
			ConfigAdvertisingTabRegionAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabRegionAll.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabRegion`");
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00068330 File Offset: 0x00066530
		[NullableContext(2)]
		public static IReadOnlyList<AdvertisingTabRegion> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdvertisingTabRegionAll.HandleId, ConfigAdvertisingTabRegionAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AdvertisingTabRegion> readOnlyList = (IReadOnlyList<AdvertisingTabRegion>)ConfigCommon.GetConfig("AdvertisingTabRegionAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AdvertisingTabRegion> list = new List<AdvertisingTabRegion>();
			while (ConfigCommon.Step(ConfigAdvertisingTabRegionAll.HandleId, false, ConfigAdvertisingTabRegionAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdvertisingTabRegionAll.HandleId, 0, ConfigAdvertisingTabRegionAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAdvertisingTabRegionAll.HandleId, ConfigAdvertisingTabRegionAll.LogPair);
					return null;
				}
				AdvertisingTabRegion rootAsAdvertisingTabRegion = AdvertisingTabRegion.GetRootAsAdvertisingTabRegion(new ByteBuffer(item2));
				list.Add(rootAsAdvertisingTabRegion);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AdvertisingTabRegionAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAdvertisingTabRegionAll.HandleId, ConfigAdvertisingTabRegionAll.LogPair);
			return list;
		}

		// Token: 0x040002E6 RID: 742
		private const string DB = "db_advertisingpage.db";

		// Token: 0x040002E7 RID: 743
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x040002E8 RID: 744
		private const string TABLE = "AdvertisingTabRegion";

		// Token: 0x040002E9 RID: 745
		private const string COMMAND = "select BinData from `AdvertisingTabRegion`";

		// Token: 0x040002EA RID: 746
		private const string KEY_PREFIX = "AdvertisingTabRegionAll";

		// Token: 0x040002EB RID: 747
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040002EC RID: 748
		private static int HandleId;
	}
}

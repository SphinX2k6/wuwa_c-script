using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000076 RID: 118
	public class ConfigAdvertisingTabRegionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002C4 RID: 708 RVA: 0x0006CB1C File Offset: 0x0006AD1C
		static ConfigAdvertisingTabRegionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabRegionAll.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabRegionAll.ResetStaticDefaultValue));
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0006CB3C File Offset: 0x0006AD3C
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

		// Token: 0x060002C6 RID: 710 RVA: 0x0006CBBB File Offset: 0x0006ADBB
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabRegionAll.LogPair = null;
			ConfigAdvertisingTabRegionAll.HandleId = 0;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0006CBC9 File Offset: 0x0006ADC9
		public static void Init()
		{
			ConfigAdvertisingTabRegionAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabRegionAll.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabRegion`");
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0006CBE4 File Offset: 0x0006ADE4
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

		// Token: 0x0400031E RID: 798
		private const string DB = "db_advertisingpage.db";

		// Token: 0x0400031F RID: 799
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x04000320 RID: 800
		private const string TABLE = "AdvertisingTabRegion";

		// Token: 0x04000321 RID: 801
		private const string COMMAND = "select BinData from `AdvertisingTabRegion`";

		// Token: 0x04000322 RID: 802
		private const string KEY_PREFIX = "AdvertisingTabRegionAll";

		// Token: 0x04000323 RID: 803
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000324 RID: 804
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000069 RID: 105
	public class ConfigAdvertisingPageInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000276 RID: 630 RVA: 0x0006B1AC File Offset: 0x000693AC
		static ConfigAdvertisingPageInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingPageInfoAll.CreateStaticDefaultValue), new Action(ConfigAdvertisingPageInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0006B1CC File Offset: 0x000693CC
		public static void CreateStaticDefaultValue()
		{
			ConfigAdvertisingPageInfoAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdvertisingPageInfoAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advertisingpage.db"),
				new ValueTuple<string, object>("文件", "x.下一版本核心内容展示.xlsx"),
				new ValueTuple<string, object>("表名", "AdvertisingPageInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `AdvertisingPageInfo`")
			});
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0006B24B File Offset: 0x0006944B
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingPageInfoAll.LogPair = null;
			ConfigAdvertisingPageInfoAll.HandleId = 0;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0006B259 File Offset: 0x00069459
		public static void Init()
		{
			ConfigAdvertisingPageInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingPageInfoAll.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingPageInfo`");
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0006B274 File Offset: 0x00069474
		[NullableContext(2)]
		public static IReadOnlyList<AdvertisingPageInfo> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdvertisingPageInfoAll.HandleId, ConfigAdvertisingPageInfoAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AdvertisingPageInfo> readOnlyList = (IReadOnlyList<AdvertisingPageInfo>)ConfigCommon.GetConfig("AdvertisingPageInfoAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AdvertisingPageInfo> list = new List<AdvertisingPageInfo>();
			while (ConfigCommon.Step(ConfigAdvertisingPageInfoAll.HandleId, false, ConfigAdvertisingPageInfoAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdvertisingPageInfoAll.HandleId, 0, ConfigAdvertisingPageInfoAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAdvertisingPageInfoAll.HandleId, ConfigAdvertisingPageInfoAll.LogPair);
					return null;
				}
				AdvertisingPageInfo rootAsAdvertisingPageInfo = AdvertisingPageInfo.GetRootAsAdvertisingPageInfo(new ByteBuffer(item2));
				list.Add(rootAsAdvertisingPageInfo);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AdvertisingPageInfoAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAdvertisingPageInfoAll.HandleId, ConfigAdvertisingPageInfoAll.LogPair);
			return list;
		}

		// Token: 0x040002C3 RID: 707
		private const string DB = "db_advertisingpage.db";

		// Token: 0x040002C4 RID: 708
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x040002C5 RID: 709
		private const string TABLE = "AdvertisingPageInfo";

		// Token: 0x040002C6 RID: 710
		private const string COMMAND = "select BinData from `AdvertisingPageInfo`";

		// Token: 0x040002C7 RID: 711
		private const string KEY_PREFIX = "AdvertisingPageInfoAll";

		// Token: 0x040002C8 RID: 712
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040002C9 RID: 713
		private static int HandleId;
	}
}

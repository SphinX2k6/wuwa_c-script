using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000061 RID: 97
	public class ConfigAdvertisingPageInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000246 RID: 582 RVA: 0x000668F8 File Offset: 0x00064AF8
		static ConfigAdvertisingPageInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingPageInfoAll.CreateStaticDefaultValue), new Action(ConfigAdvertisingPageInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00066918 File Offset: 0x00064B18
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

		// Token: 0x06000248 RID: 584 RVA: 0x00066997 File Offset: 0x00064B97
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingPageInfoAll.LogPair = null;
			ConfigAdvertisingPageInfoAll.HandleId = 0;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000669A5 File Offset: 0x00064BA5
		public static void Init()
		{
			ConfigAdvertisingPageInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingPageInfoAll.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingPageInfo`");
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000669C0 File Offset: 0x00064BC0
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

		// Token: 0x0400028B RID: 651
		private const string DB = "db_advertisingpage.db";

		// Token: 0x0400028C RID: 652
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x0400028D RID: 653
		private const string TABLE = "AdvertisingPageInfo";

		// Token: 0x0400028E RID: 654
		private const string COMMAND = "select BinData from `AdvertisingPageInfo`";

		// Token: 0x0400028F RID: 655
		private const string KEY_PREFIX = "AdvertisingPageInfoAll";

		// Token: 0x04000290 RID: 656
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000291 RID: 657
		private static int HandleId;
	}
}

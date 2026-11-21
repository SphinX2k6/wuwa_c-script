using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000074 RID: 116
	public class ConfigAdvertisingTabInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002B8 RID: 696 RVA: 0x0006C740 File Offset: 0x0006A940
		static ConfigAdvertisingTabInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabInfoAll.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0006C760 File Offset: 0x0006A960
		public static void CreateStaticDefaultValue()
		{
			ConfigAdvertisingTabInfoAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdvertisingTabInfoAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advertisingpage.db"),
				new ValueTuple<string, object>("文件", "x.下一版本核心内容展示.xlsx"),
				new ValueTuple<string, object>("表名", "AdvertisingTabInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `AdvertisingTabInfo`")
			});
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0006C7DF File Offset: 0x0006A9DF
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabInfoAll.LogPair = null;
			ConfigAdvertisingTabInfoAll.HandleId = 0;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0006C7ED File Offset: 0x0006A9ED
		public static void Init()
		{
			ConfigAdvertisingTabInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabInfoAll.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabInfo`");
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0006C808 File Offset: 0x0006AA08
		[NullableContext(2)]
		public static IReadOnlyList<AdvertisingTabInfo> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdvertisingTabInfoAll.HandleId, ConfigAdvertisingTabInfoAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AdvertisingTabInfo> readOnlyList = (IReadOnlyList<AdvertisingTabInfo>)ConfigCommon.GetConfig("AdvertisingTabInfoAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AdvertisingTabInfo> list = new List<AdvertisingTabInfo>();
			while (ConfigCommon.Step(ConfigAdvertisingTabInfoAll.HandleId, false, ConfigAdvertisingTabInfoAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdvertisingTabInfoAll.HandleId, 0, ConfigAdvertisingTabInfoAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAdvertisingTabInfoAll.HandleId, ConfigAdvertisingTabInfoAll.LogPair);
					return null;
				}
				AdvertisingTabInfo rootAsAdvertisingTabInfo = AdvertisingTabInfo.GetRootAsAdvertisingTabInfo(new ByteBuffer(item2));
				list.Add(rootAsAdvertisingTabInfo);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AdvertisingTabInfoAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAdvertisingTabInfoAll.HandleId, ConfigAdvertisingTabInfoAll.LogPair);
			return list;
		}

		// Token: 0x04000310 RID: 784
		private const string DB = "db_advertisingpage.db";

		// Token: 0x04000311 RID: 785
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x04000312 RID: 786
		private const string TABLE = "AdvertisingTabInfo";

		// Token: 0x04000313 RID: 787
		private const string COMMAND = "select BinData from `AdvertisingTabInfo`";

		// Token: 0x04000314 RID: 788
		private const string KEY_PREFIX = "AdvertisingTabInfoAll";

		// Token: 0x04000315 RID: 789
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000316 RID: 790
		private static int HandleId;
	}
}

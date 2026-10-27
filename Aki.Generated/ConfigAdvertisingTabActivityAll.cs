using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000064 RID: 100
	public class ConfigAdvertisingTabActivityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000258 RID: 600 RVA: 0x00066F1C File Offset: 0x0006511C
		static ConfigAdvertisingTabActivityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabActivityAll.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabActivityAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00066F3C File Offset: 0x0006513C
		public static void CreateStaticDefaultValue()
		{
			ConfigAdvertisingTabActivityAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdvertisingTabActivityAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advertisingpage.db"),
				new ValueTuple<string, object>("文件", "x.下一版本核心内容展示.xlsx"),
				new ValueTuple<string, object>("表名", "AdvertisingTabActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `AdvertisingTabActivity`")
			});
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00066FBB File Offset: 0x000651BB
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabActivityAll.LogPair = null;
			ConfigAdvertisingTabActivityAll.HandleId = 0;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00066FC9 File Offset: 0x000651C9
		public static void Init()
		{
			ConfigAdvertisingTabActivityAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabActivityAll.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabActivity`");
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00066FE4 File Offset: 0x000651E4
		[NullableContext(2)]
		public static IReadOnlyList<AdvertisingTabActivity> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdvertisingTabActivityAll.HandleId, ConfigAdvertisingTabActivityAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AdvertisingTabActivity> readOnlyList = (IReadOnlyList<AdvertisingTabActivity>)ConfigCommon.GetConfig("AdvertisingTabActivityAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AdvertisingTabActivity> list = new List<AdvertisingTabActivity>();
			while (ConfigCommon.Step(ConfigAdvertisingTabActivityAll.HandleId, false, ConfigAdvertisingTabActivityAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdvertisingTabActivityAll.HandleId, 0, ConfigAdvertisingTabActivityAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAdvertisingTabActivityAll.HandleId, ConfigAdvertisingTabActivityAll.LogPair);
					return null;
				}
				AdvertisingTabActivity rootAsAdvertisingTabActivity = AdvertisingTabActivity.GetRootAsAdvertisingTabActivity(new ByteBuffer(item2));
				list.Add(rootAsAdvertisingTabActivity);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AdvertisingTabActivityAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAdvertisingTabActivityAll.HandleId, ConfigAdvertisingTabActivityAll.LogPair);
			return list;
		}

		// Token: 0x040002A0 RID: 672
		private const string DB = "db_advertisingpage.db";

		// Token: 0x040002A1 RID: 673
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x040002A2 RID: 674
		private const string TABLE = "AdvertisingTabActivity";

		// Token: 0x040002A3 RID: 675
		private const string COMMAND = "select BinData from `AdvertisingTabActivity`";

		// Token: 0x040002A4 RID: 676
		private const string KEY_PREFIX = "AdvertisingTabActivityAll";

		// Token: 0x040002A5 RID: 677
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040002A6 RID: 678
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200006C RID: 108
	public class ConfigAdvertisingTabInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000288 RID: 648 RVA: 0x00067E8C File Offset: 0x0006608C
		static ConfigAdvertisingTabInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabInfoAll.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00067EAC File Offset: 0x000660AC
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

		// Token: 0x0600028A RID: 650 RVA: 0x00067F2B File Offset: 0x0006612B
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabInfoAll.LogPair = null;
			ConfigAdvertisingTabInfoAll.HandleId = 0;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00067F39 File Offset: 0x00066139
		public static void Init()
		{
			ConfigAdvertisingTabInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabInfoAll.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabInfo`");
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00067F54 File Offset: 0x00066154
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

		// Token: 0x040002D8 RID: 728
		private const string DB = "db_advertisingpage.db";

		// Token: 0x040002D9 RID: 729
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x040002DA RID: 730
		private const string TABLE = "AdvertisingTabInfo";

		// Token: 0x040002DB RID: 731
		private const string COMMAND = "select BinData from `AdvertisingTabInfo`";

		// Token: 0x040002DC RID: 732
		private const string KEY_PREFIX = "AdvertisingTabInfoAll";

		// Token: 0x040002DD RID: 733
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040002DE RID: 734
		private static int HandleId;
	}
}

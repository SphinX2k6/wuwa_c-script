using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200006C RID: 108
	public class ConfigAdvertisingTabActivityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000288 RID: 648 RVA: 0x0006B7D0 File Offset: 0x000699D0
		static ConfigAdvertisingTabActivityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabActivityAll.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabActivityAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0006B7F0 File Offset: 0x000699F0
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

		// Token: 0x0600028A RID: 650 RVA: 0x0006B86F File Offset: 0x00069A6F
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabActivityAll.LogPair = null;
			ConfigAdvertisingTabActivityAll.HandleId = 0;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0006B87D File Offset: 0x00069A7D
		public static void Init()
		{
			ConfigAdvertisingTabActivityAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabActivityAll.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabActivity`");
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0006B898 File Offset: 0x00069A98
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

		// Token: 0x040002D8 RID: 728
		private const string DB = "db_advertisingpage.db";

		// Token: 0x040002D9 RID: 729
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x040002DA RID: 730
		private const string TABLE = "AdvertisingTabActivity";

		// Token: 0x040002DB RID: 731
		private const string COMMAND = "select BinData from `AdvertisingTabActivity`";

		// Token: 0x040002DC RID: 732
		private const string KEY_PREFIX = "AdvertisingTabActivityAll";

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

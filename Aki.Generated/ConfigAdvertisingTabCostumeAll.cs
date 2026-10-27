using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000068 RID: 104
	public class ConfigAdvertisingTabCostumeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000270 RID: 624 RVA: 0x000676D4 File Offset: 0x000658D4
		static ConfigAdvertisingTabCostumeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabCostumeAll.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabCostumeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000271 RID: 625 RVA: 0x000676F4 File Offset: 0x000658F4
		public static void CreateStaticDefaultValue()
		{
			ConfigAdvertisingTabCostumeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdvertisingTabCostumeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advertisingpage.db"),
				new ValueTuple<string, object>("文件", "x.下一版本核心内容展示.xlsx"),
				new ValueTuple<string, object>("表名", "AdvertisingTabCostume"),
				new ValueTuple<string, object>("语句", "select BinData from `AdvertisingTabCostume`")
			});
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00067773 File Offset: 0x00065973
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabCostumeAll.LogPair = null;
			ConfigAdvertisingTabCostumeAll.HandleId = 0;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00067781 File Offset: 0x00065981
		public static void Init()
		{
			ConfigAdvertisingTabCostumeAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabCostumeAll.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabCostume`");
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0006779C File Offset: 0x0006599C
		[NullableContext(2)]
		public static IReadOnlyList<AdvertisingTabCostume> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdvertisingTabCostumeAll.HandleId, ConfigAdvertisingTabCostumeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AdvertisingTabCostume> readOnlyList = (IReadOnlyList<AdvertisingTabCostume>)ConfigCommon.GetConfig("AdvertisingTabCostumeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AdvertisingTabCostume> list = new List<AdvertisingTabCostume>();
			while (ConfigCommon.Step(ConfigAdvertisingTabCostumeAll.HandleId, false, ConfigAdvertisingTabCostumeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdvertisingTabCostumeAll.HandleId, 0, ConfigAdvertisingTabCostumeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAdvertisingTabCostumeAll.HandleId, ConfigAdvertisingTabCostumeAll.LogPair);
					return null;
				}
				AdvertisingTabCostume rootAsAdvertisingTabCostume = AdvertisingTabCostume.GetRootAsAdvertisingTabCostume(new ByteBuffer(item2));
				list.Add(rootAsAdvertisingTabCostume);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AdvertisingTabCostumeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAdvertisingTabCostumeAll.HandleId, ConfigAdvertisingTabCostumeAll.LogPair);
			return list;
		}

		// Token: 0x040002BC RID: 700
		private const string DB = "db_advertisingpage.db";

		// Token: 0x040002BD RID: 701
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x040002BE RID: 702
		private const string TABLE = "AdvertisingTabCostume";

		// Token: 0x040002BF RID: 703
		private const string COMMAND = "select BinData from `AdvertisingTabCostume`";

		// Token: 0x040002C0 RID: 704
		private const string KEY_PREFIX = "AdvertisingTabCostumeAll";

		// Token: 0x040002C1 RID: 705
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040002C2 RID: 706
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000070 RID: 112
	public class ConfigAdvertisingTabCostumeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002A0 RID: 672 RVA: 0x0006BF88 File Offset: 0x0006A188
		static ConfigAdvertisingTabCostumeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabCostumeAll.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabCostumeAll.ResetStaticDefaultValue));
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0006BFA8 File Offset: 0x0006A1A8
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

		// Token: 0x060002A2 RID: 674 RVA: 0x0006C027 File Offset: 0x0006A227
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabCostumeAll.LogPair = null;
			ConfigAdvertisingTabCostumeAll.HandleId = 0;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0006C035 File Offset: 0x0006A235
		public static void Init()
		{
			ConfigAdvertisingTabCostumeAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabCostumeAll.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabCostume`");
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0006C050 File Offset: 0x0006A250
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

		// Token: 0x040002F4 RID: 756
		private const string DB = "db_advertisingpage.db";

		// Token: 0x040002F5 RID: 757
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x040002F6 RID: 758
		private const string TABLE = "AdvertisingTabCostume";

		// Token: 0x040002F7 RID: 759
		private const string COMMAND = "select BinData from `AdvertisingTabCostume`";

		// Token: 0x040002F8 RID: 760
		private const string KEY_PREFIX = "AdvertisingTabCostumeAll";

		// Token: 0x040002F9 RID: 761
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040002FA RID: 762
		private static int HandleId;
	}
}

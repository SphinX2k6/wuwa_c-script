using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002AA RID: 682
	public class ConfigFarmGoldActivityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001001 RID: 4097 RVA: 0x000B3E88 File Offset: 0x000B2088
		static ConfigFarmGoldActivityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFarmGoldActivityAll.CreateStaticDefaultValue), new Action(ConfigFarmGoldActivityAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x000B3EA8 File Offset: 0x000B20A8
		public static void CreateStaticDefaultValue()
		{
			ConfigFarmGoldActivityAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFarmGoldActivityAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_farmgold.db"),
				new ValueTuple<string, object>("文件", "b.爆金币活动.xlsx"),
				new ValueTuple<string, object>("表名", "FarmGoldActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `FarmGoldActivity`")
			});
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x000B3F27 File Offset: 0x000B2127
		public static void ResetStaticDefaultValue()
		{
			ConfigFarmGoldActivityAll.LogPair = null;
			ConfigFarmGoldActivityAll.HandleId = 0;
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x000B3F35 File Offset: 0x000B2135
		public static void Init()
		{
			ConfigFarmGoldActivityAll.HandleId = ConfigCommon.InitDataStatement(ConfigFarmGoldActivityAll.HandleId, "db_farmgold.db", "select BinData from `FarmGoldActivity`");
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x000B3F50 File Offset: 0x000B2150
		[NullableContext(2)]
		public static IReadOnlyList<FarmGoldActivity> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFarmGoldActivityAll.HandleId, ConfigFarmGoldActivityAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FarmGoldActivity> readOnlyList = (IReadOnlyList<FarmGoldActivity>)ConfigCommon.GetConfig("FarmGoldActivityAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FarmGoldActivity> list = new List<FarmGoldActivity>();
			while (ConfigCommon.Step(ConfigFarmGoldActivityAll.HandleId, false, ConfigFarmGoldActivityAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFarmGoldActivityAll.HandleId, 0, ConfigFarmGoldActivityAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFarmGoldActivityAll.HandleId, ConfigFarmGoldActivityAll.LogPair);
					return null;
				}
				FarmGoldActivity rootAsFarmGoldActivity = FarmGoldActivity.GetRootAsFarmGoldActivity(new ByteBuffer(item2));
				list.Add(rootAsFarmGoldActivity);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FarmGoldActivityAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFarmGoldActivityAll.HandleId, ConfigFarmGoldActivityAll.LogPair);
			return list;
		}

		// Token: 0x0400128A RID: 4746
		private const string DB = "db_farmgold.db";

		// Token: 0x0400128B RID: 4747
		private const string FILE = "b.爆金币活动.xlsx";

		// Token: 0x0400128C RID: 4748
		private const string TABLE = "FarmGoldActivity";

		// Token: 0x0400128D RID: 4749
		private const string COMMAND = "select BinData from `FarmGoldActivity`";

		// Token: 0x0400128E RID: 4750
		private const string KEY_PREFIX = "FarmGoldActivityAll";

		// Token: 0x0400128F RID: 4751
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001290 RID: 4752
		private static int HandleId;
	}
}

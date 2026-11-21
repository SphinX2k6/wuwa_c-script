using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002BF RID: 703
	public class ConfigFarmGoldActivityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600107F RID: 4223 RVA: 0x000BA394 File Offset: 0x000B8594
		static ConfigFarmGoldActivityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFarmGoldActivityAll.CreateStaticDefaultValue), new Action(ConfigFarmGoldActivityAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x000BA3B4 File Offset: 0x000B85B4
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

		// Token: 0x06001081 RID: 4225 RVA: 0x000BA433 File Offset: 0x000B8633
		public static void ResetStaticDefaultValue()
		{
			ConfigFarmGoldActivityAll.LogPair = null;
			ConfigFarmGoldActivityAll.HandleId = 0;
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x000BA441 File Offset: 0x000B8641
		public static void Init()
		{
			ConfigFarmGoldActivityAll.HandleId = ConfigCommon.InitDataStatement(ConfigFarmGoldActivityAll.HandleId, "db_farmgold.db", "select BinData from `FarmGoldActivity`");
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x000BA45C File Offset: 0x000B865C
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

		// Token: 0x0400131D RID: 4893
		private const string DB = "db_farmgold.db";

		// Token: 0x0400131E RID: 4894
		private const string FILE = "b.爆金币活动.xlsx";

		// Token: 0x0400131F RID: 4895
		private const string TABLE = "FarmGoldActivity";

		// Token: 0x04001320 RID: 4896
		private const string COMMAND = "select BinData from `FarmGoldActivity`";

		// Token: 0x04001321 RID: 4897
		private const string KEY_PREFIX = "FarmGoldActivityAll";

		// Token: 0x04001322 RID: 4898
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001323 RID: 4899
		private static int HandleId;
	}
}

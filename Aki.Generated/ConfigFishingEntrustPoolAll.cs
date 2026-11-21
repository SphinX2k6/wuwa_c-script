using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002EC RID: 748
	public class ConfigFishingEntrustPoolAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600118D RID: 4493 RVA: 0x000C02E0 File Offset: 0x000BE4E0
		static ConfigFishingEntrustPoolAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingEntrustPoolAll.CreateStaticDefaultValue), new Action(ConfigFishingEntrustPoolAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x000C0300 File Offset: 0x000BE500
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingEntrustPoolAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingEntrustPoolAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼委托.xlsx"),
				new ValueTuple<string, object>("表名", "FishingEntrustPool"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingEntrustPool`")
			});
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x000C037F File Offset: 0x000BE57F
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingEntrustPoolAll.LogPair = null;
			ConfigFishingEntrustPoolAll.HandleId = 0;
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x000C038D File Offset: 0x000BE58D
		public static void Init()
		{
			ConfigFishingEntrustPoolAll.HandleId = ConfigCommon.InitDataStatement(ConfigFishingEntrustPoolAll.HandleId, "db_fishing.db", "select BinData from `FishingEntrustPool`");
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x000C03A8 File Offset: 0x000BE5A8
		[NullableContext(2)]
		public static IReadOnlyList<FishingEntrustPool> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingEntrustPoolAll.HandleId, ConfigFishingEntrustPoolAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FishingEntrustPool> readOnlyList = (IReadOnlyList<FishingEntrustPool>)ConfigCommon.GetConfig("FishingEntrustPoolAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FishingEntrustPool> list = new List<FishingEntrustPool>();
			while (ConfigCommon.Step(ConfigFishingEntrustPoolAll.HandleId, false, ConfigFishingEntrustPoolAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingEntrustPoolAll.HandleId, 0, ConfigFishingEntrustPoolAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFishingEntrustPoolAll.HandleId, ConfigFishingEntrustPoolAll.LogPair);
					return null;
				}
				FishingEntrustPool rootAsFishingEntrustPool = FishingEntrustPool.GetRootAsFishingEntrustPool(new ByteBuffer(item2));
				list.Add(rootAsFishingEntrustPool);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FishingEntrustPoolAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFishingEntrustPoolAll.HandleId, ConfigFishingEntrustPoolAll.LogPair);
			return list;
		}

		// Token: 0x04001458 RID: 5208
		private const string DB = "db_fishing.db";

		// Token: 0x04001459 RID: 5209
		private const string FILE = "b.捕鱼委托.xlsx";

		// Token: 0x0400145A RID: 5210
		private const string TABLE = "FishingEntrustPool";

		// Token: 0x0400145B RID: 5211
		private const string COMMAND = "select BinData from `FishingEntrustPool`";

		// Token: 0x0400145C RID: 5212
		private const string KEY_PREFIX = "FishingEntrustPoolAll";

		// Token: 0x0400145D RID: 5213
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400145E RID: 5214
		private static int HandleId;
	}
}

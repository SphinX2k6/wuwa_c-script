using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002D7 RID: 727
	public class ConfigFishingEntrustPoolAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600110F RID: 4367 RVA: 0x000B9DD4 File Offset: 0x000B7FD4
		static ConfigFishingEntrustPoolAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingEntrustPoolAll.CreateStaticDefaultValue), new Action(ConfigFishingEntrustPoolAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x000B9DF4 File Offset: 0x000B7FF4
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

		// Token: 0x06001111 RID: 4369 RVA: 0x000B9E73 File Offset: 0x000B8073
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingEntrustPoolAll.LogPair = null;
			ConfigFishingEntrustPoolAll.HandleId = 0;
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x000B9E81 File Offset: 0x000B8081
		public static void Init()
		{
			ConfigFishingEntrustPoolAll.HandleId = ConfigCommon.InitDataStatement(ConfigFishingEntrustPoolAll.HandleId, "db_fishing.db", "select BinData from `FishingEntrustPool`");
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x000B9E9C File Offset: 0x000B809C
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

		// Token: 0x040013C5 RID: 5061
		private const string DB = "db_fishing.db";

		// Token: 0x040013C6 RID: 5062
		private const string FILE = "b.捕鱼委托.xlsx";

		// Token: 0x040013C7 RID: 5063
		private const string TABLE = "FishingEntrustPool";

		// Token: 0x040013C8 RID: 5064
		private const string COMMAND = "select BinData from `FishingEntrustPool`";

		// Token: 0x040013C9 RID: 5065
		private const string KEY_PREFIX = "FishingEntrustPoolAll";

		// Token: 0x040013CA RID: 5066
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013CB RID: 5067
		private static int HandleId;
	}
}

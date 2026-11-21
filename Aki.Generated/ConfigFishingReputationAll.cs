using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002FE RID: 766
	public class ConfigFishingReputationAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011F9 RID: 4601 RVA: 0x000C2A70 File Offset: 0x000C0C70
		static ConfigFishingReputationAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingReputationAll.CreateStaticDefaultValue), new Action(ConfigFishingReputationAll.ResetStaticDefaultValue));
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x000C2A90 File Offset: 0x000C0C90
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingReputationAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingReputationAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼船坞.xlsx"),
				new ValueTuple<string, object>("表名", "FishingReputation"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingReputation`")
			});
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x000C2B0F File Offset: 0x000C0D0F
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingReputationAll.LogPair = null;
			ConfigFishingReputationAll.HandleId = 0;
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x000C2B1D File Offset: 0x000C0D1D
		public static void Init()
		{
			ConfigFishingReputationAll.HandleId = ConfigCommon.InitDataStatement(ConfigFishingReputationAll.HandleId, "db_fishing.db", "select BinData from `FishingReputation`");
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x000C2B38 File Offset: 0x000C0D38
		[NullableContext(2)]
		public static IReadOnlyList<FishingReputation> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingReputationAll.HandleId, ConfigFishingReputationAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FishingReputation> readOnlyList = (IReadOnlyList<FishingReputation>)ConfigCommon.GetConfig("FishingReputationAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FishingReputation> list = new List<FishingReputation>();
			while (ConfigCommon.Step(ConfigFishingReputationAll.HandleId, false, ConfigFishingReputationAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingReputationAll.HandleId, 0, ConfigFishingReputationAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFishingReputationAll.HandleId, ConfigFishingReputationAll.LogPair);
					return null;
				}
				FishingReputation rootAsFishingReputation = FishingReputation.GetRootAsFishingReputation(new ByteBuffer(item2));
				list.Add(rootAsFishingReputation);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FishingReputationAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFishingReputationAll.HandleId, ConfigFishingReputationAll.LogPair);
			return list;
		}

		// Token: 0x040014D6 RID: 5334
		private const string DB = "db_fishing.db";

		// Token: 0x040014D7 RID: 5335
		private const string FILE = "b.捕鱼船坞.xlsx";

		// Token: 0x040014D8 RID: 5336
		private const string TABLE = "FishingReputation";

		// Token: 0x040014D9 RID: 5337
		private const string COMMAND = "select BinData from `FishingReputation`";

		// Token: 0x040014DA RID: 5338
		private const string KEY_PREFIX = "FishingReputationAll";

		// Token: 0x040014DB RID: 5339
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014DC RID: 5340
		private static int HandleId;
	}
}

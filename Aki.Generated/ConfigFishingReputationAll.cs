using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002E9 RID: 745
	public class ConfigFishingReputationAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600117B RID: 4475 RVA: 0x000BC564 File Offset: 0x000BA764
		static ConfigFishingReputationAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingReputationAll.CreateStaticDefaultValue), new Action(ConfigFishingReputationAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x000BC584 File Offset: 0x000BA784
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

		// Token: 0x0600117D RID: 4477 RVA: 0x000BC603 File Offset: 0x000BA803
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingReputationAll.LogPair = null;
			ConfigFishingReputationAll.HandleId = 0;
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x000BC611 File Offset: 0x000BA811
		public static void Init()
		{
			ConfigFishingReputationAll.HandleId = ConfigCommon.InitDataStatement(ConfigFishingReputationAll.HandleId, "db_fishing.db", "select BinData from `FishingReputation`");
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x000BC62C File Offset: 0x000BA82C
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

		// Token: 0x04001443 RID: 5187
		private const string DB = "db_fishing.db";

		// Token: 0x04001444 RID: 5188
		private const string FILE = "b.捕鱼船坞.xlsx";

		// Token: 0x04001445 RID: 5189
		private const string TABLE = "FishingReputation";

		// Token: 0x04001446 RID: 5190
		private const string COMMAND = "select BinData from `FishingReputation`";

		// Token: 0x04001447 RID: 5191
		private const string KEY_PREFIX = "FishingReputationAll";

		// Token: 0x04001448 RID: 5192
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001449 RID: 5193
		private static int HandleId;
	}
}

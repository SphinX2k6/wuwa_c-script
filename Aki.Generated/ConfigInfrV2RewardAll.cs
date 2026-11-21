using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000450 RID: 1104
	public class ConfigInfrV2RewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019EA RID: 6634 RVA: 0x000EF9E8 File Offset: 0x000EDBE8
		static ConfigInfrV2RewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrV2RewardAll.CreateStaticDefaultValue), new Action(ConfigInfrV2RewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x000EFA08 File Offset: 0x000EDC08
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrV2RewardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrV2RewardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_villageinfr.db"),
				new ValueTuple<string, object>("文件", "j.基建V2.xlsx"),
				new ValueTuple<string, object>("表名", "InfrV2Reward"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrV2Reward`")
			});
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x000EFA87 File Offset: 0x000EDC87
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrV2RewardAll.LogPair = null;
			ConfigInfrV2RewardAll.HandleId = 0;
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x000EFA95 File Offset: 0x000EDC95
		public static void Init()
		{
			ConfigInfrV2RewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrV2RewardAll.HandleId, "db_villageinfr.db", "select BinData from `InfrV2Reward`");
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x000EFAB0 File Offset: 0x000EDCB0
		[NullableContext(2)]
		public static IReadOnlyList<InfrV2Reward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrV2RewardAll.HandleId, ConfigInfrV2RewardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<InfrV2Reward> readOnlyList = (IReadOnlyList<InfrV2Reward>)ConfigCommon.GetConfig("InfrV2RewardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<InfrV2Reward> list = new List<InfrV2Reward>();
			while (ConfigCommon.Step(ConfigInfrV2RewardAll.HandleId, false, ConfigInfrV2RewardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrV2RewardAll.HandleId, 0, ConfigInfrV2RewardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigInfrV2RewardAll.HandleId, ConfigInfrV2RewardAll.LogPair);
					return null;
				}
				InfrV2Reward rootAsInfrV2Reward = InfrV2Reward.GetRootAsInfrV2Reward(new ByteBuffer(item2));
				list.Add(rootAsInfrV2Reward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("InfrV2RewardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigInfrV2RewardAll.HandleId, ConfigInfrV2RewardAll.LogPair);
			return list;
		}

		// Token: 0x04001E14 RID: 7700
		private const string DB = "db_villageinfr.db";

		// Token: 0x04001E15 RID: 7701
		private const string FILE = "j.基建V2.xlsx";

		// Token: 0x04001E16 RID: 7702
		private const string TABLE = "InfrV2Reward";

		// Token: 0x04001E17 RID: 7703
		private const string COMMAND = "select BinData from `InfrV2Reward`";

		// Token: 0x04001E18 RID: 7704
		private const string KEY_PREFIX = "InfrV2RewardAll";

		// Token: 0x04001E19 RID: 7705
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E1A RID: 7706
		private static int HandleId;
	}
}

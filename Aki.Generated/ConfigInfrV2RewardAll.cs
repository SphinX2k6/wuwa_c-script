using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200043A RID: 1082
	public class ConfigInfrV2RewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001966 RID: 6502 RVA: 0x000E9294 File Offset: 0x000E7494
		static ConfigInfrV2RewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrV2RewardAll.CreateStaticDefaultValue), new Action(ConfigInfrV2RewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x000E92B4 File Offset: 0x000E74B4
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

		// Token: 0x06001968 RID: 6504 RVA: 0x000E9333 File Offset: 0x000E7533
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrV2RewardAll.LogPair = null;
			ConfigInfrV2RewardAll.HandleId = 0;
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x000E9341 File Offset: 0x000E7541
		public static void Init()
		{
			ConfigInfrV2RewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrV2RewardAll.HandleId, "db_villageinfr.db", "select BinData from `InfrV2Reward`");
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x000E935C File Offset: 0x000E755C
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

		// Token: 0x04001D7A RID: 7546
		private const string DB = "db_villageinfr.db";

		// Token: 0x04001D7B RID: 7547
		private const string FILE = "j.基建V2.xlsx";

		// Token: 0x04001D7C RID: 7548
		private const string TABLE = "InfrV2Reward";

		// Token: 0x04001D7D RID: 7549
		private const string COMMAND = "select BinData from `InfrV2Reward`";

		// Token: 0x04001D7E RID: 7550
		private const string KEY_PREFIX = "InfrV2RewardAll";

		// Token: 0x04001D7F RID: 7551
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D80 RID: 7552
		private static int HandleId;
	}
}

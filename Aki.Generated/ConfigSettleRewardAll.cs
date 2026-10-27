using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000909 RID: 2313
	public class ConfigSettleRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003649 RID: 13897 RVA: 0x0018C30C File Offset: 0x0018A50C
		static ConfigSettleRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSettleRewardAll.CreateStaticDefaultValue), new Action(ConfigSettleRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600364A RID: 13898 RVA: 0x0018C32C File Offset: 0x0018A52C
		public static void CreateStaticDefaultValue()
		{
			ConfigSettleRewardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSettleRewardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sprintsign.db"),
				new ValueTuple<string, object>("文件", "c.2.0春节签到.xlsx"),
				new ValueTuple<string, object>("表名", "SettleReward"),
				new ValueTuple<string, object>("语句", "select BinData from `SettleReward`")
			});
		}

		// Token: 0x0600364B RID: 13899 RVA: 0x0018C3AB File Offset: 0x0018A5AB
		public static void ResetStaticDefaultValue()
		{
			ConfigSettleRewardAll.LogPair = null;
			ConfigSettleRewardAll.HandleId = 0;
		}

		// Token: 0x0600364C RID: 13900 RVA: 0x0018C3B9 File Offset: 0x0018A5B9
		public static void Init()
		{
			ConfigSettleRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigSettleRewardAll.HandleId, "db_sprintsign.db", "select BinData from `SettleReward`");
		}

		// Token: 0x0600364D RID: 13901 RVA: 0x0018C3D4 File Offset: 0x0018A5D4
		[NullableContext(2)]
		public static IReadOnlyList<SettleReward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSettleRewardAll.HandleId, ConfigSettleRewardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SettleReward> readOnlyList = (IReadOnlyList<SettleReward>)ConfigCommon.GetConfig("SettleRewardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SettleReward> list = new List<SettleReward>();
			while (ConfigCommon.Step(ConfigSettleRewardAll.HandleId, false, ConfigSettleRewardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSettleRewardAll.HandleId, 0, ConfigSettleRewardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSettleRewardAll.HandleId, ConfigSettleRewardAll.LogPair);
					return null;
				}
				SettleReward rootAsSettleReward = SettleReward.GetRootAsSettleReward(new ByteBuffer(item2));
				list.Add(rootAsSettleReward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SettleRewardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSettleRewardAll.HandleId, ConfigSettleRewardAll.LogPair);
			return list;
		}

		// Token: 0x04003F25 RID: 16165
		private const string DB = "db_sprintsign.db";

		// Token: 0x04003F26 RID: 16166
		private const string FILE = "c.2.0春节签到.xlsx";

		// Token: 0x04003F27 RID: 16167
		private const string TABLE = "SettleReward";

		// Token: 0x04003F28 RID: 16168
		private const string COMMAND = "select BinData from `SettleReward`";

		// Token: 0x04003F29 RID: 16169
		private const string KEY_PREFIX = "SettleRewardAll";

		// Token: 0x04003F2A RID: 16170
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F2B RID: 16171
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000954 RID: 2388
	public class ConfigSettleRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600380B RID: 14347 RVA: 0x0019952C File Offset: 0x0019772C
		static ConfigSettleRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSettleRewardAll.CreateStaticDefaultValue), new Action(ConfigSettleRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600380C RID: 14348 RVA: 0x0019954C File Offset: 0x0019774C
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

		// Token: 0x0600380D RID: 14349 RVA: 0x001995CB File Offset: 0x001977CB
		public static void ResetStaticDefaultValue()
		{
			ConfigSettleRewardAll.LogPair = null;
			ConfigSettleRewardAll.HandleId = 0;
		}

		// Token: 0x0600380E RID: 14350 RVA: 0x001995D9 File Offset: 0x001977D9
		public static void Init()
		{
			ConfigSettleRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigSettleRewardAll.HandleId, "db_sprintsign.db", "select BinData from `SettleReward`");
		}

		// Token: 0x0600380F RID: 14351 RVA: 0x001995F4 File Offset: 0x001977F4
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

		// Token: 0x04004132 RID: 16690
		private const string DB = "db_sprintsign.db";

		// Token: 0x04004133 RID: 16691
		private const string FILE = "c.2.0春节签到.xlsx";

		// Token: 0x04004134 RID: 16692
		private const string TABLE = "SettleReward";

		// Token: 0x04004135 RID: 16693
		private const string COMMAND = "select BinData from `SettleReward`";

		// Token: 0x04004136 RID: 16694
		private const string KEY_PREFIX = "SettleRewardAll";

		// Token: 0x04004137 RID: 16695
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004138 RID: 16696
		private static int HandleId;
	}
}

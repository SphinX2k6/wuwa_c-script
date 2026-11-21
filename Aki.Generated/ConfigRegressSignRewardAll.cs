using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007F7 RID: 2039
	public class ConfigRegressSignRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FDC RID: 12252 RVA: 0x0016B374 File Offset: 0x00169574
		static ConfigRegressSignRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressSignRewardAll.CreateStaticDefaultValue), new Action(ConfigRegressSignRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002FDD RID: 12253 RVA: 0x0016B394 File Offset: 0x00169594
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressSignRewardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressSignRewardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressSignReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressSignReward`")
			});
		}

		// Token: 0x06002FDE RID: 12254 RVA: 0x0016B413 File Offset: 0x00169613
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressSignRewardAll.LogPair = null;
			ConfigRegressSignRewardAll.HandleId = 0;
		}

		// Token: 0x06002FDF RID: 12255 RVA: 0x0016B421 File Offset: 0x00169621
		public static void Init()
		{
			ConfigRegressSignRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigRegressSignRewardAll.HandleId, "db_regressactivity.db", "select BinData from `RegressSignReward`");
		}

		// Token: 0x06002FE0 RID: 12256 RVA: 0x0016B43C File Offset: 0x0016963C
		[NullableContext(2)]
		public static IReadOnlyList<RegressSignReward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressSignRewardAll.HandleId, ConfigRegressSignRewardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RegressSignReward> readOnlyList = (IReadOnlyList<RegressSignReward>)ConfigCommon.GetConfig("RegressSignRewardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RegressSignReward> list = new List<RegressSignReward>();
			while (ConfigCommon.Step(ConfigRegressSignRewardAll.HandleId, false, ConfigRegressSignRewardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressSignRewardAll.HandleId, 0, ConfigRegressSignRewardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRegressSignRewardAll.HandleId, ConfigRegressSignRewardAll.LogPair);
					return null;
				}
				RegressSignReward rootAsRegressSignReward = RegressSignReward.GetRootAsRegressSignReward(new ByteBuffer(item2));
				list.Add(rootAsRegressSignReward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RegressSignRewardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRegressSignRewardAll.HandleId, ConfigRegressSignRewardAll.LogPair);
			return list;
		}

		// Token: 0x040037A7 RID: 14247
		private const string DB = "db_regressactivity.db";

		// Token: 0x040037A8 RID: 14248
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x040037A9 RID: 14249
		private const string TABLE = "RegressSignReward";

		// Token: 0x040037AA RID: 14250
		private const string COMMAND = "select BinData from `RegressSignReward`";

		// Token: 0x040037AB RID: 14251
		private const string KEY_PREFIX = "RegressSignRewardAll";

		// Token: 0x040037AC RID: 14252
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040037AD RID: 14253
		private static int HandleId;
	}
}

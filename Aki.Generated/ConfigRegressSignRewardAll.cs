using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007DB RID: 2011
	public class ConfigRegressSignRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F34 RID: 12084 RVA: 0x0016408C File Offset: 0x0016228C
		static ConfigRegressSignRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressSignRewardAll.CreateStaticDefaultValue), new Action(ConfigRegressSignRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x001640AC File Offset: 0x001622AC
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

		// Token: 0x06002F36 RID: 12086 RVA: 0x0016412B File Offset: 0x0016232B
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressSignRewardAll.LogPair = null;
			ConfigRegressSignRewardAll.HandleId = 0;
		}

		// Token: 0x06002F37 RID: 12087 RVA: 0x00164139 File Offset: 0x00162339
		public static void Init()
		{
			ConfigRegressSignRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigRegressSignRewardAll.HandleId, "db_regressactivity.db", "select BinData from `RegressSignReward`");
		}

		// Token: 0x06002F38 RID: 12088 RVA: 0x00164154 File Offset: 0x00162354
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

		// Token: 0x040036E3 RID: 14051
		private const string DB = "db_regressactivity.db";

		// Token: 0x040036E4 RID: 14052
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x040036E5 RID: 14053
		private const string TABLE = "RegressSignReward";

		// Token: 0x040036E6 RID: 14054
		private const string COMMAND = "select BinData from `RegressSignReward`";

		// Token: 0x040036E7 RID: 14055
		private const string KEY_PREFIX = "RegressSignRewardAll";

		// Token: 0x040036E8 RID: 14056
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036E9 RID: 14057
		private static int HandleId;
	}
}

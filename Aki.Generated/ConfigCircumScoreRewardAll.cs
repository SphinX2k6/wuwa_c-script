using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000182 RID: 386
	public class ConfigCircumScoreRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600090D RID: 2317 RVA: 0x000903AF File Offset: 0x0008E5AF
		static ConfigCircumScoreRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCircumScoreRewardAll.CreateStaticDefaultValue), new Action(ConfigCircumScoreRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x000903D0 File Offset: 0x0008E5D0
		public static void CreateStaticDefaultValue()
		{
			ConfigCircumScoreRewardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCircumScoreRewardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_circumfluence.db"),
				new ValueTuple<string, object>("文件", "h.回流活动.xlsx"),
				new ValueTuple<string, object>("表名", "CircumScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `CircumScoreReward`")
			});
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0009044F File Offset: 0x0008E64F
		public static void ResetStaticDefaultValue()
		{
			ConfigCircumScoreRewardAll.LogPair = null;
			ConfigCircumScoreRewardAll.HandleId = 0;
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x0009045D File Offset: 0x0008E65D
		public static void Init()
		{
			ConfigCircumScoreRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigCircumScoreRewardAll.HandleId, "db_circumfluence.db", "select BinData from `CircumScoreReward`");
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00090478 File Offset: 0x0008E678
		[NullableContext(2)]
		public static IReadOnlyList<CircumScoreReward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCircumScoreRewardAll.HandleId, ConfigCircumScoreRewardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<CircumScoreReward> readOnlyList = (IReadOnlyList<CircumScoreReward>)ConfigCommon.GetConfig("CircumScoreRewardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<CircumScoreReward> list = new List<CircumScoreReward>();
			while (ConfigCommon.Step(ConfigCircumScoreRewardAll.HandleId, false, ConfigCircumScoreRewardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCircumScoreRewardAll.HandleId, 0, ConfigCircumScoreRewardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCircumScoreRewardAll.HandleId, ConfigCircumScoreRewardAll.LogPair);
					return null;
				}
				CircumScoreReward rootAsCircumScoreReward = CircumScoreReward.GetRootAsCircumScoreReward(new ByteBuffer(item2));
				list.Add(rootAsCircumScoreReward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("CircumScoreRewardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigCircumScoreRewardAll.HandleId, ConfigCircumScoreRewardAll.LogPair);
			return list;
		}

		// Token: 0x04000A72 RID: 2674
		private const string DB = "db_circumfluence.db";

		// Token: 0x04000A73 RID: 2675
		private const string FILE = "h.回流活动.xlsx";

		// Token: 0x04000A74 RID: 2676
		private const string TABLE = "CircumScoreReward";

		// Token: 0x04000A75 RID: 2677
		private const string COMMAND = "select BinData from `CircumScoreReward`";

		// Token: 0x04000A76 RID: 2678
		private const string KEY_PREFIX = "CircumScoreRewardAll";

		// Token: 0x04000A77 RID: 2679
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A78 RID: 2680
		private static int HandleId;
	}
}

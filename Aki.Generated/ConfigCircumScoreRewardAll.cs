using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000172 RID: 370
	public class ConfigCircumScoreRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008AD RID: 2221 RVA: 0x0008A853 File Offset: 0x00088A53
		static ConfigCircumScoreRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCircumScoreRewardAll.CreateStaticDefaultValue), new Action(ConfigCircumScoreRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x0008A874 File Offset: 0x00088A74
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

		// Token: 0x060008AF RID: 2223 RVA: 0x0008A8F3 File Offset: 0x00088AF3
		public static void ResetStaticDefaultValue()
		{
			ConfigCircumScoreRewardAll.LogPair = null;
			ConfigCircumScoreRewardAll.HandleId = 0;
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x0008A901 File Offset: 0x00088B01
		public static void Init()
		{
			ConfigCircumScoreRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigCircumScoreRewardAll.HandleId, "db_circumfluence.db", "select BinData from `CircumScoreReward`");
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x0008A91C File Offset: 0x00088B1C
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

		// Token: 0x04000A02 RID: 2562
		private const string DB = "db_circumfluence.db";

		// Token: 0x04000A03 RID: 2563
		private const string FILE = "h.回流活动.xlsx";

		// Token: 0x04000A04 RID: 2564
		private const string TABLE = "CircumScoreReward";

		// Token: 0x04000A05 RID: 2565
		private const string COMMAND = "select BinData from `CircumScoreReward`";

		// Token: 0x04000A06 RID: 2566
		private const string KEY_PREFIX = "CircumScoreRewardAll";

		// Token: 0x04000A07 RID: 2567
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A08 RID: 2568
		private static int HandleId;
	}
}

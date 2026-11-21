using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200010A RID: 266
	public class ConfigBlackSwordChallengeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600063D RID: 1597 RVA: 0x000809E4 File Offset: 0x0007EBE4
		static ConfigBlackSwordChallengeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackSwordChallengeAll.CreateStaticDefaultValue), new Action(ConfigBlackSwordChallengeAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00080A04 File Offset: 0x0007EC04
		public static void CreateStaticDefaultValue()
		{
			ConfigBlackSwordChallengeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBlackSwordChallengeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_blackswordchallenge.db"),
				new ValueTuple<string, object>("文件", "h.黑剑挑战.xlsx"),
				new ValueTuple<string, object>("表名", "BlackSwordChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `BlackSwordChallenge`")
			});
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00080A83 File Offset: 0x0007EC83
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackSwordChallengeAll.LogPair = null;
			ConfigBlackSwordChallengeAll.HandleId = 0;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00080A91 File Offset: 0x0007EC91
		public static void Init()
		{
			ConfigBlackSwordChallengeAll.HandleId = ConfigCommon.InitDataStatement(ConfigBlackSwordChallengeAll.HandleId, "db_blackswordchallenge.db", "select BinData from `BlackSwordChallenge`");
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00080AAC File Offset: 0x0007ECAC
		[NullableContext(2)]
		public static IReadOnlyList<BlackSwordChallenge> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBlackSwordChallengeAll.HandleId, ConfigBlackSwordChallengeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<BlackSwordChallenge> readOnlyList = (IReadOnlyList<BlackSwordChallenge>)ConfigCommon.GetConfig("BlackSwordChallengeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<BlackSwordChallenge> list = new List<BlackSwordChallenge>();
			while (ConfigCommon.Step(ConfigBlackSwordChallengeAll.HandleId, false, ConfigBlackSwordChallengeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBlackSwordChallengeAll.HandleId, 0, ConfigBlackSwordChallengeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBlackSwordChallengeAll.HandleId, ConfigBlackSwordChallengeAll.LogPair);
					return null;
				}
				BlackSwordChallenge rootAsBlackSwordChallenge = BlackSwordChallenge.GetRootAsBlackSwordChallenge(new ByteBuffer(item2));
				list.Add(rootAsBlackSwordChallenge);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BlackSwordChallengeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigBlackSwordChallengeAll.HandleId, ConfigBlackSwordChallengeAll.LogPair);
			return list;
		}

		// Token: 0x0400072A RID: 1834
		private const string DB = "db_blackswordchallenge.db";

		// Token: 0x0400072B RID: 1835
		private const string FILE = "h.黑剑挑战.xlsx";

		// Token: 0x0400072C RID: 1836
		private const string TABLE = "BlackSwordChallenge";

		// Token: 0x0400072D RID: 1837
		private const string COMMAND = "select BinData from `BlackSwordChallenge`";

		// Token: 0x0400072E RID: 1838
		private const string KEY_PREFIX = "BlackSwordChallengeAll";

		// Token: 0x0400072F RID: 1839
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000730 RID: 1840
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000FB RID: 251
	public class ConfigBlackSwordChallengeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005E3 RID: 1507 RVA: 0x0007B080 File Offset: 0x00079280
		static ConfigBlackSwordChallengeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackSwordChallengeAll.CreateStaticDefaultValue), new Action(ConfigBlackSwordChallengeAll.ResetStaticDefaultValue));
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0007B0A0 File Offset: 0x000792A0
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

		// Token: 0x060005E5 RID: 1509 RVA: 0x0007B11F File Offset: 0x0007931F
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackSwordChallengeAll.LogPair = null;
			ConfigBlackSwordChallengeAll.HandleId = 0;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0007B12D File Offset: 0x0007932D
		public static void Init()
		{
			ConfigBlackSwordChallengeAll.HandleId = ConfigCommon.InitDataStatement(ConfigBlackSwordChallengeAll.HandleId, "db_blackswordchallenge.db", "select BinData from `BlackSwordChallenge`");
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x0007B148 File Offset: 0x00079348
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

		// Token: 0x040006C1 RID: 1729
		private const string DB = "db_blackswordchallenge.db";

		// Token: 0x040006C2 RID: 1730
		private const string FILE = "h.黑剑挑战.xlsx";

		// Token: 0x040006C3 RID: 1731
		private const string TABLE = "BlackSwordChallenge";

		// Token: 0x040006C4 RID: 1732
		private const string COMMAND = "select BinData from `BlackSwordChallenge`";

		// Token: 0x040006C5 RID: 1733
		private const string KEY_PREFIX = "BlackSwordChallengeAll";

		// Token: 0x040006C6 RID: 1734
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006C7 RID: 1735
		private static int HandleId;
	}
}

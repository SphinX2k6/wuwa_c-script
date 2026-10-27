using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007B2 RID: 1970
	public class ConfigRealmBetweenChallengeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E3E RID: 11838 RVA: 0x0015EBBC File Offset: 0x0015CDBC
		static ConfigRealmBetweenChallengeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRealmBetweenChallengeAll.CreateStaticDefaultValue), new Action(ConfigRealmBetweenChallengeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002E3F RID: 11839 RVA: 0x0015EBDC File Offset: 0x0015CDDC
		public static void CreateStaticDefaultValue()
		{
			ConfigRealmBetweenChallengeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRealmBetweenChallengeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_realmbetween.db"),
				new ValueTuple<string, object>("文件", "q.千岛路书3.5.xlsx"),
				new ValueTuple<string, object>("表名", "RealmBetweenChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `RealmBetweenChallenge`")
			});
		}

		// Token: 0x06002E40 RID: 11840 RVA: 0x0015EC5B File Offset: 0x0015CE5B
		public static void ResetStaticDefaultValue()
		{
			ConfigRealmBetweenChallengeAll.LogPair = null;
			ConfigRealmBetweenChallengeAll.HandleId = 0;
		}

		// Token: 0x06002E41 RID: 11841 RVA: 0x0015EC69 File Offset: 0x0015CE69
		public static void Init()
		{
			ConfigRealmBetweenChallengeAll.HandleId = ConfigCommon.InitDataStatement(ConfigRealmBetweenChallengeAll.HandleId, "db_realmbetween.db", "select BinData from `RealmBetweenChallenge`");
		}

		// Token: 0x06002E42 RID: 11842 RVA: 0x0015EC84 File Offset: 0x0015CE84
		[NullableContext(2)]
		public static IReadOnlyList<RealmBetweenChallenge> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRealmBetweenChallengeAll.HandleId, ConfigRealmBetweenChallengeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RealmBetweenChallenge> readOnlyList = (IReadOnlyList<RealmBetweenChallenge>)ConfigCommon.GetConfig("RealmBetweenChallengeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RealmBetweenChallenge> list = new List<RealmBetweenChallenge>();
			while (ConfigCommon.Step(ConfigRealmBetweenChallengeAll.HandleId, false, ConfigRealmBetweenChallengeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRealmBetweenChallengeAll.HandleId, 0, ConfigRealmBetweenChallengeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRealmBetweenChallengeAll.HandleId, ConfigRealmBetweenChallengeAll.LogPair);
					return null;
				}
				RealmBetweenChallenge rootAsRealmBetweenChallenge = RealmBetweenChallenge.GetRootAsRealmBetweenChallenge(new ByteBuffer(item2));
				list.Add(rootAsRealmBetweenChallenge);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RealmBetweenChallengeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRealmBetweenChallengeAll.HandleId, ConfigRealmBetweenChallengeAll.LogPair);
			return list;
		}

		// Token: 0x040035C4 RID: 13764
		private const string DB = "db_realmbetween.db";

		// Token: 0x040035C5 RID: 13765
		private const string FILE = "q.千岛路书3.5.xlsx";

		// Token: 0x040035C6 RID: 13766
		private const string TABLE = "RealmBetweenChallenge";

		// Token: 0x040035C7 RID: 13767
		private const string COMMAND = "select BinData from `RealmBetweenChallenge`";

		// Token: 0x040035C8 RID: 13768
		private const string KEY_PREFIX = "RealmBetweenChallengeAll";

		// Token: 0x040035C9 RID: 13769
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035CA RID: 13770
		private static int HandleId;
	}
}

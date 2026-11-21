using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007CC RID: 1996
	public class ConfigRealmBetweenChallengeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EDA RID: 11994 RVA: 0x00165AC8 File Offset: 0x00163CC8
		static ConfigRealmBetweenChallengeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRealmBetweenChallengeAll.CreateStaticDefaultValue), new Action(ConfigRealmBetweenChallengeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002EDB RID: 11995 RVA: 0x00165AE8 File Offset: 0x00163CE8
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

		// Token: 0x06002EDC RID: 11996 RVA: 0x00165B67 File Offset: 0x00163D67
		public static void ResetStaticDefaultValue()
		{
			ConfigRealmBetweenChallengeAll.LogPair = null;
			ConfigRealmBetweenChallengeAll.HandleId = 0;
		}

		// Token: 0x06002EDD RID: 11997 RVA: 0x00165B75 File Offset: 0x00163D75
		public static void Init()
		{
			ConfigRealmBetweenChallengeAll.HandleId = ConfigCommon.InitDataStatement(ConfigRealmBetweenChallengeAll.HandleId, "db_realmbetween.db", "select BinData from `RealmBetweenChallenge`");
		}

		// Token: 0x06002EDE RID: 11998 RVA: 0x00165B90 File Offset: 0x00163D90
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

		// Token: 0x0400367A RID: 13946
		private const string DB = "db_realmbetween.db";

		// Token: 0x0400367B RID: 13947
		private const string FILE = "q.千岛路书3.5.xlsx";

		// Token: 0x0400367C RID: 13948
		private const string TABLE = "RealmBetweenChallenge";

		// Token: 0x0400367D RID: 13949
		private const string COMMAND = "select BinData from `RealmBetweenChallenge`";

		// Token: 0x0400367E RID: 13950
		private const string KEY_PREFIX = "RealmBetweenChallengeAll";

		// Token: 0x0400367F RID: 13951
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003680 RID: 13952
		private static int HandleId;
	}
}

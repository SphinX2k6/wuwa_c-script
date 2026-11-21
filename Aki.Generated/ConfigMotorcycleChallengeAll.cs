using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200058C RID: 1420
	public class ConfigMotorcycleChallengeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002155 RID: 8533 RVA: 0x0011969C File Offset: 0x0011789C
		static ConfigMotorcycleChallengeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorcycleChallengeAll.CreateStaticDefaultValue), new Action(ConfigMotorcycleChallengeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x001196BC File Offset: 0x001178BC
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorcycleChallengeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorcycleChallengeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roadbook.db"),
				new ValueTuple<string, object>("文件", "q.千岛路书3.0.xlsx"),
				new ValueTuple<string, object>("表名", "MotorcycleChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorcycleChallenge`")
			});
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x0011973B File Offset: 0x0011793B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorcycleChallengeAll.LogPair = null;
			ConfigMotorcycleChallengeAll.HandleId = 0;
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x00119749 File Offset: 0x00117949
		public static void Init()
		{
			ConfigMotorcycleChallengeAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorcycleChallengeAll.HandleId, "db_roadbook.db", "select BinData from `MotorcycleChallenge`");
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x00119764 File Offset: 0x00117964
		[NullableContext(2)]
		public static IReadOnlyList<MotorcycleChallenge> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorcycleChallengeAll.HandleId, ConfigMotorcycleChallengeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MotorcycleChallenge> readOnlyList = (IReadOnlyList<MotorcycleChallenge>)ConfigCommon.GetConfig("MotorcycleChallengeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MotorcycleChallenge> list = new List<MotorcycleChallenge>();
			while (ConfigCommon.Step(ConfigMotorcycleChallengeAll.HandleId, false, ConfigMotorcycleChallengeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorcycleChallengeAll.HandleId, 0, ConfigMotorcycleChallengeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorcycleChallengeAll.HandleId, ConfigMotorcycleChallengeAll.LogPair);
					return null;
				}
				MotorcycleChallenge rootAsMotorcycleChallenge = MotorcycleChallenge.GetRootAsMotorcycleChallenge(new ByteBuffer(item2));
				list.Add(rootAsMotorcycleChallenge);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MotorcycleChallengeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorcycleChallengeAll.HandleId, ConfigMotorcycleChallengeAll.LogPair);
			return list;
		}

		// Token: 0x040026B8 RID: 9912
		private const string DB = "db_roadbook.db";

		// Token: 0x040026B9 RID: 9913
		private const string FILE = "q.千岛路书3.0.xlsx";

		// Token: 0x040026BA RID: 9914
		private const string TABLE = "MotorcycleChallenge";

		// Token: 0x040026BB RID: 9915
		private const string COMMAND = "select BinData from `MotorcycleChallenge`";

		// Token: 0x040026BC RID: 9916
		private const string KEY_PREFIX = "MotorcycleChallengeAll";

		// Token: 0x040026BD RID: 9917
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040026BE RID: 9918
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000686 RID: 1670
	public class ConfigPhantomBattleChallengeByActivityGymId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002734 RID: 10036 RVA: 0x0013ACBC File Offset: 0x00138EBC
		static ConfigPhantomBattleChallengeByActivityGymId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleChallengeByActivityGymId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleChallengeByActivityGymId.ResetStaticDefaultValue));
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x0013ACDC File Offset: 0x00138EDC
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleChallengeByActivityGymId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleChallengeByActivityGymId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleChallenge` where ActivityId=? AND GymId=?")
			});
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x0013AD5B File Offset: 0x00138F5B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleChallengeByActivityGymId.LogPair = null;
			ConfigPhantomBattleChallengeByActivityGymId.HandleId = 0;
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x0013AD69 File Offset: 0x00138F69
		public static void Init()
		{
			ConfigPhantomBattleChallengeByActivityGymId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleChallengeByActivityGymId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleChallenge` where ActivityId=? AND GymId=?");
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x0013AD84 File Offset: 0x00138F84
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleChallenge> GetConfigList(int p0ActivityId, int p1GymId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleChallengeByActivityGymId.HandleId, ConfigPhantomBattleChallengeByActivityGymId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleChallengeByActivityGymId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1GymId);
				IReadOnlyList<PhantomBattleChallenge> readOnlyList = (IReadOnlyList<PhantomBattleChallenge>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhantomBattleChallengeByActivityGymId.LogPair.Clear();
			ConfigPhantomBattleChallengeByActivityGymId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			ConfigPhantomBattleChallengeByActivityGymId.LogPair.Add(new ValueTuple<string, object>("GymId", p1GymId));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleChallengeByActivityGymId.HandleId, 1, p0ActivityId, ConfigPhantomBattleChallengeByActivityGymId.LogPair) || !ConfigCommon.BindInt(ConfigPhantomBattleChallengeByActivityGymId.HandleId, 2, p1GymId, ConfigPhantomBattleChallengeByActivityGymId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhantomBattleChallengeByActivityGymId.HandleId, ConfigPhantomBattleChallengeByActivityGymId.LogPair);
				return null;
			}
			List<PhantomBattleChallenge> list = new List<PhantomBattleChallenge>();
			while (ConfigCommon.Step(ConfigPhantomBattleChallengeByActivityGymId.HandleId, false, ConfigPhantomBattleChallengeByActivityGymId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleChallengeByActivityGymId.HandleId, 0, ConfigPhantomBattleChallengeByActivityGymId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleChallengeByActivityGymId.HandleId, ConfigPhantomBattleChallengeByActivityGymId.LogPair);
					return null;
				}
				PhantomBattleChallenge rootAsPhantomBattleChallenge = PhantomBattleChallenge.GetRootAsPhantomBattleChallenge(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleChallenge);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleChallengeByActivityGymId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1GymId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleChallengeByActivityGymId.HandleId, ConfigPhantomBattleChallengeByActivityGymId.LogPair);
			return list;
		}

		// Token: 0x04002D90 RID: 11664
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D91 RID: 11665
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D92 RID: 11666
		private const string TABLE = "PhantomBattleChallenge";

		// Token: 0x04002D93 RID: 11667
		private const string COMMAND = "select BinData from `PhantomBattleChallenge` where ActivityId=? AND GymId=?";

		// Token: 0x04002D94 RID: 11668
		private const string KEY_PREFIX = "PhantomBattleChallengeByActivityGymId";

		// Token: 0x04002D95 RID: 11669
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D96 RID: 11670
		private static int HandleId;
	}
}

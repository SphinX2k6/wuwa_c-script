using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000670 RID: 1648
	public class ConfigPhantomBattleChallengeByGymId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026B0 RID: 9904 RVA: 0x00134707 File Offset: 0x00132907
		static ConfigPhantomBattleChallengeByGymId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleChallengeByGymId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleChallengeByGymId.ResetStaticDefaultValue));
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x00134728 File Offset: 0x00132928
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleChallengeByGymId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleChallengeByGymId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleChallenge` where GymId=?")
			});
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x001347A7 File Offset: 0x001329A7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleChallengeByGymId.LogPair = null;
			ConfigPhantomBattleChallengeByGymId.HandleId = 0;
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x001347B5 File Offset: 0x001329B5
		public static void Init()
		{
			ConfigPhantomBattleChallengeByGymId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleChallengeByGymId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleChallenge` where GymId=?");
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x001347D0 File Offset: 0x001329D0
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleChallenge> GetConfigList(int p0GymId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleChallengeByGymId.HandleId, ConfigPhantomBattleChallengeByGymId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleChallengeByGymId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GymId);
				IReadOnlyList<PhantomBattleChallenge> readOnlyList = (IReadOnlyList<PhantomBattleChallenge>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhantomBattleChallengeByGymId.LogPair.Clear();
			ConfigPhantomBattleChallengeByGymId.LogPair.Add(new ValueTuple<string, object>("GymId", p0GymId));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleChallengeByGymId.HandleId, 1, p0GymId, ConfigPhantomBattleChallengeByGymId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhantomBattleChallengeByGymId.HandleId, ConfigPhantomBattleChallengeByGymId.LogPair);
				return null;
			}
			List<PhantomBattleChallenge> list = new List<PhantomBattleChallenge>();
			while (ConfigCommon.Step(ConfigPhantomBattleChallengeByGymId.HandleId, false, ConfigPhantomBattleChallengeByGymId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleChallengeByGymId.HandleId, 0, ConfigPhantomBattleChallengeByGymId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleChallengeByGymId.HandleId, ConfigPhantomBattleChallengeByGymId.LogPair);
					return null;
				}
				PhantomBattleChallenge rootAsPhantomBattleChallenge = PhantomBattleChallenge.GetRootAsPhantomBattleChallenge(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleChallenge);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleChallengeByGymId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GymId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleChallengeByGymId.HandleId, ConfigPhantomBattleChallengeByGymId.LogPair);
			return list;
		}

		// Token: 0x04002CF6 RID: 11510
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002CF7 RID: 11511
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002CF8 RID: 11512
		private const string TABLE = "PhantomBattleChallenge";

		// Token: 0x04002CF9 RID: 11513
		private const string COMMAND = "select BinData from `PhantomBattleChallenge` where GymId=?";

		// Token: 0x04002CFA RID: 11514
		private const string KEY_PREFIX = "PhantomBattleChallengeByGymId";

		// Token: 0x04002CFB RID: 11515
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CFC RID: 11516
		private static int HandleId;
	}
}

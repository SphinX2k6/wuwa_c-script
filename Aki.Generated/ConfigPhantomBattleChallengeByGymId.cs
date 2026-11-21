using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000688 RID: 1672
	public class ConfigPhantomBattleChallengeByGymId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002740 RID: 10048 RVA: 0x0013B183 File Offset: 0x00139383
		static ConfigPhantomBattleChallengeByGymId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleChallengeByGymId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleChallengeByGymId.ResetStaticDefaultValue));
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x0013B1A4 File Offset: 0x001393A4
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

		// Token: 0x06002742 RID: 10050 RVA: 0x0013B223 File Offset: 0x00139423
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleChallengeByGymId.LogPair = null;
			ConfigPhantomBattleChallengeByGymId.HandleId = 0;
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x0013B231 File Offset: 0x00139431
		public static void Init()
		{
			ConfigPhantomBattleChallengeByGymId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleChallengeByGymId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleChallenge` where GymId=?");
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x0013B24C File Offset: 0x0013944C
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

		// Token: 0x04002D9E RID: 11678
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D9F RID: 11679
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002DA0 RID: 11680
		private const string TABLE = "PhantomBattleChallenge";

		// Token: 0x04002DA1 RID: 11681
		private const string COMMAND = "select BinData from `PhantomBattleChallenge` where GymId=?";

		// Token: 0x04002DA2 RID: 11682
		private const string KEY_PREFIX = "PhantomBattleChallengeByGymId";

		// Token: 0x04002DA3 RID: 11683
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DA4 RID: 11684
		private static int HandleId;
	}
}

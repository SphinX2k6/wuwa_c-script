using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200066E RID: 1646
	public class ConfigPhantomBattleChallengeByActivityGymId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026A4 RID: 9892 RVA: 0x00134240 File Offset: 0x00132440
		static ConfigPhantomBattleChallengeByActivityGymId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleChallengeByActivityGymId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleChallengeByActivityGymId.ResetStaticDefaultValue));
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x00134260 File Offset: 0x00132460
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

		// Token: 0x060026A6 RID: 9894 RVA: 0x001342DF File Offset: 0x001324DF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleChallengeByActivityGymId.LogPair = null;
			ConfigPhantomBattleChallengeByActivityGymId.HandleId = 0;
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x001342ED File Offset: 0x001324ED
		public static void Init()
		{
			ConfigPhantomBattleChallengeByActivityGymId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleChallengeByActivityGymId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleChallenge` where ActivityId=? AND GymId=?");
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x00134308 File Offset: 0x00132508
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

		// Token: 0x04002CE8 RID: 11496
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002CE9 RID: 11497
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002CEA RID: 11498
		private const string TABLE = "PhantomBattleChallenge";

		// Token: 0x04002CEB RID: 11499
		private const string COMMAND = "select BinData from `PhantomBattleChallenge` where ActivityId=? AND GymId=?";

		// Token: 0x04002CEC RID: 11500
		private const string KEY_PREFIX = "PhantomBattleChallengeByActivityGymId";

		// Token: 0x04002CED RID: 11501
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CEE RID: 11502
		private static int HandleId;
	}
}

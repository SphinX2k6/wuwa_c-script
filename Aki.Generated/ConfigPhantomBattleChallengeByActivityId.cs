using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200066F RID: 1647
	public class ConfigPhantomBattleChallengeByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026AA RID: 9898 RVA: 0x001344CF File Offset: 0x001326CF
		static ConfigPhantomBattleChallengeByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleChallengeByActivityId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleChallengeByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060026AB RID: 9899 RVA: 0x001344F0 File Offset: 0x001326F0
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleChallengeByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleChallengeByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleChallenge` where ActivityId=?")
			});
		}

		// Token: 0x060026AC RID: 9900 RVA: 0x0013456F File Offset: 0x0013276F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleChallengeByActivityId.LogPair = null;
			ConfigPhantomBattleChallengeByActivityId.HandleId = 0;
		}

		// Token: 0x060026AD RID: 9901 RVA: 0x0013457D File Offset: 0x0013277D
		public static void Init()
		{
			ConfigPhantomBattleChallengeByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleChallengeByActivityId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleChallenge` where ActivityId=?");
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x00134598 File Offset: 0x00132798
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleChallenge> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleChallengeByActivityId.HandleId, ConfigPhantomBattleChallengeByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleChallengeByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<PhantomBattleChallenge> readOnlyList = (IReadOnlyList<PhantomBattleChallenge>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhantomBattleChallengeByActivityId.LogPair.Clear();
			ConfigPhantomBattleChallengeByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleChallengeByActivityId.HandleId, 1, p0ActivityId, ConfigPhantomBattleChallengeByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhantomBattleChallengeByActivityId.HandleId, ConfigPhantomBattleChallengeByActivityId.LogPair);
				return null;
			}
			List<PhantomBattleChallenge> list = new List<PhantomBattleChallenge>();
			while (ConfigCommon.Step(ConfigPhantomBattleChallengeByActivityId.HandleId, false, ConfigPhantomBattleChallengeByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleChallengeByActivityId.HandleId, 0, ConfigPhantomBattleChallengeByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleChallengeByActivityId.HandleId, ConfigPhantomBattleChallengeByActivityId.LogPair);
					return null;
				}
				PhantomBattleChallenge rootAsPhantomBattleChallenge = PhantomBattleChallenge.GetRootAsPhantomBattleChallenge(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleChallenge);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleChallengeByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleChallengeByActivityId.HandleId, ConfigPhantomBattleChallengeByActivityId.LogPair);
			return list;
		}

		// Token: 0x04002CEF RID: 11503
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002CF0 RID: 11504
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002CF1 RID: 11505
		private const string TABLE = "PhantomBattleChallenge";

		// Token: 0x04002CF2 RID: 11506
		private const string COMMAND = "select BinData from `PhantomBattleChallenge` where ActivityId=?";

		// Token: 0x04002CF3 RID: 11507
		private const string KEY_PREFIX = "PhantomBattleChallengeByActivityId";

		// Token: 0x04002CF4 RID: 11508
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CF5 RID: 11509
		private static int HandleId;
	}
}

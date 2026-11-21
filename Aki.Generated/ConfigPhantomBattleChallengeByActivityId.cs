using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000687 RID: 1671
	public class ConfigPhantomBattleChallengeByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600273A RID: 10042 RVA: 0x0013AF4B File Offset: 0x0013914B
		static ConfigPhantomBattleChallengeByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleChallengeByActivityId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleChallengeByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x0013AF6C File Offset: 0x0013916C
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

		// Token: 0x0600273C RID: 10044 RVA: 0x0013AFEB File Offset: 0x001391EB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleChallengeByActivityId.LogPair = null;
			ConfigPhantomBattleChallengeByActivityId.HandleId = 0;
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x0013AFF9 File Offset: 0x001391F9
		public static void Init()
		{
			ConfigPhantomBattleChallengeByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleChallengeByActivityId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleChallenge` where ActivityId=?");
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x0013B014 File Offset: 0x00139214
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

		// Token: 0x04002D97 RID: 11671
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D98 RID: 11672
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D99 RID: 11673
		private const string TABLE = "PhantomBattleChallenge";

		// Token: 0x04002D9A RID: 11674
		private const string COMMAND = "select BinData from `PhantomBattleChallenge` where ActivityId=?";

		// Token: 0x04002D9B RID: 11675
		private const string KEY_PREFIX = "PhantomBattleChallengeByActivityId";

		// Token: 0x04002D9C RID: 11676
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D9D RID: 11677
		private static int HandleId;
	}
}

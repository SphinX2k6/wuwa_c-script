using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200068A RID: 1674
	public class ConfigPhantomBattleChallengeByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600274C RID: 10060 RVA: 0x0013B604 File Offset: 0x00139804
		static ConfigPhantomBattleChallengeByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleChallengeByMapId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleChallengeByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x0013B624 File Offset: 0x00139824
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleChallengeByMapId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleChallengeByMapId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleChallenge` where MapId=?")
			});
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x0013B6A3 File Offset: 0x001398A3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleChallengeByMapId.LogPair = null;
			ConfigPhantomBattleChallengeByMapId.HandleId = 0;
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x0013B6B1 File Offset: 0x001398B1
		public static void Init()
		{
			ConfigPhantomBattleChallengeByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleChallengeByMapId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleChallenge` where MapId=?");
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x0013B6CC File Offset: 0x001398CC
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleChallenge> GetConfigList(int p0MapId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleChallengeByMapId.HandleId, ConfigPhantomBattleChallengeByMapId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleChallengeByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				IReadOnlyList<PhantomBattleChallenge> readOnlyList = (IReadOnlyList<PhantomBattleChallenge>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhantomBattleChallengeByMapId.LogPair.Clear();
			ConfigPhantomBattleChallengeByMapId.LogPair.Add(new ValueTuple<string, object>("MapId", p0MapId));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleChallengeByMapId.HandleId, 1, p0MapId, ConfigPhantomBattleChallengeByMapId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhantomBattleChallengeByMapId.HandleId, ConfigPhantomBattleChallengeByMapId.LogPair);
				return null;
			}
			List<PhantomBattleChallenge> list = new List<PhantomBattleChallenge>();
			while (ConfigCommon.Step(ConfigPhantomBattleChallengeByMapId.HandleId, false, ConfigPhantomBattleChallengeByMapId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleChallengeByMapId.HandleId, 0, ConfigPhantomBattleChallengeByMapId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleChallengeByMapId.HandleId, ConfigPhantomBattleChallengeByMapId.LogPair);
					return null;
				}
				PhantomBattleChallenge rootAsPhantomBattleChallenge = PhantomBattleChallenge.GetRootAsPhantomBattleChallenge(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleChallenge);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleChallengeByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleChallengeByMapId.HandleId, ConfigPhantomBattleChallengeByMapId.LogPair);
			return list;
		}

		// Token: 0x04002DAC RID: 11692
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002DAD RID: 11693
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002DAE RID: 11694
		private const string TABLE = "PhantomBattleChallenge";

		// Token: 0x04002DAF RID: 11695
		private const string COMMAND = "select BinData from `PhantomBattleChallenge` where MapId=?";

		// Token: 0x04002DB0 RID: 11696
		private const string KEY_PREFIX = "PhantomBattleChallengeByMapId";

		// Token: 0x04002DB1 RID: 11697
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DB2 RID: 11698
		private static int HandleId;
	}
}

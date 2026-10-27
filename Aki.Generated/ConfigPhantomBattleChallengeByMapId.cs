using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000672 RID: 1650
	public class ConfigPhantomBattleChallengeByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026BC RID: 9916 RVA: 0x00134B88 File Offset: 0x00132D88
		static ConfigPhantomBattleChallengeByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleChallengeByMapId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleChallengeByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x00134BA8 File Offset: 0x00132DA8
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

		// Token: 0x060026BE RID: 9918 RVA: 0x00134C27 File Offset: 0x00132E27
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleChallengeByMapId.LogPair = null;
			ConfigPhantomBattleChallengeByMapId.HandleId = 0;
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x00134C35 File Offset: 0x00132E35
		public static void Init()
		{
			ConfigPhantomBattleChallengeByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleChallengeByMapId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleChallenge` where MapId=?");
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x00134C50 File Offset: 0x00132E50
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

		// Token: 0x04002D04 RID: 11524
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D05 RID: 11525
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D06 RID: 11526
		private const string TABLE = "PhantomBattleChallenge";

		// Token: 0x04002D07 RID: 11527
		private const string COMMAND = "select BinData from `PhantomBattleChallenge` where MapId=?";

		// Token: 0x04002D08 RID: 11528
		private const string KEY_PREFIX = "PhantomBattleChallengeByMapId";

		// Token: 0x04002D09 RID: 11529
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D0A RID: 11530
		private static int HandleId;
	}
}

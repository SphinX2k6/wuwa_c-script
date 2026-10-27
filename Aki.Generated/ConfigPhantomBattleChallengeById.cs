using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000671 RID: 1649
	public class ConfigPhantomBattleChallengeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026B6 RID: 9910 RVA: 0x0013493F File Offset: 0x00132B3F
		static ConfigPhantomBattleChallengeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleChallengeById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleChallengeById.ResetStaticDefaultValue));
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x00134960 File Offset: 0x00132B60
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleChallengeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleChallengeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleChallenge` where Id=?")
			});
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x001349DF File Offset: 0x00132BDF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleChallengeById.LogPair = null;
			ConfigPhantomBattleChallengeById.HandleId = 0;
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x001349ED File Offset: 0x00132BED
		public static void Init()
		{
			ConfigPhantomBattleChallengeById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleChallengeById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleChallenge` where Id=?");
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x00134A08 File Offset: 0x00132C08
		public static PhantomBattleChallenge? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleChallengeById.HandleId, ConfigPhantomBattleChallengeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleChallenge?(PhantomBattleChallenge.GetRootAsPhantomBattleChallenge(configBuffer));
				}
			}
			ConfigPhantomBattleChallengeById.LogPair.Clear();
			ConfigPhantomBattleChallengeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleChallengeById.HandleId, 1, p0Id, ConfigPhantomBattleChallengeById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleChallengeById.HandleId, true, ConfigPhantomBattleChallengeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleChallengeById.HandleId, ConfigPhantomBattleChallengeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleChallengeById.HandleId, 0, ConfigPhantomBattleChallengeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleChallengeById.HandleId, ConfigPhantomBattleChallengeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleChallenge rootAsPhantomBattleChallenge = PhantomBattleChallenge.GetRootAsPhantomBattleChallenge(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleChallengeById.HandleId, ConfigPhantomBattleChallengeById.LogPair);
			return new PhantomBattleChallenge?(rootAsPhantomBattleChallenge);
		}

		// Token: 0x04002CFD RID: 11517
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002CFE RID: 11518
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002CFF RID: 11519
		private const string TABLE = "PhantomBattleChallenge";

		// Token: 0x04002D00 RID: 11520
		private const string COMMAND = "select BinData from `PhantomBattleChallenge` where Id=?";

		// Token: 0x04002D01 RID: 11521
		private const string KEY_PREFIX = "PhantomBattleChallengeById";

		// Token: 0x04002D02 RID: 11522
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D03 RID: 11523
		private static int HandleId;
	}
}

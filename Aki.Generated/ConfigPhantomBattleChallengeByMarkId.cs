using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000673 RID: 1651
	public class ConfigPhantomBattleChallengeByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026C2 RID: 9922 RVA: 0x00134DBF File Offset: 0x00132FBF
		static ConfigPhantomBattleChallengeByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleChallengeByMarkId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleChallengeByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x00134DE0 File Offset: 0x00132FE0
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleChallengeByMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleChallengeByMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleChallenge` where MarkId=?")
			});
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x00134E5F File Offset: 0x0013305F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleChallengeByMarkId.LogPair = null;
			ConfigPhantomBattleChallengeByMarkId.HandleId = 0;
		}

		// Token: 0x060026C5 RID: 9925 RVA: 0x00134E6D File Offset: 0x0013306D
		public static void Init()
		{
			ConfigPhantomBattleChallengeByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleChallengeByMarkId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleChallenge` where MarkId=?");
		}

		// Token: 0x060026C6 RID: 9926 RVA: 0x00134E88 File Offset: 0x00133088
		public static PhantomBattleChallenge? GetConfig(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleChallengeByMarkId.HandleId, ConfigPhantomBattleChallengeByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleChallengeByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleChallenge?(PhantomBattleChallenge.GetRootAsPhantomBattleChallenge(configBuffer));
				}
			}
			ConfigPhantomBattleChallengeByMarkId.LogPair.Clear();
			ConfigPhantomBattleChallengeByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleChallengeByMarkId.HandleId, 1, p0MarkId, ConfigPhantomBattleChallengeByMarkId.LogPair) || ConfigCommon.Step(ConfigPhantomBattleChallengeByMarkId.HandleId, true, ConfigPhantomBattleChallengeByMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleChallengeByMarkId.HandleId, ConfigPhantomBattleChallengeByMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleChallengeByMarkId.HandleId, 0, ConfigPhantomBattleChallengeByMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleChallengeByMarkId.HandleId, ConfigPhantomBattleChallengeByMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleChallenge rootAsPhantomBattleChallenge = PhantomBattleChallenge.GetRootAsPhantomBattleChallenge(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleChallengeByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleChallengeByMarkId.HandleId, ConfigPhantomBattleChallengeByMarkId.LogPair);
			return new PhantomBattleChallenge?(rootAsPhantomBattleChallenge);
		}

		// Token: 0x04002D0B RID: 11531
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D0C RID: 11532
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D0D RID: 11533
		private const string TABLE = "PhantomBattleChallenge";

		// Token: 0x04002D0E RID: 11534
		private const string COMMAND = "select BinData from `PhantomBattleChallenge` where MarkId=?";

		// Token: 0x04002D0F RID: 11535
		private const string KEY_PREFIX = "PhantomBattleChallengeByMarkId";

		// Token: 0x04002D10 RID: 11536
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D11 RID: 11537
		private static int HandleId;
	}
}

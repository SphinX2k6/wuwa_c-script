using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000689 RID: 1673
	public class ConfigPhantomBattleChallengeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002746 RID: 10054 RVA: 0x0013B3BB File Offset: 0x001395BB
		static ConfigPhantomBattleChallengeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleChallengeById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleChallengeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x0013B3DC File Offset: 0x001395DC
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

		// Token: 0x06002748 RID: 10056 RVA: 0x0013B45B File Offset: 0x0013965B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleChallengeById.LogPair = null;
			ConfigPhantomBattleChallengeById.HandleId = 0;
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x0013B469 File Offset: 0x00139669
		public static void Init()
		{
			ConfigPhantomBattleChallengeById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleChallengeById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleChallenge` where Id=?");
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x0013B484 File Offset: 0x00139684
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

		// Token: 0x04002DA5 RID: 11685
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002DA6 RID: 11686
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002DA7 RID: 11687
		private const string TABLE = "PhantomBattleChallenge";

		// Token: 0x04002DA8 RID: 11688
		private const string COMMAND = "select BinData from `PhantomBattleChallenge` where Id=?";

		// Token: 0x04002DA9 RID: 11689
		private const string KEY_PREFIX = "PhantomBattleChallengeById";

		// Token: 0x04002DAA RID: 11690
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DAB RID: 11691
		private static int HandleId;
	}
}

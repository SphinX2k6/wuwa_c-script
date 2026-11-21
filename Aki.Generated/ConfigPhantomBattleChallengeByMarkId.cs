using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200068B RID: 1675
	public class ConfigPhantomBattleChallengeByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002752 RID: 10066 RVA: 0x0013B83B File Offset: 0x00139A3B
		static ConfigPhantomBattleChallengeByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleChallengeByMarkId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleChallengeByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x0013B85C File Offset: 0x00139A5C
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

		// Token: 0x06002754 RID: 10068 RVA: 0x0013B8DB File Offset: 0x00139ADB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleChallengeByMarkId.LogPair = null;
			ConfigPhantomBattleChallengeByMarkId.HandleId = 0;
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x0013B8E9 File Offset: 0x00139AE9
		public static void Init()
		{
			ConfigPhantomBattleChallengeByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleChallengeByMarkId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleChallenge` where MarkId=?");
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x0013B904 File Offset: 0x00139B04
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

		// Token: 0x04002DB3 RID: 11699
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002DB4 RID: 11700
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002DB5 RID: 11701
		private const string TABLE = "PhantomBattleChallenge";

		// Token: 0x04002DB6 RID: 11702
		private const string COMMAND = "select BinData from `PhantomBattleChallenge` where MarkId=?";

		// Token: 0x04002DB7 RID: 11703
		private const string KEY_PREFIX = "PhantomBattleChallengeByMarkId";

		// Token: 0x04002DB8 RID: 11704
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DB9 RID: 11705
		private static int HandleId;
	}
}

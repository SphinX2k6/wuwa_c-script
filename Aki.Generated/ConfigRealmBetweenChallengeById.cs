using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007B3 RID: 1971
	public class ConfigRealmBetweenChallengeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E44 RID: 11844 RVA: 0x0015ED4F File Offset: 0x0015CF4F
		static ConfigRealmBetweenChallengeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRealmBetweenChallengeById.CreateStaticDefaultValue), new Action(ConfigRealmBetweenChallengeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002E45 RID: 11845 RVA: 0x0015ED70 File Offset: 0x0015CF70
		public static void CreateStaticDefaultValue()
		{
			ConfigRealmBetweenChallengeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRealmBetweenChallengeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_realmbetween.db"),
				new ValueTuple<string, object>("文件", "q.千岛路书3.5.xlsx"),
				new ValueTuple<string, object>("表名", "RealmBetweenChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `RealmBetweenChallenge` where Id=?")
			});
		}

		// Token: 0x06002E46 RID: 11846 RVA: 0x0015EDEF File Offset: 0x0015CFEF
		public static void ResetStaticDefaultValue()
		{
			ConfigRealmBetweenChallengeById.LogPair = null;
			ConfigRealmBetweenChallengeById.HandleId = 0;
		}

		// Token: 0x06002E47 RID: 11847 RVA: 0x0015EDFD File Offset: 0x0015CFFD
		public static void Init()
		{
			ConfigRealmBetweenChallengeById.HandleId = ConfigCommon.InitDataStatement(ConfigRealmBetweenChallengeById.HandleId, "db_realmbetween.db", "select BinData from `RealmBetweenChallenge` where Id=?");
		}

		// Token: 0x06002E48 RID: 11848 RVA: 0x0015EE18 File Offset: 0x0015D018
		public static RealmBetweenChallenge? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRealmBetweenChallengeById.HandleId, ConfigRealmBetweenChallengeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RealmBetweenChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RealmBetweenChallenge?(RealmBetweenChallenge.GetRootAsRealmBetweenChallenge(configBuffer));
				}
			}
			ConfigRealmBetweenChallengeById.LogPair.Clear();
			ConfigRealmBetweenChallengeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRealmBetweenChallengeById.HandleId, 1, p0Id, ConfigRealmBetweenChallengeById.LogPair) || ConfigCommon.Step(ConfigRealmBetweenChallengeById.HandleId, true, ConfigRealmBetweenChallengeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRealmBetweenChallengeById.HandleId, ConfigRealmBetweenChallengeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRealmBetweenChallengeById.HandleId, 0, ConfigRealmBetweenChallengeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRealmBetweenChallengeById.HandleId, ConfigRealmBetweenChallengeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RealmBetweenChallenge rootAsRealmBetweenChallenge = RealmBetweenChallenge.GetRootAsRealmBetweenChallenge(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RealmBetweenChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRealmBetweenChallengeById.HandleId, ConfigRealmBetweenChallengeById.LogPair);
			return new RealmBetweenChallenge?(rootAsRealmBetweenChallenge);
		}

		// Token: 0x040035CB RID: 13771
		private const string DB = "db_realmbetween.db";

		// Token: 0x040035CC RID: 13772
		private const string FILE = "q.千岛路书3.5.xlsx";

		// Token: 0x040035CD RID: 13773
		private const string TABLE = "RealmBetweenChallenge";

		// Token: 0x040035CE RID: 13774
		private const string COMMAND = "select BinData from `RealmBetweenChallenge` where Id=?";

		// Token: 0x040035CF RID: 13775
		private const string KEY_PREFIX = "RealmBetweenChallengeById";

		// Token: 0x040035D0 RID: 13776
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035D1 RID: 13777
		private static int HandleId;
	}
}

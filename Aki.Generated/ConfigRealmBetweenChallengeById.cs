using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007CD RID: 1997
	public class ConfigRealmBetweenChallengeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EE0 RID: 12000 RVA: 0x00165C5B File Offset: 0x00163E5B
		static ConfigRealmBetweenChallengeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRealmBetweenChallengeById.CreateStaticDefaultValue), new Action(ConfigRealmBetweenChallengeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002EE1 RID: 12001 RVA: 0x00165C7C File Offset: 0x00163E7C
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

		// Token: 0x06002EE2 RID: 12002 RVA: 0x00165CFB File Offset: 0x00163EFB
		public static void ResetStaticDefaultValue()
		{
			ConfigRealmBetweenChallengeById.LogPair = null;
			ConfigRealmBetweenChallengeById.HandleId = 0;
		}

		// Token: 0x06002EE3 RID: 12003 RVA: 0x00165D09 File Offset: 0x00163F09
		public static void Init()
		{
			ConfigRealmBetweenChallengeById.HandleId = ConfigCommon.InitDataStatement(ConfigRealmBetweenChallengeById.HandleId, "db_realmbetween.db", "select BinData from `RealmBetweenChallenge` where Id=?");
		}

		// Token: 0x06002EE4 RID: 12004 RVA: 0x00165D24 File Offset: 0x00163F24
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

		// Token: 0x04003681 RID: 13953
		private const string DB = "db_realmbetween.db";

		// Token: 0x04003682 RID: 13954
		private const string FILE = "q.千岛路书3.5.xlsx";

		// Token: 0x04003683 RID: 13955
		private const string TABLE = "RealmBetweenChallenge";

		// Token: 0x04003684 RID: 13956
		private const string COMMAND = "select BinData from `RealmBetweenChallenge` where Id=?";

		// Token: 0x04003685 RID: 13957
		private const string KEY_PREFIX = "RealmBetweenChallengeById";

		// Token: 0x04003686 RID: 13958
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003687 RID: 13959
		private static int HandleId;
	}
}

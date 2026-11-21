using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000373 RID: 883
	public class ConfigFunPlayActivityChallengeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014B7 RID: 5303 RVA: 0x000D211F File Offset: 0x000D031F
		static ConfigFunPlayActivityChallengeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFunPlayActivityChallengeById.CreateStaticDefaultValue), new Action(ConfigFunPlayActivityChallengeById.ResetStaticDefaultValue));
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x000D2140 File Offset: 0x000D0340
		public static void CreateStaticDefaultValue()
		{
			ConfigFunPlayActivityChallengeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFunPlayActivityChallengeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activityfunplay.db"),
				new ValueTuple<string, object>("文件", "q.趣味玩法活动.xlsx"),
				new ValueTuple<string, object>("表名", "FunPlayActivityChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `FunPlayActivityChallenge` where Id=?")
			});
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x000D21BF File Offset: 0x000D03BF
		public static void ResetStaticDefaultValue()
		{
			ConfigFunPlayActivityChallengeById.LogPair = null;
			ConfigFunPlayActivityChallengeById.HandleId = 0;
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x000D21CD File Offset: 0x000D03CD
		public static void Init()
		{
			ConfigFunPlayActivityChallengeById.HandleId = ConfigCommon.InitDataStatement(ConfigFunPlayActivityChallengeById.HandleId, "db_activityfunplay.db", "select BinData from `FunPlayActivityChallenge` where Id=?");
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x000D21E8 File Offset: 0x000D03E8
		public static FunPlayActivityChallenge? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFunPlayActivityChallengeById.HandleId, ConfigFunPlayActivityChallengeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FunPlayActivityChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FunPlayActivityChallenge?(FunPlayActivityChallenge.GetRootAsFunPlayActivityChallenge(configBuffer));
				}
			}
			ConfigFunPlayActivityChallengeById.LogPair.Clear();
			ConfigFunPlayActivityChallengeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFunPlayActivityChallengeById.HandleId, 1, p0Id, ConfigFunPlayActivityChallengeById.LogPair) || ConfigCommon.Step(ConfigFunPlayActivityChallengeById.HandleId, true, ConfigFunPlayActivityChallengeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFunPlayActivityChallengeById.HandleId, ConfigFunPlayActivityChallengeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFunPlayActivityChallengeById.HandleId, 0, ConfigFunPlayActivityChallengeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFunPlayActivityChallengeById.HandleId, ConfigFunPlayActivityChallengeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FunPlayActivityChallenge rootAsFunPlayActivityChallenge = FunPlayActivityChallenge.GetRootAsFunPlayActivityChallenge(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FunPlayActivityChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFunPlayActivityChallengeById.HandleId, ConfigFunPlayActivityChallengeById.LogPair);
			return new FunPlayActivityChallenge?(rootAsFunPlayActivityChallenge);
		}

		// Token: 0x04001809 RID: 6153
		private const string DB = "db_activityfunplay.db";

		// Token: 0x0400180A RID: 6154
		private const string FILE = "q.趣味玩法活动.xlsx";

		// Token: 0x0400180B RID: 6155
		private const string TABLE = "FunPlayActivityChallenge";

		// Token: 0x0400180C RID: 6156
		private const string COMMAND = "select BinData from `FunPlayActivityChallenge` where Id=?";

		// Token: 0x0400180D RID: 6157
		private const string KEY_PREFIX = "FunPlayActivityChallengeById";

		// Token: 0x0400180E RID: 6158
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400180F RID: 6159
		private static int HandleId;
	}
}

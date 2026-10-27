using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200035E RID: 862
	public class ConfigFunPlayActivityChallengeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001439 RID: 5177 RVA: 0x000CBC13 File Offset: 0x000C9E13
		static ConfigFunPlayActivityChallengeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFunPlayActivityChallengeById.CreateStaticDefaultValue), new Action(ConfigFunPlayActivityChallengeById.ResetStaticDefaultValue));
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x000CBC34 File Offset: 0x000C9E34
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

		// Token: 0x0600143B RID: 5179 RVA: 0x000CBCB3 File Offset: 0x000C9EB3
		public static void ResetStaticDefaultValue()
		{
			ConfigFunPlayActivityChallengeById.LogPair = null;
			ConfigFunPlayActivityChallengeById.HandleId = 0;
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x000CBCC1 File Offset: 0x000C9EC1
		public static void Init()
		{
			ConfigFunPlayActivityChallengeById.HandleId = ConfigCommon.InitDataStatement(ConfigFunPlayActivityChallengeById.HandleId, "db_activityfunplay.db", "select BinData from `FunPlayActivityChallenge` where Id=?");
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x000CBCDC File Offset: 0x000C9EDC
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

		// Token: 0x04001776 RID: 6006
		private const string DB = "db_activityfunplay.db";

		// Token: 0x04001777 RID: 6007
		private const string FILE = "q.趣味玩法活动.xlsx";

		// Token: 0x04001778 RID: 6008
		private const string TABLE = "FunPlayActivityChallenge";

		// Token: 0x04001779 RID: 6009
		private const string COMMAND = "select BinData from `FunPlayActivityChallenge` where Id=?";

		// Token: 0x0400177A RID: 6010
		private const string KEY_PREFIX = "FunPlayActivityChallengeById";

		// Token: 0x0400177B RID: 6011
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400177C RID: 6012
		private static int HandleId;
	}
}

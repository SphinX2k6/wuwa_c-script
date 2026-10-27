using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000FC RID: 252
	public class ConfigBlackSwordChallengeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005E9 RID: 1513 RVA: 0x0007B213 File Offset: 0x00079413
		static ConfigBlackSwordChallengeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackSwordChallengeById.CreateStaticDefaultValue), new Action(ConfigBlackSwordChallengeById.ResetStaticDefaultValue));
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0007B234 File Offset: 0x00079434
		public static void CreateStaticDefaultValue()
		{
			ConfigBlackSwordChallengeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBlackSwordChallengeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_blackswordchallenge.db"),
				new ValueTuple<string, object>("文件", "h.黑剑挑战.xlsx"),
				new ValueTuple<string, object>("表名", "BlackSwordChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `BlackSwordChallenge` where Id=?")
			});
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0007B2B3 File Offset: 0x000794B3
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackSwordChallengeById.LogPair = null;
			ConfigBlackSwordChallengeById.HandleId = 0;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x0007B2C1 File Offset: 0x000794C1
		public static void Init()
		{
			ConfigBlackSwordChallengeById.HandleId = ConfigCommon.InitDataStatement(ConfigBlackSwordChallengeById.HandleId, "db_blackswordchallenge.db", "select BinData from `BlackSwordChallenge` where Id=?");
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0007B2DC File Offset: 0x000794DC
		public static BlackSwordChallenge? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBlackSwordChallengeById.HandleId, ConfigBlackSwordChallengeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BlackSwordChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BlackSwordChallenge?(BlackSwordChallenge.GetRootAsBlackSwordChallenge(configBuffer));
				}
			}
			ConfigBlackSwordChallengeById.LogPair.Clear();
			ConfigBlackSwordChallengeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBlackSwordChallengeById.HandleId, 1, p0Id, ConfigBlackSwordChallengeById.LogPair) || ConfigCommon.Step(ConfigBlackSwordChallengeById.HandleId, true, ConfigBlackSwordChallengeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBlackSwordChallengeById.HandleId, ConfigBlackSwordChallengeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBlackSwordChallengeById.HandleId, 0, ConfigBlackSwordChallengeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBlackSwordChallengeById.HandleId, ConfigBlackSwordChallengeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BlackSwordChallenge rootAsBlackSwordChallenge = BlackSwordChallenge.GetRootAsBlackSwordChallenge(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BlackSwordChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBlackSwordChallengeById.HandleId, ConfigBlackSwordChallengeById.LogPair);
			return new BlackSwordChallenge?(rootAsBlackSwordChallenge);
		}

		// Token: 0x040006C8 RID: 1736
		private const string DB = "db_blackswordchallenge.db";

		// Token: 0x040006C9 RID: 1737
		private const string FILE = "h.黑剑挑战.xlsx";

		// Token: 0x040006CA RID: 1738
		private const string TABLE = "BlackSwordChallenge";

		// Token: 0x040006CB RID: 1739
		private const string COMMAND = "select BinData from `BlackSwordChallenge` where Id=?";

		// Token: 0x040006CC RID: 1740
		private const string KEY_PREFIX = "BlackSwordChallengeById";

		// Token: 0x040006CD RID: 1741
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006CE RID: 1742
		private static int HandleId;
	}
}

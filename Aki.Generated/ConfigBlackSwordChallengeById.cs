using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200010B RID: 267
	public class ConfigBlackSwordChallengeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000643 RID: 1603 RVA: 0x00080B77 File Offset: 0x0007ED77
		static ConfigBlackSwordChallengeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackSwordChallengeById.CreateStaticDefaultValue), new Action(ConfigBlackSwordChallengeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00080B98 File Offset: 0x0007ED98
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

		// Token: 0x06000645 RID: 1605 RVA: 0x00080C17 File Offset: 0x0007EE17
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackSwordChallengeById.LogPair = null;
			ConfigBlackSwordChallengeById.HandleId = 0;
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00080C25 File Offset: 0x0007EE25
		public static void Init()
		{
			ConfigBlackSwordChallengeById.HandleId = ConfigCommon.InitDataStatement(ConfigBlackSwordChallengeById.HandleId, "db_blackswordchallenge.db", "select BinData from `BlackSwordChallenge` where Id=?");
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00080C40 File Offset: 0x0007EE40
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

		// Token: 0x04000731 RID: 1841
		private const string DB = "db_blackswordchallenge.db";

		// Token: 0x04000732 RID: 1842
		private const string FILE = "h.黑剑挑战.xlsx";

		// Token: 0x04000733 RID: 1843
		private const string TABLE = "BlackSwordChallenge";

		// Token: 0x04000734 RID: 1844
		private const string COMMAND = "select BinData from `BlackSwordChallenge` where Id=?";

		// Token: 0x04000735 RID: 1845
		private const string KEY_PREFIX = "BlackSwordChallengeById";

		// Token: 0x04000736 RID: 1846
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000737 RID: 1847
		private static int HandleId;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001AA RID: 426
	public class ConfigCorniceChallengeByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009FF RID: 2559 RVA: 0x00092100 File Offset: 0x00090300
		static ConfigCorniceChallengeByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCorniceChallengeByMarkId.CreateStaticDefaultValue), new Action(ConfigCorniceChallengeByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00092120 File Offset: 0x00090320
		public static void CreateStaticDefaultValue()
		{
			ConfigCorniceChallengeByMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCorniceChallengeByMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cornicechallenge.db"),
				new ValueTuple<string, object>("文件", "s.数据收集异常活动.xlsx"),
				new ValueTuple<string, object>("表名", "CorniceChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `CorniceChallenge` where MarkId=?")
			});
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x0009219F File Offset: 0x0009039F
		public static void ResetStaticDefaultValue()
		{
			ConfigCorniceChallengeByMarkId.LogPair = null;
			ConfigCorniceChallengeByMarkId.HandleId = 0;
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x000921AD File Offset: 0x000903AD
		public static void Init()
		{
			ConfigCorniceChallengeByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigCorniceChallengeByMarkId.HandleId, "db_cornicechallenge.db", "select BinData from `CorniceChallenge` where MarkId=?");
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x000921C8 File Offset: 0x000903C8
		public static CorniceChallenge? GetConfig(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCorniceChallengeByMarkId.HandleId, ConfigCorniceChallengeByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CorniceChallengeByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CorniceChallenge?(CorniceChallenge.GetRootAsCorniceChallenge(configBuffer));
				}
			}
			ConfigCorniceChallengeByMarkId.LogPair.Clear();
			ConfigCorniceChallengeByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigCorniceChallengeByMarkId.HandleId, 1, p0MarkId, ConfigCorniceChallengeByMarkId.LogPair) || ConfigCommon.Step(ConfigCorniceChallengeByMarkId.HandleId, true, ConfigCorniceChallengeByMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCorniceChallengeByMarkId.HandleId, ConfigCorniceChallengeByMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCorniceChallengeByMarkId.HandleId, 0, ConfigCorniceChallengeByMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCorniceChallengeByMarkId.HandleId, ConfigCorniceChallengeByMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CorniceChallenge rootAsCorniceChallenge = CorniceChallenge.GetRootAsCorniceChallenge(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CorniceChallengeByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCorniceChallengeByMarkId.HandleId, ConfigCorniceChallengeByMarkId.LogPair);
			return new CorniceChallenge?(rootAsCorniceChallenge);
		}

		// Token: 0x04000B8A RID: 2954
		private const string DB = "db_cornicechallenge.db";

		// Token: 0x04000B8B RID: 2955
		private const string FILE = "s.数据收集异常活动.xlsx";

		// Token: 0x04000B8C RID: 2956
		private const string TABLE = "CorniceChallenge";

		// Token: 0x04000B8D RID: 2957
		private const string COMMAND = "select BinData from `CorniceChallenge` where MarkId=?";

		// Token: 0x04000B8E RID: 2958
		private const string KEY_PREFIX = "CorniceChallengeByMarkId";

		// Token: 0x04000B8F RID: 2959
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B90 RID: 2960
		private static int HandleId;
	}
}

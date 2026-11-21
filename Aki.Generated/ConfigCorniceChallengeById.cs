using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001BB RID: 443
	public class ConfigCorniceChallengeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A65 RID: 2661 RVA: 0x00097DF0 File Offset: 0x00095FF0
		static ConfigCorniceChallengeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCorniceChallengeById.CreateStaticDefaultValue), new Action(ConfigCorniceChallengeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00097E10 File Offset: 0x00096010
		public static void CreateStaticDefaultValue()
		{
			ConfigCorniceChallengeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCorniceChallengeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cornicechallenge.db"),
				new ValueTuple<string, object>("文件", "s.数据收集异常活动.xlsx"),
				new ValueTuple<string, object>("表名", "CorniceChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `CorniceChallenge` where Id=?")
			});
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00097E8F File Offset: 0x0009608F
		public static void ResetStaticDefaultValue()
		{
			ConfigCorniceChallengeById.LogPair = null;
			ConfigCorniceChallengeById.HandleId = 0;
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00097E9D File Offset: 0x0009609D
		public static void Init()
		{
			ConfigCorniceChallengeById.HandleId = ConfigCommon.InitDataStatement(ConfigCorniceChallengeById.HandleId, "db_cornicechallenge.db", "select BinData from `CorniceChallenge` where Id=?");
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00097EB8 File Offset: 0x000960B8
		public static CorniceChallenge? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCorniceChallengeById.HandleId, ConfigCorniceChallengeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CorniceChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CorniceChallenge?(CorniceChallenge.GetRootAsCorniceChallenge(configBuffer));
				}
			}
			ConfigCorniceChallengeById.LogPair.Clear();
			ConfigCorniceChallengeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCorniceChallengeById.HandleId, 1, p0Id, ConfigCorniceChallengeById.LogPair) || ConfigCommon.Step(ConfigCorniceChallengeById.HandleId, true, ConfigCorniceChallengeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCorniceChallengeById.HandleId, ConfigCorniceChallengeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCorniceChallengeById.HandleId, 0, ConfigCorniceChallengeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCorniceChallengeById.HandleId, ConfigCorniceChallengeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CorniceChallenge rootAsCorniceChallenge = CorniceChallenge.GetRootAsCorniceChallenge(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CorniceChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCorniceChallengeById.HandleId, ConfigCorniceChallengeById.LogPair);
			return new CorniceChallenge?(rootAsCorniceChallenge);
		}

		// Token: 0x04000C01 RID: 3073
		private const string DB = "db_cornicechallenge.db";

		// Token: 0x04000C02 RID: 3074
		private const string FILE = "s.数据收集异常活动.xlsx";

		// Token: 0x04000C03 RID: 3075
		private const string TABLE = "CorniceChallenge";

		// Token: 0x04000C04 RID: 3076
		private const string COMMAND = "select BinData from `CorniceChallenge` where Id=?";

		// Token: 0x04000C05 RID: 3077
		private const string KEY_PREFIX = "CorniceChallengeById";

		// Token: 0x04000C06 RID: 3078
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C07 RID: 3079
		private static int HandleId;
	}
}

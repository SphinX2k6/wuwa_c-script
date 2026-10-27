using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000636 RID: 1590
	public class ConfigParkourChallengeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002554 RID: 9556 RVA: 0x0012CB48 File Offset: 0x0012AD48
		static ConfigParkourChallengeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigParkourChallengeById.CreateStaticDefaultValue), new Action(ConfigParkourChallengeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x0012CB68 File Offset: 0x0012AD68
		public static void CreateStaticDefaultValue()
		{
			ConfigParkourChallengeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigParkourChallengeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_parkourchallenge.db"),
				new ValueTuple<string, object>("文件", "p.跑酷挑战.xlsx"),
				new ValueTuple<string, object>("表名", "ParkourChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `ParkourChallenge` where Id=?")
			});
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x0012CBE7 File Offset: 0x0012ADE7
		public static void ResetStaticDefaultValue()
		{
			ConfigParkourChallengeById.LogPair = null;
			ConfigParkourChallengeById.HandleId = 0;
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x0012CBF5 File Offset: 0x0012ADF5
		public static void Init()
		{
			ConfigParkourChallengeById.HandleId = ConfigCommon.InitDataStatement(ConfigParkourChallengeById.HandleId, "db_parkourchallenge.db", "select BinData from `ParkourChallenge` where Id=?");
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x0012CC10 File Offset: 0x0012AE10
		public static ParkourChallenge? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigParkourChallengeById.HandleId, ConfigParkourChallengeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ParkourChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ParkourChallenge?(ParkourChallenge.GetRootAsParkourChallenge(configBuffer));
				}
			}
			ConfigParkourChallengeById.LogPair.Clear();
			ConfigParkourChallengeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigParkourChallengeById.HandleId, 1, p0Id, ConfigParkourChallengeById.LogPair) || ConfigCommon.Step(ConfigParkourChallengeById.HandleId, true, ConfigParkourChallengeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigParkourChallengeById.HandleId, ConfigParkourChallengeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigParkourChallengeById.HandleId, 0, ConfigParkourChallengeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigParkourChallengeById.HandleId, ConfigParkourChallengeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ParkourChallenge rootAsParkourChallenge = ParkourChallenge.GetRootAsParkourChallenge(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ParkourChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigParkourChallengeById.HandleId, ConfigParkourChallengeById.LogPair);
			return new ParkourChallenge?(rootAsParkourChallenge);
		}

		// Token: 0x04002B60 RID: 11104
		private const string DB = "db_parkourchallenge.db";

		// Token: 0x04002B61 RID: 11105
		private const string FILE = "p.跑酷挑战.xlsx";

		// Token: 0x04002B62 RID: 11106
		private const string TABLE = "ParkourChallenge";

		// Token: 0x04002B63 RID: 11107
		private const string COMMAND = "select BinData from `ParkourChallenge` where Id=?";

		// Token: 0x04002B64 RID: 11108
		private const string KEY_PREFIX = "ParkourChallengeById";

		// Token: 0x04002B65 RID: 11109
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B66 RID: 11110
		private static int HandleId;
	}
}

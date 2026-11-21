using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200064E RID: 1614
	public class ConfigParkourChallengeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025E4 RID: 9700 RVA: 0x001335C4 File Offset: 0x001317C4
		static ConfigParkourChallengeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigParkourChallengeById.CreateStaticDefaultValue), new Action(ConfigParkourChallengeById.ResetStaticDefaultValue));
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x001335E4 File Offset: 0x001317E4
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

		// Token: 0x060025E6 RID: 9702 RVA: 0x00133663 File Offset: 0x00131863
		public static void ResetStaticDefaultValue()
		{
			ConfigParkourChallengeById.LogPair = null;
			ConfigParkourChallengeById.HandleId = 0;
		}

		// Token: 0x060025E7 RID: 9703 RVA: 0x00133671 File Offset: 0x00131871
		public static void Init()
		{
			ConfigParkourChallengeById.HandleId = ConfigCommon.InitDataStatement(ConfigParkourChallengeById.HandleId, "db_parkourchallenge.db", "select BinData from `ParkourChallenge` where Id=?");
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x0013368C File Offset: 0x0013188C
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

		// Token: 0x04002C08 RID: 11272
		private const string DB = "db_parkourchallenge.db";

		// Token: 0x04002C09 RID: 11273
		private const string FILE = "p.跑酷挑战.xlsx";

		// Token: 0x04002C0A RID: 11274
		private const string TABLE = "ParkourChallenge";

		// Token: 0x04002C0B RID: 11275
		private const string COMMAND = "select BinData from `ParkourChallenge` where Id=?";

		// Token: 0x04002C0C RID: 11276
		private const string KEY_PREFIX = "ParkourChallengeById";

		// Token: 0x04002C0D RID: 11277
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C0E RID: 11278
		private static int HandleId;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200058D RID: 1421
	public class ConfigMotorcycleChallengeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600215B RID: 8539 RVA: 0x0011982F File Offset: 0x00117A2F
		static ConfigMotorcycleChallengeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorcycleChallengeById.CreateStaticDefaultValue), new Action(ConfigMotorcycleChallengeById.ResetStaticDefaultValue));
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x00119850 File Offset: 0x00117A50
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorcycleChallengeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorcycleChallengeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roadbook.db"),
				new ValueTuple<string, object>("文件", "q.千岛路书3.0.xlsx"),
				new ValueTuple<string, object>("表名", "MotorcycleChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorcycleChallenge` where Id=?")
			});
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x001198CF File Offset: 0x00117ACF
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorcycleChallengeById.LogPair = null;
			ConfigMotorcycleChallengeById.HandleId = 0;
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x001198DD File Offset: 0x00117ADD
		public static void Init()
		{
			ConfigMotorcycleChallengeById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorcycleChallengeById.HandleId, "db_roadbook.db", "select BinData from `MotorcycleChallenge` where Id=?");
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x001198F8 File Offset: 0x00117AF8
		public static MotorcycleChallenge? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorcycleChallengeById.HandleId, ConfigMotorcycleChallengeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorcycleChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorcycleChallenge?(MotorcycleChallenge.GetRootAsMotorcycleChallenge(configBuffer));
				}
			}
			ConfigMotorcycleChallengeById.LogPair.Clear();
			ConfigMotorcycleChallengeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorcycleChallengeById.HandleId, 1, p0Id, ConfigMotorcycleChallengeById.LogPair) || ConfigCommon.Step(ConfigMotorcycleChallengeById.HandleId, true, ConfigMotorcycleChallengeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorcycleChallengeById.HandleId, ConfigMotorcycleChallengeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorcycleChallengeById.HandleId, 0, ConfigMotorcycleChallengeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorcycleChallengeById.HandleId, ConfigMotorcycleChallengeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorcycleChallenge rootAsMotorcycleChallenge = MotorcycleChallenge.GetRootAsMotorcycleChallenge(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorcycleChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorcycleChallengeById.HandleId, ConfigMotorcycleChallengeById.LogPair);
			return new MotorcycleChallenge?(rootAsMotorcycleChallenge);
		}

		// Token: 0x040026BF RID: 9919
		private const string DB = "db_roadbook.db";

		// Token: 0x040026C0 RID: 9920
		private const string FILE = "q.千岛路书3.0.xlsx";

		// Token: 0x040026C1 RID: 9921
		private const string TABLE = "MotorcycleChallenge";

		// Token: 0x040026C2 RID: 9922
		private const string COMMAND = "select BinData from `MotorcycleChallenge` where Id=?";

		// Token: 0x040026C3 RID: 9923
		private const string KEY_PREFIX = "MotorcycleChallengeById";

		// Token: 0x040026C4 RID: 9924
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040026C5 RID: 9925
		private static int HandleId;
	}
}

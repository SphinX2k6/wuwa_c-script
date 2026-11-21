using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002C8 RID: 712
	public class ConfigFarmGoldScoreById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010B5 RID: 4277 RVA: 0x000BB637 File Offset: 0x000B9837
		static ConfigFarmGoldScoreById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFarmGoldScoreById.CreateStaticDefaultValue), new Action(ConfigFarmGoldScoreById.ResetStaticDefaultValue));
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x000BB658 File Offset: 0x000B9858
		public static void CreateStaticDefaultValue()
		{
			ConfigFarmGoldScoreById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFarmGoldScoreById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_farmgold.db"),
				new ValueTuple<string, object>("文件", "b.爆金币活动.xlsx"),
				new ValueTuple<string, object>("表名", "FarmGoldScore"),
				new ValueTuple<string, object>("语句", "select BinData from `FarmGoldScore` where Id=?")
			});
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x000BB6D7 File Offset: 0x000B98D7
		public static void ResetStaticDefaultValue()
		{
			ConfigFarmGoldScoreById.LogPair = null;
			ConfigFarmGoldScoreById.HandleId = 0;
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x000BB6E5 File Offset: 0x000B98E5
		public static void Init()
		{
			ConfigFarmGoldScoreById.HandleId = ConfigCommon.InitDataStatement(ConfigFarmGoldScoreById.HandleId, "db_farmgold.db", "select BinData from `FarmGoldScore` where Id=?");
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x000BB700 File Offset: 0x000B9900
		public static FarmGoldScore? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFarmGoldScoreById.HandleId, ConfigFarmGoldScoreById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FarmGoldScoreById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FarmGoldScore?(FarmGoldScore.GetRootAsFarmGoldScore(configBuffer));
				}
			}
			ConfigFarmGoldScoreById.LogPair.Clear();
			ConfigFarmGoldScoreById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFarmGoldScoreById.HandleId, 1, p0Id, ConfigFarmGoldScoreById.LogPair) || ConfigCommon.Step(ConfigFarmGoldScoreById.HandleId, true, ConfigFarmGoldScoreById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFarmGoldScoreById.HandleId, ConfigFarmGoldScoreById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFarmGoldScoreById.HandleId, 0, ConfigFarmGoldScoreById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFarmGoldScoreById.HandleId, ConfigFarmGoldScoreById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FarmGoldScore rootAsFarmGoldScore = FarmGoldScore.GetRootAsFarmGoldScore(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FarmGoldScoreById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFarmGoldScoreById.HandleId, ConfigFarmGoldScoreById.LogPair);
			return new FarmGoldScore?(rootAsFarmGoldScore);
		}

		// Token: 0x0400135C RID: 4956
		private const string DB = "db_farmgold.db";

		// Token: 0x0400135D RID: 4957
		private const string FILE = "b.爆金币活动.xlsx";

		// Token: 0x0400135E RID: 4958
		private const string TABLE = "FarmGoldScore";

		// Token: 0x0400135F RID: 4959
		private const string COMMAND = "select BinData from `FarmGoldScore` where Id=?";

		// Token: 0x04001360 RID: 4960
		private const string KEY_PREFIX = "FarmGoldScoreById";

		// Token: 0x04001361 RID: 4961
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001362 RID: 4962
		private static int HandleId;
	}
}

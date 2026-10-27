using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002AE RID: 686
	public class ConfigFarmGoldDifficultyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001019 RID: 4121 RVA: 0x000B4687 File Offset: 0x000B2887
		static ConfigFarmGoldDifficultyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFarmGoldDifficultyById.CreateStaticDefaultValue), new Action(ConfigFarmGoldDifficultyById.ResetStaticDefaultValue));
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x000B46A8 File Offset: 0x000B28A8
		public static void CreateStaticDefaultValue()
		{
			ConfigFarmGoldDifficultyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFarmGoldDifficultyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_farmgold.db"),
				new ValueTuple<string, object>("文件", "b.爆金币活动.xlsx"),
				new ValueTuple<string, object>("表名", "FarmGoldDifficulty"),
				new ValueTuple<string, object>("语句", "select BinData from `FarmGoldDifficulty` where Id=?")
			});
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x000B4727 File Offset: 0x000B2927
		public static void ResetStaticDefaultValue()
		{
			ConfigFarmGoldDifficultyById.LogPair = null;
			ConfigFarmGoldDifficultyById.HandleId = 0;
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x000B4735 File Offset: 0x000B2935
		public static void Init()
		{
			ConfigFarmGoldDifficultyById.HandleId = ConfigCommon.InitDataStatement(ConfigFarmGoldDifficultyById.HandleId, "db_farmgold.db", "select BinData from `FarmGoldDifficulty` where Id=?");
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x000B4750 File Offset: 0x000B2950
		public static FarmGoldDifficulty? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFarmGoldDifficultyById.HandleId, ConfigFarmGoldDifficultyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FarmGoldDifficultyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FarmGoldDifficulty?(FarmGoldDifficulty.GetRootAsFarmGoldDifficulty(configBuffer));
				}
			}
			ConfigFarmGoldDifficultyById.LogPair.Clear();
			ConfigFarmGoldDifficultyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFarmGoldDifficultyById.HandleId, 1, p0Id, ConfigFarmGoldDifficultyById.LogPair) || ConfigCommon.Step(ConfigFarmGoldDifficultyById.HandleId, true, ConfigFarmGoldDifficultyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFarmGoldDifficultyById.HandleId, ConfigFarmGoldDifficultyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFarmGoldDifficultyById.HandleId, 0, ConfigFarmGoldDifficultyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFarmGoldDifficultyById.HandleId, ConfigFarmGoldDifficultyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FarmGoldDifficulty rootAsFarmGoldDifficulty = FarmGoldDifficulty.GetRootAsFarmGoldDifficulty(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FarmGoldDifficultyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFarmGoldDifficultyById.HandleId, ConfigFarmGoldDifficultyById.LogPair);
			return new FarmGoldDifficulty?(rootAsFarmGoldDifficulty);
		}

		// Token: 0x040012A6 RID: 4774
		private const string DB = "db_farmgold.db";

		// Token: 0x040012A7 RID: 4775
		private const string FILE = "b.爆金币活动.xlsx";

		// Token: 0x040012A8 RID: 4776
		private const string TABLE = "FarmGoldDifficulty";

		// Token: 0x040012A9 RID: 4777
		private const string COMMAND = "select BinData from `FarmGoldDifficulty` where Id=?";

		// Token: 0x040012AA RID: 4778
		private const string KEY_PREFIX = "FarmGoldDifficultyById";

		// Token: 0x040012AB RID: 4779
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040012AC RID: 4780
		private static int HandleId;
	}
}

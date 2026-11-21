using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002C3 RID: 707
	public class ConfigFarmGoldDifficultyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001097 RID: 4247 RVA: 0x000BAB93 File Offset: 0x000B8D93
		static ConfigFarmGoldDifficultyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFarmGoldDifficultyById.CreateStaticDefaultValue), new Action(ConfigFarmGoldDifficultyById.ResetStaticDefaultValue));
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x000BABB4 File Offset: 0x000B8DB4
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

		// Token: 0x06001099 RID: 4249 RVA: 0x000BAC33 File Offset: 0x000B8E33
		public static void ResetStaticDefaultValue()
		{
			ConfigFarmGoldDifficultyById.LogPair = null;
			ConfigFarmGoldDifficultyById.HandleId = 0;
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x000BAC41 File Offset: 0x000B8E41
		public static void Init()
		{
			ConfigFarmGoldDifficultyById.HandleId = ConfigCommon.InitDataStatement(ConfigFarmGoldDifficultyById.HandleId, "db_farmgold.db", "select BinData from `FarmGoldDifficulty` where Id=?");
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x000BAC5C File Offset: 0x000B8E5C
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

		// Token: 0x04001339 RID: 4921
		private const string DB = "db_farmgold.db";

		// Token: 0x0400133A RID: 4922
		private const string FILE = "b.爆金币活动.xlsx";

		// Token: 0x0400133B RID: 4923
		private const string TABLE = "FarmGoldDifficulty";

		// Token: 0x0400133C RID: 4924
		private const string COMMAND = "select BinData from `FarmGoldDifficulty` where Id=?";

		// Token: 0x0400133D RID: 4925
		private const string KEY_PREFIX = "FarmGoldDifficultyById";

		// Token: 0x0400133E RID: 4926
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400133F RID: 4927
		private static int HandleId;
	}
}

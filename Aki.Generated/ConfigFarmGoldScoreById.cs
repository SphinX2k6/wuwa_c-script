using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002B3 RID: 691
	public class ConfigFarmGoldScoreById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001037 RID: 4151 RVA: 0x000B512B File Offset: 0x000B332B
		static ConfigFarmGoldScoreById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFarmGoldScoreById.CreateStaticDefaultValue), new Action(ConfigFarmGoldScoreById.ResetStaticDefaultValue));
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x000B514C File Offset: 0x000B334C
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

		// Token: 0x06001039 RID: 4153 RVA: 0x000B51CB File Offset: 0x000B33CB
		public static void ResetStaticDefaultValue()
		{
			ConfigFarmGoldScoreById.LogPair = null;
			ConfigFarmGoldScoreById.HandleId = 0;
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x000B51D9 File Offset: 0x000B33D9
		public static void Init()
		{
			ConfigFarmGoldScoreById.HandleId = ConfigCommon.InitDataStatement(ConfigFarmGoldScoreById.HandleId, "db_farmgold.db", "select BinData from `FarmGoldScore` where Id=?");
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x000B51F4 File Offset: 0x000B33F4
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

		// Token: 0x040012C9 RID: 4809
		private const string DB = "db_farmgold.db";

		// Token: 0x040012CA RID: 4810
		private const string FILE = "b.爆金币活动.xlsx";

		// Token: 0x040012CB RID: 4811
		private const string TABLE = "FarmGoldScore";

		// Token: 0x040012CC RID: 4812
		private const string COMMAND = "select BinData from `FarmGoldScore` where Id=?";

		// Token: 0x040012CD RID: 4813
		private const string KEY_PREFIX = "FarmGoldScoreById";

		// Token: 0x040012CE RID: 4814
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040012CF RID: 4815
		private static int HandleId;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000823 RID: 2083
	public class ConfigRiskHarvestBuffRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030E4 RID: 12516 RVA: 0x0017112B File Offset: 0x0016F32B
		static ConfigRiskHarvestBuffRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestBuffRewardById.CreateStaticDefaultValue), new Action(ConfigRiskHarvestBuffRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x0017114C File Offset: 0x0016F34C
		public static void CreateStaticDefaultValue()
		{
			ConfigRiskHarvestBuffRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRiskHarvestBuffRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_riskharvest.db"),
				new ValueTuple<string, object>("文件", "g.割草冒险活动.xlsx"),
				new ValueTuple<string, object>("表名", "RiskHarvestBuffReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RiskHarvestBuffReward` where Id = ?")
			});
		}

		// Token: 0x060030E6 RID: 12518 RVA: 0x001711CB File Offset: 0x0016F3CB
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestBuffRewardById.LogPair = null;
			ConfigRiskHarvestBuffRewardById.HandleId = 0;
		}

		// Token: 0x060030E7 RID: 12519 RVA: 0x001711D9 File Offset: 0x0016F3D9
		public static void Init()
		{
			ConfigRiskHarvestBuffRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestBuffRewardById.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestBuffReward` where Id = ?");
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x001711F4 File Offset: 0x0016F3F4
		public static RiskHarvestBuffReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRiskHarvestBuffRewardById.HandleId, ConfigRiskHarvestBuffRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RiskHarvestBuffRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RiskHarvestBuffReward?(RiskHarvestBuffReward.GetRootAsRiskHarvestBuffReward(configBuffer));
				}
			}
			ConfigRiskHarvestBuffRewardById.LogPair.Clear();
			ConfigRiskHarvestBuffRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRiskHarvestBuffRewardById.HandleId, 1, p0Id, ConfigRiskHarvestBuffRewardById.LogPair) || ConfigCommon.Step(ConfigRiskHarvestBuffRewardById.HandleId, true, ConfigRiskHarvestBuffRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRiskHarvestBuffRewardById.HandleId, ConfigRiskHarvestBuffRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRiskHarvestBuffRewardById.HandleId, 0, ConfigRiskHarvestBuffRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRiskHarvestBuffRewardById.HandleId, ConfigRiskHarvestBuffRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RiskHarvestBuffReward rootAsRiskHarvestBuffReward = RiskHarvestBuffReward.GetRootAsRiskHarvestBuffReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RiskHarvestBuffRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRiskHarvestBuffRewardById.HandleId, ConfigRiskHarvestBuffRewardById.LogPair);
			return new RiskHarvestBuffReward?(rootAsRiskHarvestBuffReward);
		}

		// Token: 0x040038DB RID: 14555
		private const string DB = "db_riskharvest.db";

		// Token: 0x040038DC RID: 14556
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x040038DD RID: 14557
		private const string TABLE = "RiskHarvestBuffReward";

		// Token: 0x040038DE RID: 14558
		private const string COMMAND = "select BinData from `RiskHarvestBuffReward` where Id = ?";

		// Token: 0x040038DF RID: 14559
		private const string KEY_PREFIX = "RiskHarvestBuffRewardById";

		// Token: 0x040038E0 RID: 14560
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038E1 RID: 14561
		private static int HandleId;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000807 RID: 2055
	public class ConfigRiskHarvestBuffRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600303C RID: 12348 RVA: 0x00169E43 File Offset: 0x00168043
		static ConfigRiskHarvestBuffRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestBuffRewardById.CreateStaticDefaultValue), new Action(ConfigRiskHarvestBuffRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x0600303D RID: 12349 RVA: 0x00169E64 File Offset: 0x00168064
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

		// Token: 0x0600303E RID: 12350 RVA: 0x00169EE3 File Offset: 0x001680E3
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestBuffRewardById.LogPair = null;
			ConfigRiskHarvestBuffRewardById.HandleId = 0;
		}

		// Token: 0x0600303F RID: 12351 RVA: 0x00169EF1 File Offset: 0x001680F1
		public static void Init()
		{
			ConfigRiskHarvestBuffRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestBuffRewardById.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestBuffReward` where Id = ?");
		}

		// Token: 0x06003040 RID: 12352 RVA: 0x00169F0C File Offset: 0x0016810C
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

		// Token: 0x04003817 RID: 14359
		private const string DB = "db_riskharvest.db";

		// Token: 0x04003818 RID: 14360
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x04003819 RID: 14361
		private const string TABLE = "RiskHarvestBuffReward";

		// Token: 0x0400381A RID: 14362
		private const string COMMAND = "select BinData from `RiskHarvestBuffReward` where Id = ?";

		// Token: 0x0400381B RID: 14363
		private const string KEY_PREFIX = "RiskHarvestBuffRewardById";

		// Token: 0x0400381C RID: 14364
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400381D RID: 14365
		private static int HandleId;
	}
}

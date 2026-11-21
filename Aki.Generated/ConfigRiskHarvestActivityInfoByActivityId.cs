using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200081C RID: 2076
	public class ConfigRiskHarvestActivityInfoByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030BA RID: 12474 RVA: 0x00170360 File Offset: 0x0016E560
		static ConfigRiskHarvestActivityInfoByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestActivityInfoByActivityId.CreateStaticDefaultValue), new Action(ConfigRiskHarvestActivityInfoByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x00170380 File Offset: 0x0016E580
		public static void CreateStaticDefaultValue()
		{
			ConfigRiskHarvestActivityInfoByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRiskHarvestActivityInfoByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_riskharvest.db"),
				new ValueTuple<string, object>("文件", "g.割草冒险活动.xlsx"),
				new ValueTuple<string, object>("表名", "RiskHarvestActivityInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `RiskHarvestActivityInfo` where ActivityId = ?")
			});
		}

		// Token: 0x060030BC RID: 12476 RVA: 0x001703FF File Offset: 0x0016E5FF
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestActivityInfoByActivityId.LogPair = null;
			ConfigRiskHarvestActivityInfoByActivityId.HandleId = 0;
		}

		// Token: 0x060030BD RID: 12477 RVA: 0x0017040D File Offset: 0x0016E60D
		public static void Init()
		{
			ConfigRiskHarvestActivityInfoByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestActivityInfoByActivityId.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestActivityInfo` where ActivityId = ?");
		}

		// Token: 0x060030BE RID: 12478 RVA: 0x00170428 File Offset: 0x0016E628
		public static RiskHarvestActivityInfo? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRiskHarvestActivityInfoByActivityId.HandleId, ConfigRiskHarvestActivityInfoByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RiskHarvestActivityInfoByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RiskHarvestActivityInfo?(RiskHarvestActivityInfo.GetRootAsRiskHarvestActivityInfo(configBuffer));
				}
			}
			ConfigRiskHarvestActivityInfoByActivityId.LogPair.Clear();
			ConfigRiskHarvestActivityInfoByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigRiskHarvestActivityInfoByActivityId.HandleId, 1, p0ActivityId, ConfigRiskHarvestActivityInfoByActivityId.LogPair) || ConfigCommon.Step(ConfigRiskHarvestActivityInfoByActivityId.HandleId, true, ConfigRiskHarvestActivityInfoByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRiskHarvestActivityInfoByActivityId.HandleId, ConfigRiskHarvestActivityInfoByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRiskHarvestActivityInfoByActivityId.HandleId, 0, ConfigRiskHarvestActivityInfoByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRiskHarvestActivityInfoByActivityId.HandleId, ConfigRiskHarvestActivityInfoByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RiskHarvestActivityInfo rootAsRiskHarvestActivityInfo = RiskHarvestActivityInfo.GetRootAsRiskHarvestActivityInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RiskHarvestActivityInfoByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRiskHarvestActivityInfoByActivityId.HandleId, ConfigRiskHarvestActivityInfoByActivityId.LogPair);
			return new RiskHarvestActivityInfo?(rootAsRiskHarvestActivityInfo);
		}

		// Token: 0x040038AA RID: 14506
		private const string DB = "db_riskharvest.db";

		// Token: 0x040038AB RID: 14507
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x040038AC RID: 14508
		private const string TABLE = "RiskHarvestActivityInfo";

		// Token: 0x040038AD RID: 14509
		private const string COMMAND = "select BinData from `RiskHarvestActivityInfo` where ActivityId = ?";

		// Token: 0x040038AE RID: 14510
		private const string KEY_PREFIX = "RiskHarvestActivityInfoByActivityId";

		// Token: 0x040038AF RID: 14511
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038B0 RID: 14512
		private static int HandleId;
	}
}

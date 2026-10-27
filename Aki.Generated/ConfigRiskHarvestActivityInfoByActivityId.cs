using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000800 RID: 2048
	public class ConfigRiskHarvestActivityInfoByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003012 RID: 12306 RVA: 0x00169078 File Offset: 0x00167278
		static ConfigRiskHarvestActivityInfoByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestActivityInfoByActivityId.CreateStaticDefaultValue), new Action(ConfigRiskHarvestActivityInfoByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003013 RID: 12307 RVA: 0x00169098 File Offset: 0x00167298
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

		// Token: 0x06003014 RID: 12308 RVA: 0x00169117 File Offset: 0x00167317
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestActivityInfoByActivityId.LogPair = null;
			ConfigRiskHarvestActivityInfoByActivityId.HandleId = 0;
		}

		// Token: 0x06003015 RID: 12309 RVA: 0x00169125 File Offset: 0x00167325
		public static void Init()
		{
			ConfigRiskHarvestActivityInfoByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestActivityInfoByActivityId.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestActivityInfo` where ActivityId = ?");
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x00169140 File Offset: 0x00167340
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

		// Token: 0x040037E6 RID: 14310
		private const string DB = "db_riskharvest.db";

		// Token: 0x040037E7 RID: 14311
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x040037E8 RID: 14312
		private const string TABLE = "RiskHarvestActivityInfo";

		// Token: 0x040037E9 RID: 14313
		private const string COMMAND = "select BinData from `RiskHarvestActivityInfo` where ActivityId = ?";

		// Token: 0x040037EA RID: 14314
		private const string KEY_PREFIX = "RiskHarvestActivityInfoByActivityId";

		// Token: 0x040037EB RID: 14315
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040037EC RID: 14316
		private static int HandleId;
	}
}

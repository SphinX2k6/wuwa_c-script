using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200080C RID: 2060
	public class ConfigRiskHarvestInstByInstanceID : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600305A RID: 12378 RVA: 0x0016A8E8 File Offset: 0x00168AE8
		static ConfigRiskHarvestInstByInstanceID()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestInstByInstanceID.CreateStaticDefaultValue), new Action(ConfigRiskHarvestInstByInstanceID.ResetStaticDefaultValue));
		}

		// Token: 0x0600305B RID: 12379 RVA: 0x0016A908 File Offset: 0x00168B08
		public static void CreateStaticDefaultValue()
		{
			ConfigRiskHarvestInstByInstanceID.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRiskHarvestInstByInstanceID.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_riskharvest.db"),
				new ValueTuple<string, object>("文件", "g.割草冒险活动.xlsx"),
				new ValueTuple<string, object>("表名", "RiskHarvestInst"),
				new ValueTuple<string, object>("语句", "select BinData from `RiskHarvestInst` where InstanceID = ?")
			});
		}

		// Token: 0x0600305C RID: 12380 RVA: 0x0016A987 File Offset: 0x00168B87
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestInstByInstanceID.LogPair = null;
			ConfigRiskHarvestInstByInstanceID.HandleId = 0;
		}

		// Token: 0x0600305D RID: 12381 RVA: 0x0016A995 File Offset: 0x00168B95
		public static void Init()
		{
			ConfigRiskHarvestInstByInstanceID.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestInstByInstanceID.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestInst` where InstanceID = ?");
		}

		// Token: 0x0600305E RID: 12382 RVA: 0x0016A9B0 File Offset: 0x00168BB0
		public static RiskHarvestInst? GetConfig(int p0InstanceID, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRiskHarvestInstByInstanceID.HandleId, ConfigRiskHarvestInstByInstanceID.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RiskHarvestInstByInstanceID");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstanceID);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RiskHarvestInst?(RiskHarvestInst.GetRootAsRiskHarvestInst(configBuffer));
				}
			}
			ConfigRiskHarvestInstByInstanceID.LogPair.Clear();
			ConfigRiskHarvestInstByInstanceID.LogPair.Add(new ValueTuple<string, object>("InstanceID", p0InstanceID));
			if (!ConfigCommon.BindInt(ConfigRiskHarvestInstByInstanceID.HandleId, 1, p0InstanceID, ConfigRiskHarvestInstByInstanceID.LogPair) || ConfigCommon.Step(ConfigRiskHarvestInstByInstanceID.HandleId, true, ConfigRiskHarvestInstByInstanceID.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRiskHarvestInstByInstanceID.HandleId, ConfigRiskHarvestInstByInstanceID.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRiskHarvestInstByInstanceID.HandleId, 0, ConfigRiskHarvestInstByInstanceID.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRiskHarvestInstByInstanceID.HandleId, ConfigRiskHarvestInstByInstanceID.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RiskHarvestInst rootAsRiskHarvestInst = RiskHarvestInst.GetRootAsRiskHarvestInst(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RiskHarvestInstByInstanceID");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstanceID);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRiskHarvestInstByInstanceID.HandleId, ConfigRiskHarvestInstByInstanceID.LogPair);
			return new RiskHarvestInst?(rootAsRiskHarvestInst);
		}

		// Token: 0x0400383A RID: 14394
		private const string DB = "db_riskharvest.db";

		// Token: 0x0400383B RID: 14395
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x0400383C RID: 14396
		private const string TABLE = "RiskHarvestInst";

		// Token: 0x0400383D RID: 14397
		private const string COMMAND = "select BinData from `RiskHarvestInst` where InstanceID = ?";

		// Token: 0x0400383E RID: 14398
		private const string KEY_PREFIX = "RiskHarvestInstByInstanceID";

		// Token: 0x0400383F RID: 14399
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003840 RID: 14400
		private static int HandleId;
	}
}

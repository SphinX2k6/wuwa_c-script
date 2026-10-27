using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200080B RID: 2059
	public class ConfigRiskHarvestInstById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003054 RID: 12372 RVA: 0x0016A69F File Offset: 0x0016889F
		static ConfigRiskHarvestInstById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestInstById.CreateStaticDefaultValue), new Action(ConfigRiskHarvestInstById.ResetStaticDefaultValue));
		}

		// Token: 0x06003055 RID: 12373 RVA: 0x0016A6C0 File Offset: 0x001688C0
		public static void CreateStaticDefaultValue()
		{
			ConfigRiskHarvestInstById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRiskHarvestInstById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_riskharvest.db"),
				new ValueTuple<string, object>("文件", "g.割草冒险活动.xlsx"),
				new ValueTuple<string, object>("表名", "RiskHarvestInst"),
				new ValueTuple<string, object>("语句", "select BinData from `RiskHarvestInst` where Id = ?")
			});
		}

		// Token: 0x06003056 RID: 12374 RVA: 0x0016A73F File Offset: 0x0016893F
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestInstById.LogPair = null;
			ConfigRiskHarvestInstById.HandleId = 0;
		}

		// Token: 0x06003057 RID: 12375 RVA: 0x0016A74D File Offset: 0x0016894D
		public static void Init()
		{
			ConfigRiskHarvestInstById.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestInstById.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestInst` where Id = ?");
		}

		// Token: 0x06003058 RID: 12376 RVA: 0x0016A768 File Offset: 0x00168968
		public static RiskHarvestInst? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRiskHarvestInstById.HandleId, ConfigRiskHarvestInstById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RiskHarvestInstById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RiskHarvestInst?(RiskHarvestInst.GetRootAsRiskHarvestInst(configBuffer));
				}
			}
			ConfigRiskHarvestInstById.LogPair.Clear();
			ConfigRiskHarvestInstById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRiskHarvestInstById.HandleId, 1, p0Id, ConfigRiskHarvestInstById.LogPair) || ConfigCommon.Step(ConfigRiskHarvestInstById.HandleId, true, ConfigRiskHarvestInstById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRiskHarvestInstById.HandleId, ConfigRiskHarvestInstById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRiskHarvestInstById.HandleId, 0, ConfigRiskHarvestInstById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRiskHarvestInstById.HandleId, ConfigRiskHarvestInstById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RiskHarvestInst rootAsRiskHarvestInst = RiskHarvestInst.GetRootAsRiskHarvestInst(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RiskHarvestInstById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRiskHarvestInstById.HandleId, ConfigRiskHarvestInstById.LogPair);
			return new RiskHarvestInst?(rootAsRiskHarvestInst);
		}

		// Token: 0x04003833 RID: 14387
		private const string DB = "db_riskharvest.db";

		// Token: 0x04003834 RID: 14388
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x04003835 RID: 14389
		private const string TABLE = "RiskHarvestInst";

		// Token: 0x04003836 RID: 14390
		private const string COMMAND = "select BinData from `RiskHarvestInst` where Id = ?";

		// Token: 0x04003837 RID: 14391
		private const string KEY_PREFIX = "RiskHarvestInstById";

		// Token: 0x04003838 RID: 14392
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003839 RID: 14393
		private static int HandleId;
	}
}

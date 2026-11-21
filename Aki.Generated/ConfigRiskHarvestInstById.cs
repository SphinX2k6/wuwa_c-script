using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000827 RID: 2087
	public class ConfigRiskHarvestInstById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030FC RID: 12540 RVA: 0x00171987 File Offset: 0x0016FB87
		static ConfigRiskHarvestInstById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestInstById.CreateStaticDefaultValue), new Action(ConfigRiskHarvestInstById.ResetStaticDefaultValue));
		}

		// Token: 0x060030FD RID: 12541 RVA: 0x001719A8 File Offset: 0x0016FBA8
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

		// Token: 0x060030FE RID: 12542 RVA: 0x00171A27 File Offset: 0x0016FC27
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestInstById.LogPair = null;
			ConfigRiskHarvestInstById.HandleId = 0;
		}

		// Token: 0x060030FF RID: 12543 RVA: 0x00171A35 File Offset: 0x0016FC35
		public static void Init()
		{
			ConfigRiskHarvestInstById.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestInstById.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestInst` where Id = ?");
		}

		// Token: 0x06003100 RID: 12544 RVA: 0x00171A50 File Offset: 0x0016FC50
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

		// Token: 0x040038F7 RID: 14583
		private const string DB = "db_riskharvest.db";

		// Token: 0x040038F8 RID: 14584
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x040038F9 RID: 14585
		private const string TABLE = "RiskHarvestInst";

		// Token: 0x040038FA RID: 14586
		private const string COMMAND = "select BinData from `RiskHarvestInst` where Id = ?";

		// Token: 0x040038FB RID: 14587
		private const string KEY_PREFIX = "RiskHarvestInstById";

		// Token: 0x040038FC RID: 14588
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038FD RID: 14589
		private static int HandleId;
	}
}

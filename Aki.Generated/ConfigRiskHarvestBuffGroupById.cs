using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000805 RID: 2053
	public class ConfigRiskHarvestBuffGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003030 RID: 12336 RVA: 0x00169A67 File Offset: 0x00167C67
		static ConfigRiskHarvestBuffGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestBuffGroupById.CreateStaticDefaultValue), new Action(ConfigRiskHarvestBuffGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06003031 RID: 12337 RVA: 0x00169A88 File Offset: 0x00167C88
		public static void CreateStaticDefaultValue()
		{
			ConfigRiskHarvestBuffGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRiskHarvestBuffGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_riskharvest.db"),
				new ValueTuple<string, object>("文件", "g.割草冒险活动.xlsx"),
				new ValueTuple<string, object>("表名", "RiskHarvestBuffGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `RiskHarvestBuffGroup` where Id = ?")
			});
		}

		// Token: 0x06003032 RID: 12338 RVA: 0x00169B07 File Offset: 0x00167D07
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestBuffGroupById.LogPair = null;
			ConfigRiskHarvestBuffGroupById.HandleId = 0;
		}

		// Token: 0x06003033 RID: 12339 RVA: 0x00169B15 File Offset: 0x00167D15
		public static void Init()
		{
			ConfigRiskHarvestBuffGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestBuffGroupById.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestBuffGroup` where Id = ?");
		}

		// Token: 0x06003034 RID: 12340 RVA: 0x00169B30 File Offset: 0x00167D30
		public static RiskHarvestBuffGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRiskHarvestBuffGroupById.HandleId, ConfigRiskHarvestBuffGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RiskHarvestBuffGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RiskHarvestBuffGroup?(RiskHarvestBuffGroup.GetRootAsRiskHarvestBuffGroup(configBuffer));
				}
			}
			ConfigRiskHarvestBuffGroupById.LogPair.Clear();
			ConfigRiskHarvestBuffGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRiskHarvestBuffGroupById.HandleId, 1, p0Id, ConfigRiskHarvestBuffGroupById.LogPair) || ConfigCommon.Step(ConfigRiskHarvestBuffGroupById.HandleId, true, ConfigRiskHarvestBuffGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRiskHarvestBuffGroupById.HandleId, ConfigRiskHarvestBuffGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRiskHarvestBuffGroupById.HandleId, 0, ConfigRiskHarvestBuffGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRiskHarvestBuffGroupById.HandleId, ConfigRiskHarvestBuffGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RiskHarvestBuffGroup rootAsRiskHarvestBuffGroup = RiskHarvestBuffGroup.GetRootAsRiskHarvestBuffGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RiskHarvestBuffGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRiskHarvestBuffGroupById.HandleId, ConfigRiskHarvestBuffGroupById.LogPair);
			return new RiskHarvestBuffGroup?(rootAsRiskHarvestBuffGroup);
		}

		// Token: 0x04003809 RID: 14345
		private const string DB = "db_riskharvest.db";

		// Token: 0x0400380A RID: 14346
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x0400380B RID: 14347
		private const string TABLE = "RiskHarvestBuffGroup";

		// Token: 0x0400380C RID: 14348
		private const string COMMAND = "select BinData from `RiskHarvestBuffGroup` where Id = ?";

		// Token: 0x0400380D RID: 14349
		private const string KEY_PREFIX = "RiskHarvestBuffGroupById";

		// Token: 0x0400380E RID: 14350
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400380F RID: 14351
		private static int HandleId;
	}
}

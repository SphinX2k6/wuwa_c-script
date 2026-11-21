using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000821 RID: 2081
	public class ConfigRiskHarvestBuffGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030D8 RID: 12504 RVA: 0x00170D4F File Offset: 0x0016EF4F
		static ConfigRiskHarvestBuffGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestBuffGroupById.CreateStaticDefaultValue), new Action(ConfigRiskHarvestBuffGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x060030D9 RID: 12505 RVA: 0x00170D70 File Offset: 0x0016EF70
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

		// Token: 0x060030DA RID: 12506 RVA: 0x00170DEF File Offset: 0x0016EFEF
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestBuffGroupById.LogPair = null;
			ConfigRiskHarvestBuffGroupById.HandleId = 0;
		}

		// Token: 0x060030DB RID: 12507 RVA: 0x00170DFD File Offset: 0x0016EFFD
		public static void Init()
		{
			ConfigRiskHarvestBuffGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestBuffGroupById.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestBuffGroup` where Id = ?");
		}

		// Token: 0x060030DC RID: 12508 RVA: 0x00170E18 File Offset: 0x0016F018
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

		// Token: 0x040038CD RID: 14541
		private const string DB = "db_riskharvest.db";

		// Token: 0x040038CE RID: 14542
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x040038CF RID: 14543
		private const string TABLE = "RiskHarvestBuffGroup";

		// Token: 0x040038D0 RID: 14544
		private const string COMMAND = "select BinData from `RiskHarvestBuffGroup` where Id = ?";

		// Token: 0x040038D1 RID: 14545
		private const string KEY_PREFIX = "RiskHarvestBuffGroupById";

		// Token: 0x040038D2 RID: 14546
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038D3 RID: 14547
		private static int HandleId;
	}
}

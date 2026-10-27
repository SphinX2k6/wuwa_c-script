using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000804 RID: 2052
	public class ConfigRiskHarvestBuffGroupByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600302A RID: 12330 RVA: 0x0016982F File Offset: 0x00167A2F
		static ConfigRiskHarvestBuffGroupByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestBuffGroupByActivityId.CreateStaticDefaultValue), new Action(ConfigRiskHarvestBuffGroupByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600302B RID: 12331 RVA: 0x00169850 File Offset: 0x00167A50
		public static void CreateStaticDefaultValue()
		{
			ConfigRiskHarvestBuffGroupByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRiskHarvestBuffGroupByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_riskharvest.db"),
				new ValueTuple<string, object>("文件", "g.割草冒险活动.xlsx"),
				new ValueTuple<string, object>("表名", "RiskHarvestBuffGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `RiskHarvestBuffGroup` where ActivityId = ?")
			});
		}

		// Token: 0x0600302C RID: 12332 RVA: 0x001698CF File Offset: 0x00167ACF
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestBuffGroupByActivityId.LogPair = null;
			ConfigRiskHarvestBuffGroupByActivityId.HandleId = 0;
		}

		// Token: 0x0600302D RID: 12333 RVA: 0x001698DD File Offset: 0x00167ADD
		public static void Init()
		{
			ConfigRiskHarvestBuffGroupByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestBuffGroupByActivityId.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestBuffGroup` where ActivityId = ?");
		}

		// Token: 0x0600302E RID: 12334 RVA: 0x001698F8 File Offset: 0x00167AF8
		[NullableContext(2)]
		public static IReadOnlyList<RiskHarvestBuffGroup> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRiskHarvestBuffGroupByActivityId.HandleId, ConfigRiskHarvestBuffGroupByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RiskHarvestBuffGroupByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<RiskHarvestBuffGroup> readOnlyList = (IReadOnlyList<RiskHarvestBuffGroup>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRiskHarvestBuffGroupByActivityId.LogPair.Clear();
			ConfigRiskHarvestBuffGroupByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigRiskHarvestBuffGroupByActivityId.HandleId, 1, p0ActivityId, ConfigRiskHarvestBuffGroupByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigRiskHarvestBuffGroupByActivityId.HandleId, ConfigRiskHarvestBuffGroupByActivityId.LogPair);
				return null;
			}
			List<RiskHarvestBuffGroup> list = new List<RiskHarvestBuffGroup>();
			while (ConfigCommon.Step(ConfigRiskHarvestBuffGroupByActivityId.HandleId, false, ConfigRiskHarvestBuffGroupByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRiskHarvestBuffGroupByActivityId.HandleId, 0, ConfigRiskHarvestBuffGroupByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRiskHarvestBuffGroupByActivityId.HandleId, ConfigRiskHarvestBuffGroupByActivityId.LogPair);
					return null;
				}
				RiskHarvestBuffGroup rootAsRiskHarvestBuffGroup = RiskHarvestBuffGroup.GetRootAsRiskHarvestBuffGroup(new ByteBuffer(item2));
				list.Add(rootAsRiskHarvestBuffGroup);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RiskHarvestBuffGroupByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRiskHarvestBuffGroupByActivityId.HandleId, ConfigRiskHarvestBuffGroupByActivityId.LogPair);
			return list;
		}

		// Token: 0x04003802 RID: 14338
		private const string DB = "db_riskharvest.db";

		// Token: 0x04003803 RID: 14339
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x04003804 RID: 14340
		private const string TABLE = "RiskHarvestBuffGroup";

		// Token: 0x04003805 RID: 14341
		private const string COMMAND = "select BinData from `RiskHarvestBuffGroup` where ActivityId = ?";

		// Token: 0x04003806 RID: 14342
		private const string KEY_PREFIX = "RiskHarvestBuffGroupByActivityId";

		// Token: 0x04003807 RID: 14343
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003808 RID: 14344
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000820 RID: 2080
	public class ConfigRiskHarvestBuffGroupByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030D2 RID: 12498 RVA: 0x00170B17 File Offset: 0x0016ED17
		static ConfigRiskHarvestBuffGroupByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestBuffGroupByActivityId.CreateStaticDefaultValue), new Action(ConfigRiskHarvestBuffGroupByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x00170B38 File Offset: 0x0016ED38
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

		// Token: 0x060030D4 RID: 12500 RVA: 0x00170BB7 File Offset: 0x0016EDB7
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestBuffGroupByActivityId.LogPair = null;
			ConfigRiskHarvestBuffGroupByActivityId.HandleId = 0;
		}

		// Token: 0x060030D5 RID: 12501 RVA: 0x00170BC5 File Offset: 0x0016EDC5
		public static void Init()
		{
			ConfigRiskHarvestBuffGroupByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestBuffGroupByActivityId.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestBuffGroup` where ActivityId = ?");
		}

		// Token: 0x060030D6 RID: 12502 RVA: 0x00170BE0 File Offset: 0x0016EDE0
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

		// Token: 0x040038C6 RID: 14534
		private const string DB = "db_riskharvest.db";

		// Token: 0x040038C7 RID: 14535
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x040038C8 RID: 14536
		private const string TABLE = "RiskHarvestBuffGroup";

		// Token: 0x040038C9 RID: 14537
		private const string COMMAND = "select BinData from `RiskHarvestBuffGroup` where ActivityId = ?";

		// Token: 0x040038CA RID: 14538
		private const string KEY_PREFIX = "RiskHarvestBuffGroupByActivityId";

		// Token: 0x040038CB RID: 14539
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038CC RID: 14540
		private static int HandleId;
	}
}

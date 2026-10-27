using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200080A RID: 2058
	public class ConfigRiskHarvestInstByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600304E RID: 12366 RVA: 0x0016A467 File Offset: 0x00168667
		static ConfigRiskHarvestInstByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestInstByActivityId.CreateStaticDefaultValue), new Action(ConfigRiskHarvestInstByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600304F RID: 12367 RVA: 0x0016A488 File Offset: 0x00168688
		public static void CreateStaticDefaultValue()
		{
			ConfigRiskHarvestInstByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRiskHarvestInstByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_riskharvest.db"),
				new ValueTuple<string, object>("文件", "g.割草冒险活动.xlsx"),
				new ValueTuple<string, object>("表名", "RiskHarvestInst"),
				new ValueTuple<string, object>("语句", "select BinData from `RiskHarvestInst` where ActivityId = ?")
			});
		}

		// Token: 0x06003050 RID: 12368 RVA: 0x0016A507 File Offset: 0x00168707
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestInstByActivityId.LogPair = null;
			ConfigRiskHarvestInstByActivityId.HandleId = 0;
		}

		// Token: 0x06003051 RID: 12369 RVA: 0x0016A515 File Offset: 0x00168715
		public static void Init()
		{
			ConfigRiskHarvestInstByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestInstByActivityId.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestInst` where ActivityId = ?");
		}

		// Token: 0x06003052 RID: 12370 RVA: 0x0016A530 File Offset: 0x00168730
		[NullableContext(2)]
		public static IReadOnlyList<RiskHarvestInst> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRiskHarvestInstByActivityId.HandleId, ConfigRiskHarvestInstByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RiskHarvestInstByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<RiskHarvestInst> readOnlyList = (IReadOnlyList<RiskHarvestInst>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRiskHarvestInstByActivityId.LogPair.Clear();
			ConfigRiskHarvestInstByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigRiskHarvestInstByActivityId.HandleId, 1, p0ActivityId, ConfigRiskHarvestInstByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigRiskHarvestInstByActivityId.HandleId, ConfigRiskHarvestInstByActivityId.LogPair);
				return null;
			}
			List<RiskHarvestInst> list = new List<RiskHarvestInst>();
			while (ConfigCommon.Step(ConfigRiskHarvestInstByActivityId.HandleId, false, ConfigRiskHarvestInstByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRiskHarvestInstByActivityId.HandleId, 0, ConfigRiskHarvestInstByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRiskHarvestInstByActivityId.HandleId, ConfigRiskHarvestInstByActivityId.LogPair);
					return null;
				}
				RiskHarvestInst rootAsRiskHarvestInst = RiskHarvestInst.GetRootAsRiskHarvestInst(new ByteBuffer(item2));
				list.Add(rootAsRiskHarvestInst);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RiskHarvestInstByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRiskHarvestInstByActivityId.HandleId, ConfigRiskHarvestInstByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400382C RID: 14380
		private const string DB = "db_riskharvest.db";

		// Token: 0x0400382D RID: 14381
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x0400382E RID: 14382
		private const string TABLE = "RiskHarvestInst";

		// Token: 0x0400382F RID: 14383
		private const string COMMAND = "select BinData from `RiskHarvestInst` where ActivityId = ?";

		// Token: 0x04003830 RID: 14384
		private const string KEY_PREFIX = "RiskHarvestInstByActivityId";

		// Token: 0x04003831 RID: 14385
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003832 RID: 14386
		private static int HandleId;
	}
}

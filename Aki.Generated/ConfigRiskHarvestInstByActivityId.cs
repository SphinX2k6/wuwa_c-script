using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000826 RID: 2086
	public class ConfigRiskHarvestInstByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030F6 RID: 12534 RVA: 0x0017174F File Offset: 0x0016F94F
		static ConfigRiskHarvestInstByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestInstByActivityId.CreateStaticDefaultValue), new Action(ConfigRiskHarvestInstByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060030F7 RID: 12535 RVA: 0x00171770 File Offset: 0x0016F970
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

		// Token: 0x060030F8 RID: 12536 RVA: 0x001717EF File Offset: 0x0016F9EF
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestInstByActivityId.LogPair = null;
			ConfigRiskHarvestInstByActivityId.HandleId = 0;
		}

		// Token: 0x060030F9 RID: 12537 RVA: 0x001717FD File Offset: 0x0016F9FD
		public static void Init()
		{
			ConfigRiskHarvestInstByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestInstByActivityId.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestInst` where ActivityId = ?");
		}

		// Token: 0x060030FA RID: 12538 RVA: 0x00171818 File Offset: 0x0016FA18
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

		// Token: 0x040038F0 RID: 14576
		private const string DB = "db_riskharvest.db";

		// Token: 0x040038F1 RID: 14577
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x040038F2 RID: 14578
		private const string TABLE = "RiskHarvestInst";

		// Token: 0x040038F3 RID: 14579
		private const string COMMAND = "select BinData from `RiskHarvestInst` where ActivityId = ?";

		// Token: 0x040038F4 RID: 14580
		private const string KEY_PREFIX = "RiskHarvestInstByActivityId";

		// Token: 0x040038F5 RID: 14581
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038F6 RID: 14582
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B72 RID: 2930
	public class ConfigWorldProgressCurveAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060044C1 RID: 17601 RVA: 0x001E2234 File Offset: 0x001E0434
		static ConfigWorldProgressCurveAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWorldProgressCurveAll.CreateStaticDefaultValue), new Action(ConfigWorldProgressCurveAll.ResetStaticDefaultValue));
		}

		// Token: 0x060044C2 RID: 17602 RVA: 0x001E2254 File Offset: 0x001E0454
		public static void CreateStaticDefaultValue()
		{
			ConfigWorldProgressCurveAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWorldProgressCurveAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_anniversaryt.db"),
				new ValueTuple<string, object>("文件", "z.周年庆主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "WorldProgressCurve"),
				new ValueTuple<string, object>("语句", "select BinData from `WorldProgressCurve`")
			});
		}

		// Token: 0x060044C3 RID: 17603 RVA: 0x001E22D3 File Offset: 0x001E04D3
		public static void ResetStaticDefaultValue()
		{
			ConfigWorldProgressCurveAll.LogPair = null;
			ConfigWorldProgressCurveAll.HandleId = 0;
		}

		// Token: 0x060044C4 RID: 17604 RVA: 0x001E22E1 File Offset: 0x001E04E1
		public static void Init()
		{
			ConfigWorldProgressCurveAll.HandleId = ConfigCommon.InitDataStatement(ConfigWorldProgressCurveAll.HandleId, "db_anniversaryt.db", "select BinData from `WorldProgressCurve`");
		}

		// Token: 0x060044C5 RID: 17605 RVA: 0x001E22FC File Offset: 0x001E04FC
		[NullableContext(2)]
		public static IReadOnlyList<WorldProgressCurve> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWorldProgressCurveAll.HandleId, ConfigWorldProgressCurveAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<WorldProgressCurve> readOnlyList = (IReadOnlyList<WorldProgressCurve>)ConfigCommon.GetConfig("WorldProgressCurveAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<WorldProgressCurve> list = new List<WorldProgressCurve>();
			while (ConfigCommon.Step(ConfigWorldProgressCurveAll.HandleId, false, ConfigWorldProgressCurveAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWorldProgressCurveAll.HandleId, 0, ConfigWorldProgressCurveAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigWorldProgressCurveAll.HandleId, ConfigWorldProgressCurveAll.LogPair);
					return null;
				}
				WorldProgressCurve rootAsWorldProgressCurve = WorldProgressCurve.GetRootAsWorldProgressCurve(new ByteBuffer(item2));
				list.Add(rootAsWorldProgressCurve);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("WorldProgressCurveAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigWorldProgressCurveAll.HandleId, ConfigWorldProgressCurveAll.LogPair);
			return list;
		}

		// Token: 0x04005004 RID: 20484
		private const string DB = "db_anniversaryt.db";

		// Token: 0x04005005 RID: 20485
		private const string FILE = "z.周年庆主题活动.xlsx";

		// Token: 0x04005006 RID: 20486
		private const string TABLE = "WorldProgressCurve";

		// Token: 0x04005007 RID: 20487
		private const string COMMAND = "select BinData from `WorldProgressCurve`";

		// Token: 0x04005008 RID: 20488
		private const string KEY_PREFIX = "WorldProgressCurveAll";

		// Token: 0x04005009 RID: 20489
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400500A RID: 20490
		private static int HandleId;
	}
}

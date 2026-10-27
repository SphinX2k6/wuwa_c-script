using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200019B RID: 411
	public class ConfigCookFormulaAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009A5 RID: 2469 RVA: 0x000900AC File Offset: 0x0008E2AC
		static ConfigCookFormulaAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCookFormulaAll.CreateStaticDefaultValue), new Action(ConfigCookFormulaAll.ResetStaticDefaultValue));
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x000900CC File Offset: 0x0008E2CC
		public static void CreateStaticDefaultValue()
		{
			ConfigCookFormulaAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCookFormulaAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cook.db"),
				new ValueTuple<string, object>("文件", "p.烹饪.xlsx"),
				new ValueTuple<string, object>("表名", "CookFormula"),
				new ValueTuple<string, object>("语句", "select BinData from `CookFormula`")
			});
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0009014B File Offset: 0x0008E34B
		public static void ResetStaticDefaultValue()
		{
			ConfigCookFormulaAll.LogPair = null;
			ConfigCookFormulaAll.HandleId = 0;
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00090159 File Offset: 0x0008E359
		public static void Init()
		{
			ConfigCookFormulaAll.HandleId = ConfigCommon.InitDataStatement(ConfigCookFormulaAll.HandleId, "db_cook.db", "select BinData from `CookFormula`");
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00090174 File Offset: 0x0008E374
		[NullableContext(2)]
		public static IReadOnlyList<CookFormula> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCookFormulaAll.HandleId, ConfigCookFormulaAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<CookFormula> readOnlyList = (IReadOnlyList<CookFormula>)ConfigCommon.GetConfig("CookFormulaAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<CookFormula> list = new List<CookFormula>();
			while (ConfigCommon.Step(ConfigCookFormulaAll.HandleId, false, ConfigCookFormulaAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCookFormulaAll.HandleId, 0, ConfigCookFormulaAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCookFormulaAll.HandleId, ConfigCookFormulaAll.LogPair);
					return null;
				}
				CookFormula rootAsCookFormula = CookFormula.GetRootAsCookFormula(new ByteBuffer(item2));
				list.Add(rootAsCookFormula);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("CookFormulaAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigCookFormulaAll.HandleId, ConfigCookFormulaAll.LogPair);
			return list;
		}

		// Token: 0x04000B21 RID: 2849
		private const string DB = "db_cook.db";

		// Token: 0x04000B22 RID: 2850
		private const string FILE = "p.烹饪.xlsx";

		// Token: 0x04000B23 RID: 2851
		private const string TABLE = "CookFormula";

		// Token: 0x04000B24 RID: 2852
		private const string COMMAND = "select BinData from `CookFormula`";

		// Token: 0x04000B25 RID: 2853
		private const string KEY_PREFIX = "CookFormulaAll";

		// Token: 0x04000B26 RID: 2854
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B27 RID: 2855
		private static int HandleId;
	}
}

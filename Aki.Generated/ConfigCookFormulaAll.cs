using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001AD RID: 429
	public class ConfigCookFormulaAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A11 RID: 2577 RVA: 0x00095FE4 File Offset: 0x000941E4
		static ConfigCookFormulaAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCookFormulaAll.CreateStaticDefaultValue), new Action(ConfigCookFormulaAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x00096004 File Offset: 0x00094204
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

		// Token: 0x06000A13 RID: 2579 RVA: 0x00096083 File Offset: 0x00094283
		public static void ResetStaticDefaultValue()
		{
			ConfigCookFormulaAll.LogPair = null;
			ConfigCookFormulaAll.HandleId = 0;
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x00096091 File Offset: 0x00094291
		public static void Init()
		{
			ConfigCookFormulaAll.HandleId = ConfigCommon.InitDataStatement(ConfigCookFormulaAll.HandleId, "db_cook.db", "select BinData from `CookFormula`");
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x000960AC File Offset: 0x000942AC
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

		// Token: 0x04000B9F RID: 2975
		private const string DB = "db_cook.db";

		// Token: 0x04000BA0 RID: 2976
		private const string FILE = "p.烹饪.xlsx";

		// Token: 0x04000BA1 RID: 2977
		private const string TABLE = "CookFormula";

		// Token: 0x04000BA2 RID: 2978
		private const string COMMAND = "select BinData from `CookFormula`";

		// Token: 0x04000BA3 RID: 2979
		private const string KEY_PREFIX = "CookFormulaAll";

		// Token: 0x04000BA4 RID: 2980
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000BA5 RID: 2981
		private static int HandleId;
	}
}

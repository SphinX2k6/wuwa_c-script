using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200035E RID: 862
	public class ConfigForgeFormulaAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001439 RID: 5177 RVA: 0x000CF5C4 File Offset: 0x000CD7C4
		static ConfigForgeFormulaAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigForgeFormulaAll.CreateStaticDefaultValue), new Action(ConfigForgeFormulaAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x000CF5E4 File Offset: 0x000CD7E4
		public static void CreateStaticDefaultValue()
		{
			ConfigForgeFormulaAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigForgeFormulaAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_forge.db"),
				new ValueTuple<string, object>("文件", "d.锻造.xlsx"),
				new ValueTuple<string, object>("表名", "ForgeFormula"),
				new ValueTuple<string, object>("语句", "select BinData from `ForgeFormula`")
			});
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x000CF663 File Offset: 0x000CD863
		public static void ResetStaticDefaultValue()
		{
			ConfigForgeFormulaAll.LogPair = null;
			ConfigForgeFormulaAll.HandleId = 0;
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x000CF671 File Offset: 0x000CD871
		public static void Init()
		{
			ConfigForgeFormulaAll.HandleId = ConfigCommon.InitDataStatement(ConfigForgeFormulaAll.HandleId, "db_forge.db", "select BinData from `ForgeFormula`");
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x000CF68C File Offset: 0x000CD88C
		[NullableContext(2)]
		public static IReadOnlyList<ForgeFormula> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigForgeFormulaAll.HandleId, ConfigForgeFormulaAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ForgeFormula> readOnlyList = (IReadOnlyList<ForgeFormula>)ConfigCommon.GetConfig("ForgeFormulaAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ForgeFormula> list = new List<ForgeFormula>();
			while (ConfigCommon.Step(ConfigForgeFormulaAll.HandleId, false, ConfigForgeFormulaAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigForgeFormulaAll.HandleId, 0, ConfigForgeFormulaAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigForgeFormulaAll.HandleId, ConfigForgeFormulaAll.LogPair);
					return null;
				}
				ForgeFormula rootAsForgeFormula = ForgeFormula.GetRootAsForgeFormula(new ByteBuffer(item2));
				list.Add(rootAsForgeFormula);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ForgeFormulaAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigForgeFormulaAll.HandleId, ConfigForgeFormulaAll.LogPair);
			return list;
		}

		// Token: 0x04001776 RID: 6006
		private const string DB = "db_forge.db";

		// Token: 0x04001777 RID: 6007
		private const string FILE = "d.锻造.xlsx";

		// Token: 0x04001778 RID: 6008
		private const string TABLE = "ForgeFormula";

		// Token: 0x04001779 RID: 6009
		private const string COMMAND = "select BinData from `ForgeFormula`";

		// Token: 0x0400177A RID: 6010
		private const string KEY_PREFIX = "ForgeFormulaAll";

		// Token: 0x0400177B RID: 6011
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400177C RID: 6012
		private static int HandleId;
	}
}

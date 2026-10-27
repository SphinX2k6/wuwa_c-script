using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000349 RID: 841
	public class ConfigForgeFormulaAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013BB RID: 5051 RVA: 0x000C90B8 File Offset: 0x000C72B8
		static ConfigForgeFormulaAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigForgeFormulaAll.CreateStaticDefaultValue), new Action(ConfigForgeFormulaAll.ResetStaticDefaultValue));
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x000C90D8 File Offset: 0x000C72D8
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

		// Token: 0x060013BD RID: 5053 RVA: 0x000C9157 File Offset: 0x000C7357
		public static void ResetStaticDefaultValue()
		{
			ConfigForgeFormulaAll.LogPair = null;
			ConfigForgeFormulaAll.HandleId = 0;
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x000C9165 File Offset: 0x000C7365
		public static void Init()
		{
			ConfigForgeFormulaAll.HandleId = ConfigCommon.InitDataStatement(ConfigForgeFormulaAll.HandleId, "db_forge.db", "select BinData from `ForgeFormula`");
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x000C9180 File Offset: 0x000C7380
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

		// Token: 0x040016E3 RID: 5859
		private const string DB = "db_forge.db";

		// Token: 0x040016E4 RID: 5860
		private const string FILE = "d.锻造.xlsx";

		// Token: 0x040016E5 RID: 5861
		private const string TABLE = "ForgeFormula";

		// Token: 0x040016E6 RID: 5862
		private const string COMMAND = "select BinData from `ForgeFormula`";

		// Token: 0x040016E7 RID: 5863
		private const string KEY_PREFIX = "ForgeFormulaAll";

		// Token: 0x040016E8 RID: 5864
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016E9 RID: 5865
		private static int HandleId;
	}
}

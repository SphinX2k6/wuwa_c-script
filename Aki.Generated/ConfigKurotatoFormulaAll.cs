using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004A8 RID: 1192
	public class ConfigKurotatoFormulaAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BFB RID: 7163 RVA: 0x000FB253 File Offset: 0x000F9453
		static ConfigKurotatoFormulaAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoFormulaAll.CreateStaticDefaultValue), new Action(ConfigKurotatoFormulaAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x000FB274 File Offset: 0x000F9474
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoFormulaAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoFormulaAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_局内.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoFormula"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoFormula`")
			});
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x000FB2F3 File Offset: 0x000F94F3
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoFormulaAll.LogPair = null;
			ConfigKurotatoFormulaAll.HandleId = 0;
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x000FB301 File Offset: 0x000F9501
		public static void Init()
		{
			ConfigKurotatoFormulaAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoFormulaAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoFormula`");
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x000FB31C File Offset: 0x000F951C
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoFormula> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoFormulaAll.HandleId, ConfigKurotatoFormulaAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoFormula> readOnlyList = (IReadOnlyList<KurotatoFormula>)ConfigCommon.GetConfig("KurotatoFormulaAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoFormula> list = new List<KurotatoFormula>();
			while (ConfigCommon.Step(ConfigKurotatoFormulaAll.HandleId, false, ConfigKurotatoFormulaAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoFormulaAll.HandleId, 0, ConfigKurotatoFormulaAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoFormulaAll.HandleId, ConfigKurotatoFormulaAll.LogPair);
					return null;
				}
				KurotatoFormula rootAsKurotatoFormula = KurotatoFormula.GetRootAsKurotatoFormula(new ByteBuffer(item2));
				list.Add(rootAsKurotatoFormula);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoFormulaAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoFormulaAll.HandleId, ConfigKurotatoFormulaAll.LogPair);
			return list;
		}

		// Token: 0x0400207C RID: 8316
		private const string DB = "db_kurotato.db";

		// Token: 0x0400207D RID: 8317
		private const string FILE = "t.土豆兄弟_局内.xlsx";

		// Token: 0x0400207E RID: 8318
		private const string TABLE = "KurotatoFormula";

		// Token: 0x0400207F RID: 8319
		private const string COMMAND = "select BinData from `KurotatoFormula`";

		// Token: 0x04002080 RID: 8320
		private const string KEY_PREFIX = "KurotatoFormulaAll";

		// Token: 0x04002081 RID: 8321
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002082 RID: 8322
		private static int HandleId;
	}
}

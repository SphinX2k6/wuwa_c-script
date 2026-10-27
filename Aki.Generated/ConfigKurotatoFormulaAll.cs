using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000492 RID: 1170
	public class ConfigKurotatoFormulaAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B77 RID: 7031 RVA: 0x000F4AFF File Offset: 0x000F2CFF
		static ConfigKurotatoFormulaAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoFormulaAll.CreateStaticDefaultValue), new Action(ConfigKurotatoFormulaAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x000F4B20 File Offset: 0x000F2D20
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

		// Token: 0x06001B79 RID: 7033 RVA: 0x000F4B9F File Offset: 0x000F2D9F
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoFormulaAll.LogPair = null;
			ConfigKurotatoFormulaAll.HandleId = 0;
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x000F4BAD File Offset: 0x000F2DAD
		public static void Init()
		{
			ConfigKurotatoFormulaAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoFormulaAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoFormula`");
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x000F4BC8 File Offset: 0x000F2DC8
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

		// Token: 0x04001FE2 RID: 8162
		private const string DB = "db_kurotato.db";

		// Token: 0x04001FE3 RID: 8163
		private const string FILE = "t.土豆兄弟_局内.xlsx";

		// Token: 0x04001FE4 RID: 8164
		private const string TABLE = "KurotatoFormula";

		// Token: 0x04001FE5 RID: 8165
		private const string COMMAND = "select BinData from `KurotatoFormula`";

		// Token: 0x04001FE6 RID: 8166
		private const string KEY_PREFIX = "KurotatoFormulaAll";

		// Token: 0x04001FE7 RID: 8167
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001FE8 RID: 8168
		private static int HandleId;
	}
}

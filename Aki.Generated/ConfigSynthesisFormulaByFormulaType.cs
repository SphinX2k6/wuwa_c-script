using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A8F RID: 2703
	public class ConfigSynthesisFormulaByFormulaType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F6E RID: 16238 RVA: 0x001C37F8 File Offset: 0x001C19F8
		static ConfigSynthesisFormulaByFormulaType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSynthesisFormulaByFormulaType.CreateStaticDefaultValue), new Action(ConfigSynthesisFormulaByFormulaType.ResetStaticDefaultValue));
		}

		// Token: 0x06003F6F RID: 16239 RVA: 0x001C3818 File Offset: 0x001C1A18
		public static void CreateStaticDefaultValue()
		{
			ConfigSynthesisFormulaByFormulaType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSynthesisFormulaByFormulaType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_compose.db"),
				new ValueTuple<string, object>("文件", "h.合成.xlsx"),
				new ValueTuple<string, object>("表名", "SynthesisFormula"),
				new ValueTuple<string, object>("语句", "select BinData from `SynthesisFormula` where FormulaType=?")
			});
		}

		// Token: 0x06003F70 RID: 16240 RVA: 0x001C3897 File Offset: 0x001C1A97
		public static void ResetStaticDefaultValue()
		{
			ConfigSynthesisFormulaByFormulaType.LogPair = null;
			ConfigSynthesisFormulaByFormulaType.HandleId = 0;
		}

		// Token: 0x06003F71 RID: 16241 RVA: 0x001C38A5 File Offset: 0x001C1AA5
		public static void Init()
		{
			ConfigSynthesisFormulaByFormulaType.HandleId = ConfigCommon.InitDataStatement(ConfigSynthesisFormulaByFormulaType.HandleId, "db_compose.db", "select BinData from `SynthesisFormula` where FormulaType=?");
		}

		// Token: 0x06003F72 RID: 16242 RVA: 0x001C38C0 File Offset: 0x001C1AC0
		[NullableContext(2)]
		public static IReadOnlyList<SynthesisFormula> GetConfigList(int p0FormulaType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSynthesisFormulaByFormulaType.HandleId, ConfigSynthesisFormulaByFormulaType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SynthesisFormulaByFormulaType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FormulaType);
				IReadOnlyList<SynthesisFormula> readOnlyList = (IReadOnlyList<SynthesisFormula>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSynthesisFormulaByFormulaType.LogPair.Clear();
			ConfigSynthesisFormulaByFormulaType.LogPair.Add(new ValueTuple<string, object>("FormulaType", p0FormulaType));
			if (!ConfigCommon.BindInt(ConfigSynthesisFormulaByFormulaType.HandleId, 1, p0FormulaType, ConfigSynthesisFormulaByFormulaType.LogPair))
			{
				ConfigCommon.Reset(ConfigSynthesisFormulaByFormulaType.HandleId, ConfigSynthesisFormulaByFormulaType.LogPair);
				return null;
			}
			List<SynthesisFormula> list = new List<SynthesisFormula>();
			while (ConfigCommon.Step(ConfigSynthesisFormulaByFormulaType.HandleId, false, ConfigSynthesisFormulaByFormulaType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSynthesisFormulaByFormulaType.HandleId, 0, ConfigSynthesisFormulaByFormulaType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSynthesisFormulaByFormulaType.HandleId, ConfigSynthesisFormulaByFormulaType.LogPair);
					return null;
				}
				SynthesisFormula rootAsSynthesisFormula = SynthesisFormula.GetRootAsSynthesisFormula(new ByteBuffer(item2));
				list.Add(rootAsSynthesisFormula);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SynthesisFormulaByFormulaType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FormulaType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSynthesisFormulaByFormulaType.HandleId, ConfigSynthesisFormulaByFormulaType.LogPair);
			return list;
		}

		// Token: 0x040049CF RID: 18895
		private const string DB = "db_compose.db";

		// Token: 0x040049D0 RID: 18896
		private const string FILE = "h.合成.xlsx";

		// Token: 0x040049D1 RID: 18897
		private const string TABLE = "SynthesisFormula";

		// Token: 0x040049D2 RID: 18898
		private const string COMMAND = "select BinData from `SynthesisFormula` where FormulaType=?";

		// Token: 0x040049D3 RID: 18899
		private const string KEY_PREFIX = "SynthesisFormulaByFormulaType";

		// Token: 0x040049D4 RID: 18900
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040049D5 RID: 18901
		private static int HandleId;
	}
}

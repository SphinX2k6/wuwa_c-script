using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009BA RID: 2490
	public class ConfigSynthesisFormulaByFormulaType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A70 RID: 14960 RVA: 0x001A4464 File Offset: 0x001A2664
		static ConfigSynthesisFormulaByFormulaType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSynthesisFormulaByFormulaType.CreateStaticDefaultValue), new Action(ConfigSynthesisFormulaByFormulaType.ResetStaticDefaultValue));
		}

		// Token: 0x06003A71 RID: 14961 RVA: 0x001A4484 File Offset: 0x001A2684
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

		// Token: 0x06003A72 RID: 14962 RVA: 0x001A4503 File Offset: 0x001A2703
		public static void ResetStaticDefaultValue()
		{
			ConfigSynthesisFormulaByFormulaType.LogPair = null;
			ConfigSynthesisFormulaByFormulaType.HandleId = 0;
		}

		// Token: 0x06003A73 RID: 14963 RVA: 0x001A4511 File Offset: 0x001A2711
		public static void Init()
		{
			ConfigSynthesisFormulaByFormulaType.HandleId = ConfigCommon.InitDataStatement(ConfigSynthesisFormulaByFormulaType.HandleId, "db_compose.db", "select BinData from `SynthesisFormula` where FormulaType=?");
		}

		// Token: 0x06003A74 RID: 14964 RVA: 0x001A452C File Offset: 0x001A272C
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

		// Token: 0x040043FC RID: 17404
		private const string DB = "db_compose.db";

		// Token: 0x040043FD RID: 17405
		private const string FILE = "h.合成.xlsx";

		// Token: 0x040043FE RID: 17406
		private const string TABLE = "SynthesisFormula";

		// Token: 0x040043FF RID: 17407
		private const string COMMAND = "select BinData from `SynthesisFormula` where FormulaType=?";

		// Token: 0x04004400 RID: 17408
		private const string KEY_PREFIX = "SynthesisFormulaByFormulaType";

		// Token: 0x04004401 RID: 17409
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004402 RID: 17410
		private static int HandleId;
	}
}

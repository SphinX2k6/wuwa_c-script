using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A90 RID: 2704
	public class ConfigSynthesisFormulaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F74 RID: 16244 RVA: 0x001C3A2F File Offset: 0x001C1C2F
		static ConfigSynthesisFormulaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSynthesisFormulaById.CreateStaticDefaultValue), new Action(ConfigSynthesisFormulaById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F75 RID: 16245 RVA: 0x001C3A50 File Offset: 0x001C1C50
		public static void CreateStaticDefaultValue()
		{
			ConfigSynthesisFormulaById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSynthesisFormulaById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_compose.db"),
				new ValueTuple<string, object>("文件", "h.合成.xlsx"),
				new ValueTuple<string, object>("表名", "SynthesisFormula"),
				new ValueTuple<string, object>("语句", "select BinData from `SynthesisFormula` where Id=?")
			});
		}

		// Token: 0x06003F76 RID: 16246 RVA: 0x001C3ACF File Offset: 0x001C1CCF
		public static void ResetStaticDefaultValue()
		{
			ConfigSynthesisFormulaById.LogPair = null;
			ConfigSynthesisFormulaById.HandleId = 0;
		}

		// Token: 0x06003F77 RID: 16247 RVA: 0x001C3ADD File Offset: 0x001C1CDD
		public static void Init()
		{
			ConfigSynthesisFormulaById.HandleId = ConfigCommon.InitDataStatement(ConfigSynthesisFormulaById.HandleId, "db_compose.db", "select BinData from `SynthesisFormula` where Id=?");
		}

		// Token: 0x06003F78 RID: 16248 RVA: 0x001C3AF8 File Offset: 0x001C1CF8
		public static SynthesisFormula? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSynthesisFormulaById.HandleId, ConfigSynthesisFormulaById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SynthesisFormulaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SynthesisFormula?(SynthesisFormula.GetRootAsSynthesisFormula(configBuffer));
				}
			}
			ConfigSynthesisFormulaById.LogPair.Clear();
			ConfigSynthesisFormulaById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSynthesisFormulaById.HandleId, 1, p0Id, ConfigSynthesisFormulaById.LogPair) || ConfigCommon.Step(ConfigSynthesisFormulaById.HandleId, true, ConfigSynthesisFormulaById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSynthesisFormulaById.HandleId, ConfigSynthesisFormulaById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSynthesisFormulaById.HandleId, 0, ConfigSynthesisFormulaById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSynthesisFormulaById.HandleId, ConfigSynthesisFormulaById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SynthesisFormula rootAsSynthesisFormula = SynthesisFormula.GetRootAsSynthesisFormula(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SynthesisFormulaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSynthesisFormulaById.HandleId, ConfigSynthesisFormulaById.LogPair);
			return new SynthesisFormula?(rootAsSynthesisFormula);
		}

		// Token: 0x040049D6 RID: 18902
		private const string DB = "db_compose.db";

		// Token: 0x040049D7 RID: 18903
		private const string FILE = "h.合成.xlsx";

		// Token: 0x040049D8 RID: 18904
		private const string TABLE = "SynthesisFormula";

		// Token: 0x040049D9 RID: 18905
		private const string COMMAND = "select BinData from `SynthesisFormula` where Id=?";

		// Token: 0x040049DA RID: 18906
		private const string KEY_PREFIX = "SynthesisFormulaById";

		// Token: 0x040049DB RID: 18907
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040049DC RID: 18908
		private static int HandleId;
	}
}

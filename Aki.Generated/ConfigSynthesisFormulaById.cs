using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009BB RID: 2491
	public class ConfigSynthesisFormulaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A76 RID: 14966 RVA: 0x001A469B File Offset: 0x001A289B
		static ConfigSynthesisFormulaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSynthesisFormulaById.CreateStaticDefaultValue), new Action(ConfigSynthesisFormulaById.ResetStaticDefaultValue));
		}

		// Token: 0x06003A77 RID: 14967 RVA: 0x001A46BC File Offset: 0x001A28BC
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

		// Token: 0x06003A78 RID: 14968 RVA: 0x001A473B File Offset: 0x001A293B
		public static void ResetStaticDefaultValue()
		{
			ConfigSynthesisFormulaById.LogPair = null;
			ConfigSynthesisFormulaById.HandleId = 0;
		}

		// Token: 0x06003A79 RID: 14969 RVA: 0x001A4749 File Offset: 0x001A2949
		public static void Init()
		{
			ConfigSynthesisFormulaById.HandleId = ConfigCommon.InitDataStatement(ConfigSynthesisFormulaById.HandleId, "db_compose.db", "select BinData from `SynthesisFormula` where Id=?");
		}

		// Token: 0x06003A7A RID: 14970 RVA: 0x001A4764 File Offset: 0x001A2964
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

		// Token: 0x04004403 RID: 17411
		private const string DB = "db_compose.db";

		// Token: 0x04004404 RID: 17412
		private const string FILE = "h.合成.xlsx";

		// Token: 0x04004405 RID: 17413
		private const string TABLE = "SynthesisFormula";

		// Token: 0x04004406 RID: 17414
		private const string COMMAND = "select BinData from `SynthesisFormula` where Id=?";

		// Token: 0x04004407 RID: 17415
		private const string KEY_PREFIX = "SynthesisFormulaById";

		// Token: 0x04004408 RID: 17416
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004409 RID: 17417
		private static int HandleId;
	}
}

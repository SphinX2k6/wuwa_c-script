using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009B9 RID: 2489
	public class ConfigSynthesisFormulaByFormulaItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A6A RID: 14954 RVA: 0x001A421D File Offset: 0x001A241D
		static ConfigSynthesisFormulaByFormulaItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSynthesisFormulaByFormulaItemId.CreateStaticDefaultValue), new Action(ConfigSynthesisFormulaByFormulaItemId.ResetStaticDefaultValue));
		}

		// Token: 0x06003A6B RID: 14955 RVA: 0x001A423C File Offset: 0x001A243C
		public static void CreateStaticDefaultValue()
		{
			ConfigSynthesisFormulaByFormulaItemId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSynthesisFormulaByFormulaItemId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_compose.db"),
				new ValueTuple<string, object>("文件", "h.合成.xlsx"),
				new ValueTuple<string, object>("表名", "SynthesisFormula"),
				new ValueTuple<string, object>("语句", "select BinData from `SynthesisFormula` where FormulaItemId=?")
			});
		}

		// Token: 0x06003A6C RID: 14956 RVA: 0x001A42BB File Offset: 0x001A24BB
		public static void ResetStaticDefaultValue()
		{
			ConfigSynthesisFormulaByFormulaItemId.LogPair = null;
			ConfigSynthesisFormulaByFormulaItemId.HandleId = 0;
		}

		// Token: 0x06003A6D RID: 14957 RVA: 0x001A42C9 File Offset: 0x001A24C9
		public static void Init()
		{
			ConfigSynthesisFormulaByFormulaItemId.HandleId = ConfigCommon.InitDataStatement(ConfigSynthesisFormulaByFormulaItemId.HandleId, "db_compose.db", "select BinData from `SynthesisFormula` where FormulaItemId=?");
		}

		// Token: 0x06003A6E RID: 14958 RVA: 0x001A42E4 File Offset: 0x001A24E4
		public static SynthesisFormula? GetConfig(int p0FormulaItemId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSynthesisFormulaByFormulaItemId.HandleId, ConfigSynthesisFormulaByFormulaItemId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SynthesisFormulaByFormulaItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FormulaItemId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SynthesisFormula?(SynthesisFormula.GetRootAsSynthesisFormula(configBuffer));
				}
			}
			ConfigSynthesisFormulaByFormulaItemId.LogPair.Clear();
			ConfigSynthesisFormulaByFormulaItemId.LogPair.Add(new ValueTuple<string, object>("FormulaItemId", p0FormulaItemId));
			if (!ConfigCommon.BindInt(ConfigSynthesisFormulaByFormulaItemId.HandleId, 1, p0FormulaItemId, ConfigSynthesisFormulaByFormulaItemId.LogPair) || ConfigCommon.Step(ConfigSynthesisFormulaByFormulaItemId.HandleId, true, ConfigSynthesisFormulaByFormulaItemId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSynthesisFormulaByFormulaItemId.HandleId, ConfigSynthesisFormulaByFormulaItemId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSynthesisFormulaByFormulaItemId.HandleId, 0, ConfigSynthesisFormulaByFormulaItemId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSynthesisFormulaByFormulaItemId.HandleId, ConfigSynthesisFormulaByFormulaItemId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SynthesisFormula rootAsSynthesisFormula = SynthesisFormula.GetRootAsSynthesisFormula(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SynthesisFormulaByFormulaItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FormulaItemId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSynthesisFormulaByFormulaItemId.HandleId, ConfigSynthesisFormulaByFormulaItemId.LogPair);
			return new SynthesisFormula?(rootAsSynthesisFormula);
		}

		// Token: 0x040043F5 RID: 17397
		private const string DB = "db_compose.db";

		// Token: 0x040043F6 RID: 17398
		private const string FILE = "h.合成.xlsx";

		// Token: 0x040043F7 RID: 17399
		private const string TABLE = "SynthesisFormula";

		// Token: 0x040043F8 RID: 17400
		private const string COMMAND = "select BinData from `SynthesisFormula` where FormulaItemId=?";

		// Token: 0x040043F9 RID: 17401
		private const string KEY_PREFIX = "SynthesisFormulaByFormulaItemId";

		// Token: 0x040043FA RID: 17402
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043FB RID: 17403
		private static int HandleId;
	}
}

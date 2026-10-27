using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009BC RID: 2492
	public class ConfigSynthesisFormulaByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A7C RID: 14972 RVA: 0x001A48E4 File Offset: 0x001A2AE4
		static ConfigSynthesisFormulaByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSynthesisFormulaByItemId.CreateStaticDefaultValue), new Action(ConfigSynthesisFormulaByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x06003A7D RID: 14973 RVA: 0x001A4904 File Offset: 0x001A2B04
		public static void CreateStaticDefaultValue()
		{
			ConfigSynthesisFormulaByItemId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSynthesisFormulaByItemId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_compose.db"),
				new ValueTuple<string, object>("文件", "h.合成.xlsx"),
				new ValueTuple<string, object>("表名", "SynthesisFormula"),
				new ValueTuple<string, object>("语句", "select BinData from `SynthesisFormula` where ItemId=?")
			});
		}

		// Token: 0x06003A7E RID: 14974 RVA: 0x001A4983 File Offset: 0x001A2B83
		public static void ResetStaticDefaultValue()
		{
			ConfigSynthesisFormulaByItemId.LogPair = null;
			ConfigSynthesisFormulaByItemId.HandleId = 0;
		}

		// Token: 0x06003A7F RID: 14975 RVA: 0x001A4991 File Offset: 0x001A2B91
		public static void Init()
		{
			ConfigSynthesisFormulaByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigSynthesisFormulaByItemId.HandleId, "db_compose.db", "select BinData from `SynthesisFormula` where ItemId=?");
		}

		// Token: 0x06003A80 RID: 14976 RVA: 0x001A49AC File Offset: 0x001A2BAC
		public static SynthesisFormula? GetConfig(int p0ItemId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSynthesisFormulaByItemId.HandleId, ConfigSynthesisFormulaByItemId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SynthesisFormulaByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SynthesisFormula?(SynthesisFormula.GetRootAsSynthesisFormula(configBuffer));
				}
			}
			ConfigSynthesisFormulaByItemId.LogPair.Clear();
			ConfigSynthesisFormulaByItemId.LogPair.Add(new ValueTuple<string, object>("ItemId", p0ItemId));
			if (!ConfigCommon.BindInt(ConfigSynthesisFormulaByItemId.HandleId, 1, p0ItemId, ConfigSynthesisFormulaByItemId.LogPair) || ConfigCommon.Step(ConfigSynthesisFormulaByItemId.HandleId, false, ConfigSynthesisFormulaByItemId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSynthesisFormulaByItemId.HandleId, ConfigSynthesisFormulaByItemId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSynthesisFormulaByItemId.HandleId, 0, ConfigSynthesisFormulaByItemId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSynthesisFormulaByItemId.HandleId, ConfigSynthesisFormulaByItemId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SynthesisFormula rootAsSynthesisFormula = SynthesisFormula.GetRootAsSynthesisFormula(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SynthesisFormulaByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSynthesisFormulaByItemId.HandleId, ConfigSynthesisFormulaByItemId.LogPair);
			return new SynthesisFormula?(rootAsSynthesisFormula);
		}

		// Token: 0x0400440A RID: 17418
		private const string DB = "db_compose.db";

		// Token: 0x0400440B RID: 17419
		private const string FILE = "h.合成.xlsx";

		// Token: 0x0400440C RID: 17420
		private const string TABLE = "SynthesisFormula";

		// Token: 0x0400440D RID: 17421
		private const string COMMAND = "select BinData from `SynthesisFormula` where ItemId=?";

		// Token: 0x0400440E RID: 17422
		private const string KEY_PREFIX = "SynthesisFormulaByItemId";

		// Token: 0x0400440F RID: 17423
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004410 RID: 17424
		private static int HandleId;
	}
}

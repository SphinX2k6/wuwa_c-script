using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A8E RID: 2702
	public class ConfigSynthesisFormulaByFormulaItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F68 RID: 16232 RVA: 0x001C35B1 File Offset: 0x001C17B1
		static ConfigSynthesisFormulaByFormulaItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSynthesisFormulaByFormulaItemId.CreateStaticDefaultValue), new Action(ConfigSynthesisFormulaByFormulaItemId.ResetStaticDefaultValue));
		}

		// Token: 0x06003F69 RID: 16233 RVA: 0x001C35D0 File Offset: 0x001C17D0
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

		// Token: 0x06003F6A RID: 16234 RVA: 0x001C364F File Offset: 0x001C184F
		public static void ResetStaticDefaultValue()
		{
			ConfigSynthesisFormulaByFormulaItemId.LogPair = null;
			ConfigSynthesisFormulaByFormulaItemId.HandleId = 0;
		}

		// Token: 0x06003F6B RID: 16235 RVA: 0x001C365D File Offset: 0x001C185D
		public static void Init()
		{
			ConfigSynthesisFormulaByFormulaItemId.HandleId = ConfigCommon.InitDataStatement(ConfigSynthesisFormulaByFormulaItemId.HandleId, "db_compose.db", "select BinData from `SynthesisFormula` where FormulaItemId=?");
		}

		// Token: 0x06003F6C RID: 16236 RVA: 0x001C3678 File Offset: 0x001C1878
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

		// Token: 0x040049C8 RID: 18888
		private const string DB = "db_compose.db";

		// Token: 0x040049C9 RID: 18889
		private const string FILE = "h.合成.xlsx";

		// Token: 0x040049CA RID: 18890
		private const string TABLE = "SynthesisFormula";

		// Token: 0x040049CB RID: 18891
		private const string COMMAND = "select BinData from `SynthesisFormula` where FormulaItemId=?";

		// Token: 0x040049CC RID: 18892
		private const string KEY_PREFIX = "SynthesisFormulaByFormulaItemId";

		// Token: 0x040049CD RID: 18893
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040049CE RID: 18894
		private static int HandleId;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A91 RID: 2705
	public class ConfigSynthesisFormulaByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F7A RID: 16250 RVA: 0x001C3C78 File Offset: 0x001C1E78
		static ConfigSynthesisFormulaByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSynthesisFormulaByItemId.CreateStaticDefaultValue), new Action(ConfigSynthesisFormulaByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x06003F7B RID: 16251 RVA: 0x001C3C98 File Offset: 0x001C1E98
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

		// Token: 0x06003F7C RID: 16252 RVA: 0x001C3D17 File Offset: 0x001C1F17
		public static void ResetStaticDefaultValue()
		{
			ConfigSynthesisFormulaByItemId.LogPair = null;
			ConfigSynthesisFormulaByItemId.HandleId = 0;
		}

		// Token: 0x06003F7D RID: 16253 RVA: 0x001C3D25 File Offset: 0x001C1F25
		public static void Init()
		{
			ConfigSynthesisFormulaByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigSynthesisFormulaByItemId.HandleId, "db_compose.db", "select BinData from `SynthesisFormula` where ItemId=?");
		}

		// Token: 0x06003F7E RID: 16254 RVA: 0x001C3D40 File Offset: 0x001C1F40
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

		// Token: 0x040049DD RID: 18909
		private const string DB = "db_compose.db";

		// Token: 0x040049DE RID: 18910
		private const string FILE = "h.合成.xlsx";

		// Token: 0x040049DF RID: 18911
		private const string TABLE = "SynthesisFormula";

		// Token: 0x040049E0 RID: 18912
		private const string COMMAND = "select BinData from `SynthesisFormula` where ItemId=?";

		// Token: 0x040049E1 RID: 18913
		private const string KEY_PREFIX = "SynthesisFormulaByItemId";

		// Token: 0x040049E2 RID: 18914
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040049E3 RID: 18915
		private static int HandleId;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200019D RID: 413
	public class ConfigCookFormulaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009B1 RID: 2481 RVA: 0x00090488 File Offset: 0x0008E688
		static ConfigCookFormulaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCookFormulaById.CreateStaticDefaultValue), new Action(ConfigCookFormulaById.ResetStaticDefaultValue));
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x000904A8 File Offset: 0x0008E6A8
		public static void CreateStaticDefaultValue()
		{
			ConfigCookFormulaById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCookFormulaById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cook.db"),
				new ValueTuple<string, object>("文件", "p.烹饪.xlsx"),
				new ValueTuple<string, object>("表名", "CookFormula"),
				new ValueTuple<string, object>("语句", "select BinData from `CookFormula` where Id=?")
			});
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00090527 File Offset: 0x0008E727
		public static void ResetStaticDefaultValue()
		{
			ConfigCookFormulaById.LogPair = null;
			ConfigCookFormulaById.HandleId = 0;
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00090535 File Offset: 0x0008E735
		public static void Init()
		{
			ConfigCookFormulaById.HandleId = ConfigCommon.InitDataStatement(ConfigCookFormulaById.HandleId, "db_cook.db", "select BinData from `CookFormula` where Id=?");
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00090550 File Offset: 0x0008E750
		public static CookFormula? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCookFormulaById.HandleId, ConfigCookFormulaById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CookFormulaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CookFormula?(CookFormula.GetRootAsCookFormula(configBuffer));
				}
			}
			ConfigCookFormulaById.LogPair.Clear();
			ConfigCookFormulaById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCookFormulaById.HandleId, 1, p0Id, ConfigCookFormulaById.LogPair) || ConfigCommon.Step(ConfigCookFormulaById.HandleId, true, ConfigCookFormulaById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCookFormulaById.HandleId, ConfigCookFormulaById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCookFormulaById.HandleId, 0, ConfigCookFormulaById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCookFormulaById.HandleId, ConfigCookFormulaById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CookFormula rootAsCookFormula = CookFormula.GetRootAsCookFormula(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CookFormulaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCookFormulaById.HandleId, ConfigCookFormulaById.LogPair);
			return new CookFormula?(rootAsCookFormula);
		}

		// Token: 0x04000B2F RID: 2863
		private const string DB = "db_cook.db";

		// Token: 0x04000B30 RID: 2864
		private const string FILE = "p.烹饪.xlsx";

		// Token: 0x04000B31 RID: 2865
		private const string TABLE = "CookFormula";

		// Token: 0x04000B32 RID: 2866
		private const string COMMAND = "select BinData from `CookFormula` where Id=?";

		// Token: 0x04000B33 RID: 2867
		private const string KEY_PREFIX = "CookFormulaById";

		// Token: 0x04000B34 RID: 2868
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B35 RID: 2869
		private static int HandleId;
	}
}

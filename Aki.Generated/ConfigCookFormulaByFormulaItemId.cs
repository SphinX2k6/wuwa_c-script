using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200019C RID: 412
	public class ConfigCookFormulaByFormulaItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009AB RID: 2475 RVA: 0x0009023F File Offset: 0x0008E43F
		static ConfigCookFormulaByFormulaItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCookFormulaByFormulaItemId.CreateStaticDefaultValue), new Action(ConfigCookFormulaByFormulaItemId.ResetStaticDefaultValue));
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x00090260 File Offset: 0x0008E460
		public static void CreateStaticDefaultValue()
		{
			ConfigCookFormulaByFormulaItemId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCookFormulaByFormulaItemId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cook.db"),
				new ValueTuple<string, object>("文件", "p.烹饪.xlsx"),
				new ValueTuple<string, object>("表名", "CookFormula"),
				new ValueTuple<string, object>("语句", "select BinData from `CookFormula` where FormulaItemId=?")
			});
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x000902DF File Offset: 0x0008E4DF
		public static void ResetStaticDefaultValue()
		{
			ConfigCookFormulaByFormulaItemId.LogPair = null;
			ConfigCookFormulaByFormulaItemId.HandleId = 0;
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x000902ED File Offset: 0x0008E4ED
		public static void Init()
		{
			ConfigCookFormulaByFormulaItemId.HandleId = ConfigCommon.InitDataStatement(ConfigCookFormulaByFormulaItemId.HandleId, "db_cook.db", "select BinData from `CookFormula` where FormulaItemId=?");
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x00090308 File Offset: 0x0008E508
		public static CookFormula? GetConfig(int p0FormulaItemId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCookFormulaByFormulaItemId.HandleId, ConfigCookFormulaByFormulaItemId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CookFormulaByFormulaItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FormulaItemId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CookFormula?(CookFormula.GetRootAsCookFormula(configBuffer));
				}
			}
			ConfigCookFormulaByFormulaItemId.LogPair.Clear();
			ConfigCookFormulaByFormulaItemId.LogPair.Add(new ValueTuple<string, object>("FormulaItemId", p0FormulaItemId));
			if (!ConfigCommon.BindInt(ConfigCookFormulaByFormulaItemId.HandleId, 1, p0FormulaItemId, ConfigCookFormulaByFormulaItemId.LogPair) || ConfigCommon.Step(ConfigCookFormulaByFormulaItemId.HandleId, true, ConfigCookFormulaByFormulaItemId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCookFormulaByFormulaItemId.HandleId, ConfigCookFormulaByFormulaItemId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCookFormulaByFormulaItemId.HandleId, 0, ConfigCookFormulaByFormulaItemId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCookFormulaByFormulaItemId.HandleId, ConfigCookFormulaByFormulaItemId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CookFormula rootAsCookFormula = CookFormula.GetRootAsCookFormula(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CookFormulaByFormulaItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FormulaItemId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCookFormulaByFormulaItemId.HandleId, ConfigCookFormulaByFormulaItemId.LogPair);
			return new CookFormula?(rootAsCookFormula);
		}

		// Token: 0x04000B28 RID: 2856
		private const string DB = "db_cook.db";

		// Token: 0x04000B29 RID: 2857
		private const string FILE = "p.烹饪.xlsx";

		// Token: 0x04000B2A RID: 2858
		private const string TABLE = "CookFormula";

		// Token: 0x04000B2B RID: 2859
		private const string COMMAND = "select BinData from `CookFormula` where FormulaItemId=?";

		// Token: 0x04000B2C RID: 2860
		private const string KEY_PREFIX = "CookFormulaByFormulaItemId";

		// Token: 0x04000B2D RID: 2861
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B2E RID: 2862
		private static int HandleId;
	}
}

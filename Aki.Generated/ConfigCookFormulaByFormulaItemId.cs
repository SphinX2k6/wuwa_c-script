using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001AE RID: 430
	public class ConfigCookFormulaByFormulaItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A17 RID: 2583 RVA: 0x00096177 File Offset: 0x00094377
		static ConfigCookFormulaByFormulaItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCookFormulaByFormulaItemId.CreateStaticDefaultValue), new Action(ConfigCookFormulaByFormulaItemId.ResetStaticDefaultValue));
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00096198 File Offset: 0x00094398
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

		// Token: 0x06000A19 RID: 2585 RVA: 0x00096217 File Offset: 0x00094417
		public static void ResetStaticDefaultValue()
		{
			ConfigCookFormulaByFormulaItemId.LogPair = null;
			ConfigCookFormulaByFormulaItemId.HandleId = 0;
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00096225 File Offset: 0x00094425
		public static void Init()
		{
			ConfigCookFormulaByFormulaItemId.HandleId = ConfigCommon.InitDataStatement(ConfigCookFormulaByFormulaItemId.HandleId, "db_cook.db", "select BinData from `CookFormula` where FormulaItemId=?");
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x00096240 File Offset: 0x00094440
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

		// Token: 0x04000BA6 RID: 2982
		private const string DB = "db_cook.db";

		// Token: 0x04000BA7 RID: 2983
		private const string FILE = "p.烹饪.xlsx";

		// Token: 0x04000BA8 RID: 2984
		private const string TABLE = "CookFormula";

		// Token: 0x04000BA9 RID: 2985
		private const string COMMAND = "select BinData from `CookFormula` where FormulaItemId=?";

		// Token: 0x04000BAA RID: 2986
		private const string KEY_PREFIX = "CookFormulaByFormulaItemId";

		// Token: 0x04000BAB RID: 2987
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000BAC RID: 2988
		private static int HandleId;
	}
}

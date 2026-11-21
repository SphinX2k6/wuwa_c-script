using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001AF RID: 431
	public class ConfigCookFormulaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A1D RID: 2589 RVA: 0x000963C0 File Offset: 0x000945C0
		static ConfigCookFormulaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCookFormulaById.CreateStaticDefaultValue), new Action(ConfigCookFormulaById.ResetStaticDefaultValue));
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x000963E0 File Offset: 0x000945E0
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

		// Token: 0x06000A1F RID: 2591 RVA: 0x0009645F File Offset: 0x0009465F
		public static void ResetStaticDefaultValue()
		{
			ConfigCookFormulaById.LogPair = null;
			ConfigCookFormulaById.HandleId = 0;
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0009646D File Offset: 0x0009466D
		public static void Init()
		{
			ConfigCookFormulaById.HandleId = ConfigCommon.InitDataStatement(ConfigCookFormulaById.HandleId, "db_cook.db", "select BinData from `CookFormula` where Id=?");
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00096488 File Offset: 0x00094688
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

		// Token: 0x04000BAD RID: 2989
		private const string DB = "db_cook.db";

		// Token: 0x04000BAE RID: 2990
		private const string FILE = "p.烹饪.xlsx";

		// Token: 0x04000BAF RID: 2991
		private const string TABLE = "CookFormula";

		// Token: 0x04000BB0 RID: 2992
		private const string COMMAND = "select BinData from `CookFormula` where Id=?";

		// Token: 0x04000BB1 RID: 2993
		private const string KEY_PREFIX = "CookFormulaById";

		// Token: 0x04000BB2 RID: 2994
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000BB3 RID: 2995
		private static int HandleId;
	}
}

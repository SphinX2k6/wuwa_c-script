using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200034A RID: 842
	public class ConfigForgeFormulaByFormulaItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013C1 RID: 5057 RVA: 0x000C924B File Offset: 0x000C744B
		static ConfigForgeFormulaByFormulaItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigForgeFormulaByFormulaItemId.CreateStaticDefaultValue), new Action(ConfigForgeFormulaByFormulaItemId.ResetStaticDefaultValue));
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x000C926C File Offset: 0x000C746C
		public static void CreateStaticDefaultValue()
		{
			ConfigForgeFormulaByFormulaItemId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigForgeFormulaByFormulaItemId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_forge.db"),
				new ValueTuple<string, object>("文件", "d.锻造.xlsx"),
				new ValueTuple<string, object>("表名", "ForgeFormula"),
				new ValueTuple<string, object>("语句", "select BinData from `ForgeFormula` where FormulaItemId=?")
			});
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x000C92EB File Offset: 0x000C74EB
		public static void ResetStaticDefaultValue()
		{
			ConfigForgeFormulaByFormulaItemId.LogPair = null;
			ConfigForgeFormulaByFormulaItemId.HandleId = 0;
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x000C92F9 File Offset: 0x000C74F9
		public static void Init()
		{
			ConfigForgeFormulaByFormulaItemId.HandleId = ConfigCommon.InitDataStatement(ConfigForgeFormulaByFormulaItemId.HandleId, "db_forge.db", "select BinData from `ForgeFormula` where FormulaItemId=?");
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x000C9314 File Offset: 0x000C7514
		public static ForgeFormula? GetConfig(int p0FormulaItemId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigForgeFormulaByFormulaItemId.HandleId, ConfigForgeFormulaByFormulaItemId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ForgeFormulaByFormulaItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FormulaItemId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ForgeFormula?(ForgeFormula.GetRootAsForgeFormula(configBuffer));
				}
			}
			ConfigForgeFormulaByFormulaItemId.LogPair.Clear();
			ConfigForgeFormulaByFormulaItemId.LogPair.Add(new ValueTuple<string, object>("FormulaItemId", p0FormulaItemId));
			if (!ConfigCommon.BindInt(ConfigForgeFormulaByFormulaItemId.HandleId, 1, p0FormulaItemId, ConfigForgeFormulaByFormulaItemId.LogPair) || ConfigCommon.Step(ConfigForgeFormulaByFormulaItemId.HandleId, true, ConfigForgeFormulaByFormulaItemId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigForgeFormulaByFormulaItemId.HandleId, ConfigForgeFormulaByFormulaItemId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigForgeFormulaByFormulaItemId.HandleId, 0, ConfigForgeFormulaByFormulaItemId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigForgeFormulaByFormulaItemId.HandleId, ConfigForgeFormulaByFormulaItemId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ForgeFormula rootAsForgeFormula = ForgeFormula.GetRootAsForgeFormula(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ForgeFormulaByFormulaItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FormulaItemId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigForgeFormulaByFormulaItemId.HandleId, ConfigForgeFormulaByFormulaItemId.LogPair);
			return new ForgeFormula?(rootAsForgeFormula);
		}

		// Token: 0x040016EA RID: 5866
		private const string DB = "db_forge.db";

		// Token: 0x040016EB RID: 5867
		private const string FILE = "d.锻造.xlsx";

		// Token: 0x040016EC RID: 5868
		private const string TABLE = "ForgeFormula";

		// Token: 0x040016ED RID: 5869
		private const string COMMAND = "select BinData from `ForgeFormula` where FormulaItemId=?";

		// Token: 0x040016EE RID: 5870
		private const string KEY_PREFIX = "ForgeFormulaByFormulaItemId";

		// Token: 0x040016EF RID: 5871
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016F0 RID: 5872
		private static int HandleId;
	}
}

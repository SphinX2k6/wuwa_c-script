using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200035F RID: 863
	public class ConfigForgeFormulaByFormulaItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600143F RID: 5183 RVA: 0x000CF757 File Offset: 0x000CD957
		static ConfigForgeFormulaByFormulaItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigForgeFormulaByFormulaItemId.CreateStaticDefaultValue), new Action(ConfigForgeFormulaByFormulaItemId.ResetStaticDefaultValue));
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x000CF778 File Offset: 0x000CD978
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

		// Token: 0x06001441 RID: 5185 RVA: 0x000CF7F7 File Offset: 0x000CD9F7
		public static void ResetStaticDefaultValue()
		{
			ConfigForgeFormulaByFormulaItemId.LogPair = null;
			ConfigForgeFormulaByFormulaItemId.HandleId = 0;
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x000CF805 File Offset: 0x000CDA05
		public static void Init()
		{
			ConfigForgeFormulaByFormulaItemId.HandleId = ConfigCommon.InitDataStatement(ConfigForgeFormulaByFormulaItemId.HandleId, "db_forge.db", "select BinData from `ForgeFormula` where FormulaItemId=?");
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x000CF820 File Offset: 0x000CDA20
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

		// Token: 0x0400177D RID: 6013
		private const string DB = "db_forge.db";

		// Token: 0x0400177E RID: 6014
		private const string FILE = "d.锻造.xlsx";

		// Token: 0x0400177F RID: 6015
		private const string TABLE = "ForgeFormula";

		// Token: 0x04001780 RID: 6016
		private const string COMMAND = "select BinData from `ForgeFormula` where FormulaItemId=?";

		// Token: 0x04001781 RID: 6017
		private const string KEY_PREFIX = "ForgeFormulaByFormulaItemId";

		// Token: 0x04001782 RID: 6018
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001783 RID: 6019
		private static int HandleId;
	}
}

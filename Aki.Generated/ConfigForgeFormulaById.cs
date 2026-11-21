using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000360 RID: 864
	public class ConfigForgeFormulaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001445 RID: 5189 RVA: 0x000CF9A0 File Offset: 0x000CDBA0
		static ConfigForgeFormulaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigForgeFormulaById.CreateStaticDefaultValue), new Action(ConfigForgeFormulaById.ResetStaticDefaultValue));
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x000CF9C0 File Offset: 0x000CDBC0
		public static void CreateStaticDefaultValue()
		{
			ConfigForgeFormulaById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigForgeFormulaById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_forge.db"),
				new ValueTuple<string, object>("文件", "d.锻造.xlsx"),
				new ValueTuple<string, object>("表名", "ForgeFormula"),
				new ValueTuple<string, object>("语句", "select BinData from `ForgeFormula` where Id=?")
			});
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x000CFA3F File Offset: 0x000CDC3F
		public static void ResetStaticDefaultValue()
		{
			ConfigForgeFormulaById.LogPair = null;
			ConfigForgeFormulaById.HandleId = 0;
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x000CFA4D File Offset: 0x000CDC4D
		public static void Init()
		{
			ConfigForgeFormulaById.HandleId = ConfigCommon.InitDataStatement(ConfigForgeFormulaById.HandleId, "db_forge.db", "select BinData from `ForgeFormula` where Id=?");
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x000CFA68 File Offset: 0x000CDC68
		public static ForgeFormula? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigForgeFormulaById.HandleId, ConfigForgeFormulaById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ForgeFormulaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ForgeFormula?(ForgeFormula.GetRootAsForgeFormula(configBuffer));
				}
			}
			ConfigForgeFormulaById.LogPair.Clear();
			ConfigForgeFormulaById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigForgeFormulaById.HandleId, 1, p0Id, ConfigForgeFormulaById.LogPair) || ConfigCommon.Step(ConfigForgeFormulaById.HandleId, true, ConfigForgeFormulaById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigForgeFormulaById.HandleId, ConfigForgeFormulaById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigForgeFormulaById.HandleId, 0, ConfigForgeFormulaById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigForgeFormulaById.HandleId, ConfigForgeFormulaById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ForgeFormula rootAsForgeFormula = ForgeFormula.GetRootAsForgeFormula(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ForgeFormulaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigForgeFormulaById.HandleId, ConfigForgeFormulaById.LogPair);
			return new ForgeFormula?(rootAsForgeFormula);
		}

		// Token: 0x04001784 RID: 6020
		private const string DB = "db_forge.db";

		// Token: 0x04001785 RID: 6021
		private const string FILE = "d.锻造.xlsx";

		// Token: 0x04001786 RID: 6022
		private const string TABLE = "ForgeFormula";

		// Token: 0x04001787 RID: 6023
		private const string COMMAND = "select BinData from `ForgeFormula` where Id=?";

		// Token: 0x04001788 RID: 6024
		private const string KEY_PREFIX = "ForgeFormulaById";

		// Token: 0x04001789 RID: 6025
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400178A RID: 6026
		private static int HandleId;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200034B RID: 843
	public class ConfigForgeFormulaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013C7 RID: 5063 RVA: 0x000C9494 File Offset: 0x000C7694
		static ConfigForgeFormulaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigForgeFormulaById.CreateStaticDefaultValue), new Action(ConfigForgeFormulaById.ResetStaticDefaultValue));
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x000C94B4 File Offset: 0x000C76B4
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

		// Token: 0x060013C9 RID: 5065 RVA: 0x000C9533 File Offset: 0x000C7733
		public static void ResetStaticDefaultValue()
		{
			ConfigForgeFormulaById.LogPair = null;
			ConfigForgeFormulaById.HandleId = 0;
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x000C9541 File Offset: 0x000C7741
		public static void Init()
		{
			ConfigForgeFormulaById.HandleId = ConfigCommon.InitDataStatement(ConfigForgeFormulaById.HandleId, "db_forge.db", "select BinData from `ForgeFormula` where Id=?");
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x000C955C File Offset: 0x000C775C
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

		// Token: 0x040016F1 RID: 5873
		private const string DB = "db_forge.db";

		// Token: 0x040016F2 RID: 5874
		private const string FILE = "d.锻造.xlsx";

		// Token: 0x040016F3 RID: 5875
		private const string TABLE = "ForgeFormula";

		// Token: 0x040016F4 RID: 5876
		private const string COMMAND = "select BinData from `ForgeFormula` where Id=?";

		// Token: 0x040016F5 RID: 5877
		private const string KEY_PREFIX = "ForgeFormulaById";

		// Token: 0x040016F6 RID: 5878
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016F7 RID: 5879
		private static int HandleId;
	}
}

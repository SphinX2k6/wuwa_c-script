using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200034C RID: 844
	public class ConfigForgeFormulaByTypeId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013CD RID: 5069 RVA: 0x000C96DC File Offset: 0x000C78DC
		static ConfigForgeFormulaByTypeId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigForgeFormulaByTypeId.CreateStaticDefaultValue), new Action(ConfigForgeFormulaByTypeId.ResetStaticDefaultValue));
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x000C96FC File Offset: 0x000C78FC
		public static void CreateStaticDefaultValue()
		{
			ConfigForgeFormulaByTypeId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigForgeFormulaByTypeId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_forge.db"),
				new ValueTuple<string, object>("文件", "d.锻造.xlsx"),
				new ValueTuple<string, object>("表名", "ForgeFormula"),
				new ValueTuple<string, object>("语句", "select BinData from `ForgeFormula` where TypeId=?")
			});
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x000C977B File Offset: 0x000C797B
		public static void ResetStaticDefaultValue()
		{
			ConfigForgeFormulaByTypeId.LogPair = null;
			ConfigForgeFormulaByTypeId.HandleId = 0;
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x000C9789 File Offset: 0x000C7989
		public static void Init()
		{
			ConfigForgeFormulaByTypeId.HandleId = ConfigCommon.InitDataStatement(ConfigForgeFormulaByTypeId.HandleId, "db_forge.db", "select BinData from `ForgeFormula` where TypeId=?");
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x000C97A4 File Offset: 0x000C79A4
		[NullableContext(2)]
		public static IReadOnlyList<ForgeFormula> GetConfigList(int p0TypeId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigForgeFormulaByTypeId.HandleId, ConfigForgeFormulaByTypeId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ForgeFormulaByTypeId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TypeId);
				IReadOnlyList<ForgeFormula> readOnlyList = (IReadOnlyList<ForgeFormula>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigForgeFormulaByTypeId.LogPair.Clear();
			ConfigForgeFormulaByTypeId.LogPair.Add(new ValueTuple<string, object>("TypeId", p0TypeId));
			if (!ConfigCommon.BindInt(ConfigForgeFormulaByTypeId.HandleId, 1, p0TypeId, ConfigForgeFormulaByTypeId.LogPair))
			{
				ConfigCommon.Reset(ConfigForgeFormulaByTypeId.HandleId, ConfigForgeFormulaByTypeId.LogPair);
				return null;
			}
			List<ForgeFormula> list = new List<ForgeFormula>();
			while (ConfigCommon.Step(ConfigForgeFormulaByTypeId.HandleId, false, ConfigForgeFormulaByTypeId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigForgeFormulaByTypeId.HandleId, 0, ConfigForgeFormulaByTypeId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigForgeFormulaByTypeId.HandleId, ConfigForgeFormulaByTypeId.LogPair);
					return null;
				}
				ForgeFormula rootAsForgeFormula = ForgeFormula.GetRootAsForgeFormula(new ByteBuffer(item2));
				list.Add(rootAsForgeFormula);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ForgeFormulaByTypeId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TypeId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigForgeFormulaByTypeId.HandleId, ConfigForgeFormulaByTypeId.LogPair);
			return list;
		}

		// Token: 0x040016F8 RID: 5880
		private const string DB = "db_forge.db";

		// Token: 0x040016F9 RID: 5881
		private const string FILE = "d.锻造.xlsx";

		// Token: 0x040016FA RID: 5882
		private const string TABLE = "ForgeFormula";

		// Token: 0x040016FB RID: 5883
		private const string COMMAND = "select BinData from `ForgeFormula` where TypeId=?";

		// Token: 0x040016FC RID: 5884
		private const string KEY_PREFIX = "ForgeFormulaByTypeId";

		// Token: 0x040016FD RID: 5885
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016FE RID: 5886
		private static int HandleId;
	}
}

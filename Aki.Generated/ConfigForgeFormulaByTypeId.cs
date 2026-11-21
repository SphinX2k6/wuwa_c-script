using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000361 RID: 865
	public class ConfigForgeFormulaByTypeId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600144B RID: 5195 RVA: 0x000CFBE8 File Offset: 0x000CDDE8
		static ConfigForgeFormulaByTypeId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigForgeFormulaByTypeId.CreateStaticDefaultValue), new Action(ConfigForgeFormulaByTypeId.ResetStaticDefaultValue));
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x000CFC08 File Offset: 0x000CDE08
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

		// Token: 0x0600144D RID: 5197 RVA: 0x000CFC87 File Offset: 0x000CDE87
		public static void ResetStaticDefaultValue()
		{
			ConfigForgeFormulaByTypeId.LogPair = null;
			ConfigForgeFormulaByTypeId.HandleId = 0;
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x000CFC95 File Offset: 0x000CDE95
		public static void Init()
		{
			ConfigForgeFormulaByTypeId.HandleId = ConfigCommon.InitDataStatement(ConfigForgeFormulaByTypeId.HandleId, "db_forge.db", "select BinData from `ForgeFormula` where TypeId=?");
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x000CFCB0 File Offset: 0x000CDEB0
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

		// Token: 0x0400178B RID: 6027
		private const string DB = "db_forge.db";

		// Token: 0x0400178C RID: 6028
		private const string FILE = "d.锻造.xlsx";

		// Token: 0x0400178D RID: 6029
		private const string TABLE = "ForgeFormula";

		// Token: 0x0400178E RID: 6030
		private const string COMMAND = "select BinData from `ForgeFormula` where TypeId=?";

		// Token: 0x0400178F RID: 6031
		private const string KEY_PREFIX = "ForgeFormulaByTypeId";

		// Token: 0x04001790 RID: 6032
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001791 RID: 6033
		private static int HandleId;
	}
}

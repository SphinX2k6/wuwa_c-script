using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000550 RID: 1360
	public class ConfigMaterialReplaceByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FEC RID: 8172 RVA: 0x001114DF File Offset: 0x0010F6DF
		static ConfigMaterialReplaceByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMaterialReplaceByGroupId.CreateStaticDefaultValue), new Action(ConfigMaterialReplaceByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x00111500 File Offset: 0x0010F700
		public static void CreateStaticDefaultValue()
		{
			ConfigMaterialReplaceByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMaterialReplaceByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_compose.db"),
				new ValueTuple<string, object>("文件", "h.合成.xlsx"),
				new ValueTuple<string, object>("表名", "MaterialReplace"),
				new ValueTuple<string, object>("语句", "select BinData from `MaterialReplace` where GroupId = ?")
			});
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x0011157F File Offset: 0x0010F77F
		public static void ResetStaticDefaultValue()
		{
			ConfigMaterialReplaceByGroupId.LogPair = null;
			ConfigMaterialReplaceByGroupId.HandleId = 0;
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x0011158D File Offset: 0x0010F78D
		public static void Init()
		{
			ConfigMaterialReplaceByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigMaterialReplaceByGroupId.HandleId, "db_compose.db", "select BinData from `MaterialReplace` where GroupId = ?");
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x001115A8 File Offset: 0x0010F7A8
		[NullableContext(2)]
		public static IReadOnlyList<MaterialReplace> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMaterialReplaceByGroupId.HandleId, ConfigMaterialReplaceByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MaterialReplaceByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<MaterialReplace> readOnlyList = (IReadOnlyList<MaterialReplace>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMaterialReplaceByGroupId.LogPair.Clear();
			ConfigMaterialReplaceByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigMaterialReplaceByGroupId.HandleId, 1, p0GroupId, ConfigMaterialReplaceByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigMaterialReplaceByGroupId.HandleId, ConfigMaterialReplaceByGroupId.LogPair);
				return null;
			}
			List<MaterialReplace> list = new List<MaterialReplace>();
			while (ConfigCommon.Step(ConfigMaterialReplaceByGroupId.HandleId, false, ConfigMaterialReplaceByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMaterialReplaceByGroupId.HandleId, 0, ConfigMaterialReplaceByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMaterialReplaceByGroupId.HandleId, ConfigMaterialReplaceByGroupId.LogPair);
					return null;
				}
				MaterialReplace rootAsMaterialReplace = MaterialReplace.GetRootAsMaterialReplace(new ByteBuffer(item2));
				list.Add(rootAsMaterialReplace);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MaterialReplaceByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMaterialReplaceByGroupId.HandleId, ConfigMaterialReplaceByGroupId.LogPair);
			return list;
		}

		// Token: 0x04002514 RID: 9492
		private const string DB = "db_compose.db";

		// Token: 0x04002515 RID: 9493
		private const string FILE = "h.合成.xlsx";

		// Token: 0x04002516 RID: 9494
		private const string TABLE = "MaterialReplace";

		// Token: 0x04002517 RID: 9495
		private const string COMMAND = "select BinData from `MaterialReplace` where GroupId = ?";

		// Token: 0x04002518 RID: 9496
		private const string KEY_PREFIX = "MaterialReplaceByGroupId";

		// Token: 0x04002519 RID: 9497
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400251A RID: 9498
		private static int HandleId;
	}
}

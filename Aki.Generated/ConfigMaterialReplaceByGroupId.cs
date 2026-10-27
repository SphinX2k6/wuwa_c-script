using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200053A RID: 1338
	public class ConfigMaterialReplaceByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F68 RID: 8040 RVA: 0x0010AD8B File Offset: 0x00108F8B
		static ConfigMaterialReplaceByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMaterialReplaceByGroupId.CreateStaticDefaultValue), new Action(ConfigMaterialReplaceByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x0010ADAC File Offset: 0x00108FAC
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

		// Token: 0x06001F6A RID: 8042 RVA: 0x0010AE2B File Offset: 0x0010902B
		public static void ResetStaticDefaultValue()
		{
			ConfigMaterialReplaceByGroupId.LogPair = null;
			ConfigMaterialReplaceByGroupId.HandleId = 0;
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x0010AE39 File Offset: 0x00109039
		public static void Init()
		{
			ConfigMaterialReplaceByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigMaterialReplaceByGroupId.HandleId, "db_compose.db", "select BinData from `MaterialReplace` where GroupId = ?");
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x0010AE54 File Offset: 0x00109054
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

		// Token: 0x0400247A RID: 9338
		private const string DB = "db_compose.db";

		// Token: 0x0400247B RID: 9339
		private const string FILE = "h.合成.xlsx";

		// Token: 0x0400247C RID: 9340
		private const string TABLE = "MaterialReplace";

		// Token: 0x0400247D RID: 9341
		private const string COMMAND = "select BinData from `MaterialReplace` where GroupId = ?";

		// Token: 0x0400247E RID: 9342
		private const string KEY_PREFIX = "MaterialReplaceByGroupId";

		// Token: 0x0400247F RID: 9343
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002480 RID: 9344
		private static int HandleId;
	}
}

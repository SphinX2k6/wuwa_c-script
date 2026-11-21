using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000D4 RID: 212
	public class ConfigAxisMappingAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004F9 RID: 1273 RVA: 0x000797CC File Offset: 0x000779CC
		static ConfigAxisMappingAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAxisMappingAll.CreateStaticDefaultValue), new Action(ConfigAxisMappingAll.ResetStaticDefaultValue));
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x000797EC File Offset: 0x000779EC
		public static void CreateStaticDefaultValue()
		{
			ConfigAxisMappingAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAxisMappingAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_input_settings.db"),
				new ValueTuple<string, object>("文件", "s.输入配置.xlsx"),
				new ValueTuple<string, object>("表名", "AxisMapping"),
				new ValueTuple<string, object>("语句", "select BinData from `AxisMapping`")
			});
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0007986B File Offset: 0x00077A6B
		public static void ResetStaticDefaultValue()
		{
			ConfigAxisMappingAll.LogPair = null;
			ConfigAxisMappingAll.HandleId = 0;
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00079879 File Offset: 0x00077A79
		public static void Init()
		{
			ConfigAxisMappingAll.HandleId = ConfigCommon.InitDataStatement(ConfigAxisMappingAll.HandleId, "db_input_settings.db", "select BinData from `AxisMapping`");
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00079894 File Offset: 0x00077A94
		[NullableContext(2)]
		public static IReadOnlyList<AxisMapping> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAxisMappingAll.HandleId, ConfigAxisMappingAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AxisMapping> readOnlyList = (IReadOnlyList<AxisMapping>)ConfigCommon.GetConfig("AxisMappingAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AxisMapping> list = new List<AxisMapping>();
			while (ConfigCommon.Step(ConfigAxisMappingAll.HandleId, false, ConfigAxisMappingAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAxisMappingAll.HandleId, 0, ConfigAxisMappingAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAxisMappingAll.HandleId, ConfigAxisMappingAll.LogPair);
					return null;
				}
				AxisMapping rootAsAxisMapping = AxisMapping.GetRootAsAxisMapping(new ByteBuffer(item2));
				list.Add(rootAsAxisMapping);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AxisMappingAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAxisMappingAll.HandleId, ConfigAxisMappingAll.LogPair);
			return list;
		}

		// Token: 0x040005B0 RID: 1456
		private const string DB = "db_input_settings.db";

		// Token: 0x040005B1 RID: 1457
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x040005B2 RID: 1458
		private const string TABLE = "AxisMapping";

		// Token: 0x040005B3 RID: 1459
		private const string COMMAND = "select BinData from `AxisMapping`";

		// Token: 0x040005B4 RID: 1460
		private const string KEY_PREFIX = "AxisMappingAll";

		// Token: 0x040005B5 RID: 1461
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040005B6 RID: 1462
		private static int HandleId;
	}
}

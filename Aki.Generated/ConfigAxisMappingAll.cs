using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000C5 RID: 197
	public class ConfigAxisMappingAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600049F RID: 1183 RVA: 0x00073E68 File Offset: 0x00072068
		static ConfigAxisMappingAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAxisMappingAll.CreateStaticDefaultValue), new Action(ConfigAxisMappingAll.ResetStaticDefaultValue));
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00073E88 File Offset: 0x00072088
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

		// Token: 0x060004A1 RID: 1185 RVA: 0x00073F07 File Offset: 0x00072107
		public static void ResetStaticDefaultValue()
		{
			ConfigAxisMappingAll.LogPair = null;
			ConfigAxisMappingAll.HandleId = 0;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00073F15 File Offset: 0x00072115
		public static void Init()
		{
			ConfigAxisMappingAll.HandleId = ConfigCommon.InitDataStatement(ConfigAxisMappingAll.HandleId, "db_input_settings.db", "select BinData from `AxisMapping`");
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00073F30 File Offset: 0x00072130
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

		// Token: 0x04000547 RID: 1351
		private const string DB = "db_input_settings.db";

		// Token: 0x04000548 RID: 1352
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04000549 RID: 1353
		private const string TABLE = "AxisMapping";

		// Token: 0x0400054A RID: 1354
		private const string COMMAND = "select BinData from `AxisMapping`";

		// Token: 0x0400054B RID: 1355
		private const string KEY_PREFIX = "AxisMappingAll";

		// Token: 0x0400054C RID: 1356
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400054D RID: 1357
		private static int HandleId;
	}
}

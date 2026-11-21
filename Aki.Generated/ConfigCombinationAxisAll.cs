using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200018E RID: 398
	public class ConfigCombinationAxisAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000955 RID: 2389 RVA: 0x00091C34 File Offset: 0x0008FE34
		static ConfigCombinationAxisAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCombinationAxisAll.CreateStaticDefaultValue), new Action(ConfigCombinationAxisAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00091C54 File Offset: 0x0008FE54
		public static void CreateStaticDefaultValue()
		{
			ConfigCombinationAxisAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCombinationAxisAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_input_settings.db"),
				new ValueTuple<string, object>("文件", "s.输入配置.xlsx"),
				new ValueTuple<string, object>("表名", "CombinationAxis"),
				new ValueTuple<string, object>("语句", "select BinData from `CombinationAxis`")
			});
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00091CD3 File Offset: 0x0008FED3
		public static void ResetStaticDefaultValue()
		{
			ConfigCombinationAxisAll.LogPair = null;
			ConfigCombinationAxisAll.HandleId = 0;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00091CE1 File Offset: 0x0008FEE1
		public static void Init()
		{
			ConfigCombinationAxisAll.HandleId = ConfigCommon.InitDataStatement(ConfigCombinationAxisAll.HandleId, "db_input_settings.db", "select BinData from `CombinationAxis`");
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00091CFC File Offset: 0x0008FEFC
		[NullableContext(2)]
		public static IReadOnlyList<CombinationAxis> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCombinationAxisAll.HandleId, ConfigCombinationAxisAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<CombinationAxis> readOnlyList = (IReadOnlyList<CombinationAxis>)ConfigCommon.GetConfig("CombinationAxisAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<CombinationAxis> list = new List<CombinationAxis>();
			while (ConfigCommon.Step(ConfigCombinationAxisAll.HandleId, false, ConfigCombinationAxisAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCombinationAxisAll.HandleId, 0, ConfigCombinationAxisAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCombinationAxisAll.HandleId, ConfigCombinationAxisAll.LogPair);
					return null;
				}
				CombinationAxis rootAsCombinationAxis = CombinationAxis.GetRootAsCombinationAxis(new ByteBuffer(item2));
				list.Add(rootAsCombinationAxis);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("CombinationAxisAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigCombinationAxisAll.HandleId, ConfigCombinationAxisAll.LogPair);
			return list;
		}

		// Token: 0x04000AC6 RID: 2758
		private const string DB = "db_input_settings.db";

		// Token: 0x04000AC7 RID: 2759
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04000AC8 RID: 2760
		private const string TABLE = "CombinationAxis";

		// Token: 0x04000AC9 RID: 2761
		private const string COMMAND = "select BinData from `CombinationAxis`";

		// Token: 0x04000ACA RID: 2762
		private const string KEY_PREFIX = "CombinationAxisAll";

		// Token: 0x04000ACB RID: 2763
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000ACC RID: 2764
		private static int HandleId;
	}
}

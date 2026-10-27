using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200017C RID: 380
	public class ConfigCombinationAxisAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008E9 RID: 2281 RVA: 0x0008BCFC File Offset: 0x00089EFC
		static ConfigCombinationAxisAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCombinationAxisAll.CreateStaticDefaultValue), new Action(ConfigCombinationAxisAll.ResetStaticDefaultValue));
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0008BD1C File Offset: 0x00089F1C
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

		// Token: 0x060008EB RID: 2283 RVA: 0x0008BD9B File Offset: 0x00089F9B
		public static void ResetStaticDefaultValue()
		{
			ConfigCombinationAxisAll.LogPair = null;
			ConfigCombinationAxisAll.HandleId = 0;
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x0008BDA9 File Offset: 0x00089FA9
		public static void Init()
		{
			ConfigCombinationAxisAll.HandleId = ConfigCommon.InitDataStatement(ConfigCombinationAxisAll.HandleId, "db_input_settings.db", "select BinData from `CombinationAxis`");
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x0008BDC4 File Offset: 0x00089FC4
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

		// Token: 0x04000A48 RID: 2632
		private const string DB = "db_input_settings.db";

		// Token: 0x04000A49 RID: 2633
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04000A4A RID: 2634
		private const string TABLE = "CombinationAxis";

		// Token: 0x04000A4B RID: 2635
		private const string COMMAND = "select BinData from `CombinationAxis`";

		// Token: 0x04000A4C RID: 2636
		private const string KEY_PREFIX = "CombinationAxisAll";

		// Token: 0x04000A4D RID: 2637
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A4E RID: 2638
		private static int HandleId;
	}
}

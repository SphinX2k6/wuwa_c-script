using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000274 RID: 628
	public class ConfigElementInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000EBC RID: 3772 RVA: 0x000B0429 File Offset: 0x000AE629
		static ConfigElementInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigElementInfoAll.CreateStaticDefaultValue), new Action(ConfigElementInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x000B0448 File Offset: 0x000AE648
		public static void CreateStaticDefaultValue()
		{
			ConfigElementInfoAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigElementInfoAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_element_info.db"),
				new ValueTuple<string, object>("文件", "y.元素属性.xlsx"),
				new ValueTuple<string, object>("表名", "ElementInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `ElementInfo`")
			});
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x000B04C7 File Offset: 0x000AE6C7
		public static void ResetStaticDefaultValue()
		{
			ConfigElementInfoAll.LogPair = null;
			ConfigElementInfoAll.HandleId = 0;
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x000B04D5 File Offset: 0x000AE6D5
		public static void Init()
		{
			ConfigElementInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigElementInfoAll.HandleId, "db_element_info.db", "select BinData from `ElementInfo`");
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x000B04F0 File Offset: 0x000AE6F0
		[NullableContext(2)]
		public static IReadOnlyList<ElementInfo> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigElementInfoAll.HandleId, ConfigElementInfoAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ElementInfo> readOnlyList = (IReadOnlyList<ElementInfo>)ConfigCommon.GetConfig("ElementInfoAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ElementInfo> list = new List<ElementInfo>();
			while (ConfigCommon.Step(ConfigElementInfoAll.HandleId, false, ConfigElementInfoAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigElementInfoAll.HandleId, 0, ConfigElementInfoAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigElementInfoAll.HandleId, ConfigElementInfoAll.LogPair);
					return null;
				}
				ElementInfo rootAsElementInfo = ElementInfo.GetRootAsElementInfo(new ByteBuffer(item2));
				list.Add(rootAsElementInfo);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ElementInfoAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigElementInfoAll.HandleId, ConfigElementInfoAll.LogPair);
			return list;
		}

		// Token: 0x04001110 RID: 4368
		private const string DB = "db_element_info.db";

		// Token: 0x04001111 RID: 4369
		private const string FILE = "y.元素属性.xlsx";

		// Token: 0x04001112 RID: 4370
		private const string TABLE = "ElementInfo";

		// Token: 0x04001113 RID: 4371
		private const string COMMAND = "select BinData from `ElementInfo`";

		// Token: 0x04001114 RID: 4372
		private const string KEY_PREFIX = "ElementInfoAll";

		// Token: 0x04001115 RID: 4373
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001116 RID: 4374
		private static int HandleId;
	}
}

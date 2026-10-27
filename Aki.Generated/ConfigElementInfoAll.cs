using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000260 RID: 608
	public class ConfigElementInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E44 RID: 3652 RVA: 0x000AA165 File Offset: 0x000A8365
		static ConfigElementInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigElementInfoAll.CreateStaticDefaultValue), new Action(ConfigElementInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x000AA184 File Offset: 0x000A8384
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

		// Token: 0x06000E46 RID: 3654 RVA: 0x000AA203 File Offset: 0x000A8403
		public static void ResetStaticDefaultValue()
		{
			ConfigElementInfoAll.LogPair = null;
			ConfigElementInfoAll.HandleId = 0;
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x000AA211 File Offset: 0x000A8411
		public static void Init()
		{
			ConfigElementInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigElementInfoAll.HandleId, "db_element_info.db", "select BinData from `ElementInfo`");
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x000AA22C File Offset: 0x000A842C
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

		// Token: 0x04001084 RID: 4228
		private const string DB = "db_element_info.db";

		// Token: 0x04001085 RID: 4229
		private const string FILE = "y.元素属性.xlsx";

		// Token: 0x04001086 RID: 4230
		private const string TABLE = "ElementInfo";

		// Token: 0x04001087 RID: 4231
		private const string COMMAND = "select BinData from `ElementInfo`";

		// Token: 0x04001088 RID: 4232
		private const string KEY_PREFIX = "ElementInfoAll";

		// Token: 0x04001089 RID: 4233
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400108A RID: 4234
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000015 RID: 21
	public class ConfigAbyssItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600007E RID: 126 RVA: 0x0005CC98 File Offset: 0x0005AE98
		static ConfigAbyssItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssItemAll.CreateStaticDefaultValue), new Action(ConfigAbyssItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0005CCB8 File Offset: 0x0005AEB8
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssItemAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssItemAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabysssuit.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssItem"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssItem`")
			});
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0005CD37 File Offset: 0x0005AF37
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssItemAll.LogPair = null;
			ConfigAbyssItemAll.HandleId = 0;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0005CD45 File Offset: 0x0005AF45
		public static void Init()
		{
			ConfigAbyssItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssItemAll.HandleId, "db_dangoabysssuit.db", "select BinData from `AbyssItem`");
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0005CD60 File Offset: 0x0005AF60
		[NullableContext(2)]
		public static IReadOnlyList<AbyssItem> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssItemAll.HandleId, ConfigAbyssItemAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AbyssItem> readOnlyList = (IReadOnlyList<AbyssItem>)ConfigCommon.GetConfig("AbyssItemAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AbyssItem> list = new List<AbyssItem>();
			while (ConfigCommon.Step(ConfigAbyssItemAll.HandleId, false, ConfigAbyssItemAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssItemAll.HandleId, 0, ConfigAbyssItemAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAbyssItemAll.HandleId, ConfigAbyssItemAll.LogPair);
					return null;
				}
				AbyssItem rootAsAbyssItem = AbyssItem.GetRootAsAbyssItem(new ByteBuffer(item2));
				list.Add(rootAsAbyssItem);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AbyssItemAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAbyssItemAll.HandleId, ConfigAbyssItemAll.LogPair);
			return list;
		}

		// Token: 0x04000077 RID: 119
		private const string DB = "db_dangoabysssuit.db";

		// Token: 0x04000078 RID: 120
		private const string FILE = "s.深渊爬塔.xlsx";

		// Token: 0x04000079 RID: 121
		private const string TABLE = "AbyssItem";

		// Token: 0x0400007A RID: 122
		private const string COMMAND = "select BinData from `AbyssItem`";

		// Token: 0x0400007B RID: 123
		private const string KEY_PREFIX = "AbyssItemAll";

		// Token: 0x0400007C RID: 124
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400007D RID: 125
		private static int HandleId;
	}
}

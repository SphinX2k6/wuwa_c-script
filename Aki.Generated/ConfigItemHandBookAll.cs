using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000457 RID: 1111
	public class ConfigItemHandBookAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A14 RID: 6676 RVA: 0x000ECE80 File Offset: 0x000EB080
		static ConfigItemHandBookAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemHandBookAll.CreateStaticDefaultValue), new Action(ConfigItemHandBookAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x000ECEA0 File Offset: 0x000EB0A0
		public static void CreateStaticDefaultValue()
		{
			ConfigItemHandBookAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigItemHandBookAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "ItemHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `ItemHandBook`")
			});
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x000ECF1F File Offset: 0x000EB11F
		public static void ResetStaticDefaultValue()
		{
			ConfigItemHandBookAll.LogPair = null;
			ConfigItemHandBookAll.HandleId = 0;
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x000ECF2D File Offset: 0x000EB12D
		public static void Init()
		{
			ConfigItemHandBookAll.HandleId = ConfigCommon.InitDataStatement(ConfigItemHandBookAll.HandleId, "db_handbook.db", "select BinData from `ItemHandBook`");
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x000ECF48 File Offset: 0x000EB148
		[NullableContext(2)]
		public static IReadOnlyList<ItemHandBook> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigItemHandBookAll.HandleId, ConfigItemHandBookAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ItemHandBook> readOnlyList = (IReadOnlyList<ItemHandBook>)ConfigCommon.GetConfig("ItemHandBookAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ItemHandBook> list = new List<ItemHandBook>();
			while (ConfigCommon.Step(ConfigItemHandBookAll.HandleId, false, ConfigItemHandBookAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigItemHandBookAll.HandleId, 0, ConfigItemHandBookAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigItemHandBookAll.HandleId, ConfigItemHandBookAll.LogPair);
					return null;
				}
				ItemHandBook rootAsItemHandBook = ItemHandBook.GetRootAsItemHandBook(new ByteBuffer(item2));
				list.Add(rootAsItemHandBook);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ItemHandBookAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigItemHandBookAll.HandleId, ConfigItemHandBookAll.LogPair);
			return list;
		}

		// Token: 0x04001E45 RID: 7749
		private const string DB = "db_handbook.db";

		// Token: 0x04001E46 RID: 7750
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04001E47 RID: 7751
		private const string TABLE = "ItemHandBook";

		// Token: 0x04001E48 RID: 7752
		private const string COMMAND = "select BinData from `ItemHandBook`";

		// Token: 0x04001E49 RID: 7753
		private const string KEY_PREFIX = "ItemHandBookAll";

		// Token: 0x04001E4A RID: 7754
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E4B RID: 7755
		private static int HandleId;
	}
}

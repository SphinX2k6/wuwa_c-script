using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200046D RID: 1133
	public class ConfigItemHandBookAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A98 RID: 6808 RVA: 0x000F35D4 File Offset: 0x000F17D4
		static ConfigItemHandBookAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemHandBookAll.CreateStaticDefaultValue), new Action(ConfigItemHandBookAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x000F35F4 File Offset: 0x000F17F4
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

		// Token: 0x06001A9A RID: 6810 RVA: 0x000F3673 File Offset: 0x000F1873
		public static void ResetStaticDefaultValue()
		{
			ConfigItemHandBookAll.LogPair = null;
			ConfigItemHandBookAll.HandleId = 0;
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x000F3681 File Offset: 0x000F1881
		public static void Init()
		{
			ConfigItemHandBookAll.HandleId = ConfigCommon.InitDataStatement(ConfigItemHandBookAll.HandleId, "db_handbook.db", "select BinData from `ItemHandBook`");
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x000F369C File Offset: 0x000F189C
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

		// Token: 0x04001EDF RID: 7903
		private const string DB = "db_handbook.db";

		// Token: 0x04001EE0 RID: 7904
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04001EE1 RID: 7905
		private const string TABLE = "ItemHandBook";

		// Token: 0x04001EE2 RID: 7906
		private const string COMMAND = "select BinData from `ItemHandBook`";

		// Token: 0x04001EE3 RID: 7907
		private const string KEY_PREFIX = "ItemHandBookAll";

		// Token: 0x04001EE4 RID: 7908
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001EE5 RID: 7909
		private static int HandleId;
	}
}

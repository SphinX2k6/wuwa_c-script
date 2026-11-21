using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200016C RID: 364
	public class ConfigChipHandBookAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000889 RID: 2185 RVA: 0x0008D595 File Offset: 0x0008B795
		static ConfigChipHandBookAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChipHandBookAll.CreateStaticDefaultValue), new Action(ConfigChipHandBookAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x0008D5B4 File Offset: 0x0008B7B4
		public static void CreateStaticDefaultValue()
		{
			ConfigChipHandBookAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChipHandBookAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "ChipHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `ChipHandBook`")
			});
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x0008D633 File Offset: 0x0008B833
		public static void ResetStaticDefaultValue()
		{
			ConfigChipHandBookAll.LogPair = null;
			ConfigChipHandBookAll.HandleId = 0;
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x0008D641 File Offset: 0x0008B841
		public static void Init()
		{
			ConfigChipHandBookAll.HandleId = ConfigCommon.InitDataStatement(ConfigChipHandBookAll.HandleId, "db_handbook.db", "select BinData from `ChipHandBook`");
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x0008D65C File Offset: 0x0008B85C
		[NullableContext(2)]
		public static IReadOnlyList<ChipHandBook> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChipHandBookAll.HandleId, ConfigChipHandBookAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ChipHandBook> readOnlyList = (IReadOnlyList<ChipHandBook>)ConfigCommon.GetConfig("ChipHandBookAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ChipHandBook> list = new List<ChipHandBook>();
			while (ConfigCommon.Step(ConfigChipHandBookAll.HandleId, false, ConfigChipHandBookAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChipHandBookAll.HandleId, 0, ConfigChipHandBookAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigChipHandBookAll.HandleId, ConfigChipHandBookAll.LogPair);
					return null;
				}
				ChipHandBook rootAsChipHandBook = ChipHandBook.GetRootAsChipHandBook(new ByteBuffer(item2));
				list.Add(rootAsChipHandBook);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ChipHandBookAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigChipHandBookAll.HandleId, ConfigChipHandBookAll.LogPair);
			return list;
		}

		// Token: 0x040009D8 RID: 2520
		private const string DB = "db_handbook.db";

		// Token: 0x040009D9 RID: 2521
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x040009DA RID: 2522
		private const string TABLE = "ChipHandBook";

		// Token: 0x040009DB RID: 2523
		private const string COMMAND = "select BinData from `ChipHandBook`";

		// Token: 0x040009DC RID: 2524
		private const string KEY_PREFIX = "ChipHandBookAll";

		// Token: 0x040009DD RID: 2525
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040009DE RID: 2526
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200015C RID: 348
	public class ConfigChipHandBookAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000829 RID: 2089 RVA: 0x00087A39 File Offset: 0x00085C39
		static ConfigChipHandBookAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChipHandBookAll.CreateStaticDefaultValue), new Action(ConfigChipHandBookAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00087A58 File Offset: 0x00085C58
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

		// Token: 0x0600082B RID: 2091 RVA: 0x00087AD7 File Offset: 0x00085CD7
		public static void ResetStaticDefaultValue()
		{
			ConfigChipHandBookAll.LogPair = null;
			ConfigChipHandBookAll.HandleId = 0;
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00087AE5 File Offset: 0x00085CE5
		public static void Init()
		{
			ConfigChipHandBookAll.HandleId = ConfigCommon.InitDataStatement(ConfigChipHandBookAll.HandleId, "db_handbook.db", "select BinData from `ChipHandBook`");
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00087B00 File Offset: 0x00085D00
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

		// Token: 0x04000968 RID: 2408
		private const string DB = "db_handbook.db";

		// Token: 0x04000969 RID: 2409
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x0400096A RID: 2410
		private const string TABLE = "ChipHandBook";

		// Token: 0x0400096B RID: 2411
		private const string COMMAND = "select BinData from `ChipHandBook`";

		// Token: 0x0400096C RID: 2412
		private const string KEY_PREFIX = "ChipHandBookAll";

		// Token: 0x0400096D RID: 2413
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400096E RID: 2414
		private static int HandleId;
	}
}

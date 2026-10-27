using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000096 RID: 150
	public class ConfigAnimalHandBookAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000384 RID: 900 RVA: 0x0006D7A8 File Offset: 0x0006B9A8
		static ConfigAnimalHandBookAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAnimalHandBookAll.CreateStaticDefaultValue), new Action(ConfigAnimalHandBookAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0006D7C8 File Offset: 0x0006B9C8
		public static void CreateStaticDefaultValue()
		{
			ConfigAnimalHandBookAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAnimalHandBookAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "AnimalHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `AnimalHandBook`")
			});
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0006D847 File Offset: 0x0006BA47
		public static void ResetStaticDefaultValue()
		{
			ConfigAnimalHandBookAll.LogPair = null;
			ConfigAnimalHandBookAll.HandleId = 0;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0006D855 File Offset: 0x0006BA55
		public static void Init()
		{
			ConfigAnimalHandBookAll.HandleId = ConfigCommon.InitDataStatement(ConfigAnimalHandBookAll.HandleId, "db_handbook.db", "select BinData from `AnimalHandBook`");
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0006D870 File Offset: 0x0006BA70
		[NullableContext(2)]
		public static IReadOnlyList<AnimalHandBook> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAnimalHandBookAll.HandleId, ConfigAnimalHandBookAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AnimalHandBook> readOnlyList = (IReadOnlyList<AnimalHandBook>)ConfigCommon.GetConfig("AnimalHandBookAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AnimalHandBook> list = new List<AnimalHandBook>();
			while (ConfigCommon.Step(ConfigAnimalHandBookAll.HandleId, false, ConfigAnimalHandBookAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAnimalHandBookAll.HandleId, 0, ConfigAnimalHandBookAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAnimalHandBookAll.HandleId, ConfigAnimalHandBookAll.LogPair);
					return null;
				}
				AnimalHandBook rootAsAnimalHandBook = AnimalHandBook.GetRootAsAnimalHandBook(new ByteBuffer(item2));
				list.Add(rootAsAnimalHandBook);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AnimalHandBookAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAnimalHandBookAll.HandleId, ConfigAnimalHandBookAll.LogPair);
			return list;
		}

		// Token: 0x040003FE RID: 1022
		private const string DB = "db_handbook.db";

		// Token: 0x040003FF RID: 1023
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04000400 RID: 1024
		private const string TABLE = "AnimalHandBook";

		// Token: 0x04000401 RID: 1025
		private const string COMMAND = "select BinData from `AnimalHandBook`";

		// Token: 0x04000402 RID: 1026
		private const string KEY_PREFIX = "AnimalHandBookAll";

		// Token: 0x04000403 RID: 1027
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000404 RID: 1028
		private static int HandleId;
	}
}

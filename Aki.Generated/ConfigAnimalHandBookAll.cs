using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200009E RID: 158
	public class ConfigAnimalHandBookAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003B4 RID: 948 RVA: 0x0007205C File Offset: 0x0007025C
		static ConfigAnimalHandBookAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAnimalHandBookAll.CreateStaticDefaultValue), new Action(ConfigAnimalHandBookAll.ResetStaticDefaultValue));
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0007207C File Offset: 0x0007027C
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

		// Token: 0x060003B6 RID: 950 RVA: 0x000720FB File Offset: 0x000702FB
		public static void ResetStaticDefaultValue()
		{
			ConfigAnimalHandBookAll.LogPair = null;
			ConfigAnimalHandBookAll.HandleId = 0;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00072109 File Offset: 0x00070309
		public static void Init()
		{
			ConfigAnimalHandBookAll.HandleId = ConfigCommon.InitDataStatement(ConfigAnimalHandBookAll.HandleId, "db_handbook.db", "select BinData from `AnimalHandBook`");
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00072124 File Offset: 0x00070324
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

		// Token: 0x04000436 RID: 1078
		private const string DB = "db_handbook.db";

		// Token: 0x04000437 RID: 1079
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04000438 RID: 1080
		private const string TABLE = "AnimalHandBook";

		// Token: 0x04000439 RID: 1081
		private const string COMMAND = "select BinData from `AnimalHandBook`";

		// Token: 0x0400043A RID: 1082
		private const string KEY_PREFIX = "AnimalHandBookAll";

		// Token: 0x0400043B RID: 1083
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400043C RID: 1084
		private static int HandleId;
	}
}

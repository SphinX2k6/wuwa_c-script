using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000346 RID: 838
	public class ConfigFloroRanchToyAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013A9 RID: 5033 RVA: 0x000CC098 File Offset: 0x000CA298
		static ConfigFloroRanchToyAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchToyAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchToyAll.ResetStaticDefaultValue));
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x000CC0B8 File Offset: 0x000CA2B8
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchToyAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchToyAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchToy"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchToy`")
			});
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x000CC137 File Offset: 0x000CA337
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchToyAll.LogPair = null;
			ConfigFloroRanchToyAll.HandleId = 0;
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x000CC145 File Offset: 0x000CA345
		public static void Init()
		{
			ConfigFloroRanchToyAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchToyAll.HandleId, "db_flororanch.db", "select BinData from `FloroRanchToy`");
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x000CC160 File Offset: 0x000CA360
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchToy> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchToyAll.HandleId, ConfigFloroRanchToyAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FloroRanchToy> readOnlyList = (IReadOnlyList<FloroRanchToy>)ConfigCommon.GetConfig("FloroRanchToyAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FloroRanchToy> list = new List<FloroRanchToy>();
			while (ConfigCommon.Step(ConfigFloroRanchToyAll.HandleId, false, ConfigFloroRanchToyAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchToyAll.HandleId, 0, ConfigFloroRanchToyAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchToyAll.HandleId, ConfigFloroRanchToyAll.LogPair);
					return null;
				}
				FloroRanchToy rootAsFloroRanchToy = FloroRanchToy.GetRootAsFloroRanchToy(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchToy);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FloroRanchToyAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchToyAll.HandleId, ConfigFloroRanchToyAll.LogPair);
			return list;
		}

		// Token: 0x040016CE RID: 5838
		private const string DB = "db_flororanch.db";

		// Token: 0x040016CF RID: 5839
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x040016D0 RID: 5840
		private const string TABLE = "FloroRanchToy";

		// Token: 0x040016D1 RID: 5841
		private const string COMMAND = "select BinData from `FloroRanchToy`";

		// Token: 0x040016D2 RID: 5842
		private const string KEY_PREFIX = "FloroRanchToyAll";

		// Token: 0x040016D3 RID: 5843
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016D4 RID: 5844
		private static int HandleId;
	}
}

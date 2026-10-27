using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000327 RID: 807
	public class ConfigFloroRanchTagAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012EF RID: 4847 RVA: 0x000C46F8 File Offset: 0x000C28F8
		static ConfigFloroRanchTagAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchTagAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchTagAll.ResetStaticDefaultValue));
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x000C4718 File Offset: 0x000C2918
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchTagAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchTagAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanchtag.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场_词条.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchTag"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchTag`")
			});
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x000C4797 File Offset: 0x000C2997
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchTagAll.LogPair = null;
			ConfigFloroRanchTagAll.HandleId = 0;
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x000C47A5 File Offset: 0x000C29A5
		public static void Init()
		{
			ConfigFloroRanchTagAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchTagAll.HandleId, "db_flororanchtag.db", "select BinData from `FloroRanchTag`");
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x000C47C0 File Offset: 0x000C29C0
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchTag> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchTagAll.HandleId, ConfigFloroRanchTagAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FloroRanchTag> readOnlyList = (IReadOnlyList<FloroRanchTag>)ConfigCommon.GetConfig("FloroRanchTagAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FloroRanchTag> list = new List<FloroRanchTag>();
			while (ConfigCommon.Step(ConfigFloroRanchTagAll.HandleId, false, ConfigFloroRanchTagAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchTagAll.HandleId, 0, ConfigFloroRanchTagAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchTagAll.HandleId, ConfigFloroRanchTagAll.LogPair);
					return null;
				}
				FloroRanchTag rootAsFloroRanchTag = FloroRanchTag.GetRootAsFloroRanchTag(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchTag);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FloroRanchTagAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchTagAll.HandleId, ConfigFloroRanchTagAll.LogPair);
			return list;
		}

		// Token: 0x040015F5 RID: 5621
		private const string DB = "db_flororanchtag.db";

		// Token: 0x040015F6 RID: 5622
		private const string FILE = "f.弗洛洛牧场_词条.xlsx";

		// Token: 0x040015F7 RID: 5623
		private const string TABLE = "FloroRanchTag";

		// Token: 0x040015F8 RID: 5624
		private const string COMMAND = "select BinData from `FloroRanchTag`";

		// Token: 0x040015F9 RID: 5625
		private const string KEY_PREFIX = "FloroRanchTagAll";

		// Token: 0x040015FA RID: 5626
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015FB RID: 5627
		private static int HandleId;
	}
}

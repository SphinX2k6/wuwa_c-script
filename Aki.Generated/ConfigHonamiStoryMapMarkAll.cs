using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003F2 RID: 1010
	public class ConfigHonamiStoryMapMarkAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017B3 RID: 6067 RVA: 0x000DFAC3 File Offset: 0x000DDCC3
		static ConfigHonamiStoryMapMarkAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryMapMarkAll.CreateStaticDefaultValue), new Action(ConfigHonamiStoryMapMarkAll.ResetStaticDefaultValue));
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x000DFAE4 File Offset: 0x000DDCE4
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryMapMarkAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryMapMarkAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局内.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryMapMark"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryMapMark`")
			});
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x000DFB63 File Offset: 0x000DDD63
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryMapMarkAll.LogPair = null;
			ConfigHonamiStoryMapMarkAll.HandleId = 0;
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x000DFB71 File Offset: 0x000DDD71
		public static void Init()
		{
			ConfigHonamiStoryMapMarkAll.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryMapMarkAll.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryMapMark`");
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x000DFB8C File Offset: 0x000DDD8C
		[NullableContext(2)]
		public static IReadOnlyList<HonamiStoryMapMark> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryMapMarkAll.HandleId, ConfigHonamiStoryMapMarkAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<HonamiStoryMapMark> readOnlyList = (IReadOnlyList<HonamiStoryMapMark>)ConfigCommon.GetConfig("HonamiStoryMapMarkAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<HonamiStoryMapMark> list = new List<HonamiStoryMapMark>();
			while (ConfigCommon.Step(ConfigHonamiStoryMapMarkAll.HandleId, false, ConfigHonamiStoryMapMarkAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryMapMarkAll.HandleId, 0, ConfigHonamiStoryMapMarkAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigHonamiStoryMapMarkAll.HandleId, ConfigHonamiStoryMapMarkAll.LogPair);
					return null;
				}
				HonamiStoryMapMark rootAsHonamiStoryMapMark = HonamiStoryMapMark.GetRootAsHonamiStoryMapMark(new ByteBuffer(item2));
				list.Add(rootAsHonamiStoryMapMark);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("HonamiStoryMapMarkAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigHonamiStoryMapMarkAll.HandleId, ConfigHonamiStoryMapMarkAll.LogPair);
			return list;
		}

		// Token: 0x04001B82 RID: 7042
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B83 RID: 7043
		private const string FILE = "s.穗波奇妙物语局内.xlsx";

		// Token: 0x04001B84 RID: 7044
		private const string TABLE = "HonamiStoryMapMark";

		// Token: 0x04001B85 RID: 7045
		private const string COMMAND = "select BinData from `HonamiStoryMapMark`";

		// Token: 0x04001B86 RID: 7046
		private const string KEY_PREFIX = "HonamiStoryMapMarkAll";

		// Token: 0x04001B87 RID: 7047
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B88 RID: 7048
		private static int HandleId;
	}
}

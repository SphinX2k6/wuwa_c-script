using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003F4 RID: 1012
	public class ConfigHonamiStoryMarkWhiteListAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017BF RID: 6079 RVA: 0x000DFEA0 File Offset: 0x000DE0A0
		static ConfigHonamiStoryMarkWhiteListAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryMarkWhiteListAll.CreateStaticDefaultValue), new Action(ConfigHonamiStoryMarkWhiteListAll.ResetStaticDefaultValue));
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x000DFEC0 File Offset: 0x000DE0C0
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryMarkWhiteListAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryMarkWhiteListAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局内.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryMarkWhiteList"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryMarkWhiteList`")
			});
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x000DFF3F File Offset: 0x000DE13F
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryMarkWhiteListAll.LogPair = null;
			ConfigHonamiStoryMarkWhiteListAll.HandleId = 0;
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x000DFF4D File Offset: 0x000DE14D
		public static void Init()
		{
			ConfigHonamiStoryMarkWhiteListAll.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryMarkWhiteListAll.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryMarkWhiteList`");
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x000DFF68 File Offset: 0x000DE168
		[NullableContext(2)]
		public static IReadOnlyList<HonamiStoryMarkWhiteList> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryMarkWhiteListAll.HandleId, ConfigHonamiStoryMarkWhiteListAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<HonamiStoryMarkWhiteList> readOnlyList = (IReadOnlyList<HonamiStoryMarkWhiteList>)ConfigCommon.GetConfig("HonamiStoryMarkWhiteListAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<HonamiStoryMarkWhiteList> list = new List<HonamiStoryMarkWhiteList>();
			while (ConfigCommon.Step(ConfigHonamiStoryMarkWhiteListAll.HandleId, false, ConfigHonamiStoryMarkWhiteListAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryMarkWhiteListAll.HandleId, 0, ConfigHonamiStoryMarkWhiteListAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigHonamiStoryMarkWhiteListAll.HandleId, ConfigHonamiStoryMarkWhiteListAll.LogPair);
					return null;
				}
				HonamiStoryMarkWhiteList rootAsHonamiStoryMarkWhiteList = HonamiStoryMarkWhiteList.GetRootAsHonamiStoryMarkWhiteList(new ByteBuffer(item2));
				list.Add(rootAsHonamiStoryMarkWhiteList);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("HonamiStoryMarkWhiteListAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigHonamiStoryMarkWhiteListAll.HandleId, ConfigHonamiStoryMarkWhiteListAll.LogPair);
			return list;
		}

		// Token: 0x04001B90 RID: 7056
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B91 RID: 7057
		private const string FILE = "s.穗波奇妙物语局内.xlsx";

		// Token: 0x04001B92 RID: 7058
		private const string TABLE = "HonamiStoryMarkWhiteList";

		// Token: 0x04001B93 RID: 7059
		private const string COMMAND = "select BinData from `HonamiStoryMarkWhiteList`";

		// Token: 0x04001B94 RID: 7060
		private const string KEY_PREFIX = "HonamiStoryMarkWhiteListAll";

		// Token: 0x04001B95 RID: 7061
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B96 RID: 7062
		private static int HandleId;
	}
}

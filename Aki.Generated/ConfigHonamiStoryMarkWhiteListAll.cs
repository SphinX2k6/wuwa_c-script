using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200040A RID: 1034
	public class ConfigHonamiStoryMarkWhiteListAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001843 RID: 6211 RVA: 0x000E65F4 File Offset: 0x000E47F4
		static ConfigHonamiStoryMarkWhiteListAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryMarkWhiteListAll.CreateStaticDefaultValue), new Action(ConfigHonamiStoryMarkWhiteListAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x000E6614 File Offset: 0x000E4814
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

		// Token: 0x06001845 RID: 6213 RVA: 0x000E6693 File Offset: 0x000E4893
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryMarkWhiteListAll.LogPair = null;
			ConfigHonamiStoryMarkWhiteListAll.HandleId = 0;
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x000E66A1 File Offset: 0x000E48A1
		public static void Init()
		{
			ConfigHonamiStoryMarkWhiteListAll.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryMarkWhiteListAll.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryMarkWhiteList`");
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x000E66BC File Offset: 0x000E48BC
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

		// Token: 0x04001C2A RID: 7210
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C2B RID: 7211
		private const string FILE = "s.穗波奇妙物语局内.xlsx";

		// Token: 0x04001C2C RID: 7212
		private const string TABLE = "HonamiStoryMarkWhiteList";

		// Token: 0x04001C2D RID: 7213
		private const string COMMAND = "select BinData from `HonamiStoryMarkWhiteList`";

		// Token: 0x04001C2E RID: 7214
		private const string KEY_PREFIX = "HonamiStoryMarkWhiteListAll";

		// Token: 0x04001C2F RID: 7215
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C30 RID: 7216
		private static int HandleId;
	}
}

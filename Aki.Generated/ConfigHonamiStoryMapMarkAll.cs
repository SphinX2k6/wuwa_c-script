using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000408 RID: 1032
	public class ConfigHonamiStoryMapMarkAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001837 RID: 6199 RVA: 0x000E6217 File Offset: 0x000E4417
		static ConfigHonamiStoryMapMarkAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryMapMarkAll.CreateStaticDefaultValue), new Action(ConfigHonamiStoryMapMarkAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x000E6238 File Offset: 0x000E4438
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

		// Token: 0x06001839 RID: 6201 RVA: 0x000E62B7 File Offset: 0x000E44B7
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryMapMarkAll.LogPair = null;
			ConfigHonamiStoryMapMarkAll.HandleId = 0;
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x000E62C5 File Offset: 0x000E44C5
		public static void Init()
		{
			ConfigHonamiStoryMapMarkAll.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryMapMarkAll.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryMapMark`");
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x000E62E0 File Offset: 0x000E44E0
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

		// Token: 0x04001C1C RID: 7196
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C1D RID: 7197
		private const string FILE = "s.穗波奇妙物语局内.xlsx";

		// Token: 0x04001C1E RID: 7198
		private const string TABLE = "HonamiStoryMapMark";

		// Token: 0x04001C1F RID: 7199
		private const string COMMAND = "select BinData from `HonamiStoryMapMark`";

		// Token: 0x04001C20 RID: 7200
		private const string KEY_PREFIX = "HonamiStoryMapMarkAll";

		// Token: 0x04001C21 RID: 7201
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C22 RID: 7202
		private static int HandleId;
	}
}

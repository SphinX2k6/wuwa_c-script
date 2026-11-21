using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003EF RID: 1007
	public class ConfigHonamiStoryActivityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017A1 RID: 6049 RVA: 0x000E2A93 File Offset: 0x000E0C93
		static ConfigHonamiStoryActivityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryActivityAll.CreateStaticDefaultValue), new Action(ConfigHonamiStoryActivityAll.ResetStaticDefaultValue));
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x000E2AB4 File Offset: 0x000E0CB4
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryActivityAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryActivityAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局外.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryActivity`")
			});
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x000E2B33 File Offset: 0x000E0D33
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryActivityAll.LogPair = null;
			ConfigHonamiStoryActivityAll.HandleId = 0;
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x000E2B41 File Offset: 0x000E0D41
		public static void Init()
		{
			ConfigHonamiStoryActivityAll.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryActivityAll.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryActivity`");
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x000E2B5C File Offset: 0x000E0D5C
		[NullableContext(2)]
		public static IReadOnlyList<HonamiStoryActivity> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryActivityAll.HandleId, ConfigHonamiStoryActivityAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<HonamiStoryActivity> readOnlyList = (IReadOnlyList<HonamiStoryActivity>)ConfigCommon.GetConfig("HonamiStoryActivityAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<HonamiStoryActivity> list = new List<HonamiStoryActivity>();
			while (ConfigCommon.Step(ConfigHonamiStoryActivityAll.HandleId, false, ConfigHonamiStoryActivityAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryActivityAll.HandleId, 0, ConfigHonamiStoryActivityAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigHonamiStoryActivityAll.HandleId, ConfigHonamiStoryActivityAll.LogPair);
					return null;
				}
				HonamiStoryActivity rootAsHonamiStoryActivity = HonamiStoryActivity.GetRootAsHonamiStoryActivity(new ByteBuffer(item2));
				list.Add(rootAsHonamiStoryActivity);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("HonamiStoryActivityAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigHonamiStoryActivityAll.HandleId, ConfigHonamiStoryActivityAll.LogPair);
			return list;
		}

		// Token: 0x04001B6D RID: 7021
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B6E RID: 7022
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001B6F RID: 7023
		private const string TABLE = "HonamiStoryActivity";

		// Token: 0x04001B70 RID: 7024
		private const string COMMAND = "select BinData from `HonamiStoryActivity`";

		// Token: 0x04001B71 RID: 7025
		private const string KEY_PREFIX = "HonamiStoryActivityAll";

		// Token: 0x04001B72 RID: 7026
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B73 RID: 7027
		private static int HandleId;
	}
}

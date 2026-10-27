using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003D9 RID: 985
	public class ConfigHonamiStoryActivityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600171D RID: 5917 RVA: 0x000DC33F File Offset: 0x000DA53F
		static ConfigHonamiStoryActivityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryActivityAll.CreateStaticDefaultValue), new Action(ConfigHonamiStoryActivityAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x000DC360 File Offset: 0x000DA560
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

		// Token: 0x0600171F RID: 5919 RVA: 0x000DC3DF File Offset: 0x000DA5DF
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryActivityAll.LogPair = null;
			ConfigHonamiStoryActivityAll.HandleId = 0;
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x000DC3ED File Offset: 0x000DA5ED
		public static void Init()
		{
			ConfigHonamiStoryActivityAll.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryActivityAll.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryActivity`");
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x000DC408 File Offset: 0x000DA608
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

		// Token: 0x04001AD3 RID: 6867
		private const string DB = "db_honamistory.db";

		// Token: 0x04001AD4 RID: 6868
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001AD5 RID: 6869
		private const string TABLE = "HonamiStoryActivity";

		// Token: 0x04001AD6 RID: 6870
		private const string COMMAND = "select BinData from `HonamiStoryActivity`";

		// Token: 0x04001AD7 RID: 6871
		private const string KEY_PREFIX = "HonamiStoryActivityAll";

		// Token: 0x04001AD8 RID: 6872
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001AD9 RID: 6873
		private static int HandleId;
	}
}

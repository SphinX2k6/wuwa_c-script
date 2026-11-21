using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200020A RID: 522
	public class ConfigDaySelectPresetAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C3F RID: 3135 RVA: 0x000A27D4 File Offset: 0x000A09D4
		static ConfigDaySelectPresetAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDaySelectPresetAll.CreateStaticDefaultValue), new Action(ConfigDaySelectPresetAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x000A27F4 File Offset: 0x000A09F4
		public static void CreateStaticDefaultValue()
		{
			ConfigDaySelectPresetAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDaySelectPresetAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_time_of_day.db"),
				new ValueTuple<string, object>("文件", "s.时间系统.xlsx"),
				new ValueTuple<string, object>("表名", "DaySelectPreset"),
				new ValueTuple<string, object>("语句", "select BinData from `DaySelectPreset`")
			});
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x000A2873 File Offset: 0x000A0A73
		public static void ResetStaticDefaultValue()
		{
			ConfigDaySelectPresetAll.LogPair = null;
			ConfigDaySelectPresetAll.HandleId = 0;
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x000A2881 File Offset: 0x000A0A81
		public static void Init()
		{
			ConfigDaySelectPresetAll.HandleId = ConfigCommon.InitDataStatement(ConfigDaySelectPresetAll.HandleId, "db_time_of_day.db", "select BinData from `DaySelectPreset`");
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x000A289C File Offset: 0x000A0A9C
		[NullableContext(2)]
		public static IReadOnlyList<DaySelectPreset> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDaySelectPresetAll.HandleId, ConfigDaySelectPresetAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DaySelectPreset> readOnlyList = (IReadOnlyList<DaySelectPreset>)ConfigCommon.GetConfig("DaySelectPresetAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DaySelectPreset> list = new List<DaySelectPreset>();
			while (ConfigCommon.Step(ConfigDaySelectPresetAll.HandleId, false, ConfigDaySelectPresetAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDaySelectPresetAll.HandleId, 0, ConfigDaySelectPresetAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDaySelectPresetAll.HandleId, ConfigDaySelectPresetAll.LogPair);
					return null;
				}
				DaySelectPreset rootAsDaySelectPreset = DaySelectPreset.GetRootAsDaySelectPreset(new ByteBuffer(item2));
				list.Add(rootAsDaySelectPreset);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DaySelectPresetAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDaySelectPresetAll.HandleId, ConfigDaySelectPresetAll.LogPair);
			return list;
		}

		// Token: 0x04000E2A RID: 3626
		private const string DB = "db_time_of_day.db";

		// Token: 0x04000E2B RID: 3627
		private const string FILE = "s.时间系统.xlsx";

		// Token: 0x04000E2C RID: 3628
		private const string TABLE = "DaySelectPreset";

		// Token: 0x04000E2D RID: 3629
		private const string COMMAND = "select BinData from `DaySelectPreset`";

		// Token: 0x04000E2E RID: 3630
		private const string KEY_PREFIX = "DaySelectPresetAll";

		// Token: 0x04000E2F RID: 3631
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E30 RID: 3632
		private static int HandleId;
	}
}

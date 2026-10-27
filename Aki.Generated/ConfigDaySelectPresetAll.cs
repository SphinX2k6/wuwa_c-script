using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001F8 RID: 504
	public class ConfigDaySelectPresetAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BD3 RID: 3027 RVA: 0x0009C89C File Offset: 0x0009AA9C
		static ConfigDaySelectPresetAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDaySelectPresetAll.CreateStaticDefaultValue), new Action(ConfigDaySelectPresetAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x0009C8BC File Offset: 0x0009AABC
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

		// Token: 0x06000BD5 RID: 3029 RVA: 0x0009C93B File Offset: 0x0009AB3B
		public static void ResetStaticDefaultValue()
		{
			ConfigDaySelectPresetAll.LogPair = null;
			ConfigDaySelectPresetAll.HandleId = 0;
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x0009C949 File Offset: 0x0009AB49
		public static void Init()
		{
			ConfigDaySelectPresetAll.HandleId = ConfigCommon.InitDataStatement(ConfigDaySelectPresetAll.HandleId, "db_time_of_day.db", "select BinData from `DaySelectPreset`");
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x0009C964 File Offset: 0x0009AB64
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

		// Token: 0x04000DAC RID: 3500
		private const string DB = "db_time_of_day.db";

		// Token: 0x04000DAD RID: 3501
		private const string FILE = "s.时间系统.xlsx";

		// Token: 0x04000DAE RID: 3502
		private const string TABLE = "DaySelectPreset";

		// Token: 0x04000DAF RID: 3503
		private const string COMMAND = "select BinData from `DaySelectPreset`";

		// Token: 0x04000DB0 RID: 3504
		private const string KEY_PREFIX = "DaySelectPresetAll";

		// Token: 0x04000DB1 RID: 3505
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DB2 RID: 3506
		private static int HandleId;
	}
}

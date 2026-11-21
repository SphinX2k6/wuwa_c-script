using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000402 RID: 1026
	public class ConfigHonamiStoryLimitTaskByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001813 RID: 6163 RVA: 0x000E5444 File Offset: 0x000E3644
		static ConfigHonamiStoryLimitTaskByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryLimitTaskByActivityId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryLimitTaskByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x000E5464 File Offset: 0x000E3664
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryLimitTaskByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryLimitTaskByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波物语活动奖励.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryLimitTask"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryLimitTask` where ActivityId=?")
			});
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x000E54E3 File Offset: 0x000E36E3
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryLimitTaskByActivityId.LogPair = null;
			ConfigHonamiStoryLimitTaskByActivityId.HandleId = 0;
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x000E54F1 File Offset: 0x000E36F1
		public static void Init()
		{
			ConfigHonamiStoryLimitTaskByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryLimitTaskByActivityId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryLimitTask` where ActivityId=?");
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x000E550C File Offset: 0x000E370C
		[NullableContext(2)]
		public static IReadOnlyList<HonamiStoryLimitTask> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryLimitTaskByActivityId.HandleId, ConfigHonamiStoryLimitTaskByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryLimitTaskByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<HonamiStoryLimitTask> readOnlyList = (IReadOnlyList<HonamiStoryLimitTask>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigHonamiStoryLimitTaskByActivityId.LogPair.Clear();
			ConfigHonamiStoryLimitTaskByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryLimitTaskByActivityId.HandleId, 1, p0ActivityId, ConfigHonamiStoryLimitTaskByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigHonamiStoryLimitTaskByActivityId.HandleId, ConfigHonamiStoryLimitTaskByActivityId.LogPair);
				return null;
			}
			List<HonamiStoryLimitTask> list = new List<HonamiStoryLimitTask>();
			while (ConfigCommon.Step(ConfigHonamiStoryLimitTaskByActivityId.HandleId, false, ConfigHonamiStoryLimitTaskByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryLimitTaskByActivityId.HandleId, 0, ConfigHonamiStoryLimitTaskByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigHonamiStoryLimitTaskByActivityId.HandleId, ConfigHonamiStoryLimitTaskByActivityId.LogPair);
					return null;
				}
				HonamiStoryLimitTask rootAsHonamiStoryLimitTask = HonamiStoryLimitTask.GetRootAsHonamiStoryLimitTask(new ByteBuffer(item2));
				list.Add(rootAsHonamiStoryLimitTask);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryLimitTaskByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigHonamiStoryLimitTaskByActivityId.HandleId, ConfigHonamiStoryLimitTaskByActivityId.LogPair);
			return list;
		}

		// Token: 0x04001BF2 RID: 7154
		private const string DB = "db_honamistory.db";

		// Token: 0x04001BF3 RID: 7155
		private const string FILE = "s.穗波物语活动奖励.xlsx";

		// Token: 0x04001BF4 RID: 7156
		private const string TABLE = "HonamiStoryLimitTask";

		// Token: 0x04001BF5 RID: 7157
		private const string COMMAND = "select BinData from `HonamiStoryLimitTask` where ActivityId=?";

		// Token: 0x04001BF6 RID: 7158
		private const string KEY_PREFIX = "HonamiStoryLimitTaskByActivityId";

		// Token: 0x04001BF7 RID: 7159
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001BF8 RID: 7160
		private static int HandleId;
	}
}

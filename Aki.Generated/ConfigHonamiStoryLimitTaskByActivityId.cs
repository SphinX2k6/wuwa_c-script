using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003EC RID: 1004
	public class ConfigHonamiStoryLimitTaskByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600178F RID: 6031 RVA: 0x000DECF0 File Offset: 0x000DCEF0
		static ConfigHonamiStoryLimitTaskByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryLimitTaskByActivityId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryLimitTaskByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x000DED10 File Offset: 0x000DCF10
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

		// Token: 0x06001791 RID: 6033 RVA: 0x000DED8F File Offset: 0x000DCF8F
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryLimitTaskByActivityId.LogPair = null;
			ConfigHonamiStoryLimitTaskByActivityId.HandleId = 0;
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x000DED9D File Offset: 0x000DCF9D
		public static void Init()
		{
			ConfigHonamiStoryLimitTaskByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryLimitTaskByActivityId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryLimitTask` where ActivityId=?");
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x000DEDB8 File Offset: 0x000DCFB8
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

		// Token: 0x04001B58 RID: 7000
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B59 RID: 7001
		private const string FILE = "s.穗波物语活动奖励.xlsx";

		// Token: 0x04001B5A RID: 7002
		private const string TABLE = "HonamiStoryLimitTask";

		// Token: 0x04001B5B RID: 7003
		private const string COMMAND = "select BinData from `HonamiStoryLimitTask` where ActivityId=?";

		// Token: 0x04001B5C RID: 7004
		private const string KEY_PREFIX = "HonamiStoryLimitTaskByActivityId";

		// Token: 0x04001B5D RID: 7005
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B5E RID: 7006
		private static int HandleId;
	}
}

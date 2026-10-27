using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000404 RID: 1028
	public class ConfigHonamiStoryResidentTaskByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600181F RID: 6175 RVA: 0x000E2280 File Offset: 0x000E0480
		static ConfigHonamiStoryResidentTaskByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryResidentTaskByActivityId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryResidentTaskByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x000E22A0 File Offset: 0x000E04A0
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryResidentTaskByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryResidentTaskByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局外.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryResidentTask"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryResidentTask` where ActivityId=?")
			});
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x000E231F File Offset: 0x000E051F
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryResidentTaskByActivityId.LogPair = null;
			ConfigHonamiStoryResidentTaskByActivityId.HandleId = 0;
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x000E232D File Offset: 0x000E052D
		public static void Init()
		{
			ConfigHonamiStoryResidentTaskByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryResidentTaskByActivityId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryResidentTask` where ActivityId=?");
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x000E2348 File Offset: 0x000E0548
		[NullableContext(2)]
		public static IReadOnlyList<HonamiStoryResidentTask> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryResidentTaskByActivityId.HandleId, ConfigHonamiStoryResidentTaskByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryResidentTaskByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<HonamiStoryResidentTask> readOnlyList = (IReadOnlyList<HonamiStoryResidentTask>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigHonamiStoryResidentTaskByActivityId.LogPair.Clear();
			ConfigHonamiStoryResidentTaskByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryResidentTaskByActivityId.HandleId, 1, p0ActivityId, ConfigHonamiStoryResidentTaskByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigHonamiStoryResidentTaskByActivityId.HandleId, ConfigHonamiStoryResidentTaskByActivityId.LogPair);
				return null;
			}
			List<HonamiStoryResidentTask> list = new List<HonamiStoryResidentTask>();
			while (ConfigCommon.Step(ConfigHonamiStoryResidentTaskByActivityId.HandleId, false, ConfigHonamiStoryResidentTaskByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryResidentTaskByActivityId.HandleId, 0, ConfigHonamiStoryResidentTaskByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigHonamiStoryResidentTaskByActivityId.HandleId, ConfigHonamiStoryResidentTaskByActivityId.LogPair);
					return null;
				}
				HonamiStoryResidentTask rootAsHonamiStoryResidentTask = HonamiStoryResidentTask.GetRootAsHonamiStoryResidentTask(new ByteBuffer(item2));
				list.Add(rootAsHonamiStoryResidentTask);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryResidentTaskByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigHonamiStoryResidentTaskByActivityId.HandleId, ConfigHonamiStoryResidentTaskByActivityId.LogPair);
			return list;
		}

		// Token: 0x04001C00 RID: 7168
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C01 RID: 7169
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001C02 RID: 7170
		private const string TABLE = "HonamiStoryResidentTask";

		// Token: 0x04001C03 RID: 7171
		private const string COMMAND = "select BinData from `HonamiStoryResidentTask` where ActivityId=?";

		// Token: 0x04001C04 RID: 7172
		private const string KEY_PREFIX = "HonamiStoryResidentTaskByActivityId";

		// Token: 0x04001C05 RID: 7173
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C06 RID: 7174
		private static int HandleId;
	}
}

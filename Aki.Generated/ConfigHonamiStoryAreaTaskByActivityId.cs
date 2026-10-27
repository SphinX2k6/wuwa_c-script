using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003DD RID: 989
	public class ConfigHonamiStoryAreaTaskByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001735 RID: 5941 RVA: 0x000DCB9C File Offset: 0x000DAD9C
		static ConfigHonamiStoryAreaTaskByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryAreaTaskByActivityId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryAreaTaskByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x000DCBBC File Offset: 0x000DADBC
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryAreaTaskByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryAreaTaskByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局外.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryAreaTask"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryAreaTask` where ActivityId=?")
			});
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x000DCC3B File Offset: 0x000DAE3B
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryAreaTaskByActivityId.LogPair = null;
			ConfigHonamiStoryAreaTaskByActivityId.HandleId = 0;
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x000DCC49 File Offset: 0x000DAE49
		public static void Init()
		{
			ConfigHonamiStoryAreaTaskByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryAreaTaskByActivityId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryAreaTask` where ActivityId=?");
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x000DCC64 File Offset: 0x000DAE64
		[NullableContext(2)]
		public static IReadOnlyList<HonamiStoryAreaTask> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryAreaTaskByActivityId.HandleId, ConfigHonamiStoryAreaTaskByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryAreaTaskByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<HonamiStoryAreaTask> readOnlyList = (IReadOnlyList<HonamiStoryAreaTask>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigHonamiStoryAreaTaskByActivityId.LogPair.Clear();
			ConfigHonamiStoryAreaTaskByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryAreaTaskByActivityId.HandleId, 1, p0ActivityId, ConfigHonamiStoryAreaTaskByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigHonamiStoryAreaTaskByActivityId.HandleId, ConfigHonamiStoryAreaTaskByActivityId.LogPair);
				return null;
			}
			List<HonamiStoryAreaTask> list = new List<HonamiStoryAreaTask>();
			while (ConfigCommon.Step(ConfigHonamiStoryAreaTaskByActivityId.HandleId, false, ConfigHonamiStoryAreaTaskByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryAreaTaskByActivityId.HandleId, 0, ConfigHonamiStoryAreaTaskByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigHonamiStoryAreaTaskByActivityId.HandleId, ConfigHonamiStoryAreaTaskByActivityId.LogPair);
					return null;
				}
				HonamiStoryAreaTask rootAsHonamiStoryAreaTask = HonamiStoryAreaTask.GetRootAsHonamiStoryAreaTask(new ByteBuffer(item2));
				list.Add(rootAsHonamiStoryAreaTask);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryAreaTaskByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigHonamiStoryAreaTaskByActivityId.HandleId, ConfigHonamiStoryAreaTaskByActivityId.LogPair);
			return list;
		}

		// Token: 0x04001AEF RID: 6895
		private const string DB = "db_honamistory.db";

		// Token: 0x04001AF0 RID: 6896
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001AF1 RID: 6897
		private const string TABLE = "HonamiStoryAreaTask";

		// Token: 0x04001AF2 RID: 6898
		private const string COMMAND = "select BinData from `HonamiStoryAreaTask` where ActivityId=?";

		// Token: 0x04001AF3 RID: 6899
		private const string KEY_PREFIX = "HonamiStoryAreaTaskByActivityId";

		// Token: 0x04001AF4 RID: 6900
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001AF5 RID: 6901
		private static int HandleId;
	}
}

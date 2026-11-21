using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200041A RID: 1050
	public class ConfigHonamiStoryResidentTaskByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018A3 RID: 6307 RVA: 0x000E89D4 File Offset: 0x000E6BD4
		static ConfigHonamiStoryResidentTaskByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryResidentTaskByActivityId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryResidentTaskByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x000E89F4 File Offset: 0x000E6BF4
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

		// Token: 0x060018A5 RID: 6309 RVA: 0x000E8A73 File Offset: 0x000E6C73
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryResidentTaskByActivityId.LogPair = null;
			ConfigHonamiStoryResidentTaskByActivityId.HandleId = 0;
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x000E8A81 File Offset: 0x000E6C81
		public static void Init()
		{
			ConfigHonamiStoryResidentTaskByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryResidentTaskByActivityId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryResidentTask` where ActivityId=?");
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x000E8A9C File Offset: 0x000E6C9C
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

		// Token: 0x04001C9A RID: 7322
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C9B RID: 7323
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001C9C RID: 7324
		private const string TABLE = "HonamiStoryResidentTask";

		// Token: 0x04001C9D RID: 7325
		private const string COMMAND = "select BinData from `HonamiStoryResidentTask` where ActivityId=?";

		// Token: 0x04001C9E RID: 7326
		private const string KEY_PREFIX = "HonamiStoryResidentTaskByActivityId";

		// Token: 0x04001C9F RID: 7327
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001CA0 RID: 7328
		private static int HandleId;
	}
}

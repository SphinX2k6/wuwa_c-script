using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003F3 RID: 1011
	public class ConfigHonamiStoryAreaTaskByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017B9 RID: 6073 RVA: 0x000E32F0 File Offset: 0x000E14F0
		static ConfigHonamiStoryAreaTaskByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryAreaTaskByActivityId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryAreaTaskByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x000E3310 File Offset: 0x000E1510
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

		// Token: 0x060017BB RID: 6075 RVA: 0x000E338F File Offset: 0x000E158F
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryAreaTaskByActivityId.LogPair = null;
			ConfigHonamiStoryAreaTaskByActivityId.HandleId = 0;
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x000E339D File Offset: 0x000E159D
		public static void Init()
		{
			ConfigHonamiStoryAreaTaskByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryAreaTaskByActivityId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryAreaTask` where ActivityId=?");
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x000E33B8 File Offset: 0x000E15B8
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

		// Token: 0x04001B89 RID: 7049
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B8A RID: 7050
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001B8B RID: 7051
		private const string TABLE = "HonamiStoryAreaTask";

		// Token: 0x04001B8C RID: 7052
		private const string COMMAND = "select BinData from `HonamiStoryAreaTask` where ActivityId=?";

		// Token: 0x04001B8D RID: 7053
		private const string KEY_PREFIX = "HonamiStoryAreaTaskByActivityId";

		// Token: 0x04001B8E RID: 7054
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B8F RID: 7055
		private static int HandleId;
	}
}

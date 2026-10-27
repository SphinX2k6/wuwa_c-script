using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007B9 RID: 1977
	public class ConfigRealmBetweenTaskByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E68 RID: 11880 RVA: 0x0015FAE0 File Offset: 0x0015DCE0
		static ConfigRealmBetweenTaskByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRealmBetweenTaskByActivityId.CreateStaticDefaultValue), new Action(ConfigRealmBetweenTaskByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002E69 RID: 11881 RVA: 0x0015FB00 File Offset: 0x0015DD00
		public static void CreateStaticDefaultValue()
		{
			ConfigRealmBetweenTaskByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRealmBetweenTaskByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_realmbetween.db"),
				new ValueTuple<string, object>("文件", "q.千岛路书3.5.xlsx"),
				new ValueTuple<string, object>("表名", "RealmBetweenTask"),
				new ValueTuple<string, object>("语句", "select BinData from `RealmBetweenTask` where ActivityId=?")
			});
		}

		// Token: 0x06002E6A RID: 11882 RVA: 0x0015FB7F File Offset: 0x0015DD7F
		public static void ResetStaticDefaultValue()
		{
			ConfigRealmBetweenTaskByActivityId.LogPair = null;
			ConfigRealmBetweenTaskByActivityId.HandleId = 0;
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x0015FB8D File Offset: 0x0015DD8D
		public static void Init()
		{
			ConfigRealmBetweenTaskByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRealmBetweenTaskByActivityId.HandleId, "db_realmbetween.db", "select BinData from `RealmBetweenTask` where ActivityId=?");
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x0015FBA8 File Offset: 0x0015DDA8
		[NullableContext(2)]
		public static IReadOnlyList<RealmBetweenTask> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRealmBetweenTaskByActivityId.HandleId, ConfigRealmBetweenTaskByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RealmBetweenTaskByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<RealmBetweenTask> readOnlyList = (IReadOnlyList<RealmBetweenTask>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRealmBetweenTaskByActivityId.LogPair.Clear();
			ConfigRealmBetweenTaskByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigRealmBetweenTaskByActivityId.HandleId, 1, p0ActivityId, ConfigRealmBetweenTaskByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigRealmBetweenTaskByActivityId.HandleId, ConfigRealmBetweenTaskByActivityId.LogPair);
				return null;
			}
			List<RealmBetweenTask> list = new List<RealmBetweenTask>();
			while (ConfigCommon.Step(ConfigRealmBetweenTaskByActivityId.HandleId, false, ConfigRealmBetweenTaskByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRealmBetweenTaskByActivityId.HandleId, 0, ConfigRealmBetweenTaskByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRealmBetweenTaskByActivityId.HandleId, ConfigRealmBetweenTaskByActivityId.LogPair);
					return null;
				}
				RealmBetweenTask rootAsRealmBetweenTask = RealmBetweenTask.GetRootAsRealmBetweenTask(new ByteBuffer(item2));
				list.Add(rootAsRealmBetweenTask);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RealmBetweenTaskByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRealmBetweenTaskByActivityId.HandleId, ConfigRealmBetweenTaskByActivityId.LogPair);
			return list;
		}

		// Token: 0x040035F5 RID: 13813
		private const string DB = "db_realmbetween.db";

		// Token: 0x040035F6 RID: 13814
		private const string FILE = "q.千岛路书3.5.xlsx";

		// Token: 0x040035F7 RID: 13815
		private const string TABLE = "RealmBetweenTask";

		// Token: 0x040035F8 RID: 13816
		private const string COMMAND = "select BinData from `RealmBetweenTask` where ActivityId=?";

		// Token: 0x040035F9 RID: 13817
		private const string KEY_PREFIX = "RealmBetweenTaskByActivityId";

		// Token: 0x040035FA RID: 13818
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035FB RID: 13819
		private static int HandleId;
	}
}

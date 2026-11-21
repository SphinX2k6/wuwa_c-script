using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007D3 RID: 2003
	public class ConfigRealmBetweenTaskByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F04 RID: 12036 RVA: 0x001669EC File Offset: 0x00164BEC
		static ConfigRealmBetweenTaskByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRealmBetweenTaskByActivityId.CreateStaticDefaultValue), new Action(ConfigRealmBetweenTaskByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002F05 RID: 12037 RVA: 0x00166A0C File Offset: 0x00164C0C
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

		// Token: 0x06002F06 RID: 12038 RVA: 0x00166A8B File Offset: 0x00164C8B
		public static void ResetStaticDefaultValue()
		{
			ConfigRealmBetweenTaskByActivityId.LogPair = null;
			ConfigRealmBetweenTaskByActivityId.HandleId = 0;
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x00166A99 File Offset: 0x00164C99
		public static void Init()
		{
			ConfigRealmBetweenTaskByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRealmBetweenTaskByActivityId.HandleId, "db_realmbetween.db", "select BinData from `RealmBetweenTask` where ActivityId=?");
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x00166AB4 File Offset: 0x00164CB4
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

		// Token: 0x040036AB RID: 13995
		private const string DB = "db_realmbetween.db";

		// Token: 0x040036AC RID: 13996
		private const string FILE = "q.千岛路书3.5.xlsx";

		// Token: 0x040036AD RID: 13997
		private const string TABLE = "RealmBetweenTask";

		// Token: 0x040036AE RID: 13998
		private const string COMMAND = "select BinData from `RealmBetweenTask` where ActivityId=?";

		// Token: 0x040036AF RID: 13999
		private const string KEY_PREFIX = "RealmBetweenTaskByActivityId";

		// Token: 0x040036B0 RID: 14000
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036B1 RID: 14001
		private static int HandleId;
	}
}

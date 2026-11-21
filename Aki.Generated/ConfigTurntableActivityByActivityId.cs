using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B30 RID: 2864
	public class ConfigTurntableActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004334 RID: 17204 RVA: 0x001D8EEC File Offset: 0x001D70EC
		static ConfigTurntableActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTurntableActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigTurntableActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06004335 RID: 17205 RVA: 0x001D8F0C File Offset: 0x001D710C
		public static void CreateStaticDefaultValue()
		{
			ConfigTurntableActivityByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTurntableActivityByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_turntableactivity.db"),
				new ValueTuple<string, object>("文件", "z.转盘活动.xlsx"),
				new ValueTuple<string, object>("表名", "TurntableActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `TurntableActivity` where ActivityId = ?")
			});
		}

		// Token: 0x06004336 RID: 17206 RVA: 0x001D8F8B File Offset: 0x001D718B
		public static void ResetStaticDefaultValue()
		{
			ConfigTurntableActivityByActivityId.LogPair = null;
			ConfigTurntableActivityByActivityId.HandleId = 0;
		}

		// Token: 0x06004337 RID: 17207 RVA: 0x001D8F99 File Offset: 0x001D7199
		public static void Init()
		{
			ConfigTurntableActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTurntableActivityByActivityId.HandleId, "db_turntableactivity.db", "select BinData from `TurntableActivity` where ActivityId = ?");
		}

		// Token: 0x06004338 RID: 17208 RVA: 0x001D8FB4 File Offset: 0x001D71B4
		[NullableContext(2)]
		public static IReadOnlyList<TurntableActivity> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTurntableActivityByActivityId.HandleId, ConfigTurntableActivityByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TurntableActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<TurntableActivity> readOnlyList = (IReadOnlyList<TurntableActivity>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTurntableActivityByActivityId.LogPair.Clear();
			ConfigTurntableActivityByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigTurntableActivityByActivityId.HandleId, 1, p0ActivityId, ConfigTurntableActivityByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigTurntableActivityByActivityId.HandleId, ConfigTurntableActivityByActivityId.LogPair);
				return null;
			}
			List<TurntableActivity> list = new List<TurntableActivity>();
			while (ConfigCommon.Step(ConfigTurntableActivityByActivityId.HandleId, false, ConfigTurntableActivityByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTurntableActivityByActivityId.HandleId, 0, ConfigTurntableActivityByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTurntableActivityByActivityId.HandleId, ConfigTurntableActivityByActivityId.LogPair);
					return null;
				}
				TurntableActivity rootAsTurntableActivity = TurntableActivity.GetRootAsTurntableActivity(new ByteBuffer(item2));
				list.Add(rootAsTurntableActivity);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TurntableActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTurntableActivityByActivityId.HandleId, ConfigTurntableActivityByActivityId.LogPair);
			return list;
		}

		// Token: 0x04004E36 RID: 20022
		private const string DB = "db_turntableactivity.db";

		// Token: 0x04004E37 RID: 20023
		private const string FILE = "z.转盘活动.xlsx";

		// Token: 0x04004E38 RID: 20024
		private const string TABLE = "TurntableActivity";

		// Token: 0x04004E39 RID: 20025
		private const string COMMAND = "select BinData from `TurntableActivity` where ActivityId = ?";

		// Token: 0x04004E3A RID: 20026
		private const string KEY_PREFIX = "TurntableActivityByActivityId";

		// Token: 0x04004E3B RID: 20027
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004E3C RID: 20028
		private static int HandleId;
	}
}

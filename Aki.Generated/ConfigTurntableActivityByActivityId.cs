using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A5B RID: 2651
	public class ConfigTurntableActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E36 RID: 15926 RVA: 0x001B9B58 File Offset: 0x001B7D58
		static ConfigTurntableActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTurntableActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigTurntableActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003E37 RID: 15927 RVA: 0x001B9B78 File Offset: 0x001B7D78
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

		// Token: 0x06003E38 RID: 15928 RVA: 0x001B9BF7 File Offset: 0x001B7DF7
		public static void ResetStaticDefaultValue()
		{
			ConfigTurntableActivityByActivityId.LogPair = null;
			ConfigTurntableActivityByActivityId.HandleId = 0;
		}

		// Token: 0x06003E39 RID: 15929 RVA: 0x001B9C05 File Offset: 0x001B7E05
		public static void Init()
		{
			ConfigTurntableActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTurntableActivityByActivityId.HandleId, "db_turntableactivity.db", "select BinData from `TurntableActivity` where ActivityId = ?");
		}

		// Token: 0x06003E3A RID: 15930 RVA: 0x001B9C20 File Offset: 0x001B7E20
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

		// Token: 0x04004863 RID: 18531
		private const string DB = "db_turntableactivity.db";

		// Token: 0x04004864 RID: 18532
		private const string FILE = "z.转盘活动.xlsx";

		// Token: 0x04004865 RID: 18533
		private const string TABLE = "TurntableActivity";

		// Token: 0x04004866 RID: 18534
		private const string COMMAND = "select BinData from `TurntableActivity` where ActivityId = ?";

		// Token: 0x04004867 RID: 18535
		private const string KEY_PREFIX = "TurntableActivityByActivityId";

		// Token: 0x04004868 RID: 18536
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004869 RID: 18537
		private static int HandleId;
	}
}

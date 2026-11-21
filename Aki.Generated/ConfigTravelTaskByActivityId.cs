using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B22 RID: 2850
	public class ConfigTravelTaskByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060042E0 RID: 17120 RVA: 0x001D70A4 File Offset: 0x001D52A4
		static ConfigTravelTaskByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTravelTaskByActivityId.CreateStaticDefaultValue), new Action(ConfigTravelTaskByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060042E1 RID: 17121 RVA: 0x001D70C4 File Offset: 0x001D52C4
		public static void CreateStaticDefaultValue()
		{
			ConfigTravelTaskByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTravelTaskByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitymaptravel.db"),
				new ValueTuple<string, object>("文件", "d.地图主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "TravelTask"),
				new ValueTuple<string, object>("语句", "select BinData from `TravelTask` where ActivityId=?")
			});
		}

		// Token: 0x060042E2 RID: 17122 RVA: 0x001D7143 File Offset: 0x001D5343
		public static void ResetStaticDefaultValue()
		{
			ConfigTravelTaskByActivityId.LogPair = null;
			ConfigTravelTaskByActivityId.HandleId = 0;
		}

		// Token: 0x060042E3 RID: 17123 RVA: 0x001D7151 File Offset: 0x001D5351
		public static void Init()
		{
			ConfigTravelTaskByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTravelTaskByActivityId.HandleId, "db_activitymaptravel.db", "select BinData from `TravelTask` where ActivityId=?");
		}

		// Token: 0x060042E4 RID: 17124 RVA: 0x001D716C File Offset: 0x001D536C
		[NullableContext(2)]
		public static IReadOnlyList<TravelTask> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTravelTaskByActivityId.HandleId, ConfigTravelTaskByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TravelTaskByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<TravelTask> readOnlyList = (IReadOnlyList<TravelTask>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTravelTaskByActivityId.LogPair.Clear();
			ConfigTravelTaskByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigTravelTaskByActivityId.HandleId, 1, p0ActivityId, ConfigTravelTaskByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigTravelTaskByActivityId.HandleId, ConfigTravelTaskByActivityId.LogPair);
				return null;
			}
			List<TravelTask> list = new List<TravelTask>();
			while (ConfigCommon.Step(ConfigTravelTaskByActivityId.HandleId, false, ConfigTravelTaskByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTravelTaskByActivityId.HandleId, 0, ConfigTravelTaskByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTravelTaskByActivityId.HandleId, ConfigTravelTaskByActivityId.LogPair);
					return null;
				}
				TravelTask rootAsTravelTask = TravelTask.GetRootAsTravelTask(new ByteBuffer(item2));
				list.Add(rootAsTravelTask);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TravelTaskByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTravelTaskByActivityId.HandleId, ConfigTravelTaskByActivityId.LogPair);
			return list;
		}

		// Token: 0x04004DD4 RID: 19924
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x04004DD5 RID: 19925
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x04004DD6 RID: 19926
		private const string TABLE = "TravelTask";

		// Token: 0x04004DD7 RID: 19927
		private const string COMMAND = "select BinData from `TravelTask` where ActivityId=?";

		// Token: 0x04004DD8 RID: 19928
		private const string KEY_PREFIX = "TravelTaskByActivityId";

		// Token: 0x04004DD9 RID: 19929
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004DDA RID: 19930
		private static int HandleId;
	}
}

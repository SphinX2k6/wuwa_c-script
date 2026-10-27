using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A4D RID: 2637
	public class ConfigTravelTaskByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DE2 RID: 15842 RVA: 0x001B7D10 File Offset: 0x001B5F10
		static ConfigTravelTaskByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTravelTaskByActivityId.CreateStaticDefaultValue), new Action(ConfigTravelTaskByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003DE3 RID: 15843 RVA: 0x001B7D30 File Offset: 0x001B5F30
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

		// Token: 0x06003DE4 RID: 15844 RVA: 0x001B7DAF File Offset: 0x001B5FAF
		public static void ResetStaticDefaultValue()
		{
			ConfigTravelTaskByActivityId.LogPair = null;
			ConfigTravelTaskByActivityId.HandleId = 0;
		}

		// Token: 0x06003DE5 RID: 15845 RVA: 0x001B7DBD File Offset: 0x001B5FBD
		public static void Init()
		{
			ConfigTravelTaskByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTravelTaskByActivityId.HandleId, "db_activitymaptravel.db", "select BinData from `TravelTask` where ActivityId=?");
		}

		// Token: 0x06003DE6 RID: 15846 RVA: 0x001B7DD8 File Offset: 0x001B5FD8
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

		// Token: 0x04004801 RID: 18433
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x04004802 RID: 18434
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x04004803 RID: 18435
		private const string TABLE = "TravelTask";

		// Token: 0x04004804 RID: 18436
		private const string COMMAND = "select BinData from `TravelTask` where ActivityId=?";

		// Token: 0x04004805 RID: 18437
		private const string KEY_PREFIX = "TravelTaskByActivityId";

		// Token: 0x04004806 RID: 18438
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004807 RID: 18439
		private static int HandleId;
	}
}

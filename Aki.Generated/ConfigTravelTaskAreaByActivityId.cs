using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B20 RID: 2848
	public class ConfigTravelTaskAreaByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060042D4 RID: 17108 RVA: 0x001D6C24 File Offset: 0x001D4E24
		static ConfigTravelTaskAreaByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTravelTaskAreaByActivityId.CreateStaticDefaultValue), new Action(ConfigTravelTaskAreaByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060042D5 RID: 17109 RVA: 0x001D6C44 File Offset: 0x001D4E44
		public static void CreateStaticDefaultValue()
		{
			ConfigTravelTaskAreaByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTravelTaskAreaByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitymaptravel.db"),
				new ValueTuple<string, object>("文件", "d.地图主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "TravelTaskArea"),
				new ValueTuple<string, object>("语句", "select BinData from `TravelTaskArea` where ActivityId=?")
			});
		}

		// Token: 0x060042D6 RID: 17110 RVA: 0x001D6CC3 File Offset: 0x001D4EC3
		public static void ResetStaticDefaultValue()
		{
			ConfigTravelTaskAreaByActivityId.LogPair = null;
			ConfigTravelTaskAreaByActivityId.HandleId = 0;
		}

		// Token: 0x060042D7 RID: 17111 RVA: 0x001D6CD1 File Offset: 0x001D4ED1
		public static void Init()
		{
			ConfigTravelTaskAreaByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTravelTaskAreaByActivityId.HandleId, "db_activitymaptravel.db", "select BinData from `TravelTaskArea` where ActivityId=?");
		}

		// Token: 0x060042D8 RID: 17112 RVA: 0x001D6CEC File Offset: 0x001D4EEC
		[NullableContext(2)]
		public static IReadOnlyList<TravelTaskArea> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTravelTaskAreaByActivityId.HandleId, ConfigTravelTaskAreaByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TravelTaskAreaByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<TravelTaskArea> readOnlyList = (IReadOnlyList<TravelTaskArea>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTravelTaskAreaByActivityId.LogPair.Clear();
			ConfigTravelTaskAreaByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigTravelTaskAreaByActivityId.HandleId, 1, p0ActivityId, ConfigTravelTaskAreaByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigTravelTaskAreaByActivityId.HandleId, ConfigTravelTaskAreaByActivityId.LogPair);
				return null;
			}
			List<TravelTaskArea> list = new List<TravelTaskArea>();
			while (ConfigCommon.Step(ConfigTravelTaskAreaByActivityId.HandleId, false, ConfigTravelTaskAreaByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTravelTaskAreaByActivityId.HandleId, 0, ConfigTravelTaskAreaByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTravelTaskAreaByActivityId.HandleId, ConfigTravelTaskAreaByActivityId.LogPair);
					return null;
				}
				TravelTaskArea rootAsTravelTaskArea = TravelTaskArea.GetRootAsTravelTaskArea(new ByteBuffer(item2));
				list.Add(rootAsTravelTaskArea);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TravelTaskAreaByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTravelTaskAreaByActivityId.HandleId, ConfigTravelTaskAreaByActivityId.LogPair);
			return list;
		}

		// Token: 0x04004DC6 RID: 19910
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x04004DC7 RID: 19911
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x04004DC8 RID: 19912
		private const string TABLE = "TravelTaskArea";

		// Token: 0x04004DC9 RID: 19913
		private const string COMMAND = "select BinData from `TravelTaskArea` where ActivityId=?";

		// Token: 0x04004DCA RID: 19914
		private const string KEY_PREFIX = "TravelTaskAreaByActivityId";

		// Token: 0x04004DCB RID: 19915
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004DCC RID: 19916
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A4B RID: 2635
	public class ConfigTravelTaskAreaByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DD6 RID: 15830 RVA: 0x001B7890 File Offset: 0x001B5A90
		static ConfigTravelTaskAreaByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTravelTaskAreaByActivityId.CreateStaticDefaultValue), new Action(ConfigTravelTaskAreaByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003DD7 RID: 15831 RVA: 0x001B78B0 File Offset: 0x001B5AB0
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

		// Token: 0x06003DD8 RID: 15832 RVA: 0x001B792F File Offset: 0x001B5B2F
		public static void ResetStaticDefaultValue()
		{
			ConfigTravelTaskAreaByActivityId.LogPair = null;
			ConfigTravelTaskAreaByActivityId.HandleId = 0;
		}

		// Token: 0x06003DD9 RID: 15833 RVA: 0x001B793D File Offset: 0x001B5B3D
		public static void Init()
		{
			ConfigTravelTaskAreaByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTravelTaskAreaByActivityId.HandleId, "db_activitymaptravel.db", "select BinData from `TravelTaskArea` where ActivityId=?");
		}

		// Token: 0x06003DDA RID: 15834 RVA: 0x001B7958 File Offset: 0x001B5B58
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

		// Token: 0x040047F3 RID: 18419
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x040047F4 RID: 18420
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x040047F5 RID: 18421
		private const string TABLE = "TravelTaskArea";

		// Token: 0x040047F6 RID: 18422
		private const string COMMAND = "select BinData from `TravelTaskArea` where ActivityId=?";

		// Token: 0x040047F7 RID: 18423
		private const string KEY_PREFIX = "TravelTaskAreaByActivityId";

		// Token: 0x040047F8 RID: 18424
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040047F9 RID: 18425
		private static int HandleId;
	}
}

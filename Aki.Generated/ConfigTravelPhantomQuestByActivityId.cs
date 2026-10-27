using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A48 RID: 2632
	public class ConfigTravelPhantomQuestByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DC4 RID: 15812 RVA: 0x001B71C7 File Offset: 0x001B53C7
		static ConfigTravelPhantomQuestByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTravelPhantomQuestByActivityId.CreateStaticDefaultValue), new Action(ConfigTravelPhantomQuestByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003DC5 RID: 15813 RVA: 0x001B71E8 File Offset: 0x001B53E8
		public static void CreateStaticDefaultValue()
		{
			ConfigTravelPhantomQuestByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTravelPhantomQuestByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitymaptravel.db"),
				new ValueTuple<string, object>("文件", "d.地图主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "TravelPhantomQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `TravelPhantomQuest` where ActivityId=?")
			});
		}

		// Token: 0x06003DC6 RID: 15814 RVA: 0x001B7267 File Offset: 0x001B5467
		public static void ResetStaticDefaultValue()
		{
			ConfigTravelPhantomQuestByActivityId.LogPair = null;
			ConfigTravelPhantomQuestByActivityId.HandleId = 0;
		}

		// Token: 0x06003DC7 RID: 15815 RVA: 0x001B7275 File Offset: 0x001B5475
		public static void Init()
		{
			ConfigTravelPhantomQuestByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTravelPhantomQuestByActivityId.HandleId, "db_activitymaptravel.db", "select BinData from `TravelPhantomQuest` where ActivityId=?");
		}

		// Token: 0x06003DC8 RID: 15816 RVA: 0x001B7290 File Offset: 0x001B5490
		[NullableContext(2)]
		public static IReadOnlyList<TravelPhantomQuest> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTravelPhantomQuestByActivityId.HandleId, ConfigTravelPhantomQuestByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TravelPhantomQuestByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<TravelPhantomQuest> readOnlyList = (IReadOnlyList<TravelPhantomQuest>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTravelPhantomQuestByActivityId.LogPair.Clear();
			ConfigTravelPhantomQuestByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigTravelPhantomQuestByActivityId.HandleId, 1, p0ActivityId, ConfigTravelPhantomQuestByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigTravelPhantomQuestByActivityId.HandleId, ConfigTravelPhantomQuestByActivityId.LogPair);
				return null;
			}
			List<TravelPhantomQuest> list = new List<TravelPhantomQuest>();
			while (ConfigCommon.Step(ConfigTravelPhantomQuestByActivityId.HandleId, false, ConfigTravelPhantomQuestByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTravelPhantomQuestByActivityId.HandleId, 0, ConfigTravelPhantomQuestByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTravelPhantomQuestByActivityId.HandleId, ConfigTravelPhantomQuestByActivityId.LogPair);
					return null;
				}
				TravelPhantomQuest rootAsTravelPhantomQuest = TravelPhantomQuest.GetRootAsTravelPhantomQuest(new ByteBuffer(item2));
				list.Add(rootAsTravelPhantomQuest);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TravelPhantomQuestByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTravelPhantomQuestByActivityId.HandleId, ConfigTravelPhantomQuestByActivityId.LogPair);
			return list;
		}

		// Token: 0x040047DE RID: 18398
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x040047DF RID: 18399
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x040047E0 RID: 18400
		private const string TABLE = "TravelPhantomQuest";

		// Token: 0x040047E1 RID: 18401
		private const string COMMAND = "select BinData from `TravelPhantomQuest` where ActivityId=?";

		// Token: 0x040047E2 RID: 18402
		private const string KEY_PREFIX = "TravelPhantomQuestByActivityId";

		// Token: 0x040047E3 RID: 18403
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040047E4 RID: 18404
		private static int HandleId;
	}
}

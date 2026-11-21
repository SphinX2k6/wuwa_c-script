using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B1D RID: 2845
	public class ConfigTravelPhantomQuestByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060042C2 RID: 17090 RVA: 0x001D655B File Offset: 0x001D475B
		static ConfigTravelPhantomQuestByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTravelPhantomQuestByActivityId.CreateStaticDefaultValue), new Action(ConfigTravelPhantomQuestByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060042C3 RID: 17091 RVA: 0x001D657C File Offset: 0x001D477C
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

		// Token: 0x060042C4 RID: 17092 RVA: 0x001D65FB File Offset: 0x001D47FB
		public static void ResetStaticDefaultValue()
		{
			ConfigTravelPhantomQuestByActivityId.LogPair = null;
			ConfigTravelPhantomQuestByActivityId.HandleId = 0;
		}

		// Token: 0x060042C5 RID: 17093 RVA: 0x001D6609 File Offset: 0x001D4809
		public static void Init()
		{
			ConfigTravelPhantomQuestByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTravelPhantomQuestByActivityId.HandleId, "db_activitymaptravel.db", "select BinData from `TravelPhantomQuest` where ActivityId=?");
		}

		// Token: 0x060042C6 RID: 17094 RVA: 0x001D6624 File Offset: 0x001D4824
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

		// Token: 0x04004DB1 RID: 19889
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x04004DB2 RID: 19890
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x04004DB3 RID: 19891
		private const string TABLE = "TravelPhantomQuest";

		// Token: 0x04004DB4 RID: 19892
		private const string COMMAND = "select BinData from `TravelPhantomQuest` where ActivityId=?";

		// Token: 0x04004DB5 RID: 19893
		private const string KEY_PREFIX = "TravelPhantomQuestByActivityId";

		// Token: 0x04004DB6 RID: 19894
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004DB7 RID: 19895
		private static int HandleId;
	}
}

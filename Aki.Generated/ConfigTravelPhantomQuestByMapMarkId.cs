using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B1F RID: 2847
	public class ConfigTravelPhantomQuestByMapMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060042CE RID: 17102 RVA: 0x001D69DC File Offset: 0x001D4BDC
		static ConfigTravelPhantomQuestByMapMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTravelPhantomQuestByMapMarkId.CreateStaticDefaultValue), new Action(ConfigTravelPhantomQuestByMapMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x060042CF RID: 17103 RVA: 0x001D69FC File Offset: 0x001D4BFC
		public static void CreateStaticDefaultValue()
		{
			ConfigTravelPhantomQuestByMapMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTravelPhantomQuestByMapMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitymaptravel.db"),
				new ValueTuple<string, object>("文件", "d.地图主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "TravelPhantomQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `TravelPhantomQuest` where MapMarkId=?")
			});
		}

		// Token: 0x060042D0 RID: 17104 RVA: 0x001D6A7B File Offset: 0x001D4C7B
		public static void ResetStaticDefaultValue()
		{
			ConfigTravelPhantomQuestByMapMarkId.LogPair = null;
			ConfigTravelPhantomQuestByMapMarkId.HandleId = 0;
		}

		// Token: 0x060042D1 RID: 17105 RVA: 0x001D6A89 File Offset: 0x001D4C89
		public static void Init()
		{
			ConfigTravelPhantomQuestByMapMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigTravelPhantomQuestByMapMarkId.HandleId, "db_activitymaptravel.db", "select BinData from `TravelPhantomQuest` where MapMarkId=?");
		}

		// Token: 0x060042D2 RID: 17106 RVA: 0x001D6AA4 File Offset: 0x001D4CA4
		public static TravelPhantomQuest? GetConfig(int p0MapMarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTravelPhantomQuestByMapMarkId.HandleId, ConfigTravelPhantomQuestByMapMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TravelPhantomQuestByMapMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapMarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TravelPhantomQuest?(TravelPhantomQuest.GetRootAsTravelPhantomQuest(configBuffer));
				}
			}
			ConfigTravelPhantomQuestByMapMarkId.LogPair.Clear();
			ConfigTravelPhantomQuestByMapMarkId.LogPair.Add(new ValueTuple<string, object>("MapMarkId", p0MapMarkId));
			if (!ConfigCommon.BindInt(ConfigTravelPhantomQuestByMapMarkId.HandleId, 1, p0MapMarkId, ConfigTravelPhantomQuestByMapMarkId.LogPair) || ConfigCommon.Step(ConfigTravelPhantomQuestByMapMarkId.HandleId, true, ConfigTravelPhantomQuestByMapMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTravelPhantomQuestByMapMarkId.HandleId, ConfigTravelPhantomQuestByMapMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTravelPhantomQuestByMapMarkId.HandleId, 0, ConfigTravelPhantomQuestByMapMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTravelPhantomQuestByMapMarkId.HandleId, ConfigTravelPhantomQuestByMapMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TravelPhantomQuest rootAsTravelPhantomQuest = TravelPhantomQuest.GetRootAsTravelPhantomQuest(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TravelPhantomQuestByMapMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapMarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTravelPhantomQuestByMapMarkId.HandleId, ConfigTravelPhantomQuestByMapMarkId.LogPair);
			return new TravelPhantomQuest?(rootAsTravelPhantomQuest);
		}

		// Token: 0x04004DBF RID: 19903
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x04004DC0 RID: 19904
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x04004DC1 RID: 19905
		private const string TABLE = "TravelPhantomQuest";

		// Token: 0x04004DC2 RID: 19906
		private const string COMMAND = "select BinData from `TravelPhantomQuest` where MapMarkId=?";

		// Token: 0x04004DC3 RID: 19907
		private const string KEY_PREFIX = "TravelPhantomQuestByMapMarkId";

		// Token: 0x04004DC4 RID: 19908
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004DC5 RID: 19909
		private static int HandleId;
	}
}

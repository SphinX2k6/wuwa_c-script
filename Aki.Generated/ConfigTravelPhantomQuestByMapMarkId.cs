using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A4A RID: 2634
	public class ConfigTravelPhantomQuestByMapMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DD0 RID: 15824 RVA: 0x001B7648 File Offset: 0x001B5848
		static ConfigTravelPhantomQuestByMapMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTravelPhantomQuestByMapMarkId.CreateStaticDefaultValue), new Action(ConfigTravelPhantomQuestByMapMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06003DD1 RID: 15825 RVA: 0x001B7668 File Offset: 0x001B5868
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

		// Token: 0x06003DD2 RID: 15826 RVA: 0x001B76E7 File Offset: 0x001B58E7
		public static void ResetStaticDefaultValue()
		{
			ConfigTravelPhantomQuestByMapMarkId.LogPair = null;
			ConfigTravelPhantomQuestByMapMarkId.HandleId = 0;
		}

		// Token: 0x06003DD3 RID: 15827 RVA: 0x001B76F5 File Offset: 0x001B58F5
		public static void Init()
		{
			ConfigTravelPhantomQuestByMapMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigTravelPhantomQuestByMapMarkId.HandleId, "db_activitymaptravel.db", "select BinData from `TravelPhantomQuest` where MapMarkId=?");
		}

		// Token: 0x06003DD4 RID: 15828 RVA: 0x001B7710 File Offset: 0x001B5910
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

		// Token: 0x040047EC RID: 18412
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x040047ED RID: 18413
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x040047EE RID: 18414
		private const string TABLE = "TravelPhantomQuest";

		// Token: 0x040047EF RID: 18415
		private const string COMMAND = "select BinData from `TravelPhantomQuest` where MapMarkId=?";

		// Token: 0x040047F0 RID: 18416
		private const string KEY_PREFIX = "TravelPhantomQuestByMapMarkId";

		// Token: 0x040047F1 RID: 18417
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040047F2 RID: 18418
		private static int HandleId;
	}
}

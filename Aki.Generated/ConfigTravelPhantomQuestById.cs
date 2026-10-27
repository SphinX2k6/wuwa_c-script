using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A49 RID: 2633
	public class ConfigTravelPhantomQuestById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DCA RID: 15818 RVA: 0x001B73FF File Offset: 0x001B55FF
		static ConfigTravelPhantomQuestById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTravelPhantomQuestById.CreateStaticDefaultValue), new Action(ConfigTravelPhantomQuestById.ResetStaticDefaultValue));
		}

		// Token: 0x06003DCB RID: 15819 RVA: 0x001B7420 File Offset: 0x001B5620
		public static void CreateStaticDefaultValue()
		{
			ConfigTravelPhantomQuestById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTravelPhantomQuestById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitymaptravel.db"),
				new ValueTuple<string, object>("文件", "d.地图主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "TravelPhantomQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `TravelPhantomQuest` where Id=?")
			});
		}

		// Token: 0x06003DCC RID: 15820 RVA: 0x001B749F File Offset: 0x001B569F
		public static void ResetStaticDefaultValue()
		{
			ConfigTravelPhantomQuestById.LogPair = null;
			ConfigTravelPhantomQuestById.HandleId = 0;
		}

		// Token: 0x06003DCD RID: 15821 RVA: 0x001B74AD File Offset: 0x001B56AD
		public static void Init()
		{
			ConfigTravelPhantomQuestById.HandleId = ConfigCommon.InitDataStatement(ConfigTravelPhantomQuestById.HandleId, "db_activitymaptravel.db", "select BinData from `TravelPhantomQuest` where Id=?");
		}

		// Token: 0x06003DCE RID: 15822 RVA: 0x001B74C8 File Offset: 0x001B56C8
		public static TravelPhantomQuest? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTravelPhantomQuestById.HandleId, ConfigTravelPhantomQuestById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TravelPhantomQuestById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TravelPhantomQuest?(TravelPhantomQuest.GetRootAsTravelPhantomQuest(configBuffer));
				}
			}
			ConfigTravelPhantomQuestById.LogPair.Clear();
			ConfigTravelPhantomQuestById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTravelPhantomQuestById.HandleId, 1, p0Id, ConfigTravelPhantomQuestById.LogPair) || ConfigCommon.Step(ConfigTravelPhantomQuestById.HandleId, true, ConfigTravelPhantomQuestById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTravelPhantomQuestById.HandleId, ConfigTravelPhantomQuestById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTravelPhantomQuestById.HandleId, 0, ConfigTravelPhantomQuestById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTravelPhantomQuestById.HandleId, ConfigTravelPhantomQuestById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TravelPhantomQuest rootAsTravelPhantomQuest = TravelPhantomQuest.GetRootAsTravelPhantomQuest(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TravelPhantomQuestById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTravelPhantomQuestById.HandleId, ConfigTravelPhantomQuestById.LogPair);
			return new TravelPhantomQuest?(rootAsTravelPhantomQuest);
		}

		// Token: 0x040047E5 RID: 18405
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x040047E6 RID: 18406
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x040047E7 RID: 18407
		private const string TABLE = "TravelPhantomQuest";

		// Token: 0x040047E8 RID: 18408
		private const string COMMAND = "select BinData from `TravelPhantomQuest` where Id=?";

		// Token: 0x040047E9 RID: 18409
		private const string KEY_PREFIX = "TravelPhantomQuestById";

		// Token: 0x040047EA RID: 18410
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040047EB RID: 18411
		private static int HandleId;
	}
}

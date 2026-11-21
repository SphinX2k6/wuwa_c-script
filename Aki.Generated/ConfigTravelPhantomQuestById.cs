using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B1E RID: 2846
	public class ConfigTravelPhantomQuestById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060042C8 RID: 17096 RVA: 0x001D6793 File Offset: 0x001D4993
		static ConfigTravelPhantomQuestById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTravelPhantomQuestById.CreateStaticDefaultValue), new Action(ConfigTravelPhantomQuestById.ResetStaticDefaultValue));
		}

		// Token: 0x060042C9 RID: 17097 RVA: 0x001D67B4 File Offset: 0x001D49B4
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

		// Token: 0x060042CA RID: 17098 RVA: 0x001D6833 File Offset: 0x001D4A33
		public static void ResetStaticDefaultValue()
		{
			ConfigTravelPhantomQuestById.LogPair = null;
			ConfigTravelPhantomQuestById.HandleId = 0;
		}

		// Token: 0x060042CB RID: 17099 RVA: 0x001D6841 File Offset: 0x001D4A41
		public static void Init()
		{
			ConfigTravelPhantomQuestById.HandleId = ConfigCommon.InitDataStatement(ConfigTravelPhantomQuestById.HandleId, "db_activitymaptravel.db", "select BinData from `TravelPhantomQuest` where Id=?");
		}

		// Token: 0x060042CC RID: 17100 RVA: 0x001D685C File Offset: 0x001D4A5C
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

		// Token: 0x04004DB8 RID: 19896
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x04004DB9 RID: 19897
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x04004DBA RID: 19898
		private const string TABLE = "TravelPhantomQuest";

		// Token: 0x04004DBB RID: 19899
		private const string COMMAND = "select BinData from `TravelPhantomQuest` where Id=?";

		// Token: 0x04004DBC RID: 19900
		private const string KEY_PREFIX = "TravelPhantomQuestById";

		// Token: 0x04004DBD RID: 19901
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004DBE RID: 19902
		private static int HandleId;
	}
}

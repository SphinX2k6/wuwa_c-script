using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AE1 RID: 2785
	public class ConfigTrackMoonHandbookRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600415A RID: 16730 RVA: 0x001CE534 File Offset: 0x001CC734
		static ConfigTrackMoonHandbookRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrackMoonHandbookRewardAll.CreateStaticDefaultValue), new Action(ConfigTrackMoonHandbookRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600415B RID: 16731 RVA: 0x001CE554 File Offset: 0x001CC754
		public static void CreateStaticDefaultValue()
		{
			ConfigTrackMoonHandbookRewardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrackMoonHandbookRewardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "TrackMoonHandbookReward"),
				new ValueTuple<string, object>("语句", "select BinData from `TrackMoonHandbookReward`")
			});
		}

		// Token: 0x0600415C RID: 16732 RVA: 0x001CE5D3 File Offset: 0x001CC7D3
		public static void ResetStaticDefaultValue()
		{
			ConfigTrackMoonHandbookRewardAll.LogPair = null;
			ConfigTrackMoonHandbookRewardAll.HandleId = 0;
		}

		// Token: 0x0600415D RID: 16733 RVA: 0x001CE5E1 File Offset: 0x001CC7E1
		public static void Init()
		{
			ConfigTrackMoonHandbookRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrackMoonHandbookRewardAll.HandleId, "db_moonchasing.db", "select BinData from `TrackMoonHandbookReward`");
		}

		// Token: 0x0600415E RID: 16734 RVA: 0x001CE5FC File Offset: 0x001CC7FC
		[NullableContext(2)]
		public static IReadOnlyList<TrackMoonHandbookReward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrackMoonHandbookRewardAll.HandleId, ConfigTrackMoonHandbookRewardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TrackMoonHandbookReward> readOnlyList = (IReadOnlyList<TrackMoonHandbookReward>)ConfigCommon.GetConfig("TrackMoonHandbookRewardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TrackMoonHandbookReward> list = new List<TrackMoonHandbookReward>();
			while (ConfigCommon.Step(ConfigTrackMoonHandbookRewardAll.HandleId, false, ConfigTrackMoonHandbookRewardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrackMoonHandbookRewardAll.HandleId, 0, ConfigTrackMoonHandbookRewardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrackMoonHandbookRewardAll.HandleId, ConfigTrackMoonHandbookRewardAll.LogPair);
					return null;
				}
				TrackMoonHandbookReward rootAsTrackMoonHandbookReward = TrackMoonHandbookReward.GetRootAsTrackMoonHandbookReward(new ByteBuffer(item2));
				list.Add(rootAsTrackMoonHandbookReward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TrackMoonHandbookRewardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrackMoonHandbookRewardAll.HandleId, ConfigTrackMoonHandbookRewardAll.LogPair);
			return list;
		}

		// Token: 0x04004C0D RID: 19469
		private const string DB = "db_moonchasing.db";

		// Token: 0x04004C0E RID: 19470
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04004C0F RID: 19471
		private const string TABLE = "TrackMoonHandbookReward";

		// Token: 0x04004C10 RID: 19472
		private const string COMMAND = "select BinData from `TrackMoonHandbookReward`";

		// Token: 0x04004C11 RID: 19473
		private const string KEY_PREFIX = "TrackMoonHandbookRewardAll";

		// Token: 0x04004C12 RID: 19474
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004C13 RID: 19475
		private static int HandleId;
	}
}

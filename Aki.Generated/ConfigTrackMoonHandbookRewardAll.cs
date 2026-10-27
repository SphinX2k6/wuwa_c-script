using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A0C RID: 2572
	public class ConfigTrackMoonHandbookRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C5C RID: 15452 RVA: 0x001AF1A0 File Offset: 0x001AD3A0
		static ConfigTrackMoonHandbookRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrackMoonHandbookRewardAll.CreateStaticDefaultValue), new Action(ConfigTrackMoonHandbookRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003C5D RID: 15453 RVA: 0x001AF1C0 File Offset: 0x001AD3C0
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

		// Token: 0x06003C5E RID: 15454 RVA: 0x001AF23F File Offset: 0x001AD43F
		public static void ResetStaticDefaultValue()
		{
			ConfigTrackMoonHandbookRewardAll.LogPair = null;
			ConfigTrackMoonHandbookRewardAll.HandleId = 0;
		}

		// Token: 0x06003C5F RID: 15455 RVA: 0x001AF24D File Offset: 0x001AD44D
		public static void Init()
		{
			ConfigTrackMoonHandbookRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrackMoonHandbookRewardAll.HandleId, "db_moonchasing.db", "select BinData from `TrackMoonHandbookReward`");
		}

		// Token: 0x06003C60 RID: 15456 RVA: 0x001AF268 File Offset: 0x001AD468
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

		// Token: 0x0400463A RID: 17978
		private const string DB = "db_moonchasing.db";

		// Token: 0x0400463B RID: 17979
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x0400463C RID: 17980
		private const string TABLE = "TrackMoonHandbookReward";

		// Token: 0x0400463D RID: 17981
		private const string COMMAND = "select BinData from `TrackMoonHandbookReward`";

		// Token: 0x0400463E RID: 17982
		private const string KEY_PREFIX = "TrackMoonHandbookRewardAll";

		// Token: 0x0400463F RID: 17983
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004640 RID: 17984
		private static int HandleId;
	}
}

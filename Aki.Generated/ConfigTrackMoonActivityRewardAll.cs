using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A09 RID: 2569
	public class ConfigTrackMoonActivityRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C4A RID: 15434 RVA: 0x001AEB7C File Offset: 0x001ACD7C
		static ConfigTrackMoonActivityRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrackMoonActivityRewardAll.CreateStaticDefaultValue), new Action(ConfigTrackMoonActivityRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003C4B RID: 15435 RVA: 0x001AEB9C File Offset: 0x001ACD9C
		public static void CreateStaticDefaultValue()
		{
			ConfigTrackMoonActivityRewardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrackMoonActivityRewardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trackmoonactivity.db"),
				new ValueTuple<string, object>("文件", "z.追月节活动.xlsx"),
				new ValueTuple<string, object>("表名", "TrackMoonActivityReward"),
				new ValueTuple<string, object>("语句", "select BinData from `TrackMoonActivityReward`")
			});
		}

		// Token: 0x06003C4C RID: 15436 RVA: 0x001AEC1B File Offset: 0x001ACE1B
		public static void ResetStaticDefaultValue()
		{
			ConfigTrackMoonActivityRewardAll.LogPair = null;
			ConfigTrackMoonActivityRewardAll.HandleId = 0;
		}

		// Token: 0x06003C4D RID: 15437 RVA: 0x001AEC29 File Offset: 0x001ACE29
		public static void Init()
		{
			ConfigTrackMoonActivityRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrackMoonActivityRewardAll.HandleId, "db_trackmoonactivity.db", "select BinData from `TrackMoonActivityReward`");
		}

		// Token: 0x06003C4E RID: 15438 RVA: 0x001AEC44 File Offset: 0x001ACE44
		[NullableContext(2)]
		public static IReadOnlyList<TrackMoonActivityReward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrackMoonActivityRewardAll.HandleId, ConfigTrackMoonActivityRewardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TrackMoonActivityReward> readOnlyList = (IReadOnlyList<TrackMoonActivityReward>)ConfigCommon.GetConfig("TrackMoonActivityRewardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TrackMoonActivityReward> list = new List<TrackMoonActivityReward>();
			while (ConfigCommon.Step(ConfigTrackMoonActivityRewardAll.HandleId, false, ConfigTrackMoonActivityRewardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrackMoonActivityRewardAll.HandleId, 0, ConfigTrackMoonActivityRewardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrackMoonActivityRewardAll.HandleId, ConfigTrackMoonActivityRewardAll.LogPair);
					return null;
				}
				TrackMoonActivityReward rootAsTrackMoonActivityReward = TrackMoonActivityReward.GetRootAsTrackMoonActivityReward(new ByteBuffer(item2));
				list.Add(rootAsTrackMoonActivityReward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TrackMoonActivityRewardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrackMoonActivityRewardAll.HandleId, ConfigTrackMoonActivityRewardAll.LogPair);
			return list;
		}

		// Token: 0x04004625 RID: 17957
		private const string DB = "db_trackmoonactivity.db";

		// Token: 0x04004626 RID: 17958
		private const string FILE = "z.追月节活动.xlsx";

		// Token: 0x04004627 RID: 17959
		private const string TABLE = "TrackMoonActivityReward";

		// Token: 0x04004628 RID: 17960
		private const string COMMAND = "select BinData from `TrackMoonActivityReward`";

		// Token: 0x04004629 RID: 17961
		private const string KEY_PREFIX = "TrackMoonActivityRewardAll";

		// Token: 0x0400462A RID: 17962
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400462B RID: 17963
		private static int HandleId;
	}
}

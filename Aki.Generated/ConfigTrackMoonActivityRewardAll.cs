using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ADE RID: 2782
	public class ConfigTrackMoonActivityRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004148 RID: 16712 RVA: 0x001CDF10 File Offset: 0x001CC110
		static ConfigTrackMoonActivityRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrackMoonActivityRewardAll.CreateStaticDefaultValue), new Action(ConfigTrackMoonActivityRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06004149 RID: 16713 RVA: 0x001CDF30 File Offset: 0x001CC130
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

		// Token: 0x0600414A RID: 16714 RVA: 0x001CDFAF File Offset: 0x001CC1AF
		public static void ResetStaticDefaultValue()
		{
			ConfigTrackMoonActivityRewardAll.LogPair = null;
			ConfigTrackMoonActivityRewardAll.HandleId = 0;
		}

		// Token: 0x0600414B RID: 16715 RVA: 0x001CDFBD File Offset: 0x001CC1BD
		public static void Init()
		{
			ConfigTrackMoonActivityRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrackMoonActivityRewardAll.HandleId, "db_trackmoonactivity.db", "select BinData from `TrackMoonActivityReward`");
		}

		// Token: 0x0600414C RID: 16716 RVA: 0x001CDFD8 File Offset: 0x001CC1D8
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

		// Token: 0x04004BF8 RID: 19448
		private const string DB = "db_trackmoonactivity.db";

		// Token: 0x04004BF9 RID: 19449
		private const string FILE = "z.追月节活动.xlsx";

		// Token: 0x04004BFA RID: 19450
		private const string TABLE = "TrackMoonActivityReward";

		// Token: 0x04004BFB RID: 19451
		private const string COMMAND = "select BinData from `TrackMoonActivityReward`";

		// Token: 0x04004BFC RID: 19452
		private const string KEY_PREFIX = "TrackMoonActivityRewardAll";

		// Token: 0x04004BFD RID: 19453
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004BFE RID: 19454
		private static int HandleId;
	}
}

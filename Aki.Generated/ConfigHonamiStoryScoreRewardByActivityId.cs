using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000408 RID: 1032
	public class ConfigHonamiStoryScoreRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001837 RID: 6199 RVA: 0x000E2ADC File Offset: 0x000E0CDC
		static ConfigHonamiStoryScoreRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryScoreRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryScoreRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x000E2AFC File Offset: 0x000E0CFC
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryScoreRewardByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryScoreRewardByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波物语活动奖励.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryScoreReward` where ActivityId=?")
			});
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x000E2B7B File Offset: 0x000E0D7B
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryScoreRewardByActivityId.LogPair = null;
			ConfigHonamiStoryScoreRewardByActivityId.HandleId = 0;
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x000E2B89 File Offset: 0x000E0D89
		public static void Init()
		{
			ConfigHonamiStoryScoreRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryScoreRewardByActivityId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryScoreReward` where ActivityId=?");
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x000E2BA4 File Offset: 0x000E0DA4
		[NullableContext(2)]
		public static IReadOnlyList<HonamiStoryScoreReward> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryScoreRewardByActivityId.HandleId, ConfigHonamiStoryScoreRewardByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryScoreRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<HonamiStoryScoreReward> readOnlyList = (IReadOnlyList<HonamiStoryScoreReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigHonamiStoryScoreRewardByActivityId.LogPair.Clear();
			ConfigHonamiStoryScoreRewardByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryScoreRewardByActivityId.HandleId, 1, p0ActivityId, ConfigHonamiStoryScoreRewardByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigHonamiStoryScoreRewardByActivityId.HandleId, ConfigHonamiStoryScoreRewardByActivityId.LogPair);
				return null;
			}
			List<HonamiStoryScoreReward> list = new List<HonamiStoryScoreReward>();
			while (ConfigCommon.Step(ConfigHonamiStoryScoreRewardByActivityId.HandleId, false, ConfigHonamiStoryScoreRewardByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryScoreRewardByActivityId.HandleId, 0, ConfigHonamiStoryScoreRewardByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigHonamiStoryScoreRewardByActivityId.HandleId, ConfigHonamiStoryScoreRewardByActivityId.LogPair);
					return null;
				}
				HonamiStoryScoreReward rootAsHonamiStoryScoreReward = HonamiStoryScoreReward.GetRootAsHonamiStoryScoreReward(new ByteBuffer(item2));
				list.Add(rootAsHonamiStoryScoreReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryScoreRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigHonamiStoryScoreRewardByActivityId.HandleId, ConfigHonamiStoryScoreRewardByActivityId.LogPair);
			return list;
		}

		// Token: 0x04001C1C RID: 7196
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C1D RID: 7197
		private const string FILE = "s.穗波物语活动奖励.xlsx";

		// Token: 0x04001C1E RID: 7198
		private const string TABLE = "HonamiStoryScoreReward";

		// Token: 0x04001C1F RID: 7199
		private const string COMMAND = "select BinData from `HonamiStoryScoreReward` where ActivityId=?";

		// Token: 0x04001C20 RID: 7200
		private const string KEY_PREFIX = "HonamiStoryScoreRewardByActivityId";

		// Token: 0x04001C21 RID: 7201
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C22 RID: 7202
		private static int HandleId;
	}
}

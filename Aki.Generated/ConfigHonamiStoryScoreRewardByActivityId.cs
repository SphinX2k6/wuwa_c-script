using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200041E RID: 1054
	public class ConfigHonamiStoryScoreRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018BB RID: 6331 RVA: 0x000E9230 File Offset: 0x000E7430
		static ConfigHonamiStoryScoreRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryScoreRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryScoreRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x000E9250 File Offset: 0x000E7450
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

		// Token: 0x060018BD RID: 6333 RVA: 0x000E92CF File Offset: 0x000E74CF
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryScoreRewardByActivityId.LogPair = null;
			ConfigHonamiStoryScoreRewardByActivityId.HandleId = 0;
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x000E92DD File Offset: 0x000E74DD
		public static void Init()
		{
			ConfigHonamiStoryScoreRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryScoreRewardByActivityId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryScoreReward` where ActivityId=?");
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x000E92F8 File Offset: 0x000E74F8
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

		// Token: 0x04001CB6 RID: 7350
		private const string DB = "db_honamistory.db";

		// Token: 0x04001CB7 RID: 7351
		private const string FILE = "s.穗波物语活动奖励.xlsx";

		// Token: 0x04001CB8 RID: 7352
		private const string TABLE = "HonamiStoryScoreReward";

		// Token: 0x04001CB9 RID: 7353
		private const string COMMAND = "select BinData from `HonamiStoryScoreReward` where ActivityId=?";

		// Token: 0x04001CBA RID: 7354
		private const string KEY_PREFIX = "HonamiStoryScoreRewardByActivityId";

		// Token: 0x04001CBB RID: 7355
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001CBC RID: 7356
		private static int HandleId;
	}
}

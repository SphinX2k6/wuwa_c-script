using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000502 RID: 1282
	public class ConfigLongShanScoreRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E17 RID: 7703 RVA: 0x00106DB8 File Offset: 0x00104FB8
		static ConfigLongShanScoreRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLongShanScoreRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigLongShanScoreRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x00106DD8 File Offset: 0x00104FD8
		public static void CreateStaticDefaultValue()
		{
			ConfigLongShanScoreRewardByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLongShanScoreRewardByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_longshanactivity.db"),
				new ValueTuple<string, object>("文件", "l.龙山主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "LongShanScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `LongShanScoreReward` where ActivityId=?")
			});
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x00106E57 File Offset: 0x00105057
		public static void ResetStaticDefaultValue()
		{
			ConfigLongShanScoreRewardByActivityId.LogPair = null;
			ConfigLongShanScoreRewardByActivityId.HandleId = 0;
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x00106E65 File Offset: 0x00105065
		public static void Init()
		{
			ConfigLongShanScoreRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigLongShanScoreRewardByActivityId.HandleId, "db_longshanactivity.db", "select BinData from `LongShanScoreReward` where ActivityId=?");
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x00106E80 File Offset: 0x00105080
		[NullableContext(2)]
		public static IReadOnlyList<LongShanScoreReward> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLongShanScoreRewardByActivityId.HandleId, ConfigLongShanScoreRewardByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LongShanScoreRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<LongShanScoreReward> readOnlyList = (IReadOnlyList<LongShanScoreReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigLongShanScoreRewardByActivityId.LogPair.Clear();
			ConfigLongShanScoreRewardByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigLongShanScoreRewardByActivityId.HandleId, 1, p0ActivityId, ConfigLongShanScoreRewardByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigLongShanScoreRewardByActivityId.HandleId, ConfigLongShanScoreRewardByActivityId.LogPair);
				return null;
			}
			List<LongShanScoreReward> list = new List<LongShanScoreReward>();
			while (ConfigCommon.Step(ConfigLongShanScoreRewardByActivityId.HandleId, false, ConfigLongShanScoreRewardByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLongShanScoreRewardByActivityId.HandleId, 0, ConfigLongShanScoreRewardByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigLongShanScoreRewardByActivityId.HandleId, ConfigLongShanScoreRewardByActivityId.LogPair);
					return null;
				}
				LongShanScoreReward rootAsLongShanScoreReward = LongShanScoreReward.GetRootAsLongShanScoreReward(new ByteBuffer(item2));
				list.Add(rootAsLongShanScoreReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LongShanScoreRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigLongShanScoreRewardByActivityId.HandleId, ConfigLongShanScoreRewardByActivityId.LogPair);
			return list;
		}

		// Token: 0x040022F2 RID: 8946
		private const string DB = "db_longshanactivity.db";

		// Token: 0x040022F3 RID: 8947
		private const string FILE = "l.龙山主题活动.xlsx";

		// Token: 0x040022F4 RID: 8948
		private const string TABLE = "LongShanScoreReward";

		// Token: 0x040022F5 RID: 8949
		private const string COMMAND = "select BinData from `LongShanScoreReward` where ActivityId=?";

		// Token: 0x040022F6 RID: 8950
		private const string KEY_PREFIX = "LongShanScoreRewardByActivityId";

		// Token: 0x040022F7 RID: 8951
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022F8 RID: 8952
		private static int HandleId;
	}
}

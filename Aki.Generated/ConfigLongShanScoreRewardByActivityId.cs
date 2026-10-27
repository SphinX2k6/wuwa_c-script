using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004EC RID: 1260
	public class ConfigLongShanScoreRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D93 RID: 7571 RVA: 0x00100664 File Offset: 0x000FE864
		static ConfigLongShanScoreRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLongShanScoreRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigLongShanScoreRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x00100684 File Offset: 0x000FE884
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

		// Token: 0x06001D95 RID: 7573 RVA: 0x00100703 File Offset: 0x000FE903
		public static void ResetStaticDefaultValue()
		{
			ConfigLongShanScoreRewardByActivityId.LogPair = null;
			ConfigLongShanScoreRewardByActivityId.HandleId = 0;
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x00100711 File Offset: 0x000FE911
		public static void Init()
		{
			ConfigLongShanScoreRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigLongShanScoreRewardByActivityId.HandleId, "db_longshanactivity.db", "select BinData from `LongShanScoreReward` where ActivityId=?");
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x0010072C File Offset: 0x000FE92C
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

		// Token: 0x04002258 RID: 8792
		private const string DB = "db_longshanactivity.db";

		// Token: 0x04002259 RID: 8793
		private const string FILE = "l.龙山主题活动.xlsx";

		// Token: 0x0400225A RID: 8794
		private const string TABLE = "LongShanScoreReward";

		// Token: 0x0400225B RID: 8795
		private const string COMMAND = "select BinData from `LongShanScoreReward` where ActivityId=?";

		// Token: 0x0400225C RID: 8796
		private const string KEY_PREFIX = "LongShanScoreRewardByActivityId";

		// Token: 0x0400225D RID: 8797
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400225E RID: 8798
		private static int HandleId;
	}
}

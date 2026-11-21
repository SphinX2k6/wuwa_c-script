using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007F8 RID: 2040
	public class ConfigRegressSignRewardByGradeAndActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FE2 RID: 12258 RVA: 0x0016B507 File Offset: 0x00169707
		static ConfigRegressSignRewardByGradeAndActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressSignRewardByGradeAndActivityId.CreateStaticDefaultValue), new Action(ConfigRegressSignRewardByGradeAndActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002FE3 RID: 12259 RVA: 0x0016B528 File Offset: 0x00169728
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressSignRewardByGradeAndActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressSignRewardByGradeAndActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressSignReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressSignReward` where Grade=? And ActivityId = ?")
			});
		}

		// Token: 0x06002FE4 RID: 12260 RVA: 0x0016B5A7 File Offset: 0x001697A7
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressSignRewardByGradeAndActivityId.LogPair = null;
			ConfigRegressSignRewardByGradeAndActivityId.HandleId = 0;
		}

		// Token: 0x06002FE5 RID: 12261 RVA: 0x0016B5B5 File Offset: 0x001697B5
		public static void Init()
		{
			ConfigRegressSignRewardByGradeAndActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRegressSignRewardByGradeAndActivityId.HandleId, "db_regressactivity.db", "select BinData from `RegressSignReward` where Grade=? And ActivityId = ?");
		}

		// Token: 0x06002FE6 RID: 12262 RVA: 0x0016B5D0 File Offset: 0x001697D0
		[NullableContext(2)]
		public static IReadOnlyList<RegressSignReward> GetConfigList(int p0Grade, int p1ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressSignRewardByGradeAndActivityId.HandleId, ConfigRegressSignRewardByGradeAndActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("RegressSignRewardByGradeAndActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Grade);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1ActivityId);
				IReadOnlyList<RegressSignReward> readOnlyList = (IReadOnlyList<RegressSignReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRegressSignRewardByGradeAndActivityId.LogPair.Clear();
			ConfigRegressSignRewardByGradeAndActivityId.LogPair.Add(new ValueTuple<string, object>("Grade", p0Grade));
			ConfigRegressSignRewardByGradeAndActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p1ActivityId));
			if (!ConfigCommon.BindInt(ConfigRegressSignRewardByGradeAndActivityId.HandleId, 1, p0Grade, ConfigRegressSignRewardByGradeAndActivityId.LogPair) || !ConfigCommon.BindInt(ConfigRegressSignRewardByGradeAndActivityId.HandleId, 2, p1ActivityId, ConfigRegressSignRewardByGradeAndActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigRegressSignRewardByGradeAndActivityId.HandleId, ConfigRegressSignRewardByGradeAndActivityId.LogPair);
				return null;
			}
			List<RegressSignReward> list = new List<RegressSignReward>();
			while (ConfigCommon.Step(ConfigRegressSignRewardByGradeAndActivityId.HandleId, false, ConfigRegressSignRewardByGradeAndActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressSignRewardByGradeAndActivityId.HandleId, 0, ConfigRegressSignRewardByGradeAndActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRegressSignRewardByGradeAndActivityId.HandleId, ConfigRegressSignRewardByGradeAndActivityId.LogPair);
					return null;
				}
				RegressSignReward rootAsRegressSignReward = RegressSignReward.GetRootAsRegressSignReward(new ByteBuffer(item2));
				list.Add(rootAsRegressSignReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("RegressSignRewardByGradeAndActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Grade);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRegressSignRewardByGradeAndActivityId.HandleId, ConfigRegressSignRewardByGradeAndActivityId.LogPair);
			return list;
		}

		// Token: 0x040037AE RID: 14254
		private const string DB = "db_regressactivity.db";

		// Token: 0x040037AF RID: 14255
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x040037B0 RID: 14256
		private const string TABLE = "RegressSignReward";

		// Token: 0x040037B1 RID: 14257
		private const string COMMAND = "select BinData from `RegressSignReward` where Grade=? And ActivityId = ?";

		// Token: 0x040037B2 RID: 14258
		private const string KEY_PREFIX = "RegressSignRewardByGradeAndActivityId";

		// Token: 0x040037B3 RID: 14259
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040037B4 RID: 14260
		private static int HandleId;
	}
}

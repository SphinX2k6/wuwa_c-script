using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007DC RID: 2012
	public class ConfigRegressSignRewardByGradeAndActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F3A RID: 12090 RVA: 0x0016421F File Offset: 0x0016241F
		static ConfigRegressSignRewardByGradeAndActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressSignRewardByGradeAndActivityId.CreateStaticDefaultValue), new Action(ConfigRegressSignRewardByGradeAndActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002F3B RID: 12091 RVA: 0x00164240 File Offset: 0x00162440
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

		// Token: 0x06002F3C RID: 12092 RVA: 0x001642BF File Offset: 0x001624BF
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressSignRewardByGradeAndActivityId.LogPair = null;
			ConfigRegressSignRewardByGradeAndActivityId.HandleId = 0;
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x001642CD File Offset: 0x001624CD
		public static void Init()
		{
			ConfigRegressSignRewardByGradeAndActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRegressSignRewardByGradeAndActivityId.HandleId, "db_regressactivity.db", "select BinData from `RegressSignReward` where Grade=? And ActivityId = ?");
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x001642E8 File Offset: 0x001624E8
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

		// Token: 0x040036EA RID: 14058
		private const string DB = "db_regressactivity.db";

		// Token: 0x040036EB RID: 14059
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x040036EC RID: 14060
		private const string TABLE = "RegressSignReward";

		// Token: 0x040036ED RID: 14061
		private const string COMMAND = "select BinData from `RegressSignReward` where Grade=? And ActivityId = ?";

		// Token: 0x040036EE RID: 14062
		private const string KEY_PREFIX = "RegressSignRewardByGradeAndActivityId";

		// Token: 0x040036EF RID: 14063
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036F0 RID: 14064
		private static int HandleId;
	}
}

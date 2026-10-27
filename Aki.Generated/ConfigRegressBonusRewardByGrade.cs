using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007CA RID: 1994
	public class ConfigRegressBonusRewardByGrade : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002ECE RID: 11982 RVA: 0x00161CDF File Offset: 0x0015FEDF
		static ConfigRegressBonusRewardByGrade()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressBonusRewardByGrade.CreateStaticDefaultValue), new Action(ConfigRegressBonusRewardByGrade.ResetStaticDefaultValue));
		}

		// Token: 0x06002ECF RID: 11983 RVA: 0x00161D00 File Offset: 0x0015FF00
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressBonusRewardByGrade.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressBonusRewardByGrade.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressBonusReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressBonusReward` where Grade=?")
			});
		}

		// Token: 0x06002ED0 RID: 11984 RVA: 0x00161D7F File Offset: 0x0015FF7F
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressBonusRewardByGrade.LogPair = null;
			ConfigRegressBonusRewardByGrade.HandleId = 0;
		}

		// Token: 0x06002ED1 RID: 11985 RVA: 0x00161D8D File Offset: 0x0015FF8D
		public static void Init()
		{
			ConfigRegressBonusRewardByGrade.HandleId = ConfigCommon.InitDataStatement(ConfigRegressBonusRewardByGrade.HandleId, "db_regressactivity.db", "select BinData from `RegressBonusReward` where Grade=?");
		}

		// Token: 0x06002ED2 RID: 11986 RVA: 0x00161DA8 File Offset: 0x0015FFA8
		[NullableContext(2)]
		public static IReadOnlyList<RegressBonusReward> GetConfigList(int p0Grade, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressBonusRewardByGrade.HandleId, ConfigRegressBonusRewardByGrade.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressBonusRewardByGrade");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Grade);
				IReadOnlyList<RegressBonusReward> readOnlyList = (IReadOnlyList<RegressBonusReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRegressBonusRewardByGrade.LogPair.Clear();
			ConfigRegressBonusRewardByGrade.LogPair.Add(new ValueTuple<string, object>("Grade", p0Grade));
			if (!ConfigCommon.BindInt(ConfigRegressBonusRewardByGrade.HandleId, 1, p0Grade, ConfigRegressBonusRewardByGrade.LogPair))
			{
				ConfigCommon.Reset(ConfigRegressBonusRewardByGrade.HandleId, ConfigRegressBonusRewardByGrade.LogPair);
				return null;
			}
			List<RegressBonusReward> list = new List<RegressBonusReward>();
			while (ConfigCommon.Step(ConfigRegressBonusRewardByGrade.HandleId, false, ConfigRegressBonusRewardByGrade.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressBonusRewardByGrade.HandleId, 0, ConfigRegressBonusRewardByGrade.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRegressBonusRewardByGrade.HandleId, ConfigRegressBonusRewardByGrade.LogPair);
					return null;
				}
				RegressBonusReward rootAsRegressBonusReward = RegressBonusReward.GetRootAsRegressBonusReward(new ByteBuffer(item2));
				list.Add(rootAsRegressBonusReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressBonusRewardByGrade");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Grade);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRegressBonusRewardByGrade.HandleId, ConfigRegressBonusRewardByGrade.LogPair);
			return list;
		}

		// Token: 0x0400366C RID: 13932
		private const string DB = "db_regressactivity.db";

		// Token: 0x0400366D RID: 13933
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x0400366E RID: 13934
		private const string TABLE = "RegressBonusReward";

		// Token: 0x0400366F RID: 13935
		private const string COMMAND = "select BinData from `RegressBonusReward` where Grade=?";

		// Token: 0x04003670 RID: 13936
		private const string KEY_PREFIX = "RegressBonusRewardByGrade";

		// Token: 0x04003671 RID: 13937
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003672 RID: 13938
		private static int HandleId;
	}
}

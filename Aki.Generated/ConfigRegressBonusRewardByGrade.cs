using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007E6 RID: 2022
	public class ConfigRegressBonusRewardByGrade : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F76 RID: 12150 RVA: 0x00168FC7 File Offset: 0x001671C7
		static ConfigRegressBonusRewardByGrade()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressBonusRewardByGrade.CreateStaticDefaultValue), new Action(ConfigRegressBonusRewardByGrade.ResetStaticDefaultValue));
		}

		// Token: 0x06002F77 RID: 12151 RVA: 0x00168FE8 File Offset: 0x001671E8
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

		// Token: 0x06002F78 RID: 12152 RVA: 0x00169067 File Offset: 0x00167267
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressBonusRewardByGrade.LogPair = null;
			ConfigRegressBonusRewardByGrade.HandleId = 0;
		}

		// Token: 0x06002F79 RID: 12153 RVA: 0x00169075 File Offset: 0x00167275
		public static void Init()
		{
			ConfigRegressBonusRewardByGrade.HandleId = ConfigCommon.InitDataStatement(ConfigRegressBonusRewardByGrade.HandleId, "db_regressactivity.db", "select BinData from `RegressBonusReward` where Grade=?");
		}

		// Token: 0x06002F7A RID: 12154 RVA: 0x00169090 File Offset: 0x00167290
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

		// Token: 0x04003730 RID: 14128
		private const string DB = "db_regressactivity.db";

		// Token: 0x04003731 RID: 14129
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x04003732 RID: 14130
		private const string TABLE = "RegressBonusReward";

		// Token: 0x04003733 RID: 14131
		private const string COMMAND = "select BinData from `RegressBonusReward` where Grade=?";

		// Token: 0x04003734 RID: 14132
		private const string KEY_PREFIX = "RegressBonusRewardByGrade";

		// Token: 0x04003735 RID: 14133
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003736 RID: 14134
		private static int HandleId;
	}
}

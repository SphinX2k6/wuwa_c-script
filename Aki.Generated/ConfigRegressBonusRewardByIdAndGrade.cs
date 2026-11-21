using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007E7 RID: 2023
	public class ConfigRegressBonusRewardByIdAndGrade : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F7C RID: 12156 RVA: 0x001691FF File Offset: 0x001673FF
		static ConfigRegressBonusRewardByIdAndGrade()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressBonusRewardByIdAndGrade.CreateStaticDefaultValue), new Action(ConfigRegressBonusRewardByIdAndGrade.ResetStaticDefaultValue));
		}

		// Token: 0x06002F7D RID: 12157 RVA: 0x00169220 File Offset: 0x00167420
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressBonusRewardByIdAndGrade.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressBonusRewardByIdAndGrade.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressBonusReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressBonusReward` where Id=? And Grade=?")
			});
		}

		// Token: 0x06002F7E RID: 12158 RVA: 0x0016929F File Offset: 0x0016749F
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressBonusRewardByIdAndGrade.LogPair = null;
			ConfigRegressBonusRewardByIdAndGrade.HandleId = 0;
		}

		// Token: 0x06002F7F RID: 12159 RVA: 0x001692AD File Offset: 0x001674AD
		public static void Init()
		{
			ConfigRegressBonusRewardByIdAndGrade.HandleId = ConfigCommon.InitDataStatement(ConfigRegressBonusRewardByIdAndGrade.HandleId, "db_regressactivity.db", "select BinData from `RegressBonusReward` where Id=? And Grade=?");
		}

		// Token: 0x06002F80 RID: 12160 RVA: 0x001692C8 File Offset: 0x001674C8
		public static RegressBonusReward? GetConfig(int p0Id, int p1Grade, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressBonusRewardByIdAndGrade.HandleId, ConfigRegressBonusRewardByIdAndGrade.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("RegressBonusRewardByIdAndGrade");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Grade);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RegressBonusReward?(RegressBonusReward.GetRootAsRegressBonusReward(configBuffer));
				}
			}
			ConfigRegressBonusRewardByIdAndGrade.LogPair.Clear();
			ConfigRegressBonusRewardByIdAndGrade.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			ConfigRegressBonusRewardByIdAndGrade.LogPair.Add(new ValueTuple<string, object>("Grade", p1Grade));
			if (!ConfigCommon.BindInt(ConfigRegressBonusRewardByIdAndGrade.HandleId, 1, p0Id, ConfigRegressBonusRewardByIdAndGrade.LogPair) || !ConfigCommon.BindInt(ConfigRegressBonusRewardByIdAndGrade.HandleId, 2, p1Grade, ConfigRegressBonusRewardByIdAndGrade.LogPair) || ConfigCommon.Step(ConfigRegressBonusRewardByIdAndGrade.HandleId, true, ConfigRegressBonusRewardByIdAndGrade.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRegressBonusRewardByIdAndGrade.HandleId, ConfigRegressBonusRewardByIdAndGrade.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressBonusRewardByIdAndGrade.HandleId, 0, ConfigRegressBonusRewardByIdAndGrade.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRegressBonusRewardByIdAndGrade.HandleId, ConfigRegressBonusRewardByIdAndGrade.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RegressBonusReward rootAsRegressBonusReward = RegressBonusReward.GetRootAsRegressBonusReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("RegressBonusRewardByIdAndGrade");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Grade);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRegressBonusRewardByIdAndGrade.HandleId, ConfigRegressBonusRewardByIdAndGrade.LogPair);
			return new RegressBonusReward?(rootAsRegressBonusReward);
		}

		// Token: 0x04003737 RID: 14135
		private const string DB = "db_regressactivity.db";

		// Token: 0x04003738 RID: 14136
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x04003739 RID: 14137
		private const string TABLE = "RegressBonusReward";

		// Token: 0x0400373A RID: 14138
		private const string COMMAND = "select BinData from `RegressBonusReward` where Id=? And Grade=?";

		// Token: 0x0400373B RID: 14139
		private const string KEY_PREFIX = "RegressBonusRewardByIdAndGrade";

		// Token: 0x0400373C RID: 14140
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400373D RID: 14141
		private static int HandleId;
	}
}

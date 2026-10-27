using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007CB RID: 1995
	public class ConfigRegressBonusRewardByIdAndGrade : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002ED4 RID: 11988 RVA: 0x00161F17 File Offset: 0x00160117
		static ConfigRegressBonusRewardByIdAndGrade()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressBonusRewardByIdAndGrade.CreateStaticDefaultValue), new Action(ConfigRegressBonusRewardByIdAndGrade.ResetStaticDefaultValue));
		}

		// Token: 0x06002ED5 RID: 11989 RVA: 0x00161F38 File Offset: 0x00160138
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

		// Token: 0x06002ED6 RID: 11990 RVA: 0x00161FB7 File Offset: 0x001601B7
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressBonusRewardByIdAndGrade.LogPair = null;
			ConfigRegressBonusRewardByIdAndGrade.HandleId = 0;
		}

		// Token: 0x06002ED7 RID: 11991 RVA: 0x00161FC5 File Offset: 0x001601C5
		public static void Init()
		{
			ConfigRegressBonusRewardByIdAndGrade.HandleId = ConfigCommon.InitDataStatement(ConfigRegressBonusRewardByIdAndGrade.HandleId, "db_regressactivity.db", "select BinData from `RegressBonusReward` where Id=? And Grade=?");
		}

		// Token: 0x06002ED8 RID: 11992 RVA: 0x00161FE0 File Offset: 0x001601E0
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

		// Token: 0x04003673 RID: 13939
		private const string DB = "db_regressactivity.db";

		// Token: 0x04003674 RID: 13940
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x04003675 RID: 13941
		private const string TABLE = "RegressBonusReward";

		// Token: 0x04003676 RID: 13942
		private const string COMMAND = "select BinData from `RegressBonusReward` where Id=? And Grade=?";

		// Token: 0x04003677 RID: 13943
		private const string KEY_PREFIX = "RegressBonusRewardByIdAndGrade";

		// Token: 0x04003678 RID: 13944
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003679 RID: 13945
		private static int HandleId;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007E8 RID: 2024
	public class ConfigRegressDisposableRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F82 RID: 12162 RVA: 0x0016949D File Offset: 0x0016769D
		static ConfigRegressDisposableRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressDisposableRewardById.CreateStaticDefaultValue), new Action(ConfigRegressDisposableRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06002F83 RID: 12163 RVA: 0x001694BC File Offset: 0x001676BC
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressDisposableRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressDisposableRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressDisposableReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressDisposableReward` where Id=?")
			});
		}

		// Token: 0x06002F84 RID: 12164 RVA: 0x0016953B File Offset: 0x0016773B
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressDisposableRewardById.LogPair = null;
			ConfigRegressDisposableRewardById.HandleId = 0;
		}

		// Token: 0x06002F85 RID: 12165 RVA: 0x00169549 File Offset: 0x00167749
		public static void Init()
		{
			ConfigRegressDisposableRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigRegressDisposableRewardById.HandleId, "db_regressactivity.db", "select BinData from `RegressDisposableReward` where Id=?");
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x00169564 File Offset: 0x00167764
		public static RegressDisposableReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressDisposableRewardById.HandleId, ConfigRegressDisposableRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressDisposableRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RegressDisposableReward?(RegressDisposableReward.GetRootAsRegressDisposableReward(configBuffer));
				}
			}
			ConfigRegressDisposableRewardById.LogPair.Clear();
			ConfigRegressDisposableRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRegressDisposableRewardById.HandleId, 1, p0Id, ConfigRegressDisposableRewardById.LogPair) || ConfigCommon.Step(ConfigRegressDisposableRewardById.HandleId, true, ConfigRegressDisposableRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRegressDisposableRewardById.HandleId, ConfigRegressDisposableRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressDisposableRewardById.HandleId, 0, ConfigRegressDisposableRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRegressDisposableRewardById.HandleId, ConfigRegressDisposableRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RegressDisposableReward rootAsRegressDisposableReward = RegressDisposableReward.GetRootAsRegressDisposableReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressDisposableRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRegressDisposableRewardById.HandleId, ConfigRegressDisposableRewardById.LogPair);
			return new RegressDisposableReward?(rootAsRegressDisposableReward);
		}

		// Token: 0x0400373E RID: 14142
		private const string DB = "db_regressactivity.db";

		// Token: 0x0400373F RID: 14143
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x04003740 RID: 14144
		private const string TABLE = "RegressDisposableReward";

		// Token: 0x04003741 RID: 14145
		private const string COMMAND = "select BinData from `RegressDisposableReward` where Id=?";

		// Token: 0x04003742 RID: 14146
		private const string KEY_PREFIX = "RegressDisposableRewardById";

		// Token: 0x04003743 RID: 14147
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003744 RID: 14148
		private static int HandleId;
	}
}

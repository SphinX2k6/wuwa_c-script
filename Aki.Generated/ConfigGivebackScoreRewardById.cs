using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003B3 RID: 947
	public class ConfigGivebackScoreRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001639 RID: 5689 RVA: 0x000DAC6F File Offset: 0x000D8E6F
		static ConfigGivebackScoreRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGivebackScoreRewardById.CreateStaticDefaultValue), new Action(ConfigGivebackScoreRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x000DAC90 File Offset: 0x000D8E90
		public static void CreateStaticDefaultValue()
		{
			ConfigGivebackScoreRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGivebackScoreRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_feedbackreward.db"),
				new ValueTuple<string, object>("文件", "l.老玩家回馈.xlsx"),
				new ValueTuple<string, object>("表名", "GivebackScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `GivebackScoreReward` where Id=?")
			});
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x000DAD0F File Offset: 0x000D8F0F
		public static void ResetStaticDefaultValue()
		{
			ConfigGivebackScoreRewardById.LogPair = null;
			ConfigGivebackScoreRewardById.HandleId = 0;
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x000DAD1D File Offset: 0x000D8F1D
		public static void Init()
		{
			ConfigGivebackScoreRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigGivebackScoreRewardById.HandleId, "db_feedbackreward.db", "select BinData from `GivebackScoreReward` where Id=?");
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x000DAD38 File Offset: 0x000D8F38
		public static GivebackScoreReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGivebackScoreRewardById.HandleId, ConfigGivebackScoreRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GivebackScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GivebackScoreReward?(GivebackScoreReward.GetRootAsGivebackScoreReward(configBuffer));
				}
			}
			ConfigGivebackScoreRewardById.LogPair.Clear();
			ConfigGivebackScoreRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGivebackScoreRewardById.HandleId, 1, p0Id, ConfigGivebackScoreRewardById.LogPair) || ConfigCommon.Step(ConfigGivebackScoreRewardById.HandleId, true, ConfigGivebackScoreRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGivebackScoreRewardById.HandleId, ConfigGivebackScoreRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGivebackScoreRewardById.HandleId, 0, ConfigGivebackScoreRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGivebackScoreRewardById.HandleId, ConfigGivebackScoreRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GivebackScoreReward rootAsGivebackScoreReward = GivebackScoreReward.GetRootAsGivebackScoreReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GivebackScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGivebackScoreRewardById.HandleId, ConfigGivebackScoreRewardById.LogPair);
			return new GivebackScoreReward?(rootAsGivebackScoreReward);
		}

		// Token: 0x040019C9 RID: 6601
		private const string DB = "db_feedbackreward.db";

		// Token: 0x040019CA RID: 6602
		private const string FILE = "l.老玩家回馈.xlsx";

		// Token: 0x040019CB RID: 6603
		private const string TABLE = "GivebackScoreReward";

		// Token: 0x040019CC RID: 6604
		private const string COMMAND = "select BinData from `GivebackScoreReward` where Id=?";

		// Token: 0x040019CD RID: 6605
		private const string KEY_PREFIX = "GivebackScoreRewardById";

		// Token: 0x040019CE RID: 6606
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040019CF RID: 6607
		private static int HandleId;
	}
}

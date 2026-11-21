using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000807 RID: 2055
	public class ConfigRewardViewFromSourceBySourceId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600303C RID: 12348 RVA: 0x0016D5E7 File Offset: 0x0016B7E7
		static ConfigRewardViewFromSourceBySourceId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRewardViewFromSourceBySourceId.CreateStaticDefaultValue), new Action(ConfigRewardViewFromSourceBySourceId.ResetStaticDefaultValue));
		}

		// Token: 0x0600303D RID: 12349 RVA: 0x0016D608 File Offset: 0x0016B808
		public static void CreateStaticDefaultValue()
		{
			ConfigRewardViewFromSourceBySourceId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRewardViewFromSourceBySourceId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rewardui.db"),
				new ValueTuple<string, object>("文件", "j.奖励界面表现.xlsx"),
				new ValueTuple<string, object>("表名", "RewardViewFromSource"),
				new ValueTuple<string, object>("语句", "select BinData from `RewardViewFromSource` where RewardSourceId=?")
			});
		}

		// Token: 0x0600303E RID: 12350 RVA: 0x0016D687 File Offset: 0x0016B887
		public static void ResetStaticDefaultValue()
		{
			ConfigRewardViewFromSourceBySourceId.LogPair = null;
			ConfigRewardViewFromSourceBySourceId.HandleId = 0;
		}

		// Token: 0x0600303F RID: 12351 RVA: 0x0016D695 File Offset: 0x0016B895
		public static void Init()
		{
			ConfigRewardViewFromSourceBySourceId.HandleId = ConfigCommon.InitDataStatement(ConfigRewardViewFromSourceBySourceId.HandleId, "db_rewardui.db", "select BinData from `RewardViewFromSource` where RewardSourceId=?");
		}

		// Token: 0x06003040 RID: 12352 RVA: 0x0016D6B0 File Offset: 0x0016B8B0
		public static RewardViewFromSource? GetConfig(int p0RewardSourceId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRewardViewFromSourceBySourceId.HandleId, ConfigRewardViewFromSourceBySourceId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RewardViewFromSourceBySourceId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RewardSourceId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RewardViewFromSource?(RewardViewFromSource.GetRootAsRewardViewFromSource(configBuffer));
				}
			}
			ConfigRewardViewFromSourceBySourceId.LogPair.Clear();
			ConfigRewardViewFromSourceBySourceId.LogPair.Add(new ValueTuple<string, object>("RewardSourceId", p0RewardSourceId));
			if (!ConfigCommon.BindInt(ConfigRewardViewFromSourceBySourceId.HandleId, 1, p0RewardSourceId, ConfigRewardViewFromSourceBySourceId.LogPair) || ConfigCommon.Step(ConfigRewardViewFromSourceBySourceId.HandleId, true, ConfigRewardViewFromSourceBySourceId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRewardViewFromSourceBySourceId.HandleId, ConfigRewardViewFromSourceBySourceId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRewardViewFromSourceBySourceId.HandleId, 0, ConfigRewardViewFromSourceBySourceId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRewardViewFromSourceBySourceId.HandleId, ConfigRewardViewFromSourceBySourceId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RewardViewFromSource rootAsRewardViewFromSource = RewardViewFromSource.GetRootAsRewardViewFromSource(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RewardViewFromSourceBySourceId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RewardSourceId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRewardViewFromSourceBySourceId.HandleId, ConfigRewardViewFromSourceBySourceId.LogPair);
			return new RewardViewFromSource?(rootAsRewardViewFromSource);
		}

		// Token: 0x04003817 RID: 14359
		private const string DB = "db_rewardui.db";

		// Token: 0x04003818 RID: 14360
		private const string FILE = "j.奖励界面表现.xlsx";

		// Token: 0x04003819 RID: 14361
		private const string TABLE = "RewardViewFromSource";

		// Token: 0x0400381A RID: 14362
		private const string COMMAND = "select BinData from `RewardViewFromSource` where RewardSourceId=?";

		// Token: 0x0400381B RID: 14363
		private const string KEY_PREFIX = "RewardViewFromSourceBySourceId";

		// Token: 0x0400381C RID: 14364
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400381D RID: 14365
		private static int HandleId;
	}
}

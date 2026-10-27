using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007EB RID: 2027
	public class ConfigRewardViewFromSourceBySourceId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F94 RID: 12180 RVA: 0x001662FF File Offset: 0x001644FF
		static ConfigRewardViewFromSourceBySourceId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRewardViewFromSourceBySourceId.CreateStaticDefaultValue), new Action(ConfigRewardViewFromSourceBySourceId.ResetStaticDefaultValue));
		}

		// Token: 0x06002F95 RID: 12181 RVA: 0x00166320 File Offset: 0x00164520
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

		// Token: 0x06002F96 RID: 12182 RVA: 0x0016639F File Offset: 0x0016459F
		public static void ResetStaticDefaultValue()
		{
			ConfigRewardViewFromSourceBySourceId.LogPair = null;
			ConfigRewardViewFromSourceBySourceId.HandleId = 0;
		}

		// Token: 0x06002F97 RID: 12183 RVA: 0x001663AD File Offset: 0x001645AD
		public static void Init()
		{
			ConfigRewardViewFromSourceBySourceId.HandleId = ConfigCommon.InitDataStatement(ConfigRewardViewFromSourceBySourceId.HandleId, "db_rewardui.db", "select BinData from `RewardViewFromSource` where RewardSourceId=?");
		}

		// Token: 0x06002F98 RID: 12184 RVA: 0x001663C8 File Offset: 0x001645C8
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

		// Token: 0x04003753 RID: 14163
		private const string DB = "db_rewardui.db";

		// Token: 0x04003754 RID: 14164
		private const string FILE = "j.奖励界面表现.xlsx";

		// Token: 0x04003755 RID: 14165
		private const string TABLE = "RewardViewFromSource";

		// Token: 0x04003756 RID: 14166
		private const string COMMAND = "select BinData from `RewardViewFromSource` where RewardSourceId=?";

		// Token: 0x04003757 RID: 14167
		private const string KEY_PREFIX = "RewardViewFromSourceBySourceId";

		// Token: 0x04003758 RID: 14168
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003759 RID: 14169
		private static int HandleId;
	}
}

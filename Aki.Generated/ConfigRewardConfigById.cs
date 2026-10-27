using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007E9 RID: 2025
	public class ConfigRewardConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F88 RID: 12168 RVA: 0x00165F24 File Offset: 0x00164124
		static ConfigRewardConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRewardConfigById.CreateStaticDefaultValue), new Action(ConfigRewardConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002F89 RID: 12169 RVA: 0x00165F44 File Offset: 0x00164144
		public static void CreateStaticDefaultValue()
		{
			ConfigRewardConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRewardConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_circumfluence.db"),
				new ValueTuple<string, object>("文件", "h.回流活动.xlsx"),
				new ValueTuple<string, object>("表名", "RewardConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `RewardConfig` where Id=?")
			});
		}

		// Token: 0x06002F8A RID: 12170 RVA: 0x00165FC3 File Offset: 0x001641C3
		public static void ResetStaticDefaultValue()
		{
			ConfigRewardConfigById.LogPair = null;
			ConfigRewardConfigById.HandleId = 0;
		}

		// Token: 0x06002F8B RID: 12171 RVA: 0x00165FD1 File Offset: 0x001641D1
		public static void Init()
		{
			ConfigRewardConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigRewardConfigById.HandleId, "db_circumfluence.db", "select BinData from `RewardConfig` where Id=?");
		}

		// Token: 0x06002F8C RID: 12172 RVA: 0x00165FEC File Offset: 0x001641EC
		public static RewardConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRewardConfigById.HandleId, ConfigRewardConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RewardConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RewardConfig?(RewardConfig.GetRootAsRewardConfig(configBuffer));
				}
			}
			ConfigRewardConfigById.LogPair.Clear();
			ConfigRewardConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRewardConfigById.HandleId, 1, p0Id, ConfigRewardConfigById.LogPair) || ConfigCommon.Step(ConfigRewardConfigById.HandleId, true, ConfigRewardConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRewardConfigById.HandleId, ConfigRewardConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRewardConfigById.HandleId, 0, ConfigRewardConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRewardConfigById.HandleId, ConfigRewardConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RewardConfig rootAsRewardConfig = RewardConfig.GetRootAsRewardConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RewardConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRewardConfigById.HandleId, ConfigRewardConfigById.LogPair);
			return new RewardConfig?(rootAsRewardConfig);
		}

		// Token: 0x04003745 RID: 14149
		private const string DB = "db_circumfluence.db";

		// Token: 0x04003746 RID: 14150
		private const string FILE = "h.回流活动.xlsx";

		// Token: 0x04003747 RID: 14151
		private const string TABLE = "RewardConfig";

		// Token: 0x04003748 RID: 14152
		private const string COMMAND = "select BinData from `RewardConfig` where Id=?";

		// Token: 0x04003749 RID: 14153
		private const string KEY_PREFIX = "RewardConfigById";

		// Token: 0x0400374A RID: 14154
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400374B RID: 14155
		private static int HandleId;
	}
}

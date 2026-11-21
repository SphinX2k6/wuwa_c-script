using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000805 RID: 2053
	public class ConfigRewardConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003030 RID: 12336 RVA: 0x0016D20C File Offset: 0x0016B40C
		static ConfigRewardConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRewardConfigById.CreateStaticDefaultValue), new Action(ConfigRewardConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06003031 RID: 12337 RVA: 0x0016D22C File Offset: 0x0016B42C
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

		// Token: 0x06003032 RID: 12338 RVA: 0x0016D2AB File Offset: 0x0016B4AB
		public static void ResetStaticDefaultValue()
		{
			ConfigRewardConfigById.LogPair = null;
			ConfigRewardConfigById.HandleId = 0;
		}

		// Token: 0x06003033 RID: 12339 RVA: 0x0016D2B9 File Offset: 0x0016B4B9
		public static void Init()
		{
			ConfigRewardConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigRewardConfigById.HandleId, "db_circumfluence.db", "select BinData from `RewardConfig` where Id=?");
		}

		// Token: 0x06003034 RID: 12340 RVA: 0x0016D2D4 File Offset: 0x0016B4D4
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

		// Token: 0x04003809 RID: 14345
		private const string DB = "db_circumfluence.db";

		// Token: 0x0400380A RID: 14346
		private const string FILE = "h.回流活动.xlsx";

		// Token: 0x0400380B RID: 14347
		private const string TABLE = "RewardConfig";

		// Token: 0x0400380C RID: 14348
		private const string COMMAND = "select BinData from `RewardConfig` where Id=?";

		// Token: 0x0400380D RID: 14349
		private const string KEY_PREFIX = "RewardConfigById";

		// Token: 0x0400380E RID: 14350
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400380F RID: 14351
		private static int HandleId;
	}
}

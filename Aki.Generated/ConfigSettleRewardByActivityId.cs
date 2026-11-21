using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000955 RID: 2389
	public class ConfigSettleRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003811 RID: 14353 RVA: 0x001996BF File Offset: 0x001978BF
		static ConfigSettleRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSettleRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigSettleRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003812 RID: 14354 RVA: 0x001996E0 File Offset: 0x001978E0
		public static void CreateStaticDefaultValue()
		{
			ConfigSettleRewardByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSettleRewardByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sprintsign.db"),
				new ValueTuple<string, object>("文件", "c.2.0春节签到.xlsx"),
				new ValueTuple<string, object>("表名", "SettleReward"),
				new ValueTuple<string, object>("语句", "select BinData from `SettleReward` where ActivityId=?")
			});
		}

		// Token: 0x06003813 RID: 14355 RVA: 0x0019975F File Offset: 0x0019795F
		public static void ResetStaticDefaultValue()
		{
			ConfigSettleRewardByActivityId.LogPair = null;
			ConfigSettleRewardByActivityId.HandleId = 0;
		}

		// Token: 0x06003814 RID: 14356 RVA: 0x0019976D File Offset: 0x0019796D
		public static void Init()
		{
			ConfigSettleRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSettleRewardByActivityId.HandleId, "db_sprintsign.db", "select BinData from `SettleReward` where ActivityId=?");
		}

		// Token: 0x06003815 RID: 14357 RVA: 0x00199788 File Offset: 0x00197988
		public static SettleReward? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSettleRewardByActivityId.HandleId, ConfigSettleRewardByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SettleRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SettleReward?(SettleReward.GetRootAsSettleReward(configBuffer));
				}
			}
			ConfigSettleRewardByActivityId.LogPair.Clear();
			ConfigSettleRewardByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSettleRewardByActivityId.HandleId, 1, p0ActivityId, ConfigSettleRewardByActivityId.LogPair) || ConfigCommon.Step(ConfigSettleRewardByActivityId.HandleId, true, ConfigSettleRewardByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSettleRewardByActivityId.HandleId, ConfigSettleRewardByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSettleRewardByActivityId.HandleId, 0, ConfigSettleRewardByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSettleRewardByActivityId.HandleId, ConfigSettleRewardByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SettleReward rootAsSettleReward = SettleReward.GetRootAsSettleReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SettleRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSettleRewardByActivityId.HandleId, ConfigSettleRewardByActivityId.LogPair);
			return new SettleReward?(rootAsSettleReward);
		}

		// Token: 0x04004139 RID: 16697
		private const string DB = "db_sprintsign.db";

		// Token: 0x0400413A RID: 16698
		private const string FILE = "c.2.0春节签到.xlsx";

		// Token: 0x0400413B RID: 16699
		private const string TABLE = "SettleReward";

		// Token: 0x0400413C RID: 16700
		private const string COMMAND = "select BinData from `SettleReward` where ActivityId=?";

		// Token: 0x0400413D RID: 16701
		private const string KEY_PREFIX = "SettleRewardByActivityId";

		// Token: 0x0400413E RID: 16702
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400413F RID: 16703
		private static int HandleId;
	}
}

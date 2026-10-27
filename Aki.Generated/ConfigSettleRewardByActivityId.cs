using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200090A RID: 2314
	public class ConfigSettleRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600364F RID: 13903 RVA: 0x0018C49F File Offset: 0x0018A69F
		static ConfigSettleRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSettleRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigSettleRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x0018C4C0 File Offset: 0x0018A6C0
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

		// Token: 0x06003651 RID: 13905 RVA: 0x0018C53F File Offset: 0x0018A73F
		public static void ResetStaticDefaultValue()
		{
			ConfigSettleRewardByActivityId.LogPair = null;
			ConfigSettleRewardByActivityId.HandleId = 0;
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x0018C54D File Offset: 0x0018A74D
		public static void Init()
		{
			ConfigSettleRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSettleRewardByActivityId.HandleId, "db_sprintsign.db", "select BinData from `SettleReward` where ActivityId=?");
		}

		// Token: 0x06003653 RID: 13907 RVA: 0x0018C568 File Offset: 0x0018A768
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

		// Token: 0x04003F2C RID: 16172
		private const string DB = "db_sprintsign.db";

		// Token: 0x04003F2D RID: 16173
		private const string FILE = "c.2.0春节签到.xlsx";

		// Token: 0x04003F2E RID: 16174
		private const string TABLE = "SettleReward";

		// Token: 0x04003F2F RID: 16175
		private const string COMMAND = "select BinData from `SettleReward` where ActivityId=?";

		// Token: 0x04003F30 RID: 16176
		private const string KEY_PREFIX = "SettleRewardByActivityId";

		// Token: 0x04003F31 RID: 16177
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F32 RID: 16178
		private static int HandleId;
	}
}

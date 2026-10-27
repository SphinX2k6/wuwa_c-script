using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200028A RID: 650
	public class ConfigExchangeRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F41 RID: 3905 RVA: 0x000AFBC8 File Offset: 0x000ADDC8
		static ConfigExchangeRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExchangeRewardById.CreateStaticDefaultValue), new Action(ConfigExchangeRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x000AFBE8 File Offset: 0x000ADDE8
		public static void CreateStaticDefaultValue()
		{
			ConfigExchangeRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExchangeRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_exchangereward.db"),
				new ValueTuple<string, object>("文件", "d.兑换奖励配置.xlsx"),
				new ValueTuple<string, object>("表名", "ExchangeReward"),
				new ValueTuple<string, object>("语句", "select BinData from `ExchangeReward` where Id=?")
			});
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x000AFC67 File Offset: 0x000ADE67
		public static void ResetStaticDefaultValue()
		{
			ConfigExchangeRewardById.LogPair = null;
			ConfigExchangeRewardById.HandleId = 0;
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x000AFC75 File Offset: 0x000ADE75
		public static void Init()
		{
			ConfigExchangeRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigExchangeRewardById.HandleId, "db_exchangereward.db", "select BinData from `ExchangeReward` where Id=?");
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x000AFC90 File Offset: 0x000ADE90
		public static ExchangeReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExchangeRewardById.HandleId, ConfigExchangeRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExchangeRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ExchangeReward?(ExchangeReward.GetRootAsExchangeReward(configBuffer));
				}
			}
			ConfigExchangeRewardById.LogPair.Clear();
			ConfigExchangeRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigExchangeRewardById.HandleId, 1, p0Id, ConfigExchangeRewardById.LogPair) || ConfigCommon.Step(ConfigExchangeRewardById.HandleId, true, ConfigExchangeRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigExchangeRewardById.HandleId, ConfigExchangeRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExchangeRewardById.HandleId, 0, ConfigExchangeRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigExchangeRewardById.HandleId, ConfigExchangeRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ExchangeReward rootAsExchangeReward = ExchangeReward.GetRootAsExchangeReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExchangeRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigExchangeRewardById.HandleId, ConfigExchangeRewardById.LogPair);
			return new ExchangeReward?(rootAsExchangeReward);
		}

		// Token: 0x040011AA RID: 4522
		private const string DB = "db_exchangereward.db";

		// Token: 0x040011AB RID: 4523
		private const string FILE = "d.兑换奖励配置.xlsx";

		// Token: 0x040011AC RID: 4524
		private const string TABLE = "ExchangeReward";

		// Token: 0x040011AD RID: 4525
		private const string COMMAND = "select BinData from `ExchangeReward` where Id=?";

		// Token: 0x040011AE RID: 4526
		private const string KEY_PREFIX = "ExchangeRewardById";

		// Token: 0x040011AF RID: 4527
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011B0 RID: 4528
		private static int HandleId;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200029E RID: 670
	public class ConfigExchangeRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FB9 RID: 4025 RVA: 0x000B5E8C File Offset: 0x000B408C
		static ConfigExchangeRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExchangeRewardById.CreateStaticDefaultValue), new Action(ConfigExchangeRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x000B5EAC File Offset: 0x000B40AC
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

		// Token: 0x06000FBB RID: 4027 RVA: 0x000B5F2B File Offset: 0x000B412B
		public static void ResetStaticDefaultValue()
		{
			ConfigExchangeRewardById.LogPair = null;
			ConfigExchangeRewardById.HandleId = 0;
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x000B5F39 File Offset: 0x000B4139
		public static void Init()
		{
			ConfigExchangeRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigExchangeRewardById.HandleId, "db_exchangereward.db", "select BinData from `ExchangeReward` where Id=?");
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x000B5F54 File Offset: 0x000B4154
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

		// Token: 0x04001236 RID: 4662
		private const string DB = "db_exchangereward.db";

		// Token: 0x04001237 RID: 4663
		private const string FILE = "d.兑换奖励配置.xlsx";

		// Token: 0x04001238 RID: 4664
		private const string TABLE = "ExchangeReward";

		// Token: 0x04001239 RID: 4665
		private const string COMMAND = "select BinData from `ExchangeReward` where Id=?";

		// Token: 0x0400123A RID: 4666
		private const string KEY_PREFIX = "ExchangeRewardById";

		// Token: 0x0400123B RID: 4667
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400123C RID: 4668
		private static int HandleId;
	}
}

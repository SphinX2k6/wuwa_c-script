using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200029F RID: 671
	public class ConfigExchangeSharedById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FBF RID: 4031 RVA: 0x000B60D4 File Offset: 0x000B42D4
		static ConfigExchangeSharedById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExchangeSharedById.CreateStaticDefaultValue), new Action(ConfigExchangeSharedById.ResetStaticDefaultValue));
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x000B60F4 File Offset: 0x000B42F4
		public static void CreateStaticDefaultValue()
		{
			ConfigExchangeSharedById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExchangeSharedById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_exchangereward.db"),
				new ValueTuple<string, object>("文件", "d.兑换奖励配置.xlsx"),
				new ValueTuple<string, object>("表名", "ExchangeShared"),
				new ValueTuple<string, object>("语句", "select BinData from `ExchangeShared` where Id=?")
			});
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x000B6173 File Offset: 0x000B4373
		public static void ResetStaticDefaultValue()
		{
			ConfigExchangeSharedById.LogPair = null;
			ConfigExchangeSharedById.HandleId = 0;
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x000B6181 File Offset: 0x000B4381
		public static void Init()
		{
			ConfigExchangeSharedById.HandleId = ConfigCommon.InitDataStatement(ConfigExchangeSharedById.HandleId, "db_exchangereward.db", "select BinData from `ExchangeShared` where Id=?");
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x000B619C File Offset: 0x000B439C
		public static ExchangeShared? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExchangeSharedById.HandleId, ConfigExchangeSharedById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExchangeSharedById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ExchangeShared?(ExchangeShared.GetRootAsExchangeShared(configBuffer));
				}
			}
			ConfigExchangeSharedById.LogPair.Clear();
			ConfigExchangeSharedById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigExchangeSharedById.HandleId, 1, p0Id, ConfigExchangeSharedById.LogPair) || ConfigCommon.Step(ConfigExchangeSharedById.HandleId, true, ConfigExchangeSharedById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigExchangeSharedById.HandleId, ConfigExchangeSharedById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExchangeSharedById.HandleId, 0, ConfigExchangeSharedById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigExchangeSharedById.HandleId, ConfigExchangeSharedById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ExchangeShared rootAsExchangeShared = ExchangeShared.GetRootAsExchangeShared(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExchangeSharedById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigExchangeSharedById.HandleId, ConfigExchangeSharedById.LogPair);
			return new ExchangeShared?(rootAsExchangeShared);
		}

		// Token: 0x0400123D RID: 4669
		private const string DB = "db_exchangereward.db";

		// Token: 0x0400123E RID: 4670
		private const string FILE = "d.兑换奖励配置.xlsx";

		// Token: 0x0400123F RID: 4671
		private const string TABLE = "ExchangeShared";

		// Token: 0x04001240 RID: 4672
		private const string COMMAND = "select BinData from `ExchangeShared` where Id=?";

		// Token: 0x04001241 RID: 4673
		private const string KEY_PREFIX = "ExchangeSharedById";

		// Token: 0x04001242 RID: 4674
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001243 RID: 4675
		private static int HandleId;
	}
}

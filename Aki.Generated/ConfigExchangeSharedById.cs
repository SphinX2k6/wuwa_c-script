using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200028B RID: 651
	public class ConfigExchangeSharedById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F47 RID: 3911 RVA: 0x000AFE10 File Offset: 0x000AE010
		static ConfigExchangeSharedById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExchangeSharedById.CreateStaticDefaultValue), new Action(ConfigExchangeSharedById.ResetStaticDefaultValue));
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x000AFE30 File Offset: 0x000AE030
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

		// Token: 0x06000F49 RID: 3913 RVA: 0x000AFEAF File Offset: 0x000AE0AF
		public static void ResetStaticDefaultValue()
		{
			ConfigExchangeSharedById.LogPair = null;
			ConfigExchangeSharedById.HandleId = 0;
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x000AFEBD File Offset: 0x000AE0BD
		public static void Init()
		{
			ConfigExchangeSharedById.HandleId = ConfigCommon.InitDataStatement(ConfigExchangeSharedById.HandleId, "db_exchangereward.db", "select BinData from `ExchangeShared` where Id=?");
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x000AFED8 File Offset: 0x000AE0D8
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

		// Token: 0x040011B1 RID: 4529
		private const string DB = "db_exchangereward.db";

		// Token: 0x040011B2 RID: 4530
		private const string FILE = "d.兑换奖励配置.xlsx";

		// Token: 0x040011B3 RID: 4531
		private const string TABLE = "ExchangeShared";

		// Token: 0x040011B4 RID: 4532
		private const string COMMAND = "select BinData from `ExchangeShared` where Id=?";

		// Token: 0x040011B5 RID: 4533
		private const string KEY_PREFIX = "ExchangeSharedById";

		// Token: 0x040011B6 RID: 4534
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011B7 RID: 4535
		private static int HandleId;
	}
}

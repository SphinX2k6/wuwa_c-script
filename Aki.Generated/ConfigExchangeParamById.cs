using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200029D RID: 669
	public class ConfigExchangeParamById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FB3 RID: 4019 RVA: 0x000B5C44 File Offset: 0x000B3E44
		static ConfigExchangeParamById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExchangeParamById.CreateStaticDefaultValue), new Action(ConfigExchangeParamById.ResetStaticDefaultValue));
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x000B5C64 File Offset: 0x000B3E64
		public static void CreateStaticDefaultValue()
		{
			ConfigExchangeParamById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExchangeParamById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_compose.db"),
				new ValueTuple<string, object>("文件", "h.合成.xlsx"),
				new ValueTuple<string, object>("表名", "ExchangeParam"),
				new ValueTuple<string, object>("语句", "select BinData from `ExchangeParam` where Id=?")
			});
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x000B5CE3 File Offset: 0x000B3EE3
		public static void ResetStaticDefaultValue()
		{
			ConfigExchangeParamById.LogPair = null;
			ConfigExchangeParamById.HandleId = 0;
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x000B5CF1 File Offset: 0x000B3EF1
		public static void Init()
		{
			ConfigExchangeParamById.HandleId = ConfigCommon.InitDataStatement(ConfigExchangeParamById.HandleId, "db_compose.db", "select BinData from `ExchangeParam` where Id=?");
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x000B5D0C File Offset: 0x000B3F0C
		public static ExchangeParam? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExchangeParamById.HandleId, ConfigExchangeParamById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExchangeParamById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ExchangeParam?(ExchangeParam.GetRootAsExchangeParam(configBuffer));
				}
			}
			ConfigExchangeParamById.LogPair.Clear();
			ConfigExchangeParamById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigExchangeParamById.HandleId, 1, p0Id, ConfigExchangeParamById.LogPair) || ConfigCommon.Step(ConfigExchangeParamById.HandleId, true, ConfigExchangeParamById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigExchangeParamById.HandleId, ConfigExchangeParamById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExchangeParamById.HandleId, 0, ConfigExchangeParamById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigExchangeParamById.HandleId, ConfigExchangeParamById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ExchangeParam rootAsExchangeParam = ExchangeParam.GetRootAsExchangeParam(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExchangeParamById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigExchangeParamById.HandleId, ConfigExchangeParamById.LogPair);
			return new ExchangeParam?(rootAsExchangeParam);
		}

		// Token: 0x0400122F RID: 4655
		private const string DB = "db_compose.db";

		// Token: 0x04001230 RID: 4656
		private const string FILE = "h.合成.xlsx";

		// Token: 0x04001231 RID: 4657
		private const string TABLE = "ExchangeParam";

		// Token: 0x04001232 RID: 4658
		private const string COMMAND = "select BinData from `ExchangeParam` where Id=?";

		// Token: 0x04001233 RID: 4659
		private const string KEY_PREFIX = "ExchangeParamById";

		// Token: 0x04001234 RID: 4660
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001235 RID: 4661
		private static int HandleId;
	}
}

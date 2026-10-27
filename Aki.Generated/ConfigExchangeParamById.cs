using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000289 RID: 649
	public class ConfigExchangeParamById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F3B RID: 3899 RVA: 0x000AF980 File Offset: 0x000ADB80
		static ConfigExchangeParamById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExchangeParamById.CreateStaticDefaultValue), new Action(ConfigExchangeParamById.ResetStaticDefaultValue));
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x000AF9A0 File Offset: 0x000ADBA0
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

		// Token: 0x06000F3D RID: 3901 RVA: 0x000AFA1F File Offset: 0x000ADC1F
		public static void ResetStaticDefaultValue()
		{
			ConfigExchangeParamById.LogPair = null;
			ConfigExchangeParamById.HandleId = 0;
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x000AFA2D File Offset: 0x000ADC2D
		public static void Init()
		{
			ConfigExchangeParamById.HandleId = ConfigCommon.InitDataStatement(ConfigExchangeParamById.HandleId, "db_compose.db", "select BinData from `ExchangeParam` where Id=?");
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x000AFA48 File Offset: 0x000ADC48
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

		// Token: 0x040011A3 RID: 4515
		private const string DB = "db_compose.db";

		// Token: 0x040011A4 RID: 4516
		private const string FILE = "h.合成.xlsx";

		// Token: 0x040011A5 RID: 4517
		private const string TABLE = "ExchangeParam";

		// Token: 0x040011A6 RID: 4518
		private const string COMMAND = "select BinData from `ExchangeParam` where Id=?";

		// Token: 0x040011A7 RID: 4519
		private const string KEY_PREFIX = "ExchangeParamById";

		// Token: 0x040011A8 RID: 4520
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011A9 RID: 4521
		private static int HandleId;
	}
}

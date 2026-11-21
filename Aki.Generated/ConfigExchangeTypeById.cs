using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002A1 RID: 673
	public class ConfigExchangeTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FCB RID: 4043 RVA: 0x000B64AF File Offset: 0x000B46AF
		static ConfigExchangeTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExchangeTypeById.CreateStaticDefaultValue), new Action(ConfigExchangeTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x000B64D0 File Offset: 0x000B46D0
		public static void CreateStaticDefaultValue()
		{
			ConfigExchangeTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExchangeTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_compose.db"),
				new ValueTuple<string, object>("文件", "h.合成.xlsx"),
				new ValueTuple<string, object>("表名", "ExchangeType"),
				new ValueTuple<string, object>("语句", "select BinData from `ExchangeType` where Id=?")
			});
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x000B654F File Offset: 0x000B474F
		public static void ResetStaticDefaultValue()
		{
			ConfigExchangeTypeById.LogPair = null;
			ConfigExchangeTypeById.HandleId = 0;
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x000B655D File Offset: 0x000B475D
		public static void Init()
		{
			ConfigExchangeTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigExchangeTypeById.HandleId, "db_compose.db", "select BinData from `ExchangeType` where Id=?");
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x000B6578 File Offset: 0x000B4778
		public static ExchangeType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExchangeTypeById.HandleId, ConfigExchangeTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExchangeTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ExchangeType?(ExchangeType.GetRootAsExchangeType(configBuffer));
				}
			}
			ConfigExchangeTypeById.LogPair.Clear();
			ConfigExchangeTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigExchangeTypeById.HandleId, 1, p0Id, ConfigExchangeTypeById.LogPair) || ConfigCommon.Step(ConfigExchangeTypeById.HandleId, true, ConfigExchangeTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigExchangeTypeById.HandleId, ConfigExchangeTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExchangeTypeById.HandleId, 0, ConfigExchangeTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigExchangeTypeById.HandleId, ConfigExchangeTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ExchangeType rootAsExchangeType = ExchangeType.GetRootAsExchangeType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExchangeTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigExchangeTypeById.HandleId, ConfigExchangeTypeById.LogPair);
			return new ExchangeType?(rootAsExchangeType);
		}

		// Token: 0x0400124B RID: 4683
		private const string DB = "db_compose.db";

		// Token: 0x0400124C RID: 4684
		private const string FILE = "h.合成.xlsx";

		// Token: 0x0400124D RID: 4685
		private const string TABLE = "ExchangeType";

		// Token: 0x0400124E RID: 4686
		private const string COMMAND = "select BinData from `ExchangeType` where Id=?";

		// Token: 0x0400124F RID: 4687
		private const string KEY_PREFIX = "ExchangeTypeById";

		// Token: 0x04001250 RID: 4688
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001251 RID: 4689
		private static int HandleId;
	}
}

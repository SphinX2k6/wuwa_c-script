using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200028D RID: 653
	public class ConfigExchangeTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F53 RID: 3923 RVA: 0x000B01EB File Offset: 0x000AE3EB
		static ConfigExchangeTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExchangeTypeById.CreateStaticDefaultValue), new Action(ConfigExchangeTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x000B020C File Offset: 0x000AE40C
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

		// Token: 0x06000F55 RID: 3925 RVA: 0x000B028B File Offset: 0x000AE48B
		public static void ResetStaticDefaultValue()
		{
			ConfigExchangeTypeById.LogPair = null;
			ConfigExchangeTypeById.HandleId = 0;
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x000B0299 File Offset: 0x000AE499
		public static void Init()
		{
			ConfigExchangeTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigExchangeTypeById.HandleId, "db_compose.db", "select BinData from `ExchangeType` where Id=?");
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x000B02B4 File Offset: 0x000AE4B4
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

		// Token: 0x040011BF RID: 4543
		private const string DB = "db_compose.db";

		// Token: 0x040011C0 RID: 4544
		private const string FILE = "h.合成.xlsx";

		// Token: 0x040011C1 RID: 4545
		private const string TABLE = "ExchangeType";

		// Token: 0x040011C2 RID: 4546
		private const string COMMAND = "select BinData from `ExchangeType` where Id=?";

		// Token: 0x040011C3 RID: 4547
		private const string KEY_PREFIX = "ExchangeTypeById";

		// Token: 0x040011C4 RID: 4548
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011C5 RID: 4549
		private static int HandleId;
	}
}

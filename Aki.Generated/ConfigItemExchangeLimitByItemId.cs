using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200046C RID: 1132
	public class ConfigItemExchangeLimitByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A92 RID: 6802 RVA: 0x000F338C File Offset: 0x000F158C
		static ConfigItemExchangeLimitByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemExchangeLimitByItemId.CreateStaticDefaultValue), new Action(ConfigItemExchangeLimitByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x000F33AC File Offset: 0x000F15AC
		public static void CreateStaticDefaultValue()
		{
			ConfigItemExchangeLimitByItemId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigItemExchangeLimitByItemId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_item_exchange.db"),
				new ValueTuple<string, object>("文件", "d.道具兑换.xlsx"),
				new ValueTuple<string, object>("表名", "ItemExchangeLimit"),
				new ValueTuple<string, object>("语句", "select BinData from `ItemExchangeLimit` where ItemId=?")
			});
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x000F342B File Offset: 0x000F162B
		public static void ResetStaticDefaultValue()
		{
			ConfigItemExchangeLimitByItemId.LogPair = null;
			ConfigItemExchangeLimitByItemId.HandleId = 0;
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x000F3439 File Offset: 0x000F1639
		public static void Init()
		{
			ConfigItemExchangeLimitByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigItemExchangeLimitByItemId.HandleId, "db_item_exchange.db", "select BinData from `ItemExchangeLimit` where ItemId=?");
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x000F3454 File Offset: 0x000F1654
		public static ItemExchangeLimit? GetConfig(int p0ItemId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigItemExchangeLimitByItemId.HandleId, ConfigItemExchangeLimitByItemId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ItemExchangeLimitByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ItemExchangeLimit?(ItemExchangeLimit.GetRootAsItemExchangeLimit(configBuffer));
				}
			}
			ConfigItemExchangeLimitByItemId.LogPair.Clear();
			ConfigItemExchangeLimitByItemId.LogPair.Add(new ValueTuple<string, object>("ItemId", p0ItemId));
			if (!ConfigCommon.BindInt(ConfigItemExchangeLimitByItemId.HandleId, 1, p0ItemId, ConfigItemExchangeLimitByItemId.LogPair) || ConfigCommon.Step(ConfigItemExchangeLimitByItemId.HandleId, true, ConfigItemExchangeLimitByItemId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigItemExchangeLimitByItemId.HandleId, ConfigItemExchangeLimitByItemId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigItemExchangeLimitByItemId.HandleId, 0, ConfigItemExchangeLimitByItemId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigItemExchangeLimitByItemId.HandleId, ConfigItemExchangeLimitByItemId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ItemExchangeLimit rootAsItemExchangeLimit = ItemExchangeLimit.GetRootAsItemExchangeLimit(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ItemExchangeLimitByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigItemExchangeLimitByItemId.HandleId, ConfigItemExchangeLimitByItemId.LogPair);
			return new ItemExchangeLimit?(rootAsItemExchangeLimit);
		}

		// Token: 0x04001ED8 RID: 7896
		private const string DB = "db_item_exchange.db";

		// Token: 0x04001ED9 RID: 7897
		private const string FILE = "d.道具兑换.xlsx";

		// Token: 0x04001EDA RID: 7898
		private const string TABLE = "ItemExchangeLimit";

		// Token: 0x04001EDB RID: 7899
		private const string COMMAND = "select BinData from `ItemExchangeLimit` where ItemId=?";

		// Token: 0x04001EDC RID: 7900
		private const string KEY_PREFIX = "ItemExchangeLimitByItemId";

		// Token: 0x04001EDD RID: 7901
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001EDE RID: 7902
		private static int HandleId;
	}
}

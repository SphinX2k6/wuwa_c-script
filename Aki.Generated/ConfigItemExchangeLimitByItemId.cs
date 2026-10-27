using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000456 RID: 1110
	public class ConfigItemExchangeLimitByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A0E RID: 6670 RVA: 0x000ECC38 File Offset: 0x000EAE38
		static ConfigItemExchangeLimitByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemExchangeLimitByItemId.CreateStaticDefaultValue), new Action(ConfigItemExchangeLimitByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x000ECC58 File Offset: 0x000EAE58
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

		// Token: 0x06001A10 RID: 6672 RVA: 0x000ECCD7 File Offset: 0x000EAED7
		public static void ResetStaticDefaultValue()
		{
			ConfigItemExchangeLimitByItemId.LogPair = null;
			ConfigItemExchangeLimitByItemId.HandleId = 0;
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x000ECCE5 File Offset: 0x000EAEE5
		public static void Init()
		{
			ConfigItemExchangeLimitByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigItemExchangeLimitByItemId.HandleId, "db_item_exchange.db", "select BinData from `ItemExchangeLimit` where ItemId=?");
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x000ECD00 File Offset: 0x000EAF00
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

		// Token: 0x04001E3E RID: 7742
		private const string DB = "db_item_exchange.db";

		// Token: 0x04001E3F RID: 7743
		private const string FILE = "d.道具兑换.xlsx";

		// Token: 0x04001E40 RID: 7744
		private const string TABLE = "ItemExchangeLimit";

		// Token: 0x04001E41 RID: 7745
		private const string COMMAND = "select BinData from `ItemExchangeLimit` where ItemId=?";

		// Token: 0x04001E42 RID: 7746
		private const string KEY_PREFIX = "ItemExchangeLimitByItemId";

		// Token: 0x04001E43 RID: 7747
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E44 RID: 7748
		private static int HandleId;
	}
}

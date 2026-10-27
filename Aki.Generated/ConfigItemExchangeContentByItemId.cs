using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000455 RID: 1109
	public class ConfigItemExchangeContentByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A08 RID: 6664 RVA: 0x000EC9EF File Offset: 0x000EABEF
		static ConfigItemExchangeContentByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemExchangeContentByItemId.CreateStaticDefaultValue), new Action(ConfigItemExchangeContentByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x000ECA10 File Offset: 0x000EAC10
		public static void CreateStaticDefaultValue()
		{
			ConfigItemExchangeContentByItemId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigItemExchangeContentByItemId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_item_exchange.db"),
				new ValueTuple<string, object>("文件", "d.道具兑换.xlsx"),
				new ValueTuple<string, object>("表名", "ItemExchangeContent"),
				new ValueTuple<string, object>("语句", "select BinData from `ItemExchangeContent` where ItemId=?")
			});
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x000ECA8F File Offset: 0x000EAC8F
		public static void ResetStaticDefaultValue()
		{
			ConfigItemExchangeContentByItemId.LogPair = null;
			ConfigItemExchangeContentByItemId.HandleId = 0;
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x000ECA9D File Offset: 0x000EAC9D
		public static void Init()
		{
			ConfigItemExchangeContentByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigItemExchangeContentByItemId.HandleId, "db_item_exchange.db", "select BinData from `ItemExchangeContent` where ItemId=?");
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x000ECAB8 File Offset: 0x000EACB8
		public static ItemExchangeContent? GetConfig(int p0ItemId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigItemExchangeContentByItemId.HandleId, ConfigItemExchangeContentByItemId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ItemExchangeContentByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ItemExchangeContent?(ItemExchangeContent.GetRootAsItemExchangeContent(configBuffer));
				}
			}
			ConfigItemExchangeContentByItemId.LogPair.Clear();
			ConfigItemExchangeContentByItemId.LogPair.Add(new ValueTuple<string, object>("ItemId", p0ItemId));
			if (!ConfigCommon.BindInt(ConfigItemExchangeContentByItemId.HandleId, 1, p0ItemId, ConfigItemExchangeContentByItemId.LogPair) || ConfigCommon.Step(ConfigItemExchangeContentByItemId.HandleId, true, ConfigItemExchangeContentByItemId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigItemExchangeContentByItemId.HandleId, ConfigItemExchangeContentByItemId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigItemExchangeContentByItemId.HandleId, 0, ConfigItemExchangeContentByItemId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigItemExchangeContentByItemId.HandleId, ConfigItemExchangeContentByItemId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ItemExchangeContent rootAsItemExchangeContent = ItemExchangeContent.GetRootAsItemExchangeContent(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ItemExchangeContentByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigItemExchangeContentByItemId.HandleId, ConfigItemExchangeContentByItemId.LogPair);
			return new ItemExchangeContent?(rootAsItemExchangeContent);
		}

		// Token: 0x04001E37 RID: 7735
		private const string DB = "db_item_exchange.db";

		// Token: 0x04001E38 RID: 7736
		private const string FILE = "d.道具兑换.xlsx";

		// Token: 0x04001E39 RID: 7737
		private const string TABLE = "ItemExchangeContent";

		// Token: 0x04001E3A RID: 7738
		private const string COMMAND = "select BinData from `ItemExchangeContent` where ItemId=?";

		// Token: 0x04001E3B RID: 7739
		private const string KEY_PREFIX = "ItemExchangeContentByItemId";

		// Token: 0x04001E3C RID: 7740
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E3D RID: 7741
		private static int HandleId;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200046B RID: 1131
	public class ConfigItemExchangeContentByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A8C RID: 6796 RVA: 0x000F3143 File Offset: 0x000F1343
		static ConfigItemExchangeContentByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemExchangeContentByItemId.CreateStaticDefaultValue), new Action(ConfigItemExchangeContentByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x000F3164 File Offset: 0x000F1364
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

		// Token: 0x06001A8E RID: 6798 RVA: 0x000F31E3 File Offset: 0x000F13E3
		public static void ResetStaticDefaultValue()
		{
			ConfigItemExchangeContentByItemId.LogPair = null;
			ConfigItemExchangeContentByItemId.HandleId = 0;
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x000F31F1 File Offset: 0x000F13F1
		public static void Init()
		{
			ConfigItemExchangeContentByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigItemExchangeContentByItemId.HandleId, "db_item_exchange.db", "select BinData from `ItemExchangeContent` where ItemId=?");
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x000F320C File Offset: 0x000F140C
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

		// Token: 0x04001ED1 RID: 7889
		private const string DB = "db_item_exchange.db";

		// Token: 0x04001ED2 RID: 7890
		private const string FILE = "d.道具兑换.xlsx";

		// Token: 0x04001ED3 RID: 7891
		private const string TABLE = "ItemExchangeContent";

		// Token: 0x04001ED4 RID: 7892
		private const string COMMAND = "select BinData from `ItemExchangeContent` where ItemId=?";

		// Token: 0x04001ED5 RID: 7893
		private const string KEY_PREFIX = "ItemExchangeContentByItemId";

		// Token: 0x04001ED6 RID: 7894
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001ED7 RID: 7895
		private static int HandleId;
	}
}

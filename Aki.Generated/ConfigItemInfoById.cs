using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200045E RID: 1118
	public class ConfigItemInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A3E RID: 6718 RVA: 0x000EDBFB File Offset: 0x000EBDFB
		static ConfigItemInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemInfoById.CreateStaticDefaultValue), new Action(ConfigItemInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x000EDC1C File Offset: 0x000EBE1C
		public static void CreateStaticDefaultValue()
		{
			ConfigItemInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigItemInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_item.db"),
				new ValueTuple<string, object>("文件", "d.道具.xlsx"),
				new ValueTuple<string, object>("表名", "ItemInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `ItemInfo` where Id=?")
			});
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x000EDC9B File Offset: 0x000EBE9B
		public static void ResetStaticDefaultValue()
		{
			ConfigItemInfoById.LogPair = null;
			ConfigItemInfoById.HandleId = 0;
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x000EDCA9 File Offset: 0x000EBEA9
		public static void Init()
		{
			ConfigItemInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigItemInfoById.HandleId, "db_item.db", "select BinData from `ItemInfo` where Id=?");
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x000EDCC4 File Offset: 0x000EBEC4
		public static ItemInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigItemInfoById.HandleId, ConfigItemInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ItemInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ItemInfo?(ItemInfo.GetRootAsItemInfo(configBuffer));
				}
			}
			ConfigItemInfoById.LogPair.Clear();
			ConfigItemInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigItemInfoById.HandleId, 1, p0Id, ConfigItemInfoById.LogPair) || ConfigCommon.Step(ConfigItemInfoById.HandleId, true, ConfigItemInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigItemInfoById.HandleId, ConfigItemInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigItemInfoById.HandleId, 0, ConfigItemInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigItemInfoById.HandleId, ConfigItemInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ItemInfo rootAsItemInfo = ItemInfo.GetRootAsItemInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ItemInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigItemInfoById.HandleId, ConfigItemInfoById.LogPair);
			return new ItemInfo?(rootAsItemInfo);
		}

		// Token: 0x04001E76 RID: 7798
		private const string DB = "db_item.db";

		// Token: 0x04001E77 RID: 7799
		private const string FILE = "d.道具.xlsx";

		// Token: 0x04001E78 RID: 7800
		private const string TABLE = "ItemInfo";

		// Token: 0x04001E79 RID: 7801
		private const string COMMAND = "select BinData from `ItemInfo` where Id=?";

		// Token: 0x04001E7A RID: 7802
		private const string KEY_PREFIX = "ItemInfoById";

		// Token: 0x04001E7B RID: 7803
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E7C RID: 7804
		private static int HandleId;
	}
}

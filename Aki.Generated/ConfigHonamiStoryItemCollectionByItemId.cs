using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003E7 RID: 999
	public class ConfigHonamiStoryItemCollectionByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001771 RID: 6001 RVA: 0x000DE24B File Offset: 0x000DC44B
		static ConfigHonamiStoryItemCollectionByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryItemCollectionByItemId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryItemCollectionByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x000DE26C File Offset: 0x000DC46C
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryItemCollectionByItemId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryItemCollectionByItemId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局外.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryItemCollection"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryItemCollection` where ItemId=?")
			});
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x000DE2EB File Offset: 0x000DC4EB
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryItemCollectionByItemId.LogPair = null;
			ConfigHonamiStoryItemCollectionByItemId.HandleId = 0;
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x000DE2F9 File Offset: 0x000DC4F9
		public static void Init()
		{
			ConfigHonamiStoryItemCollectionByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryItemCollectionByItemId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryItemCollection` where ItemId=?");
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x000DE314 File Offset: 0x000DC514
		public static HonamiStoryItemCollection? GetConfig(int p0ItemId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryItemCollectionByItemId.HandleId, ConfigHonamiStoryItemCollectionByItemId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryItemCollectionByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryItemCollection?(HonamiStoryItemCollection.GetRootAsHonamiStoryItemCollection(configBuffer));
				}
			}
			ConfigHonamiStoryItemCollectionByItemId.LogPair.Clear();
			ConfigHonamiStoryItemCollectionByItemId.LogPair.Add(new ValueTuple<string, object>("ItemId", p0ItemId));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryItemCollectionByItemId.HandleId, 1, p0ItemId, ConfigHonamiStoryItemCollectionByItemId.LogPair) || ConfigCommon.Step(ConfigHonamiStoryItemCollectionByItemId.HandleId, true, ConfigHonamiStoryItemCollectionByItemId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryItemCollectionByItemId.HandleId, ConfigHonamiStoryItemCollectionByItemId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryItemCollectionByItemId.HandleId, 0, ConfigHonamiStoryItemCollectionByItemId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryItemCollectionByItemId.HandleId, ConfigHonamiStoryItemCollectionByItemId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryItemCollection rootAsHonamiStoryItemCollection = HonamiStoryItemCollection.GetRootAsHonamiStoryItemCollection(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryItemCollectionByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryItemCollectionByItemId.HandleId, ConfigHonamiStoryItemCollectionByItemId.LogPair);
			return new HonamiStoryItemCollection?(rootAsHonamiStoryItemCollection);
		}

		// Token: 0x04001B35 RID: 6965
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B36 RID: 6966
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001B37 RID: 6967
		private const string TABLE = "HonamiStoryItemCollection";

		// Token: 0x04001B38 RID: 6968
		private const string COMMAND = "select BinData from `HonamiStoryItemCollection` where ItemId=?";

		// Token: 0x04001B39 RID: 6969
		private const string KEY_PREFIX = "HonamiStoryItemCollectionByItemId";

		// Token: 0x04001B3A RID: 6970
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B3B RID: 6971
		private static int HandleId;
	}
}

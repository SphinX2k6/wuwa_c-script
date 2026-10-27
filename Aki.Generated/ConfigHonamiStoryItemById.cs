using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003E5 RID: 997
	public class ConfigHonamiStoryItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001765 RID: 5989 RVA: 0x000DDDCC File Offset: 0x000DBFCC
		static ConfigHonamiStoryItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryItemById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x000DDDEC File Offset: 0x000DBFEC
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语道具.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryItem"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryItem` where Id=?")
			});
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x000DDE6B File Offset: 0x000DC06B
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryItemById.LogPair = null;
			ConfigHonamiStoryItemById.HandleId = 0;
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x000DDE79 File Offset: 0x000DC079
		public static void Init()
		{
			ConfigHonamiStoryItemById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryItemById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryItem` where Id=?");
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x000DDE94 File Offset: 0x000DC094
		public static HonamiStoryItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryItemById.HandleId, ConfigHonamiStoryItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryItem?(HonamiStoryItem.GetRootAsHonamiStoryItem(configBuffer));
				}
			}
			ConfigHonamiStoryItemById.LogPair.Clear();
			ConfigHonamiStoryItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryItemById.HandleId, 1, p0Id, ConfigHonamiStoryItemById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryItemById.HandleId, true, ConfigHonamiStoryItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryItemById.HandleId, ConfigHonamiStoryItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryItemById.HandleId, 0, ConfigHonamiStoryItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryItemById.HandleId, ConfigHonamiStoryItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryItem rootAsHonamiStoryItem = HonamiStoryItem.GetRootAsHonamiStoryItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryItemById.HandleId, ConfigHonamiStoryItemById.LogPair);
			return new HonamiStoryItem?(rootAsHonamiStoryItem);
		}

		// Token: 0x04001B27 RID: 6951
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B28 RID: 6952
		private const string FILE = "s.穗波奇妙物语道具.xlsx";

		// Token: 0x04001B29 RID: 6953
		private const string TABLE = "HonamiStoryItem";

		// Token: 0x04001B2A RID: 6954
		private const string COMMAND = "select BinData from `HonamiStoryItem` where Id=?";

		// Token: 0x04001B2B RID: 6955
		private const string KEY_PREFIX = "HonamiStoryItemById";

		// Token: 0x04001B2C RID: 6956
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B2D RID: 6957
		private static int HandleId;
	}
}

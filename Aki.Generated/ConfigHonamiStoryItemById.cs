using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003FB RID: 1019
	public class ConfigHonamiStoryItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017E9 RID: 6121 RVA: 0x000E4520 File Offset: 0x000E2720
		static ConfigHonamiStoryItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryItemById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryItemById.ResetStaticDefaultValue));
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x000E4540 File Offset: 0x000E2740
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

		// Token: 0x060017EB RID: 6123 RVA: 0x000E45BF File Offset: 0x000E27BF
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryItemById.LogPair = null;
			ConfigHonamiStoryItemById.HandleId = 0;
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x000E45CD File Offset: 0x000E27CD
		public static void Init()
		{
			ConfigHonamiStoryItemById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryItemById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryItem` where Id=?");
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x000E45E8 File Offset: 0x000E27E8
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

		// Token: 0x04001BC1 RID: 7105
		private const string DB = "db_honamistory.db";

		// Token: 0x04001BC2 RID: 7106
		private const string FILE = "s.穗波奇妙物语道具.xlsx";

		// Token: 0x04001BC3 RID: 7107
		private const string TABLE = "HonamiStoryItem";

		// Token: 0x04001BC4 RID: 7108
		private const string COMMAND = "select BinData from `HonamiStoryItem` where Id=?";

		// Token: 0x04001BC5 RID: 7109
		private const string KEY_PREFIX = "HonamiStoryItemById";

		// Token: 0x04001BC6 RID: 7110
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001BC7 RID: 7111
		private static int HandleId;
	}
}

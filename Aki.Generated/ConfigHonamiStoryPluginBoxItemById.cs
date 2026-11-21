using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000412 RID: 1042
	public class ConfigHonamiStoryPluginBoxItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001873 RID: 6259 RVA: 0x000E77A3 File Offset: 0x000E59A3
		static ConfigHonamiStoryPluginBoxItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryPluginBoxItemById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryPluginBoxItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x000E77C4 File Offset: 0x000E59C4
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryPluginBoxItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryPluginBoxItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语道具.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryPluginBoxItem"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryPluginBoxItem` where Id=?")
			});
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x000E7843 File Offset: 0x000E5A43
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryPluginBoxItemById.LogPair = null;
			ConfigHonamiStoryPluginBoxItemById.HandleId = 0;
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x000E7851 File Offset: 0x000E5A51
		public static void Init()
		{
			ConfigHonamiStoryPluginBoxItemById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryPluginBoxItemById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryPluginBoxItem` where Id=?");
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x000E786C File Offset: 0x000E5A6C
		public static HonamiStoryPluginBoxItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryPluginBoxItemById.HandleId, ConfigHonamiStoryPluginBoxItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryPluginBoxItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryPluginBoxItem?(HonamiStoryPluginBoxItem.GetRootAsHonamiStoryPluginBoxItem(configBuffer));
				}
			}
			ConfigHonamiStoryPluginBoxItemById.LogPair.Clear();
			ConfigHonamiStoryPluginBoxItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryPluginBoxItemById.HandleId, 1, p0Id, ConfigHonamiStoryPluginBoxItemById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryPluginBoxItemById.HandleId, true, ConfigHonamiStoryPluginBoxItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryPluginBoxItemById.HandleId, ConfigHonamiStoryPluginBoxItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryPluginBoxItemById.HandleId, 0, ConfigHonamiStoryPluginBoxItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryPluginBoxItemById.HandleId, ConfigHonamiStoryPluginBoxItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryPluginBoxItem rootAsHonamiStoryPluginBoxItem = HonamiStoryPluginBoxItem.GetRootAsHonamiStoryPluginBoxItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryPluginBoxItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryPluginBoxItemById.HandleId, ConfigHonamiStoryPluginBoxItemById.LogPair);
			return new HonamiStoryPluginBoxItem?(rootAsHonamiStoryPluginBoxItem);
		}

		// Token: 0x04001C62 RID: 7266
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C63 RID: 7267
		private const string FILE = "s.穗波奇妙物语道具.xlsx";

		// Token: 0x04001C64 RID: 7268
		private const string TABLE = "HonamiStoryPluginBoxItem";

		// Token: 0x04001C65 RID: 7269
		private const string COMMAND = "select BinData from `HonamiStoryPluginBoxItem` where Id=?";

		// Token: 0x04001C66 RID: 7270
		private const string KEY_PREFIX = "HonamiStoryPluginBoxItemById";

		// Token: 0x04001C67 RID: 7271
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C68 RID: 7272
		private static int HandleId;
	}
}

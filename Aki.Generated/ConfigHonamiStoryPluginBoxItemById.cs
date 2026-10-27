using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003FC RID: 1020
	public class ConfigHonamiStoryPluginBoxItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017EF RID: 6127 RVA: 0x000E104F File Offset: 0x000DF24F
		static ConfigHonamiStoryPluginBoxItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryPluginBoxItemById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryPluginBoxItemById.ResetStaticDefaultValue));
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x000E1070 File Offset: 0x000DF270
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

		// Token: 0x060017F1 RID: 6129 RVA: 0x000E10EF File Offset: 0x000DF2EF
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryPluginBoxItemById.LogPair = null;
			ConfigHonamiStoryPluginBoxItemById.HandleId = 0;
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x000E10FD File Offset: 0x000DF2FD
		public static void Init()
		{
			ConfigHonamiStoryPluginBoxItemById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryPluginBoxItemById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryPluginBoxItem` where Id=?");
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x000E1118 File Offset: 0x000DF318
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

		// Token: 0x04001BC8 RID: 7112
		private const string DB = "db_honamistory.db";

		// Token: 0x04001BC9 RID: 7113
		private const string FILE = "s.穗波奇妙物语道具.xlsx";

		// Token: 0x04001BCA RID: 7114
		private const string TABLE = "HonamiStoryPluginBoxItem";

		// Token: 0x04001BCB RID: 7115
		private const string COMMAND = "select BinData from `HonamiStoryPluginBoxItem` where Id=?";

		// Token: 0x04001BCC RID: 7116
		private const string KEY_PREFIX = "HonamiStoryPluginBoxItemById";

		// Token: 0x04001BCD RID: 7117
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001BCE RID: 7118
		private static int HandleId;
	}
}

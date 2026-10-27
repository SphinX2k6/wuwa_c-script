using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003FF RID: 1023
	public class ConfigHonamiStoryPluginTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001801 RID: 6145 RVA: 0x000E1728 File Offset: 0x000DF928
		static ConfigHonamiStoryPluginTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryPluginTagById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryPluginTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x000E1748 File Offset: 0x000DF948
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryPluginTagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryPluginTagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语装备栏.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryPluginTag"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryPluginTag` where Id=?")
			});
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x000E17C7 File Offset: 0x000DF9C7
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryPluginTagById.LogPair = null;
			ConfigHonamiStoryPluginTagById.HandleId = 0;
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x000E17D5 File Offset: 0x000DF9D5
		public static void Init()
		{
			ConfigHonamiStoryPluginTagById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryPluginTagById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryPluginTag` where Id=?");
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x000E17F0 File Offset: 0x000DF9F0
		public static HonamiStoryPluginTag? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryPluginTagById.HandleId, ConfigHonamiStoryPluginTagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryPluginTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryPluginTag?(HonamiStoryPluginTag.GetRootAsHonamiStoryPluginTag(configBuffer));
				}
			}
			ConfigHonamiStoryPluginTagById.LogPair.Clear();
			ConfigHonamiStoryPluginTagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryPluginTagById.HandleId, 1, p0Id, ConfigHonamiStoryPluginTagById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryPluginTagById.HandleId, true, ConfigHonamiStoryPluginTagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryPluginTagById.HandleId, ConfigHonamiStoryPluginTagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryPluginTagById.HandleId, 0, ConfigHonamiStoryPluginTagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryPluginTagById.HandleId, ConfigHonamiStoryPluginTagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryPluginTag rootAsHonamiStoryPluginTag = HonamiStoryPluginTag.GetRootAsHonamiStoryPluginTag(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryPluginTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryPluginTagById.HandleId, ConfigHonamiStoryPluginTagById.LogPair);
			return new HonamiStoryPluginTag?(rootAsHonamiStoryPluginTag);
		}

		// Token: 0x04001BDD RID: 7133
		private const string DB = "db_honamistory.db";

		// Token: 0x04001BDE RID: 7134
		private const string FILE = "s.穗波奇妙物语装备栏.xlsx";

		// Token: 0x04001BDF RID: 7135
		private const string TABLE = "HonamiStoryPluginTag";

		// Token: 0x04001BE0 RID: 7136
		private const string COMMAND = "select BinData from `HonamiStoryPluginTag` where Id=?";

		// Token: 0x04001BE1 RID: 7137
		private const string KEY_PREFIX = "HonamiStoryPluginTagById";

		// Token: 0x04001BE2 RID: 7138
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001BE3 RID: 7139
		private static int HandleId;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003FF RID: 1023
	public class ConfigHonamiStoryItemQualityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001801 RID: 6145 RVA: 0x000E4D7B File Offset: 0x000E2F7B
		static ConfigHonamiStoryItemQualityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryItemQualityById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryItemQualityById.ResetStaticDefaultValue));
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x000E4D9C File Offset: 0x000E2F9C
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryItemQualityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryItemQualityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语道具.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryItemQuality"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryItemQuality` where Id=?")
			});
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x000E4E1B File Offset: 0x000E301B
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryItemQualityById.LogPair = null;
			ConfigHonamiStoryItemQualityById.HandleId = 0;
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x000E4E29 File Offset: 0x000E3029
		public static void Init()
		{
			ConfigHonamiStoryItemQualityById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryItemQualityById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryItemQuality` where Id=?");
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x000E4E44 File Offset: 0x000E3044
		public static HonamiStoryItemQuality? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryItemQualityById.HandleId, ConfigHonamiStoryItemQualityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryItemQualityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryItemQuality?(HonamiStoryItemQuality.GetRootAsHonamiStoryItemQuality(configBuffer));
				}
			}
			ConfigHonamiStoryItemQualityById.LogPair.Clear();
			ConfigHonamiStoryItemQualityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryItemQualityById.HandleId, 1, p0Id, ConfigHonamiStoryItemQualityById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryItemQualityById.HandleId, true, ConfigHonamiStoryItemQualityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryItemQualityById.HandleId, ConfigHonamiStoryItemQualityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryItemQualityById.HandleId, 0, ConfigHonamiStoryItemQualityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryItemQualityById.HandleId, ConfigHonamiStoryItemQualityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryItemQuality rootAsHonamiStoryItemQuality = HonamiStoryItemQuality.GetRootAsHonamiStoryItemQuality(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryItemQualityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryItemQualityById.HandleId, ConfigHonamiStoryItemQualityById.LogPair);
			return new HonamiStoryItemQuality?(rootAsHonamiStoryItemQuality);
		}

		// Token: 0x04001BDD RID: 7133
		private const string DB = "db_honamistory.db";

		// Token: 0x04001BDE RID: 7134
		private const string FILE = "s.穗波奇妙物语道具.xlsx";

		// Token: 0x04001BDF RID: 7135
		private const string TABLE = "HonamiStoryItemQuality";

		// Token: 0x04001BE0 RID: 7136
		private const string COMMAND = "select BinData from `HonamiStoryItemQuality` where Id=?";

		// Token: 0x04001BE1 RID: 7137
		private const string KEY_PREFIX = "HonamiStoryItemQualityById";

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

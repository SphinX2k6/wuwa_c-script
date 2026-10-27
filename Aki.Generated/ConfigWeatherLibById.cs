using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A8F RID: 2703
	public class ConfigWeatherLibById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F6E RID: 16238 RVA: 0x001C10CC File Offset: 0x001BF2CC
		static ConfigWeatherLibById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeatherLibById.CreateStaticDefaultValue), new Action(ConfigWeatherLibById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F6F RID: 16239 RVA: 0x001C10EC File Offset: 0x001BF2EC
		public static void CreateStaticDefaultValue()
		{
			ConfigWeatherLibById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeatherLibById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weather.db"),
				new ValueTuple<string, object>("文件", "t.天气系统.xlsx"),
				new ValueTuple<string, object>("表名", "WeatherLib"),
				new ValueTuple<string, object>("语句", "select BinData from `WeatherLib` where Id = ?")
			});
		}

		// Token: 0x06003F70 RID: 16240 RVA: 0x001C116B File Offset: 0x001BF36B
		public static void ResetStaticDefaultValue()
		{
			ConfigWeatherLibById.LogPair = null;
			ConfigWeatherLibById.HandleId = 0;
		}

		// Token: 0x06003F71 RID: 16241 RVA: 0x001C1179 File Offset: 0x001BF379
		public static void Init()
		{
			ConfigWeatherLibById.HandleId = ConfigCommon.InitDataStatement(ConfigWeatherLibById.HandleId, "db_weather.db", "select BinData from `WeatherLib` where Id = ?");
		}

		// Token: 0x06003F72 RID: 16242 RVA: 0x001C1194 File Offset: 0x001BF394
		public static WeatherLib? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeatherLibById.HandleId, ConfigWeatherLibById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeatherLibById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeatherLib?(WeatherLib.GetRootAsWeatherLib(configBuffer));
				}
			}
			ConfigWeatherLibById.LogPair.Clear();
			ConfigWeatherLibById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWeatherLibById.HandleId, 1, p0Id, ConfigWeatherLibById.LogPair) || ConfigCommon.Step(ConfigWeatherLibById.HandleId, true, ConfigWeatherLibById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeatherLibById.HandleId, ConfigWeatherLibById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeatherLibById.HandleId, 0, ConfigWeatherLibById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeatherLibById.HandleId, ConfigWeatherLibById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeatherLib rootAsWeatherLib = WeatherLib.GetRootAsWeatherLib(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeatherLibById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeatherLibById.HandleId, ConfigWeatherLibById.LogPair);
			return new WeatherLib?(rootAsWeatherLib);
		}

		// Token: 0x040049CF RID: 18895
		private const string DB = "db_weather.db";

		// Token: 0x040049D0 RID: 18896
		private const string FILE = "t.天气系统.xlsx";

		// Token: 0x040049D1 RID: 18897
		private const string TABLE = "WeatherLib";

		// Token: 0x040049D2 RID: 18898
		private const string COMMAND = "select BinData from `WeatherLib` where Id = ?";

		// Token: 0x040049D3 RID: 18899
		private const string KEY_PREFIX = "WeatherLibById";

		// Token: 0x040049D4 RID: 18900
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040049D5 RID: 18901
		private static int HandleId;
	}
}

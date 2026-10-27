using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A8E RID: 2702
	public class ConfigWeatherById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F68 RID: 16232 RVA: 0x001C0E82 File Offset: 0x001BF082
		static ConfigWeatherById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeatherById.CreateStaticDefaultValue), new Action(ConfigWeatherById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F69 RID: 16233 RVA: 0x001C0EA4 File Offset: 0x001BF0A4
		public static void CreateStaticDefaultValue()
		{
			ConfigWeatherById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeatherById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weather.db"),
				new ValueTuple<string, object>("文件", "t.天气系统.xlsx"),
				new ValueTuple<string, object>("表名", "Weather"),
				new ValueTuple<string, object>("语句", "select BinData from `Weather` where Id = ?")
			});
		}

		// Token: 0x06003F6A RID: 16234 RVA: 0x001C0F23 File Offset: 0x001BF123
		public static void ResetStaticDefaultValue()
		{
			ConfigWeatherById.LogPair = null;
			ConfigWeatherById.HandleId = 0;
		}

		// Token: 0x06003F6B RID: 16235 RVA: 0x001C0F31 File Offset: 0x001BF131
		public static void Init()
		{
			ConfigWeatherById.HandleId = ConfigCommon.InitDataStatement(ConfigWeatherById.HandleId, "db_weather.db", "select BinData from `Weather` where Id = ?");
		}

		// Token: 0x06003F6C RID: 16236 RVA: 0x001C0F4C File Offset: 0x001BF14C
		public static Weather? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeatherById.HandleId, ConfigWeatherById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeatherById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Weather?(Weather.GetRootAsWeather(configBuffer));
				}
			}
			ConfigWeatherById.LogPair.Clear();
			ConfigWeatherById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWeatherById.HandleId, 1, p0Id, ConfigWeatherById.LogPair) || ConfigCommon.Step(ConfigWeatherById.HandleId, true, ConfigWeatherById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeatherById.HandleId, ConfigWeatherById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeatherById.HandleId, 0, ConfigWeatherById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeatherById.HandleId, ConfigWeatherById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Weather rootAsWeather = Weather.GetRootAsWeather(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeatherById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeatherById.HandleId, ConfigWeatherById.LogPair);
			return new Weather?(rootAsWeather);
		}

		// Token: 0x040049C8 RID: 18888
		private const string DB = "db_weather.db";

		// Token: 0x040049C9 RID: 18889
		private const string FILE = "t.天气系统.xlsx";

		// Token: 0x040049CA RID: 18890
		private const string TABLE = "Weather";

		// Token: 0x040049CB RID: 18891
		private const string COMMAND = "select BinData from `Weather` where Id = ?";

		// Token: 0x040049CC RID: 18892
		private const string KEY_PREFIX = "WeatherById";

		// Token: 0x040049CD RID: 18893
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040049CE RID: 18894
		private static int HandleId;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B63 RID: 2915
	public class ConfigWeatherById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004466 RID: 17510 RVA: 0x001E0216 File Offset: 0x001DE416
		static ConfigWeatherById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeatherById.CreateStaticDefaultValue), new Action(ConfigWeatherById.ResetStaticDefaultValue));
		}

		// Token: 0x06004467 RID: 17511 RVA: 0x001E0238 File Offset: 0x001DE438
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

		// Token: 0x06004468 RID: 17512 RVA: 0x001E02B7 File Offset: 0x001DE4B7
		public static void ResetStaticDefaultValue()
		{
			ConfigWeatherById.LogPair = null;
			ConfigWeatherById.HandleId = 0;
		}

		// Token: 0x06004469 RID: 17513 RVA: 0x001E02C5 File Offset: 0x001DE4C5
		public static void Init()
		{
			ConfigWeatherById.HandleId = ConfigCommon.InitDataStatement(ConfigWeatherById.HandleId, "db_weather.db", "select BinData from `Weather` where Id = ?");
		}

		// Token: 0x0600446A RID: 17514 RVA: 0x001E02E0 File Offset: 0x001DE4E0
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

		// Token: 0x04004F9B RID: 20379
		private const string DB = "db_weather.db";

		// Token: 0x04004F9C RID: 20380
		private const string FILE = "t.天气系统.xlsx";

		// Token: 0x04004F9D RID: 20381
		private const string TABLE = "Weather";

		// Token: 0x04004F9E RID: 20382
		private const string COMMAND = "select BinData from `Weather` where Id = ?";

		// Token: 0x04004F9F RID: 20383
		private const string KEY_PREFIX = "WeatherById";

		// Token: 0x04004FA0 RID: 20384
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004FA1 RID: 20385
		private static int HandleId;
	}
}

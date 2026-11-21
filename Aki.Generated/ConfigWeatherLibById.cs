using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B64 RID: 2916
	public class ConfigWeatherLibById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600446C RID: 17516 RVA: 0x001E0460 File Offset: 0x001DE660
		static ConfigWeatherLibById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeatherLibById.CreateStaticDefaultValue), new Action(ConfigWeatherLibById.ResetStaticDefaultValue));
		}

		// Token: 0x0600446D RID: 17517 RVA: 0x001E0480 File Offset: 0x001DE680
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

		// Token: 0x0600446E RID: 17518 RVA: 0x001E04FF File Offset: 0x001DE6FF
		public static void ResetStaticDefaultValue()
		{
			ConfigWeatherLibById.LogPair = null;
			ConfigWeatherLibById.HandleId = 0;
		}

		// Token: 0x0600446F RID: 17519 RVA: 0x001E050D File Offset: 0x001DE70D
		public static void Init()
		{
			ConfigWeatherLibById.HandleId = ConfigCommon.InitDataStatement(ConfigWeatherLibById.HandleId, "db_weather.db", "select BinData from `WeatherLib` where Id = ?");
		}

		// Token: 0x06004470 RID: 17520 RVA: 0x001E0528 File Offset: 0x001DE728
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

		// Token: 0x04004FA2 RID: 20386
		private const string DB = "db_weather.db";

		// Token: 0x04004FA3 RID: 20387
		private const string FILE = "t.天气系统.xlsx";

		// Token: 0x04004FA4 RID: 20388
		private const string TABLE = "WeatherLib";

		// Token: 0x04004FA5 RID: 20389
		private const string COMMAND = "select BinData from `WeatherLib` where Id = ?";

		// Token: 0x04004FA6 RID: 20390
		private const string KEY_PREFIX = "WeatherLibById";

		// Token: 0x04004FA7 RID: 20391
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004FA8 RID: 20392
		private static int HandleId;
	}
}

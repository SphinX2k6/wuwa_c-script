using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A91 RID: 2705
	public class ConfigWeatherSwitchById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F7A RID: 16250 RVA: 0x001C14A7 File Offset: 0x001BF6A7
		static ConfigWeatherSwitchById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeatherSwitchById.CreateStaticDefaultValue), new Action(ConfigWeatherSwitchById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F7B RID: 16251 RVA: 0x001C14C8 File Offset: 0x001BF6C8
		public static void CreateStaticDefaultValue()
		{
			ConfigWeatherSwitchById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeatherSwitchById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weather.db"),
				new ValueTuple<string, object>("文件", "t.天气系统.xlsx"),
				new ValueTuple<string, object>("表名", "WeatherSwitch"),
				new ValueTuple<string, object>("语句", "select BinData from `WeatherSwitch` where Id=?")
			});
		}

		// Token: 0x06003F7C RID: 16252 RVA: 0x001C1547 File Offset: 0x001BF747
		public static void ResetStaticDefaultValue()
		{
			ConfigWeatherSwitchById.LogPair = null;
			ConfigWeatherSwitchById.HandleId = 0;
		}

		// Token: 0x06003F7D RID: 16253 RVA: 0x001C1555 File Offset: 0x001BF755
		public static void Init()
		{
			ConfigWeatherSwitchById.HandleId = ConfigCommon.InitDataStatement(ConfigWeatherSwitchById.HandleId, "db_weather.db", "select BinData from `WeatherSwitch` where Id=?");
		}

		// Token: 0x06003F7E RID: 16254 RVA: 0x001C1570 File Offset: 0x001BF770
		public static WeatherSwitch? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeatherSwitchById.HandleId, ConfigWeatherSwitchById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeatherSwitchById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeatherSwitch?(WeatherSwitch.GetRootAsWeatherSwitch(configBuffer));
				}
			}
			ConfigWeatherSwitchById.LogPair.Clear();
			ConfigWeatherSwitchById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWeatherSwitchById.HandleId, 1, p0Id, ConfigWeatherSwitchById.LogPair) || ConfigCommon.Step(ConfigWeatherSwitchById.HandleId, true, ConfigWeatherSwitchById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeatherSwitchById.HandleId, ConfigWeatherSwitchById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeatherSwitchById.HandleId, 0, ConfigWeatherSwitchById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeatherSwitchById.HandleId, ConfigWeatherSwitchById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeatherSwitch rootAsWeatherSwitch = WeatherSwitch.GetRootAsWeatherSwitch(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeatherSwitchById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeatherSwitchById.HandleId, ConfigWeatherSwitchById.LogPair);
			return new WeatherSwitch?(rootAsWeatherSwitch);
		}

		// Token: 0x040049DD RID: 18909
		private const string DB = "db_weather.db";

		// Token: 0x040049DE RID: 18910
		private const string FILE = "t.天气系统.xlsx";

		// Token: 0x040049DF RID: 18911
		private const string TABLE = "WeatherSwitch";

		// Token: 0x040049E0 RID: 18912
		private const string COMMAND = "select BinData from `WeatherSwitch` where Id=?";

		// Token: 0x040049E1 RID: 18913
		private const string KEY_PREFIX = "WeatherSwitchById";

		// Token: 0x040049E2 RID: 18914
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040049E3 RID: 18915
		private static int HandleId;
	}
}

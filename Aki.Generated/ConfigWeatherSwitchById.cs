using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B66 RID: 2918
	public class ConfigWeatherSwitchById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004478 RID: 17528 RVA: 0x001E083B File Offset: 0x001DEA3B
		static ConfigWeatherSwitchById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeatherSwitchById.CreateStaticDefaultValue), new Action(ConfigWeatherSwitchById.ResetStaticDefaultValue));
		}

		// Token: 0x06004479 RID: 17529 RVA: 0x001E085C File Offset: 0x001DEA5C
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

		// Token: 0x0600447A RID: 17530 RVA: 0x001E08DB File Offset: 0x001DEADB
		public static void ResetStaticDefaultValue()
		{
			ConfigWeatherSwitchById.LogPair = null;
			ConfigWeatherSwitchById.HandleId = 0;
		}

		// Token: 0x0600447B RID: 17531 RVA: 0x001E08E9 File Offset: 0x001DEAE9
		public static void Init()
		{
			ConfigWeatherSwitchById.HandleId = ConfigCommon.InitDataStatement(ConfigWeatherSwitchById.HandleId, "db_weather.db", "select BinData from `WeatherSwitch` where Id=?");
		}

		// Token: 0x0600447C RID: 17532 RVA: 0x001E0904 File Offset: 0x001DEB04
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

		// Token: 0x04004FB0 RID: 20400
		private const string DB = "db_weather.db";

		// Token: 0x04004FB1 RID: 20401
		private const string FILE = "t.天气系统.xlsx";

		// Token: 0x04004FB2 RID: 20402
		private const string TABLE = "WeatherSwitch";

		// Token: 0x04004FB3 RID: 20403
		private const string COMMAND = "select BinData from `WeatherSwitch` where Id=?";

		// Token: 0x04004FB4 RID: 20404
		private const string KEY_PREFIX = "WeatherSwitchById";

		// Token: 0x04004FB5 RID: 20405
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004FB6 RID: 20406
		private static int HandleId;
	}
}

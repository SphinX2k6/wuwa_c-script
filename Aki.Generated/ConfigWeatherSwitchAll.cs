using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B65 RID: 2917
	public class ConfigWeatherSwitchAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004472 RID: 17522 RVA: 0x001E06A8 File Offset: 0x001DE8A8
		static ConfigWeatherSwitchAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeatherSwitchAll.CreateStaticDefaultValue), new Action(ConfigWeatherSwitchAll.ResetStaticDefaultValue));
		}

		// Token: 0x06004473 RID: 17523 RVA: 0x001E06C8 File Offset: 0x001DE8C8
		public static void CreateStaticDefaultValue()
		{
			ConfigWeatherSwitchAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeatherSwitchAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weather.db"),
				new ValueTuple<string, object>("文件", "t.天气系统.xlsx"),
				new ValueTuple<string, object>("表名", "WeatherSwitch"),
				new ValueTuple<string, object>("语句", "select BinData from `WeatherSwitch`")
			});
		}

		// Token: 0x06004474 RID: 17524 RVA: 0x001E0747 File Offset: 0x001DE947
		public static void ResetStaticDefaultValue()
		{
			ConfigWeatherSwitchAll.LogPair = null;
			ConfigWeatherSwitchAll.HandleId = 0;
		}

		// Token: 0x06004475 RID: 17525 RVA: 0x001E0755 File Offset: 0x001DE955
		public static void Init()
		{
			ConfigWeatherSwitchAll.HandleId = ConfigCommon.InitDataStatement(ConfigWeatherSwitchAll.HandleId, "db_weather.db", "select BinData from `WeatherSwitch`");
		}

		// Token: 0x06004476 RID: 17526 RVA: 0x001E0770 File Offset: 0x001DE970
		[NullableContext(2)]
		public static IReadOnlyList<WeatherSwitch> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeatherSwitchAll.HandleId, ConfigWeatherSwitchAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<WeatherSwitch> readOnlyList = (IReadOnlyList<WeatherSwitch>)ConfigCommon.GetConfig("WeatherSwitchAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<WeatherSwitch> list = new List<WeatherSwitch>();
			while (ConfigCommon.Step(ConfigWeatherSwitchAll.HandleId, false, ConfigWeatherSwitchAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeatherSwitchAll.HandleId, 0, ConfigWeatherSwitchAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigWeatherSwitchAll.HandleId, ConfigWeatherSwitchAll.LogPair);
					return null;
				}
				WeatherSwitch rootAsWeatherSwitch = WeatherSwitch.GetRootAsWeatherSwitch(new ByteBuffer(item2));
				list.Add(rootAsWeatherSwitch);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("WeatherSwitchAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigWeatherSwitchAll.HandleId, ConfigWeatherSwitchAll.LogPair);
			return list;
		}

		// Token: 0x04004FA9 RID: 20393
		private const string DB = "db_weather.db";

		// Token: 0x04004FAA RID: 20394
		private const string FILE = "t.天气系统.xlsx";

		// Token: 0x04004FAB RID: 20395
		private const string TABLE = "WeatherSwitch";

		// Token: 0x04004FAC RID: 20396
		private const string COMMAND = "select BinData from `WeatherSwitch`";

		// Token: 0x04004FAD RID: 20397
		private const string KEY_PREFIX = "WeatherSwitchAll";

		// Token: 0x04004FAE RID: 20398
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004FAF RID: 20399
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A90 RID: 2704
	public class ConfigWeatherSwitchAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F74 RID: 16244 RVA: 0x001C1314 File Offset: 0x001BF514
		static ConfigWeatherSwitchAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeatherSwitchAll.CreateStaticDefaultValue), new Action(ConfigWeatherSwitchAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003F75 RID: 16245 RVA: 0x001C1334 File Offset: 0x001BF534
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

		// Token: 0x06003F76 RID: 16246 RVA: 0x001C13B3 File Offset: 0x001BF5B3
		public static void ResetStaticDefaultValue()
		{
			ConfigWeatherSwitchAll.LogPair = null;
			ConfigWeatherSwitchAll.HandleId = 0;
		}

		// Token: 0x06003F77 RID: 16247 RVA: 0x001C13C1 File Offset: 0x001BF5C1
		public static void Init()
		{
			ConfigWeatherSwitchAll.HandleId = ConfigCommon.InitDataStatement(ConfigWeatherSwitchAll.HandleId, "db_weather.db", "select BinData from `WeatherSwitch`");
		}

		// Token: 0x06003F78 RID: 16248 RVA: 0x001C13DC File Offset: 0x001BF5DC
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

		// Token: 0x040049D6 RID: 18902
		private const string DB = "db_weather.db";

		// Token: 0x040049D7 RID: 18903
		private const string FILE = "t.天气系统.xlsx";

		// Token: 0x040049D8 RID: 18904
		private const string TABLE = "WeatherSwitch";

		// Token: 0x040049D9 RID: 18905
		private const string COMMAND = "select BinData from `WeatherSwitch`";

		// Token: 0x040049DA RID: 18906
		private const string KEY_PREFIX = "WeatherSwitchAll";

		// Token: 0x040049DB RID: 18907
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040049DC RID: 18908
		private static int HandleId;
	}
}

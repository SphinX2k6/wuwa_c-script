using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Weather
{
	// Token: 0x02003796 RID: 14230
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class WeatherModuleConfig : ConfigBase
	{
		// Token: 0x06025006 RID: 151558 RVA: 0x00A73E10 File Offset: 0x00A72010
		public Weather? GetWeatherConfig(int id)
		{
			Weather? config = ConfigWeatherById.GetConfig(id, true);
			if (config != null)
			{
				return new Weather?(config.Value);
			}
			return null;
		}

		// Token: 0x06025007 RID: 151559 RVA: 0x00A73E44 File Offset: 0x00A72044
		public WeatherDefines.EWeatherType GetWeatherType(int id)
		{
			Weather? config = ConfigWeatherById.GetConfig(id, true);
			if (config != null)
			{
				return (WeatherDefines.EWeatherType)config.Value.WeatherType;
			}
			return WeatherDefines.EWeatherType.None;
		}

		// Token: 0x06025008 RID: 151560 RVA: 0x00A73E74 File Offset: 0x00A72074
		public WeatherSwitch? GetWeatherSwitchConfig(int id)
		{
			WeatherSwitch? config = ConfigWeatherSwitchById.GetConfig(id, true);
			if (config != null)
			{
				return new WeatherSwitch?(config.Value);
			}
			return null;
		}

		// Token: 0x06025009 RID: 151561 RVA: 0x00A73EA8 File Offset: 0x00A720A8
		[NullableContext(2)]
		public IReadOnlyList<WeatherSwitch> GetWeatherSwitchConfigAll()
		{
			return ConfigWeatherSwitchAll.GetConfigList(true);
		}

		// Token: 0x17004BE5 RID: 19429
		// (get) Token: 0x0602500A RID: 151562 RVA: 0x00A73EB0 File Offset: 0x00A720B0
		public static WeatherModuleConfig Instance
		{
			get
			{
				return WeatherModuleConfig._Instance;
			}
		}

		// Token: 0x0602500B RID: 151563 RVA: 0x00A73EB7 File Offset: 0x00A720B7
		public static WeatherModuleConfig GetOrCreateInstance()
		{
			if (WeatherModuleConfig._Instance == null)
			{
				WeatherModuleConfig.CreateInstance();
			}
			return WeatherModuleConfig._Instance;
		}

		// Token: 0x0602500C RID: 151564 RVA: 0x00A73ECB File Offset: 0x00A720CB
		public static bool CreateInstance()
		{
			if (WeatherModuleConfig._Instance != null)
			{
				return true;
			}
			WeatherModuleConfig._Instance = new WeatherModuleConfig();
			return true;
		}

		// Token: 0x0602500D RID: 151565 RVA: 0x00A73EE1 File Offset: 0x00A720E1
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602500E RID: 151566 RVA: 0x00A73EE3 File Offset: 0x00A720E3
		public static void ResetStaticDefaultValue()
		{
			WeatherModuleConfig._Instance = null;
		}

		// Token: 0x0602500F RID: 151567 RVA: 0x00A73EEB File Offset: 0x00A720EB
		static WeatherModuleConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WeatherModuleConfig.CreateStaticDefaultValue), new Action(WeatherModuleConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401479D RID: 83869
		[Nullable(2)]
		private static WeatherModuleConfig _Instance;
	}
}

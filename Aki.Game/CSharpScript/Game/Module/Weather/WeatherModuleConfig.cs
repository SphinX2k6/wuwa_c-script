using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Weather
{
	// Token: 0x02004865 RID: 18533
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class WeatherModuleConfig : ConfigBase
	{
		// Token: 0x06030836 RID: 198710 RVA: 0x00B43BFC File Offset: 0x00B41DFC
		public Weather? GetWeatherConfig(int id)
		{
			Weather? config = ConfigWeatherById.GetConfig(id, true);
			if (config != null)
			{
				return new Weather?(config.Value);
			}
			return null;
		}

		// Token: 0x06030837 RID: 198711 RVA: 0x00B43C30 File Offset: 0x00B41E30
		public WeatherDefines.EWeatherType GetWeatherType(int id)
		{
			Weather? config = ConfigWeatherById.GetConfig(id, true);
			if (config != null)
			{
				return (WeatherDefines.EWeatherType)config.Value.WeatherType;
			}
			return WeatherDefines.EWeatherType.None;
		}

		// Token: 0x06030838 RID: 198712 RVA: 0x00B43C60 File Offset: 0x00B41E60
		public WeatherSwitch? GetWeatherSwitchConfig(int id)
		{
			WeatherSwitch? config = ConfigWeatherSwitchById.GetConfig(id, true);
			if (config != null)
			{
				return new WeatherSwitch?(config.Value);
			}
			return null;
		}

		// Token: 0x06030839 RID: 198713 RVA: 0x00B43C94 File Offset: 0x00B41E94
		[NullableContext(2)]
		public IReadOnlyList<WeatherSwitch> GetWeatherSwitchConfigAll()
		{
			return ConfigWeatherSwitchAll.GetConfigList(true);
		}

		// Token: 0x17007929 RID: 31017
		// (get) Token: 0x0603083A RID: 198714 RVA: 0x00B43C9C File Offset: 0x00B41E9C
		public static WeatherModuleConfig Instance
		{
			get
			{
				return WeatherModuleConfig._Instance;
			}
		}

		// Token: 0x0603083B RID: 198715 RVA: 0x00B43CA3 File Offset: 0x00B41EA3
		public static WeatherModuleConfig GetOrCreateInstance()
		{
			if (WeatherModuleConfig._Instance == null)
			{
				WeatherModuleConfig.CreateInstance();
			}
			return WeatherModuleConfig._Instance;
		}

		// Token: 0x0603083C RID: 198716 RVA: 0x00B43CB7 File Offset: 0x00B41EB7
		public static bool CreateInstance()
		{
			if (WeatherModuleConfig._Instance != null)
			{
				return true;
			}
			WeatherModuleConfig._Instance = new WeatherModuleConfig();
			return true;
		}

		// Token: 0x0603083D RID: 198717 RVA: 0x00B43CCD File Offset: 0x00B41ECD
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603083E RID: 198718 RVA: 0x00B43CCF File Offset: 0x00B41ECF
		public static void ResetStaticDefaultValue()
		{
			WeatherModuleConfig._Instance = null;
		}

		// Token: 0x0603083F RID: 198719 RVA: 0x00B43CD7 File Offset: 0x00B41ED7
		static WeatherModuleConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WeatherModuleConfig.CreateStaticDefaultValue), new Action(WeatherModuleConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401A0EA RID: 106730
		[Nullable(2)]
		private static WeatherModuleConfig _Instance;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.WorldMap.RegionalTerminal
{
	// Token: 0x02003783 RID: 14211
	[NullableContext(1)]
	[Nullable(0)]
	public class RegionalTerminalConfig : ConfigBase
	{
		// Token: 0x06024EDD RID: 151261 RVA: 0x00A6F610 File Offset: 0x00A6D810
		public AreaTerminal? GetAreaTerminalByGameplayId(int gameplayId)
		{
			return ConfigAreaTerminalById.GetConfig(gameplayId, true);
		}

		// Token: 0x06024EDE RID: 151262 RVA: 0x00A6F619 File Offset: 0x00A6D819
		public IReadOnlyList<AreaTerminal> GetAreaTerminalByCountryId(int countryId)
		{
			return ConfigAreaTerminalByCountry.GetConfigList(countryId, true) ?? new List<AreaTerminal>();
		}

		// Token: 0x06024EDF RID: 151263 RVA: 0x00A6F62B File Offset: 0x00A6D82B
		public IReadOnlyList<AreaTerminal> GetAllAreaTerminal()
		{
			return ConfigAreaTerminalAll.GetConfigList(true) ?? new List<AreaTerminal>();
		}

		// Token: 0x06024EE0 RID: 151264 RVA: 0x00A6F63C File Offset: 0x00A6D83C
		public AreaTerminalGroup? GetAreaTerminalGroup(int groupId)
		{
			return ConfigAreaTerminalGroupById.GetConfig(groupId, true);
		}

		// Token: 0x06024EE1 RID: 151265 RVA: 0x00A6F645 File Offset: 0x00A6D845
		public IReadOnlyList<AreaMapGroup> GetAllAreaMapGroup()
		{
			return ConfigAreaMapGroupAll.GetConfigList(true) ?? new List<AreaMapGroup>();
		}

		// Token: 0x06024EE2 RID: 151266 RVA: 0x00A6F656 File Offset: 0x00A6D856
		public AreaMapGroup? GetAreaMapGroup(int groupId)
		{
			return ConfigAreaMapGroupById.GetConfig(groupId, true);
		}

		// Token: 0x17004BCC RID: 19404
		// (get) Token: 0x06024EE3 RID: 151267 RVA: 0x00A6F65F File Offset: 0x00A6D85F
		public static RegionalTerminalConfig Instance
		{
			get
			{
				return RegionalTerminalConfig._Instance;
			}
		}

		// Token: 0x06024EE4 RID: 151268 RVA: 0x00A6F666 File Offset: 0x00A6D866
		public static RegionalTerminalConfig GetOrCreateInstance()
		{
			if (RegionalTerminalConfig._Instance == null)
			{
				RegionalTerminalConfig.CreateInstance();
			}
			return RegionalTerminalConfig._Instance;
		}

		// Token: 0x06024EE5 RID: 151269 RVA: 0x00A6F67A File Offset: 0x00A6D87A
		public static bool CreateInstance()
		{
			if (RegionalTerminalConfig._Instance != null)
			{
				return true;
			}
			RegionalTerminalConfig._Instance = new RegionalTerminalConfig();
			return true;
		}

		// Token: 0x06024EE6 RID: 151270 RVA: 0x00A6F690 File Offset: 0x00A6D890
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06024EE7 RID: 151271 RVA: 0x00A6F692 File Offset: 0x00A6D892
		public static void ResetStaticDefaultValue()
		{
			RegionalTerminalConfig._Instance = null;
		}

		// Token: 0x06024EE8 RID: 151272 RVA: 0x00A6F69A File Offset: 0x00A6D89A
		static RegionalTerminalConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RegionalTerminalConfig.CreateStaticDefaultValue), new Action(RegionalTerminalConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04014734 RID: 83764
		[Nullable(2)]
		private static RegionalTerminalConfig _Instance;
	}
}

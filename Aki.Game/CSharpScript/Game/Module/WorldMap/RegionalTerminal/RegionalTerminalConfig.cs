using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.WorldMap.RegionalTerminal
{
	// Token: 0x02004852 RID: 18514
	[NullableContext(1)]
	[Nullable(0)]
	public class RegionalTerminalConfig : ConfigBase
	{
		// Token: 0x0603070E RID: 198414 RVA: 0x00B3F3CC File Offset: 0x00B3D5CC
		public AreaTerminal? GetAreaTerminalByGameplayId(int gameplayId)
		{
			return ConfigAreaTerminalById.GetConfig(gameplayId, true);
		}

		// Token: 0x0603070F RID: 198415 RVA: 0x00B3F3D5 File Offset: 0x00B3D5D5
		public IReadOnlyList<AreaTerminal> GetAreaTerminalByCountryId(int countryId)
		{
			return ConfigAreaTerminalByCountry.GetConfigList(countryId, true) ?? new List<AreaTerminal>();
		}

		// Token: 0x06030710 RID: 198416 RVA: 0x00B3F3E7 File Offset: 0x00B3D5E7
		public IReadOnlyList<AreaTerminal> GetAllAreaTerminal()
		{
			return ConfigAreaTerminalAll.GetConfigList(true) ?? new List<AreaTerminal>();
		}

		// Token: 0x06030711 RID: 198417 RVA: 0x00B3F3F8 File Offset: 0x00B3D5F8
		public AreaTerminalGroup? GetAreaTerminalGroup(int groupId)
		{
			return ConfigAreaTerminalGroupById.GetConfig(groupId, true);
		}

		// Token: 0x06030712 RID: 198418 RVA: 0x00B3F401 File Offset: 0x00B3D601
		public IReadOnlyList<AreaMapGroup> GetAllAreaMapGroup()
		{
			return ConfigAreaMapGroupAll.GetConfigList(true) ?? new List<AreaMapGroup>();
		}

		// Token: 0x06030713 RID: 198419 RVA: 0x00B3F412 File Offset: 0x00B3D612
		public AreaMapGroup? GetAreaMapGroup(int groupId)
		{
			return ConfigAreaMapGroupById.GetConfig(groupId, true);
		}

		// Token: 0x1700790F RID: 30991
		// (get) Token: 0x06030714 RID: 198420 RVA: 0x00B3F41B File Offset: 0x00B3D61B
		public static RegionalTerminalConfig Instance
		{
			get
			{
				return RegionalTerminalConfig._Instance;
			}
		}

		// Token: 0x06030715 RID: 198421 RVA: 0x00B3F422 File Offset: 0x00B3D622
		public static RegionalTerminalConfig GetOrCreateInstance()
		{
			if (RegionalTerminalConfig._Instance == null)
			{
				RegionalTerminalConfig.CreateInstance();
			}
			return RegionalTerminalConfig._Instance;
		}

		// Token: 0x06030716 RID: 198422 RVA: 0x00B3F436 File Offset: 0x00B3D636
		public static bool CreateInstance()
		{
			if (RegionalTerminalConfig._Instance != null)
			{
				return true;
			}
			RegionalTerminalConfig._Instance = new RegionalTerminalConfig();
			return true;
		}

		// Token: 0x06030717 RID: 198423 RVA: 0x00B3F44C File Offset: 0x00B3D64C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06030718 RID: 198424 RVA: 0x00B3F44E File Offset: 0x00B3D64E
		public static void ResetStaticDefaultValue()
		{
			RegionalTerminalConfig._Instance = null;
		}

		// Token: 0x06030719 RID: 198425 RVA: 0x00B3F456 File Offset: 0x00B3D656
		static RegionalTerminalConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RegionalTerminalConfig.CreateStaticDefaultValue), new Action(RegionalTerminalConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401A080 RID: 106624
		[Nullable(2)]
		private static RegionalTerminalConfig _Instance;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x02005403 RID: 21507
	[NullableContext(1)]
	[Nullable(0)]
	public static class MenuDefineInstSettings
	{
		// Token: 0x06036F5B RID: 225115 RVA: 0x00D04FD8 File Offset: 0x00D031D8
		// Note: this type is marked as 'beforefieldinit'.
		static MenuDefineInstSettings()
		{
			Dictionary<EWorldDungeonSubType, EFunction[]> dictionary = new Dictionary<EWorldDungeonSubType, EFunction[]>();
			dictionary[EWorldDungeonSubType.SpringManorWorld] = new EFunction[]
			{
				EFunction.MobileButtonCustom,
				EFunction.MotorMobileButtonCustom
			};
			MenuDefineInstSettings.disableSettingsWorldInstMap = dictionary;
		}

		// Token: 0x0401D009 RID: 118793
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<EDungeonSubType, EFunction[]> disableSettingsInstMap = new Dictionary<EDungeonSubType, EFunction[]>();

		// Token: 0x0401D00A RID: 118794
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<EWorldDungeonSubType, EFunction[]> disableSettingsWorldInstMap;
	}
}

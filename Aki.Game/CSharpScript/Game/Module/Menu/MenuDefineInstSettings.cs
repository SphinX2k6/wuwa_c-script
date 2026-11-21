using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020043E6 RID: 17382
	[NullableContext(1)]
	[Nullable(0)]
	public static class MenuDefineInstSettings
	{
		// Token: 0x0602BEA3 RID: 179875 RVA: 0x00C5441C File Offset: 0x00C5261C
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

		// Token: 0x04017AA2 RID: 96930
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<EDungeonSubType, EFunction[]> disableSettingsInstMap = new Dictionary<EDungeonSubType, EFunction[]>();

		// Token: 0x04017AA3 RID: 96931
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<EWorldDungeonSubType, EFunction[]> disableSettingsWorldInstMap;
	}
}

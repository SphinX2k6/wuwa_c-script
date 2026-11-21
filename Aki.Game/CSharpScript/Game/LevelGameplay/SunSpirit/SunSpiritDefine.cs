using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit
{
	// Token: 0x02005B4D RID: 23373
	public static class SunSpiritDefine
	{
		// Token: 0x060397D1 RID: 235473 RVA: 0x01022CDC File Offset: 0x01020EDC
		// Note: this type is marked as 'beforefieldinit'.
		static SunSpiritDefine()
		{
			Dictionary<ESunSpiritStateType, string> dictionary = new Dictionary<ESunSpiritStateType, string>();
			dictionary[ESunSpiritStateType.None] = "None";
			dictionary[ESunSpiritStateType.FlyingToGear] = "FlyingToGear";
			dictionary[ESunSpiritStateType.FlyingToPlayer] = "FlyingToPlayer";
			dictionary[ESunSpiritStateType.OccupiedByGear] = "OccupiedByGear";
			dictionary[ESunSpiritStateType.OccupiedByPlayer] = "OccupiedByPlayer";
			SunSpiritDefine.sunSpiritStateTypeToString = dictionary;
		}

		// Token: 0x0401E56E RID: 124270
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<ESunSpiritStateType, string> sunSpiritStateTypeToString;
	}
}

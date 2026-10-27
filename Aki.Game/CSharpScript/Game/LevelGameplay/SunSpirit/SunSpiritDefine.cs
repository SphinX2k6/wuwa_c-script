using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit
{
	// Token: 0x020069F0 RID: 27120
	public static class SunSpiritDefine
	{
		// Token: 0x06043788 RID: 276360 RVA: 0x0107E628 File Offset: 0x0107C828
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

		// Token: 0x0402337C RID: 144252
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<ESunSpiritStateType, string> sunSpiritStateTypeToString;
	}
}

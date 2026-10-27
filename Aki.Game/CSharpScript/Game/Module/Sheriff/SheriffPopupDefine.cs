using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C4C RID: 19532
	public static class SheriffPopupDefine
	{
		// Token: 0x06032802 RID: 206850 RVA: 0x00BC3410 File Offset: 0x00BC1610
		// Note: this type is marked as 'beforefieldinit'.
		static SheriffPopupDefine()
		{
			Dictionary<int, string> dictionary = new Dictionary<int, string>();
			dictionary[0] = "Sheriff_HudDesc_4";
			dictionary[1] = "Sheriff_HudDesc_5";
			SheriffPopupDefine.SheriffCriminalIdentityTxt = dictionary;
		}

		// Token: 0x0401AE2D RID: 110125
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyDictionary<int, string> SheriffCriminalIdentityTxt;
	}
}

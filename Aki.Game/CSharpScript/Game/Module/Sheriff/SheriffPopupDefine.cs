using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003BFD RID: 15357
	public static class SheriffPopupDefine
	{
		// Token: 0x060275B5 RID: 161205 RVA: 0x00B08028 File Offset: 0x00B06228
		// Note: this type is marked as 'beforefieldinit'.
		static SheriffPopupDefine()
		{
			Dictionary<int, string> dictionary = new Dictionary<int, string>();
			dictionary[0] = "Sheriff_HudDesc_4";
			dictionary[1] = "Sheriff_HudDesc_5";
			SheriffPopupDefine.SheriffCriminalIdentityTxt = dictionary;
		}

		// Token: 0x0401578A RID: 87946
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyDictionary<int, string> SheriffCriminalIdentityTxt;
	}
}

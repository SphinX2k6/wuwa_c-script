using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C4B RID: 19531
	public static class SheriffShopDefine
	{
		// Token: 0x06032801 RID: 206849 RVA: 0x00BC33E0 File Offset: 0x00BC15E0
		// Note: this type is marked as 'beforefieldinit'.
		static SheriffShopDefine()
		{
			Dictionary<int, string> dictionary = new Dictionary<int, string>();
			dictionary[1] = "Sheriff_Shop_3";
			dictionary[2] = "Sheriff_Shop_4";
			dictionary[3] = "Sheriff_Shop_5";
			SheriffShopDefine.SheriffShopTabMenuName = dictionary;
		}

		// Token: 0x0401AE2C RID: 110124
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyDictionary<int, string> SheriffShopTabMenuName;
	}
}

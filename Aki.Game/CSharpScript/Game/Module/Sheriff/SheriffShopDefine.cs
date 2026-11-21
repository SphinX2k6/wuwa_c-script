using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003BFC RID: 15356
	public static class SheriffShopDefine
	{
		// Token: 0x060275B4 RID: 161204 RVA: 0x00B07FF8 File Offset: 0x00B061F8
		// Note: this type is marked as 'beforefieldinit'.
		static SheriffShopDefine()
		{
			Dictionary<int, string> dictionary = new Dictionary<int, string>();
			dictionary[1] = "Sheriff_Shop_3";
			dictionary[2] = "Sheriff_Shop_4";
			dictionary[3] = "Sheriff_Shop_5";
			SheriffShopDefine.SheriffShopTabMenuName = dictionary;
		}

		// Token: 0x04015789 RID: 87945
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyDictionary<int, string> SheriffShopTabMenuName;
	}
}

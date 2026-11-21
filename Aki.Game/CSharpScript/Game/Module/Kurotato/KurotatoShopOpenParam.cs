using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046C3 RID: 18115
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoShopOpenParam : IKurotatoShopOpenParam
	{
		// Token: 0x17005BA1 RID: 23457
		// (get) Token: 0x0602D8A2 RID: 186530 RVA: 0x00CBEAE9 File Offset: 0x00CBCCE9
		// (set) Token: 0x0602D8A3 RID: 186531 RVA: 0x00CBEAF1 File Offset: 0x00CBCCF1
		public List<int> Items { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020056EC RID: 22252
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoShopOpenParam : IKurotatoShopOpenParam
	{
		// Token: 0x170087D9 RID: 34777
		// (get) Token: 0x06038992 RID: 231826 RVA: 0x00D70501 File Offset: 0x00D6E701
		// (set) Token: 0x06038993 RID: 231827 RVA: 0x00D70509 File Offset: 0x00D6E709
		public List<int> Items { get; set; }
	}
}

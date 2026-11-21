using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046EC RID: 18156
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoSaveViewOpenParam : IKurotatoSaveViewOpenParam
	{
		// Token: 0x17005C20 RID: 23584
		// (get) Token: 0x0602D9B0 RID: 186800 RVA: 0x00CBEF98 File Offset: 0x00CBD198
		// (set) Token: 0x0602D9B1 RID: 186801 RVA: 0x00CBEFA0 File Offset: 0x00CBD1A0
		public List<KurotatoInstInfo> InstInfos { get; set; }

		// Token: 0x17005C21 RID: 23585
		// (get) Token: 0x0602D9B2 RID: 186802 RVA: 0x00CBEFA9 File Offset: 0x00CBD1A9
		// (set) Token: 0x0602D9B3 RID: 186803 RVA: 0x00CBEFB1 File Offset: 0x00CBD1B1
		public int DefaultIndex { get; set; }
	}
}

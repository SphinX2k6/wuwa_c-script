using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x02005715 RID: 22293
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoSaveViewOpenParam : IKurotatoSaveViewOpenParam
	{
		// Token: 0x17008858 RID: 34904
		// (get) Token: 0x06038AA0 RID: 232096 RVA: 0x00D709B0 File Offset: 0x00D6EBB0
		// (set) Token: 0x06038AA1 RID: 232097 RVA: 0x00D709B8 File Offset: 0x00D6EBB8
		public List<KurotatoInstInfo> InstInfos { get; set; }

		// Token: 0x17008859 RID: 34905
		// (get) Token: 0x06038AA2 RID: 232098 RVA: 0x00D709C1 File Offset: 0x00D6EBC1
		// (set) Token: 0x06038AA3 RID: 232099 RVA: 0x00D709C9 File Offset: 0x00D6EBC9
		public int DefaultIndex { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x02005714 RID: 22292
	[NullableContext(1)]
	public interface IKurotatoSaveViewOpenParam
	{
		// Token: 0x17008856 RID: 34902
		// (get) Token: 0x06038A9C RID: 232092
		// (set) Token: 0x06038A9D RID: 232093
		List<KurotatoInstInfo> InstInfos { get; set; }

		// Token: 0x17008857 RID: 34903
		// (get) Token: 0x06038A9E RID: 232094
		// (set) Token: 0x06038A9F RID: 232095
		int DefaultIndex { get; set; }
	}
}

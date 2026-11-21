using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046EB RID: 18155
	[NullableContext(1)]
	public interface IKurotatoSaveViewOpenParam
	{
		// Token: 0x17005C1E RID: 23582
		// (get) Token: 0x0602D9AC RID: 186796
		// (set) Token: 0x0602D9AD RID: 186797
		List<KurotatoInstInfo> InstInfos { get; set; }

		// Token: 0x17005C1F RID: 23583
		// (get) Token: 0x0602D9AE RID: 186798
		// (set) Token: 0x0602D9AF RID: 186799
		int DefaultIndex { get; set; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x0200725C RID: 29276
	[NullableContext(1)]
	public interface IPlayCustomSequence
	{
		// Token: 0x17009E77 RID: 40567
		// (get) Token: 0x06047BD8 RID: 293848
		// (set) Token: 0x06047BD9 RID: 293849
		int CustomSeqId { get; set; }

		// Token: 0x17009E78 RID: 40568
		// (get) Token: 0x06047BDA RID: 293850
		// (set) Token: 0x06047BDB RID: 293851
		int[] WhoIds { get; set; }

		// Token: 0x17009E79 RID: 40569
		// (get) Token: 0x06047BDC RID: 293852
		// (set) Token: 0x06047BDD RID: 293853
		bool? ResetCamera { get; set; }
	}
}

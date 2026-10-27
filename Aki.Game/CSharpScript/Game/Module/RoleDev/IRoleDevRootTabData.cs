using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CB7 RID: 19639
	[NullableContext(1)]
	public interface IRoleDevRootTabData
	{
		// Token: 0x17007D15 RID: 32021
		// (get) Token: 0x06032B6C RID: 207724
		// (set) Token: 0x06032B6D RID: 207725
		ERoleDevTabType TabIndex { get; set; }

		// Token: 0x17007D16 RID: 32022
		// (get) Token: 0x06032B6E RID: 207726
		// (set) Token: 0x06032B6F RID: 207727
		string TabName { get; set; }

		// Token: 0x17007D17 RID: 32023
		// (get) Token: 0x06032B70 RID: 207728
		// (set) Token: 0x06032B71 RID: 207729
		bool TabIsUpgrade { get; set; }

		// Token: 0x17007D18 RID: 32024
		// (get) Token: 0x06032B72 RID: 207730
		// (set) Token: 0x06032B73 RID: 207731
		bool TabIsFinish { get; set; }
	}
}

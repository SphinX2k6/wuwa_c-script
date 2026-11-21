using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C68 RID: 15464
	[NullableContext(1)]
	public interface IRoleDevRootTabData
	{
		// Token: 0x170050BF RID: 20671
		// (get) Token: 0x06027920 RID: 162080
		// (set) Token: 0x06027921 RID: 162081
		ERoleDevTabType TabIndex { get; set; }

		// Token: 0x170050C0 RID: 20672
		// (get) Token: 0x06027922 RID: 162082
		// (set) Token: 0x06027923 RID: 162083
		string TabName { get; set; }

		// Token: 0x170050C1 RID: 20673
		// (get) Token: 0x06027924 RID: 162084
		// (set) Token: 0x06027925 RID: 162085
		bool TabIsUpgrade { get; set; }

		// Token: 0x170050C2 RID: 20674
		// (get) Token: 0x06027926 RID: 162086
		// (set) Token: 0x06027927 RID: 162087
		bool TabIsFinish { get; set; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CB8 RID: 19640
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevRootTabData : IRoleDevRootTabData
	{
		// Token: 0x17007D19 RID: 32025
		// (get) Token: 0x06032B74 RID: 207732 RVA: 0x00BD50A5 File Offset: 0x00BD32A5
		// (set) Token: 0x06032B75 RID: 207733 RVA: 0x00BD50AD File Offset: 0x00BD32AD
		public ERoleDevTabType TabIndex { get; set; }

		// Token: 0x17007D1A RID: 32026
		// (get) Token: 0x06032B76 RID: 207734 RVA: 0x00BD50B6 File Offset: 0x00BD32B6
		// (set) Token: 0x06032B77 RID: 207735 RVA: 0x00BD50BE File Offset: 0x00BD32BE
		public string TabName { get; set; }

		// Token: 0x17007D1B RID: 32027
		// (get) Token: 0x06032B78 RID: 207736 RVA: 0x00BD50C7 File Offset: 0x00BD32C7
		// (set) Token: 0x06032B79 RID: 207737 RVA: 0x00BD50CF File Offset: 0x00BD32CF
		public bool TabIsUpgrade { get; set; }

		// Token: 0x17007D1C RID: 32028
		// (get) Token: 0x06032B7A RID: 207738 RVA: 0x00BD50D8 File Offset: 0x00BD32D8
		// (set) Token: 0x06032B7B RID: 207739 RVA: 0x00BD50E0 File Offset: 0x00BD32E0
		public bool TabIsFinish { get; set; }
	}
}

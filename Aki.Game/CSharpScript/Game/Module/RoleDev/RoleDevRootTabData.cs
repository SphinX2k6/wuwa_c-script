using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C69 RID: 15465
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevRootTabData : IRoleDevRootTabData
	{
		// Token: 0x170050C3 RID: 20675
		// (get) Token: 0x06027928 RID: 162088 RVA: 0x00B19E3D File Offset: 0x00B1803D
		// (set) Token: 0x06027929 RID: 162089 RVA: 0x00B19E45 File Offset: 0x00B18045
		public ERoleDevTabType TabIndex { get; set; }

		// Token: 0x170050C4 RID: 20676
		// (get) Token: 0x0602792A RID: 162090 RVA: 0x00B19E4E File Offset: 0x00B1804E
		// (set) Token: 0x0602792B RID: 162091 RVA: 0x00B19E56 File Offset: 0x00B18056
		public string TabName { get; set; }

		// Token: 0x170050C5 RID: 20677
		// (get) Token: 0x0602792C RID: 162092 RVA: 0x00B19E5F File Offset: 0x00B1805F
		// (set) Token: 0x0602792D RID: 162093 RVA: 0x00B19E67 File Offset: 0x00B18067
		public bool TabIsUpgrade { get; set; }

		// Token: 0x170050C6 RID: 20678
		// (get) Token: 0x0602792E RID: 162094 RVA: 0x00B19E70 File Offset: 0x00B18070
		// (set) Token: 0x0602792F RID: 162095 RVA: 0x00B19E78 File Offset: 0x00B18078
		public bool TabIsFinish { get; set; }
	}
}

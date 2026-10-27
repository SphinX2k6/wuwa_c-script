using System;
using System.Runtime.CompilerServices;

// Token: 0x0200142A RID: 5162
[NullableContext(2)]
[Nullable(0)]
public class PinballRoleViewOpenParam : IPinballRoleViewOpenParam
{
	// Token: 0x17000CB0 RID: 3248
	// (get) Token: 0x060091AD RID: 37293 RVA: 0x001F3026 File Offset: 0x001F1226
	// (set) Token: 0x060091AE RID: 37294 RVA: 0x001F302E File Offset: 0x001F122E
	public int? RoleId { get; set; }

	// Token: 0x17000CB1 RID: 3249
	// (get) Token: 0x060091AF RID: 37295 RVA: 0x001F3037 File Offset: 0x001F1237
	// (set) Token: 0x060091B0 RID: 37296 RVA: 0x001F303F File Offset: 0x001F123F
	public int[] FormationRoleIds { get; set; }
}

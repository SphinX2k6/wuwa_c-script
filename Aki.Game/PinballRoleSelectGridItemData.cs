using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020008E0 RID: 2272
[NullableContext(1)]
[Nullable(0)]
public class PinballRoleSelectGridItemData : IPinballRoleSelectGridItemData
{
	// Token: 0x17000CD7 RID: 3287
	// (get) Token: 0x06006552 RID: 25938 RVA: 0x001FBBE9 File Offset: 0x001F9DE9
	// (set) Token: 0x06006553 RID: 25939 RVA: 0x001FBBF1 File Offset: 0x001F9DF1
	public PinballRoleDataBase RoleData { get; set; }

	// Token: 0x17000CD8 RID: 3288
	// (get) Token: 0x06006554 RID: 25940 RVA: 0x001FBBFA File Offset: 0x001F9DFA
	// (set) Token: 0x06006555 RID: 25941 RVA: 0x001FBC02 File Offset: 0x001F9E02
	public IPinballItemDataRole ItemData { get; set; }

	// Token: 0x17000CD9 RID: 3289
	// (get) Token: 0x06006556 RID: 25942 RVA: 0x001FBC0B File Offset: 0x001F9E0B
	// (set) Token: 0x06006557 RID: 25943 RVA: 0x001FBC13 File Offset: 0x001F9E13
	public List<int> ClassIdList { get; set; }

	// Token: 0x17000CDA RID: 3290
	// (get) Token: 0x06006558 RID: 25944 RVA: 0x001FBC1C File Offset: 0x001F9E1C
	// (set) Token: 0x06006559 RID: 25945 RVA: 0x001FBC24 File Offset: 0x001F9E24
	public bool IsSelected { get; set; }

	// Token: 0x17000CDB RID: 3291
	// (get) Token: 0x0600655A RID: 25946 RVA: 0x001FBC2D File Offset: 0x001F9E2D
	// (set) Token: 0x0600655B RID: 25947 RVA: 0x001FBC35 File Offset: 0x001F9E35
	public int FormationIndex { get; set; }
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200142C RID: 5164
[NullableContext(1)]
[Nullable(0)]
public class PinballRoleSelectGridItemData : IPinballRoleSelectGridItemData
{
	// Token: 0x17000CB7 RID: 3255
	// (get) Token: 0x060091BD RID: 37309 RVA: 0x001F30AD File Offset: 0x001F12AD
	// (set) Token: 0x060091BE RID: 37310 RVA: 0x001F30B5 File Offset: 0x001F12B5
	public PinballRoleDataBase RoleData { get; set; }

	// Token: 0x17000CB8 RID: 3256
	// (get) Token: 0x060091BF RID: 37311 RVA: 0x001F30BE File Offset: 0x001F12BE
	// (set) Token: 0x060091C0 RID: 37312 RVA: 0x001F30C6 File Offset: 0x001F12C6
	public IPinballItemDataRole ItemData { get; set; }

	// Token: 0x17000CB9 RID: 3257
	// (get) Token: 0x060091C1 RID: 37313 RVA: 0x001F30CF File Offset: 0x001F12CF
	// (set) Token: 0x060091C2 RID: 37314 RVA: 0x001F30D7 File Offset: 0x001F12D7
	public List<int> ClassIdList { get; set; }

	// Token: 0x17000CBA RID: 3258
	// (get) Token: 0x060091C3 RID: 37315 RVA: 0x001F30E0 File Offset: 0x001F12E0
	// (set) Token: 0x060091C4 RID: 37316 RVA: 0x001F30E8 File Offset: 0x001F12E8
	public bool IsSelected { get; set; }

	// Token: 0x17000CBB RID: 3259
	// (get) Token: 0x060091C5 RID: 37317 RVA: 0x001F30F1 File Offset: 0x001F12F1
	// (set) Token: 0x060091C6 RID: 37318 RVA: 0x001F30F9 File Offset: 0x001F12F9
	public int FormationIndex { get; set; }
}

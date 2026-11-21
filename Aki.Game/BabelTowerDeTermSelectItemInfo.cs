using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020005E7 RID: 1511
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerDeTermSelectItemInfo : IBabelTowerDeTermSelectItemInfo
{
	// Token: 0x170009FF RID: 2559
	// (get) Token: 0x06004729 RID: 18217 RVA: 0x001845AE File Offset: 0x001827AE
	// (set) Token: 0x0600472A RID: 18218 RVA: 0x001845B6 File Offset: 0x001827B6
	public bool IsNecessary { get; set; }

	// Token: 0x17000A00 RID: 2560
	// (get) Token: 0x0600472B RID: 18219 RVA: 0x001845BF File Offset: 0x001827BF
	// (set) Token: 0x0600472C RID: 18220 RVA: 0x001845C7 File Offset: 0x001827C7
	public List<int> AllDeTerm { get; set; }

	// Token: 0x17000A01 RID: 2561
	// (get) Token: 0x0600472D RID: 18221 RVA: 0x001845D0 File Offset: 0x001827D0
	// (set) Token: 0x0600472E RID: 18222 RVA: 0x001845D8 File Offset: 0x001827D8
	public List<int> DailyDeTerm { get; set; }

	// Token: 0x17000A02 RID: 2562
	// (get) Token: 0x0600472F RID: 18223 RVA: 0x001845E1 File Offset: 0x001827E1
	// (set) Token: 0x06004730 RID: 18224 RVA: 0x001845E9 File Offset: 0x001827E9
	public Action<int> OnChangeSelectDeTerm { get; set; }
}

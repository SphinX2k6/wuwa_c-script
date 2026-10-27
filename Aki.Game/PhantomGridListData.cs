using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002464 RID: 9316
[NullableContext(1)]
[Nullable(0)]
public class PhantomGridListData : IPhantomGridListData
{
	// Token: 0x1700185A RID: 6234
	// (get) Token: 0x06012B16 RID: 76566 RVA: 0x0049D626 File Offset: 0x0049B826
	// (set) Token: 0x06012B17 RID: 76567 RVA: 0x0049D62E File Offset: 0x0049B82E
	public EGridTitleType TitleType { get; set; }

	// Token: 0x1700185B RID: 6235
	// (get) Token: 0x06012B18 RID: 76568 RVA: 0x0049D637 File Offset: 0x0049B837
	// (set) Token: 0x06012B19 RID: 76569 RVA: 0x0049D63F File Offset: 0x0049B83F
	public List<int> MonsterIds { get; set; } = new List<int>();
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x020012D3 RID: 4819
[NullableContext(1)]
[Nullable(0)]
public class MapTravelViewProxy : IMapTravelViewProxy
{
	// Token: 0x17000B58 RID: 2904
	// (get) Token: 0x060084D2 RID: 34002 RVA: 0x001C46B3 File Offset: 0x001C28B3
	// (set) Token: 0x060084D3 RID: 34003 RVA: 0x001C46BB File Offset: 0x001C28BB
	public IMapTravelSubViewInterface UiProxy { get; set; }

	// Token: 0x17000B59 RID: 2905
	// (get) Token: 0x060084D4 RID: 34004 RVA: 0x001C46C4 File Offset: 0x001C28C4
	// (set) Token: 0x060084D5 RID: 34005 RVA: 0x001C46CC File Offset: 0x001C28CC
	public EMapTravelSubType Type { get; set; }

	// Token: 0x17000B5A RID: 2906
	// (get) Token: 0x060084D6 RID: 34006 RVA: 0x001C46D5 File Offset: 0x001C28D5
	// (set) Token: 0x060084D7 RID: 34007 RVA: 0x001C46DD File Offset: 0x001C28DD
	public string SpineSkinName { get; set; }
}

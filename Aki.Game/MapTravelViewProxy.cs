using System;
using System.Runtime.CompilerServices;

// Token: 0x02000787 RID: 1927
[NullableContext(1)]
[Nullable(0)]
public class MapTravelViewProxy : IMapTravelViewProxy
{
	// Token: 0x17000B78 RID: 2936
	// (get) Token: 0x0600586D RID: 22637 RVA: 0x001CD50F File Offset: 0x001CB70F
	// (set) Token: 0x0600586E RID: 22638 RVA: 0x001CD517 File Offset: 0x001CB717
	public IMapTravelSubViewInterface UiProxy { get; set; }

	// Token: 0x17000B79 RID: 2937
	// (get) Token: 0x0600586F RID: 22639 RVA: 0x001CD520 File Offset: 0x001CB720
	// (set) Token: 0x06005870 RID: 22640 RVA: 0x001CD528 File Offset: 0x001CB728
	public EMapTravelSubType Type { get; set; }

	// Token: 0x17000B7A RID: 2938
	// (get) Token: 0x06005871 RID: 22641 RVA: 0x001CD531 File Offset: 0x001CB731
	// (set) Token: 0x06005872 RID: 22642 RVA: 0x001CD539 File Offset: 0x001CB739
	public string SpineSkinName { get; set; }
}

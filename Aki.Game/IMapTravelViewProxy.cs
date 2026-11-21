using System;
using System.Runtime.CompilerServices;

// Token: 0x02000786 RID: 1926
[NullableContext(1)]
public interface IMapTravelViewProxy
{
	// Token: 0x17000B75 RID: 2933
	// (get) Token: 0x06005867 RID: 22631
	// (set) Token: 0x06005868 RID: 22632
	IMapTravelSubViewInterface UiProxy { get; set; }

	// Token: 0x17000B76 RID: 2934
	// (get) Token: 0x06005869 RID: 22633
	// (set) Token: 0x0600586A RID: 22634
	EMapTravelSubType Type { get; set; }

	// Token: 0x17000B77 RID: 2935
	// (get) Token: 0x0600586B RID: 22635
	// (set) Token: 0x0600586C RID: 22636
	string SpineSkinName { get; set; }
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x020012D2 RID: 4818
[NullableContext(1)]
public interface IMapTravelViewProxy
{
	// Token: 0x17000B55 RID: 2901
	// (get) Token: 0x060084CC RID: 33996
	// (set) Token: 0x060084CD RID: 33997
	IMapTravelSubViewInterface UiProxy { get; set; }

	// Token: 0x17000B56 RID: 2902
	// (get) Token: 0x060084CE RID: 33998
	// (set) Token: 0x060084CF RID: 33999
	EMapTravelSubType Type { get; set; }

	// Token: 0x17000B57 RID: 2903
	// (get) Token: 0x060084D0 RID: 34000
	// (set) Token: 0x060084D1 RID: 34001
	string SpineSkinName { get; set; }
}

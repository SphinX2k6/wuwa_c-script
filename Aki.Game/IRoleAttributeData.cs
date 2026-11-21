using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D3D RID: 7485
[NullableContext(1)]
public interface IRoleAttributeData
{
	// Token: 0x17001B89 RID: 7049
	// (get) Token: 0x060128F1 RID: 76017
	// (set) Token: 0x060128F2 RID: 76018
	string Name { get; set; }

	// Token: 0x17001B8A RID: 7050
	// (get) Token: 0x060128F3 RID: 76019
	// (set) Token: 0x060128F4 RID: 76020
	int Level { get; set; }

	// Token: 0x17001B8B RID: 7051
	// (get) Token: 0x060128F5 RID: 76021
	// (set) Token: 0x060128F6 RID: 76022
	int BreakLevel { get; set; }

	// Token: 0x17001B8C RID: 7052
	// (get) Token: 0x060128F7 RID: 76023
	// (set) Token: 0x060128F8 RID: 76024
	int Exp { get; set; }
}

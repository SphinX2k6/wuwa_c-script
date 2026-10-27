using System;
using System.Runtime.CompilerServices;

// Token: 0x02002089 RID: 8329
[NullableContext(1)]
public interface ILoginInfo
{
	// Token: 0x1700143E RID: 5182
	// (get) Token: 0x06010647 RID: 67143
	// (set) Token: 0x06010648 RID: 67144
	int LoginCode { get; set; }

	// Token: 0x1700143F RID: 5183
	// (get) Token: 0x06010649 RID: 67145
	// (set) Token: 0x0601064A RID: 67146
	string Uid { get; set; }

	// Token: 0x17001440 RID: 5184
	// (get) Token: 0x0601064B RID: 67147
	// (set) Token: 0x0601064C RID: 67148
	string UserName { get; set; }

	// Token: 0x17001441 RID: 5185
	// (get) Token: 0x0601064D RID: 67149
	// (set) Token: 0x0601064E RID: 67150
	string Token { get; set; }
}

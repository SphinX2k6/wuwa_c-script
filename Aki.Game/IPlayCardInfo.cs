using System;
using System.Runtime.CompilerServices;

// Token: 0x0200050D RID: 1293
[NullableContext(1)]
public interface IPlayCardInfo
{
	// Token: 0x170008C9 RID: 2249
	// (get) Token: 0x06003EC7 RID: 16071
	// (set) Token: 0x06003EC8 RID: 16072
	int Value { get; set; }

	// Token: 0x170008CA RID: 2250
	// (get) Token: 0x06003EC9 RID: 16073
	// (set) Token: 0x06003ECA RID: 16074
	int[] CardIdList { get; set; }
}

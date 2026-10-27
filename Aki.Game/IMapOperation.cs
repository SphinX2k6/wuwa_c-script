using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x020021E6 RID: 8678
[NullableContext(1)]
public interface IMapOperation
{
	// Token: 0x17001562 RID: 5474
	// (get) Token: 0x06010E3C RID: 69180
	// (set) Token: 0x06010E3D RID: 69181
	[Nullable(2)]
	string OpName { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17001563 RID: 5475
	// (get) Token: 0x06010E3E RID: 69182
	EMapOperationType Type { get; }

	// Token: 0x17001564 RID: 5476
	// (get) Token: 0x06010E3F RID: 69183
	Func<bool> IsValidate { get; }

	// Token: 0x17001565 RID: 5477
	// (get) Token: 0x06010E40 RID: 69184
	Func<UniTask> Execute { get; }
}

using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x02002AA9 RID: 10921
[NullableContext(1)]
public interface IGraphNode
{
	// Token: 0x17002CFE RID: 11518
	// (get) Token: 0x0601BC04 RID: 113668
	// (set) Token: 0x0601BC05 RID: 113669
	Func<UniTask> Run { get; set; }

	// Token: 0x17002CFF RID: 11519
	// (get) Token: 0x0601BC06 RID: 113670
	// (set) Token: 0x0601BC07 RID: 113671
	int? Priority { get; set; }
}

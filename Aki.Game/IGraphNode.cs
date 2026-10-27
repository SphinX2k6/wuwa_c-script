using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x02003534 RID: 13620
[NullableContext(1)]
public interface IGraphNode
{
	// Token: 0x17002965 RID: 10597
	// (get) Token: 0x0601DEDC RID: 122588
	// (set) Token: 0x0601DEDD RID: 122589
	Func<UniTask> Run { get; set; }

	// Token: 0x17002966 RID: 10598
	// (get) Token: 0x0601DEDE RID: 122590
	// (set) Token: 0x0601DEDF RID: 122591
	int? Priority { get; set; }
}

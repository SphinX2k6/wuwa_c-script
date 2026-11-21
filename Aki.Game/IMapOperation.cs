using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x020016CA RID: 5834
[NullableContext(1)]
public interface IMapOperation
{
	// Token: 0x17001599 RID: 5529
	// (get) Token: 0x0600E2CD RID: 58061
	// (set) Token: 0x0600E2CE RID: 58062
	[Nullable(2)]
	string OpName { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x1700159A RID: 5530
	// (get) Token: 0x0600E2CF RID: 58063
	EMapOperationType Type { get; }

	// Token: 0x1700159B RID: 5531
	// (get) Token: 0x0600E2D0 RID: 58064
	Func<bool> IsValidate { get; }

	// Token: 0x1700159C RID: 5532
	// (get) Token: 0x0600E2D1 RID: 58065
	Func<UniTask> Execute { get; }
}

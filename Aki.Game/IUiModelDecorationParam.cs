using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002C71 RID: 11377
[NullableContext(1)]
public interface IUiModelDecorationParam
{
	// Token: 0x17001FE5 RID: 8165
	// (get) Token: 0x06017C38 RID: 97336
	// (set) Token: 0x06017C39 RID: 97337
	string SocketName { get; set; }

	// Token: 0x17001FE6 RID: 8166
	// (get) Token: 0x06017C3A RID: 97338
	// (set) Token: 0x06017C3B RID: 97339
	USkeletalMesh SkeletalMesh { get; set; }

	// Token: 0x17001FE7 RID: 8167
	// (get) Token: 0x06017C3C RID: 97340
	// (set) Token: 0x06017C3D RID: 97341
	FTransform Transform { get; set; }
}

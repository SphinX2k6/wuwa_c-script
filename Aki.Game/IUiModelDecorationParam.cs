using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020021CA RID: 8650
[NullableContext(1)]
public interface IUiModelDecorationParam
{
	// Token: 0x17002036 RID: 8246
	// (get) Token: 0x060154AA RID: 87210
	// (set) Token: 0x060154AB RID: 87211
	string SocketName { get; set; }

	// Token: 0x17002037 RID: 8247
	// (get) Token: 0x060154AC RID: 87212
	// (set) Token: 0x060154AD RID: 87213
	USkeletalMesh SkeletalMesh { get; set; }

	// Token: 0x17002038 RID: 8248
	// (get) Token: 0x060154AE RID: 87214
	// (set) Token: 0x060154AF RID: 87215
	FTransform Transform { get; set; }
}

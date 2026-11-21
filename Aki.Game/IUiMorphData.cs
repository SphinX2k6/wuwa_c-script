using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020021E6 RID: 8678
[NullableContext(2)]
public interface IUiMorphData
{
	// Token: 0x1700205F RID: 8287
	// (get) Token: 0x060155C6 RID: 87494
	// (set) Token: 0x060155C7 RID: 87495
	USkeletalMesh MainSkeletalMesh { get; set; }

	// Token: 0x17002060 RID: 8288
	// (get) Token: 0x060155C8 RID: 87496
	// (set) Token: 0x060155C9 RID: 87497
	[Nullable(new byte[]
	{
		2,
		1
	})]
	List<USkeletalMesh> ChildSkeletalMesh { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17002061 RID: 8289
	// (get) Token: 0x060155CA RID: 87498
	// (set) Token: 0x060155CB RID: 87499
	[Nullable(1)]
	List<UiModelDecorationParam> DecorationParamList { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17002062 RID: 8290
	// (get) Token: 0x060155CC RID: 87500
	// (set) Token: 0x060155CD RID: 87501
	UClass AnimClass { get; set; }

	// Token: 0x17002063 RID: 8291
	// (get) Token: 0x060155CE RID: 87502
	// (set) Token: 0x060155CF RID: 87503
	string RoleBody { get; set; }
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002C8D RID: 11405
[NullableContext(2)]
public interface IUiMorphData
{
	// Token: 0x1700200E RID: 8206
	// (get) Token: 0x06017D52 RID: 97618
	// (set) Token: 0x06017D53 RID: 97619
	USkeletalMesh MainSkeletalMesh { get; set; }

	// Token: 0x1700200F RID: 8207
	// (get) Token: 0x06017D54 RID: 97620
	// (set) Token: 0x06017D55 RID: 97621
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

	// Token: 0x17002010 RID: 8208
	// (get) Token: 0x06017D56 RID: 97622
	// (set) Token: 0x06017D57 RID: 97623
	[Nullable(1)]
	List<UiModelDecorationParam> DecorationParamList { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17002011 RID: 8209
	// (get) Token: 0x06017D58 RID: 97624
	// (set) Token: 0x06017D59 RID: 97625
	UClass AnimClass { get; set; }

	// Token: 0x17002012 RID: 8210
	// (get) Token: 0x06017D5A RID: 97626
	// (set) Token: 0x06017D5B RID: 97627
	string RoleBody { get; set; }
}

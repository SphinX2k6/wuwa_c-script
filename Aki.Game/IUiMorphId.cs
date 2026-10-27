using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Entity.Struct;
using UnrealEngine;

// Token: 0x02002C8F RID: 11407
[NullableContext(2)]
public interface IUiMorphId
{
	// Token: 0x17002018 RID: 8216
	// (get) Token: 0x06017D67 RID: 97639
	// (set) Token: 0x06017D68 RID: 97640
	string MainMeshPath { get; set; }

	// Token: 0x17002019 RID: 8217
	// (get) Token: 0x06017D69 RID: 97641
	// (set) Token: 0x06017D6A RID: 97642
	string AnimPath { get; set; }

	// Token: 0x1700201A RID: 8218
	// (get) Token: 0x06017D6B RID: 97643
	// (set) Token: 0x06017D6C RID: 97644
	[Nullable(new byte[]
	{
		2,
		1
	})]
	List<string> ChildMeshPathList { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x1700201B RID: 8219
	// (get) Token: 0x06017D6D RID: 97645
	// (set) Token: 0x06017D6E RID: 97646
	[Nullable(1)]
	TArray<SModelDecorationConfig> DecorationMeshConfigArray { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x1700201C RID: 8220
	// (get) Token: 0x06017D6F RID: 97647
	// (set) Token: 0x06017D70 RID: 97648
	string RoleBody { get; set; }
}

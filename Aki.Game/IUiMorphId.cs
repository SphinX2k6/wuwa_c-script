using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Entity.Struct;
using UnrealEngine;

// Token: 0x020021E8 RID: 8680
[NullableContext(2)]
public interface IUiMorphId
{
	// Token: 0x17002069 RID: 8297
	// (get) Token: 0x060155DB RID: 87515
	// (set) Token: 0x060155DC RID: 87516
	string MainMeshPath { get; set; }

	// Token: 0x1700206A RID: 8298
	// (get) Token: 0x060155DD RID: 87517
	// (set) Token: 0x060155DE RID: 87518
	string AnimPath { get; set; }

	// Token: 0x1700206B RID: 8299
	// (get) Token: 0x060155DF RID: 87519
	// (set) Token: 0x060155E0 RID: 87520
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

	// Token: 0x1700206C RID: 8300
	// (get) Token: 0x060155E1 RID: 87521
	// (set) Token: 0x060155E2 RID: 87522
	[Nullable(1)]
	TArray<SModelDecorationConfig> DecorationMeshConfigArray { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x1700206D RID: 8301
	// (get) Token: 0x060155E3 RID: 87523
	// (set) Token: 0x060155E4 RID: 87524
	string RoleBody { get; set; }
}

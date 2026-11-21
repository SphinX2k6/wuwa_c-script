using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020021E7 RID: 8679
[NullableContext(2)]
[Nullable(0)]
public class UiMorphData : IUiMorphData
{
	// Token: 0x17002064 RID: 8292
	// (get) Token: 0x060155D0 RID: 87504 RVA: 0x00636137 File Offset: 0x00634337
	// (set) Token: 0x060155D1 RID: 87505 RVA: 0x0063613F File Offset: 0x0063433F
	public USkeletalMesh MainSkeletalMesh { get; set; }

	// Token: 0x17002065 RID: 8293
	// (get) Token: 0x060155D2 RID: 87506 RVA: 0x00636148 File Offset: 0x00634348
	// (set) Token: 0x060155D3 RID: 87507 RVA: 0x00636150 File Offset: 0x00634350
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<USkeletalMesh> ChildSkeletalMesh { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17002066 RID: 8294
	// (get) Token: 0x060155D4 RID: 87508 RVA: 0x00636159 File Offset: 0x00634359
	// (set) Token: 0x060155D5 RID: 87509 RVA: 0x00636161 File Offset: 0x00634361
	[Nullable(1)]
	public List<UiModelDecorationParam> DecorationParamList { [NullableContext(1)] get; [NullableContext(1)] set; } = new List<UiModelDecorationParam>();

	// Token: 0x17002067 RID: 8295
	// (get) Token: 0x060155D6 RID: 87510 RVA: 0x0063616A File Offset: 0x0063436A
	// (set) Token: 0x060155D7 RID: 87511 RVA: 0x00636172 File Offset: 0x00634372
	public UClass AnimClass { get; set; }

	// Token: 0x17002068 RID: 8296
	// (get) Token: 0x060155D8 RID: 87512 RVA: 0x0063617B File Offset: 0x0063437B
	// (set) Token: 0x060155D9 RID: 87513 RVA: 0x00636183 File Offset: 0x00634383
	public string RoleBody { get; set; }
}

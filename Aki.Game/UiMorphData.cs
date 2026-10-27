using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002C8E RID: 11406
[NullableContext(2)]
[Nullable(0)]
public class UiMorphData : IUiMorphData
{
	// Token: 0x17002013 RID: 8211
	// (get) Token: 0x06017D5C RID: 97628 RVA: 0x00610597 File Offset: 0x0060E797
	// (set) Token: 0x06017D5D RID: 97629 RVA: 0x0061059F File Offset: 0x0060E79F
	public USkeletalMesh MainSkeletalMesh { get; set; }

	// Token: 0x17002014 RID: 8212
	// (get) Token: 0x06017D5E RID: 97630 RVA: 0x006105A8 File Offset: 0x0060E7A8
	// (set) Token: 0x06017D5F RID: 97631 RVA: 0x006105B0 File Offset: 0x0060E7B0
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

	// Token: 0x17002015 RID: 8213
	// (get) Token: 0x06017D60 RID: 97632 RVA: 0x006105B9 File Offset: 0x0060E7B9
	// (set) Token: 0x06017D61 RID: 97633 RVA: 0x006105C1 File Offset: 0x0060E7C1
	[Nullable(1)]
	public List<UiModelDecorationParam> DecorationParamList { [NullableContext(1)] get; [NullableContext(1)] set; } = new List<UiModelDecorationParam>();

	// Token: 0x17002016 RID: 8214
	// (get) Token: 0x06017D62 RID: 97634 RVA: 0x006105CA File Offset: 0x0060E7CA
	// (set) Token: 0x06017D63 RID: 97635 RVA: 0x006105D2 File Offset: 0x0060E7D2
	public UClass AnimClass { get; set; }

	// Token: 0x17002017 RID: 8215
	// (get) Token: 0x06017D64 RID: 97636 RVA: 0x006105DB File Offset: 0x0060E7DB
	// (set) Token: 0x06017D65 RID: 97637 RVA: 0x006105E3 File Offset: 0x0060E7E3
	public string RoleBody { get; set; }
}

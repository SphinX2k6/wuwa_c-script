using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Entity.Struct;
using UnrealEngine;

// Token: 0x020021E9 RID: 8681
[NullableContext(2)]
[Nullable(0)]
public class UiMorphId : IUiMorphId
{
	// Token: 0x1700206E RID: 8302
	// (get) Token: 0x060155E5 RID: 87525 RVA: 0x0063619F File Offset: 0x0063439F
	// (set) Token: 0x060155E6 RID: 87526 RVA: 0x006361A7 File Offset: 0x006343A7
	public string MainMeshPath { get; set; }

	// Token: 0x1700206F RID: 8303
	// (get) Token: 0x060155E7 RID: 87527 RVA: 0x006361B0 File Offset: 0x006343B0
	// (set) Token: 0x060155E8 RID: 87528 RVA: 0x006361B8 File Offset: 0x006343B8
	public string AnimPath { get; set; }

	// Token: 0x17002070 RID: 8304
	// (get) Token: 0x060155E9 RID: 87529 RVA: 0x006361C1 File Offset: 0x006343C1
	// (set) Token: 0x060155EA RID: 87530 RVA: 0x006361C9 File Offset: 0x006343C9
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> ChildMeshPathList { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17002071 RID: 8305
	// (get) Token: 0x060155EB RID: 87531 RVA: 0x006361D2 File Offset: 0x006343D2
	// (set) Token: 0x060155EC RID: 87532 RVA: 0x006361DA File Offset: 0x006343DA
	[Nullable(1)]
	public TArray<SModelDecorationConfig> DecorationMeshConfigArray { [NullableContext(1)] get; [NullableContext(1)] set; } = new TArray<SModelDecorationConfig>();

	// Token: 0x17002072 RID: 8306
	// (get) Token: 0x060155ED RID: 87533 RVA: 0x006361E3 File Offset: 0x006343E3
	// (set) Token: 0x060155EE RID: 87534 RVA: 0x006361EB File Offset: 0x006343EB
	public string RoleBody { get; set; }
}

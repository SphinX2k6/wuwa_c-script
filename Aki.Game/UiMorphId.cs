using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Entity.Struct;
using UnrealEngine;

// Token: 0x02002C90 RID: 11408
[NullableContext(2)]
[Nullable(0)]
public class UiMorphId : IUiMorphId
{
	// Token: 0x1700201D RID: 8221
	// (get) Token: 0x06017D71 RID: 97649 RVA: 0x006105FF File Offset: 0x0060E7FF
	// (set) Token: 0x06017D72 RID: 97650 RVA: 0x00610607 File Offset: 0x0060E807
	public string MainMeshPath { get; set; }

	// Token: 0x1700201E RID: 8222
	// (get) Token: 0x06017D73 RID: 97651 RVA: 0x00610610 File Offset: 0x0060E810
	// (set) Token: 0x06017D74 RID: 97652 RVA: 0x00610618 File Offset: 0x0060E818
	public string AnimPath { get; set; }

	// Token: 0x1700201F RID: 8223
	// (get) Token: 0x06017D75 RID: 97653 RVA: 0x00610621 File Offset: 0x0060E821
	// (set) Token: 0x06017D76 RID: 97654 RVA: 0x00610629 File Offset: 0x0060E829
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

	// Token: 0x17002020 RID: 8224
	// (get) Token: 0x06017D77 RID: 97655 RVA: 0x00610632 File Offset: 0x0060E832
	// (set) Token: 0x06017D78 RID: 97656 RVA: 0x0061063A File Offset: 0x0060E83A
	[Nullable(1)]
	public TArray<SModelDecorationConfig> DecorationMeshConfigArray { [NullableContext(1)] get; [NullableContext(1)] set; } = new TArray<SModelDecorationConfig>();

	// Token: 0x17002021 RID: 8225
	// (get) Token: 0x06017D79 RID: 97657 RVA: 0x00610643 File Offset: 0x0060E843
	// (set) Token: 0x06017D7A RID: 97658 RVA: 0x0061064B File Offset: 0x0060E84B
	public string RoleBody { get; set; }
}

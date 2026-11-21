using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C5B RID: 19547
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiHoverTipsD : IBattleUiHoverTipsD
	{
		// Token: 0x1700619D RID: 24989
		// (get) Token: 0x06030C70 RID: 199792 RVA: 0x00D9AC08 File Offset: 0x00D98E08
		// (set) Token: 0x06030C71 RID: 199793 RVA: 0x00D9AC10 File Offset: 0x00D98E10
		public string TitleKey { get; set; }

		// Token: 0x1700619E RID: 24990
		// (get) Token: 0x06030C72 RID: 199794 RVA: 0x00D9AC19 File Offset: 0x00D98E19
		// (set) Token: 0x06030C73 RID: 199795 RVA: 0x00D9AC21 File Offset: 0x00D98E21
		public FColor? TitleColor { get; set; }

		// Token: 0x1700619F RID: 24991
		// (get) Token: 0x06030C74 RID: 199796 RVA: 0x00D9AC2A File Offset: 0x00D98E2A
		// (set) Token: 0x06030C75 RID: 199797 RVA: 0x00D9AC32 File Offset: 0x00D98E32
		[Nullable(2)]
		public string SubTitleKey { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170061A0 RID: 24992
		// (get) Token: 0x06030C76 RID: 199798 RVA: 0x00D9AC3B File Offset: 0x00D98E3B
		// (set) Token: 0x06030C77 RID: 199799 RVA: 0x00D9AC43 File Offset: 0x00D98E43
		public IMediumItemGridBase ItemInfo { get; set; }

		// Token: 0x170061A1 RID: 24993
		// (get) Token: 0x06030C78 RID: 199800 RVA: 0x00D9AC4C File Offset: 0x00D98E4C
		// (set) Token: 0x06030C79 RID: 199801 RVA: 0x00D9AC54 File Offset: 0x00D98E54
		public List<IBattleUiHoverTipsDescInfo> DescInfoList { get; set; }

		// Token: 0x170061A2 RID: 24994
		// (get) Token: 0x06030C7A RID: 199802 RVA: 0x00D9AC5D File Offset: 0x00D98E5D
		// (set) Token: 0x06030C7B RID: 199803 RVA: 0x00D9AC65 File Offset: 0x00D98E65
		[Nullable(2)]
		public string DescTitleKey { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}

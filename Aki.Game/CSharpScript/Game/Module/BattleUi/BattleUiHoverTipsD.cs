using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005C7B RID: 23675
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiHoverTipsD : IBattleUiHoverTipsD
	{
		// Token: 0x17008DCB RID: 36299
		// (get) Token: 0x0603BD22 RID: 245026 RVA: 0x00E4A68C File Offset: 0x00E4888C
		// (set) Token: 0x0603BD23 RID: 245027 RVA: 0x00E4A694 File Offset: 0x00E48894
		public string TitleKey { get; set; }

		// Token: 0x17008DCC RID: 36300
		// (get) Token: 0x0603BD24 RID: 245028 RVA: 0x00E4A69D File Offset: 0x00E4889D
		// (set) Token: 0x0603BD25 RID: 245029 RVA: 0x00E4A6A5 File Offset: 0x00E488A5
		public FColor? TitleColor { get; set; }

		// Token: 0x17008DCD RID: 36301
		// (get) Token: 0x0603BD26 RID: 245030 RVA: 0x00E4A6AE File Offset: 0x00E488AE
		// (set) Token: 0x0603BD27 RID: 245031 RVA: 0x00E4A6B6 File Offset: 0x00E488B6
		[Nullable(2)]
		public string SubTitleKey { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008DCE RID: 36302
		// (get) Token: 0x0603BD28 RID: 245032 RVA: 0x00E4A6BF File Offset: 0x00E488BF
		// (set) Token: 0x0603BD29 RID: 245033 RVA: 0x00E4A6C7 File Offset: 0x00E488C7
		public IMediumItemGridBase ItemInfo { get; set; }

		// Token: 0x17008DCF RID: 36303
		// (get) Token: 0x0603BD2A RID: 245034 RVA: 0x00E4A6D0 File Offset: 0x00E488D0
		// (set) Token: 0x0603BD2B RID: 245035 RVA: 0x00E4A6D8 File Offset: 0x00E488D8
		public List<IBattleUiHoverTipsDescInfo> DescInfoList { get; set; }

		// Token: 0x17008DD0 RID: 36304
		// (get) Token: 0x0603BD2C RID: 245036 RVA: 0x00E4A6E1 File Offset: 0x00E488E1
		// (set) Token: 0x0603BD2D RID: 245037 RVA: 0x00E4A6E9 File Offset: 0x00E488E9
		[Nullable(2)]
		public string DescTitleKey { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}

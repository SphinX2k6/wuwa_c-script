using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005C7D RID: 23677
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiHoverTipsDescInfo : IBattleUiHoverTipsDescInfo
	{
		// Token: 0x17008DD6 RID: 36310
		// (get) Token: 0x0603BD39 RID: 245049 RVA: 0x00E4A6FA File Offset: 0x00E488FA
		// (set) Token: 0x0603BD3A RID: 245050 RVA: 0x00E4A702 File Offset: 0x00E48902
		public string DescKey { get; set; }

		// Token: 0x17008DD7 RID: 36311
		// (get) Token: 0x0603BD3B RID: 245051 RVA: 0x00E4A70B File Offset: 0x00E4890B
		// (set) Token: 0x0603BD3C RID: 245052 RVA: 0x00E4A713 File Offset: 0x00E48913
		public bool? DescUseChangeColor { get; set; }

		// Token: 0x17008DD8 RID: 36312
		// (get) Token: 0x0603BD3D RID: 245053 RVA: 0x00E4A71C File Offset: 0x00E4891C
		// (set) Token: 0x0603BD3E RID: 245054 RVA: 0x00E4A724 File Offset: 0x00E48924
		[Nullable(2)]
		public string StateTitleKey { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008DD9 RID: 36313
		// (get) Token: 0x0603BD3F RID: 245055 RVA: 0x00E4A72D File Offset: 0x00E4892D
		// (set) Token: 0x0603BD40 RID: 245056 RVA: 0x00E4A735 File Offset: 0x00E48935
		public bool? IsUnlock { get; set; }

		// Token: 0x17008DDA RID: 36314
		// (get) Token: 0x0603BD41 RID: 245057 RVA: 0x00E4A73E File Offset: 0x00E4893E
		// (set) Token: 0x0603BD42 RID: 245058 RVA: 0x00E4A746 File Offset: 0x00E48946
		public bool? IsShowState { get; set; }
	}
}

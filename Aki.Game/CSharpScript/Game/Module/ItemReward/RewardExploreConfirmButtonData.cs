using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057D3 RID: 22483
	[NullableContext(2)]
	[Nullable(0)]
	public class RewardExploreConfirmButtonData : IRewardExploreConfirmButton
	{
		// Token: 0x170089C3 RID: 35267
		// (get) Token: 0x06039293 RID: 234131 RVA: 0x00D901A1 File Offset: 0x00D8E3A1
		// (set) Token: 0x06039294 RID: 234132 RVA: 0x00D901A9 File Offset: 0x00D8E3A9
		[Nullable(1)]
		public string ButtonTextId { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x170089C4 RID: 35268
		// (get) Token: 0x06039295 RID: 234133 RVA: 0x00D901B2 File Offset: 0x00D8E3B2
		// (set) Token: 0x06039296 RID: 234134 RVA: 0x00D901BA File Offset: 0x00D8E3BA
		public string DescriptionTextId { get; set; }

		// Token: 0x170089C5 RID: 35269
		// (get) Token: 0x06039297 RID: 234135 RVA: 0x00D901C3 File Offset: 0x00D8E3C3
		// (set) Token: 0x06039298 RID: 234136 RVA: 0x00D901CB File Offset: 0x00D8E3CB
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<object> DescriptionArgs { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x170089C6 RID: 35270
		// (get) Token: 0x06039299 RID: 234137 RVA: 0x00D901D4 File Offset: 0x00D8E3D4
		// (set) Token: 0x0603929A RID: 234138 RVA: 0x00D901DC File Offset: 0x00D8E3DC
		public int? TimeDown { get; set; }

		// Token: 0x170089C7 RID: 35271
		// (get) Token: 0x0603929B RID: 234139 RVA: 0x00D901E5 File Offset: 0x00D8E3E5
		// (set) Token: 0x0603929C RID: 234140 RVA: 0x00D901ED File Offset: 0x00D8E3ED
		public bool IsTimeDownCloseView { get; set; }

		// Token: 0x170089C8 RID: 35272
		// (get) Token: 0x0603929D RID: 234141 RVA: 0x00D901F6 File Offset: 0x00D8E3F6
		// (set) Token: 0x0603929E RID: 234142 RVA: 0x00D901FE File Offset: 0x00D8E3FE
		public Action OnTimeDownOnCallback { get; set; }

		// Token: 0x170089C9 RID: 35273
		// (get) Token: 0x0603929F RID: 234143 RVA: 0x00D90207 File Offset: 0x00D8E407
		// (set) Token: 0x060392A0 RID: 234144 RVA: 0x00D9020F File Offset: 0x00D8E40F
		public bool IsClickedCloseView { get; set; }

		// Token: 0x170089CA RID: 35274
		// (get) Token: 0x060392A1 RID: 234145 RVA: 0x00D90218 File Offset: 0x00D8E418
		// (set) Token: 0x060392A2 RID: 234146 RVA: 0x00D90220 File Offset: 0x00D8E420
		public Action<int> OnClickedCallback { get; set; }

		// Token: 0x170089CB RID: 35275
		// (get) Token: 0x060392A3 RID: 234147 RVA: 0x00D90229 File Offset: 0x00D8E429
		// (set) Token: 0x060392A4 RID: 234148 RVA: 0x00D90231 File Offset: 0x00D8E431
		public int? ClickCd { get; set; }
	}
}

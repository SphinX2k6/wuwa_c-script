using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D0B RID: 15627
	public class IArcadeGameplayTetrisBoardGameT
	{
		// Token: 0x17006B36 RID: 27446
		// (get) Token: 0x060158E9 RID: 88297 RVA: 0x0031D410 File Offset: 0x0031B610
		// (set) Token: 0x060158EA RID: 88298 RVA: 0x0031D418 File Offset: 0x0031B618
		public EArcadeGameplayType Type { get; set; }

		// Token: 0x17006B37 RID: 27447
		// (get) Token: 0x060158EB RID: 88299 RVA: 0x0031D421 File Offset: 0x0031B621
		// (set) Token: 0x060158EC RID: 88300 RVA: 0x0031D429 File Offset: 0x0031B629
		public int LevelId { get; set; }

		// Token: 0x060158ED RID: 88301 RVA: 0x0031D432 File Offset: 0x0031B632
		public IArcadeGameplayTetrisBoardGameT()
		{
			this.Type = EArcadeGameplayType.DropCatch;
			this.LevelId = 0;
		}
	}
}

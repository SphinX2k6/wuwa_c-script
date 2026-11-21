using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x0200416C RID: 16748
	[NullableContext(1)]
	[Nullable(0)]
	public class CardTabItemData : ICardTabItemData
	{
		// Token: 0x17005556 RID: 21846
		// (get) Token: 0x0602A645 RID: 173637 RVA: 0x00BF5143 File Offset: 0x00BF3343
		// (set) Token: 0x0602A646 RID: 173638 RVA: 0x00BF514B File Offset: 0x00BF334B
		public ECardTabType TabType { get; set; }

		// Token: 0x17005557 RID: 21847
		// (get) Token: 0x0602A647 RID: 173639 RVA: 0x00BF5154 File Offset: 0x00BF3354
		// (set) Token: 0x0602A648 RID: 173640 RVA: 0x00BF515C File Offset: 0x00BF335C
		public ECardElement? ElementConfigId { get; set; }

		// Token: 0x17005558 RID: 21848
		// (get) Token: 0x0602A649 RID: 173641 RVA: 0x00BF5165 File Offset: 0x00BF3365
		// (set) Token: 0x0602A64A RID: 173642 RVA: 0x00BF516D File Offset: 0x00BF336D
		public string TabTexturePath { get; set; }

		// Token: 0x17005559 RID: 21849
		// (get) Token: 0x0602A64B RID: 173643 RVA: 0x00BF5176 File Offset: 0x00BF3376
		// (set) Token: 0x0602A64C RID: 173644 RVA: 0x00BF517E File Offset: 0x00BF337E
		public string TabElementColor { get; set; }

		// Token: 0x1700555A RID: 21850
		// (get) Token: 0x0602A64D RID: 173645 RVA: 0x00BF5187 File Offset: 0x00BF3387
		// (set) Token: 0x0602A64E RID: 173646 RVA: 0x00BF518F File Offset: 0x00BF338F
		public bool ShowRedDot { get; set; }

		// Token: 0x1700555B RID: 21851
		// (get) Token: 0x0602A64F RID: 173647 RVA: 0x00BF5198 File Offset: 0x00BF3398
		// (set) Token: 0x0602A650 RID: 173648 RVA: 0x00BF51A0 File Offset: 0x00BF33A0
		public bool IsDisable { get; set; }

		// Token: 0x1700555C RID: 21852
		// (get) Token: 0x0602A651 RID: 173649 RVA: 0x00BF51A9 File Offset: 0x00BF33A9
		// (set) Token: 0x0602A652 RID: 173650 RVA: 0x00BF51B1 File Offset: 0x00BF33B1
		public bool IsArrivedMax { get; set; }
	}
}

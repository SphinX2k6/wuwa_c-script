using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053CE RID: 21454
	public class IAnimalComponentT
	{
		// Token: 0x170097CB RID: 38859
		// (get) Token: 0x06021825 RID: 137253 RVA: 0x0049F424 File Offset: 0x0049D624
		// (set) Token: 0x06021826 RID: 137254 RVA: 0x0049F42C File Offset: 0x0049D62C
		public bool Disabled { get; set; }

		// Token: 0x170097CC RID: 38860
		// (get) Token: 0x06021827 RID: 137255 RVA: 0x0049F435 File Offset: 0x0049D635
		// (set) Token: 0x06021828 RID: 137256 RVA: 0x0049F43D File Offset: 0x0049D63D
		public bool IsStare { get; set; }

		// Token: 0x170097CD RID: 38861
		// (get) Token: 0x06021829 RID: 137257 RVA: 0x0049F446 File Offset: 0x0049D646
		// (set) Token: 0x0602182A RID: 137258 RVA: 0x0049F44E File Offset: 0x0049D64E
		public int AnimalAttackRange { get; set; }

		// Token: 0x170097CE RID: 38862
		// (get) Token: 0x0602182B RID: 137259 RVA: 0x0049F457 File Offset: 0x0049D657
		// (set) Token: 0x0602182C RID: 137260 RVA: 0x0049F45F File Offset: 0x0049D65F
		public int MoveRange { get; set; }

		// Token: 0x170097CF RID: 38863
		// (get) Token: 0x0602182D RID: 137261 RVA: 0x0049F468 File Offset: 0x0049D668
		// (set) Token: 0x0602182E RID: 137262 RVA: 0x0049F470 File Offset: 0x0049D670
		public bool UseRangeComponentAsMoveRange { get; set; }

		// Token: 0x170097D0 RID: 38864
		// (get) Token: 0x0602182F RID: 137263 RVA: 0x0049F479 File Offset: 0x0049D679
		// (set) Token: 0x06021830 RID: 137264 RVA: 0x0049F481 File Offset: 0x0049D681
		public bool CanKillSelf { get; set; }

		// Token: 0x170097D1 RID: 38865
		// (get) Token: 0x06021831 RID: 137265 RVA: 0x0049F48A File Offset: 0x0049D68A
		// (set) Token: 0x06021832 RID: 137266 RVA: 0x0049F492 File Offset: 0x0049D692
		public bool PlayDeathAnimOnDestroy { get; set; }

		// Token: 0x170097D2 RID: 38866
		// (get) Token: 0x06021833 RID: 137267 RVA: 0x0049F49B File Offset: 0x0049D69B
		// (set) Token: 0x06021834 RID: 137268 RVA: 0x0049F4A3 File Offset: 0x0049D6A3
		public ICollectAnimalConfigT SpecialAnimalConfig { get; set; }

		// Token: 0x170097D3 RID: 38867
		// (get) Token: 0x06021835 RID: 137269 RVA: 0x0049F4AC File Offset: 0x0049D6AC
		// (set) Token: 0x06021836 RID: 137270 RVA: 0x0049F4B4 File Offset: 0x0049D6B4
		public List<IAnimalEmotionBubbleEntryT> EmotionBubbleMap { get; set; }

		// Token: 0x170097D4 RID: 38868
		// (get) Token: 0x06021837 RID: 137271 RVA: 0x0049F4BD File Offset: 0x0049D6BD
		// (set) Token: 0x06021838 RID: 137272 RVA: 0x0049F4C5 File Offset: 0x0049D6C5
		public List<EExtraMovementAbility> ExtraMovementAbilities { get; set; }

		// Token: 0x170097D5 RID: 38869
		// (get) Token: 0x06021839 RID: 137273 RVA: 0x0049F4CE File Offset: 0x0049D6CE
		// (set) Token: 0x0602183A RID: 137274 RVA: 0x0049F4D6 File Offset: 0x0049D6D6
		public byte NullMask { get; set; }

		// Token: 0x0602183B RID: 137275 RVA: 0x0049F4E0 File Offset: 0x0049D6E0
		public IAnimalComponentT()
		{
			this.Disabled = false;
			this.IsStare = false;
			this.AnimalAttackRange = 0;
			this.MoveRange = 0;
			this.UseRangeComponentAsMoveRange = false;
			this.CanKillSelf = false;
			this.PlayDeathAnimOnDestroy = false;
			this.SpecialAnimalConfig = null;
			this.EmotionBubbleMap = null;
			this.ExtraMovementAbilities = null;
			this.NullMask = 0;
		}
	}
}

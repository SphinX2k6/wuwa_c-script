using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EA5 RID: 20133
	public class IAnimalComponentT
	{
		// Token: 0x1700906B RID: 36971
		// (get) Token: 0x0601FB26 RID: 129830 RVA: 0x00469FD0 File Offset: 0x004681D0
		// (set) Token: 0x0601FB27 RID: 129831 RVA: 0x00469FD8 File Offset: 0x004681D8
		public bool Disabled { get; set; }

		// Token: 0x1700906C RID: 36972
		// (get) Token: 0x0601FB28 RID: 129832 RVA: 0x00469FE1 File Offset: 0x004681E1
		// (set) Token: 0x0601FB29 RID: 129833 RVA: 0x00469FE9 File Offset: 0x004681E9
		public bool IsStare { get; set; }

		// Token: 0x1700906D RID: 36973
		// (get) Token: 0x0601FB2A RID: 129834 RVA: 0x00469FF2 File Offset: 0x004681F2
		// (set) Token: 0x0601FB2B RID: 129835 RVA: 0x00469FFA File Offset: 0x004681FA
		public int AnimalAttackRange { get; set; }

		// Token: 0x1700906E RID: 36974
		// (get) Token: 0x0601FB2C RID: 129836 RVA: 0x0046A003 File Offset: 0x00468203
		// (set) Token: 0x0601FB2D RID: 129837 RVA: 0x0046A00B File Offset: 0x0046820B
		public int MoveRange { get; set; }

		// Token: 0x1700906F RID: 36975
		// (get) Token: 0x0601FB2E RID: 129838 RVA: 0x0046A014 File Offset: 0x00468214
		// (set) Token: 0x0601FB2F RID: 129839 RVA: 0x0046A01C File Offset: 0x0046821C
		public bool UseRangeComponentAsMoveRange { get; set; }

		// Token: 0x17009070 RID: 36976
		// (get) Token: 0x0601FB30 RID: 129840 RVA: 0x0046A025 File Offset: 0x00468225
		// (set) Token: 0x0601FB31 RID: 129841 RVA: 0x0046A02D File Offset: 0x0046822D
		public bool CanKillSelf { get; set; }

		// Token: 0x17009071 RID: 36977
		// (get) Token: 0x0601FB32 RID: 129842 RVA: 0x0046A036 File Offset: 0x00468236
		// (set) Token: 0x0601FB33 RID: 129843 RVA: 0x0046A03E File Offset: 0x0046823E
		public bool PlayDeathAnimOnDestroy { get; set; }

		// Token: 0x17009072 RID: 36978
		// (get) Token: 0x0601FB34 RID: 129844 RVA: 0x0046A047 File Offset: 0x00468247
		// (set) Token: 0x0601FB35 RID: 129845 RVA: 0x0046A04F File Offset: 0x0046824F
		public ICollectAnimalConfigT SpecialAnimalConfig { get; set; }

		// Token: 0x17009073 RID: 36979
		// (get) Token: 0x0601FB36 RID: 129846 RVA: 0x0046A058 File Offset: 0x00468258
		// (set) Token: 0x0601FB37 RID: 129847 RVA: 0x0046A060 File Offset: 0x00468260
		public List<IAnimalEmotionBubbleEntryT> EmotionBubbleMap { get; set; }

		// Token: 0x17009074 RID: 36980
		// (get) Token: 0x0601FB38 RID: 129848 RVA: 0x0046A069 File Offset: 0x00468269
		// (set) Token: 0x0601FB39 RID: 129849 RVA: 0x0046A071 File Offset: 0x00468271
		public byte NullMask { get; set; }

		// Token: 0x0601FB3A RID: 129850 RVA: 0x0046A07C File Offset: 0x0046827C
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
			this.NullMask = 0;
		}
	}
}

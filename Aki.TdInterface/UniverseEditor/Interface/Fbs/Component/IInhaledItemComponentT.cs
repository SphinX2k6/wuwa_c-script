using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200540E RID: 21518
	public class IInhaledItemComponentT
	{
		// Token: 0x17009E53 RID: 40531
		// (get) Token: 0x0602357D RID: 144765 RVA: 0x004E468B File Offset: 0x004E288B
		// (set) Token: 0x0602357E RID: 144766 RVA: 0x004E4693 File Offset: 0x004E2893
		public bool Disabled { get; set; }

		// Token: 0x17009E54 RID: 40532
		// (get) Token: 0x0602357F RID: 144767 RVA: 0x004E469C File Offset: 0x004E289C
		// (set) Token: 0x06023580 RID: 144768 RVA: 0x004E46A4 File Offset: 0x004E28A4
		public int InhaledStrength { get; set; }

		// Token: 0x17009E55 RID: 40533
		// (get) Token: 0x06023581 RID: 144769 RVA: 0x004E46AD File Offset: 0x004E28AD
		// (set) Token: 0x06023582 RID: 144770 RVA: 0x004E46B5 File Offset: 0x004E28B5
		public int InhaledInterruptionRecoveryTime { get; set; }

		// Token: 0x17009E56 RID: 40534
		// (get) Token: 0x06023583 RID: 144771 RVA: 0x004E46BE File Offset: 0x004E28BE
		// (set) Token: 0x06023584 RID: 144772 RVA: 0x004E46C6 File Offset: 0x004E28C6
		public IInhaledPerformanceT InhaledPerformance { get; set; }

		// Token: 0x17009E57 RID: 40535
		// (get) Token: 0x06023585 RID: 144773 RVA: 0x004E46CF File Offset: 0x004E28CF
		// (set) Token: 0x06023586 RID: 144774 RVA: 0x004E46D7 File Offset: 0x004E28D7
		public TInhaledPerResultTypeUnion InhaledPerResult { get; set; }

		// Token: 0x17009E58 RID: 40536
		// (get) Token: 0x06023587 RID: 144775 RVA: 0x004E46E0 File Offset: 0x004E28E0
		// (set) Token: 0x06023588 RID: 144776 RVA: 0x004E46E8 File Offset: 0x004E28E8
		public byte NullMask { get; set; }

		// Token: 0x06023589 RID: 144777 RVA: 0x004E46F1 File Offset: 0x004E28F1
		public IInhaledItemComponentT()
		{
			this.Disabled = false;
			this.InhaledStrength = 0;
			this.InhaledInterruptionRecoveryTime = 0;
			this.InhaledPerformance = null;
			this.InhaledPerResult = null;
			this.NullMask = 0;
		}
	}
}

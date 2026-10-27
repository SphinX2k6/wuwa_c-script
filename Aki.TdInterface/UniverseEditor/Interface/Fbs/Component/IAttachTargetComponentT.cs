using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EBD RID: 20157
	public class IAttachTargetComponentT
	{
		// Token: 0x1700909E RID: 37022
		// (get) Token: 0x0601FBFD RID: 130045 RVA: 0x0046B887 File Offset: 0x00469A87
		// (set) Token: 0x0601FBFE RID: 130046 RVA: 0x0046B88F File Offset: 0x00469A8F
		public bool Disabled { get; set; }

		// Token: 0x1700909F RID: 37023
		// (get) Token: 0x0601FBFF RID: 130047 RVA: 0x0046B898 File Offset: 0x00469A98
		// (set) Token: 0x0601FC00 RID: 130048 RVA: 0x0046B8A0 File Offset: 0x00469AA0
		public TAttachTargetUnion AttachTarget { get; set; }

		// Token: 0x170090A0 RID: 37024
		// (get) Token: 0x0601FC01 RID: 130049 RVA: 0x0046B8A9 File Offset: 0x00469AA9
		// (set) Token: 0x0601FC02 RID: 130050 RVA: 0x0046B8B1 File Offset: 0x00469AB1
		public EAttachRuleType PosRule { get; set; }

		// Token: 0x170090A1 RID: 37025
		// (get) Token: 0x0601FC03 RID: 130051 RVA: 0x0046B8BA File Offset: 0x00469ABA
		// (set) Token: 0x0601FC04 RID: 130052 RVA: 0x0046B8C2 File Offset: 0x00469AC2
		public EAttachRuleType RotRule { get; set; }

		// Token: 0x170090A2 RID: 37026
		// (get) Token: 0x0601FC05 RID: 130053 RVA: 0x0046B8CB File Offset: 0x00469ACB
		// (set) Token: 0x0601FC06 RID: 130054 RVA: 0x0046B8D3 File Offset: 0x00469AD3
		public TAttachTimingUnion AttachTiming { get; set; }

		// Token: 0x170090A3 RID: 37027
		// (get) Token: 0x0601FC07 RID: 130055 RVA: 0x0046B8DC File Offset: 0x00469ADC
		// (set) Token: 0x0601FC08 RID: 130056 RVA: 0x0046B8E4 File Offset: 0x00469AE4
		public byte NullMask { get; set; }

		// Token: 0x0601FC09 RID: 130057 RVA: 0x0046B8ED File Offset: 0x00469AED
		public IAttachTargetComponentT()
		{
			this.Disabled = false;
			this.AttachTarget = null;
			this.PosRule = EAttachRuleType.Relatively;
			this.RotRule = EAttachRuleType.Relatively;
			this.AttachTiming = null;
			this.NullMask = 0;
		}
	}
}

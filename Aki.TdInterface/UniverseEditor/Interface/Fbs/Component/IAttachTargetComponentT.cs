using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053E6 RID: 21478
	public class IAttachTargetComponentT
	{
		// Token: 0x170097FF RID: 38911
		// (get) Token: 0x060218FF RID: 137471 RVA: 0x004A0D63 File Offset: 0x0049EF63
		// (set) Token: 0x06021900 RID: 137472 RVA: 0x004A0D6B File Offset: 0x0049EF6B
		public bool Disabled { get; set; }

		// Token: 0x17009800 RID: 38912
		// (get) Token: 0x06021901 RID: 137473 RVA: 0x004A0D74 File Offset: 0x0049EF74
		// (set) Token: 0x06021902 RID: 137474 RVA: 0x004A0D7C File Offset: 0x0049EF7C
		public TAttachTargetUnion AttachTarget { get; set; }

		// Token: 0x17009801 RID: 38913
		// (get) Token: 0x06021903 RID: 137475 RVA: 0x004A0D85 File Offset: 0x0049EF85
		// (set) Token: 0x06021904 RID: 137476 RVA: 0x004A0D8D File Offset: 0x0049EF8D
		public EAttachRuleType PosRule { get; set; }

		// Token: 0x17009802 RID: 38914
		// (get) Token: 0x06021905 RID: 137477 RVA: 0x004A0D96 File Offset: 0x0049EF96
		// (set) Token: 0x06021906 RID: 137478 RVA: 0x004A0D9E File Offset: 0x0049EF9E
		public EAttachRuleType RotRule { get; set; }

		// Token: 0x17009803 RID: 38915
		// (get) Token: 0x06021907 RID: 137479 RVA: 0x004A0DA7 File Offset: 0x0049EFA7
		// (set) Token: 0x06021908 RID: 137480 RVA: 0x004A0DAF File Offset: 0x0049EFAF
		public TAttachTimingUnion AttachTiming { get; set; }

		// Token: 0x17009804 RID: 38916
		// (get) Token: 0x06021909 RID: 137481 RVA: 0x004A0DB8 File Offset: 0x0049EFB8
		// (set) Token: 0x0602190A RID: 137482 RVA: 0x004A0DC0 File Offset: 0x0049EFC0
		public byte NullMask { get; set; }

		// Token: 0x0602190B RID: 137483 RVA: 0x004A0DC9 File Offset: 0x0049EFC9
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

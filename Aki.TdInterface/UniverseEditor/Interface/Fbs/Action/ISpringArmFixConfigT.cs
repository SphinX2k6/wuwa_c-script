using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007978 RID: 31096
	public class ISpringArmFixConfigT
	{
		// Token: 0x1700E402 RID: 58370
		// (get) Token: 0x06036C40 RID: 224320 RVA: 0x00753630 File Offset: 0x00751830
		// (set) Token: 0x06036C41 RID: 224321 RVA: 0x00753638 File Offset: 0x00751838
		public bool LeftRightFix { get; set; }

		// Token: 0x1700E403 RID: 58371
		// (get) Token: 0x06036C42 RID: 224322 RVA: 0x00753641 File Offset: 0x00751841
		// (set) Token: 0x06036C43 RID: 224323 RVA: 0x00753649 File Offset: 0x00751849
		public bool ForwardBackFix { get; set; }

		// Token: 0x1700E404 RID: 58372
		// (get) Token: 0x06036C44 RID: 224324 RVA: 0x00753652 File Offset: 0x00751852
		// (set) Token: 0x06036C45 RID: 224325 RVA: 0x0075365A File Offset: 0x0075185A
		public bool UpDownFix { get; set; }

		// Token: 0x1700E405 RID: 58373
		// (get) Token: 0x06036C46 RID: 224326 RVA: 0x00753663 File Offset: 0x00751863
		// (set) Token: 0x06036C47 RID: 224327 RVA: 0x0075366B File Offset: 0x0075186B
		public byte NullMask { get; set; }

		// Token: 0x06036C48 RID: 224328 RVA: 0x00753674 File Offset: 0x00751874
		public ISpringArmFixConfigT()
		{
			this.LeftRightFix = false;
			this.ForwardBackFix = false;
			this.UpDownFix = false;
			this.NullMask = 0;
		}
	}
}

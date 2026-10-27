using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200624C RID: 25164
	public class IBvbPlayerOperationConstraintT
	{
		// Token: 0x1700BB8D RID: 48013
		// (get) Token: 0x0602B660 RID: 177760 RVA: 0x005F9717 File Offset: 0x005F7917
		// (set) Token: 0x0602B661 RID: 177761 RVA: 0x005F971F File Offset: 0x005F791F
		public TBvbPlayerOperationTypeUnion EnableOperation { get; set; }

		// Token: 0x1700BB8E RID: 48014
		// (get) Token: 0x0602B662 RID: 177762 RVA: 0x005F9728 File Offset: 0x005F7928
		// (set) Token: 0x0602B663 RID: 177763 RVA: 0x005F9730 File Offset: 0x005F7930
		public bool IsTheLast { get; set; }

		// Token: 0x1700BB8F RID: 48015
		// (get) Token: 0x0602B664 RID: 177764 RVA: 0x005F9739 File Offset: 0x005F7939
		// (set) Token: 0x0602B665 RID: 177765 RVA: 0x005F9741 File Offset: 0x005F7941
		public string TidPromptTxt { get; set; }

		// Token: 0x1700BB90 RID: 48016
		// (get) Token: 0x0602B666 RID: 177766 RVA: 0x005F974A File Offset: 0x005F794A
		// (set) Token: 0x0602B667 RID: 177767 RVA: 0x005F9752 File Offset: 0x005F7952
		public byte NullMask { get; set; }

		// Token: 0x0602B668 RID: 177768 RVA: 0x005F975B File Offset: 0x005F795B
		public IBvbPlayerOperationConstraintT()
		{
			this.EnableOperation = null;
			this.IsTheLast = false;
			this.TidPromptTxt = null;
			this.NullMask = 0;
		}
	}
}

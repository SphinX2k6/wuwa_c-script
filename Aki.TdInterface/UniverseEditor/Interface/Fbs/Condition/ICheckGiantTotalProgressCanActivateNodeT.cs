using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F00 RID: 20224
	public class ICheckGiantTotalProgressCanActivateNodeT
	{
		// Token: 0x1700906D RID: 36973
		// (get) Token: 0x0601F6A5 RID: 128677 RVA: 0x0046032C File Offset: 0x0045E52C
		// (set) Token: 0x0601F6A6 RID: 128678 RVA: 0x00460334 File Offset: 0x0045E534
		public ECondition Type { get; set; }

		// Token: 0x1700906E RID: 36974
		// (get) Token: 0x0601F6A7 RID: 128679 RVA: 0x0046033D File Offset: 0x0045E53D
		// (set) Token: 0x0601F6A8 RID: 128680 RVA: 0x00460345 File Offset: 0x0045E545
		public bool HasActivateNode { get; set; }

		// Token: 0x0601F6A9 RID: 128681 RVA: 0x0046034E File Offset: 0x0045E54E
		public ICheckGiantTotalProgressCanActivateNodeT()
		{
			this.Type = ECondition.CompareVar;
			this.HasActivateNode = false;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FBA RID: 16314
	public class IProgressBarT
	{
		// Token: 0x170071F1 RID: 29169
		// (get) Token: 0x06017542 RID: 95554 RVA: 0x0035CE03 File Offset: 0x0035B003
		// (set) Token: 0x06017543 RID: 95555 RVA: 0x0035CE0B File Offset: 0x0035B00B
		public EProgressBarStyle ProgressStyle { get; set; }

		// Token: 0x170071F2 RID: 29170
		// (get) Token: 0x06017544 RID: 95556 RVA: 0x0035CE14 File Offset: 0x0035B014
		// (set) Token: 0x06017545 RID: 95557 RVA: 0x0035CE1C File Offset: 0x0035B01C
		public IProgressCalculateT ProgressCalculate { get; set; }

		// Token: 0x06017546 RID: 95558 RVA: 0x0035CE25 File Offset: 0x0035B025
		public IProgressBarT()
		{
			this.ProgressStyle = EProgressBarStyle.Default;
			this.ProgressCalculate = null;
		}
	}
}

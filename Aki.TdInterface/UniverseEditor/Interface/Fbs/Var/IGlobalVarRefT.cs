using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A9D RID: 15005
	public class IGlobalVarRefT
	{
		// Token: 0x170066CC RID: 26316
		// (get) Token: 0x060145E0 RID: 83424 RVA: 0x002F88CD File Offset: 0x002F6ACD
		// (set) Token: 0x060145E1 RID: 83425 RVA: 0x002F88D5 File Offset: 0x002F6AD5
		public EVar Type { get; set; }

		// Token: 0x170066CD RID: 26317
		// (get) Token: 0x060145E2 RID: 83426 RVA: 0x002F88DE File Offset: 0x002F6ADE
		// (set) Token: 0x060145E3 RID: 83427 RVA: 0x002F88E6 File Offset: 0x002F6AE6
		public EVarRefSource Source { get; set; }

		// Token: 0x170066CE RID: 26318
		// (get) Token: 0x060145E4 RID: 83428 RVA: 0x002F88EF File Offset: 0x002F6AEF
		// (set) Token: 0x060145E5 RID: 83429 RVA: 0x002F88F7 File Offset: 0x002F6AF7
		public string Keyword { get; set; }

		// Token: 0x060145E6 RID: 83430 RVA: 0x002F8900 File Offset: 0x002F6B00
		public IGlobalVarRefT()
		{
			this.Type = EVar.Boolean;
			this.Source = EVarRefSource.Constant;
			this.Keyword = null;
		}
	}
}

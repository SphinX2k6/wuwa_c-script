using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200745B RID: 29787
	public class ITrapDefensePlayerOperationConstraintT
	{
		// Token: 0x1700E222 RID: 57890
		// (get) Token: 0x060361EA RID: 221674 RVA: 0x0075C031 File Offset: 0x0075A231
		// (set) Token: 0x060361EB RID: 221675 RVA: 0x0075C039 File Offset: 0x0075A239
		public TTrapDefensePlayerOperationTypeUnion DisableOperation { get; set; }

		// Token: 0x1700E223 RID: 57891
		// (get) Token: 0x060361EC RID: 221676 RVA: 0x0075C042 File Offset: 0x0075A242
		// (set) Token: 0x060361ED RID: 221677 RVA: 0x0075C04A File Offset: 0x0075A24A
		public bool IsConstrained { get; set; }

		// Token: 0x1700E224 RID: 57892
		// (get) Token: 0x060361EE RID: 221678 RVA: 0x0075C053 File Offset: 0x0075A253
		// (set) Token: 0x060361EF RID: 221679 RVA: 0x0075C05B File Offset: 0x0075A25B
		public string TidPromptTxt { get; set; }

		// Token: 0x060361F0 RID: 221680 RVA: 0x0075C064 File Offset: 0x0075A264
		public ITrapDefensePlayerOperationConstraintT()
		{
			this.DisableOperation = null;
			this.IsConstrained = false;
			this.TidPromptTxt = null;
		}
	}
}

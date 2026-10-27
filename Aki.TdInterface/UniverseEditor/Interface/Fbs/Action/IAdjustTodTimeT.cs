using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006174 RID: 24948
	public class IAdjustTodTimeT
	{
		// Token: 0x1700B9D3 RID: 47571
		// (get) Token: 0x0602AF22 RID: 175906 RVA: 0x005ECC32 File Offset: 0x005EAE32
		// (set) Token: 0x0602AF23 RID: 175907 RVA: 0x005ECC3A File Offset: 0x005EAE3A
		public int Hour { get; set; }

		// Token: 0x1700B9D4 RID: 47572
		// (get) Token: 0x0602AF24 RID: 175908 RVA: 0x005ECC43 File Offset: 0x005EAE43
		// (set) Token: 0x0602AF25 RID: 175909 RVA: 0x005ECC4B File Offset: 0x005EAE4B
		public int Min { get; set; }

		// Token: 0x1700B9D5 RID: 47573
		// (get) Token: 0x0602AF26 RID: 175910 RVA: 0x005ECC54 File Offset: 0x005EAE54
		// (set) Token: 0x0602AF27 RID: 175911 RVA: 0x005ECC5C File Offset: 0x005EAE5C
		public bool ShowUi { get; set; }

		// Token: 0x0602AF28 RID: 175912 RVA: 0x005ECC65 File Offset: 0x005EAE65
		public IAdjustTodTimeT()
		{
			this.Hour = 0;
			this.Min = 0;
			this.ShowUi = false;
		}
	}
}

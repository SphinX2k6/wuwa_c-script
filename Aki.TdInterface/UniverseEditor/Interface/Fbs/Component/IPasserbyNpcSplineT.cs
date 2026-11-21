using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CCD RID: 23757
	public class IPasserbyNpcSplineT
	{
		// Token: 0x1700AE8F RID: 44687
		// (get) Token: 0x060276ED RID: 161517 RVA: 0x00565B7F File Offset: 0x00563D7F
		// (set) Token: 0x060276EE RID: 161518 RVA: 0x00565B87 File Offset: 0x00563D87
		public int SplineEntityId { get; set; }

		// Token: 0x1700AE90 RID: 44688
		// (get) Token: 0x060276EF RID: 161519 RVA: 0x00565B90 File Offset: 0x00563D90
		// (set) Token: 0x060276F0 RID: 161520 RVA: 0x00565B98 File Offset: 0x00563D98
		public int SpawnWeight { get; set; }

		// Token: 0x1700AE91 RID: 44689
		// (get) Token: 0x060276F1 RID: 161521 RVA: 0x00565BA1 File Offset: 0x00563DA1
		// (set) Token: 0x060276F2 RID: 161522 RVA: 0x00565BA9 File Offset: 0x00563DA9
		public bool IsLoop { get; set; }

		// Token: 0x1700AE92 RID: 44690
		// (get) Token: 0x060276F3 RID: 161523 RVA: 0x00565BB2 File Offset: 0x00563DB2
		// (set) Token: 0x060276F4 RID: 161524 RVA: 0x00565BBA File Offset: 0x00563DBA
		public IPasserbyNpcMoveStateT MoveState { get; set; }

		// Token: 0x1700AE93 RID: 44691
		// (get) Token: 0x060276F5 RID: 161525 RVA: 0x00565BC3 File Offset: 0x00563DC3
		// (set) Token: 0x060276F6 RID: 161526 RVA: 0x00565BCB File Offset: 0x00563DCB
		public bool IsIkEnabled { get; set; }

		// Token: 0x1700AE94 RID: 44692
		// (get) Token: 0x060276F7 RID: 161527 RVA: 0x00565BD4 File Offset: 0x00563DD4
		// (set) Token: 0x060276F8 RID: 161528 RVA: 0x00565BDC File Offset: 0x00563DDC
		public byte NullMask { get; set; }

		// Token: 0x060276F9 RID: 161529 RVA: 0x00565BE5 File Offset: 0x00563DE5
		public IPasserbyNpcSplineT()
		{
			this.SplineEntityId = 0;
			this.SpawnWeight = 0;
			this.IsLoop = false;
			this.MoveState = null;
			this.IsIkEnabled = false;
			this.NullMask = 0;
		}
	}
}

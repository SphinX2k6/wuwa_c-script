using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056E1 RID: 22241
	public class IPasserbyNpcSplineT
	{
		// Token: 0x1700A591 RID: 42385
		// (get) Token: 0x0602529C RID: 152220 RVA: 0x005213C3 File Offset: 0x0051F5C3
		// (set) Token: 0x0602529D RID: 152221 RVA: 0x005213CB File Offset: 0x0051F5CB
		public int SplineEntityId { get; set; }

		// Token: 0x1700A592 RID: 42386
		// (get) Token: 0x0602529E RID: 152222 RVA: 0x005213D4 File Offset: 0x0051F5D4
		// (set) Token: 0x0602529F RID: 152223 RVA: 0x005213DC File Offset: 0x0051F5DC
		public int SpawnWeight { get; set; }

		// Token: 0x1700A593 RID: 42387
		// (get) Token: 0x060252A0 RID: 152224 RVA: 0x005213E5 File Offset: 0x0051F5E5
		// (set) Token: 0x060252A1 RID: 152225 RVA: 0x005213ED File Offset: 0x0051F5ED
		public bool IsLoop { get; set; }

		// Token: 0x1700A594 RID: 42388
		// (get) Token: 0x060252A2 RID: 152226 RVA: 0x005213F6 File Offset: 0x0051F5F6
		// (set) Token: 0x060252A3 RID: 152227 RVA: 0x005213FE File Offset: 0x0051F5FE
		public IPasserbyNpcMoveStateT MoveState { get; set; }

		// Token: 0x1700A595 RID: 42389
		// (get) Token: 0x060252A4 RID: 152228 RVA: 0x00521407 File Offset: 0x0051F607
		// (set) Token: 0x060252A5 RID: 152229 RVA: 0x0052140F File Offset: 0x0051F60F
		public bool IsIkEnabled { get; set; }

		// Token: 0x1700A596 RID: 42390
		// (get) Token: 0x060252A6 RID: 152230 RVA: 0x00521418 File Offset: 0x0051F618
		// (set) Token: 0x060252A7 RID: 152231 RVA: 0x00521420 File Offset: 0x0051F620
		public byte NullMask { get; set; }

		// Token: 0x060252A8 RID: 152232 RVA: 0x00521429 File Offset: 0x0051F629
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

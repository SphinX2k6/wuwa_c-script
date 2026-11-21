using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CDC RID: 23772
	public class IPathDrivenActorInitialSpawnHandleT
	{
		// Token: 0x1700AEAE RID: 44718
		// (get) Token: 0x06027779 RID: 161657 RVA: 0x00566BF4 File Offset: 0x00564DF4
		// (set) Token: 0x0602777A RID: 161658 RVA: 0x00566BFC File Offset: 0x00564DFC
		public int Index { get; set; }

		// Token: 0x1700AEAF RID: 44719
		// (get) Token: 0x0602777B RID: 161659 RVA: 0x00566C05 File Offset: 0x00564E05
		// (set) Token: 0x0602777C RID: 161660 RVA: 0x00566C0D File Offset: 0x00564E0D
		public EPathDrivenActorInitialSpawnHandleType HandleType { get; set; }

		// Token: 0x0602777D RID: 161661 RVA: 0x00566C16 File Offset: 0x00564E16
		public IPathDrivenActorInitialSpawnHandleT()
		{
			this.Index = 0;
			this.HandleType = EPathDrivenActorInitialSpawnHandleType.WaterBoxStagnation;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CDF RID: 23775
	public class IPathDrivenActorMoveBaseT
	{
		// Token: 0x1700AEB2 RID: 44722
		// (get) Token: 0x0602778D RID: 161677 RVA: 0x00566D92 File Offset: 0x00564F92
		// (set) Token: 0x0602778E RID: 161678 RVA: 0x00566D9A File Offset: 0x00564F9A
		public EPathDrivenActorMoveType Type { get; set; }

		// Token: 0x0602778F RID: 161679 RVA: 0x00566DA3 File Offset: 0x00564FA3
		public IPathDrivenActorMoveBaseT()
		{
			this.Type = EPathDrivenActorMoveType.Spline;
		}
	}
}

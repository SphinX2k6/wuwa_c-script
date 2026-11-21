using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C7C RID: 23676
	public class IPasserbyNpcFloorSplineT
	{
		// Token: 0x1700ADF9 RID: 44537
		// (get) Token: 0x06027473 RID: 160883 RVA: 0x005611D9 File Offset: 0x0055F3D9
		// (set) Token: 0x06027474 RID: 160884 RVA: 0x005611E1 File Offset: 0x0055F3E1
		public int SplineEntityId { get; set; }

		// Token: 0x1700ADFA RID: 44538
		// (get) Token: 0x06027475 RID: 160885 RVA: 0x005611EA File Offset: 0x0055F3EA
		// (set) Token: 0x06027476 RID: 160886 RVA: 0x005611F2 File Offset: 0x0055F3F2
		public int Floor { get; set; }

		// Token: 0x1700ADFB RID: 44539
		// (get) Token: 0x06027477 RID: 160887 RVA: 0x005611FB File Offset: 0x0055F3FB
		// (set) Token: 0x06027478 RID: 160888 RVA: 0x00561203 File Offset: 0x0055F403
		public IPasserbyNpcMoveStateT MoveState { get; set; }

		// Token: 0x06027479 RID: 160889 RVA: 0x0056120C File Offset: 0x0055F40C
		public IPasserbyNpcFloorSplineT()
		{
			this.SplineEntityId = 0;
			this.Floor = 0;
			this.MoveState = null;
		}
	}
}

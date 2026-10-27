using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045D3 RID: 17875
	public class ITrapDefenseSplineT
	{
		// Token: 0x17007F11 RID: 32529
		// (get) Token: 0x0601B0C5 RID: 110789 RVA: 0x003DADAD File Offset: 0x003D8FAD
		// (set) Token: 0x0601B0C6 RID: 110790 RVA: 0x003DADB5 File Offset: 0x003D8FB5
		public string SplineEntityId { get; set; }

		// Token: 0x17007F12 RID: 32530
		// (get) Token: 0x0601B0C7 RID: 110791 RVA: 0x003DADBE File Offset: 0x003D8FBE
		// (set) Token: 0x0601B0C8 RID: 110792 RVA: 0x003DADC6 File Offset: 0x003D8FC6
		public float DelayTime { get; set; }

		// Token: 0x17007F13 RID: 32531
		// (get) Token: 0x0601B0C9 RID: 110793 RVA: 0x003DADCF File Offset: 0x003D8FCF
		// (set) Token: 0x0601B0CA RID: 110794 RVA: 0x003DADD7 File Offset: 0x003D8FD7
		public float IntervalTime { get; set; }

		// Token: 0x0601B0CB RID: 110795 RVA: 0x003DADE0 File Offset: 0x003D8FE0
		public ITrapDefenseSplineT()
		{
			this.SplineEntityId = null;
			this.DelayTime = 0f;
			this.IntervalTime = 0f;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053A1 RID: 21409
	public class IAirWallBothSidesStyleT
	{
		// Token: 0x1700976E RID: 38766
		// (get) Token: 0x06021693 RID: 136851 RVA: 0x0049C284 File Offset: 0x0049A484
		// (set) Token: 0x06021694 RID: 136852 RVA: 0x0049C28C File Offset: 0x0049A48C
		public EAirWallSpawnStyle Type { get; set; }

		// Token: 0x1700976F RID: 38767
		// (get) Token: 0x06021695 RID: 136853 RVA: 0x0049C295 File Offset: 0x0049A495
		// (set) Token: 0x06021696 RID: 136854 RVA: 0x0049C29D File Offset: 0x0049A49D
		public float GapWidth { get; set; }

		// Token: 0x06021697 RID: 136855 RVA: 0x0049C2A6 File Offset: 0x0049A4A6
		public IAirWallBothSidesStyleT()
		{
			this.Type = EAirWallSpawnStyle.AlongSpline;
			this.GapWidth = 0f;
		}
	}
}

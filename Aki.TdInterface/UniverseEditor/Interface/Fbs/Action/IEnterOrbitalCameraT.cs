using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D3B RID: 27963
	public class IEnterOrbitalCameraT
	{
		// Token: 0x1700CD21 RID: 52513
		// (get) Token: 0x060303BD RID: 197565 RVA: 0x0068EA75 File Offset: 0x0068CC75
		// (set) Token: 0x060303BE RID: 197566 RVA: 0x0068EA7D File Offset: 0x0068CC7D
		public IEnterOrbitalCameraControlByMoveT Option { get; set; }

		// Token: 0x1700CD22 RID: 52514
		// (get) Token: 0x060303BF RID: 197567 RVA: 0x0068EA86 File Offset: 0x0068CC86
		// (set) Token: 0x060303C0 RID: 197568 RVA: 0x0068EA8E File Offset: 0x0068CC8E
		public bool IsDisableControlCamera { get; set; }

		// Token: 0x1700CD23 RID: 52515
		// (get) Token: 0x060303C1 RID: 197569 RVA: 0x0068EA97 File Offset: 0x0068CC97
		// (set) Token: 0x060303C2 RID: 197570 RVA: 0x0068EA9F File Offset: 0x0068CC9F
		public byte NullMask { get; set; }

		// Token: 0x060303C3 RID: 197571 RVA: 0x0068EAA8 File Offset: 0x0068CCA8
		public IEnterOrbitalCameraT()
		{
			this.Option = null;
			this.IsDisableControlCamera = false;
			this.NullMask = 0;
		}
	}
}

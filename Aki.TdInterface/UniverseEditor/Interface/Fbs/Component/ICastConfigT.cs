using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005488 RID: 21640
	public class ICastConfigT
	{
		// Token: 0x17009A19 RID: 39449
		// (get) Token: 0x060220A1 RID: 139425 RVA: 0x004B13F5 File Offset: 0x004AF5F5
		// (set) Token: 0x060220A2 RID: 139426 RVA: 0x004B13FD File Offset: 0x004AF5FD
		public int CastAngularVelocity { get; set; }

		// Token: 0x17009A1A RID: 39450
		// (get) Token: 0x060220A3 RID: 139427 RVA: 0x004B1406 File Offset: 0x004AF606
		// (set) Token: 0x060220A4 RID: 139428 RVA: 0x004B140E File Offset: 0x004AF60E
		public string CastCameraShake { get; set; }

		// Token: 0x17009A1B RID: 39451
		// (get) Token: 0x060220A5 RID: 139429 RVA: 0x004B1417 File Offset: 0x004AF617
		// (set) Token: 0x060220A6 RID: 139430 RVA: 0x004B141F File Offset: 0x004AF61F
		public int CastVelocity { get; set; }

		// Token: 0x060220A7 RID: 139431 RVA: 0x004B1428 File Offset: 0x004AF628
		public ICastConfigT()
		{
			this.CastAngularVelocity = 0;
			this.CastCameraShake = null;
			this.CastVelocity = 0;
		}
	}
}

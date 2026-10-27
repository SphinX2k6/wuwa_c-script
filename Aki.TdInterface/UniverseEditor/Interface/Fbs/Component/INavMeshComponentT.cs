using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055E8 RID: 21992
	public class INavMeshComponentT
	{
		// Token: 0x1700A2BF RID: 41663
		// (get) Token: 0x060247CB RID: 149451 RVA: 0x0050960D File Offset: 0x0050780D
		// (set) Token: 0x060247CC RID: 149452 RVA: 0x00509615 File Offset: 0x00507815
		public bool Disabled { get; set; }

		// Token: 0x1700A2C0 RID: 41664
		// (get) Token: 0x060247CD RID: 149453 RVA: 0x0050961E File Offset: 0x0050781E
		// (set) Token: 0x060247CE RID: 149454 RVA: 0x00509626 File Offset: 0x00507826
		public INavMeshAkiEntitySourceT Source { get; set; }

		// Token: 0x1700A2C1 RID: 41665
		// (get) Token: 0x060247CF RID: 149455 RVA: 0x0050962F File Offset: 0x0050782F
		// (set) Token: 0x060247D0 RID: 149456 RVA: 0x00509637 File Offset: 0x00507837
		public byte NullMask { get; set; }

		// Token: 0x060247D1 RID: 149457 RVA: 0x00509640 File Offset: 0x00507840
		public INavMeshComponentT()
		{
			this.Disabled = false;
			this.Source = null;
			this.NullMask = 0;
		}
	}
}

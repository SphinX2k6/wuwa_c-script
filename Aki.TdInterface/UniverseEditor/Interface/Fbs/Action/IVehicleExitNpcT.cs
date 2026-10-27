using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007518 RID: 29976
	public class IVehicleExitNpcT
	{
		// Token: 0x1700E377 RID: 58231
		// (get) Token: 0x0603685B RID: 223323 RVA: 0x00768267 File Offset: 0x00766467
		// (set) Token: 0x0603685C RID: 223324 RVA: 0x0076826F File Offset: 0x0076646F
		public int TargetNpc { get; set; }

		// Token: 0x1700E378 RID: 58232
		// (get) Token: 0x0603685D RID: 223325 RVA: 0x00768278 File Offset: 0x00766478
		// (set) Token: 0x0603685E RID: 223326 RVA: 0x00768280 File Offset: 0x00766480
		public TExitVehicleTypeUnion ExitType { get; set; }

		// Token: 0x0603685F RID: 223327 RVA: 0x00768289 File Offset: 0x00766489
		public IVehicleExitNpcT()
		{
			this.TargetNpc = 0;
			this.ExitType = null;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D14 RID: 32020
	public class IVehicleExitPlayerT
	{
		// Token: 0x1700EFAC RID: 61356
		// (get) Token: 0x06039CAC RID: 236716 RVA: 0x007CBE41 File Offset: 0x007CA041
		// (set) Token: 0x06039CAD RID: 236717 RVA: 0x007CBE49 File Offset: 0x007CA049
		public bool DestroyVehicle { get; set; }

		// Token: 0x1700EFAD RID: 61357
		// (get) Token: 0x06039CAE RID: 236718 RVA: 0x007CBE52 File Offset: 0x007CA052
		// (set) Token: 0x06039CAF RID: 236719 RVA: 0x007CBE5A File Offset: 0x007CA05A
		public TExitVehicleTypeUnion ExitType { get; set; }

		// Token: 0x1700EFAE RID: 61358
		// (get) Token: 0x06039CB0 RID: 236720 RVA: 0x007CBE63 File Offset: 0x007CA063
		// (set) Token: 0x06039CB1 RID: 236721 RVA: 0x007CBE6B File Offset: 0x007CA06B
		public byte NullMask { get; set; }

		// Token: 0x06039CB2 RID: 236722 RVA: 0x007CBE74 File Offset: 0x007CA074
		public IVehicleExitPlayerT()
		{
			this.DestroyVehicle = false;
			this.ExitType = null;
			this.NullMask = 0;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200751E RID: 29982
	public class IVehicleExitPlayerT
	{
		// Token: 0x1700E382 RID: 58242
		// (get) Token: 0x06036896 RID: 223382 RVA: 0x00768B99 File Offset: 0x00766D99
		// (set) Token: 0x06036897 RID: 223383 RVA: 0x00768BA1 File Offset: 0x00766DA1
		public bool DestroyVehicle { get; set; }

		// Token: 0x1700E383 RID: 58243
		// (get) Token: 0x06036898 RID: 223384 RVA: 0x00768BAA File Offset: 0x00766DAA
		// (set) Token: 0x06036899 RID: 223385 RVA: 0x00768BB2 File Offset: 0x00766DB2
		public TExitVehicleTypeUnion ExitType { get; set; }

		// Token: 0x1700E384 RID: 58244
		// (get) Token: 0x0603689A RID: 223386 RVA: 0x00768BBB File Offset: 0x00766DBB
		// (set) Token: 0x0603689B RID: 223387 RVA: 0x00768BC3 File Offset: 0x00766DC3
		public byte NullMask { get; set; }

		// Token: 0x0603689C RID: 223388 RVA: 0x00768BCC File Offset: 0x00766DCC
		public IVehicleExitPlayerT()
		{
			this.DestroyVehicle = false;
			this.ExitType = null;
			this.NullMask = 0;
		}
	}
}

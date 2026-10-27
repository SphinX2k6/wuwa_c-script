using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063BF RID: 25535
	public class IClientFollowShooterLeisureInteractT
	{
		// Token: 0x1700BE49 RID: 48713
		// (get) Token: 0x0602C2C3 RID: 180931 RVA: 0x00610BA3 File Offset: 0x0060EDA3
		// (set) Token: 0x0602C2C4 RID: 180932 RVA: 0x00610BAB File Offset: 0x0060EDAB
		public int Id { get; set; }

		// Token: 0x1700BE4A RID: 48714
		// (get) Token: 0x0602C2C5 RID: 180933 RVA: 0x00610BB4 File Offset: 0x0060EDB4
		// (set) Token: 0x0602C2C6 RID: 180934 RVA: 0x00610BBC File Offset: 0x0060EDBC
		public TClientFollowShooterLeisureTypeUnion InteractType { get; set; }

		// Token: 0x0602C2C7 RID: 180935 RVA: 0x00610BC5 File Offset: 0x0060EDC5
		public IClientFollowShooterLeisureInteractT()
		{
			this.Id = 0;
			this.InteractType = null;
		}
	}
}

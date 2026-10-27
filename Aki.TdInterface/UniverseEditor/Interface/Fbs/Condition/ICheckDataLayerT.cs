using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049C2 RID: 18882
	public class ICheckDataLayerT
	{
		// Token: 0x17008885 RID: 34949
		// (get) Token: 0x0601D7AC RID: 120748 RVA: 0x00426FEC File Offset: 0x004251EC
		// (set) Token: 0x0601D7AD RID: 120749 RVA: 0x00426FF4 File Offset: 0x004251F4
		public int DataLayerId { get; set; }

		// Token: 0x17008886 RID: 34950
		// (get) Token: 0x0601D7AE RID: 120750 RVA: 0x00426FFD File Offset: 0x004251FD
		// (set) Token: 0x0601D7AF RID: 120751 RVA: 0x00427005 File Offset: 0x00425205
		public bool IsLoad { get; set; }

		// Token: 0x0601D7B0 RID: 120752 RVA: 0x0042700E File Offset: 0x0042520E
		public ICheckDataLayerT()
		{
			this.DataLayerId = 0;
			this.IsLoad = false;
		}
	}
}

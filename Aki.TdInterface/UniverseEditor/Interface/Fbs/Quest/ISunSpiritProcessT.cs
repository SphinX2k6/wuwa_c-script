using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004593 RID: 17811
	public class ISunSpiritProcessT
	{
		// Token: 0x17007C90 RID: 31888
		// (get) Token: 0x06019FA6 RID: 106406 RVA: 0x003B4726 File Offset: 0x003B2926
		// (set) Token: 0x06019FA7 RID: 106407 RVA: 0x003B472E File Offset: 0x003B292E
		public int LauncherId { get; set; }

		// Token: 0x17007C91 RID: 31889
		// (get) Token: 0x06019FA8 RID: 106408 RVA: 0x003B4737 File Offset: 0x003B2937
		// (set) Token: 0x06019FA9 RID: 106409 RVA: 0x003B473F File Offset: 0x003B293F
		public bool IsRecycle { get; set; }

		// Token: 0x17007C92 RID: 31890
		// (get) Token: 0x06019FAA RID: 106410 RVA: 0x003B4748 File Offset: 0x003B2948
		// (set) Token: 0x06019FAB RID: 106411 RVA: 0x003B4750 File Offset: 0x003B2950
		public byte NullMask { get; set; }

		// Token: 0x06019FAC RID: 106412 RVA: 0x003B4759 File Offset: 0x003B2959
		public ISunSpiritProcessT()
		{
			this.LauncherId = 0;
			this.IsRecycle = false;
			this.NullMask = 0;
		}
	}
}

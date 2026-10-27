using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063EF RID: 25583
	public class IClientSetSeasonStateT
	{
		// Token: 0x1700BE8C RID: 48780
		// (get) Token: 0x0602C42F RID: 181295 RVA: 0x0061348B File Offset: 0x0061168B
		// (set) Token: 0x0602C430 RID: 181296 RVA: 0x00613493 File Offset: 0x00611693
		public int VolumeId { get; set; }

		// Token: 0x1700BE8D RID: 48781
		// (get) Token: 0x0602C431 RID: 181297 RVA: 0x0061349C File Offset: 0x0061169C
		// (set) Token: 0x0602C432 RID: 181298 RVA: 0x006134A4 File Offset: 0x006116A4
		public TClientSetSeasonStateUnion Config { get; set; }

		// Token: 0x0602C433 RID: 181299 RVA: 0x006134AD File Offset: 0x006116AD
		public IClientSetSeasonStateT()
		{
			this.VolumeId = 0;
			this.Config = null;
		}
	}
}

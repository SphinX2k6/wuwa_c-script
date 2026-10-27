using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061B0 RID: 25008
	public class IAudioStateT
	{
		// Token: 0x1700BA7A RID: 47738
		// (get) Token: 0x0602B17C RID: 176508 RVA: 0x005F12FA File Offset: 0x005EF4FA
		// (set) Token: 0x0602B17D RID: 176509 RVA: 0x005F1302 File Offset: 0x005EF502
		public string Group { get; set; }

		// Token: 0x1700BA7B RID: 47739
		// (get) Token: 0x0602B17E RID: 176510 RVA: 0x005F130B File Offset: 0x005EF50B
		// (set) Token: 0x0602B17F RID: 176511 RVA: 0x005F1313 File Offset: 0x005EF513
		public string State { get; set; }

		// Token: 0x0602B180 RID: 176512 RVA: 0x005F131C File Offset: 0x005EF51C
		public IAudioStateT()
		{
			this.Group = null;
			this.State = null;
		}
	}
}

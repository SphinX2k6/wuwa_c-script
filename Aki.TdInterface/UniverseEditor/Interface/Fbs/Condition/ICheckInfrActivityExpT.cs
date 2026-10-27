using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A76 RID: 19062
	public class ICheckInfrActivityExpT
	{
		// Token: 0x17008A11 RID: 35345
		// (get) Token: 0x0601DE06 RID: 122374 RVA: 0x004325BA File Offset: 0x004307BA
		// (set) Token: 0x0601DE07 RID: 122375 RVA: 0x004325C2 File Offset: 0x004307C2
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x17008A12 RID: 35346
		// (get) Token: 0x0601DE08 RID: 122376 RVA: 0x004325CB File Offset: 0x004307CB
		// (set) Token: 0x0601DE09 RID: 122377 RVA: 0x004325D3 File Offset: 0x004307D3
		public ECompare Compare { get; set; }

		// Token: 0x17008A13 RID: 35347
		// (get) Token: 0x0601DE0A RID: 122378 RVA: 0x004325DC File Offset: 0x004307DC
		// (set) Token: 0x0601DE0B RID: 122379 RVA: 0x004325E4 File Offset: 0x004307E4
		public int Exp { get; set; }

		// Token: 0x0601DE0C RID: 122380 RVA: 0x004325ED File Offset: 0x004307ED
		public ICheckInfrActivityExpT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.Compare = ECompare.Eq;
			this.Exp = 0;
		}
	}
}

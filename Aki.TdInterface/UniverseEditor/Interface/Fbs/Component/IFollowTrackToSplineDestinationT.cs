using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005821 RID: 22561
	public class IFollowTrackToSplineDestinationT
	{
		// Token: 0x1700A34E RID: 41806
		// (get) Token: 0x06024827 RID: 149543 RVA: 0x00504177 File Offset: 0x00502377
		// (set) Token: 0x06024828 RID: 149544 RVA: 0x0050417F File Offset: 0x0050237F
		public EFollowTrackEndType Type { get; set; }

		// Token: 0x1700A34F RID: 41807
		// (get) Token: 0x06024829 RID: 149545 RVA: 0x00504188 File Offset: 0x00502388
		// (set) Token: 0x0602482A RID: 149546 RVA: 0x00504190 File Offset: 0x00502390
		public string ChangeSelfState { get; set; }

		// Token: 0x0602482B RID: 149547 RVA: 0x00504199 File Offset: 0x00502399
		public IFollowTrackToSplineDestinationT()
		{
			this.Type = EFollowTrackEndType.ToStart;
			this.ChangeSelfState = null;
		}
	}
}

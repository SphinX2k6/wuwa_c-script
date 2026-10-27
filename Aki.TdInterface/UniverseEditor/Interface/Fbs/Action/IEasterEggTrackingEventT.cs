using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006628 RID: 26152
	public class IEasterEggTrackingEventT
	{
		// Token: 0x1700C24A RID: 49738
		// (get) Token: 0x0602D69D RID: 186013 RVA: 0x00638C20 File Offset: 0x00636E20
		// (set) Token: 0x0602D69E RID: 186014 RVA: 0x00638C28 File Offset: 0x00636E28
		public ETrackingEventType Type { get; set; }

		// Token: 0x1700C24B RID: 49739
		// (get) Token: 0x0602D69F RID: 186015 RVA: 0x00638C31 File Offset: 0x00636E31
		// (set) Token: 0x0602D6A0 RID: 186016 RVA: 0x00638C39 File Offset: 0x00636E39
		public int EasterEggId { get; set; }

		// Token: 0x0602D6A1 RID: 186017 RVA: 0x00638C42 File Offset: 0x00636E42
		public IEasterEggTrackingEventT()
		{
			this.Type = ETrackingEventType.EasterEgg;
			this.EasterEggId = 0;
		}
	}
}

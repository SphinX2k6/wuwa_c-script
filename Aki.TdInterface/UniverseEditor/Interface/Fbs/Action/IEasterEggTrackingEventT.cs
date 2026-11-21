using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C99 RID: 27801
	public class IEasterEggTrackingEventT
	{
		// Token: 0x1700CBE8 RID: 52200
		// (get) Token: 0x0602FE6E RID: 196206 RVA: 0x00685788 File Offset: 0x00683988
		// (set) Token: 0x0602FE6F RID: 196207 RVA: 0x00685790 File Offset: 0x00683990
		public ETrackingEventType Type { get; set; }

		// Token: 0x1700CBE9 RID: 52201
		// (get) Token: 0x0602FE70 RID: 196208 RVA: 0x00685799 File Offset: 0x00683999
		// (set) Token: 0x0602FE71 RID: 196209 RVA: 0x006857A1 File Offset: 0x006839A1
		public int EasterEggId { get; set; }

		// Token: 0x0602FE72 RID: 196210 RVA: 0x006857AA File Offset: 0x006839AA
		public IEasterEggTrackingEventT()
		{
			this.Type = ETrackingEventType.EasterEgg;
			this.EasterEggId = 0;
		}
	}
}

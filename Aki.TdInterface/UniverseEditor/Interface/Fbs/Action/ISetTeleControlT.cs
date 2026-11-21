using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007855 RID: 30805
	public class ISetTeleControlT
	{
		// Token: 0x1700E1FA RID: 57850
		// (get) Token: 0x060362DF RID: 221919 RVA: 0x007420F9 File Offset: 0x007402F9
		// (set) Token: 0x060362E0 RID: 221920 RVA: 0x00742101 File Offset: 0x00740301
		public TSetTeleControlConfigUnion Config { get; set; }

		// Token: 0x060362E1 RID: 221921 RVA: 0x0074210A File Offset: 0x0074030A
		public ISetTeleControlT()
		{
			this.Config = null;
		}
	}
}

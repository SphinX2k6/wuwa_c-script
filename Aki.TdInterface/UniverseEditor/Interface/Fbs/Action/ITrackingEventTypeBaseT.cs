using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007434 RID: 29748
	public class ITrackingEventTypeBaseT
	{
		// Token: 0x1700E1E0 RID: 57824
		// (get) Token: 0x060360B8 RID: 221368 RVA: 0x00759D9E File Offset: 0x00757F9E
		// (set) Token: 0x060360B9 RID: 221369 RVA: 0x00759DA6 File Offset: 0x00757FA6
		public ETrackingEventType Type { get; set; }

		// Token: 0x060360BA RID: 221370 RVA: 0x00759DAF File Offset: 0x00757FAF
		public ITrackingEventTypeBaseT()
		{
			this.Type = ETrackingEventType.EasterEgg;
		}
	}
}

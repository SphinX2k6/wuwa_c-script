using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005952 RID: 22866
	public class IHookLockScreenDetectTypeBaseT
	{
		// Token: 0x1700A615 RID: 42517
		// (get) Token: 0x0602540D RID: 152589 RVA: 0x0051D592 File Offset: 0x0051B792
		// (set) Token: 0x0602540E RID: 152590 RVA: 0x0051D59A File Offset: 0x0051B79A
		public EHookLockScreenDetectType Type { get; set; }

		// Token: 0x0602540F RID: 152591 RVA: 0x0051D5A3 File Offset: 0x0051B7A3
		public IHookLockScreenDetectTypeBaseT()
		{
			this.Type = EHookLockScreenDetectType.CentralEllipse;
		}
	}
}

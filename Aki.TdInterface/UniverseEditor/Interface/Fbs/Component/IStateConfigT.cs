using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FB2 RID: 24498
	public class IStateConfigT
	{
		// Token: 0x1700B571 RID: 46449
		// (get) Token: 0x06029376 RID: 168822 RVA: 0x005A0697 File Offset: 0x0059E897
		// (set) Token: 0x06029377 RID: 168823 RVA: 0x005A069F File Offset: 0x0059E89F
		public string State { get; set; }

		// Token: 0x1700B572 RID: 46450
		// (get) Token: 0x06029378 RID: 168824 RVA: 0x005A06A8 File Offset: 0x0059E8A8
		// (set) Token: 0x06029379 RID: 168825 RVA: 0x005A06B0 File Offset: 0x0059E8B0
		public float Duration { get; set; }

		// Token: 0x0602937A RID: 168826 RVA: 0x005A06B9 File Offset: 0x0059E8B9
		public IStateConfigT()
		{
			this.State = null;
			this.Duration = 0f;
		}
	}
}

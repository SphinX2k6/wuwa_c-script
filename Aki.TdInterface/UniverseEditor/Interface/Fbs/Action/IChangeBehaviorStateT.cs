using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006941 RID: 26945
	public class IChangeBehaviorStateT
	{
		// Token: 0x1700C660 RID: 50784
		// (get) Token: 0x0602E306 RID: 189190 RVA: 0x0064F538 File Offset: 0x0064D738
		// (set) Token: 0x0602E307 RID: 189191 RVA: 0x0064F540 File Offset: 0x0064D740
		public int StateId { get; set; }

		// Token: 0x1700C661 RID: 50785
		// (get) Token: 0x0602E308 RID: 189192 RVA: 0x0064F549 File Offset: 0x0064D749
		// (set) Token: 0x0602E309 RID: 189193 RVA: 0x0064F551 File Offset: 0x0064D751
		public bool IsInstant { get; set; }

		// Token: 0x0602E30A RID: 189194 RVA: 0x0064F55A File Offset: 0x0064D75A
		public IChangeBehaviorStateT()
		{
			this.StateId = 0;
			this.IsInstant = false;
		}
	}
}

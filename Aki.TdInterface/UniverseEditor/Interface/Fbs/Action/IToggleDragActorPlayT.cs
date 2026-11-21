using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BE2 RID: 31714
	public class IToggleDragActorPlayT
	{
		// Token: 0x1700ED93 RID: 60819
		// (get) Token: 0x060392A4 RID: 234148 RVA: 0x007B9655 File Offset: 0x007B7855
		// (set) Token: 0x060392A5 RID: 234149 RVA: 0x007B965D File Offset: 0x007B785D
		public TToggleDragActorPlayUnion Config { get; set; }

		// Token: 0x060392A6 RID: 234150 RVA: 0x007B9666 File Offset: 0x007B7866
		public IToggleDragActorPlayT()
		{
			this.Config = null;
		}
	}
}

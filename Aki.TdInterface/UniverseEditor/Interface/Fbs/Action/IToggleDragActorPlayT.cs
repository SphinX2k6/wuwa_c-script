using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073F8 RID: 29688
	public class IToggleDragActorPlayT
	{
		// Token: 0x1700E17E RID: 57726
		// (get) Token: 0x06035EF1 RID: 220913 RVA: 0x00756EE1 File Offset: 0x007550E1
		// (set) Token: 0x06035EF2 RID: 220914 RVA: 0x00756EE9 File Offset: 0x007550E9
		public TToggleDragActorPlayUnion Config { get; set; }

		// Token: 0x06035EF3 RID: 220915 RVA: 0x00756EF2 File Offset: 0x007550F2
		public IToggleDragActorPlayT()
		{
			this.Config = null;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073FB RID: 29691
	public class IToggleDragActorPlayDisableT
	{
		// Token: 0x1700E181 RID: 57729
		// (get) Token: 0x06035F03 RID: 220931 RVA: 0x0075708E File Offset: 0x0075528E
		// (set) Token: 0x06035F04 RID: 220932 RVA: 0x00757096 File Offset: 0x00755296
		public EToggleDragActorPlayType Type { get; set; }

		// Token: 0x06035F05 RID: 220933 RVA: 0x0075709F File Offset: 0x0075529F
		public IToggleDragActorPlayDisableT()
		{
			this.Type = EToggleDragActorPlayType.Enable;
		}
	}
}

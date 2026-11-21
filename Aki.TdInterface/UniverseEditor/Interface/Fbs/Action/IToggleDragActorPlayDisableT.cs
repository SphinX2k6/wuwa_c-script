using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BE5 RID: 31717
	public class IToggleDragActorPlayDisableT
	{
		// Token: 0x1700ED96 RID: 60822
		// (get) Token: 0x060392B6 RID: 234166 RVA: 0x007B9802 File Offset: 0x007B7A02
		// (set) Token: 0x060392B7 RID: 234167 RVA: 0x007B980A File Offset: 0x007B7A0A
		public EToggleDragActorPlayType Type { get; set; }

		// Token: 0x060392B8 RID: 234168 RVA: 0x007B9813 File Offset: 0x007B7A13
		public IToggleDragActorPlayDisableT()
		{
			this.Type = EToggleDragActorPlayType.Enable;
		}
	}
}

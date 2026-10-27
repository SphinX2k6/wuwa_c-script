using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007401 RID: 29697
	public class IToggleDragActorPlayTypeT
	{
		// Token: 0x1700E195 RID: 57749
		// (get) Token: 0x06035F49 RID: 221001 RVA: 0x00757896 File Offset: 0x00755A96
		// (set) Token: 0x06035F4A RID: 221002 RVA: 0x0075789E File Offset: 0x00755A9E
		public EToggleDragActorPlayType Type { get; set; }

		// Token: 0x06035F4B RID: 221003 RVA: 0x007578A7 File Offset: 0x00755AA7
		public IToggleDragActorPlayTypeT()
		{
			this.Type = EToggleDragActorPlayType.Enable;
		}
	}
}

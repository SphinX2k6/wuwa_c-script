using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200552B RID: 21803
	public class IMechascoutDragInstantT
	{
		// Token: 0x1700A103 RID: 41219
		// (get) Token: 0x0602406F RID: 147567 RVA: 0x004FA66A File Offset: 0x004F886A
		// (set) Token: 0x06024070 RID: 147568 RVA: 0x004FA672 File Offset: 0x004F8872
		public EMechascoutDragType Type { get; set; }

		// Token: 0x06024071 RID: 147569 RVA: 0x004FA67B File Offset: 0x004F887B
		public IMechascoutDragInstantT()
		{
			this.Type = EMechascoutDragType.Instant;
		}
	}
}

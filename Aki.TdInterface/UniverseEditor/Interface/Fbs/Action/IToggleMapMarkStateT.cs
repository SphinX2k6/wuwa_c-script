using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007410 RID: 29712
	public class IToggleMapMarkStateT
	{
		// Token: 0x1700E1A8 RID: 57768
		// (get) Token: 0x06035FA9 RID: 221097 RVA: 0x00758176 File Offset: 0x00756376
		// (set) Token: 0x06035FAA RID: 221098 RVA: 0x0075817E File Offset: 0x0075637E
		public EMapMarkState Type { get; set; }

		// Token: 0x06035FAB RID: 221099 RVA: 0x00758187 File Offset: 0x00756387
		public IToggleMapMarkStateT()
		{
			this.Type = EMapMarkState.Show;
		}
	}
}

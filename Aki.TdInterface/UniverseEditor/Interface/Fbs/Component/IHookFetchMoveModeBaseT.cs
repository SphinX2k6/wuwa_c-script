using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053B7 RID: 21431
	public class IHookFetchMoveModeBaseT
	{
		// Token: 0x17009D89 RID: 40329
		// (get) Token: 0x060231FA RID: 143866 RVA: 0x004DCC1A File Offset: 0x004DAE1A
		// (set) Token: 0x060231FB RID: 143867 RVA: 0x004DCC22 File Offset: 0x004DAE22
		public EHookFetchMoveMode Type { get; set; }

		// Token: 0x060231FC RID: 143868 RVA: 0x004DCC2B File Offset: 0x004DAE2B
		public IHookFetchMoveModeBaseT()
		{
			this.Type = EHookFetchMoveMode.Uniform;
		}
	}
}

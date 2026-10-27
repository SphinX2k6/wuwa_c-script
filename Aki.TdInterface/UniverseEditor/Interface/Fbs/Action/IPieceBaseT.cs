using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CCD RID: 27853
	public class IPieceBaseT
	{
		// Token: 0x1700CF60 RID: 53088
		// (get) Token: 0x0603117B RID: 201083 RVA: 0x006A9757 File Offset: 0x006A7957
		// (set) Token: 0x0603117C RID: 201084 RVA: 0x006A975F File Offset: 0x006A795F
		public IPieceIndexT Index { get; set; }

		// Token: 0x1700CF61 RID: 53089
		// (get) Token: 0x0603117D RID: 201085 RVA: 0x006A9768 File Offset: 0x006A7968
		// (set) Token: 0x0603117E RID: 201086 RVA: 0x006A9770 File Offset: 0x006A7970
		public bool Active { get; set; }

		// Token: 0x0603117F RID: 201087 RVA: 0x006A9779 File Offset: 0x006A7979
		public IPieceBaseT()
		{
			this.Index = null;
			this.Active = false;
		}
	}
}

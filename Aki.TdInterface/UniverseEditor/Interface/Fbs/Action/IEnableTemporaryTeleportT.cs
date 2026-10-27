using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200669A RID: 26266
	public class IEnableTemporaryTeleportT
	{
		// Token: 0x1700C334 RID: 49972
		// (get) Token: 0x0602DA79 RID: 187001 RVA: 0x0063F7E4 File Offset: 0x0063D9E4
		// (set) Token: 0x0602DA7A RID: 187002 RVA: 0x0063F7EC File Offset: 0x0063D9EC
		public bool Enable { get; set; }

		// Token: 0x1700C335 RID: 49973
		// (get) Token: 0x0602DA7B RID: 187003 RVA: 0x0063F7F5 File Offset: 0x0063D9F5
		// (set) Token: 0x0602DA7C RID: 187004 RVA: 0x0063F7FD File Offset: 0x0063D9FD
		public int RangeEntity { get; set; }

		// Token: 0x0602DA7D RID: 187005 RVA: 0x0063F806 File Offset: 0x0063DA06
		public IEnableTemporaryTeleportT()
		{
			this.Enable = false;
			this.RangeEntity = 0;
		}
	}
}

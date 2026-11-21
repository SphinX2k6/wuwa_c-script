using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CE7 RID: 27879
	public class IEnableLevelPlayConfigT
	{
		// Token: 0x1700CC79 RID: 52345
		// (get) Token: 0x060300F8 RID: 196856 RVA: 0x00689DE8 File Offset: 0x00687FE8
		// (set) Token: 0x060300F9 RID: 196857 RVA: 0x00689DF0 File Offset: 0x00687FF0
		public int LevelPlayId { get; set; }

		// Token: 0x1700CC7A RID: 52346
		// (get) Token: 0x060300FA RID: 196858 RVA: 0x00689DF9 File Offset: 0x00687FF9
		// (set) Token: 0x060300FB RID: 196859 RVA: 0x00689E01 File Offset: 0x00688001
		public bool Enable { get; set; }

		// Token: 0x060300FC RID: 196860 RVA: 0x00689E0A File Offset: 0x0068800A
		public IEnableLevelPlayConfigT()
		{
			this.LevelPlayId = 0;
			this.Enable = false;
		}
	}
}

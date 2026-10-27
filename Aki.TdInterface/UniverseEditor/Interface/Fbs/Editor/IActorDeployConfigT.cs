using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200481B RID: 18459
	public class IActorDeployConfigT
	{
		// Token: 0x1700846F RID: 33903
		// (get) Token: 0x0601C82D RID: 116781 RVA: 0x0040851A File Offset: 0x0040671A
		// (set) Token: 0x0601C82E RID: 116782 RVA: 0x00408522 File Offset: 0x00406722
		public string Folder { get; set; }

		// Token: 0x17008470 RID: 33904
		// (get) Token: 0x0601C82F RID: 116783 RVA: 0x0040852B File Offset: 0x0040672B
		// (set) Token: 0x0601C830 RID: 116784 RVA: 0x00408533 File Offset: 0x00406733
		public string SubFolder { get; set; }

		// Token: 0x0601C831 RID: 116785 RVA: 0x0040853C File Offset: 0x0040673C
		public IActorDeployConfigT()
		{
			this.Folder = null;
			this.SubFolder = null;
		}
	}
}

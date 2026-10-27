using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004878 RID: 18552
	public class IEntityDeployConfigT
	{
		// Token: 0x17008642 RID: 34370
		// (get) Token: 0x0601CE58 RID: 118360 RVA: 0x004159F6 File Offset: 0x00413BF6
		// (set) Token: 0x0601CE59 RID: 118361 RVA: 0x004159FE File Offset: 0x00413BFE
		public string Folder { get; set; }

		// Token: 0x17008643 RID: 34371
		// (get) Token: 0x0601CE5A RID: 118362 RVA: 0x00415A07 File Offset: 0x00413C07
		// (set) Token: 0x0601CE5B RID: 118363 RVA: 0x00415A0F File Offset: 0x00413C0F
		public string SubFolder { get; set; }

		// Token: 0x0601CE5C RID: 118364 RVA: 0x00415A18 File Offset: 0x00413C18
		public IEntityDeployConfigT()
		{
			this.Folder = null;
			this.SubFolder = null;
		}
	}
}

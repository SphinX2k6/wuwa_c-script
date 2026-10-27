using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047F1 RID: 18417
	public class IVoxelInfoT
	{
		// Token: 0x1700845D RID: 33885
		// (get) Token: 0x0601C7C8 RID: 116680 RVA: 0x004079F2 File Offset: 0x00405BF2
		// (set) Token: 0x0601C7C9 RID: 116681 RVA: 0x004079FA File Offset: 0x00405BFA
		public int EnvType { get; set; }

		// Token: 0x0601C7CA RID: 116682 RVA: 0x00407A03 File Offset: 0x00405C03
		public IVoxelInfoT()
		{
			this.EnvType = 0;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C59 RID: 19545
	public class IVoxelInfoT
	{
		// Token: 0x17008AA8 RID: 35496
		// (get) Token: 0x0601DFC5 RID: 122821 RVA: 0x00434342 File Offset: 0x00432542
		// (set) Token: 0x0601DFC6 RID: 122822 RVA: 0x0043434A File Offset: 0x0043254A
		public int EnvType { get; set; }

		// Token: 0x0601DFC7 RID: 122823 RVA: 0x00434353 File Offset: 0x00432553
		public IVoxelInfoT()
		{
			this.EnvType = 0;
		}
	}
}

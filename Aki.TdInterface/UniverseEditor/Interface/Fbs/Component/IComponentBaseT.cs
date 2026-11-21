using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005539 RID: 21817
	public class IComponentBaseT
	{
		// Token: 0x17009C00 RID: 39936
		// (get) Token: 0x0602282F RID: 141359 RVA: 0x004C1004 File Offset: 0x004BF204
		// (set) Token: 0x06022830 RID: 141360 RVA: 0x004C100C File Offset: 0x004BF20C
		public bool Disabled { get; set; }

		// Token: 0x17009C01 RID: 39937
		// (get) Token: 0x06022831 RID: 141361 RVA: 0x004C1015 File Offset: 0x004BF215
		// (set) Token: 0x06022832 RID: 141362 RVA: 0x004C101D File Offset: 0x004BF21D
		public byte NullMask { get; set; }

		// Token: 0x06022833 RID: 141363 RVA: 0x004C1026 File Offset: 0x004BF226
		public IComponentBaseT()
		{
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}

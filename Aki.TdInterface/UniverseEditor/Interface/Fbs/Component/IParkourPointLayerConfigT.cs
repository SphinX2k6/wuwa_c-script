using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056B1 RID: 22193
	public class IParkourPointLayerConfigT
	{
		// Token: 0x1700A50E RID: 42254
		// (get) Token: 0x060250C0 RID: 151744 RVA: 0x0051D6E8 File Offset: 0x0051B8E8
		// (set) Token: 0x060250C1 RID: 151745 RVA: 0x0051D6F0 File Offset: 0x0051B8F0
		public int Width { get; set; }

		// Token: 0x1700A50F RID: 42255
		// (get) Token: 0x060250C2 RID: 151746 RVA: 0x0051D6F9 File Offset: 0x0051B8F9
		// (set) Token: 0x060250C3 RID: 151747 RVA: 0x0051D701 File Offset: 0x0051B901
		public int Length { get; set; }

		// Token: 0x060250C4 RID: 151748 RVA: 0x0051D70A File Offset: 0x0051B90A
		public IParkourPointLayerConfigT()
		{
			this.Width = 0;
			this.Length = 0;
		}
	}
}

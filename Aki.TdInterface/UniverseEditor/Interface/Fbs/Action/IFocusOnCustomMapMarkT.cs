using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006841 RID: 26689
	public class IFocusOnCustomMapMarkT
	{
		// Token: 0x1700C646 RID: 50758
		// (get) Token: 0x0602E895 RID: 190613 RVA: 0x0065984C File Offset: 0x00657A4C
		// (set) Token: 0x0602E896 RID: 190614 RVA: 0x00659854 File Offset: 0x00657A54
		public EMapMarkType Type { get; set; }

		// Token: 0x1700C647 RID: 50759
		// (get) Token: 0x0602E897 RID: 190615 RVA: 0x0065985D File Offset: 0x00657A5D
		// (set) Token: 0x0602E898 RID: 190616 RVA: 0x00659865 File Offset: 0x00657A65
		public int MarkId { get; set; }

		// Token: 0x0602E899 RID: 190617 RVA: 0x0065986E File Offset: 0x00657A6E
		public IFocusOnCustomMapMarkT()
		{
			this.Type = EMapMarkType.Custom;
			this.MarkId = 0;
		}
	}
}

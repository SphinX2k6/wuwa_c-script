using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075AD RID: 30125
	public class IReignsSetPropertyVisibleT
	{
		// Token: 0x1700DD83 RID: 56707
		// (get) Token: 0x06034D82 RID: 216450 RVA: 0x0071A8EC File Offset: 0x00718AEC
		// (set) Token: 0x06034D83 RID: 216451 RVA: 0x0071A8F4 File Offset: 0x00718AF4
		public int PropertyId { get; set; }

		// Token: 0x1700DD84 RID: 56708
		// (get) Token: 0x06034D84 RID: 216452 RVA: 0x0071A8FD File Offset: 0x00718AFD
		// (set) Token: 0x06034D85 RID: 216453 RVA: 0x0071A905 File Offset: 0x00718B05
		public bool IsVisible { get; set; }

		// Token: 0x06034D86 RID: 216454 RVA: 0x0071A90E File Offset: 0x00718B0E
		public IReignsSetPropertyVisibleT()
		{
			this.PropertyId = 0;
			this.IsVisible = false;
		}
	}
}

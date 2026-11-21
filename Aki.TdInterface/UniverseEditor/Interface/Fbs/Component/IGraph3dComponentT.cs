using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200588D RID: 22669
	public class IGraph3dComponentT
	{
		// Token: 0x1700A44A RID: 42058
		// (get) Token: 0x06024C3E RID: 150590 RVA: 0x0050CB0D File Offset: 0x0050AD0D
		// (set) Token: 0x06024C3F RID: 150591 RVA: 0x0050CB15 File Offset: 0x0050AD15
		public bool Disabled { get; set; }

		// Token: 0x1700A44B RID: 42059
		// (get) Token: 0x06024C40 RID: 150592 RVA: 0x0050CB1E File Offset: 0x0050AD1E
		// (set) Token: 0x06024C41 RID: 150593 RVA: 0x0050CB26 File Offset: 0x0050AD26
		public IGraph3dNormalT GraphConfig { get; set; }

		// Token: 0x1700A44C RID: 42060
		// (get) Token: 0x06024C42 RID: 150594 RVA: 0x0050CB2F File Offset: 0x0050AD2F
		// (set) Token: 0x06024C43 RID: 150595 RVA: 0x0050CB37 File Offset: 0x0050AD37
		public byte NullMask { get; set; }

		// Token: 0x06024C44 RID: 150596 RVA: 0x0050CB40 File Offset: 0x0050AD40
		public IGraph3dComponentT()
		{
			this.Disabled = false;
			this.GraphConfig = null;
			this.NullMask = 0;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200688F RID: 26767
	public class IGiantToggleModelT
	{
		// Token: 0x1700C6BF RID: 50879
		// (get) Token: 0x0602EAE6 RID: 191206 RVA: 0x0065D5F2 File Offset: 0x0065B7F2
		// (set) Token: 0x0602EAE7 RID: 191207 RVA: 0x0065D5FA File Offset: 0x0065B7FA
		public bool IsEnabled { get; set; }

		// Token: 0x0602EAE8 RID: 191208 RVA: 0x0065D603 File Offset: 0x0065B803
		public IGiantToggleModelT()
		{
			this.IsEnabled = false;
		}
	}
}

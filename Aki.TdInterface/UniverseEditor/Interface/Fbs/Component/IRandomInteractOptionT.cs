using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057EB RID: 22507
	public class IRandomInteractOptionT
	{
		// Token: 0x1700A81C RID: 43036
		// (get) Token: 0x06025D2A RID: 154922 RVA: 0x0053763B File Offset: 0x0053583B
		// (set) Token: 0x06025D2B RID: 154923 RVA: 0x00537643 File Offset: 0x00535843
		public int Weight { get; set; }

		// Token: 0x1700A81D RID: 43037
		// (get) Token: 0x06025D2C RID: 154924 RVA: 0x0053764C File Offset: 0x0053584C
		// (set) Token: 0x06025D2D RID: 154925 RVA: 0x00537654 File Offset: 0x00535854
		public IInteractOptionT Option { get; set; }

		// Token: 0x06025D2E RID: 154926 RVA: 0x0053765D File Offset: 0x0053585D
		public IRandomInteractOptionT()
		{
			this.Weight = 0;
			this.Option = null;
		}
	}
}

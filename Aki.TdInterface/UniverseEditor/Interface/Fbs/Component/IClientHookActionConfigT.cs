using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FAA RID: 20394
	public class IClientHookActionConfigT
	{
		// Token: 0x170093AF RID: 37807
		// (get) Token: 0x0602074B RID: 132939 RVA: 0x00484053 File Offset: 0x00482253
		// (set) Token: 0x0602074C RID: 132940 RVA: 0x0048405B File Offset: 0x0048225B
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x170093B0 RID: 37808
		// (get) Token: 0x0602074D RID: 132941 RVA: 0x00484064 File Offset: 0x00482264
		// (set) Token: 0x0602074E RID: 132942 RVA: 0x0048406C File Offset: 0x0048226C
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x170093B1 RID: 37809
		// (get) Token: 0x0602074F RID: 132943 RVA: 0x00484075 File Offset: 0x00482275
		// (set) Token: 0x06020750 RID: 132944 RVA: 0x0048407D File Offset: 0x0048227D
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x170093B2 RID: 37810
		// (get) Token: 0x06020751 RID: 132945 RVA: 0x00484086 File Offset: 0x00482286
		// (set) Token: 0x06020752 RID: 132946 RVA: 0x0048408E File Offset: 0x0048228E
		public byte NullMask { get; set; }

		// Token: 0x06020753 RID: 132947 RVA: 0x00484097 File Offset: 0x00482297
		public IClientHookActionConfigT()
		{
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.NullMask = 0;
		}
	}
}

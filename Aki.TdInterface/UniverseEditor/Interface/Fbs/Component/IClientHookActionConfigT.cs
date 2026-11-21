using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005506 RID: 21766
	public class IClientHookActionConfigT
	{
		// Token: 0x17009B87 RID: 39815
		// (get) Token: 0x0602263F RID: 140863 RVA: 0x004BD537 File Offset: 0x004BB737
		// (set) Token: 0x06022640 RID: 140864 RVA: 0x004BD53F File Offset: 0x004BB73F
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x17009B88 RID: 39816
		// (get) Token: 0x06022641 RID: 140865 RVA: 0x004BD548 File Offset: 0x004BB748
		// (set) Token: 0x06022642 RID: 140866 RVA: 0x004BD550 File Offset: 0x004BB750
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x17009B89 RID: 39817
		// (get) Token: 0x06022643 RID: 140867 RVA: 0x004BD559 File Offset: 0x004BB759
		// (set) Token: 0x06022644 RID: 140868 RVA: 0x004BD561 File Offset: 0x004BB761
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x17009B8A RID: 39818
		// (get) Token: 0x06022645 RID: 140869 RVA: 0x004BD56A File Offset: 0x004BB76A
		// (set) Token: 0x06022646 RID: 140870 RVA: 0x004BD572 File Offset: 0x004BB772
		public byte NullMask { get; set; }

		// Token: 0x06022647 RID: 140871 RVA: 0x004BD57B File Offset: 0x004BB77B
		public IClientHookActionConfigT()
		{
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.NullMask = 0;
		}
	}
}

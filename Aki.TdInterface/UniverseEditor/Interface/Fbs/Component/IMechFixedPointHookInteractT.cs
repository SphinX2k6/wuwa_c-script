using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AC9 RID: 23241
	public class IMechFixedPointHookInteractT
	{
		// Token: 0x1700A96C RID: 43372
		// (get) Token: 0x0602620B RID: 156171 RVA: 0x00539644 File Offset: 0x00537844
		// (set) Token: 0x0602620C RID: 156172 RVA: 0x0053964C File Offset: 0x0053784C
		public EMechHookInteractType Type { get; set; }

		// Token: 0x1700A96D RID: 43373
		// (get) Token: 0x0602620D RID: 156173 RVA: 0x00539655 File Offset: 0x00537855
		// (set) Token: 0x0602620E RID: 156174 RVA: 0x0053965D File Offset: 0x0053785D
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700A96E RID: 43374
		// (get) Token: 0x0602620F RID: 156175 RVA: 0x00539666 File Offset: 0x00537866
		// (set) Token: 0x06026210 RID: 156176 RVA: 0x0053966E File Offset: 0x0053786E
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700A96F RID: 43375
		// (get) Token: 0x06026211 RID: 156177 RVA: 0x00539677 File Offset: 0x00537877
		// (set) Token: 0x06026212 RID: 156178 RVA: 0x0053967F File Offset: 0x0053787F
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700A970 RID: 43376
		// (get) Token: 0x06026213 RID: 156179 RVA: 0x00539688 File Offset: 0x00537888
		// (set) Token: 0x06026214 RID: 156180 RVA: 0x00539690 File Offset: 0x00537890
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700A971 RID: 43377
		// (get) Token: 0x06026215 RID: 156181 RVA: 0x00539699 File Offset: 0x00537899
		// (set) Token: 0x06026216 RID: 156182 RVA: 0x005396A1 File Offset: 0x005378A1
		public IMechBehaviorConfigT MechBehaviorConfig { get; set; }

		// Token: 0x1700A972 RID: 43378
		// (get) Token: 0x06026217 RID: 156183 RVA: 0x005396AA File Offset: 0x005378AA
		// (set) Token: 0x06026218 RID: 156184 RVA: 0x005396B2 File Offset: 0x005378B2
		public byte NullMask { get; set; }

		// Token: 0x06026219 RID: 156185 RVA: 0x005396BB File Offset: 0x005378BB
		public IMechFixedPointHookInteractT()
		{
			this.Type = EMechHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.MechBehaviorConfig = null;
			this.NullMask = 0;
		}
	}
}

using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005949 RID: 22857
	public class IHookInteractTypeT
	{
		// Token: 0x1700A5D9 RID: 42457
		// (get) Token: 0x06025322 RID: 152354 RVA: 0x0051ABD4 File Offset: 0x00518DD4
		// (set) Token: 0x06025323 RID: 152355 RVA: 0x0051ABDC File Offset: 0x00518DDC
		public EHookInteractType Type { get; set; }

		// Token: 0x1700A5DA RID: 42458
		// (get) Token: 0x06025324 RID: 152356 RVA: 0x0051ABE5 File Offset: 0x00518DE5
		// (set) Token: 0x06025325 RID: 152357 RVA: 0x0051ABED File Offset: 0x00518DED
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700A5DB RID: 42459
		// (get) Token: 0x06025326 RID: 152358 RVA: 0x0051ABF6 File Offset: 0x00518DF6
		// (set) Token: 0x06025327 RID: 152359 RVA: 0x0051ABFE File Offset: 0x00518DFE
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700A5DC RID: 42460
		// (get) Token: 0x06025328 RID: 152360 RVA: 0x0051AC07 File Offset: 0x00518E07
		// (set) Token: 0x06025329 RID: 152361 RVA: 0x0051AC0F File Offset: 0x00518E0F
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700A5DD RID: 42461
		// (get) Token: 0x0602532A RID: 152362 RVA: 0x0051AC18 File Offset: 0x00518E18
		// (set) Token: 0x0602532B RID: 152363 RVA: 0x0051AC20 File Offset: 0x00518E20
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700A5DE RID: 42462
		// (get) Token: 0x0602532C RID: 152364 RVA: 0x0051AC29 File Offset: 0x00518E29
		// (set) Token: 0x0602532D RID: 152365 RVA: 0x0051AC31 File Offset: 0x00518E31
		public byte NullMask { get; set; }

		// Token: 0x0602532E RID: 152366 RVA: 0x0051AC3A File Offset: 0x00518E3A
		public IHookInteractTypeT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.NullMask = 0;
		}
	}
}

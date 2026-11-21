using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ADB RID: 23259
	public class IMechTransformHookT
	{
		// Token: 0x1700A9B2 RID: 43442
		// (get) Token: 0x0602631C RID: 156444 RVA: 0x0053C1B0 File Offset: 0x0053A3B0
		// (set) Token: 0x0602631D RID: 156445 RVA: 0x0053C1B8 File Offset: 0x0053A3B8
		public EHookInteractType Type { get; set; }

		// Token: 0x1700A9B3 RID: 43443
		// (get) Token: 0x0602631E RID: 156446 RVA: 0x0053C1C1 File Offset: 0x0053A3C1
		// (set) Token: 0x0602631F RID: 156447 RVA: 0x0053C1C9 File Offset: 0x0053A3C9
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700A9B4 RID: 43444
		// (get) Token: 0x06026320 RID: 156448 RVA: 0x0053C1D2 File Offset: 0x0053A3D2
		// (set) Token: 0x06026321 RID: 156449 RVA: 0x0053C1DA File Offset: 0x0053A3DA
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700A9B5 RID: 43445
		// (get) Token: 0x06026322 RID: 156450 RVA: 0x0053C1E3 File Offset: 0x0053A3E3
		// (set) Token: 0x06026323 RID: 156451 RVA: 0x0053C1EB File Offset: 0x0053A3EB
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700A9B6 RID: 43446
		// (get) Token: 0x06026324 RID: 156452 RVA: 0x0053C1F4 File Offset: 0x0053A3F4
		// (set) Token: 0x06026325 RID: 156453 RVA: 0x0053C1FC File Offset: 0x0053A3FC
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700A9B7 RID: 43447
		// (get) Token: 0x06026326 RID: 156454 RVA: 0x0053C205 File Offset: 0x0053A405
		// (set) Token: 0x06026327 RID: 156455 RVA: 0x0053C20D File Offset: 0x0053A40D
		public byte NullMask { get; set; }

		// Token: 0x06026328 RID: 156456 RVA: 0x0053C216 File Offset: 0x0053A416
		public IMechTransformHookT()
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

using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005289 RID: 21129
	public class IFlyingFeatherT
	{
		// Token: 0x17009AE8 RID: 39656
		// (get) Token: 0x060226CD RID: 141005 RVA: 0x004C5CF2 File Offset: 0x004C3EF2
		// (set) Token: 0x060226CE RID: 141006 RVA: 0x004C5CFA File Offset: 0x004C3EFA
		public EHookInteractType Type { get; set; }

		// Token: 0x17009AE9 RID: 39657
		// (get) Token: 0x060226CF RID: 141007 RVA: 0x004C5D03 File Offset: 0x004C3F03
		// (set) Token: 0x060226D0 RID: 141008 RVA: 0x004C5D0B File Offset: 0x004C3F0B
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x17009AEA RID: 39658
		// (get) Token: 0x060226D1 RID: 141009 RVA: 0x004C5D14 File Offset: 0x004C3F14
		// (set) Token: 0x060226D2 RID: 141010 RVA: 0x004C5D1C File Offset: 0x004C3F1C
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x17009AEB RID: 39659
		// (get) Token: 0x060226D3 RID: 141011 RVA: 0x004C5D25 File Offset: 0x004C3F25
		// (set) Token: 0x060226D4 RID: 141012 RVA: 0x004C5D2D File Offset: 0x004C3F2D
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x17009AEC RID: 39660
		// (get) Token: 0x060226D5 RID: 141013 RVA: 0x004C5D36 File Offset: 0x004C3F36
		// (set) Token: 0x060226D6 RID: 141014 RVA: 0x004C5D3E File Offset: 0x004C3F3E
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x17009AED RID: 39661
		// (get) Token: 0x060226D7 RID: 141015 RVA: 0x004C5D47 File Offset: 0x004C3F47
		// (set) Token: 0x060226D8 RID: 141016 RVA: 0x004C5D4F File Offset: 0x004C3F4F
		public int EntityId { get; set; }

		// Token: 0x17009AEE RID: 39662
		// (get) Token: 0x060226D9 RID: 141017 RVA: 0x004C5D58 File Offset: 0x004C3F58
		// (set) Token: 0x060226DA RID: 141018 RVA: 0x004C5D60 File Offset: 0x004C3F60
		public byte NullMask { get; set; }

		// Token: 0x060226DB RID: 141019 RVA: 0x004C5D69 File Offset: 0x004C3F69
		public IFlyingFeatherT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.EntityId = 0;
			this.NullMask = 0;
		}
	}
}

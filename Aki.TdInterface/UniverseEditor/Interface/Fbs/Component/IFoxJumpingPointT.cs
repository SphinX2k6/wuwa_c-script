using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052BF RID: 21183
	public class IFoxJumpingPointT
	{
		// Token: 0x17009B56 RID: 39766
		// (get) Token: 0x060228BB RID: 141499 RVA: 0x004C9D24 File Offset: 0x004C7F24
		// (set) Token: 0x060228BC RID: 141500 RVA: 0x004C9D2C File Offset: 0x004C7F2C
		public EHookInteractType Type { get; set; }

		// Token: 0x17009B57 RID: 39767
		// (get) Token: 0x060228BD RID: 141501 RVA: 0x004C9D35 File Offset: 0x004C7F35
		// (set) Token: 0x060228BE RID: 141502 RVA: 0x004C9D3D File Offset: 0x004C7F3D
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x17009B58 RID: 39768
		// (get) Token: 0x060228BF RID: 141503 RVA: 0x004C9D46 File Offset: 0x004C7F46
		// (set) Token: 0x060228C0 RID: 141504 RVA: 0x004C9D4E File Offset: 0x004C7F4E
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x17009B59 RID: 39769
		// (get) Token: 0x060228C1 RID: 141505 RVA: 0x004C9D57 File Offset: 0x004C7F57
		// (set) Token: 0x060228C2 RID: 141506 RVA: 0x004C9D5F File Offset: 0x004C7F5F
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x17009B5A RID: 39770
		// (get) Token: 0x060228C3 RID: 141507 RVA: 0x004C9D68 File Offset: 0x004C7F68
		// (set) Token: 0x060228C4 RID: 141508 RVA: 0x004C9D70 File Offset: 0x004C7F70
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x17009B5B RID: 39771
		// (get) Token: 0x060228C5 RID: 141509 RVA: 0x004C9D79 File Offset: 0x004C7F79
		// (set) Token: 0x060228C6 RID: 141510 RVA: 0x004C9D81 File Offset: 0x004C7F81
		public byte NullMask { get; set; }

		// Token: 0x060228C7 RID: 141511 RVA: 0x004C9D8A File Offset: 0x004C7F8A
		public IFoxJumpingPointT()
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

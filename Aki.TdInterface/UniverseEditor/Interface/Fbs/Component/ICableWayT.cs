using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F4D RID: 20301
	public class ICableWayT
	{
		// Token: 0x17009262 RID: 37474
		// (get) Token: 0x06020295 RID: 131733 RVA: 0x00479B56 File Offset: 0x00477D56
		// (set) Token: 0x06020296 RID: 131734 RVA: 0x00479B5E File Offset: 0x00477D5E
		public EHookInteractType Type { get; set; }

		// Token: 0x17009263 RID: 37475
		// (get) Token: 0x06020297 RID: 131735 RVA: 0x00479B67 File Offset: 0x00477D67
		// (set) Token: 0x06020298 RID: 131736 RVA: 0x00479B6F File Offset: 0x00477D6F
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x17009264 RID: 37476
		// (get) Token: 0x06020299 RID: 131737 RVA: 0x00479B78 File Offset: 0x00477D78
		// (set) Token: 0x0602029A RID: 131738 RVA: 0x00479B80 File Offset: 0x00477D80
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x17009265 RID: 37477
		// (get) Token: 0x0602029B RID: 131739 RVA: 0x00479B89 File Offset: 0x00477D89
		// (set) Token: 0x0602029C RID: 131740 RVA: 0x00479B91 File Offset: 0x00477D91
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x17009266 RID: 37478
		// (get) Token: 0x0602029D RID: 131741 RVA: 0x00479B9A File Offset: 0x00477D9A
		// (set) Token: 0x0602029E RID: 131742 RVA: 0x00479BA2 File Offset: 0x00477DA2
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x17009267 RID: 37479
		// (get) Token: 0x0602029F RID: 131743 RVA: 0x00479BAB File Offset: 0x00477DAB
		// (set) Token: 0x060202A0 RID: 131744 RVA: 0x00479BB3 File Offset: 0x00477DB3
		public int SplineEntityId { get; set; }

		// Token: 0x17009268 RID: 37480
		// (get) Token: 0x060202A1 RID: 131745 RVA: 0x00479BBC File Offset: 0x00477DBC
		// (set) Token: 0x060202A2 RID: 131746 RVA: 0x00479BC4 File Offset: 0x00477DC4
		public byte NullMask { get; set; }

		// Token: 0x060202A3 RID: 131747 RVA: 0x00479BCD File Offset: 0x00477DCD
		public ICableWayT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.SplineEntityId = 0;
			this.NullMask = 0;
		}
	}
}

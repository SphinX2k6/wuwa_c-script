using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200547C RID: 21628
	public class ICableWayT
	{
		// Token: 0x170099DB RID: 39387
		// (get) Token: 0x06021FE7 RID: 139239 RVA: 0x004AFB46 File Offset: 0x004ADD46
		// (set) Token: 0x06021FE8 RID: 139240 RVA: 0x004AFB4E File Offset: 0x004ADD4E
		public EHookInteractType Type { get; set; }

		// Token: 0x170099DC RID: 39388
		// (get) Token: 0x06021FE9 RID: 139241 RVA: 0x004AFB57 File Offset: 0x004ADD57
		// (set) Token: 0x06021FEA RID: 139242 RVA: 0x004AFB5F File Offset: 0x004ADD5F
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x170099DD RID: 39389
		// (get) Token: 0x06021FEB RID: 139243 RVA: 0x004AFB68 File Offset: 0x004ADD68
		// (set) Token: 0x06021FEC RID: 139244 RVA: 0x004AFB70 File Offset: 0x004ADD70
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x170099DE RID: 39390
		// (get) Token: 0x06021FED RID: 139245 RVA: 0x004AFB79 File Offset: 0x004ADD79
		// (set) Token: 0x06021FEE RID: 139246 RVA: 0x004AFB81 File Offset: 0x004ADD81
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x170099DF RID: 39391
		// (get) Token: 0x06021FEF RID: 139247 RVA: 0x004AFB8A File Offset: 0x004ADD8A
		// (set) Token: 0x06021FF0 RID: 139248 RVA: 0x004AFB92 File Offset: 0x004ADD92
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x170099E0 RID: 39392
		// (get) Token: 0x06021FF1 RID: 139249 RVA: 0x004AFB9B File Offset: 0x004ADD9B
		// (set) Token: 0x06021FF2 RID: 139250 RVA: 0x004AFBA3 File Offset: 0x004ADDA3
		public int SplineEntityId { get; set; }

		// Token: 0x170099E1 RID: 39393
		// (get) Token: 0x06021FF3 RID: 139251 RVA: 0x004AFBAC File Offset: 0x004ADDAC
		// (set) Token: 0x06021FF4 RID: 139252 RVA: 0x004AFBB4 File Offset: 0x004ADDB4
		public byte NullMask { get; set; }

		// Token: 0x06021FF5 RID: 139253 RVA: 0x004AFBBD File Offset: 0x004ADDBD
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

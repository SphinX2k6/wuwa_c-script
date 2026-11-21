using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AD2 RID: 23250
	public class IMechHookInteractTypeT
	{
		// Token: 0x1700A98C RID: 43404
		// (get) Token: 0x06026288 RID: 156296 RVA: 0x0053A9BC File Offset: 0x00538BBC
		// (set) Token: 0x06026289 RID: 156297 RVA: 0x0053A9C4 File Offset: 0x00538BC4
		public EMechHookInteractType Type { get; set; }

		// Token: 0x1700A98D RID: 43405
		// (get) Token: 0x0602628A RID: 156298 RVA: 0x0053A9CD File Offset: 0x00538BCD
		// (set) Token: 0x0602628B RID: 156299 RVA: 0x0053A9D5 File Offset: 0x00538BD5
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700A98E RID: 43406
		// (get) Token: 0x0602628C RID: 156300 RVA: 0x0053A9DE File Offset: 0x00538BDE
		// (set) Token: 0x0602628D RID: 156301 RVA: 0x0053A9E6 File Offset: 0x00538BE6
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700A98F RID: 43407
		// (get) Token: 0x0602628E RID: 156302 RVA: 0x0053A9EF File Offset: 0x00538BEF
		// (set) Token: 0x0602628F RID: 156303 RVA: 0x0053A9F7 File Offset: 0x00538BF7
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700A990 RID: 43408
		// (get) Token: 0x06026290 RID: 156304 RVA: 0x0053AA00 File Offset: 0x00538C00
		// (set) Token: 0x06026291 RID: 156305 RVA: 0x0053AA08 File Offset: 0x00538C08
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700A991 RID: 43409
		// (get) Token: 0x06026292 RID: 156306 RVA: 0x0053AA11 File Offset: 0x00538C11
		// (set) Token: 0x06026293 RID: 156307 RVA: 0x0053AA19 File Offset: 0x00538C19
		public byte NullMask { get; set; }

		// Token: 0x06026294 RID: 156308 RVA: 0x0053AA22 File Offset: 0x00538C22
		public IMechHookInteractTypeT()
		{
			this.Type = EMechHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.NullMask = 0;
		}
	}
}

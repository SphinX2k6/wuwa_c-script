using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A08 RID: 23048
	public class ISunSpiritLauncherT
	{
		// Token: 0x1700AD2B RID: 44331
		// (get) Token: 0x060271FA RID: 160250 RVA: 0x00561DE0 File Offset: 0x0055FFE0
		// (set) Token: 0x060271FB RID: 160251 RVA: 0x00561DE8 File Offset: 0x0055FFE8
		public EHookInteractType Type { get; set; }

		// Token: 0x1700AD2C RID: 44332
		// (get) Token: 0x060271FC RID: 160252 RVA: 0x00561DF1 File Offset: 0x0055FFF1
		// (set) Token: 0x060271FD RID: 160253 RVA: 0x00561DF9 File Offset: 0x0055FFF9
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700AD2D RID: 44333
		// (get) Token: 0x060271FE RID: 160254 RVA: 0x00561E02 File Offset: 0x00560002
		// (set) Token: 0x060271FF RID: 160255 RVA: 0x00561E0A File Offset: 0x0056000A
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700AD2E RID: 44334
		// (get) Token: 0x06027200 RID: 160256 RVA: 0x00561E13 File Offset: 0x00560013
		// (set) Token: 0x06027201 RID: 160257 RVA: 0x00561E1B File Offset: 0x0056001B
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700AD2F RID: 44335
		// (get) Token: 0x06027202 RID: 160258 RVA: 0x00561E24 File Offset: 0x00560024
		// (set) Token: 0x06027203 RID: 160259 RVA: 0x00561E2C File Offset: 0x0056002C
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700AD30 RID: 44336
		// (get) Token: 0x06027204 RID: 160260 RVA: 0x00561E35 File Offset: 0x00560035
		// (set) Token: 0x06027205 RID: 160261 RVA: 0x00561E3D File Offset: 0x0056003D
		public byte NullMask { get; set; }

		// Token: 0x06027206 RID: 160262 RVA: 0x00561E46 File Offset: 0x00560046
		public ISunSpiritLauncherT()
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

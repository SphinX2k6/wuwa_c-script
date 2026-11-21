using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005800 RID: 22528
	public class IFollowerShootT
	{
		// Token: 0x1700A307 RID: 41735
		// (get) Token: 0x06024702 RID: 149250 RVA: 0x00501F34 File Offset: 0x00500134
		// (set) Token: 0x06024703 RID: 149251 RVA: 0x00501F3C File Offset: 0x0050013C
		public EHookInteractType Type { get; set; }

		// Token: 0x1700A308 RID: 41736
		// (get) Token: 0x06024704 RID: 149252 RVA: 0x00501F45 File Offset: 0x00500145
		// (set) Token: 0x06024705 RID: 149253 RVA: 0x00501F4D File Offset: 0x0050014D
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700A309 RID: 41737
		// (get) Token: 0x06024706 RID: 149254 RVA: 0x00501F56 File Offset: 0x00500156
		// (set) Token: 0x06024707 RID: 149255 RVA: 0x00501F5E File Offset: 0x0050015E
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700A30A RID: 41738
		// (get) Token: 0x06024708 RID: 149256 RVA: 0x00501F67 File Offset: 0x00500167
		// (set) Token: 0x06024709 RID: 149257 RVA: 0x00501F6F File Offset: 0x0050016F
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700A30B RID: 41739
		// (get) Token: 0x0602470A RID: 149258 RVA: 0x00501F78 File Offset: 0x00500178
		// (set) Token: 0x0602470B RID: 149259 RVA: 0x00501F80 File Offset: 0x00500180
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700A30C RID: 41740
		// (get) Token: 0x0602470C RID: 149260 RVA: 0x00501F89 File Offset: 0x00500189
		// (set) Token: 0x0602470D RID: 149261 RVA: 0x00501F91 File Offset: 0x00500191
		public byte NullMask { get; set; }

		// Token: 0x0602470E RID: 149262 RVA: 0x00501F9A File Offset: 0x0050019A
		public IFollowerShootT()
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

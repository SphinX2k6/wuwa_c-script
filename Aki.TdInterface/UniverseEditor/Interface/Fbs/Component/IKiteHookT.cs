using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A3F RID: 23103
	public class IKiteHookT
	{
		// Token: 0x1700A80D RID: 43021
		// (get) Token: 0x06025C8C RID: 154764 RVA: 0x0052E346 File Offset: 0x0052C546
		// (set) Token: 0x06025C8D RID: 154765 RVA: 0x0052E34E File Offset: 0x0052C54E
		public EHookInteractType Type { get; set; }

		// Token: 0x1700A80E RID: 43022
		// (get) Token: 0x06025C8E RID: 154766 RVA: 0x0052E357 File Offset: 0x0052C557
		// (set) Token: 0x06025C8F RID: 154767 RVA: 0x0052E35F File Offset: 0x0052C55F
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700A80F RID: 43023
		// (get) Token: 0x06025C90 RID: 154768 RVA: 0x0052E368 File Offset: 0x0052C568
		// (set) Token: 0x06025C91 RID: 154769 RVA: 0x0052E370 File Offset: 0x0052C570
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700A810 RID: 43024
		// (get) Token: 0x06025C92 RID: 154770 RVA: 0x0052E379 File Offset: 0x0052C579
		// (set) Token: 0x06025C93 RID: 154771 RVA: 0x0052E381 File Offset: 0x0052C581
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700A811 RID: 43025
		// (get) Token: 0x06025C94 RID: 154772 RVA: 0x0052E38A File Offset: 0x0052C58A
		// (set) Token: 0x06025C95 RID: 154773 RVA: 0x0052E392 File Offset: 0x0052C592
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700A812 RID: 43026
		// (get) Token: 0x06025C96 RID: 154774 RVA: 0x0052E39B File Offset: 0x0052C59B
		// (set) Token: 0x06025C97 RID: 154775 RVA: 0x0052E3A3 File Offset: 0x0052C5A3
		public string HookDataAssetOverride { get; set; }

		// Token: 0x1700A813 RID: 43027
		// (get) Token: 0x06025C98 RID: 154776 RVA: 0x0052E3AC File Offset: 0x0052C5AC
		// (set) Token: 0x06025C99 RID: 154777 RVA: 0x0052E3B4 File Offset: 0x0052C5B4
		public bool SupportSwitchHookMidway { get; set; }

		// Token: 0x1700A814 RID: 43028
		// (get) Token: 0x06025C9A RID: 154778 RVA: 0x0052E3BD File Offset: 0x0052C5BD
		// (set) Token: 0x06025C9B RID: 154779 RVA: 0x0052E3C5 File Offset: 0x0052C5C5
		public byte NullMask { get; set; }

		// Token: 0x06025C9C RID: 154780 RVA: 0x0052E3CE File Offset: 0x0052C5CE
		public IKiteHookT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.HookDataAssetOverride = null;
			this.SupportSwitchHookMidway = false;
			this.NullMask = 0;
		}
	}
}

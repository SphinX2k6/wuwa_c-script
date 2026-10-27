using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B4E RID: 23374
	public class IWaterBoxBigWeaponHookT
	{
		// Token: 0x1700B082 RID: 45186
		// (get) Token: 0x06027F9D RID: 163741 RVA: 0x0057F2B0 File Offset: 0x0057D4B0
		// (set) Token: 0x06027F9E RID: 163742 RVA: 0x0057F2B8 File Offset: 0x0057D4B8
		public EHookInteractType Type { get; set; }

		// Token: 0x1700B083 RID: 45187
		// (get) Token: 0x06027F9F RID: 163743 RVA: 0x0057F2C1 File Offset: 0x0057D4C1
		// (set) Token: 0x06027FA0 RID: 163744 RVA: 0x0057F2C9 File Offset: 0x0057D4C9
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700B084 RID: 45188
		// (get) Token: 0x06027FA1 RID: 163745 RVA: 0x0057F2D2 File Offset: 0x0057D4D2
		// (set) Token: 0x06027FA2 RID: 163746 RVA: 0x0057F2DA File Offset: 0x0057D4DA
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700B085 RID: 45189
		// (get) Token: 0x06027FA3 RID: 163747 RVA: 0x0057F2E3 File Offset: 0x0057D4E3
		// (set) Token: 0x06027FA4 RID: 163748 RVA: 0x0057F2EB File Offset: 0x0057D4EB
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700B086 RID: 45190
		// (get) Token: 0x06027FA5 RID: 163749 RVA: 0x0057F2F4 File Offset: 0x0057D4F4
		// (set) Token: 0x06027FA6 RID: 163750 RVA: 0x0057F2FC File Offset: 0x0057D4FC
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700B087 RID: 45191
		// (get) Token: 0x06027FA7 RID: 163751 RVA: 0x0057F305 File Offset: 0x0057D505
		// (set) Token: 0x06027FA8 RID: 163752 RVA: 0x0057F30D File Offset: 0x0057D50D
		public byte NullMask { get; set; }

		// Token: 0x06027FA9 RID: 163753 RVA: 0x0057F316 File Offset: 0x0057D516
		public IWaterBoxBigWeaponHookT()
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

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A24 RID: 23076
	public class IItemLockingConfigT
	{
		// Token: 0x1700A7BC RID: 42940
		// (get) Token: 0x06025B36 RID: 154422 RVA: 0x0052AFC9 File Offset: 0x005291C9
		// (set) Token: 0x06025B37 RID: 154423 RVA: 0x0052AFD1 File Offset: 0x005291D1
		public string EffectPath { get; set; }

		// Token: 0x1700A7BD RID: 42941
		// (get) Token: 0x06025B38 RID: 154424 RVA: 0x0052AFDA File Offset: 0x005291DA
		// (set) Token: 0x06025B39 RID: 154425 RVA: 0x0052AFE2 File Offset: 0x005291E2
		public ETeleControlLockingPerform TeleControlPerform { get; set; }

		// Token: 0x1700A7BE RID: 42942
		// (get) Token: 0x06025B3A RID: 154426 RVA: 0x0052AFEB File Offset: 0x005291EB
		// (set) Token: 0x06025B3B RID: 154427 RVA: 0x0052AFF3 File Offset: 0x005291F3
		public byte NullMask { get; set; }

		// Token: 0x06025B3C RID: 154428 RVA: 0x0052AFFC File Offset: 0x005291FC
		public IItemLockingConfigT()
		{
			this.EffectPath = null;
			this.TeleControlPerform = ETeleControlLockingPerform.RightMatch;
			this.NullMask = 0;
		}
	}
}

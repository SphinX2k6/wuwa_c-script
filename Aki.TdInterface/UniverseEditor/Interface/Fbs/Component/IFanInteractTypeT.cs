using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057A0 RID: 22432
	public class IFanInteractTypeT
	{
		// Token: 0x1700A234 RID: 41524
		// (get) Token: 0x0602435B RID: 148315 RVA: 0x004FA622 File Offset: 0x004F8822
		// (set) Token: 0x0602435C RID: 148316 RVA: 0x004FA62A File Offset: 0x004F882A
		public EFanInteractType Type { get; set; }

		// Token: 0x0602435D RID: 148317 RVA: 0x004FA633 File Offset: 0x004F8833
		public IFanInteractTypeT()
		{
			this.Type = EFanInteractType.Hit;
		}
	}
}

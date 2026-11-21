using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059A6 RID: 22950
	public class IInitStateBirthT
	{
		// Token: 0x1700A6A4 RID: 42660
		// (get) Token: 0x060256AB RID: 153259 RVA: 0x0052211B File Offset: 0x0052031B
		// (set) Token: 0x060256AC RID: 153260 RVA: 0x00522123 File Offset: 0x00520323
		public EInitStateType Type { get; set; }

		// Token: 0x1700A6A5 RID: 42661
		// (get) Token: 0x060256AD RID: 153261 RVA: 0x0052212C File Offset: 0x0052032C
		// (set) Token: 0x060256AE RID: 153262 RVA: 0x00522134 File Offset: 0x00520334
		public string BirthTag { get; set; }

		// Token: 0x060256AF RID: 153263 RVA: 0x0052213D File Offset: 0x0052033D
		public IInitStateBirthT()
		{
			this.Type = EInitStateType.Birth;
			this.BirthTag = null;
		}
	}
}

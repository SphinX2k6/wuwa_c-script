using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005456 RID: 21590
	public class IInteractGearComponentT
	{
		// Token: 0x17009EF6 RID: 40694
		// (get) Token: 0x0602383D RID: 145469 RVA: 0x004E9E94 File Offset: 0x004E8094
		// (set) Token: 0x0602383E RID: 145470 RVA: 0x004E9E9C File Offset: 0x004E809C
		public bool Disabled { get; set; }

		// Token: 0x17009EF7 RID: 40695
		// (get) Token: 0x0602383F RID: 145471 RVA: 0x004E9EA5 File Offset: 0x004E80A5
		// (set) Token: 0x06023840 RID: 145472 RVA: 0x004E9EAD File Offset: 0x004E80AD
		public float NormalPrepareTime { get; set; }

		// Token: 0x17009EF8 RID: 40696
		// (get) Token: 0x06023841 RID: 145473 RVA: 0x004E9EB6 File Offset: 0x004E80B6
		// (set) Token: 0x06023842 RID: 145474 RVA: 0x004E9EBE File Offset: 0x004E80BE
		public float ActivePrepareTime { get; set; }

		// Token: 0x17009EF9 RID: 40697
		// (get) Token: 0x06023843 RID: 145475 RVA: 0x004E9EC7 File Offset: 0x004E80C7
		// (set) Token: 0x06023844 RID: 145476 RVA: 0x004E9ECF File Offset: 0x004E80CF
		public byte NullMask { get; set; }

		// Token: 0x06023845 RID: 145477 RVA: 0x004E9ED8 File Offset: 0x004E80D8
		public IInteractGearComponentT()
		{
			this.Disabled = false;
			this.NormalPrepareTime = 0f;
			this.ActivePrepareTime = 0f;
			this.NullMask = 0;
		}
	}
}

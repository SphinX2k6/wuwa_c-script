using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005396 RID: 21398
	public class IHitLogicChangeLockStateT
	{
		// Token: 0x17009D3D RID: 40253
		// (get) Token: 0x060230B6 RID: 143542 RVA: 0x004DA36A File Offset: 0x004D856A
		// (set) Token: 0x060230B7 RID: 143543 RVA: 0x004DA372 File Offset: 0x004D8572
		public EHitLogicType Type { get; set; }

		// Token: 0x060230B8 RID: 143544 RVA: 0x004DA37B File Offset: 0x004D857B
		public IHitLogicChangeLockStateT()
		{
			this.Type = EHitLogicType.ChangeNextState;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053A2 RID: 21410
	public class IHitLogicTypeT
	{
		// Token: 0x17009D4F RID: 40271
		// (get) Token: 0x06023118 RID: 143640 RVA: 0x004DAE6E File Offset: 0x004D906E
		// (set) Token: 0x06023119 RID: 143641 RVA: 0x004DAE76 File Offset: 0x004D9076
		public EHitLogicType Type { get; set; }

		// Token: 0x0602311A RID: 143642 RVA: 0x004DAE7F File Offset: 0x004D907F
		public IHitLogicTypeT()
		{
			this.Type = EHitLogicType.ChangeNextState;
		}
	}
}

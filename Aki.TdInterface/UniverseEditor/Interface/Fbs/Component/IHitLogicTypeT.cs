using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005928 RID: 22824
	public class IHitLogicTypeT
	{
		// Token: 0x1700A587 RID: 42375
		// (get) Token: 0x060251CC RID: 152012 RVA: 0x00517D42 File Offset: 0x00515F42
		// (set) Token: 0x060251CD RID: 152013 RVA: 0x00517D4A File Offset: 0x00515F4A
		public EHitLogicType Type { get; set; }

		// Token: 0x060251CE RID: 152014 RVA: 0x00517D53 File Offset: 0x00515F53
		public IHitLogicTypeT()
		{
			this.Type = EHitLogicType.ChangeNextState;
		}
	}
}

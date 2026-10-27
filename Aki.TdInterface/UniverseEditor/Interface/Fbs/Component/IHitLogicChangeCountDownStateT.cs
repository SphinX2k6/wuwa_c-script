using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005393 RID: 21395
	public class IHitLogicChangeCountDownStateT
	{
		// Token: 0x17009D3A RID: 40250
		// (get) Token: 0x060230A4 RID: 143524 RVA: 0x004DA1F2 File Offset: 0x004D83F2
		// (set) Token: 0x060230A5 RID: 143525 RVA: 0x004DA1FA File Offset: 0x004D83FA
		public EHitLogicType Type { get; set; }

		// Token: 0x060230A6 RID: 143526 RVA: 0x004DA203 File Offset: 0x004D8403
		public IHitLogicChangeCountDownStateT()
		{
			this.Type = EHitLogicType.ChangeNextState;
		}
	}
}

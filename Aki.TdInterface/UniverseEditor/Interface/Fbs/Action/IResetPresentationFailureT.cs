using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007631 RID: 30257
	public class IResetPresentationFailureT
	{
		// Token: 0x1700DE45 RID: 56901
		// (get) Token: 0x0603517D RID: 217469 RVA: 0x0072167D File Offset: 0x0071F87D
		// (set) Token: 0x0603517E RID: 217470 RVA: 0x00721685 File Offset: 0x0071F885
		public EResetPresentationType Type { get; set; }

		// Token: 0x1700DE46 RID: 56902
		// (get) Token: 0x0603517F RID: 217471 RVA: 0x0072168E File Offset: 0x0071F88E
		// (set) Token: 0x06035180 RID: 217472 RVA: 0x00721696 File Offset: 0x0071F896
		public float Duration { get; set; }

		// Token: 0x1700DE47 RID: 56903
		// (get) Token: 0x06035181 RID: 217473 RVA: 0x0072169F File Offset: 0x0071F89F
		// (set) Token: 0x06035182 RID: 217474 RVA: 0x007216A7 File Offset: 0x0071F8A7
		public List<int> GamePlayCues { get; set; }

		// Token: 0x06035183 RID: 217475 RVA: 0x007216B0 File Offset: 0x0071F8B0
		public IResetPresentationFailureT()
		{
			this.Type = EResetPresentationType.Failure;
			this.Duration = 0f;
			this.GamePlayCues = null;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DDD RID: 32221
	public class IVisualNovelRoleIntroductionConfigBaseT
	{
		// Token: 0x1700F169 RID: 61801
		// (get) Token: 0x0603A3BF RID: 238527 RVA: 0x007D920A File Offset: 0x007D740A
		// (set) Token: 0x0603A3C0 RID: 238528 RVA: 0x007D9212 File Offset: 0x007D7412
		public EVisualNovelSubType Type { get; set; }

		// Token: 0x0603A3C1 RID: 238529 RVA: 0x007D921B File Offset: 0x007D741B
		public IVisualNovelRoleIntroductionConfigBaseT()
		{
			this.Type = EVisualNovelSubType.SolarSchool;
		}
	}
}

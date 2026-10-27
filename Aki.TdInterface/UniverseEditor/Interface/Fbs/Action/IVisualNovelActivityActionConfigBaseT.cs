using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007551 RID: 30033
	public class IVisualNovelActivityActionConfigBaseT
	{
		// Token: 0x1700E3DE RID: 58334
		// (get) Token: 0x06036A54 RID: 223828 RVA: 0x0076C2D2 File Offset: 0x0076A4D2
		// (set) Token: 0x06036A55 RID: 223829 RVA: 0x0076C2DA File Offset: 0x0076A4DA
		public EVisualNovelSubType Type { get; set; }

		// Token: 0x06036A56 RID: 223830 RVA: 0x0076C2E3 File Offset: 0x0076A4E3
		public IVisualNovelActivityActionConfigBaseT()
		{
			this.Type = EVisualNovelSubType.SolarSchool;
		}
	}
}

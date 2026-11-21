using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004918 RID: 18712
	public class IFindSunSpiritGridBaseT
	{
		// Token: 0x1700825C RID: 33372
		// (get) Token: 0x0601BC15 RID: 113685 RVA: 0x003EC9AA File Offset: 0x003EABAA
		// (set) Token: 0x0601BC16 RID: 113686 RVA: 0x003EC9B2 File Offset: 0x003EABB2
		public EFindSunSpiritGridType Type { get; set; }

		// Token: 0x0601BC17 RID: 113687 RVA: 0x003EC9BB File Offset: 0x003EABBB
		public IFindSunSpiritGridBaseT()
		{
			this.Type = EFindSunSpiritGridType.Empty;
		}
	}
}

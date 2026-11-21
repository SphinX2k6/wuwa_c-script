using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F2A RID: 20266
	public class ICheckHonamiStorySuccessfulEvacuationT
	{
		// Token: 0x170090C0 RID: 37056
		// (get) Token: 0x0601F7FB RID: 129019 RVA: 0x00462458 File Offset: 0x00460658
		// (set) Token: 0x0601F7FC RID: 129020 RVA: 0x00462460 File Offset: 0x00460660
		public ECondition Type { get; set; }

		// Token: 0x170090C1 RID: 37057
		// (get) Token: 0x0601F7FD RID: 129021 RVA: 0x00462469 File Offset: 0x00460669
		// (set) Token: 0x0601F7FE RID: 129022 RVA: 0x00462471 File Offset: 0x00460671
		public bool IsSuccessful { get; set; }

		// Token: 0x0601F7FF RID: 129023 RVA: 0x0046247A File Offset: 0x0046067A
		public ICheckHonamiStorySuccessfulEvacuationT()
		{
			this.Type = ECondition.CompareVar;
			this.IsSuccessful = false;
		}
	}
}

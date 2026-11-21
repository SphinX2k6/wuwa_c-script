using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EA9 RID: 20137
	public class ICheckEncircleLevelCompleteT
	{
		// Token: 0x17008FAB RID: 36779
		// (get) Token: 0x0601F377 RID: 127863 RVA: 0x0045A1AA File Offset: 0x004583AA
		// (set) Token: 0x0601F378 RID: 127864 RVA: 0x0045A1B2 File Offset: 0x004583B2
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x17008FAC RID: 36780
		// (get) Token: 0x0601F379 RID: 127865 RVA: 0x0045A1BB File Offset: 0x004583BB
		// (set) Token: 0x0601F37A RID: 127866 RVA: 0x0045A1C3 File Offset: 0x004583C3
		public int EncircleLevelId { get; set; }

		// Token: 0x17008FAD RID: 36781
		// (get) Token: 0x0601F37B RID: 127867 RVA: 0x0045A1CC File Offset: 0x004583CC
		// (set) Token: 0x0601F37C RID: 127868 RVA: 0x0045A1D4 File Offset: 0x004583D4
		public bool IsCompleted { get; set; }

		// Token: 0x0601F37D RID: 127869 RVA: 0x0045A1DD File Offset: 0x004583DD
		public ICheckEncircleLevelCompleteT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.EncircleLevelId = 0;
			this.IsCompleted = false;
		}
	}
}

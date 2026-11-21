using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050C2 RID: 20674
	public class ICompleteCertainFishingEntrustT
	{
		// Token: 0x17009431 RID: 37937
		// (get) Token: 0x0602064B RID: 132683 RVA: 0x0047C886 File Offset: 0x0047AA86
		// (set) Token: 0x0602064C RID: 132684 RVA: 0x0047C88E File Offset: 0x0047AA8E
		public ECondition Type { get; set; }

		// Token: 0x17009432 RID: 37938
		// (get) Token: 0x0602064D RID: 132685 RVA: 0x0047C897 File Offset: 0x0047AA97
		// (set) Token: 0x0602064E RID: 132686 RVA: 0x0047C89F File Offset: 0x0047AA9F
		public int Id { get; set; }

		// Token: 0x17009433 RID: 37939
		// (get) Token: 0x0602064F RID: 132687 RVA: 0x0047C8A8 File Offset: 0x0047AAA8
		// (set) Token: 0x06020650 RID: 132688 RVA: 0x0047C8B0 File Offset: 0x0047AAB0
		public int Count { get; set; }

		// Token: 0x06020651 RID: 132689 RVA: 0x0047C8B9 File Offset: 0x0047AAB9
		public ICompleteCertainFishingEntrustT()
		{
			this.Type = ECondition.CompareVar;
			this.Id = 0;
			this.Count = 0;
		}
	}
}

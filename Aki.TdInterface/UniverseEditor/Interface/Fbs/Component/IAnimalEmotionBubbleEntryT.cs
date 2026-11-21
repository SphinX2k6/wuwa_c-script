using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053D1 RID: 21457
	public class IAnimalEmotionBubbleEntryT
	{
		// Token: 0x170097D9 RID: 38873
		// (get) Token: 0x06021851 RID: 137297 RVA: 0x0049F852 File Offset: 0x0049DA52
		// (set) Token: 0x06021852 RID: 137298 RVA: 0x0049F85A File Offset: 0x0049DA5A
		public string MontagePath { get; set; }

		// Token: 0x170097DA RID: 38874
		// (get) Token: 0x06021853 RID: 137299 RVA: 0x0049F863 File Offset: 0x0049DA63
		// (set) Token: 0x06021854 RID: 137300 RVA: 0x0049F86B File Offset: 0x0049DA6B
		public string EmotionName { get; set; }

		// Token: 0x06021855 RID: 137301 RVA: 0x0049F874 File Offset: 0x0049DA74
		public IAnimalEmotionBubbleEntryT()
		{
			this.MontagePath = null;
			this.EmotionName = null;
		}
	}
}

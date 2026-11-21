using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B28 RID: 31528
	public class ITalkOptionRogueRandomEventT
	{
		// Token: 0x1700EC20 RID: 60448
		// (get) Token: 0x06038C51 RID: 232529 RVA: 0x007AD60E File Offset: 0x007AB80E
		// (set) Token: 0x06038C52 RID: 232530 RVA: 0x007AD616 File Offset: 0x007AB816
		public ETalkOptionParamType Type { get; set; }

		// Token: 0x1700EC21 RID: 60449
		// (get) Token: 0x06038C53 RID: 232531 RVA: 0x007AD61F File Offset: 0x007AB81F
		// (set) Token: 0x06038C54 RID: 232532 RVA: 0x007AD627 File Offset: 0x007AB827
		public int OptionId { get; set; }

		// Token: 0x1700EC22 RID: 60450
		// (get) Token: 0x06038C55 RID: 232533 RVA: 0x007AD630 File Offset: 0x007AB830
		// (set) Token: 0x06038C56 RID: 232534 RVA: 0x007AD638 File Offset: 0x007AB838
		public byte NullMask { get; set; }

		// Token: 0x06038C57 RID: 232535 RVA: 0x007AD641 File Offset: 0x007AB841
		public ITalkOptionRogueRandomEventT()
		{
			this.Type = ETalkOptionParamType.QteSucceed;
			this.OptionId = 0;
			this.NullMask = 0;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C39 RID: 31801
	public class ITransitionPopupConfigT
	{
		// Token: 0x1700EE19 RID: 60953
		// (get) Token: 0x06039520 RID: 234784 RVA: 0x007BDA41 File Offset: 0x007BBC41
		// (set) Token: 0x06039521 RID: 234785 RVA: 0x007BDA49 File Offset: 0x007BBC49
		public float Duration { get; set; }

		// Token: 0x1700EE1A RID: 60954
		// (get) Token: 0x06039522 RID: 234786 RVA: 0x007BDA52 File Offset: 0x007BBC52
		// (set) Token: 0x06039523 RID: 234787 RVA: 0x007BDA5A File Offset: 0x007BBC5A
		public TTransitionPopupStyleUnion PopupStyle { get; set; }

		// Token: 0x1700EE1B RID: 60955
		// (get) Token: 0x06039524 RID: 234788 RVA: 0x007BDA63 File Offset: 0x007BBC63
		// (set) Token: 0x06039525 RID: 234789 RVA: 0x007BDA6B File Offset: 0x007BBC6B
		public byte NullMask { get; set; }

		// Token: 0x06039526 RID: 234790 RVA: 0x007BDA74 File Offset: 0x007BBC74
		public ITransitionPopupConfigT()
		{
			this.Duration = 0f;
			this.PopupStyle = null;
			this.NullMask = 0;
		}
	}
}

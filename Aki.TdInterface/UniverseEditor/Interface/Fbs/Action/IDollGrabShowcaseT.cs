using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006604 RID: 26116
	public class IDollGrabShowcaseT
	{
		// Token: 0x1700C20A RID: 49674
		// (get) Token: 0x0602D585 RID: 185733 RVA: 0x00636F7C File Offset: 0x0063517C
		// (set) Token: 0x0602D586 RID: 185734 RVA: 0x00636F84 File Offset: 0x00635184
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700C20B RID: 49675
		// (get) Token: 0x0602D587 RID: 185735 RVA: 0x00636F8D File Offset: 0x0063518D
		// (set) Token: 0x0602D588 RID: 185736 RVA: 0x00636F95 File Offset: 0x00635195
		public int ShowcaseEntityId { get; set; }

		// Token: 0x0602D589 RID: 185737 RVA: 0x00636F9E File Offset: 0x0063519E
		public IDollGrabShowcaseT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.ShowcaseEntityId = 0;
		}
	}
}

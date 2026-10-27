using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068BF RID: 26815
	public class IHandInHandInitiatorT
	{
		// Token: 0x1700C705 RID: 50949
		// (get) Token: 0x0602EC66 RID: 191590 RVA: 0x006625DF File Offset: 0x006607DF
		// (set) Token: 0x0602EC67 RID: 191591 RVA: 0x006625E7 File Offset: 0x006607E7
		public THandInHandInitiatorUnion Initiator { get; set; }

		// Token: 0x1700C706 RID: 50950
		// (get) Token: 0x0602EC68 RID: 191592 RVA: 0x006625F0 File Offset: 0x006607F0
		// (set) Token: 0x0602EC69 RID: 191593 RVA: 0x006625F8 File Offset: 0x006607F8
		public EHandType HandType { get; set; }

		// Token: 0x0602EC6A RID: 191594 RVA: 0x00662601 File Offset: 0x00660801
		public IHandInHandInitiatorT()
		{
			this.Initiator = null;
			this.HandType = EHandType.Left;
		}
	}
}

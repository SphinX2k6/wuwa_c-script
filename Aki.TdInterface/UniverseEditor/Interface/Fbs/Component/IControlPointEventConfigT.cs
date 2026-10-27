using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005028 RID: 20520
	public class IControlPointEventConfigT
	{
		// Token: 0x170094EE RID: 38126
		// (get) Token: 0x06020DFF RID: 134655 RVA: 0x004926A5 File Offset: 0x004908A5
		// (set) Token: 0x06020E00 RID: 134656 RVA: 0x004926AD File Offset: 0x004908AD
		public int Index { get; set; }

		// Token: 0x170094EF RID: 38127
		// (get) Token: 0x06020E01 RID: 134657 RVA: 0x004926B6 File Offset: 0x004908B6
		// (set) Token: 0x06020E02 RID: 134658 RVA: 0x004926BE File Offset: 0x004908BE
		public List<IActionInfoT> LeftInEventActions { get; set; }

		// Token: 0x170094F0 RID: 38128
		// (get) Token: 0x06020E03 RID: 134659 RVA: 0x004926C7 File Offset: 0x004908C7
		// (set) Token: 0x06020E04 RID: 134660 RVA: 0x004926CF File Offset: 0x004908CF
		public List<IActionInfoT> LeftOutEventActions { get; set; }

		// Token: 0x170094F1 RID: 38129
		// (get) Token: 0x06020E05 RID: 134661 RVA: 0x004926D8 File Offset: 0x004908D8
		// (set) Token: 0x06020E06 RID: 134662 RVA: 0x004926E0 File Offset: 0x004908E0
		public List<IActionInfoT> RightInEventActions { get; set; }

		// Token: 0x170094F2 RID: 38130
		// (get) Token: 0x06020E07 RID: 134663 RVA: 0x004926E9 File Offset: 0x004908E9
		// (set) Token: 0x06020E08 RID: 134664 RVA: 0x004926F1 File Offset: 0x004908F1
		public List<IActionInfoT> RightOutEventActions { get; set; }

		// Token: 0x170094F3 RID: 38131
		// (get) Token: 0x06020E09 RID: 134665 RVA: 0x004926FA File Offset: 0x004908FA
		// (set) Token: 0x06020E0A RID: 134666 RVA: 0x00492702 File Offset: 0x00490902
		public byte NullMask { get; set; }

		// Token: 0x06020E0B RID: 134667 RVA: 0x0049270B File Offset: 0x0049090B
		public IControlPointEventConfigT()
		{
			this.Index = 0;
			this.LeftInEventActions = null;
			this.LeftOutEventActions = null;
			this.RightInEventActions = null;
			this.RightOutEventActions = null;
			this.NullMask = 0;
		}
	}
}

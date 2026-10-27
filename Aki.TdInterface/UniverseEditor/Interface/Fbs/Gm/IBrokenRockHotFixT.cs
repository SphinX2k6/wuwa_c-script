using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200463D RID: 17981
	public class IBrokenRockHotFixT
	{
		// Token: 0x17007F98 RID: 32664
		// (get) Token: 0x0601B3C5 RID: 111557 RVA: 0x003E0632 File Offset: 0x003DE832
		// (set) Token: 0x0601B3C6 RID: 111558 RVA: 0x003E063A File Offset: 0x003DE83A
		public EGmCommand Type { get; set; }

		// Token: 0x0601B3C7 RID: 111559 RVA: 0x003E0643 File Offset: 0x003DE843
		public IBrokenRockHotFixT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
